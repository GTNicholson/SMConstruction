
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmSalesOrderReview_New
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
    Dim mfrm As frmSalesOrderReview_New
    mfrm = New frmSalesOrderReview_New
    mfrm.pFormController = New fccSalesOrderReview(rSalesOrder, rDBConn)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmSalesOrderReview_New_Load(sender As Object, e As EventArgs) Handles Me.Load
    pFormController.LoadDataRef()
    LoadGrids()
    RefreshControls()
    Me.Text = "Revisión de Venta # " & pFormController.SalesOrder.OrderNo
  End Sub

  Private Sub RefreshControls()
    Dim mPercentage As Decimal = 0
    Dim mProfit As Decimal

    txtEstimatedInsumosTotalValue.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemEstimatedValue.ToString("$#,##0.00;;#")
    txtWoodTotalEstimatedValue.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodStockItemEstimatedValue.ToString("$#,##0.00;;#")


    txtTotalValueSalesOrder.Text = pFormController.SalesOrder.GetTotalValueWithCarriage.ToString("$#,##0.00;;#")
    txtTotalCostValue.Text = (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pFormController.TotalIndirectCost + +pFormController.SalesOrderPhaseItemInfos.GetTotalActualManPowerValue).ToString("$#,##0.00;;#")

    txtOrderNo.Text = pFormController.SalesOrder.OrderNo
    txtProjectName.Text = pFormController.SalesOrder.ProjectName
    If pFormController.SalesOrder.Customer IsNot Nothing Then
      txtClientName.Text = pFormController.SalesOrder.Customer.CompanyName
    Else
      txtClientName.Text = ""
    End If
    txtRequiredDate.Text = pFormController.SalesOrder.SalesOrderPhases(0).DateRequired
    txtDateCreated.Text = pFormController.SalesOrder.DateEntered.ToShortDateString
    txtProjectOwner.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pFormController.SalesOrder.ContractManagerID)

    txtStockItemPickMatCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal.ToString("$#,##0.00;;#")
    txtWoodPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked.ToString("$#,##0.00;;#")
    txtSOPIMaterialCost.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalStimatedValue.ToString("$#,##0.00;;#")

    txtTotalSOPIMaterialsPick.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalMaterialPickReal.ToString("$#,##0.00;;#")

    txtSOPIOutsourcing.Text = (pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget).ToString("$#,##0.00;;#")
    txtTotalSOPIOutsourcing.Text = pFormController.SalesOrderPhaseItemInfos.GetTotalSubconValue.ToString("$#,##0.00;;#")

    txtSOPIManPower.Text = (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget).ToString("$#,##0.00;;#")
    txtActualSOPIManPower.Text = pFormController.SalesOrderPhaseItemInfos.GetActualMOSOPI.ToString("$#,##0.00;;#")

    mProfit = (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pFormController.TotalIndirectCost + +pFormController.SalesOrderPhaseItemInfos.GetTotalActualManPowerValue)

    mProfit = pFormController.SalesOrder.GetTotalValueWithCarriage - mProfit
    txtProfit.Text = mProfit.ToString("$#,##0.00;;#")
    If mProfit >= 0 Then
      txtProfitLabel.Text = "Utilidad"
      txtProfit.BackColor = Color.Green
      txtProfit.ForeColor = Color.White
    Else
      txtProfitLabel.Text = "Pérdida"
      txtProfit.BackColor = Color.Red
      txtProfit.ForeColor = Color.White

    End If

    If (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue) > 0 Then
      txtPercentageInvoiced.Text = pFormController.SalesOrder.GetTotalValueWithCarriage / (pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pFormController.TotalIndirectCost)

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

      mPercentage = ((pFormController.SalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pFormController.SalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pFormController.SalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pFormController.TotalIndirectCost) / pFormController.SalesOrder.GetTotalValueWithCarriage)

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



    If (pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget) > 0 Then
      mPercentage = pFormController.SalesOrderPhaseItemInfos.GetTotalSubconValue / (pFormController.SalesOrder.SalesOrderItems.GetTotalOutsourcingBudget)

      If mPercentage > 1 Then
        txtOutsourcingPercetange.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtOutsourcingPercetange.ForeColor = Color.Green

      Else
        txtOutsourcingPercetange.ForeColor = Color.Black
      End If
      txtOutsourcingPercetange.Text = mPercentage

    End If




    If (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget) > 0 Then
      mPercentage = pFormController.SalesOrderPhaseItemInfos.GetTotalActualManPowerValue / (pFormController.SalesOrder.SalesOrderItems.GetTotalMOBudget)

      If mPercentage > 1 Then
        txtManPowerPercentage.ForeColor = Color.Red
      ElseIf mPercentage < 1 Then
        txtManPowerPercentage.ForeColor = Color.Green

      Else
        txtManPowerPercentage.ForeColor = Color.Black
      End If
      txtManPowerPercentage.Text = mPercentage

    End If

    txtIndirectCost.Text = pFormController.TotalIndirectCost
    'txtTotalWOCompleteValue.Text = pFormController.GetTotalWOCompleteValue().ToString("$#,##0.00;;#")
    'txtTotalWOValueInProcess.Text = pFormController.GetTotalWOInProcessValue().ToString("$#,##0.00;;#")

  End Sub

  Private Sub LoadGrids()
    grdSpeciesByOT.DataSource = pFormController.WoodPalletItemInfosPicked
    'grdCustomerPOs.DataSource = pFormController.CustomerPOInfos
    'grdInvoices.DataSource = pFormController.Invoices
    'grdPOItemAllocations.DataSource = pFormController.POItemWOAllocationInfos
    'grdOtherCategoriesPOItemAllocations.DataSource = pFormController.OtherCategoriesPOItemAllocationInfos
    'grdWoodUsage.DataSource = pFormController.WoodPalletItemInfosPicked
    'grdWorkOrderInfos.DataSource = pFormController.WorkOrderInfos
    'grdPaymentAccounts.DataSource = pFormController.PaymentAccounts
    grdSalesOrderPhaseItemInfo.DataSource = pFormController.SalesOrderPhaseItemInfos
    grdMaterials.DataSource = pFormController.MaterialsByCategories
    grdTimeSheetEntry.DataSource = pFormController.TimeSheetProjects
    chrTimeSheet.DataSource = pFormController.TimeSheetProjects
    chrWoodPalletItemInfo.DataSource = pFormController.WoodPalletItemInfosPicked
    chrOtherExpenses.DataSource = pFormController.MaterialsByCategories
  End Sub


  Private Sub txtIndirectCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtIndirectCost.EditValueChanged
    Dim mIndirectCost As Decimal

    If pFormController IsNot Nothing Then

      If IsNumeric(txtIndirectCost.Text) Then
        mIndirectCost = Decimal.Parse(txtIndirectCost.Text)

        pFormController.TotalIndirectCost = mIndirectCost
        RefreshControls()
      End If


    End If
  End Sub

  Private Sub frmSalesOrderReview_New_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    If pFormController.TotalIndirectCost > 0 Then

      pFormController.UpdateIndirectCost()

    End If


  End Sub

  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    Dim mFilePath As String = String.Empty
    Dim mWorkBook As Workbook

    mWorkBook = pFormController.GetExcelSalesProjectReviewDetail(pFormController.SalesOrder, pFormController.SalesOrderPhaseItemInfos)

    pFormController.CreateExcelProjectReview(mWorkBook)
    mFilePath = mWorkBook.Path
    If System.IO.File.Exists(mFilePath) Then
      frmSpreadSheetControl.OpenFormModal(mFilePath)
    End If

  End Sub
End Class