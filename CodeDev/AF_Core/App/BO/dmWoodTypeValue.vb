''Class Definition - WoodTypeValue (to WoodTypeValue)'Generated from Table:WoodTypeValue
Imports RTIS.CommonVB

Public Class dmWoodTypeValue : Inherits dmBase
  Implements iValueItem

  Private pWoodTypeValueID As Int32
  Private pDescription As String

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
    WoodTypeValueID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodTypeValue)
      .WoodTypeValueID = WoodTypeValueID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodTypeValueID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pWoodTypeValueID
    End Get
    Set(ByVal value As Int32)
      If pWoodTypeValueID <> value Then IsDirty = True
      pWoodTypeValueID = value
    End Set
  End Property

  Public Property Description() As String Implements iValueItem.DisplayValue
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property



  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - WoodTypeValue (to WoodTypeValue)'Generated from Table:WoodTypeValue

'Private pWoodTypeValues As colWoodTypeValues
'Public Property WoodTypeValues() As colWoodTypeValues
'  Get
'    Return pWoodTypeValues
'  End Get
'  Set(ByVal value As colWoodTypeValues)
'    pWoodTypeValues = value
'  End Set
'End Property

'  pWoodTypeValues = New colWoodTypeValues 'Add to New
'  pWoodTypeValues = Nothing 'Add to Finalize
'  .WoodTypeValues = WoodTypeValues.Clone 'Add to CloneTo
'  WoodTypeValues.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodTypeValues.IsDirty 'Add to IsAnyDirty

Public Class colWoodTypeValues : Inherits colBase(Of dmWoodTypeValue)

  Public Overrides Function IndexFromKey(ByVal vWoodTypeValueID As Integer) As Integer
    Dim mItem As dmWoodTypeValue
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodTypeValueID = vWoodTypeValueID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodTypeValue))
    MyBase.New(vList)
  End Sub

End Class




