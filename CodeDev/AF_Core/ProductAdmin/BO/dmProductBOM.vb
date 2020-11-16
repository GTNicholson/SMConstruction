''Class Definition - ProductBOM (to ProductBOM)'Generated from Table:ProductBOM
Imports RTIS.CommonVB

Public Class dmProductBOM : Inherits dmBase
  Private pProductBOMID As Int32
  Private pParentID As Int32
  Private pProductID As Int32
  Private pQuantity As Int32

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
    ProductBOMID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductBOM)
      .ProductBOMID = ProductBOMID
      .ParentID = ParentID
      .ProductID = ProductID
      .Quantity = Quantity
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductBOMID() As Int32
    Get
      Return pProductBOMID
    End Get
    Set(ByVal value As Int32)
      If pProductBOMID <> value Then IsDirty = True
      pProductBOMID = value
    End Set
  End Property

  Public Property ParentID() As Int32
    Get
      Return pParentID
    End Get
    Set(ByVal value As Int32)
      If pParentID <> value Then IsDirty = True
      pParentID = value
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

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property


End Class



''Collection Definition - ProductBOM (to ProductBOM)'Generated from Table:ProductBOM

'Private pProductBOMs As colProductBOMs
'Public Property ProductBOMs() As colProductBOMs
'  Get
'    Return pProductBOMs
'  End Get
'  Set(ByVal value As colProductBOMs)
'    pProductBOMs = value
'  End Set
'End Property

'  pProductBOMs = New colProductBOMs 'Add to New
'  pProductBOMs = Nothing 'Add to Finalize
'  .ProductBOMs = ProductBOMs.Clone 'Add to CloneTo
'  ProductBOMs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductBOMs.IsDirty 'Add to IsAnyDirty

Public Class colProductBOMs : Inherits colBase(Of dmProductBOM)

  Public Overrides Function IndexFromKey(ByVal vProductBOMID As Integer) As Integer
    Dim mItem As dmProductBOM
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductBOMID = vProductBOMID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromProductID(ByVal vProductID As Integer) As dmProductBOM
    Dim mItem As dmProductBOM
    Dim mRetVal As dmProductBOM = Nothing

    For Each mItem In MyBase.Items

      If mItem.ProductID = vProductID Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

  Public Function IndexFromProductID(ByVal vProductID As Integer) As Integer
    Dim mItem As dmProductBOM
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductID = vProductID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductBOM))
    MyBase.New(vList)
  End Sub

End Class


