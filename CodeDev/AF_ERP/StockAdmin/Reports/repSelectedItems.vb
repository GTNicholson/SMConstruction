Imports System.Drawing.Printing

Public Class repSelectedItems
  Private pStockTakeItemEditors As colStockTakeItemEditors


  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub

  Private Sub repSelectedItems_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpDataBindings()
  End Sub

  Public Shared Function GenerateReport(ByRef rStockTakeItemEditors As colStockTakeItemEditors) As repSelectedItems
    Dim mRep As New repSelectedItems
    mRep.pStockTakeItemEditors = rStockTakeItemEditors
    mRep.DataSource = mRep.pStockTakeItemEditors

    mRep.CreateDocument()

    Return mRep
  End Function

  Private Sub SetUpDataBindings()


    ''xrtStockCode.DataBindings.Add("Text", DataSource, "ItemNumber")



  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mSTIE As clsStockTakeItemEditor


    mSTIE = Me.GetCurrentRow
    If mSTIE IsNot Nothing Then
      xrtStockDescription.Text = mSTIE.StockItem.Description
      xrtCategory.Text = mSTIE.StockItemCategoryDesc
      xrtPartNo.Text = mSTIE.StockItem.PartNo
      xrtSystemQty.Text = mSTIE.StockTakeItem.CountedQty
    End If

  End Sub
End Class