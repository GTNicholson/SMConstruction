Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repRequisaMaintenanceSummary

  Private pMaintenanceWorkOrder As dmMaintenanceWorkOrder
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"

  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateRequisaSummaryReport(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors) As XtraReport
    Dim mRep As New repRequisaMaintenanceSummary(rMaintenanceWorkOrder, rMaterialRequirementProcessors)
    Dim mPrintTool As ReportPrintTool
    mRep.CreateDocument()


    mPrintTool = New ReportPrintTool(mRep)
    mPrintTool.ShowPreviewDialog()
    mPrintTool.Dispose()
    mPrintTool = Nothing


    Return mRep
  End Function

  Public Sub New(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pMaintenanceWorkOrder = rMaintenanceWorkOrder
    DataSource = rMaterialRequirementProcessors
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repRequisaWorkOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"

    xtcWorkOrderNo.Text = pMaintenanceWorkOrder.MaintenanceWorkOrderNo
    xtcProyectName.Text = pMaintenanceWorkOrder.Description

    xtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xtcDescription.DataBindings.Add("Text", DataSource, "Description")

    xtcRequiredQty.DataBindings.Add("Text", DataSource, "Quantity", "{0:0.###}")

    xtcRequiredQty.DataBindings.Add("Text", DataSource, "Quantity", "{0:0.###}")

    xtcPickedQty.DataBindings.Add("Text", DataSource, "PickedQty", "{0:0.###}")
    xtcReturnQty.DataBindings.Add("Text", DataSource, "ReturnQty", "{0:0.###}")


    xtcUoM.DataBindings.Add("Text", DataSource, "UoMDescUI")

    xtcArea.DataBindings.Add("Text", DataSource, "AreaDesc")
  End Sub


End Class