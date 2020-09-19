Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI


Public Class srepWorkOrderMatReqsWoodChanges
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private pQuantity As Int32
  Private pMatReqChanges As colMaterialRequirementInfos

  Private Sub srepWorkOrderMatReqsWoodChanges_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepMatReqChanges As srepWorkOrderMatReqsWoodChanges

    SetUpBindings()


    msrepMatReqChanges = New srepWorkOrderMatReqsWoodChanges
    msrepMatReqChanges.DataSource = pMatReqChanges


  End Sub

  Private Sub SetUpBindings()



    xrlTotalBoardFeet.DataBindings.Add("Text", Me.DataSource, "TotalBoardFeetReport")
    'xrlMatReqDesc.DataBindings.Add("Text", Me.DataSource, "Description")

    ''xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrtComponentDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtcChangeReason.DataBindings.Add("Text", Me.DataSource, "Comments")
    xrtUnitPiece.DataBindings.Add("Text", Me.DataSource, "UnitPiece")
    xrtNetThickness.DataBindings.Add("Text", Me.DataSource, "NetThickness", "{0:#.#}")
    xrtNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth", "{0:#.#}")
    xrtNetLenght.DataBindings.Add("Text", Me.DataSource, "NetLenght", "{0:#.#}")
    xrtGrossLenghtFeet.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFractionFeet")


  End Sub


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

      xrtcDate.Text = mMatReq.DateChange.ToShortDateString
      xrtWoodSpecieID.Text = mWoodSpecieID
      xrtQualityType.Text = mQuality
      xrtMaterialTypeID.Text = mMaterialID
      xrtBoardFeet.Text = mMatReq.TotalBoardFeetReport()

    End If


  End Sub
End Class