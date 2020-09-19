''Class Definition - HouseTypeSalesItems (to HouseTypeSalesItems)'Generated from Table:HouseTypeSalesItems
Imports RTIS.CommonVB

Public Class dmHouseTypeSalesItems : Inherits dmBase
  Private pHouseTypeSalesItemsID As Int32
  Private pHouseTypeID As Int32
  Private pItemNumber As String
  Private pDescription As String
  Private pQuantity As Int32
  Private pUnitPrice As Decimal
  Private pImageFile As String
  Private pWoodSpecieID As Int32
  Private pWoodFinish As Int32
  Private pQtyInvoiced As Int32

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
    HouseTypeSalesItemsID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmHouseTypeSalesItems)
      .HouseTypeSalesItemsID = HouseTypeSalesItemsID
      .HouseTypeID = HouseTypeID
      .ItemNumber = ItemNumber
      .Description = Description
      .Quantity = Quantity
      .UnitPrice = UnitPrice
      .ImageFile = ImageFile
      .WoodSpecieID = WoodSpecieID
      .WoodFinish = WoodFinish
      .QtyInvoiced = QtyInvoiced
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property HouseTypeSalesItemsID() As Int32
    Get
      Return pHouseTypeSalesItemsID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeSalesItemsID <> value Then IsDirty = True
      pHouseTypeSalesItemsID = value
    End Set
  End Property

  Public Property HouseTypeID() As Int32
    Get
      Return pHouseTypeID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeID <> value Then IsDirty = True
      pHouseTypeID = value
    End Set
  End Property

  Public Property ItemNumber() As String
    Get
      Return pItemNumber
    End Get
    Set(ByVal value As String)
      If pItemNumber <> value Then IsDirty = True
      pItemNumber = value
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

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property UnitPrice() As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(ByVal value As Decimal)
      If pUnitPrice <> value Then IsDirty = True
      pUnitPrice = value
    End Set
  End Property

  Public Property ImageFile() As String
    Get
      Return pImageFile
    End Get
    Set(ByVal value As String)
      If pImageFile <> value Then IsDirty = True
      pImageFile = value
    End Set
  End Property

  Public Property WoodSpecieID() As Int32
    Get
      Return pWoodSpecieID
    End Get
    Set(ByVal value As Int32)
      If pWoodSpecieID <> value Then IsDirty = True
      pWoodSpecieID = value
    End Set
  End Property

  Public Property WoodFinish() As Int32
    Get
      Return pWoodFinish
    End Get
    Set(ByVal value As Int32)
      If pWoodFinish <> value Then IsDirty = True
      pWoodFinish = value
    End Set
  End Property

  Public Property QtyInvoiced() As Int32
    Get
      Return pQtyInvoiced
    End Get
    Set(ByVal value As Int32)
      If pQtyInvoiced <> value Then IsDirty = True
      pQtyInvoiced = value
    End Set
  End Property


End Class



''Collection Definition - HouseTypeSalesItems (to HouseTypeSalesItems)'Generated from Table:HouseTypeSalesItems

'Private pHouseTypeSalesItemss As colHouseTypeSalesItemss
'Public Property HouseTypeSalesItemss() As colHouseTypeSalesItemss
'  Get
'    Return pHouseTypeSalesItemss
'  End Get
'  Set(ByVal value As colHouseTypeSalesItemss)
'    pHouseTypeSalesItemss = value
'  End Set
'End Property

'  pHouseTypeSalesItemss = New colHouseTypeSalesItemss 'Add to New
'  pHouseTypeSalesItemss = Nothing 'Add to Finalize
'  .HouseTypeSalesItemss = HouseTypeSalesItemss.Clone 'Add to CloneTo
'  HouseTypeSalesItemss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = HouseTypeSalesItemss.IsDirty 'Add to IsAnyDirty

Public Class colHouseTypeSalesItemss : Inherits colBase(Of dmHouseTypeSalesItems)

  Public Overrides Function IndexFromKey(ByVal vHouseTypeSalesItemsID As Integer) As Integer
    Dim mItem As dmHouseTypeSalesItems
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HouseTypeSalesItemsID = vHouseTypeSalesItemsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmHouseTypeSalesItems))
    MyBase.New(vList)
  End Sub

End Class



