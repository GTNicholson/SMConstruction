''Class Definition - ThicknessValue (to ThicknessValue)'Generated from Table:ThicknessValue
Imports RTIS.CommonVB

Public Class dmThicknessValue : Inherits dmBase
  Implements iValueItem

  Private pThicknessValueID As Int32
  Private pThickness As Decimal

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
    ThicknessValueID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmThicknessValue)
      .ThicknessValueID = ThicknessValueID
      .Thickness = Thickness
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ThicknessValueID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pThicknessValueID
    End Get
    Set(ByVal value As Int32)
      If pThicknessValueID <> value Then IsDirty = True
      pThicknessValueID = value
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


  Public Property DisplayValue As String Implements iValueItem.DisplayValue
    Get
      Return Thickness.ToString("n2")
    End Get
    Set(value As String)
      If value <> "" Then
        pThickness = Val(value)
      Else
        pThickness = 0
      End If
    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - ThicknessValue (to ThicknessValue)'Generated from Table:ThicknessValue

'Private pThicknessValues As colThicknessValues
'Public Property ThicknessValues() As colThicknessValues
'  Get
'    Return pThicknessValues
'  End Get
'  Set(ByVal value As colThicknessValues)
'    pThicknessValues = value
'  End Set
'End Property

'  pThicknessValues = New colThicknessValues 'Add to New
'  pThicknessValues = Nothing 'Add to Finalize
'  .ThicknessValues = ThicknessValues.Clone 'Add to CloneTo
'  ThicknessValues.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ThicknessValues.IsDirty 'Add to IsAnyDirty

Public Class colThicknessValues : Inherits colBase(Of dmThicknessValue)

  Public Overrides Function IndexFromKey(ByVal vThicknessValueID As Integer) As Integer
    Dim mItem As dmThicknessValue
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ThicknessValueID = vThicknessValueID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmThicknessValue))
    MyBase.New(vList)
  End Sub

End Class




