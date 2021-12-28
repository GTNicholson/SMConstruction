Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmPickMaterials

  Dim pFormController As fccPickMaterials
  Dim pMaterialRequirementInfos As colMaterialRequirementInfos
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private Enum eGroupItemButtons
    Process = 1
    AddItems = 2
    Export = 3
    ReturnFromProd = 4
  End Enum


  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    Dim mVI As clsValueItem
    Dim mSITLIs As New colStockItemTransactionLogInfos
    Dim mRequisaLists As New List(Of String)

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementInfo, gcCategory, mVIs)

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementInfo, gcAreaID, mVIs)


    mVIs = New colValueItems
    mVI = New clsValueItem
    mVI.ItemValue = 0
    mVI.DisplayValue = "Todos"
    mVIs.Add(mVI)

    For Each mVI In clsEnumsConstants.EnumToVIs(GetType(eWorkCentre)).AsList.OrderBy(Function(x) x.DisplayValue).ToList

      Select Case mVI.ItemValue
        Case eWorkCentre.Engineering, eWorkCentre.Undefined, eWorkCentre.Insumos, eWorkCentre.Purchasing, eWorkCentre.Wood
        Case Else
          mVIs.Add(mVI)

      End Select

    Next


    clsDEControlLoading.FillDEComboVI(cboArea, mVIs)





  End Sub


  Public Property FormController() As fccPickMaterials
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPickMaterials)
      pFormController = value
    End Set
  End Property

  Public Sub New()

    pMaterialRequirementInfos = New colMaterialRequirementInfos
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub
  Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

  End Sub


  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmPickMaterials = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmPickMaterials
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccPickMaterials(rDBConn)

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub




  Private Shared Function GetFormIfLoaded() As frmPickMaterials


    Dim mfrmWanted As frmPickMaterials = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPickMaterials
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPickMaterials Then
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

  Private Sub btnSelectOT_Click(sender As Object, e As EventArgs) Handles btnSelectOT.Click
    Dim mWOPicker As clsPickerWorkOrder
    Dim mWOIs As New colWorkOrderInfos

    pFormController.LoadWorkOrderInfos(mWOIs)

    mWOPicker = New clsPickerWorkOrder(mWOIs, pFormController.DBConn)

    Dim mWO As clsWorkOrderInfo
    mWO = frmWorkOrderPicker.OpenPickerSingle(mWOPicker)

    If mWO IsNot Nothing Then
      pFormController.CurrentWorkOrderInfo = mWO
      RefreshControls()

      LoadRequisaCombos()
      grdMaterialRequirementInfo.DataSource = Nothing
    End If



  End Sub

  Private Sub LoadRequisaCombos()
    Dim mVIS As colValueItems
    Dim mVI As clsValueItem
    Dim mRequisaLists As New List(Of String)
    Dim mSITLIs As New colStockItemTransactionLogInfos

    mVIS = New colValueItems
    mVI = New clsValueItem
    mVI.ItemValue = 0
    mVI.DisplayValue = "Imprimir Resumen"
    mVIS.Add(mVI)

    pFormController.GetSITLInfos(mSITLIs)

    For Each mSITLI In mSITLIs

      If mRequisaLists.Contains(mSITLI.ReferenceNo) = False Then

        mVI = New clsValueItem
        mVI.ItemValue = mSITLI.StockItemTransactionLogID
        mVI.DisplayValue = mSITLI.ReferenceNo
        mVIS.Add(mVI)
        mRequisaLists.Add(mSITLI.ReferenceNo)

      End If

    Next

    clsDEControlLoading.FillDEComboVI(cboRequisas, mVIS)
  End Sub

  Private Sub RefreshControls()

    Try



      With pFormController.CurrentWorkOrderInfo
        btnSelectOT.Text = .WorkOrderNo
        txtCompanyName.Text = .CustomerName
        txtFinishDate.Text = .FinishDate
        txtProjectName.Text = .ProjectName
        txtReference.Text = .OrderNo
        txtWODescription.Text = .Description
        txtWOQty.Text = .Quantity
        txtPlannedDate.Text = .PlannedStartDate
      End With


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub


  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    '// call formcontroller to load workorderinfos collection where objectytype = WO and objectid = eProductType.ProductFurniture


    '// Bind the grid to the new collection

  End Sub

  Private Sub frmPickMaterials_Load(sender As Object, e As EventArgs) Handles Me.Load
    ''Dim mWOIs As New colWorkOrderInfos
    SetPermissions()

    LoadCombos()

    clsDEControlLoading.SetDECombo(cboArea, 0) 'Todos

    SetGroupField()

  End Sub

  Private Sub SetPermissions()
    Dim mPermissionCode As ePermissionCode = pFormController.DBConn.RTISUser.ActivityPermission(eActivityCode.PickingMatReq)

    If mPermissionCode = ePermissionCode.ePC_Full Then
    Else
      grpMaterialRequirements.CustomHeaderButtons(0).Properties.Visible = False
      grpMaterialRequirements.CustomHeaderButtons(1).Properties.Visible = False
      grpMaterialRequirements.CustomHeaderButtons(2).Properties.Visible = False


    End If




  End Sub

  Private Sub SetGroupField()
    Dim item1 As GridGroupSummaryItem = New GridGroupSummaryItem

    item1.FieldName = "TotalAmount"

    item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
    item1.DisplayFormat = "{0:C$#,##0.00;;#}"
    item1.ShowInGroupColumnFooter = gvMaterialRequirementInfos.Columns("UnitPrice")
    gvMaterialRequirementInfos.GroupSummary.Add(item1)
  End Sub

  Private Sub frmPickMaterials_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpMaterialRequirements.CustomButtonClick
    Dim mCountToProcess As Integer
    Try
      Select Case e.Button.Properties.Tag
        Case eGroupItemButtons.Process
          gvMaterialRequirementInfos.CloseEditor()
          gvMaterialRequirementInfos.UpdateCurrentRow()

          mCountToProcess = pFormController.MaterialRequirementProcessors.GetTotalItemsToProcess()

          If mCountToProcess > 0 Then
            pFormController.ProcessPicks()
          End If

          gvMaterialRequirementInfos.RefreshData()
          LoadRequisaCombos()
        Case eGroupItemButtons.AddItems
          Dim mPicker As clsPickerStockItem
          Dim mSIList As List(Of RTIS.ERPStock.intStockItemDef)
          mPicker = New clsPickerStockItem(AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemCollection, pFormController.DBConn, AppRTISGlobal.GetInstance)
          mSIList = frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance, False, -1)
          If mSIList.Count > 0 Then
            pFormController.CreateAdditionalMatReqs(mSIList)
          End If
        Case eGroupItemButtons.Export
          Dim mFileName As String = "Exportar Salida de Producción de OT_ " + pFormController.CurrentWorkOrderInfo.Description & ".xlsx"
          If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
            gvMaterialRequirementInfos.ExportToXlsx(mFileName)
          End If

        Case eGroupItemButtons.ReturnFromProd
          gvMaterialRequirementInfos.CloseEditor()
          gvMaterialRequirementInfos.UpdateCurrentRow()
          pFormController.ProcessReturnProduction()
          gvMaterialRequirementInfos.RefreshData()

      End Select
      LoadGrid()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try



  End Sub

  Private Sub btnPrintRequisa_Click(sender As Object, e As EventArgs) Handles btnPrintRequisa.Click
    Dim mReportPath As String
    Dim mRequisaID As Integer = clsDEControlLoading.GetDEComboValue(cboRequisas)

    If mRequisaID = 0 Then
      pFormController.CreateRequisaSummary()
    Else
      pFormController.CreateRequisaPicking(cboRequisas.Text)

    End If

    'MessageBox.Show(cboRequisas.Text)
    'mReportPath = pFormController.CreateRequisaSummary()
    'pFormController.CurrentWorkOrderInfo.WorkOrder.RequisaDocumentPath = mReportPath
  End Sub

  Private Sub btnLoadMatReq_Click(sender As Object, e As EventArgs) Handles btnLoadMatReq.Click

    If pFormController.CurrentWorkOrderInfo IsNot Nothing Then
      If pFormController.CurrentWorkOrderInfo.WorkOrder.WorkOrderID > 0 Then
        LoadGrid()

      End If
    End If

  End Sub

  Private Sub LoadGrid()
    Dim mArea As Integer = clsDEControlLoading.GetDEComboValue(cboArea)



    pFormController.LoadMaterialRequirementProcessorss(mArea)
    grdMaterialRequirementInfo.DataSource = pFormController.MaterialRequirementProcessors
    gvMaterialRequirementInfos.RefreshData()
    gvMaterialRequirementInfos.ExpandAllGroups()


  End Sub

  Private Sub gvMaterialRequirementInfos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvMaterialRequirementInfos.RowCellStyle
    Dim mCurrentRow As clsMaterialRequirementProcessor


    Try

      mCurrentRow = TryCast(gvMaterialRequirementInfos.GetRow(e.RowHandle), clsMaterialRequirementProcessor)
      If mCurrentRow IsNot Nothing Then

        Select Case e.Column.FieldName
          Case "ToProcessQty"

            If mCurrentRow.FromStockQty = 0 And mCurrentRow.QtyOS <> 0 Then ''//Pending to Despatch
              e.Appearance.BackColor = Color.LightGreen

            Else


            End If

            If mCurrentRow.FromStockQty <> 0 And mCurrentRow.QtyOS <> 0 Then ''//Pending Picking from Stock
              e.Appearance.BackColor = Color.LightGreen

            Else


            End If

            If mCurrentRow.QtyOS <= 0 Then ''//ALready picked
              e.Appearance.BackColor = Color.LightGray

            Else


            End If

        End Select


      Else


        End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try



  End Sub
End Class