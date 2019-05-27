''Class Definition - ProductFurnitureOperation (to ProductFurnitureOperation)'Generated from Table:ProductFurnitureOperation
Imports RTIS.CommonVB

Public Class dmProductFurnitureOperation : Inherits dmBase
  Private pProductFurnitureOperationID As Int32
  Private pProductfurnitureID As Int32
  Private pWorkCenterID As Int32
  Private pDescription As String
  Private pEstimatedHours As Double
  Private pQtyOfOperators As Int32

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
    ProductFurnitureOperationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductFurnitureOperation)
      .ProductFurnitureOperationID = ProductFurnitureOperationID
      .ProductfurnitureID = ProductfurnitureID
      .WorkCenterID = WorkCenterID
      .Description = Description
      .EstimatedHours = EstimatedHours
      .QtyOfOperators = QtyOfOperators
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductFurnitureOperationID() As Int32
    Get
      Return pProductFurnitureOperationID
    End Get
    Set(ByVal value As Int32)
      If pProductFurnitureOperationID <> value Then IsDirty = True
      pProductFurnitureOperationID = value
    End Set
  End Property

  Public Property ProductfurnitureID() As Int32
    Get
      Return pProductfurnitureID
    End Get
    Set(ByVal value As Int32)
      If pProductfurnitureID <> value Then IsDirty = True
      pProductfurnitureID = value
    End Set
  End Property

  Public Property WorkCenterID() As Int32
    Get
      Return pWorkCenterID
    End Get
    Set(ByVal value As Int32)
      If pWorkCenterID <> value Then IsDirty = True
      pWorkCenterID = value
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

  Public Property EstimatedHours() As Double
    Get
      Return pEstimatedHours
    End Get
    Set(ByVal value As Double)
      If pEstimatedHours <> value Then IsDirty = True
      pEstimatedHours = value
    End Set
  End Property

  Public Property QtyOfOperators() As Int32
    Get
      Return pQtyOfOperators
    End Get
    Set(ByVal value As Int32)
      If pQtyOfOperators <> value Then IsDirty = True
      pQtyOfOperators = value
    End Set
  End Property


End Class



''Collection Definition - ProductFurnitureOperation (to ProductFurnitureOperation)'Generated from Table:ProductFurnitureOperation

'Private pProductFurnitureOperations As colProductFurnitureOperations
'Public Property ProductFurnitureOperations() As colProductFurnitureOperations
'  Get
'    Return pProductFurnitureOperations
'  End Get
'  Set(ByVal value As colProductFurnitureOperations)
'    pProductFurnitureOperations = value
'  End Set
'End Property

'  pProductFurnitureOperations = New colProductFurnitureOperations 'Add to New
'  pProductFurnitureOperations = Nothing 'Add to Finalize
'  .ProductFurnitureOperations = ProductFurnitureOperations.Clone 'Add to CloneTo
'  ProductFurnitureOperations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductFurnitureOperations.IsDirty 'Add to IsAnyDirty

Public Class colProductFurnitureOperations : Inherits colBase(Of dmProductFurnitureOperation)

  Public Overrides Function IndexFromKey(ByVal vProductFurnitureOperationID As Integer) As Integer
    Dim mItem As dmProductFurnitureOperation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductFurnitureOperationID = vProductFurnitureOperationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductFurnitureOperation))
    MyBase.New(vList)
  End Sub

End Class






