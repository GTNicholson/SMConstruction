Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder
  Private pWoodMatReqs As colMaterialRequirements
  Private pStockItemMatReqs As colMaterialRequirements
  Private pFurniture As dmProductFurniture
  Private pProjectName As String


  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByVal vProjectName As String) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.pProjectName = vProjectName
    mRep.pWoodMatReqs = rWorkOrder.WoodMaterialRequirements
    mRep.pStockItemMatReqs = rWorkOrder.StockItemMaterialRequirements

    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    '// Head informatio from pWorkOrder
    xtcOTNumber.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xtcProjectName.Text = pProjectName
    xtcDescription.DataBindings.Add("Text", pWorkOrder, "Description")
    xtcEmployee.DataBindings.Add("Text", pWorkOrder, "EmployeeDesc")
    xtcCreatedDate.DataBindings.Add("Text", pWorkOrder, "DateCreated", "{0:dd/MM/yyyy}")
    xtcPlannedStartDate.DataBindings.Add("Text", pWorkOrder, "PlannedStartDate", "{0:dd/MM/yyyy}")
    xtcDueDate.DataBindings.Add("Text", pWorkOrder, "PlannedDeliverDate", "{0:dd/MM/yyyy}")



  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    'Dim mProduct As dmProductBase
    'Dim mPicHeight As Single
    Dim mrepWorkOrderWoodMaterialRequirementInfo As repWorkOrderWoodMaterialRequirement
    Dim mrepStockItemMaterialRequirement As repWorkOrderStockItemMaterialRequirement
    Dim mRepSignatures As srepWorkOrderSignOffs



    SetUpDataBindings()

    xtcTotalBoardFeet.Text = pWorkOrder.WoodMaterialRequirements.GetTotalBoardFeets().ToString("n3")

    mrepWorkOrderWoodMaterialRequirementInfo = New repWorkOrderWoodMaterialRequirement
    mrepWorkOrderWoodMaterialRequirementInfo.DataSource = pWoodMatReqs
    xrSubWorkOrderWoodMatReq.ReportSource = mrepWorkOrderWoodMaterialRequirementInfo

    mrepStockItemMaterialRequirement = New repWorkOrderStockItemMaterialRequirement()

    mrepStockItemMaterialRequirement.DataSource = pStockItemMatReqs
    xrSubWorkOrderStockItemMatReq.ReportSource = mrepStockItemMaterialRequirement

    mRepSignatures = New srepWorkOrderSignOffs
    xrsubSigns.ReportSource = mRepSignatures

  End Sub

  Private Function GetOptimalPicHeight(ByVal vNotes As String) As Single
    Dim mRetVal As Single
    Dim mSize As Drawing.SizeF
    Dim mAvailableHeight As Single

    mAvailableHeight = Me.Detail.HeightF
    ''mSize = PrintingSystem.Graph.MeasureString(vNotes, xrNotes.WidthF)
    ''mSize.Height = Math.Max(mSize.Height, xrNotes.HeightF)
    ''mAvailableHeight = mAvailableHeight - (xrNotes.TopF + mSize.Height)

    mRetVal = mAvailableHeight
    Return mRetVal
  End Function

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    ''Dim mFileName As String
    ''Dim mImage As Image

    ''mFileName = clsSMSharedFuncs.GetWOImageFileName(pSalesOrderPhaseItemInfos, pWorkOrder)

    ''If IO.File.Exists(mFileName) Then
    ''  mImage = Drawing.Image.FromFile(mFileName)
    ''End If

    ''xrPic.Image = mImage


  End Sub
End Class