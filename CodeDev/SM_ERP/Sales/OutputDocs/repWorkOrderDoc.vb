Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pFurniture As dmProductFurniture


  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.pFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
    mRep.pSalesOrder = rSalesOrder
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
    xrlDescription.DataBindings.Add("Text", pWorkOrder, "Description")
    xrtCantidad.DataBindings.Add("Text", pWorkOrder, "Quantity")


  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mPF As dmProductFurniture
    Dim mPicHeight As Single
    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    XrSubreport1.ReportSource = New srepWorkOrderSignOffs

    SetUpDataBindings()
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName
    xrSalesOrderID.Text = pSalesOrder.OrderNo
    xrlOT2.Text = pWorkOrder.WorkOrderNo
    xrlDateEntered.Text = pSalesOrder.DateEntered
    xrtFinishDate.Text = pSalesOrder.FinishDate
    xrtDate.Text = pWorkOrder.PlannedStartDate
    xrtEmployeeID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pWorkOrder.EmployeeID)
    xrtEmployee2.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pWorkOrder.EmployeeID)
    xrtSalesOrderItemNumber.Text = pWorkOrder.ParentSalesOrderItem.ItemNumber


    If IsNothing(mPF) Then
      MessageBox.Show("Error, no existe ningún producto / componente ligado a esta Orden de Trabajo", "Error")

      Return

    End If

    xrNotes.Text = mPF.Notes

    '// Optimise Image size so that it fits on what remains of the page after the notext
    mPicHeight = GetOptimalPicHeight(mPF.Notes)
    xrPic.HeightF = mPicHeight

  End Sub

  Private Function GetOptimalPicHeight(ByVal vNotes As String) As Single
    Dim mRetVal As Single
    Dim mSize As Drawing.SizeF
    Dim mAvailableHeight As Single

    mAvailableHeight = Me.Detail.HeightF
    mSize = PrintingSystem.Graph.MeasureString(vNotes, xrNotes.WidthF)
    mSize.Height = Math.Max(mSize.Height, xrNotes.HeightF)
    mAvailableHeight = mAvailableHeight - (xrNotes.TopF + mSize.Height)

    mRetVal = mAvailableHeight
    Return mRetVal
  End Function

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mFileName As String
    Dim mImage As Image

    mFileName = clsSMSharedFuncs.GetWOImageFileName(pSalesOrder, pWorkOrder)

    If IO.File.Exists(mFileName) Then
      mImage = Drawing.Image.FromFile(mFileName)
    End If

    xrPic.Image = mImage


  End Sub
End Class