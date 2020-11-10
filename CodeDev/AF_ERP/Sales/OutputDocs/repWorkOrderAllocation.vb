Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI


Public Class repWorkOrderAllocation
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos

  Private Sub srepWorkOrderMatReqsWoodChanges_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepMatReqChanges As repWorkOrderAllocation

    SetUpBindings()


    msrepMatReqChanges = New repWorkOrderAllocation
    msrepMatReqChanges.DataSource = pSalesOrderPhaseItemInfos


  End Sub

  Private Sub SetUpBindings()


    xrtSalesOrderNo.DataBindings.Add("Text", Me.DataSource, "SalesOrderNo")
    xrtSalesItemType.DataBindings.Add("Text", Me.DataSource, "SalesItemTypeDesc")
    xrtItemNumber.DataBindings.Add("Text", Me.DataSource, "ItemNumber")
    xrtClientName.DataBindings.Add("Text", Me.DataSource, "ClientName")
    xrtProjectName.DataBindings.Add("Text", Me.DataSource, "ProjectName")
    xrtRequiredDate.DataBindings.Add("Text", Me.DataSource, "RequiredDate", "{0:dd/MM/yyyy}")

    ''xrlTotalBoardFeet.DataBindings.Add("Text", Me.DataSource, "TotalBoardFeetReport")


  End Sub


  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint


  End Sub
End Class