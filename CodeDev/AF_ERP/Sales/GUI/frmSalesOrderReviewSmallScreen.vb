Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmSalesOrderReviewSmallScreen
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
    Dim mfrm As frmSalesOrderReviewSmallScreen
    mfrm = New frmSalesOrderReviewSmallScreen
    mfrm.pFormController = New fccSalesOrderReview(rSalesOrder, rDBConn)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmSalesOrderReviewSmallScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
    pFormController.LoadDataRef()
    LoadGrids()
    RefreshControls()
    Me.Text = "Revisión de Venta # " & pFormController.SalesOrder.OrderNo
  End Sub

  Private Sub RefreshControls()
    txtTotalValueSalesOrder.Text = pFormController.SalesOrder.GetTotalValueWithCarriage.ToString("$#,##0.00;;#")
    txtTotalInvoiced.Text = pFormController.SalesOrder.GetTotalInvoiceValue.ToString("$#,##0.00;;#")


    txtStockItemMatReqCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqReal.ToString("$#,##0.00;;#")
    txtStockItemPickMatCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal.ToString("$#,##0.00;;#")


    txtWoodMatReqCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReq.ToString("$#,##0.00;;#")
    txtWoodPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked.ToString("$#,##0.00;;#")

    txtSOPIMaterialCost.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalMaterialReqiredCost.ToString("$#,##0.00;;#")
    txtEngineeringMaterialCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialEngineeringCost.ToString("$#,##0.00;;#")
    txtTotalSOPIMaterialsPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialPickReal.ToString("$#,##0.00;;#")

    'txtTotalSOPICurrentWoodCost.Text = pFormController.SalesOrderPhaseItemInfo.GetTotalWoodMatReqReal.ToString("$#,##0.00;;#")
    txtSOPIMO.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget.ToString("$#,##0.00;;#")

    txtSOPIOutsourcing.Text = pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget.ToString("$#,##0.00;;#")


    If pFormController.SalesOrder.GetTotalValueWithCarriage > 0 Then
      txtPercentageInvoiced.Text = pFormController.SalesOrder.GetTotalInvoiceValue / pFormController.SalesOrder.GetTotalValueWithCarriage

    End If

    If pFormController.SalesOrder.SalesOrderItems.GetTotalMaterialReqiredCost > 0 Then
      Dim mPercentage As Decimal = 0
      mPercentage = (pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialEngineeringCost / pFormController.SalesOrder.SalesOrderItems.GetTotalMaterialReqiredCost)

      If mPercentage > 0 Then
        txtSIMatReqPercentage.ForeColor = Color.Red
      ElseIf mPercentage < 0 Then
        txtSIMatReqPercentage.ForeColor = Color.Green
      Else
        txtSIMatReqPercentage.ForeColor = Color.Black
      End If
      txtSIMatReqPercentage.Text = mPercentage

    End If
  End Sub

  Private Sub LoadGrids()
    grdCustomerPOs.DataSource = pFormController.CustomerPOInfos
    grdInvoices.DataSource = pFormController.Invoices
    grdPOItemAllocations.DataSource = pFormController.POItemWOAllocationInfos
    grdOtherCategoriesPOItemAllocations.DataSource = pFormController.OtherCategoriesPOItemAllocationInfos
    grdWoodUsage.DataSource = pFormController.WoodPalletItemInfosPicked
    grdWorkOrderInfos.DataSource = pFormController.WorkOrderInfos
    grdPaymentAccounts.DataSource = pFormController.PaymentAccounts
    grdSalesOrderPhaseItemInfo.DataSource = pFormController.SalesOrderPhaseItemInfos
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

  Private Sub grpPOItemInfos_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpPOItemInfos.CustomButtonClick
    Dim mFileName As String = "Exportar Compras Producción " + pFormController.SalesOrder.ProjectName & ".xlsx"
    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvPOItemAllocations.ExportToXlsx(mFileName)
    End If
  End Sub

  Private Sub grpOtherCaterogoriesPurchaseOrder_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpOtherCaterogoriesPurchaseOrder.CustomButtonClick
    Dim mFileName As String = "Exportar Compras Otras Categorías " + pFormController.SalesOrder.ProjectName & ".xlsx"
    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvOtherCategoriesPOItemAllocations.ExportToXlsx(mFileName)
    End If
  End Sub

  Private Sub gvSalesOrderPhaseItemInfo_DoubleClick(sender As Object, e As EventArgs) Handles gvSalesOrderPhaseItemInfo.DoubleClick
    Dim mSelectedColumn As GridColumn
    Dim mCurrentRow As clsSalesOrderPhaseItemInfo
    Try

      mSelectedColumn = gvSalesOrderPhaseItemInfo.FocusedColumn

      gvSalesOrderPhaseItemInfo.CloseEditor()
      mCurrentRow = TryCast(gvSalesOrderPhaseItemInfo.GetFocusedRow, clsSalesOrderPhaseItemInfo)

      If mCurrentRow IsNot Nothing Then
        Select Case mSelectedColumn.Name
          Case gcMatEsp.Name

            frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.MatEspecificados)

          Case gcMatActual.Name
            frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.MatActual)

        End Select
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

End Class