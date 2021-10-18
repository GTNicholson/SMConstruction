Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repRequisaWorkOrder

  Private pWorkOrderInfo As clsWorkOrderInfo
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"

  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreatePODeliveryReport(ByRef rWorkOrderInfo As clsWorkOrderInfo, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors) As XtraReport
    Dim mRep As New repRequisaWorkOrder(rWorkOrderInfo, rMaterialRequirementProcessors)
    Dim mPrintTool As ReportPrintTool
    mRep.CreateDocument()


    mPrintTool = New ReportPrintTool(mRep)
    mPrintTool.ShowPreviewDialog()
    mPrintTool.Dispose()
    mPrintTool = Nothing


    Return mRep
  End Function

  Public Sub New(ByRef rWorkOrderInfo As clsWorkOrderInfo, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pWorkOrderInfo = rWorkOrderInfo
    DataSource = rMaterialRequirementProcessors
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repRequisaWorkOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"

    xrUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice", mCurrentFormat)
    xrtVATAmount.DataBindings.Add("Text", DataSource, "VATAmount", mCurrentFormat)



    xrQuantity.DataBindings.Add("Text", DataSource, "DelItemQty", "{0:0.###}")

    xrNetTotal.DataBindings.Add("Text", DataSource, "TotalPriceByDelItemQty", mCurrentFormat)


    xrtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xrtcRefCodes.DataBindings.Add("Text", DataSource, "PurchaseRefCodes")
    xrUoM.DataBindings.Add("Text", DataSource, "UoMDescription")




    xrtcDescription.DataBindings.Add("Text", DataSource, "Description")



  End Sub


End Class