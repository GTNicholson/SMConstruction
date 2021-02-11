Imports System.Drawing.Printing

Public Class repoListToStockTake
  Private pStockItemInfos As colStockTakeItemEditors

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub

  Private Sub repSelectedItems_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpDataBindings()

  End Sub

  Public Shared Function GenerateReport(ByRef rStockItemInfos As colStockTakeItemEditors) As repoListToStockTake
    Dim mRep As New repoListToStockTake
    mRep.pStockItemInfos = rStockItemInfos
    mRep.DataSource = mRep.pStockItemInfos

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
      xrtStockCode.Text = mSTIE.StockItem.StockCode
      xrtStockDescription.Text = mSTIE.StockItem.Description
      xrtCategory.Text = mSTIE.StockItemCategoryDesc
      xrtPartNo.Text = mSTIE.StockItem.PartNo
      xrtSystemQtys.Text = mSTIE.StockTakeItem.SnapshotQty.ToString("n2")
      xrtItemType.Text = mSTIE.StockItemTypeDesc
    End If

  End Sub
End Class