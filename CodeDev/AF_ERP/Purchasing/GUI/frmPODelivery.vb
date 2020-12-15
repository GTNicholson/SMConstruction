Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Public Class frmPODelivery
  Dim pFormController As fccPODelivery
  ''Dim pMaterialRequirementInfos As colMaterialRequirementInfos
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum

  Private Enum ePOIProcessorOption
    eProcess = 1
    eTimberPack = 2
    eProcessAll = 3
    ePrintPODelivery = 4
  End Enum

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdPurchaseOrderItemInfo, gcCategory, mVIs)

    clsDEControlLoading.FillDEComboVI(cboStatus, clsEnumsConstants.EnumToVIs(GetType(ePODelivery)))

  End Sub

  Public Property FormController() As fccPODelivery
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPODelivery)
      pFormController = value
    End Set
  End Property

  Public Sub New()

    ''pMaterialRequirementInfos = New colMaterialRequirementInfos
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsModal(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vPrimaryKey As Integer, ByVal vPOID As Integer, ByVal vMode As eFormMode)
    Dim mfrm As frmPODelivery = Nothing

    '' mfrm = GetFormIfLoaded()
    ''If mfrm Is Nothing Then
    mfrm = New frmPODelivery
    mfrm.FormMode = vMode
    '' mfrm.MdiParent = rMDIParent
    mfrm.pFormController = New fccPODelivery(rDBConn)
    mfrm.pFormController.PrimaryKey = vPrimaryKey
    If vPOID <> 0 Then
      mfrm.pFormController.PurchaseOrderID = vPOID
    End If

    mfrm.ShowDialog()
    ''Else
    ''mfrm.Focus()
    ''End If
  End Sub

  Private Shared Function GetFormIfLoaded() As frmPODelivery


    Dim mfrmWanted As frmPODelivery = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPODelivery
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPODelivery Then
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

  Private Sub SetUpUserPermissions()
    'If pFormController.DBConn.RTISUser.IsSecurityAllowAll Then
    ''If pFormController.PurchaseOrderInfo.Category = ePurchaseCategories.Timber Then
    ''  grpMaterialRequirements.CustomHeaderButtons(1).Properties.Visible = True
    ''  grpMaterialRequirements.CustomHeaderButtons(0).Properties.Visible = False
    ''Else
    ''  grpMaterialRequirements.CustomHeaderButtons(1).Properties.Visible = False
    ''  grpMaterialRequirements.CustomHeaderButtons(0).Properties.Visible = True

    ''End If
  End Sub

  Private Sub RefreshControls()

    Try

      If pFormController.PurchaseOrderInfo IsNot Nothing Then
        With pFormController.PurchaseOrderInfo
          btnSelectPurchaseOrder.Text = .PONum
          txtCategory.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(.Category, ePurchaseCategories))
          txtRequiredDate.Text = .RequiredDate
          txtSupplierCompanyName.Text = .CompanyName

          Select Case .PurchaseOrder.DefaultCurrency
            Case eCurrency.Cordobas
              txtDefaultCurrency.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCurrency), CType(.DefaultCurrency, eCurrency))
              txtDefaultCurrency.Text &= " (C$)"
              txtExchangeRate.Text = String.Format(New CultureInfo("es-NI"), "{0:c}", pFormController.PurchaseOrderInfo.ExchangeRateValue)
            Case eCurrency.Dollar
              txtDefaultCurrency.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCurrency), CType(.DefaultCurrency, eCurrency))

          End Select


        End With

        If pFormController.PODelivery IsNot Nothing Then

          With pFormController.PODelivery
            txtGRNNumber.Text = .GRNumber
            txtRefDocSupplier.Text = .RefSupplierDoc
            dteReceived.Text = .DateCreated
            SetReceivedValueWithCurrencyFormat() ' pFormController.GetReceivedValue()
            gcQtyToProcess.OptionsColumn.ReadOnly = False

            cboStatus.Properties.ReadOnly = False
            clsDEControlLoading.SetDECombo(cboStatus, .Status)

            If .GRNumber <> "" Then
              grpGRN.CustomHeaderButtons.Item(0).Properties.Enabled = False
              txtRefDocSupplier.ReadOnly = False
            Else
              txtRefDocSupplier.ReadOnly = True
            End If
          End With

        End If
        SetupReadOnly()
        SetUpUserPermissions()



      End If





    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Public Function SetReceivedValueWithCurrencyFormat()

    If pFormController.PurchaseOrderInfo.DefaultCurrency = eCurrency.Cordobas Then
      txtReceivedValue.Text = String.Format(New CultureInfo("es-NI"), "{0:c}", pFormController.GetReceivedValue)


    Else

      txtReceivedValue.Text = String.Format(New CultureInfo("en-US"), "{0:c}", pFormController.GetReceivedValue)


    End If

  End Function

  Private Sub SetupReadOnly()

    If txtGRNNumber.Text = "" Then

      grdPurchaseOrderItemInfo.Enabled = False
      grpMaterialRequirements.CustomHeaderButtons.Item(0).Properties.Visible = False
      ''grpMaterialRequirements.CustomHeaderButtons.Item(1).Properties.Visible = False
      grpMaterialRequirements.CustomHeaderButtons.Item(2).Properties.Visible = False
    Else

      grdPurchaseOrderItemInfo.Enabled = True
      grpMaterialRequirements.CustomHeaderButtons.Item(0).Properties.Visible = True
      ''grpMaterialRequirements.CustomHeaderButtons.Item(1).Properties.Visible = True
      grpMaterialRequirements.CustomHeaderButtons.Item(2).Properties.Visible = True
    End If

  End Sub

  Private Sub frmPurchaseOrderDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
    ''Add error patter for form load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    Try
      pFormController.LoadObjects()

      LoadCombos()

      'SetUpUserPermissions()

      RefreshGrid()


      RefreshControls()
      If txtGRNNumber.Text <> "" And btnSelectPurchaseOrder.Text <> "" Then
        btnSelectPurchaseOrder.Enabled = False



        '' pFormController.PODelivery = Nothing
      Else
        gcQtyToProcess.OptionsColumn.ReadOnly = True
      End If

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub




  Private Sub frmPickMaterials_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    Me.Dispose()


  End Sub

  Private Sub btnSelectProductionBatch_Click(sender As Object, e As EventArgs) Handles btnSelectPurchaseOrder.Click
    Dim mPickerPurchaseOrder As clsPickerPurchaseOrder
    Dim mPurchaseorderInfos As New colPurchaseOrderInfos
    Dim mPOI As clsPurchaseOrderInfo
    Dim mDialogResult As DialogResult
    mPurchaseorderInfos = pFormController.GetPurchaseOrderInfos

    mPickerPurchaseOrder = New clsPickerPurchaseOrder(mPurchaseorderInfos)


    mPOI = frmPickerPurchaseOrder.OpenPickerSingle(mPickerPurchaseOrder)

    If mPOI IsNot Nothing Then

      If pFormController.GetPODeliverysByPurchaseOrderID(mPOI.PurchaseOrderID) >= 1 Then
        mDialogResult = MessageBox.Show("Esta O.C. ya tiene una recepción, ¿Desea agregar otra recepción?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If mDialogResult = DialogResult.Yes Then
          pFormController.PurchaseOrderID = mPOI.PurchaseOrderID
          pFormController.PurchaseOrderInfo = mPOI
          If pFormController.PODelivery IsNot Nothing Then '// if we already have a podelivery then reset the purchase order id
            pFormController.PODelivery.PurchaseOrderID = mPOI.PurchaseOrderID
          End If

        ElseIf mDialogResult = DialogResult.No Then
          Exit Sub
        End If
      Else
        pFormController.PurchaseOrderID = mPOI.PurchaseOrderID
        pFormController.PurchaseOrderInfo = mPOI
        If pFormController.PODelivery IsNot Nothing Then '// if we already have a podelivery then reset the purchase order id
          pFormController.PODelivery.PurchaseOrderID = mPOI.PurchaseOrderID
        End If
      End If

      RefreshGrid()
      RefreshControls()
      UpdateObject()
    Else
      If pFormController.PODelivery IsNot Nothing Then
        pFormController.PODelivery.PurchaseOrderID = 0
      End If
    End If


  End Sub

  Private Sub UpdateObject()


    If pFormController.PODelivery IsNot Nothing Then
      With pFormController.PODelivery
        .GRNumber = txtGRNNumber.Text
        .PODeliveryValue = pFormController.GetReceivedValue
        .PurchaseOrder = pFormController.PurchaseOrderInfo.PurchaseOrder
        .PurchaseOrderID = pFormController.PurchaseOrderInfo.PurchaseOrder.PurchaseOrderID
        .Status = clsDEControlLoading.GetDEComboValue(cboStatus)
        .RefSupplierDoc = txtRefDocSupplier.Text
        .DateCreated = dteReceived.EditValue
      End With
    End If
  End Sub

  Private Sub RefreshGrid()
    pFormController.LoadPurchaseOrderItemAllocationProcessorss()
    grdPurchaseOrderItemInfo.DataSource = pFormController.PurchaseOrderProcessors
    gvMaterialRequirementInfos.RefreshData()

  End Sub

  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirements.CustomButtonClick
    Dim mOK As Boolean
    Dim mdsoPurchasing As New dsoPurchasing(pFormController.DBConn)
    Try
      UpdateObject()
      gvMaterialRequirementInfos.CloseEditor()
      gvMaterialRequirementInfos.UpdateCurrentRow()
      pFormController.SavePODelivery()

      Select Case e.Button.Properties.Tag


        Case ePOIProcessorOption.eProcess ''//Click on Process Button


          mOK = pFormController.ProcessDeliveryQtys(False)


          If mOK Then pFormController.CreatePurchaseOrderPDF(pFormController.PurchaseOrderInfo, pFormController.PurchaseOrderProcessors, pFormController.PODelivery, False)

          If File.Exists(pFormController.PODelivery.FileExport) Then
            ''  Process.Start(pFormController.PODelivery.FileExport)

          End If

        Case ePOIProcessorOption.eTimberPack

          pFormController.ProcessDeliveryQtys(True)

        Case ePOIProcessorOption.eProcessAll

          For Each mPOI As clsPurchaseOrderItemAllocationProcessor In pFormController.PurchaseOrderProcessors
            Dim mPendingValue As Decimal = 0
            mPendingValue = mPOI.Quantity - mPOI.ReceivedQty

            If mPendingValue > 0 Then
              mPOI.ToProcessQty = mPendingValue
              ''pFormController.ProcessDeliveryQtys(False)
            End If

          Next

        Case ePOIProcessorOption.ePrintPODelivery
          pFormController.CreatePurchaseOrderPDF(pFormController.PurchaseOrderInfo, pFormController.PurchaseOrderProcessors, pFormController.PODelivery, True)
      End Select

      pFormController.SavePODelivery()
      gvMaterialRequirementInfos.RefreshData()

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    ''pFormController.LoadMaterialRequirementProcessorss()
    ''grdPurchaseOrderItemInfo.DataSource = pFormController.MaterialRequirementProcessors
  End Sub


  Private Sub GroupControl2_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpGRN.CustomButtonClick
    Select Case e.Button.Properties.Tag

      Case "Raise"
        UpdateObject()

        pFormController.RaisePODelivery()

        RefreshControls()
        UpdateObject()
        pFormController.SavePODelivery()
      Case "Edit"

      Case "Save"
        UpdateObject()
        pFormController.SavePODelivery()
        ''pFormController.PODelivery = Nothing
    End Select
  End Sub

  Private Sub grpPOPicking_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpPOPicking.CustomButtonClick

  End Sub

  Private Sub frmPurchaseOrderDelivery_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()

    If pFormController.IsDirty Then
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
        mRetVal = pFormController.SavePODelivery
        'TODO - If mRetVal then AddHandler InstanceData to  BrowseTracker
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub frmPurchaseOrderDelivery_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub


End Class
