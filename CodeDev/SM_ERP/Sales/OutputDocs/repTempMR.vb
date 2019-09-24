Imports System.Drawing.Printing

Public Class repTempMR
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder

  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos) As repTempMR
    Dim mRetVal As repTempMR

    mRetVal = New repTempMR
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.CreateDocument()

    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    mTool.ShowPreviewDialog()

    Return mRetVal
  End Function

  Private Sub repTempMR_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpBindings()
  End Sub

  Private Sub SetUpBindings()
    xrlOTNumber.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrlMatReqDesc.DataBindings.Add("Text", Me.DataSource, "Description")
  End Sub

End Class