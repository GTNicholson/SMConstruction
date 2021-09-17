Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmWorkOrderSalesItemDetails
  Private pFormController As fccWorkOrderSalesItemDetails

  Public Shared Sub OpenModal(ByRef pSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo, ByRef rDBConn As clsDBConnBase, ByVal vOptionMat As eOptionMaterialesView)
    Dim mfrm As frmWorkOrderSalesItemDetails
    mfrm = New frmWorkOrderSalesItemDetails
    mfrm.pFormController = New fccWorkOrderSalesItemDetails(pSalesOrderPhaseItemInfo, rDBConn, vOptionMat)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmWorkOrderSalesItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pFormController.LoadDataRef()
    LoadGrids()
    RefreshControls()

    Select Case pFormController.OptionMaterialesView
      Case eOptionMaterialesView.MatEspecificados
        Me.Text = "Revisión de Materiales Específicados de " & pFormController.SalesOrderPhaseItemInfo.Description

      Case eOptionMaterialesView.MatActual
        Me.Text = "Revisión de Materiales Despachados de " & pFormController.SalesOrderPhaseItemInfo.Description

    End Select
  End Sub

  Private Sub RefreshControls()

    Select Case pFormController.OptionMaterialesView
      Case eOptionMaterialesView.MatEspecificados
        xtpInsumos.Visible = True
        xtpWood.Visible = True
        gcDespatchQty.Visible = False
        gcReqQty.Visible = False
        gcDespatchTotalCost.Visible = False
        gcTotalCost.Visible = True
        xtcMaterials.TabPages(0).PageVisible = True

      Case eOptionMaterialesView.MatActual
        xtpInsumos.Visible = True
        xtpWood.Visible = False
        xtcMaterials.TabPages(0).PageVisible = False
        gcDespatchQty.Visible = True
        gcReqQty.Visible = False
        gcDespatchTotalCost.Visible = True
        gcTotalCost.Visible = False
    End Select
  End Sub

  Private Sub LoadGrids()

    grdMaterialRequirementWood.DataSource = pFormController.MaterialRequirementInfoWoods
    grdStockItemMatReq.DataSource = pFormController.MaterialRequirementInfoInsumos
  End Sub

  Private Sub gvStockItemMatReq_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWoodMatReq.CustomUnboundColumnData
    Dim mMatReq As clsMaterialRequirementInfo

    mMatReq = TryCast(e.Row, clsMaterialRequirementInfo)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcTotalQuantity.Name
          If e.IsGetData Then
            e.Value = (mMatReq.UnitPiece * pFormController.SalesOrderPhaseItemInfo.WOAQuantity)

          End If
          If e.IsSetData Then
            'mMatReq.PiecesPerComponent = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / e.Value
          End If
        Case gcQtyBoardFeet.Name
          Dim mValue As Decimal
          Dim mQty As Integer
          If e.IsGetData Then
            Try

              mQty = (mMatReq.UnitPiece * pFormController.SalesOrderPhaseItemInfo.WOAQuantity)

              mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)

              ''mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mMatReq.TotalPieces, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)
              mValue = mValue
              e.Value = mValue


            Catch ex As Exception
              If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
            End Try

          End If

        Case gcTotalCostWood.Name
          If e.IsGetData Then
            Dim mTotalBoardFeet As Decimal
            Dim mQty As Integer

            mQty = (mMatReq.UnitPiece * pFormController.SalesOrderPhaseItemInfo.WOAQuantity)

            mTotalBoardFeet = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)

            e.Value = mTotalBoardFeet * mMatReq.AverageCost
          End If
      End Select
    End If
  End Sub

  Private Sub gvStockItemMatReq_CustomUnboundColumnData_1(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItemMatReq.CustomUnboundColumnData
    Dim mMatReq As clsMaterialRequirementInfo

    mMatReq = TryCast(e.Row, clsMaterialRequirementInfo)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcTotalCost.Name
          If e.IsGetData Then
            e.Value = (mMatReq.AverageCostUSDInsumos * (pFormController.SalesOrderPhaseItemInfo.WOAQuantity * mMatReq.Quantity))

          End If
          If e.IsSetData Then
            'mMatReq.PiecesPerComponent = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / e.Value
          End If

        Case gcDespatchTotalCost.Name
          If e.IsGetData Then
            e.Value = (mMatReq.AverageCostUSDInsumos * (pFormController.SalesOrderPhaseItemInfo.WOAQuantity * mMatReq.PickedQty))

          End If

      End Select
    End If
  End Sub
End Class