Imports System.Drawing.Printing

Public Class repProductFurniture

  Private pProductFurniture As dmProductFurniture

  Public Property ProductFurniture As dmProductFurniture
    Get
      Return pProductFurniture
    End Get
    Set(value As dmProductFurniture)
      pProductFurniture = value
    End Set
  End Property

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim msrepMats As New srepMaterials

    msrepMats.DataSource = pProductFurniture.MaterialRequirments
    subrepMaterials.ReportSource = msrepMats

  End Sub

  Private Sub repProductFurniture_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpBindings()
  End Sub

  Private Sub SetUpBindings()
    xrlNotes.DataBindings.Add("Text", pProductFurniture, "Notes")
  End Sub

End Class