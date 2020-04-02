''Class Definition - WoodSpecie (to WoodSpecie)'Generated from Table:WoodSpecie
Imports RTIS.CommonVB

Public Class dmWoodSpecie : Inherits dmBase

  Implements RTIS.CommonVB.iValueItem

  Private pWoodSpecieID As Int32
  Private pEnglishDescription As String
  Private pSpanishDescription As String
  Private pDensity As Double
  Private pPriceBracket As Byte
  Private pWoodValue As colWoodValues

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pWoodValue = New colWoodValues
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pWoodValue = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pWoodValue.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    WoodSpecieID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodSpecie)
      .WoodSpecieID = WoodSpecieID
      .EnglishDescription = EnglishDescription
      .SpanishDescription = SpanishDescription
      .Density = Density
      .PriceBracket = PriceBracket
      .WoodValue = WoodValue
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodValue() As colWoodValues
    Get
      Return pWoodValue
    End Get
    Set(value As colWoodValues)
      pWoodValue = value
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

  Public Property EnglishDescription() As String
    Get
      Return pEnglishDescription
    End Get
    Set(ByVal value As String)
      If pEnglishDescription <> value Then IsDirty = True
      pEnglishDescription = value
    End Set
  End Property

  Public Property SpanishDescription() As String
    Get
      Return pSpanishDescription
    End Get
    Set(ByVal value As String)
      If pSpanishDescription <> value Then IsDirty = True
      pSpanishDescription = value
    End Set
  End Property

  Public Property Density() As Double
    Get
      Return pDensity
    End Get
    Set(ByVal value As Double)
      If pDensity <> value Then IsDirty = True
      pDensity = value
    End Set
  End Property

  Public Property PriceBracket() As Byte
    Get
      Return pPriceBracket
    End Get
    Set(ByVal value As Byte)
      If pPriceBracket <> value Then IsDirty = True
      pPriceBracket = value
    End Set
  End Property

  Public Property ItemValue As Integer Implements iValueItem.ItemValue
    Get
      Return pWoodSpecieID
    End Get
    Set(value As Integer)

    End Set
  End Property

  Public Property DisplayValue As String Implements iValueItem.DisplayValue
    Get
      Return pEnglishDescription
    End Get
    Set(value As String)

    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get
      Return False
    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - WoodSpecie (to WoodSpecie)'Generated from Table:WoodSpecie

'Private pWoodSpecies As colWoodSpecies
'Public Property WoodSpecies() As colWoodSpecies
'  Get
'    Return pWoodSpecies
'  End Get
'  Set(ByVal value As colWoodSpecies)
'    pWoodSpecies = value
'  End Set
'End Property

'  pWoodSpecies = New colWoodSpecies 'Add to New
'  pWoodSpecies = Nothing 'Add to Finalize
'  .WoodSpecies = WoodSpecies.Clone 'Add to CloneTo
'  WoodSpecies.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodSpecies.IsDirty 'Add to IsAnyDirty

Public Class colWoodSpecies : Inherits colBase(Of dmWoodSpecie)

  Public Overrides Function IndexFromKey(ByVal vWoodSpecieID As Integer) As Integer
    Dim mItem As dmWoodSpecie
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodSpecieID = vWoodSpecieID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodSpecie))
    MyBase.New(vList)
  End Sub

End Class
