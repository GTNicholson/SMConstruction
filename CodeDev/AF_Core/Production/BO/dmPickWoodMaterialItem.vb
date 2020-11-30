''Class Definition - PickWoodMaterialItem (to PickWoodMaterialItem)'Generated from Table:PickWoodMaterialItem
Imports RTIS.CommonVB

Public Class dmPickWoodMaterialItem : Inherits dmBase
  Private pPickWoodMaterialItemID As Int32
  Private pPickWoodMaterialID As Int32
  Private pQtyPicked As Decimal
  Private pWoodPalletItemID As Int32

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
    PickWoodMaterialItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPickWoodMaterialItem)
      .PickWoodMaterialItemID = PickWoodMaterialItemID
      .PickWoodMaterialID = PickWoodMaterialID
      .QtyPicked = QtyPicked
      .WoodPalletItemID = WoodPalletItemID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PickWoodMaterialItemID() As Int32
    Get
      Return pPickWoodMaterialItemID
    End Get
    Set(ByVal value As Int32)
      If pPickWoodMaterialItemID <> value Then IsDirty = True
      pPickWoodMaterialItemID = value
    End Set
  End Property

  Public Property PickWoodMaterialID() As Int32
    Get
      Return pPickWoodMaterialID
    End Get
    Set(ByVal value As Int32)
      If pPickWoodMaterialID <> value Then IsDirty = True
      pPickWoodMaterialID = value
    End Set
  End Property

  Public Property QtyPicked() As Decimal
    Get
      Return pQtyPicked
    End Get
    Set(ByVal value As Decimal)
      If pQtyPicked <> value Then IsDirty = True
      pQtyPicked = value
    End Set
  End Property

  Public Property WoodPalletItemID() As Int32
    Get
      Return pWoodPalletItemID
    End Get
    Set(ByVal value As Int32)
      If pWoodPalletItemID <> value Then IsDirty = True
      pWoodPalletItemID = value
    End Set
  End Property


End Class



''Collection Definition - PickWoodMaterialItem (to PickWoodMaterialItem)'Generated from Table:PickWoodMaterialItem

'Private pPickWoodMaterialItems As colPickWoodMaterialItems
'Public Property PickWoodMaterialItems() As colPickWoodMaterialItems
'  Get
'    Return pPickWoodMaterialItems
'  End Get
'  Set(ByVal value As colPickWoodMaterialItems)
'    pPickWoodMaterialItems = value
'  End Set
'End Property

'  pPickWoodMaterialItems = New colPickWoodMaterialItems 'Add to New
'  pPickWoodMaterialItems = Nothing 'Add to Finalize
'  .PickWoodMaterialItems = PickWoodMaterialItems.Clone 'Add to CloneTo
'  PickWoodMaterialItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PickWoodMaterialItems.IsDirty 'Add to IsAnyDirty

Public Class colPickWoodMaterialItems : Inherits colBase(Of dmPickWoodMaterialItem)

  Public Overrides Function IndexFromKey(ByVal vPickWoodMaterialItemID As Integer) As Integer
    Dim mItem As dmPickWoodMaterialItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PickWoodMaterialItemID = vPickWoodMaterialItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPickWoodMaterialItem))
    MyBase.New(vList)
  End Sub

End Class


