Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderPhaseItemInfos As colWorkOrderAllocationEditors
  Private pFurniture As dmProductFurniture


  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByRef rWorkOrderAllocations As colWorkOrderAllocationEditors) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.pFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
    mRep.pSalesOrderPhaseItemInfos = rWorkOrderAllocations
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
    xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtCantidad.DataBindings.Add("Text", pWorkOrder, "Quantity")


  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mProduct As dmProductBase
    Dim mPicHeight As Single
    Dim mRepWorkOrderAllocation As repWorkOrderAllocation

    Select Case pWorkOrder.Product.ItemType
      Case eProductType.StructureAF
        mProduct = TryCast(pWorkOrder.Product, dmProductStructure)
        xrtProductCode.Text = TryCast(pWorkOrder.Product, dmProductStructure).Code
        xrlDescription.Text = TryCast(pWorkOrder.Product, dmProductStructure).Description
      Case Else
        mProduct = TryCast(pWorkOrder.Product, dmProductStructure)

    End Select


    SetUpDataBindings()


      xrlOT2.Text = pWorkOrder.WorkOrderNo
      xrlDrawingDate.Text = pWorkOrder.DrawingDate
      xrtFinishDate.Text = pWorkOrder.PlannedDeliverDate
      xrtDate.Text = pWorkOrder.PlannedStartDate


    If IsNothing(mProduct) Then
        MessageBox.Show("Error, no existe ningún producto / componente ligado a esta Orden de Trabajo", "Error")

        Return

      End If

    ''xrNotes.Text = mPF.Notes

    '// Optimise Image size so that it fits on what remains of the page after the notext

    ''xrPic.HeightF = mPicHeight

    mRepWorkOrderAllocation = New repWorkOrderAllocation
    mRepWorkOrderAllocation.DataSource = pSalesOrderPhaseItemInfos
    xrSubWorkOrderAllocation.ReportSource = mRepWorkOrderAllocation
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