﻿Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmGeneralPurchaseOrder
  Private pFormController As fccPurchaseOrder
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False
  Private pPOIEditor As clsPOItemEditor
  Private pcolPOIEditor As colPOItemEditors
  Private pSupplier As dmSupplier
  Dim pActiveEditor As DevExpress.XtraEditors.PopupContainerEdit

  Private Enum eWorkOrder
    PickWO = 1

  End Enum

  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode)
    Dim mfrm As frmGeneralPurchaseOrder = Nothing
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    '' Add code here if need to check if a Detail Form for this ID is already open
    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmGeneralPurchaseOrder
      mfrm.FormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
      mfrm.FormController.DBConn = rUserSession.CreateMainDBConn
      mfrm.FormController.RTISGlobal = rRTISGlobal
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID

      mfrm.FormMode = vFormMode
      ''If vPrimaryKeyID = 0 Then
      ''  mfrm.FormMode = eFormMode.eFMFormModeAdd
      ''Else
      ''  mfrm.FormMode = eFormMode.eFMFormModeEdit
      ''End If

      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub



  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI, ByVal vPOOption As ePODetailOption)
    Dim mfrm As frmGeneralPurchaseOrder = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmGeneralPurchaseOrder
      mfrm.pFormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.FormController.POOption = vPOOption
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub



  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode)
    Dim mfrm As New frmGeneralPurchaseOrder
    mfrm.FormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
    mfrm.FormController.DBConn = rDBConn
    mfrm.FormController.RTISGlobal = rRTISGlobal
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.FormMode = vFormMode
    mfrm.Owner = rParentForm
    mfrm.ShowDialog()
    If mfrm.ExitMode = Windows.Forms.DialogResult.Yes Then
      ''vPrimaryKeyID = mfrm.FormController.PrimaryKeyID - Problem with .FormController being set to nothing
    End If
    mfrm.FormController = Nothing
    mfrm.Owner = Nothing
    mfrm.Dispose()
    mfrm = Nothing
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmGeneralPurchaseOrder
    Dim mfrmWanted As frmGeneralPurchaseOrder = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmGeneralPurchaseOrder
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

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub frmDetailForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

  End Sub

  Private Sub frmDetailForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    FormController.UpdateCOMOs()
    FormController.ClearObjects()
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Public Property FormController() As fccPurchaseOrder
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPurchaseOrder)
      pFormController = value
    End Set
  End Property

  Private Sub frmDetailForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub frmDetailForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

  End Sub

  Private Sub frmDetailForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try
      pSupplier = New dmSupplier

      If mOK Then mOK = pFormController.LoadObject()
      If mOK Then mOK = pFormController.LoadRefData()
      ConfigureFileControl()
      pFormController.LoadSuppliers()

      LoadCombos()
      RefreshControls()
      RefreshGrid()
      pFormController.CompanyOption = repPurchaseOrder.eCompanyOption.Agro
      rgCompanyOption.EditValue = CType(pFormController.CompanyOption, System.Int32)

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

  Private Sub RefreshGrid()
    'pFormController.LoadObject()
    grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems ''.POItemsMinusAllocatedItem
    pFormController.UpdatePercentageValue(Val(txtRetentionPercentage.EditValue))
    gvPurchaseOrderItems.RefreshData()
    pFormController.LoadPODeliveryInfos()
    grdPODeliveryInfos.DataSource = pFormController.PODeliveryInfos

  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboStatus, clsEnumsConstants.EnumToVIs(GetType(ePurchaseOrderDueDateStatus)))
    clsDEControlLoading.FillDEComboVI(cboStage, clsEnumsConstants.EnumToVIs(GetType(ePOStage)))
    clsDEControlLoading.FillDEComboVI(cboValuationMode, clsEnumsConstants.EnumToVIs(GetType(eValuationMode)))


    clsDEControlLoading.FillDEComboVI(cboCategory, clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories)))
    clsDEControlLoading.LoadGridLookUpEdit(grdPurchaseOrderItems, gcCoCType, clsEnumsConstants.EnumToVIs(GetType(eCOCType)))
    clsDEControlLoading.FillDEComboVI(cboBuyer, pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdPurchaseOrderItems, gcVATRateCode, pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.VATRate))

    clsDEControlLoading.FillDEComboVI(cboPaymentMethod, clsEnumsConstants.EnumToVIs(GetType(ePaymentMethod)))
    clsDEControlLoading.LoadGridLookUpEdit(grdPurchaseOrderItems, gcUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))
    clsDEControlLoading.FillDEComboVI(cboAccountingCategory, pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.AccoutingCategory))
    dteDateOfOrder.Properties.NullDate = Date.MinValue
    dteDueDate.Properties.NullDate = Date.MinValue
    dtePaymentDate.Properties.NullDate = Date.MinValue
    grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems ''.POItemsMinusAllocatedItem
    LoadPOItemAllocationCombo()
  End Sub

  Private Sub LoadPOItemAllocationCombo()
    Dim mCallOffVIs As New colValueItems
    mCallOffVIs.AddNewItem(0, "A Inventario")

    For Each mSOPII As clsSalesOrderPhaseItemInfo In pFormController.SalesOrderPhaseItemInfos
      mCallOffVIs.AddNewItem(mSOPII.SalesOrderPhaseItemID, mSOPII.ItemNumber & "/" & mSOPII.Description)
    Next

    clsDEControlLoading.LoadGridLookUpEdit(grdPurchaseOrderItemAllocationSalesOrderPhaseItem, gvPurchaseOrderItemAllocationSalesOrderPhaseItem.Columns("SalesorderPhaseItemID"), mCallOffVIs)

  End Sub

  Private Sub SetupUserPermissions()
    'Dim mPermisionLevel As ePermissionCode
    'mPermisionLevel = pDBConn.RTISUser.ActivityPermissions.GetActivityPermission(eActivityCode.UserConfig)


  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Public Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()
    'pFormController.SaveObjects()
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
        pFormController.SaveObject()
        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal


  End Function

  Public Sub RefreshControls()
    Dim mStartActive As Boolean = pIsActive

    Try


      pIsActive = False
      With pFormController.PurchaseOrder
        Me.Text = "OC: " & .PONum
        UctFileControl1.LoadControls()
        UctFileControl1.RefreshControls()
        uctDeliveryAddress.Address = .DeliveryAddress
        uctDeliveryAddress.RefreshControls()
        txtRetentionPercentage.EditValue = .RetentionPercentage
        dteDateOfOrder.EditValue = .SubmissionDate
        txtCarriage.Text = .Carriage
        txtComments.Text = .Comments
        pSupplier = pFormController.Suppliers.ItemFromKey(.SupplierID)
        txtSupplierRef.Text = .SupplierRef
        btePONum.EditValue = .PONum
        txtSupplierRef.Text = .SupplierRef

        'dteDateEntered.EditValue = .DateEntered
        dteDueDate.EditValue = clsGeneralA.DateToDBValue(.RequiredDate)
        dtePaymentDate.EditValue = .PaymentDate
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboPaymentMethod, .PaymentMethod)

        RTIS.Elements.clsDEControlLoading.SetDECombo(cboCategory, .Category)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboAccountingCategory, .AccoutingCategoryID)

        RTIS.Elements.clsDEControlLoading.SetDECombo(cboBuyer, .BuyerID)
        clsDEControlLoading.SetDECombo(cboStatus, .Status)
        clsDEControlLoading.SetDECombo(cboStage, .POStage)
        clsDEControlLoading.SetDECombo(cboValuationMode, .ValuationMode)


        '' RTIS.Elements.clsDEControlLoading.SetDECombo(cboCountry, .DeliveryAddress.Country)
        txtExchangeValue.Text = .ExchangeRateValue



        rgDefaultCurrency.EditValue = CInt(pFormController.CurrentDefaultCurrency)

        btnEditPurchaseOrderPDF.Text = .FileName

        txtNetValue.Text = pFormController.GetTotalNetValue().ToString("n2")

        If pSupplier IsNot Nothing Then
          btedSupplier.Text = pSupplier.CompanyName
          FillSupplierDetail()
        Else


        End If


        '// Set the purchasereqtype mode buttons
        Select Case .MaterialRequirementTypeID

          'Case ePOMaterialRequirementType.Sencillo
          '  grpPOMaterialType.CustomHeaderButtons(0).Properties.Checked = True
          '  grpPOMaterialType.CustomHeaderButtons(1).Properties.Checked = False

          '  If pFormController.SalesOrderPhaseItemInfo IsNot Nothing Then
          '    btedSOPhase.Text = pFormController.SalesOrderPhaseItemInfo.ItemNumberRef & "/" & pFormController.SalesOrderPhaseItemInfo.Description
          '    txtProjectName.Text = pFormController.SalesOrderPhaseItemInfo.ProjectName
          '    txtCustomerName.Text = pFormController.SalesOrderPhaseItemInfo.CompanyName
          '    dteDateRequired.EditValue = pFormController.SalesOrderPhaseItemInfo.DateRequired
          '  End If



          'Case ePOMaterialRequirementType.Multiple
          '  grpPOMaterialType.CustomHeaderButtons(0).Properties.Checked = False
          '  grpPOMaterialType.CustomHeaderButtons(1).Properties.Checked = True

        End Select


      End With


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    pIsActive = mStartActive
  End Sub

  Private Sub FillSupplierDetail()

    Try
      With pFormController.PurchaseOrder.Supplier

        UctAddress1.Address = .MainAddress
        UctAddress1.RefreshControls()

        If pFormController.PurchaseOrder.Supplier.IsRetention Then

          txtRetentionPercentage.Visible = True
          lblRetention.Visible = True
        Else
          txtRetentionPercentage.Visible = False
          lblRetention.Visible = False
        End If
        ''  RTIS.Elements.clsDEControlLoading.FillDEComboVI(UctAddress1.cboCountry, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))

        ''txtAddress1.Text = .Supplier.MainAddress1
        ''RTIS.Elements.clsDEControlLoading.SetDECombo(cboCountry, .Supplier.SalesAreaID)
        ''txtTown.Text = .Supplier.MainTown
        ''btedSupplier.Text = .Supplier.CompanyName
        ''CustomerStatusID.Text = .Customer.CustomerStatusID

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub UpdateObject()
    With pFormController.PurchaseOrder

      With .Supplier
        UctAddress1.UpdateObject()
        .MainAddress = UctAddress1.Address
      End With

      .PaymentMethod = clsDEControlLoading.GetDEComboValue(cboPaymentMethod)
      .SubmissionDate = dteDateOfOrder.EditValue
      .RequiredDate = dteDueDate.DateTime
      .PaymentDate = dtePaymentDate.EditValue
      .Category = clsDEControlLoading.GetDEComboValue(cboCategory)
      .Status = clsDEControlLoading.GetDEComboValue(cboStatus)
      .POStage = clsDEControlLoading.GetDEComboValue(cboStage)
      .ValuationMode = clsDEControlLoading.GetDEComboValue(cboValuationMode)
      .RetentionPercentage = txtRetentionPercentage.EditValue
      .AccoutingCategoryID = clsDEControlLoading.GetDEComboValue(cboAccountingCategory)
      .Carriage = Val(txtCarriage.EditValue)
      '' .DeliveryAddress.Country = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCountry)
      .SupplierRef = txtSupplierRef.Text
      .Comments = txtComments.Text
      .TotalNetValue = pFormController.GetTotalNetValue()
      uctDeliveryAddress.UpdateObject()
      gvPurchaseOrderItems.CloseEditor()
      gvPurchaseOrderItems.UpdateCurrentRow()

      .ExchangeRateValue = Val(txtExchangeValue.Text)

      .BuyerID = clsDEControlLoading.GetDEComboValue(cboBuyer)
      pFormController.PurchaseOrder.DefaultCurrency = pFormController.CurrentDefaultCurrency
      .DeliveryAddress = uctDeliveryAddress.Address

      Select Case .MaterialRequirementTypeID
        Case ePOMaterialRequirementType.Sencillo

          If pFormController.SalesOrderPhaseItemInfo IsNot Nothing Then
            .RefMatType = pFormController.SalesOrderPhaseItemInfo.Description
          End If

        Case ePOMaterialRequirementType.Inventario
          pFormController.PurchaseOrder.RefMatType = "Ninguno"

        Case ePOMaterialRequirementType.Multiple
          pFormController.PurchaseOrder.RefMatType = "Múltiple"
      End Select

      If .DeliveryAddress IsNot Nothing Then
        If .DeliveryAddress.IsDirty Then
          .IsDirty = True
        End If
      End If

      If .SupplierAddress IsNot Nothing Then
        If .SupplierAddress.IsDirty Then
          .IsDirty = True
        End If
      End If

      If .InvoiceAddress IsNot Nothing Then
        If .InvoiceAddress.IsDirty Then
          .IsDirty = True
        End If
      End If

      gvPurchaseOrderItems.CloseEditor()
      grdPurchaseOrderItems.Update()

      gvPurchaseOrderItemAllocationSalesOrderPhaseItem.CloseEditor()
      grdPurchaseOrderItemAllocationSalesOrderPhaseItem.Update()

    End With



  End Sub

  Private Sub ConfigureFileControl()
    Dim mFileDirectory As String



    mFileDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.PurchaseOrderFileFolderSys, pFormController.PurchaseOrder.SubmissionDate.Year, clsGeneralA.GetFileSafeName(pFormController.PurchaseOrder.PurchaseOrderID.ToString("00000")))

    UctFileControl1.UserController = New uccFileControl(Me)
    UctFileControl1.UserController.Directory = mFileDirectory
    UctFileControl1.UserController.FileTrackers = pFormController.PurchaseOrder.POFiles
    UctFileControl1.UserController.ConfigSystemWatcher()


  End Sub


  ''Private Sub ControlForceValidateExample()
  ''  '' knock on effects of a property/control change - example event template
  ''  Try
  ''    If pIsActive Then
  ''      UpdateObject()
  ''
  ''      ''Knock-on effects
  ''
  ''      RefreshControls()
  ''    End If
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''  End Try
  ''End Sub

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

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub




  Private Sub barbtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Protected Overrides Sub Finalize()
    If FormController IsNot Nothing Then FormController = Nothing
    MyBase.Finalize()
  End Sub


  Private Sub bbiPrintPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    'Dim mPOInfo As New clsPurchaseOrderInfo
    'Dim mPOItemInfos As New colPOItemInfos
    'Dim mBuyer As clsEmployee
    'Dim mEmployees As colEmployees
    'Try
    '  UpdateObject()
    '  mPOInfo.PurchaseOrder = pFormController.PurchaseOrder
    '  For Each mPOItem As dmPurchaseOrderItem In pFormController.PurchaseOrder.PurchaseOrderItems
    '    If String.IsNullOrEmpty(mPOItem.Description) = False Then
    '      mPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
    '    End If
    '  Next

    '  mEmployees = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.Employee)
    '  mBuyer = mEmployees.ItemFromKey(pFormController.PurchaseOrder.BuyerID)

    '  repPurchaseOrder.CreateReport(mPOInfo, mPOItemInfos, mBuyer, True)

    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    'End Try
  End Sub



  Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try

      UpdateObject()
      pFormController.SaveObject()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btedSupplier_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btedSupplier.ButtonClick
    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Combo
          Dim mSupplierPicker As clsPickerSupplier
          ''  Dim mSupplier As dmSupplier

          mSupplierPicker = New clsPickerSupplier(pFormController.GetSupplierList, pFormController.DBConn)
          pSupplier = frmPickSupplier.OpenPickerSingle(mSupplierPicker)
          If pSupplier IsNot Nothing Then
            pFormController.PurchaseOrder.SupplierID = pSupplier.SupplierID
            pFormController.PurchaseOrder.Supplier = pSupplier
            pFormController.CurrentDefaultCurrency = pSupplier.DefaultCurrency
            rgDefaultCurrency.EditValue = CInt(pFormController.CurrentDefaultCurrency)

            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If

        Case ButtonPredefines.Ellipsis
          frmSupplierDetail.OpenFormModal(pFormController.PurchaseOrder.SupplierID, pFormController.DBConn)
          If pFormController.PurchaseOrder.SupplierID <> 0 Then
            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If

      End Select

      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub btnEditPurchaseOrderPDF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnEditPurchaseOrderPDF.ButtonClick
    Try

      ''UpdateObject()
      ''Select Case e.Button.Kind
      ''  Case ButtonPredefines.Plus

      ''    AddPurchaseOrderDocument()
      ''    RefreshControls()
      ''End Select
      ''RefreshControls()


      UpdateObject()
      For Each mPOI In pFormController.PurchaseOrder.PurchaseOrderItems
        pFormController.CreateUpdatePOItemAllocation(mPOI, True)

      Next

      Select Case e.Button.Kind
        Case ButtonPredefines.Plus


          If ckeAccountOrder.Checked Then
            pFormController.CreatePurchaseOrderPDF(pFormController.CurrentDefaultCurrency, pFormController.PurchaseOrder.Supplier.PrintAccountOption, True, pFormController.CompanyOption)
          Else
            pFormController.CreatePurchaseOrderPDF(pFormController.CurrentDefaultCurrency, pFormController.PurchaseOrder.Supplier.PrintAccountOption, False, pFormController.CompanyOption)

          End If



          If File.Exists(pFormController.PurchaseOrder.FileName) Then
            Process.Start(pFormController.PurchaseOrder.FileName)
          End If

        Case ButtonPredefines.Delete
          If File.Exists(pFormController.PurchaseOrder.FileName) Then File.Delete(pFormController.PurchaseOrder.FileName)
          pFormController.PurchaseOrder.FileName = ""
        Case ButtonPredefines.Ellipsis
          If File.Exists(pFormController.PurchaseOrder.FileName) Then

            Process.Start(pFormController.PurchaseOrder.FileName)
          End If
      End Select
      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  ''Public Sub AddPurchaseOrderDocument()
  ''  Dim mValidate As clsValidate
  ''  Dim mReport As repPurchaseOrder_bk
  ''  Dim mFilePath As String

  ''  mValidate = pFormController.ValidateObject()
  ''  If mValidate.ValOk Then

  ''    CheckSave(False)

  ''    mReport = GetReport(eDocumentType.PurchaseOrder)

  ''    CreateReportPDF(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, True, mReport)

  ''    CheckSave(False)

  ''    mFilePath = pFormController.PurchaseOrder.OutputDocuments.GetFilePath(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, eFileType.PDF)

  ''    RefreshControls()
  ''    If IO.File.Exists(mFilePath) Then
  ''      frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
  ''      pFormController.PurchaseOrder.
  ''    End If
  ''    mReport.ClearImages()
  ''    mReport.Dispose()
  ''  Else
  ''    MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
  ''  End If

  ''End Sub

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.PurchaseOrder.PurchaseOrderID

    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PurchaseOrderFileFolderSys, pFormController.PurchaseOrder.RequiredDate.Year, clsGeneralA.GetFileSafeName(pFormController.PurchaseOrder.PurchaseOrderID.ToString("00000")))

    mFileName &= ".pdf"
    mFileName = clsGeneralA.GetFileSafeName(mFileName)

    mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
    If IO.Directory.Exists(mExportDirectory) = False Then
      IO.Directory.CreateDirectory(mExportDirectory)
    End If

    mFilePath = IO.Path.Combine(mExportDirectory, mFileName)
    If IO.File.Exists(mFilePath) Then
      If vOverride = False Then If MsgBox("Por favor, confirme que desea volver a crear el PDF", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    End If

    ' mReport = CreateReport(vDocumentType)
    If vReport IsNot Nothing Then


      ''vReport.ExportToPdf(mFilePath, mExportOptions)
      pFormController.CreatePurchaseOrderPack(vReport, mFilePath)

      vReport.Dispose()
      'vReport = Nothing

      pFormController.PurchaseOrder.OutputDocuments.SetFilePath(eParentType.PurchaseOrder, vDocumentType, eFileType.PDF, mFilePath)

    End If

  End Sub
  ''Public Function GetReport(ByVal vDocType As eDocumentType) As DevExpress.XtraReports.UI.XtraReport
  ''  Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing
  ''  Dim mPOs As New colPurchaseOrders

  ''  Select Case vDocType
  ''    Case eDocumentType.PurchaseOrder

  ''      If pFormController.PurchaseOrder IsNot Nothing Then
  ''        mRetVal = repPurchaseOrder.GenerateReport(pFormController.PurchaseOrder)
  ''      End If

  ''  End Select

  ''  Return mRetVal
  ''End Function



  Private Sub gpnlPOItems_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpnlPOItems.CustomButtonClick
    Dim mSelectedItem As dmStockItem
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOItemEditor As clsPOItemEditor
    Dim mTest As New colPOItemEditors

    Dim mPicker As clsPickerStockItem
    Dim mStockItems As New colStockItems
    Dim mStockItem As dmStockItem
    Dim mSelectedStockItems As colStockItems
    Dim mExchangeRate As Decimal = 0
    Try

      Select Case e.Button.Properties.Tag
        Case "AddStockItem"


          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
            mStockItems.Add(mItem.Value)
          Next

          mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, pFormController.RTISGlobal)

          For Each mPOItem In pFormController.PurchaseOrder.PurchaseOrderItems ''.POItemsMinusAllocatedItem
            If mPOItem.StockItemID > 0 Then
              mStockItem = mStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                mPicker.SelectedObjects.Add(mStockItem)
              End If
            End If
          Next

          frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, pFormController.RTISGlobal, False, -1)
          For Each mSelectedItem In mPicker.SelectedObjects
            If mSelectedItem IsNot Nothing Then
              mPOItem = pFormController.PurchaseOrder.PurchaseOrderItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mPOItem Is Nothing Then
                mPOItem = clsPurchaseHandler.AddPOItem(pFormController.PurchaseOrder)
                mPOItem.StockItemID = mSelectedItem.StockItemID
                mPOItem.Description = mSelectedItem.Description
                mPOItem.PartNo = mSelectedItem.PartNo
                mPOItem.StockCode = mSelectedItem.StockCode

                ''Set the UnitPrice as per DefaultCuurency
                If pFormController.CurrentDefaultCurrency = eCurrency.Cordobas Then
                  mPOItem.UnitPrice = mSelectedItem.AverageCost

                Else
                  mExchangeRate = pFormController.GetExchangeRate(Now, eCurrency.Cordobas)
                  mPOItem.UnitPrice = mSelectedItem.AverageCost / mExchangeRate

                End If
                mPOItem.UoM = mSelectedItem.SupplierUoM
                mPOItem.SupplierCode = mSelectedItem.AuxCode
                pPOIEditor = New clsPOItemEditor(pFormController.PurchaseOrder, mPOItem)
                pFormController.POIEditors.Add(pPOIEditor)
              End If
            End If
          Next

          mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

          For mindex As Integer = pFormController.PurchaseOrder.PurchaseOrderItems.Count - 1 To 0 Step -1
            mPOItem = pFormController.PurchaseOrder.PurchaseOrderItems(mindex)
            If mPOItem.StockItemID > 0 Then
              mStockItem = mSelectedStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                pFormController.PurchaseOrder.PurchaseOrderItems.Remove(mPOItem)
              End If
            End If
          Next



          grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems

        Case "DeleteItem"

          mPOItem = gvPurchaseOrderItems.GetFocusedRow
          If mPOItem IsNot Nothing Then
            If MsgBox("¿Está seguro que desea eliminar este ítem de la compra?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Artículo") Then
              pFormController.PurchaseOrder.PurchaseOrderItems.Remove(mPOItem)
              grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems

            End If
          End If

        Case "ManualItem"

          mPOItem = New dmPurchaseOrderItem
          pFormController.PurchaseOrder.PurchaseOrderItems.Add(mPOItem)
          grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems


        Case "ProcessManualItem"

          pFormController.SaveObject()

          pFormController.ProcessManualItem()
          pFormController.ReloadPODeliveryInfos()
          grdPODeliveryInfos.DataSource = pFormController.PODeliveryInfos
          grdPODeliveryInfos.RefreshDataSource()

          pFormController.ReloadPOItems()

          grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
          grdPurchaseOrderItems.RefreshDataSource()


      End Select



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub btePONum_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btePONum.ButtonClick
    Select Case e.Button.Kind
      Case ButtonPredefines.Plus
        If pFormController.PurchaseOrder.PONum = "" Then
          pFormController.GetNextPONo()
        End If

        RefreshControls()
    End Select


  End Sub

  Private Sub repoPopPutWorkOrderQty_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repoPopupSalesOrderPhaseItem.QueryPopUp
    Dim mRow As dmPurchaseOrderItem
    'gvPurchaseOrderItems.CloseEditor()
    mRow = gvPurchaseOrderItems.GetFocusedRow
    If mRow IsNot Nothing Then
      grdPurchaseOrderItemAllocationSalesOrderPhaseItem.DataSource = mRow.PurchaseOrderItemAllocations
    End If
  End Sub

  Private Sub repoPopPutWorkOrderQty_CloseUp(sender As Object, e As CloseUpEventArgs) Handles repoPopupSalesOrderPhaseItem.CloseUp
    Dim mRow As dmPurchaseOrderItem
    'gvPurchaseOrderItems.CloseEditor()
    mRow = gvPurchaseOrderItems.GetFocusedRow
    If mRow IsNot Nothing Then

      gvPurchaseOrderItemAllocationSalesOrderPhaseItem.CloseEditor()
      UpdateObject()
      mRow.QtyRequired = mRow.TotalQuantityAllocated
      gvPurchaseOrderItems.RefreshData()

      RefreshControls()

    End If
  End Sub

  Private Sub repoPopupWorkOrderAllocation_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repoPopupWorkOrderAllocation.QueryPopUp
    Dim mRow As dmPurchaseOrderItem
    'gvPurchaseOrderItems.CloseEditor()
    mRow = gvPurchaseOrderItems.GetFocusedRow
    If mRow IsNot Nothing Then
      grdPurchaseOrderItemAllocationSalesOrderPhaseItem.DataSource = mRow.PurchaseOrderItemAllocations
    End If
  End Sub

  Private Sub repoPopupWorkOrderAllocation_CloseUp(sender As Object, e As CloseUpEventArgs) Handles repoPopupWorkOrderAllocation.CloseUp
    Dim mRow As dmPurchaseOrderItem
    'gvPurchaseOrderItems.CloseEditor()
    mRow = gvPurchaseOrderItems.GetFocusedRow
    If mRow IsNot Nothing Then

      gvPurchaseOrderItemAllocationSalesOrderPhaseItem.CloseEditor()
      UpdateObject()
      mRow.QtyRequired = mRow.TotalQuantityAllocated
      gvPurchaseOrderItems.RefreshData()

      RefreshControls()

    End If
  End Sub

  Private Sub btnManageCOs_Click(sender As Object, e As EventArgs)
    Try
      Dim mPicker As clsPickerSalesOrderPhaseItem
      Dim mSalesOrderPhaseItemInfos As New colSalesOrderPhaseItemInfos
      Dim mSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
      Dim mPurchaseOrderAllocation As dmPurchaseOrderAllocation
      Dim mSelectedSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
      Dim mPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation

      pFormController.LoadSalesOrderPhaseItemInfo(mSalesOrderPhaseItemInfos, String.Format("DateRequired is not null AND OrderStatusENUM not in ({0})", CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed)))

      mPicker = New clsPickerSalesOrderPhaseItem(mSalesOrderPhaseItemInfos, pFormController.DBConn)

      For Each mPOA In pFormController.PurchaseOrder.PurchaseOrderAllocations ''.POItemsMinusAllocatedItem
        If mPOA.SalesorderPhaseItemID > 0 Then
          mSalesOrderPhaseItemInfo = mSalesOrderPhaseItemInfos.ItemFromKey(mPOA.SalesorderPhaseItemID)

          If Not mPicker.SelectedObjects.Contains(mSalesOrderPhaseItemInfo) Then
            mPicker.SelectedObjects.Add(mSalesOrderPhaseItemInfo)
          End If
        End If
      Next

      frmSalesOrderPhaseItemPickerMulti.OpenPickerMulti(mPicker, True)
      For Each mSelectedItem In mPicker.SelectedObjects
        If mSelectedItem IsNot Nothing Then
          mPurchaseOrderAllocation = pFormController.PurchaseOrder.PurchaseOrderAllocations.ItemFromSalesOrderPhaseItemID(mSelectedItem.SalesOrderPhaseItem.SalesOrderPhaseItemID)
          If mPurchaseOrderAllocation Is Nothing Then
            mPurchaseOrderAllocation = New dmPurchaseOrderAllocation
            mPurchaseOrderAllocation.SalesorderPhaseItemID = mSelectedItem.SalesOrderPhaseItemID
            pFormController.PurchaseOrder.PurchaseOrderAllocations.Add(mPurchaseOrderAllocation)
          End If
        End If
      Next
      mSelectedSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
      For Each mSOPII As clsSalesOrderPhaseItemInfo In mPicker.SelectedObjects
        mSelectedSalesOrderPhaseItemInfos.Add(mSOPII)
      Next

      For mindex As Integer = pFormController.PurchaseOrder.PurchaseOrderAllocations.Count - 1 To 0 Step -1
        mPurchaseOrderAllocation = pFormController.PurchaseOrder.PurchaseOrderAllocations(mindex)

        mSalesOrderPhaseItemInfo = mSelectedSalesOrderPhaseItemInfos.ItemFromKey(mPurchaseOrderAllocation.SalesorderPhaseItemID)

        If Not mPicker.SelectedObjects.Contains(mSalesOrderPhaseItemInfo) Then
          pFormController.PurchaseOrder.PurchaseOrderAllocations.Remove(pFormController.PurchaseOrder.PurchaseOrderAllocations(mindex))
        End If

      Next
      pFormController.SaveObject()
      pFormController.LoadRefData()
      LoadPOItemAllocationCombo()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnSendPOEmail_Click(sender As Object, e As EventArgs) Handles btnSendPOEmail.ItemClick
    Dim mMsg As String = ""
    Dim mFileName As String
    Dim mEmail As String = ""
    Dim mOK As Boolean = True

    Dim mEmailMsg As New RTIS.EmailLib.clsEmailMessage
    Dim mdsoAdmin As New dsoRTISGlobal(pFormController.DBConn)
    Dim mEmailTemplate As dmEmailTemplate = Nothing
    Dim mTaskBoolean As Task(Of Boolean)
    Dim mSentToCustomer As Boolean


    mFileName = pFormController.PurchaseOrder.FileName
    If mFileName = "" Then
      mMsg = mMsg & "La Orden de Compra aún no ha sido creada" & vbCrLf
      mOK = False
    ElseIf IO.File.Exists(mFileName) = False Then
      mMsg = mMsg & "El documento " & mFileName & " No se ha encontrado" & vbCrLf
      mOK = False
    End If


    ''//Verifying if The Customer Contact is linked correctly to this Invoice

    If pFormController.Suppliers(0) IsNot Nothing Then
      mEmail = pFormController.Suppliers(0).Email
    Else
      mMsg = "No se ha registrado un correo válido para este proveedor"
      mOK = False
    End If


    If mOK Then
      mMsg = "Confirmar que deseas enviar el documento :" & vbCrLf & System.IO.Path.GetFileName(mFileName) & vbCrLf & " Para:"

      ''//Load all parameters from the Template
      mdsoAdmin.LoadEmailTemplate(mEmailTemplate, eEmailTemplate.PurchaseOrder)
      mEmailMsg.Subject = mEmailTemplate.Subject
      mEmailMsg.BodyHtml = mEmailTemplate.Body

      mEmailMsg.SendTo = pFormController.Suppliers(0).Email

      mEmailMsg.IsBodyHtml = True
      '' mEmailMsg.Subject = RTIS.WorkflowCore.clsDocumentHelper.SearchReplaceText(mEmailMsg.Subject, pFormController.PlaceHolders())

      mEmailMsg.Subject = "Orden de Compra " & pFormController.PurchaseOrder.PONum & "- AgroForestal"
      mEmailMsg.BodyHtml = RTIS.WorkflowCore.clsDocumentHelper.SearchReplaceText(mEmailMsg.BodyHtml, pFormController.PlaceHolders())
      mEmailMsg.AddAttachment(mFileName)

      ''mEmailMsg.SendToBCC = "invoicesent@central-manufacturing.co.uk"

      If RTIS.CandidateElements.frmEmailSimple.OpenSendEmailAsModal(Me, AppRTISGlobal.GetInstance, mEmailMsg, True, True) = True Then
        MsgBox("Email Enviado") 'OR UPDATE SENT FLAG / AUDIT
      Else
        MsgBox("Email no Enviado")
      End If

    Else
      MsgBox(mMsg, MsgBoxStyle.Information)
    End If
  End Sub

  Private Sub rgDefaultCurrency_EditValueChanged(sender As Object, e As EventArgs) Handles rgDefaultCurrency.EditValueChanged

    If pFormController IsNot Nothing Then
      UpdateObject()
      pFormController.CurrentDefaultCurrency = CInt(rgDefaultCurrency.EditValue)
      If pFormController.CurrentDefaultCurrency = eCurrency.Cordobas Then
        lblExchangeRate.Visible = True
        txtExchangeValue.Visible = True

        If pFormController.PurchaseOrder.ExchangeRateValue = 0 Then
          pFormController.PurchaseOrder.ExchangeRateValue = pFormController.GetExchangeRate(Now, eCurrency.Cordobas)
          'RefreshControls()
        End If

        gvPODeliveryInfos.Columns("ExchangeRateValue").Visible = True

        gvPODeliveryInfos.Columns("ExchangeRateValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPODeliveryInfos.Columns("ExchangeRateValue").DisplayFormat.FormatString = "C$#,##0.0000;;#"
        gvPODeliveryInfos.Columns("ExchangeRateValue").SummaryItem.DisplayFormat = "{0:c2}"

        gvPurchaseOrderItems.Columns("VATAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("VATAmount").DisplayFormat.FormatString = "C$#,##0.00;;#"
        gvPurchaseOrderItems.Columns("VATAmount").SummaryItem.DisplayFormat = "{0:C$#,##0.00;;#}"



        gvPurchaseOrderItems.Columns("GrossAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("GrossAmount").DisplayFormat.FormatString = "C$#,##0.00;;#"
        ''gvPODeliveryInfos.Columns("GrossAmount").SummaryItem.DisplayFormat = "{0:C$#,##0.00;;#}"


        gvPurchaseOrderItems.Columns("UnitPrice").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("UnitPrice").DisplayFormat.FormatString = "C$#,##0.00;;#"


        gvPurchaseOrderItems.Columns("NetAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("NetAmount").DisplayFormat.FormatString = "C$#,##0.00;;#"
        ''gvPODeliveryInfos.Columns("NetAmount").SummaryItem.DisplayFormat = "{0:C$#,##0.00;;#}"

        gvPurchaseOrderItems.Columns("RetentionValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("RetentionValue").DisplayFormat.FormatString = "C$#,##0.00;;#"

        gvPurchaseOrderItems.Columns("TotalValueReceived").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("TotalValueReceived").DisplayFormat.FormatString = "C$#,##0.00;;#"
        ''gvPODeliveryInfos.Columns("TotalValueReceived").SummaryItem.DisplayFormat = "{0:C$#,##0.00;;#}"


        gvPODeliveryInfos.Columns("PODeliveryValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPODeliveryInfos.Columns("PODeliveryValue").DisplayFormat.FormatString = "C$#,##0.00;;#"
        gvPODeliveryInfos.Columns("PODeliveryValue").SummaryItem.DisplayFormat = "{0:C$#,##0.00;;#}"

      Else
        lblExchangeRate.Visible = False
        txtExchangeValue.Visible = False
        gvPODeliveryInfos.Columns("ExchangeRateValue").Visible = False


        gvPurchaseOrderItems.Columns("VATAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("VATAmount").DisplayFormat.FormatString = "$#,##0.00;;#"
        gvPurchaseOrderItems.Columns("VATAmount").SummaryItem.DisplayFormat = "{0:$#,##0.00;;#}"

        gvPurchaseOrderItems.Columns("GrossAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("GrossAmount").DisplayFormat.FormatString = "$#,##0.00;;#"

        gvPurchaseOrderItems.Columns("UnitPrice").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("UnitPrice").DisplayFormat.FormatString = "$#,##0.00;;#"

        gvPurchaseOrderItems.Columns("NetAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("NetAmount").DisplayFormat.FormatString = "$#,##0.00;;#"

        gvPurchaseOrderItems.Columns("RetentionValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("RetentionValue").DisplayFormat.FormatString = "$#,##0.00;;#"

        gvPurchaseOrderItems.Columns("TotalValueReceived").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPurchaseOrderItems.Columns("TotalValueReceived").DisplayFormat.FormatString = "$#,##0.00;;#"

        gvPODeliveryInfos.Columns("PODeliveryValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvPODeliveryInfos.Columns("PODeliveryValue").DisplayFormat.FormatString = "$#,##0.00;;#"

      End If
      RefreshControls()
    End If
  End Sub

  Private Sub btnPODelivery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPODelivery.ItemClick
    Dim mDialogResult As DialogResult

    If pFormController.PODeliveryInfos IsNot Nothing Then

      If pFormController.PurchaseOrder IsNot Nothing Then

        For Each mPOItem As dmPurchaseOrderItem In pFormController.PurchaseOrder.PurchaseOrderItems

          pFormController.CreateUpdatePOItemAllocation(mPOItem, True)
        Next

      End If

      If pFormController.PODeliveryInfos.Count >= 1 Then
        mDialogResult = MessageBox.Show("Esta O.C. ya tiene una recepción, ¿Desea agregar otra recepción?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If mDialogResult = DialogResult.Yes Then
          UpdateObject()
          pFormController.SaveObject()
          frmPODelivery.OpenAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, 0, pFormController.PurchaseOrder.PurchaseOrderID, eFormMode.eFMFormModeAdd)

          pFormController.ReloadPODeliveryInfos()
          grdPODeliveryInfos.DataSource = pFormController.PODeliveryInfos
          grdPODeliveryInfos.RefreshDataSource()

          pFormController.ReloadPOItems()

          grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
          grdPurchaseOrderItems.RefreshDataSource()
        End If
      Else
        UpdateObject()
        pFormController.SaveObject()
        frmPODelivery.OpenAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, 0, pFormController.PurchaseOrder.PurchaseOrderID, eFormMode.eFMFormModeAdd)

        pFormController.ReloadPODeliveryInfos()
        grdPODeliveryInfos.DataSource = pFormController.PODeliveryInfos
        grdPODeliveryInfos.RefreshDataSource()

        pFormController.ReloadPOItems()

        grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
        grdPurchaseOrderItems.RefreshDataSource()
      End If
    End If

  End Sub

  Private Sub btnReloadPODeliveryInfos_Click(sender As Object, e As EventArgs)



  End Sub

  Private Sub btedSupplier_EditValueChanged(sender As Object, e As EventArgs) Handles btedSupplier.EditValueChanged

    ''pFormController.PurchaseOrder.DefaultCurrency = pSupplier.DefaultCurrency
  End Sub

  Private Sub gvPurchaseOrderItems_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvPurchaseOrderItems.CustomUnboundColumnData
    Dim mPOItem As dmPurchaseOrderItem
    Dim mVatRates As colVATRates
    Dim mStockItem As dmStockItem

    mVatRates = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.VATRate)
    mPOItem = e.Row
    If mPOItem IsNot Nothing Then
      If e.Column Is gcVATRateCode Then
        If e.IsGetData Then
          e.Value = mPOItem.VatRateCode
        ElseIf e.IsSetData Then
          mPOItem.VatRateCode = e.Value
          mPOItem.VatValue = mPOItem.CalculateVATValue(mVatRates.GetVATRateAtDate(mPOItem.VatRateCode, pFormController.PurchaseOrder.SubmissionDate))
          'gvPurchaseOrderItems.RefreshRow(gvPurchaseOrderItems.FocusedRowHandle)
        End If
      End If

      If e.Column Is gcStockCode Then

        mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOItem.StockItemID)

        If mStockItem IsNot Nothing Then
          If e.IsGetData Then
            e.Value = mStockItem.StockCode
          ElseIf e.IsSetData Then
            mPOItem.StockCode = mStockItem.StockCode
          End If
        End If


      End If

    End If
  End Sub

  Private Sub gvPurchaseOrderItems_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvPurchaseOrderItems.CellValueChanged
    Dim mPOItem As dmPurchaseOrderItem
    Dim mVatRates As colVATRates
    mVatRates = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.VATRate)
    mPOItem = gvPurchaseOrderItems.GetRow(e.RowHandle)
    If mPOItem IsNot Nothing And mVatRates IsNot Nothing Then
      mPOItem.TempPercentageRetention = pFormController.PurchaseOrder.RetentionPercentage

      mPOItem.VatValue = mPOItem.CalculateVATValue(mVatRates.GetVATRateAtDate(mPOItem.VatRateCode, pFormController.PurchaseOrder.SubmissionDate))

    End If

  End Sub







  Private Sub gvPurchaseOrderItems_ShowingEditor(sender As Object, e As CancelEventArgs) Handles gvPurchaseOrderItems.ShowingEditor

    Dim mPOI As dmPurchaseOrderItem
    mPOI = CType(gvPurchaseOrderItems.GetFocusedRow, dmPurchaseOrderItem)

    Select Case gvPurchaseOrderItems.FocusedColumn.Name
      Case gcPOIDescription.Name, gcSupplierCode.Name, gcPartNo.Name
        If mPOI.StockItemID > 0 Then
          e.Cancel = True
        Else
          e.Cancel = False
        End If
    End Select

  End Sub





  Private Sub gvPurchaseOrderItems_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvPurchaseOrderItems.RowUpdated
    Dim mPOItem As dmPurchaseOrderItem
    Try

      gvPurchaseOrderItems.CloseEditor()
      gvPurchaseOrderItems.UpdateCurrentRow()

      Select Case pFormController.PurchaseOrder.MaterialRequirementTypeID
        Case ePOMaterialRequirementType.Inventario, ePOMaterialRequirementType.Sencillo
          '// Check that we are Simple of Stock type - otherwise don't do anything

          '// Get the current POItem from the grid
          mPOItem = TryCast(gvPurchaseOrderItems.GetFocusedRow, dmPurchaseOrderItem)

          If mPOItem IsNot Nothing Then
            pFormController.CreateUpdatePOItemAllocation(mPOItem, True)

          End If
      End Select
      LoadPOItemAllocationCombo()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btedSOPhase_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub grdPurchaseOrderItems_ViewRegistered(sender As Object, e As ViewOperationEventArgs) Handles grdPurchaseOrderItems.ViewRegistered




  End Sub

  Public Sub ShowHideGridColumsByName(ByRef rViewBase As BaseView, ByVal vColumnNameToShow As String, ByVal vColumnNameToHide As String)
    Dim mView As GridView = CType(rViewBase, GridView)

    For Each mColum As GridColumn In mView.Columns

      If mColum.Name = vColumnNameToShow Then
        mColum.Visible = True
        mColum.VisibleIndex = 3 ''//To force to have The right position of the column in the view
      End If

      If mColum.Name = vColumnNameToHide Then
        mColum.Visible = False

      End If

    Next
  End Sub

  Private Sub repoPODelivery_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoPODelivery.ButtonClick
    Dim mPODI As clsPODeliveryInfo

    Try
      mPODI = TryCast(gvPODeliveryInfos.GetFocusedRow, clsPODeliveryInfo)

      If mPODI IsNot Nothing Then

        If pFormController.PurchaseOrder IsNot Nothing Then

          For Each mPOItem As dmPurchaseOrderItem In pFormController.PurchaseOrder.PurchaseOrderItems

            pFormController.CreateUpdatePOItemAllocation(mPOItem, True)
          Next

        End If


        frmPODelivery.OpenAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, mPODI.PODeliveryID, pFormController.PurchaseOrder.PurchaseOrderID, eFormMode.eFMFormModeAdd)

        pFormController.ReloadPODeliveryInfos()
        grdPODeliveryInfos.DataSource = pFormController.PODeliveryInfos
        grdPODeliveryInfos.RefreshDataSource()

        pFormController.ReloadPOItems()

        grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
        grdPurchaseOrderItems.RefreshDataSource()

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try


  End Sub

  Private Sub txtRetentionPercentage_EditValueChanged(sender As Object, e As EventArgs) Handles txtRetentionPercentage.TextChanged

    If pFormController IsNot Nothing Then
      UpdateObject()
      If pFormController.PurchaseOrder IsNot Nothing And pFormController.PurchaseOrder.PurchaseOrderItems.Count > 0 Then
        pFormController.PurchaseOrder.RetentionPercentage = Val(txtRetentionPercentage.EditValue)
        'CheckSave(False)

        RefreshControls()
        Dim mPOItem As dmPurchaseOrderItem
        Dim mVatRates As colVATRates
        mVatRates = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.VATRate)
        For Each mPOItem In pFormController.PurchaseOrder.PurchaseOrderItems

          If mPOItem IsNot Nothing And mVatRates IsNot Nothing Then
            mPOItem.TempPercentageRetention = pFormController.PurchaseOrder.RetentionPercentage

            mPOItem.VatValue = mPOItem.CalculateVATValue(mVatRates.GetVATRateAtDate(mPOItem.VatRateCode, pFormController.PurchaseOrder.SubmissionDate))

          End If
        Next
        gvPurchaseOrderItems.RefreshData()
      End If
    End If
  End Sub

  Private Sub gvPurchaseOrderItemAllocationSalesOrderPhaseItem_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvPurchaseOrderItemAllocationSalesOrderPhaseItem.CustomUnboundColumnData

    Dim mRow As dmPurchaseOrderItemAllocation
    Dim mSOPII As clsSalesOrderPhaseItemInfo

    Try
      mRow = TryCast(e.Row, dmPurchaseOrderItemAllocation)

      If mRow IsNot Nothing Then

        Select Case e.Column.Name
          Case gcSOPIQuantity.Name
            If e.IsGetData Then
              mSOPII = pFormController.SalesOrderPhaseItemInfos.ItemFromKey(mRow.SalesorderPhaseItemID)
              e.Value = mRow.Quantity
              If mSOPII IsNot Nothing Then
                mRow.ItemRef = mSOPII.ItemNumberRef
                mRow.ItemRef2 = mSOPII.Description
                mRow.ProjectRef = mSOPII.ProjectName & "/" & mSOPII.CompanyName
              Else
                ''To Inventory
                mRow.ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(pFormController.PurchaseOrder.Category, ePurchaseCategories))

              End If

            ElseIf e.IsSetData Then
              mRow.Quantity = e.Value

            End If

        End Select

      End If
    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try


  End Sub

  Private Sub rgCompanyOption_EditValueChanged(sender As Object, e As EventArgs) Handles rgCompanyOption.EditValueChanged

    If pIsActive Then

      If pFormController IsNot Nothing Then

        pFormController.CompanyOption = rgCompanyOption.EditValue
      End If

    End If
  End Sub
End Class