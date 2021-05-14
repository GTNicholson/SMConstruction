Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Public Class frmPickWoodMaterial
  Dim pFormController As fccPickWoodMaterial
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

  End Sub

  Public Property FormController() As fccPickWoodMaterial
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPickWoodMaterial)
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

  Public Shared Sub OpenAsModal(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vPickWoodMaterialID As Integer, ByRef rWoodPallet As dmWoodPallet, ByVal vMode As eFormMode)
    Dim mfrm As frmPickWoodMaterial = Nothing

    '' mfrm = GetFormIfLoaded()
    ''If mfrm Is Nothing Then
    mfrm = New frmPickWoodMaterial
    mfrm.FormMode = vMode
    '' mfrm.MdiParent = rMDIParent
    mfrm.pFormController = New fccPickWoodMaterial(rDBConn)
    mfrm.pFormController.WoodPallet = rWoodPallet

    mfrm.ShowDialog()
    ''Else
    ''mfrm.Focus()
    ''End If
  End Sub

  Private Shared Function GetFormIfLoaded() As frmPickWoodMaterial


    Dim mfrmWanted As frmPickWoodMaterial = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPickWoodMaterial
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPickWoodMaterial Then
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

      If pFormController.WoodPallet IsNot Nothing Then
        With pFormController.WoodPallet
          txtWoodPalletRef.Text = .PalletRef
          txtWoodPalletDescription.Text = .LocationDesc


        End With

        If pFormController.CurrentWorkOrderInfo IsNot Nothing Then
          With pFormController.CurrentWorkOrderInfo
            btnSelectWorkOrder.Text = .WorkOrderNo
            txtWorkOrderDescription.Text = .Description
            txtCustomerName.Text = .CustomerName
            txtProjectName.Text = .ProjectName
          End With



        End If

        If pFormController.WoodPalletItemEditors IsNot Nothing Then

          With pFormController.WoodPallet
            ' txtGRNNumber.Text = "Testing" '.PickNumber
            ' txtRefDocSupplier.Text = .RefSupplierDoc
            SetReceivedValueWithCurrencyFormat() ' pFormController.GetReceivedValue()
            gcQtyToProcess.OptionsColumn.ReadOnly = False

            'clsDEControlLoading.SetDECombo(cboStatus, .Status)

            'If .PickNumber <> "" Then
            '  grpGRN.CustomHeaderButtons.Item(0).Properties.Enabled = False
            '  txtRefDocSupplier.ReadOnly = False
            'Else
            '  txtRefDocSupplier.ReadOnly = True
            'End If
          End With

        End If
        SetupReadOnly()
        SetUpUserPermissions()



      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Public Sub SetReceivedValueWithCurrencyFormat()


  End Sub

  Private Sub SetupReadOnly()

    'If txtGRNNumber.Text = "" Then

    '  grdPurchaseOrderItemInfo.Enabled = False
    '  grdWoodPalletItems.CustomHeaderButtons.Item(0).Properties.Visible = False
    '  ''grpMaterialRequirements.CustomHeaderButtons.Item(1).Properties.Visible = False
    '  grdWoodPalletItems.CustomHeaderButtons.Item(2).Properties.Visible = False
    'Else

    '  grdPurchaseOrderItemInfo.Enabled = True
    '  grdWoodPalletItems.CustomHeaderButtons.Item(0).Properties.Visible = True
    '  ''grpMaterialRequirements.CustomHeaderButtons.Item(1).Properties.Visible = True
    '  grdWoodPalletItems.CustomHeaderButtons.Item(2).Properties.Visible = True
    'End If

  End Sub

  Private Sub frmPurchaseOrderDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
    ''Add error patter for form load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    Try
      pFormController.LoadObjects()

      grdPurchaseOrderItemInfo.DataSource = pFormController.WoodPalletItemEditors
      LoadCombos()

      'SetUpUserPermissions()

      RefreshGrid()


      RefreshControls()
      'If txtGRNNumber.Text <> "" And btnSelectWorkOrder.Text <> "" Then
      '  btnSelectWorkOrder.Enabled = False



      '  '' pFormController.PODelivery = Nothing
      'Else
      '  gcQtyToProcess.OptionsColumn.ReadOnly = True
      'End If

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub




  Private Sub frmPickMaterials_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    If pFormController.CurrentWorkOrderInfo IsNot Nothing Then
      If pFormController.CurrentWorkOrderInfo.WorkOrderID > 0 Then
        gvWoodPalletItems.CloseEditor()
        pFormController.WoodPallet.IntoWIPDate = Now
        pFormController.WoodPallet.WorkOrderID = pFormController.CurrentWorkOrderInfo.WorkOrderID
        pFormController.CreateNegativeTransaction()
        pFormController.SaveWoodPallet()
      End If
    End If

    Me.Dispose()


  End Sub

  Private Sub btnSelectWorkOrder_Click(sender As Object, e As EventArgs) Handles btnSelectWorkOrder.Click
    Dim mWOPicker As clsPickerWorkOrder
    Dim mWOIs As New colWorkOrderInfos

    pFormController.LoadWorkOrderInfos(mWOIs)

    mWOPicker = New clsPickerWorkOrder(mWOIs, pFormController.DBConn)

    Dim mWO As clsWorkOrderInfo
    mWO = frmWorkOrderPicker.OpenPickerSingle(mWOPicker)

    If mWO IsNot Nothing Then
      pFormController.CurrentWorkOrderInfo = mWO
      RefreshControls()

    End If


  End Sub

  Private Sub UpdateObject()


    'If pFormController.PickWoodMaterialRequirement IsNot Nothing Then
    '  With pFormController.PickWoodMaterialRequirement
    '    .PickNumber = txtGRNNumber.Text
    '    '.PODeliveryValue = pFormController.GetReceivedValue
    '    '.PurchaseOrder = pFormController.WorkOrderInfo.PurchaseOrder
    '    '.PurchaseOrderID = pFormController.WorkOrderInfo.PurchaseOrder.PurchaseOrderID
    '    '.Status = clsDEControlLoading.GetDEComboValue(cboStatus)
    '    '.RefSupplierDoc = txtRefDocSupplier.Text
    '    .DateCreated = dteReceived.EditValue
    '  End With
    'End If
  End Sub

  Private Sub RefreshGrid()
    'pFormController.LoadPurchaseOrderItemAllocationProcessorss()
    'grdPurchaseOrderItemInfo.DataSource = pFormController.PurchaseOrderProcessors
    gvWoodPalletItems.RefreshData()

  End Sub

  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grdWoodPalletItems.CustomButtonClick
    Dim mOK As Boolean
    Try
      UpdateObject()
      gvWoodPalletItems.CloseEditor()
      gvWoodPalletItems.UpdateCurrentRow()
      pFormController.SavePickeWoodPalletItem()

      Select Case e.Button.Properties.Tag


        Case ePOIProcessorOption.eProcess ''//Click on Process Button

          If pFormController.CurrentWorkOrderInfo IsNot Nothing Then
            mOK = pFormController.ProcessPickingQtys()

          End If


          'If mOK Then pFormController.CreatePurchaseOrderPDF(pFormController.WorkOrderInfo, pFormController.PurchaseOrderProcessors, pFormController.PickWoodMaterialRequirement, False)

          'If File.Exists(pFormController.PickWoodMaterialRequirement.FileExport) Then
          '  ''  Process.Start(pFormController.PODelivery.FileExport)

          'End If

        Case ePOIProcessorOption.eProcessAll

          For Each mWPIE As clsWoodPalletItemEditor In pFormController.WoodPalletItemEditors
            Dim mPendingValue As Decimal = 0
            mPendingValue = mWPIE.Quantity - mWPIE.QuantityUsed

            If mPendingValue > 0 Then
              mWPIE.ToProcessQty = mPendingValue
              ''pFormController.ProcessDeliveryQtys(False)
            End If

          Next

        Case ePOIProcessorOption.ePrintPODelivery
          '   pFormController.CreatePurchaseOrderPDF(pFormController.WorkOrderInfo, pFormController.PurchaseOrderProcessors, pFormController.PODelivery, True)
      End Select

      pFormController.SavePickeWoodPalletItem()
      gvWoodPalletItems.RefreshData()

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    ''pFormController.LoadMaterialRequirementProcessorss()
    ''grdPurchaseOrderItemInfo.DataSource = pFormController.MaterialRequirementProcessors
  End Sub


  Private Sub grpGRN_CustomButtonClick(sender As Object, e As BaseButtonEventArgs)
    Select Case e.Button.Properties.Tag

      Case "Raise"
        UpdateObject()

        pFormController.RaisePickingNumber()

        RefreshControls()
        UpdateObject()
        pFormController.SavePickeWoodPalletItem()
      Case "Edit"

      Case "Save"
        UpdateObject()
        pFormController.SavePickeWoodPalletItem()
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
        mRetVal = pFormController.SavePickeWoodPalletItem
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
