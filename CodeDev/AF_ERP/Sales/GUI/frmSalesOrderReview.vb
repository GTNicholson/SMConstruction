Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
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
    tgsCosting.IsOn = True
    pFormController.CostingMethod = tgsCosting.IsOn
    pFormController.LoadDataRef()


    LoadGrids()
    RefreshControls()
    Me.Text = "Revisión de Venta # " & pFormController.SalesOrder.OrderNo
  End Sub

  Private Sub RefreshControls()
    Dim mPercentage As Decimal = 0

    txtEstimatedInsumosTotalValue.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemEstimatedValue.ToString("$#,##0.00;;#")
    txtWoodTotalEstimatedValue.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodStockItemEstimatedValue.ToString("$#,##0.00;;#")


    txtTotalValueSalesOrder.Text = pFormController.SalesOrder.GetTotalValueWithCarriage.ToString("$#,##0.00;;#")
    txtTotalCostValue.Text = (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue).ToString("$#,##0.00;;#")



    txtStockItemMatReqCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqReal.ToString("$#,##0.00;;#")
    txtStockItemPickMatCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal.ToString("$#,##0.00;;#")


    txtWoodMatReqCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReq.ToString("$#,##0.00;;#")
    txtWoodPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked.ToString("$#,##0.00;;#")

    txtSOPIMaterialCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStimatedValue.ToString("$#,##0.00;;#")
    txtEngineeringMaterialCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialEngineeringCost.ToString("$#,##0.00;;#")
    txtTotalSOPIMaterialsPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialPickReal.ToString("$#,##0.00;;#")

    'txtTotalSOPICurrentWoodCost.Text = pFormController.SalesOrderPhaseItemInfo.GetTotalWoodMatReqReal.ToString("$#,##0.00;;#")
    txtSOPIMO.Text = (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget + pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget).ToString("$#,##0.00;;#")
    txtTotalSOPISubMOValue.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalSubconMOValue.ToString("$#,##0.00;;#")



    If (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue) > 0 Then
      txtPercentageInvoiced.Text = pFormController.SalesOrder.GetTotalValueWithCarriage / (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue)

    End If

    If pFormController.SalesOrderPhaseItemInfos.GetTotalStimatedValue > 0 Then

      mPercentage = (pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialPickReal / pFormController.SalesOrderPhaseItemInfos.GetTotalStimatedValue)

      If mPercentage > 1 Then
        txtSIMatReqPercentage.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtSIMatReqPercentage.ForeColor = Color.Green

      Else
        txtSIMatReqPercentage.ForeColor = Color.Black
      End If
      txtSIMatReqPercentage.Text = mPercentage

    End If

    If pFormController.SalesOrder.GetTotalValueWithCarriage > 0 Then

      mPercentage = ((pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue) / pFormController.SalesOrder.GetTotalValueWithCarriage)

      If mPercentage > 1 Then
        txtPercentageInvoiced.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtPercentageInvoiced.ForeColor = Color.Green

      Else
        txtPercentageInvoiced.ForeColor = Color.Black

      End If
      txtPercentageInvoiced.Text = mPercentage

    End If


    If pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemEstimatedValue > 0 Then
      mPercentage = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal / pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemEstimatedValue

      If mPercentage > 1 Then
        txtInumosPercentage.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtInumosPercentage.ForeColor = Color.Green

      Else
        txtInumosPercentage.ForeColor = Color.Black
      End If
      txtInumosPercentage.Text = mPercentage

    End If

    If pFormController.SalesOrderPhaseItemInfos.GetTotalWoodStockItemEstimatedValue > 0 Then

      mPercentage = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked / pFormController.SalesOrderPhaseItemInfos.GetTotalWoodStockItemEstimatedValue

      If mPercentage > 1 Then
        txtWoodPercentage.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtWoodPercentage.ForeColor = Color.Green

      Else
        txtWoodPercentage.ForeColor = Color.Black
      End If
      txtWoodPercentage.Text = mPercentage

    End If



    If (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget + pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget) > 0 Then
      mPercentage = pFormController.SalesOrderPhaseItemInfos.GetTotalSubconMOValue / (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget + pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget)

      If mPercentage > 1 Then
        txtOutsourcingMOPercetange.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtOutsourcingMOPercetange.ForeColor = Color.Green

      Else
        txtOutsourcingMOPercetange.ForeColor = Color.Black
      End If
      txtOutsourcingMOPercetange.Text = mPercentage

    End If


    'txtTotalWOCompleteValue.Text = pFormController.GetTotalWOCompleteValue().ToString("$#,##0.00;;#")
    'txtTotalWOValueInProcess.Text = pFormController.GetTotalWOInProcessValue().ToString("$#,##0.00;;#")

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
    grdHonorarios.DataSource = pFormController.HonorariosPOIAllocationInfos
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
        Select Case mSelectedColumn.FieldName
          Case "SOPIStockItemMatReqDollarValue"

            frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.InsumosSpecified)

          Case "SpecifiedWoodCost"

            frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.WoodSpecified)



          Case "SOPIPickDollarValue"
            frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.InsumosActual)

            'Case "PickedWoodCost"
            '  frmWorkOrderSalesItemDetails.OpenModal(mCurrentRow, pFormController.DBConn, eOptionMaterialesView.WoodActual)


        End Select
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub GroupControl4_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl4.CustomButtonClick
    Dim mFileName As String = "Exportar Compras Producción " + pFormController.SalesOrder.ProjectName & ".xlsx"
    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvPOHonorarios.ExportToXlsx(mFileName)
    End If
  End Sub

  Private Sub tgsCosting_Toggled(sender As Object, e As EventArgs) Handles tgsCosting.Toggled

    Try
      If pFormController IsNot Nothing Then
        pFormController.CostingMethod = tgsCosting.IsOn
        pFormController.LoadDataRef()
        RefreshControls()
        LoadGrids()
      End If
    Catch ex As Exception

    End Try
  End Sub
End Class