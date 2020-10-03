''Class Definition - ProductInstallation (to ProductInstallation)'Generated from Table:ProductInstallation
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmProductInstallation : Inherits dmProductBase

  Private pProductInstallationID As Int32
  Private pProductInstallationTypeID As Int32
  Private pNotes As String

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
    ProductInstallationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductInstallation)
      .ProductInstallationID = ProductInstallationID
      .Description = Description
      .ProductInstallationTypeID = ProductInstallationTypeID
      .Notes = Notes
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Overrides Function Clone() As Object
    Dim mRetVal As New dmProductInstallation
    CloneTo(mRetVal)
    Return mRetVal
  End Function

  Public Overrides Sub CalculateCostAndPrice()
    Throw New NotImplementedException()
  End Sub


  Public Property ProductInstallationID() As Int32
    Get
      Return ID
    End Get
    Set(ByVal value As Int32)
      ID = value
    End Set
  End Property


  Public Property ProductInstallationTypeID() As Int32
    Get
      Return pProductInstallationTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductInstallationTypeID <> value Then IsDirty = True
      pProductInstallationTypeID = value
    End Set
  End Property

  Public Property Notes() As String
    Get
      Return pNotes
    End Get
    Set(ByVal value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
    End Set
  End Property

  Public Overrides Property ItemType As Integer
    Get
      Return eProductType.ProductInstallation
    End Get
    Set(value As Integer)

    End Set
  End Property


  Private ReadOnly Property intItemSpecCore_IsAnyDirty As Boolean
    Get
      Throw New NotImplementedException()
    End Get
  End Property
End Class



''Collection Definition - ProductInstallation (to ProductInstallation)'Generated from Table:ProductInstallation

'Private pProductInstallations As colProductInstallations
'Public Property ProductInstallations() As colProductInstallations
'  Get
'    Return pProductInstallations
'  End Get
'  Set(ByVal value As colProductInstallations)
'    pProductInstallations = value
'  End Set
'End Property

'  pProductInstallations = New colProductInstallations 'Add to New
'  pProductInstallations = Nothing 'Add to Finalize
'  .ProductInstallations = ProductInstallations.Clone 'Add to CloneTo
'  ProductInstallations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductInstallations.IsDirty 'Add to IsAnyDirty

Public Class colProductInstallations : Inherits colBase(Of dmProductInstallation)

  Public Overrides Function IndexFromKey(ByVal vProductInstallationID As Integer) As Integer
    Dim mItem As dmProductInstallation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductInstallationID = vProductInstallationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductInstallation))
    MyBase.New(vList)
  End Sub

End Class


