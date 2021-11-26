''Class Definition - WoodPalletGuideItem (to WoodPalletGuideItem)'Generated from Table:WoodPalletGuideItem
Imports RTIS.CommonVB

Public Class dmWoodPalletGuideItem : Inherits dmBase
  Private pWoodPalletGuideItemID As Int32
  Private pPalletID As Int32
  Private pStockItemID As Int32
  Private pSpeciesID As Int32
  Private pWidth As Decimal
  Private pLength As Decimal
  Private pQuantity As Decimal
  Private pDescription As String
  Private pStockCode As String
  Private pThickness As Decimal
  Private pVolumeM3 As Decimal

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
    WoodPalletGuideItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodPalletGuideItem)
      .WoodPalletGuideItemID = WoodPalletGuideItemID
      .PalletID = PalletID
      .StockItemID = StockItemID
      .SpeciesID = SpeciesID
      .Width = Width
      .Length = Length
      .Quantity = Quantity
      .Description = Description
      .StockCode = StockCode
      .Thickness = Thickness
      .VolumeM3 = VolumeM3
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodPalletGuideItemID() As Int32
    Get
      Return pWoodPalletGuideItemID
    End Get
    Set(ByVal value As Int32)
      If pWoodPalletGuideItemID <> value Then IsDirty = True
      pWoodPalletGuideItemID = value
    End Set
  End Property

  Public Property PalletID() As Int32
    Get
      Return pPalletID
    End Get
    Set(ByVal value As Int32)
      If pPalletID <> value Then IsDirty = True
      pPalletID = value
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

  Public Property SpeciesID() As Int32
    Get
      Return pSpeciesID
    End Get
    Set(ByVal value As Int32)
      If pSpeciesID <> value Then IsDirty = True
      pSpeciesID = value
    End Set
  End Property

  Public Property Width() As Decimal
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      If pWidth <> value Then IsDirty = True
      pWidth = value
    End Set
  End Property

  Public Property Length() As Decimal
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      If pLength <> value Then IsDirty = True
      pLength = value
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

  Public Property Thickness() As Decimal
    Get
      Return pThickness
    End Get
    Set(ByVal value As Decimal)
      If pThickness <> value Then IsDirty = True
      pThickness = value
    End Set
  End Property

  Public Property VolumeM3() As Decimal
    Get
      Return pVolumeM3
    End Get
    Set(ByVal value As Decimal)
      If pVolumeM3 <> value Then IsDirty = True
      pVolumeM3 = value
    End Set
  End Property


End Class



''Collection Definition - WoodPalletGuideItem (to WoodPalletGuideItem)'Generated from Table:WoodPalletGuideItem

'Private pWoodPalletGuideItems As colWoodPalletGuideItems
'Public Property WoodPalletGuideItems() As colWoodPalletGuideItems
'  Get
'    Return pWoodPalletGuideItems
'  End Get
'  Set(ByVal value As colWoodPalletGuideItems)
'    pWoodPalletGuideItems = value
'  End Set
'End Property

'  pWoodPalletGuideItems = New colWoodPalletGuideItems 'Add to New
'  pWoodPalletGuideItems = Nothing 'Add to Finalize
'  .WoodPalletGuideItems = WoodPalletGuideItems.Clone 'Add to CloneTo
'  WoodPalletGuideItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodPalletGuideItems.IsDirty 'Add to IsAnyDirty

Public Class colWoodPalletGuideItems : Inherits colBase(Of dmWoodPalletGuideItem)

  Public Overrides Function IndexFromKey(ByVal vWoodPalletGuideItemID As Integer) As Integer
    Dim mItem As dmWoodPalletGuideItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodPalletGuideItemID = vWoodPalletGuideItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodPalletGuideItem))
    MyBase.New(vList)
  End Sub

  Public Function GetTotalVolumenBySpecies(ByVal vSpeciesID As Integer) As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmWoodPalletGuideItem In Me.Items

      If mItem.SpeciesID = vSpeciesID Then
        mRetVal = mRetVal + mItem.VolumeM3
      End If
    Next
    Return mRetVal
  End Function
End Class



