Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmSupplierDetail
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccSupplierDetail

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


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
    Dim mfrm As frmSupplierDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSupplierDetail
      mfrm.pFormController = New fccSupplierDetail(rDBConn)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub


  Public Shared Sub OpenFormModal(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmSupplierDetail = Nothing

    mfrm = New frmSupplierDetail
    mfrm.pFormController = New fccSupplierDetail(rDBConn)
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.ShowDialog()

  End Sub

  Public Shared Function GetNewSupplier(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase) As dmSupplier
    Dim mfrm As frmSupplierDetail = Nothing
    Dim mRetVal As dmSupplier = Nothing
    mfrm = New frmSupplierDetail
    mfrm.pFormController = New fccSupplierDetail(rDBConn)
    mfrm.FormController.PrimaryKeyID = 0
    mfrm.ShowDialog()

    If mfrm.FormController.Supplier.SupplierID <> 0 Then
      mRetVal = mfrm.pFormController.Supplier
    End If

    Return mRetVal
  End Function

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmSupplierDetail
    Dim mfrmWanted As frmSupplierDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSupplierDetail
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


  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Public ReadOnly Property FormController As fccSupplierDetail
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmSupplierDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      grdSupplierContact.DataSource = pFormController.Supplier.SupplierContacts
      grdPOInfo.DataSource = pFormController.PurchaseOrders
      LoadCombos()

      If mOK Then RefreshControls()

      ''If mOK Then SetupUserPermissions()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True


  End Sub


  Private Sub LoadCombos()
    Try
      RTIS.Elements.clsDEControlLoading.FillDEComboVI(UctAddress1.cboCountry, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))
      RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboPaymentTermsType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType))
      RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboPurchaseTermsType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PurchaseTermType))

      clsDEControlLoading.LoadGridLookUpEdit(Me.grdPOInfo, gvPOInfo.Columns("Category"), clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories)))
      clsDEControlLoading.LoadGridLookUpEdit(Me.grdPOInfo, gvPOInfo.Columns("Status"), clsEnumsConstants.EnumToVIs(GetType(ePurchaseOrderDueDateStatus)))
      clsDEControlLoading.LoadGridLookUpEdit(Me.grdPOInfo, gvPOInfo.Columns("PaymentStatus"), clsEnumsConstants.EnumToVIs(GetType(ePaymentStatus)))

      ''  clsDEControlLoading.LoadGridLookUpEdit(Me.grdPOInfo, gvPOInfo.Columns("Status"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.sta))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()
    ''pFormController.SaveObjects()
    If pFormController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
        Select Case mResponse
          Case MsgBoxResult.Yes
            mSaveRequired = True
            mRetVal = False
            ExitMode = Windows.Forms.DialogResult.Yes
          Case MsgBoxResult.No
            mSaveRequired = False
            mRetVal = True
            ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
          Case MsgBoxResult.Cancel
            mSaveRequired = False
            mRetVal = False
        End Select
      Else
        ExitMode = Windows.Forms.DialogResult.Yes
        mSaveRequired = True
        mRetVal = False
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.Ignore
      mSaveRequired = False
      mRetVal = True
    End If

    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then


        pFormController.SaveObjects()


        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  'Here put the fields
  Private Sub RefreshControls()
    With pFormController.Supplier

      lblSupplierID.Text = "ID:" & .SupplierID.ToString("00000")
      cboBankName.EditValue = .BankName
      txtSupplierReference.Text = .SupplierReferenceID
      txtCompanyName.Text = .CompanyName
      txtRazonSocial.Text = .RazonSocial
      txtRucNumber.Text = .Rucnumber
      ''txtMainAddress1.Text = .MainAddress1
      txtTelNo.Text = .TelNo
      txtEmail.Text = .Email
      txtWebUrl.Text = .WebURL
      txtAcountRef.Text = .AccountCode
      txtBancoIntermediario.Text = .BancoIntermediario
      txtSwift.Text = .Numero_SWIFT
      txtABA.Text = .Numero_ABA
      ''txtMainTown.Text = .MainTown
      txtCustomerNotes.Text = .Notes
      ''RTIS.Elements.clsDEControlLoading.SetDECombo(cboCountry, .SalesAreaID)
      RTIS.Elements.clsDEControlLoading.SetDECombo(cboPaymentTermsType, .PaymentTermsType)
      RTIS.Elements.clsDEControlLoading.SetDECombo(cboPurchaseTermsType, .PurchasingTermsType)
      rgEstatus.EditValue = .SupplierStatusID
      rgDefaultCurrency.EditValue = .DefaultCurrency

      UctAddress1.Address = .MainAddress
      UctAddress1.RefreshControls()

    End With
  End Sub

  Private Sub UpdateObjects()
    With pFormController.Supplier


      UctAddress1.UpdateObject()
      .MainAddress = UctAddress1.Address
      .BankName = cboBankName.EditValue

      .CompanyName = txtCompanyName.Text
      .SupplierReferenceID = txtSupplierReference.Text
      .CompanyName = txtCompanyName.Text
      .RazonSocial = txtRazonSocial.Text
      .Rucnumber = txtRucNumber.Text
      '' .MainAddress1 = txtMainAddress1.Text
      .TelNo = txtTelNo.Text
      .Email = txtEmail.Text
      .WebURL = txtWebUrl.Text
      .AccountCode = txtAcountRef.Text
      .BancoIntermediario = txtBancoIntermediario.Text
      .Numero_SWIFT = txtSwift.Text
      .Numero_ABA = txtABA.Text
      ''  .MainTown = txtMainTown.Text
      .Notes = txtCustomerNotes.Text
      ''.SalesAreaID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCountry)
      .PaymentTermsType = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboPaymentTermsType)
      .PurchasingTermsType = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboPurchaseTermsType)
      .SupplierStatusID = rgEstatus.EditValue

      .DefaultCurrency = rgDefaultCurrency.EditValue
      gvSupplierContacts.CloseEditor()
      gvSupplierContacts.UpdateCurrentRow()

    End With
  End Sub

  Private Sub frmSupplierDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub



  Private Sub frmSupplierDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If



  End Sub



  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
    If vWithCheck Then
      If CheckSave(True) Then 'Changed from False 20150206 !!!
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If

  End Sub

  Private Sub frmCustomerDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

  End Sub

  Private Sub bbtnSavenAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSavenAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btSave.ItemClick
    Try
      UpdateObjects()
      pFormController.SaveObjects()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub rgDefaultCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgDefaultCurrency.SelectedIndexChanged

    If rgDefaultCurrency.EditValue = eCurrency.Cordobas Then

      gvPOInfo.Columns("TotalNetValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      gvPOInfo.Columns("TotalNetValue").DisplayFormat.FormatString = "C$#,##0.00;;#"


    Else

      gvPOInfo.Columns("TotalNetValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      gvPOInfo.Columns("TotalNetValue").DisplayFormat.FormatString = "$#,##0.00;;#"

    End If
  End Sub
End Class