Imports System.Drawing.Printing

Public Class repOtherMaterials
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder

  Private Sub repOtherMaterials_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName = " / " & pSalesOrder.ProjectName
    xrtProductDescription.Text = pWorkOrder.Description
    xrtQuantity.Text = pWorkOrder.Quantity


    SetUpBindings()
  End Sub

  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos) As repOtherMaterials
    Dim mRetVal As repOtherMaterials

    mRetVal = New repOtherMaterials
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.CreateDocument()

    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    mTool.ShowPreviewDialog()

    Return mRetVal
  End Function
  Private Sub SetUpBindings()
    xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtMaterialDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtMaterialQuantity.DataBindings.Add("Text", Me.DataSource, "Quantity")
  End Sub


End Class