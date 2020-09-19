Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class repWorkOrderMatReqsWood

  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private pQuantity As Int32
  Private pMatReqChanges As colMaterialRequirementInfos

  Private Sub repWorkOrderMatReqsWood_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepMatReqChanges As srepWorkOrderMatReqsWoodChanges

    If pWorkOrder.isInternal = False Then
      xrlCustomerName.Text = pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName
    End If

    xrlWorkOrderNo.Text = pWorkOrder.WorkOrderNo
    xrlProductDescription.Text = pWorkOrder.Description
    xrtDateEntered.Text = pWorkOrder.PlannedStartDate
    xrtQuantity.Text = pWorkOrder.Quantity


    SetUpBindings()


    msrepMatReqChanges = New srepWorkOrderMatReqsWoodChanges
    msrepMatReqChanges.DataSource = pMatReqChanges
    subrepMatReqChanges.ReportSource = msrepMatReqChanges

  End Sub

  Private Sub SetUpBindings()




    xrlTotalBoardFeet.DataBindings.Add("Text", Me.DataSource, "TotalBoardFeetReport")
    'xrlMatReqDesc.DataBindings.Add("Text", Me.DataSource, "Description")

    ''xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtComponentDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtUnitPiece.DataBindings.Add("Text", Me.DataSource, "UnitPiece")
    xrtNetThickness.DataBindings.Add("Text", Me.DataSource, "NetThickness", "{0:#.#}")
    xrtNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth", "{0:#.#}")
    xrtNetLenght.DataBindings.Add("Text", Me.DataSource, "NetLenght", "{0:#.#}")

    ''xrtcTotalPieces.DataBindings.Add("Text", Me.DataSource, "TotalPieces_SMM", "{0:#.#}")

    ''Function Area
    xrtGrossThickness.DataBindings.Add("Text", Me.DataSource, "InitialThicknessFraction")
    xrtGrossWidth.DataBindings.Add("Text", Me.DataSource, "InitialWidthFraction")
    xrtGrossLenght.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFraction")
    xrtGrossLenghtFeet.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFractionFeet")
    'xrtBoardFeet.DataBindings.Add("Text", Me.DataSource, "TotalBoardFeetFromCM")


  End Sub


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos, ByRef rMatReqChanges As colMaterialRequirementInfos) As repWorkOrderMatReqsWood
    Dim mRetVal As repWorkOrderMatReqsWood

    mRetVal = New repWorkOrderMatReqsWood
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.pMatReqChanges = rMatReqChanges

    mRetVal.CreateDocument()

    'Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    'mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    'mTool.ShowPreviewDialog()

    Return mRetVal

  End Function

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mWoodSpecieID As String
    Dim mQuality As String
    Dim mMaterialID As String



    Dim mMatReq As clsMaterialRequirementInfo
    mMatReq = CType(Me.GetCurrentRow, clsMaterialRequirementInfo)
    If mMatReq IsNot Nothing Then
      xrtcTotalPieces.Text = mMatReq.TotalPieces ' (mMatReq.UnitPiece * pWorkOrder.Quantity) / mMatReq

      mWoodSpecieID = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).
                                   ItemValueToDisplayValue(mMatReq.WoodSpecieID)

      mQuality = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Quality).
                                        ItemValueToDisplayValue(mMatReq.QualityType)

      mMaterialID = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Material).
                                        ItemValueToDisplayValue(mMatReq.Material)

      xrtWoodSpecieID.Text = mWoodSpecieID
      xrtQualityType.Text = mQuality
      xrtMaterialTypeID.Text = mMaterialID
      xrtBoardFeet.Text = mMatReq.TotalBoardFeetReport()

    End If




  End Sub

  Private Sub Detail_AfterPrint(sender As Object, e As EventArgs) Handles Detail.AfterPrint


  End Sub

  Private Sub Detail_TextChanged(sender As Object, e As EventArgs) Handles Detail.TextChanged

  End Sub

  Private Sub repWorkOrderMatReqsWood_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint

  End Sub

  Private Sub repWorkOrderMatReqsWood_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles Me.PrintOnPage

  End Sub

  Private Sub Detail_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles Detail.PrintOnPage

  End Sub

  Private Sub ReportFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportFooter.BeforePrint

  End Sub
End Class