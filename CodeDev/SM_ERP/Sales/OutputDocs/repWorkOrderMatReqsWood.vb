Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class repWorkOrderMatReqsWood

  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private pQuantity As Int32

  Private Sub repWorkOrderMatReqsWood_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    xrlWorkOrderNo.Text = "OT " & pWorkOrder.WorkOrderNo
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName
    xrlProductDescription.Text = pWorkOrder.Description
    xrtDateEntered.Text = pWorkOrder.PlannedStartDate
    xrtQuantity.Text = pWorkOrder.Quantity
    pQuantity = Val(xrtQuantity.Text)

    SetUpBindings()


  End Sub

  Private Sub SetUpBindings()
    ''xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtComponentDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtUnitPiece.DataBindings.Add("Text", Me.DataSource, "UnitPiece")
    xrtNetThickness.DataBindings.Add("Text", Me.DataSource, "NetThickness")
    xrtNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth")
    xrtNetLenght.DataBindings.Add("Text", Me.DataSource, "NetLenght")
    xrtMaterialTypeID.DataBindings.Add("Text", Me.DataSource, "MaterialTypeID")
    xrtQualityType.DataBindings.Add("Text", Me.DataSource, "QualityType")

    ''Function Area
    xrtGrossThickness.DataBindings.Add("Text", Me.DataSource, "InitialThicknessFraction")
    xrtGrossWidth.DataBindings.Add("Text", Me.DataSource, "InitialWidthFraction")
    xrtGrossLenght.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFraction")
    xrtGrossLenghtFeet.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFractionFeet")
    xrtBoardFeet.DataBindings.Add("Text", Me.DataSource, "TotalBoardFeetFromCM")



    'xrlMatReqDesc.DataBindings.Add("Text", Me.DataSource, "Description")
  End Sub


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos) As repWorkOrderMatReqsWood
    Dim mRetVal As repWorkOrderMatReqsWood

    mRetVal = New repWorkOrderMatReqsWood
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.CreateDocument()

    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    mTool.ShowPreviewDialog()

    Return mRetVal

  End Function

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mMatReq As clsMaterialRequirementInfo
    mMatReq = CType(Me.GetCurrentRow, clsMaterialRequirementInfo)
    If mMatReq IsNot Nothing Then
      xrtcTotalPieces.Text = mMatReq.UnitPiece * pWorkOrder.Quantity
    End If
  End Sub

  Private Sub Detail_AfterPrint(sender As Object, e As EventArgs) Handles Detail.AfterPrint


  End Sub

  Private Sub Detail_TextChanged(sender As Object, e As EventArgs) Handles Detail.TextChanged

  End Sub

  Private Sub repWorkOrderMatReqsWood_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint

  End Sub

  Private Sub repWorkOrderMatReqsWood_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles Me.PrintOnPage
    xrtcTotalPieces.Text = pQuantity * Val(xrtUnitPiece.Text)
  End Sub

  Private Sub Detail_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles Detail.PrintOnPage
    xrtcTotalPieces.Text = pQuantity * Val(xrtUnitPiece.Text)
  End Sub
End Class