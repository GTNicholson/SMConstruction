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
    xtcNetLength.DataBindings.Add("Text", Me.DataSource, "NetLenght", "{0:#.#}")

    xtcNetWidth.DataBindings.Add("Text", Me.DataSource, "NetWidth", "{0:#.#}")

    xtcThicknessCM.DataBindings.Add("Text", Me.DataSource, "NetThickness", "{0:#.#}")

    xtcBoardFeet.DataBindings.Add("Text", Me.DataSource, "BoardFeetPerLine", "{0:#.#0}")
    xtcSpecieDesc.DataBindings.Add("Text", Me.DataSource, "WoodSpecieDesc")

    xtcThicknessInch.DataBindings.Add("Text", Me.DataSource, "InitialThicknessFraction")
    xtcLengthInch.DataBindings.Add("Text", Me.DataSource, "InitialLenghtFraction")
    xtcWidthInch.DataBindings.Add("Text", Me.DataSource, "InitialWidthFraction")

  End Sub



End Class