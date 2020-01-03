Imports RTIS.CommonVB

Public Class clsStockItemInfo
  Private pStockItem As dmStockItem

  Private PStockItemId As Integer
  Private pCategory As Integer
  Private pItemType As Integer
  Private pSpecies As Integer
  Private pColour As String
  Private pPartNo As String
  Private pLength As Decimal
  Private pWidth As Decimal
  Private pThickness As Decimal
  Private pDescription As String
  Private pStdCosT As Decimal



  Public Sub New()
    MyBase.New()
    pStockItem = New dmStockItem
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property StockItem() As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(ByVal value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property StockItemId() As Integer
    Get
      Return PStockItemId
    End Get
    Set(ByVal value As Int32)
      PStockItemId = value
    End Set
  End Property
  Public Property Category() As Integer
    Get
      Return pCategory
    End Get
    Set(ByVal value As Int32)
      pCategory = value
    End Set
  End Property
  Public Property ItemType() As Integer
    Get
      Return pItemType
    End Get
    Set(ByVal value As Int32)
      pItemType = value
    End Set
  End Property

  Public Property Species() As Int32
    Get
      Return pSpecies
    End Get
    Set(ByVal value As Int32)
      pSpecies = value
    End Set
  End Property
  Public Property Colour() As String
    Get
      Return pColour
    End Get
    Set(ByVal value As String)
      pColour = value
    End Set
  End Property
  Public Property PartNo() As String
    Get
      Return pPartNo
    End Get
    Set(ByVal value As String)
      pPartNo = value
    End Set
  End Property
  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      pDescription = value
    End Set
  End Property

  Public Property Length() As Decimal
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      pLength = value
    End Set
  End Property
  Public Property Width() As Decimal
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      pWidth = value
    End Set
  End Property
  Public Property Thickness() As Decimal
    Get
      Return pThickness
    End Get
    Set(ByVal value As Decimal)
      pThickness = value
    End Set
  End Property

  Public Property StdCosT() As Decimal
    Get
      Return pStdCosT
    End Get
    Set(ByVal value As Decimal)
      pStdCosT = value
    End Set
  End Property

End Class

Public Class colStockItemInfos : Inherits List(Of clsStockItemInfo)

End Class