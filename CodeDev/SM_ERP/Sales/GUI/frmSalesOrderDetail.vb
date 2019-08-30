Imports RTIS.CommonVB

Public Class frmSalesOrderDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccSalesOrderDetail

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmSalesOrderDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSalesOrderDetail
      mfrm.pFormController = New fccSalesOrderDetail(rDBConn)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmSalesOrderDetail
    Dim mfrmWanted As frmSalesOrderDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSalesOrderDetail
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.FormController.PrimaryKeyID = vPrimaryKeyID Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Public ReadOnly Property FormController As fccSalesOrderDetail
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmCustomerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pFormController.LoadObjects()
    LoadCombos()
    RefreshControls()
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))
    mVIs = clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboEstatusENUM, mVIs)
  End Sub

  Private Sub RefreshControls()
    Try

      With pFormController.SalesOrder
        txtSalesOrderID.Text = .OrderNo
        txtProjectName.Text = .ProjectName
        dteDateEntered.EditValue = .DateEntered
        dteFinishDate.EditValue = .FinishDate
        dteDueTime.EditValue = .DueTime
        txtVisibleNotes.Text = .VisibleNotes

        RTIS.Elements.clsDEControlLoading.SetDECombo(cboOrderTypeID, .OrderTypeID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboEstatusENUM, .OrderStatusENUM)

        If .Customer Is Nothing Then
          btnedCustomer.Text = ""
        Else
          FillCustomerDetail()

        End If

      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub



  Private Sub frmCustomerDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try

      UpdateObjects()
      pFormController.SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateObjects()
    With pFormController.SalesOrder
      .OrderNo = txtSalesOrderID.Text
      .ProjectName = txtProjectName.Text
      .DateEntered = dteDateEntered.DateTime
      .DueTime = dteDueTime.DateTime
      .FinishDate = dteFinishDate.DateTime
      .VisibleNotes = txtVisibleNotes.Text
      .OrderTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboOrderTypeID)
      .OrderStatusENUM = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboEstatusENUM)

    End With
  End Sub

  Private Sub btnedCustomer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnedCustomer.ButtonClick
    Try
      Dim mCustomerPicker As clsPickerCustomer
      Dim mcustomer As dmCustomer
      UpdateObjects()
      mCustomerPicker = New clsPickerCustomer(pFormController.GetCustomerList)
      mcustomer = frmPickerCustomer.OpenPickerSingle(mCustomerPicker)
      If mcustomer Is Nothing Then
        pFormController.SalesOrder.CustomerID = 0
        pFormController.SalesOrder.Customer = Nothing
      Else
        pFormController.SalesOrder.CustomerID = mcustomer.CustomerID
        pFormController.SalesOrder.Customer = mcustomer
        FillCustomerDetail()

      End If
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub FillCustomerDetail()

    Try
      With pFormController.SalesOrder
        btnedCustomer.Text = .Customer.CompanyName
        txtAccountRef.Text = .Customer.AccountRef
        txtMainTown.Text = .Customer.MainTown
        txtPaymentTermsType.Text = .Customer.PaymentTermsType
        txtSalesAreaID.Text = .Customer.SalesAreaID
        CustomerStatusID.Text = .Customer.CustomerStatusID

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

End Class