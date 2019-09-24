Imports System.Drawing.Printing

Public Class repWorkOrderMatReqsWood

  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder

  Private Sub repWorkOrderMatReqsWood_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    xrlWorkOrderNo.Text = "OT " & pWorkOrder.WorkOrderNo
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName
    xrlProductDescription.Text = pWorkOrder.Description
    xrtDateEntered.Text = pWorkOrder.PlannedStartDate

    SetUpBindings()
  End Sub

  Private Sub SetUpBindings()
    ''xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtComponentDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtUnitPiece.DataBindings.Add("Text", Me.DataSource, "UnitPiece")
    xrtNetThickness.DataBindings.Add("Text", Me.DataSource, "NetThickness")
    xrtNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth")
    xrtNetLenght.DataBindings.Add("Text", Me.DataSource, "NetLenght")
    xrtMaterialTypeID.DataBindings.Add("Text", Me.DataSource, "MaterialTypeID")
    xrtQualityType.DataBindings.Add("Text", Me.DataSource, "QualityType")
    'xrlMatReqDesc.DataBindings.Add("Text", Me.DataSource, "Description")
  End Sub


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos) As repWorkOrderMatReqsWood
    Dim mRetVal As repWorkOrderMatReqsWood

    mRetVal = New repWorkOrderMatReqsWood
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.CreateDocument()

    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    mTool.ShowPreviewDialog()

    Return mRetVal

  End Function




End Class