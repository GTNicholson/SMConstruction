''Class Definition - WoodValue (to WoodValue)'Generated from Table:WoodValue
Imports RTIS.CommonVB

Public Class dmWoodValue : Inherits dmBase
  Private pWoodValueID As Int32
  Private pSpeciesID As Int32
  Private pWoodValueDate As DateTime
  Private pWoodValueBF As Decimal

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
    WoodValueID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodValue)
      .WoodValueID = WoodValueID
      .SpeciesID = SpeciesID
      .WoodValueDate = WoodValueDate
      .WoodValueBF = WoodValueBF
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodValueID() As Int32
    Get
      Return pWoodValueID
    End Get
    Set(ByVal value As Int32)
      If pWoodValueID <> value Then IsDirty = True
      pWoodValueID = value
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

  Public Property WoodValueDate() As DateTime
    Get
      Return pWoodValueDate
    End Get
    Set(ByVal value As DateTime)
      If pWoodValueDate <> value Then IsDirty = True
      pWoodValueDate = value
    End Set
  End Property

  Public Property WoodValueBF() As Decimal
    Get
      Return pWoodValueBF
    End Get
    Set(ByVal value As Decimal)
      If pWoodValueBF <> value Then IsDirty = True
      pWoodValueBF = value
    End Set
  End Property


End Class



''Collection Definition - WoodValue (to WoodValue)'Generated from Table:WoodValue

'Private pWoodValues As colWoodValues
'Public Property WoodValues() As colWoodValues
'  Get
'    Return pWoodValues
'  End Get
'  Set(ByVal value As colWoodValues)
'    pWoodValues = value
'  End Set
'End Property

'  pWoodValues = New colWoodValues 'Add to New
'  pWoodValues = Nothing 'Add to Finalize
'  .WoodValues = WoodValues.Clone 'Add to CloneTo
'  WoodValues.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodValues.IsDirty 'Add to IsAnyDirty

Public Class colWoodValues : Inherits colBase(Of dmWoodValue)

  Public Overrides Function IndexFromKey(ByVal vWoodValueID As Integer) As Integer
    Dim mItem As dmWoodValue
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodValueID = vWoodValueID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodValue))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - WoodValue (to WoodValue)'Generated from Table:WoodValue
