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

    Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    mpt.ShowPreviewDialog()


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
    SetUpDataBindings()
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName
    xrSalesOrderID.Text = pSalesOrder.OrderNo
    xrlProjectName.Text = pSalesOrder.ProjectName
    xrlDateEntered.Text = pSalesOrder.DateEntered
    xrlDueTime.Text = pSalesOrder.DueTime
    xrNotes.Text = pSalesOrder.VisibleNotes
    xrProjectType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).ItemValueToDisplayValue(pSalesOrder.OrderTypeID)


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
  End Sub
End Class