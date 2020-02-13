Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmPurchaseOrder
  Private pFormController As fccPurchaseOrder
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmPurchaseOrder = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmPurchaseOrder
      mfrm.pFormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub


  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode)
    Dim mfrm As New frmPurchaseOrder
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

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmPurchaseOrder
    Dim mfrmWanted As frmPurchaseOrder = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPurchaseOrder
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


      pFormController.LoadObject()
      RefreshGrid()

      LoadCombos()
      RefreshControls()
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

  Private Sub RefreshGrid()
    grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
  End Sub

  Private Sub LoadCombos()

  End Sub



  Private Sub SetupUserPermissions()
    'Dim mPermisionLevel As ePermissionCode
    'mPermisionLevel = pDBConn.RTISUser.ActivityPermissions.GetActivityPermission(eActivityCode.UserConfig)


  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
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

  Private Sub RefreshControls()
    Try

      With pFormController.PurchaseOrder

        txtPONum.Text = .PONum
        txtSupplierRef.Text = .SupplierRef
        'dteDateEntered.EditValue = .DateEntered
        dteDueDate.EditValue = clsGeneralA.DateToDBValue(.RequiredDate)

        RTIS.Elements.clsDEControlLoading.SetDECombo(cboCategory, .Category)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboBuyer, .BuyerID)


        If .Supplier Is Nothing Then
          btedSupplier.Text = ""
        Else
          FillSupplierDetail()

        End If
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub FillSupplierDetail()

    Try
      With pFormController.PurchaseOrder
        btedSupplier.Text = .Supplier.CompanyName
        txtAddress1.Text = .Supplier.MainAddress1
        txtCountry.Text = .Supplier.MainCountry
        txtTown.Text = .Supplier.MainTown

        'CustomerStatusID.Text = .Customer.CustomerStatusID

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub UpdateObject()
    With pFormController.PurchaseOrder
      .PONum = txtPONum.Text
      .RequiredDate = dteDueDate.DateTime


      gvPurchaseOrderItems.CloseEditor()
      gvPurchaseOrderItems.UpdateCurrentRow()





    End With
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

  Private Sub barbtnSaveExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbutSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      CheckSave(False)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
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


  Private Sub LabelControl13_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

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
          Dim mSupplier As dmSupplier
          UpdateObject()
          mSupplierPicker = New clsPickerSupplier(pFormController.GetSupplierList, pFormController.DBConn)
          mSupplier = frmPickSupplier.OpenPickerSingle(mSupplierPicker)
          If mSupplier IsNot Nothing Then
            pFormController.PurchaseOrder.SupplierID = mSupplier.SupplierID
            pFormController.PurchaseOrder.Supplier = mSupplier
            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If
          RefreshControls()
        Case ButtonPredefines.Ellipsis
          frmCustomerDetail.OpenFormModal(pFormController.PurchaseOrder.SupplierID, pFormController.DBConn)
          If pFormController.PurchaseOrder.SupplierID <> 0 Then
            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If
          RefreshControls()
      End Select

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gpnlPOItems_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpnlPOItems.CustomButtonClick
    ' Dim mPickerStockItem As clsPickerStockItem
    Dim mSelectedItem As dmStockItem
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOItemEditor As clsPOItemEditor
    Dim mPicker As clsPickerStockItem
    Dim mStockItems As New colStockItems
    Dim mStockItem As dmStockItem
    Dim mSelectedStockItems As colStockItems
    Try

      Select Case e.Button.Properties.Tag
        Case "AddStockItem"

          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
            mStockItems.Add(mItem.Value)
          Next

          mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, pFormController.RTISGlobal)

          For Each mPOItem In pFormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem
            If mPOItem.StockItemID > 0 Then
              mStockItem = mStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                mPicker.SelectedObjects.Add(mStockItem)
              End If
            End If
          Next

          If frmPickerStockItem.PickPurchaseOrderItems(mPicker, pFormController.RTISGlobal) Then
            For Each mSelectedItem In mPicker.SelectedObjects
              If mSelectedItem IsNot Nothing Then
                mPOItem = pFormController.PurchaseOrder.PurchaseOrderItems.ItemByStockItemID(mSelectedItem.StockItemID)
                If mPOItem Is Nothing Then
                  mPOItem = clsPurchaseHandler.AddPOItem(pFormController.PurchaseOrder)
                  mPOItem.StockItemID = mSelectedItem.StockItemID
                  mPOItem.Description = mSelectedItem.Description
                  mPOItem.PartNo = mSelectedItem.PartNo
                End If
              End If
            Next
          End If
          mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

          For mindex As Integer = pFormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem.Count - 1 To 0 Step -1
            mPOItem = pFormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem(mindex)
            If mPOItem.StockItemID > 0 Then
              mStockItem = mSelectedStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                pFormController.PurchaseOrder.PurchaseOrderItems.Remove(mPOItem)
              End If
            End If
          Next


          grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem

        Case "DeleteItem"

          mPOItem = gvPurchaseOrderItems.GetFocusedRow
          If mPOItem IsNot Nothing Then
            If MsgBox("¿Está seguro que desea eliminar este ítem de la compra?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Artículo") Then
              pFormController.PurchaseOrder.PurchaseOrderItems.Remove(mPOItem)
              grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem
            End If
          End If

      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnEditPurchaseOrderPDF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnEditPurchaseOrderPDF.ButtonClick
    Try

      UpdateObject()
      Select Case e.Button.Kind
        Case ButtonPredefines.Plus

          AddPurchaseOrderDocument()
          RefreshControls()
      End Select
      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub AddPurchaseOrderDocument()
    Dim mValidate As clsValidate
    Dim mReport As repPurchaseOrder
    Dim mFilePath As String

    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.PurchaseOrder)

      CreateReportPDF(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, True, mReport)

      CheckSave(False)

      mFilePath = pFormController.PurchaseOrder.OutputDocuments.GetFilePath(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      End If
      mReport.ClearImages()
      mReport.Dispose()
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
    End If

  End Sub

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
  Public Function GetReport(ByVal vDocType As eDocumentType) As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mPOs As New colPurchaseOrders

    Select Case vDocType
      Case eDocumentType.PurchaseOrder

        If pFormController.PurchaseOrder IsNot Nothing Then
          mRetVal = repPurchaseOrder.GenerateReport(pFormController.PurchaseOrder)
        End If

    End Select

    Return mRetVal
  End Function

End Class