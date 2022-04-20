Public Class repWorkOrderMaintenanceDoc


  'Public Shared Function GenerateReport(ByRef rWorkOrderMaintenanceRepInfos As List(Of clsMaintenanceWorkOrderInfo), ByVal vPurchaseOrderInfo As clsPurchaseOrderInfo, ByVal vDueDate As Date, ByVal vPreview As Boolean, ByVal vStandardText As String, ByVal vPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos) As repPurchaseOrderDoc
  '  Dim mRep As repWorkOrderMaintenanceDoc
  '  Dim mPrintTool As DevExpress.XtraReports.UI.ReportPrintTool
  '  mRep = New repWorkOrderMaintenanceDoc(rPurchaseOrderReportInfos, vPurchaseOrderInfo, vDueDate, vStandardText, vPOItemAllocationInfos)
  '  ''rDespatchReportInfos(0).DespatchLines = vDespatchLines
  '  mRep.DataSource = rPurchaseOrderReportInfos
  '  mRep.DataMember = "PurchaseOrderItemInfos"

  '  mRep.CreateDocument()
  '  If vPreview Then
  '    mPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
  '    mPrintTool.ShowPreviewDialog()
  '    mPrintTool.Dispose()
  '    mPrintTool = Nothing
  '  End If
  '  Return mRep
  'End Function

  'Private Sub SetBindings()

  '  xtcWorkOrderNo.DataBindings.Add("Text", DataSource, "WorkOrderNo")
  '  xtcWorkCenterID.DataBindings.Add("Text", DataSource, "WorkCenterID")

  '  xrDescription.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.Description")
  '  xrQuantity.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.Qty").FormatString = "{0:0.##}"
  '  xrUnitPrice.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.UnitPrice").FormatString = "{0:0.00}"
  '  xrtcVATCode.DataBindings.Add("Text", DataSource, "PurchaseOrderItems.VATRate").FormatString = "{0:0.##%}"
  '  xtcPartNo.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.PartNo")
  'xrtcDiscount.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.DiscountPercentage").FormatString = "{0:0.##%}"
  'xrTotalItemNetPrice.DataBindings.Add("Text", DataSource, "PurchaseOrderItemInfos.Price").FormatString = "{0:0.00}"

  'xrtStandardText.Text = pStandardText
  'xrtStandardText.Html = pStandardText

  'End Sub
End Class