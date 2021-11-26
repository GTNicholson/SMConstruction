Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder
  Private pWoodMatReqs As colMaterialRequirements
  Private pStockItemMatReqs As colMaterialRequirements
  Private pFurniture As dmProductFurniture
  Private pProjectName As String
  Private pCustomerName As String
  Private pOrderNo As String
  Private pFinishDate As Date

  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByVal vProjectName As String, ByVal vCustomerName As String, ByVal vOrderNo As String, ByVal vFinishDate As Date) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.pProjectName = vProjectName
    mRep.pWoodMatReqs = rWorkOrder.WoodMaterialRequirements
    mRep.pStockItemMatReqs = rWorkOrder.StockItemMaterialRequirements
    mRep.pCustomerName = vCustomerName
    mRep.pOrderNo = vOrderNo
    mRep.pFinishDate = vFinishDate
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
    xtcWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xtcProjectName.Text = pProjectName
    xtcOrderNo.Text = pOrderNo
    xtcCustomerName.Text = pCustomerName
    xtcQuantity.Text = pWorkOrder.Quantity
    xtcDescription.DataBindings.Add("Text", pWorkOrder, "Description")
    xtcEmployee.DataBindings.Add("Text", pWorkOrder, "EmployeeDesc")


    If pFinishDate = Date.MinValue Then

    Else
      xtcFinishDate.Text = pFinishDate.Date.ToString("dd/MM/yyyy")

    End If


    If pWorkOrder.PlannedDeliverDate = Date.MinValue Then

    Else
      xtcDueDate.DataBindings.Add("Text", pWorkOrder, "PlannedDeliverDate", "{0:dd/MM/yyyy}")

    End If

    If pWorkOrder.DateCreated = Date.MinValue Then

    Else
      xtcCreatedDate.DataBindings.Add("Text", pWorkOrder, "DateCreated", "{0:dd/MM/yyyy}")

    End If

    If pWorkOrder.PlannedStartDate = Date.MinValue Then

    Else
      xtcPlannedStartDate.DataBindings.Add("Text", pWorkOrder, "PlannedStartDate", "{0:dd/MM/yyyy}")

    End If

    If pWorkOrder.PurchasingDate = Date.MinValue Then

    Else
      xtcPurchasingDate.DataBindings.Add("Text", pWorkOrder, "PurchasingDate", "{0:dd/MM/yyyy}")

    End If


  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    'Dim mProduct As dmProductBase
    'Dim mPicHeight As Single
    Dim mrepWorkOrderWoodMaterialRequirementInfo As repWorkOrderWoodMaterialRequirement
    Dim mrepStockItemMaterialRequirement As repWorkOrderStockItemMaterialRequirement

    Dim mFileName As String
    Dim mImage As Image


    SetUpDataBindings()

    xtcTotalBoardFeet.Text = pWorkOrder.WoodMaterialRequirements.GetTotalBoardFeets().ToString("n3")

    mrepWorkOrderWoodMaterialRequirementInfo = New repWorkOrderWoodMaterialRequirement
    mrepWorkOrderWoodMaterialRequirementInfo.DataSource = pWoodMatReqs
    xrSubWorkOrderWoodMatReq.ReportSource = mrepWorkOrderWoodMaterialRequirementInfo

    mrepStockItemMaterialRequirement = New repWorkOrderStockItemMaterialRequirement()

    mrepStockItemMaterialRequirement.DataSource = pStockItemMatReqs.OrderBy(Function(x) x.AreaDesc)
    xrSubWorkOrderStockItemMatReq.ReportSource = mrepStockItemMaterialRequirement


    'mFileName = clsSMSharedFuncs.GetWOImageFileName(pSalesOrderPhaseItemInfos, pWorkOrder)

    'If IO.File.Exists(mFileName) Then
    '  mImage = Drawing.Image.FromFile(mFileName)
    'End If

    'xrPic.Image = mImage


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