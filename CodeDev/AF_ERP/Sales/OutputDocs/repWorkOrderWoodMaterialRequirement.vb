Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI


Public Class repWorkOrderWoodMaterialRequirement
  Private pMaterialRequirementInfos As colMaterialRequirementInfos

  Private Sub sreprepWorkOrderWoodMaterialRequirement_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepMatReqChanges As repWorkOrderWoodMaterialRequirement

    SetUpBindings()


    'msrepMatReqChanges = New repWorkOrderWoodMaterialRequirement
    'msrepMatReqChanges.DataSource = pMaterialRequirementInfos


  End Sub

  Private Sub SetUpBindings()


    xtcDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xtcOriginalQty.DataBindings.Add("Text", Me.DataSource, "UnitPiece")
    xtcNetLength.DataBindings.Add("Text", Me.DataSource, "NetLenght")
    xtcNetThickness.DataBindings.Add("Text", Me.DataSource, "NetThickness")
    xtcNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth")
    xtcWidthInch.DataBindings.Add("Text", Me.DataSource, "WidthInch")
    xtcThicknessCM.DataBindings.Add("Text", Me.DataSource, "ThicknessCM")
    xtcLengthInch.DataBindings.Add("Text", Me.DataSource, "LengthInch")

  End Sub


  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint


  End Sub
End Class