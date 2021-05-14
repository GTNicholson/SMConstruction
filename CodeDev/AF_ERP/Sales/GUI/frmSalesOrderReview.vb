Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.DataLayer

Public Class frmSalesOrderReview
  Private pFormController As fccSalesOrderReview

  Public Property FormController As fccSalesOrderReview
    Get
      Return pFormController
    End Get
    Set(value As fccSalesOrderReview)
      pFormController = value
    End Set
  End Property
  Public Shared Sub OpenModal(ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As clsDBConnBase)
    Dim mfrm As frmSalesOrderReview
    mfrm = New frmSalesOrderReview
    mfrm.pFormController = New fccSalesOrderReview(rSalesOrder, rDBConn)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmSalesOrderReview_Load(sender As Object, e As EventArgs) Handles Me.Load
    pFormController.LoadDataRef()
    LoadGrids()
    RefreshControls()
    Me.Text = "Revisión de Venta # " & pFormController.SalesOrder.OrderNo
  End Sub

  Private Sub RefreshControls()
    txtTotalValueSalesOrder.Text = pFormController.SalesOrder.GetTotalValueWithCarriage.ToString("$#,##0.00;;#")
    txtTotalInvoiced.Text = pFormController.SalesOrder.GetTotalInvoiceValue.ToString("$#,##0.00;;#")

    txtSOPIStockItemMatReq.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalStockItemMatReqBudget.ToString("$#,##0.00;;#")
    txtTotalSOPICurrentCost.Text = pFormController.SalesOrderPhaseItemInfo.GetTotalStockItemMatReqReal.ToString("$#,##0.00;;#")

    txtSOPIWoodMatReq.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalWoodMatReqBudget.ToString("$#,##0.00;;#")
    'txtTotalSOPICurrentWoodCost.Text = pFormController.SalesOrderPhaseItemInfo.GetTotalWoodMatReqReal.ToString("$#,##0.00;;#")
    txtSOPIMO.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget.ToString("$#,##0.00;;#")

    txtSOPIOutsourcing.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget.ToString("$#,##0.00;;#")


    If pFormController.SalesOrder.GetTotalValueWithCarriage > 0 Then
      txtPercentageInvoiced.Text = pFormController.SalesOrder.GetTotalInvoiceValue / pFormController.SalesOrder.GetTotalValueWithCarriage

    End If

    If pFormController.SalesOrder.SalesOrderItems.GetTotalStockItemMatReqBudget > 0 Then
      txtSIMatReqPercentage.Text = pFormController.SalesOrderPhaseItemInfo.GetTotalStockItemMatReqReal / pFormController.SalesOrder.SalesOrderItems.GetTotalStockItemMatReqBudget

    End If
  End Sub

  Private Sub LoadGrids()
    grdCustomerPOs.DataSource = pFormController.CustomerPOInfos
    grdInvoices.DataSource = pFormController.Invoices
    grdPOItemAllocations.DataSource = pFormController.POItemAllocationInfos
    grdWoodUsage.DataSource = pFormController.WoodRequirementInfos
    grdWorkOrderInfos.DataSource = pFormController.WorkOrderInfos
    grdPaymentAccounts.DataSource = pFormController.PaymentAccounts
    grdSalesOrderPhaseItemInfo.DataSource = pFormController.SalesOrderPhaseItemInfo
  End Sub

  Private Sub gvPOItemAllocations_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gvPOItemAllocations.RowCellStyle

    Dim mGView As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, GridView)
    Dim mCurrentRow As clsPurchaseOrderItemAllocationInfo
    Dim mPercentage As Decimal

    mCurrentRow = TryCast(mGView.GetRow(e.RowHandle), clsPurchaseOrderItemAllocationInfo)

    If mCurrentRow IsNot Nothing Then
      If mCurrentRow.TotalPurchaseOrderItemAmountUSD > 0 Then
        mPercentage = mCurrentRow.Balance / mCurrentRow.TotalPurchaseOrderItemAmountUSD

        mPercentage = (mPercentage * 100)
        If mCurrentRow.Balance > 5 Then
          Select Case e.Column.FieldName
            Case "Balance"
              e.Appearance.BackColor = Color.DarkRed
              e.Appearance.ForeColor = Color.White
            Case Else
              e.Appearance.BackColor = Color.Transparent
              e.Appearance.ForeColor = Color.Black

          End Select

        ElseIf mCurrentRow.Balance < -5 Then
          Select Case e.Column.FieldName
            Case "Balance"
              e.Appearance.BackColor = Color.LightGreen

            Case Else
              e.Appearance.BackColor = Color.Transparent
              e.Appearance.ForeColor = Color.Black

          End Select

        Else
          Select Case e.Column.FieldName
            Case "Balance"
              e.Appearance.BackColor = Color.Transparent
              e.Appearance.ForeColor = Color.Black

            Case Else
              e.Appearance.BackColor = Color.Transparent
              e.Appearance.ForeColor = Color.Black

          End Select
        End If


      End If


    End If


  End Sub
End Class