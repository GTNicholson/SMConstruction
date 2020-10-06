''Class Definition - ProductInstallationType (to ProductInstallationType)'Generated from Table:ProductInstallationType
Imports RTIS.CommonVB

Public Class dmProductInstallationType : Inherits dmBase
  Implements iValueItem

  Private pProductInstallationTypeID As Int32
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
    ProductInstallationTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductInstallationType)
      .ProductInstallationTypeID = ProductInstallationTypeID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductInstallationTypeID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pProductInstallationTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductInstallationTypeID <> value Then IsDirty = True
      pProductInstallationTypeID = value
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

  Public Property ItemValue As Integer
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DisplayValue As String
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - ProductInstallationType (to ProductInstallationType)'Generated from Table:ProductInstallationType

'Private pProductInstallationTypes As colProductInstallationTypes
'Public Property ProductInstallationTypes() As colProductInstallationTypes
'  Get
'    Return pProductInstallationTypes
'  End Get
'  Set(ByVal value As colProductInstallationTypes)
'    pProductInstallationTypes = value
'  End Set
'End Property

'  pProductInstallationTypes = New colProductInstallationTypes 'Add to New
'  pProductInstallationTypes = Nothing 'Add to Finalize
'  .ProductInstallationTypes = ProductInstallationTypes.Clone 'Add to CloneTo
'  ProductInstallationTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductInstallationTypes.IsDirty 'Add to IsAnyDirty

Public Class colProductInstallationTypes : Inherits colBase(Of dmProductInstallationType)

  Public Overrides Function IndexFromKey(ByVal vProductInstallationTypeID As Integer) As Integer
    Dim mItem As dmProductInstallationType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductInstallationTypeID = vProductInstallationTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductInstallationType))
    MyBase.New(vList)
  End Sub

End Class


