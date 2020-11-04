''Class Definition - StockItemBOM (to StockItemBOM)'Generated from Table:StockItemBOM
Imports RTIS.CommonVB

Public Class dmStockItemBOM : Inherits dmBase
  Private pStockItemBOMID As Int32
  Private pProductID As Int32
  Private pStockItemID As Int32
  Private pQuantity As Decimal
  Private pDescription As String
  Private pStockCode As String
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    StockItemBOMID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemBOM)
      .StockItemBOMID = StockItemBOMID
      .ProductID = ProductID
      .StockItemID = StockItemID
      .Quantity = Quantity
      .Description = Description
      StockCode = StockCode
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemBOMID() As Int32
    Get
      Return pStockItemBOMID
    End Get
    Set(ByVal value As Int32)
      If pStockItemBOMID <> value Then IsDirty = True
      pStockItemBOMID = value
    End Set
  End Property

  Public Property ProductID() As Int32
    Get
      Return pProductID
    End Get
    Set(ByVal value As Int32)
      If pProductID <> value Then IsDirty = True
      pProductID = value
    End Set
  End Property

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property StockCode() As String
    Get
      Return pStockCode
    End Get
    Set(ByVal value As String)
      If pStockCode <> value Then IsDirty = True
      pStockCode = value
    End Set
  End Property
End Class



''Collection Definition - StockItemBOM (to StockItemBOM)'Generated from Table:StockItemBOM

'Private pStockItemBOMs As colStockItemBOMs
'Public Property StockItemBOMs() As colStockItemBOMs
'  Get
'    Return pStockItemBOMs
'  End Get
'  Set(ByVal value As colStockItemBOMs)
'    pStockItemBOMs = value
'  End Set
'End Property

'  pStockItemBOMs = New colStockItemBOMs 'Add to New
'  pStockItemBOMs = Nothing 'Add to Finalize
'  .StockItemBOMs = StockItemBOMs.Clone 'Add to CloneTo
'  StockItemBOMs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemBOMs.IsDirty 'Add to IsAnyDirty

Public Class colStockItemBOMs : Inherits colBase(Of dmStockItemBOM)

  Public Overrides Function IndexFromKey(ByVal vStockItemBOMID As Integer) As Integer
    Dim mItem As dmStockItemBOM
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemBOMID = vStockItemBOMID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemBOM))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromStockItemID(ByVal vStockItemID As Integer) As Integer
    Dim mItem As dmStockItemBOM
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemID = vStockItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function
End Class






