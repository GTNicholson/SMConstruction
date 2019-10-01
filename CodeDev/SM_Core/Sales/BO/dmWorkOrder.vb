''Class Definition - WorkOrder (to WorkOrder)'Generated from Table:WorkOrder
Imports RTIS.CommonVB

Public Class dmWorkOrder : Inherits dmBase
  Private pWorkOrderID As Int32
  Private pSalesOrderID As Int32
  Private pSalesOrderItemID As Int32
  Private pParentSalesOrderItem As dmSalesOrderItem '// Not in clone and not in samespec  
  Private pWorkOrderNo As String
  Private pProductTypeID As Int32
  Private pProductID As Integer
  Private pQuantity As Double
  Private pDateCreated As Date
  Private pDescription As String
  Private pPlannedStartDate As DateTime
  Private pUnitPrice As Decimal
  Private pProjectName As String
  Private pWorkOrderType As Int32
  Private pEmployeeName As String
  Private pWoodSpecieID As Int32
  Private pWoodFinish As Int32
  Private pImageFile As String
  Private pWorkcentreID As Int32

  Private pMachining As Boolean
  Private pAssembley As Boolean
  Private pSanding As Boolean
  Private pPainting As Boolean
  Private pMetalWork As Boolean
  Private pUpholstery As Boolean
  Private pSubContract As Boolean


  Private pProduct As RTIS.ERPCore.intItemSpecCore

  Private pOutputDocuments As colOutputDocuments
  Private pWOFiles As colFileTrackers

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pOutputDocuments = New colOutputDocuments
    pWOFiles = New colFileTrackers
    pWOFiles.TrackDeleted = True
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pOutputDocuments = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If pProduct IsNot Nothing Then
        If mAnyDirty = False Then mAnyDirty = pProduct.IsAnyDirty
        If mAnyDirty = False Then mAnyDirty = pWOFiles.IsDirty
        If mAnyDirty = False Then mAnyDirty = pOutputDocuments.IsDirty
      End If
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    WorkOrderID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrder)
      .WorkOrderID = WorkOrderID
      .SalesOrderID = SalesOrderID
      .SalesOrderItemID = SalesOrderItemID
      .WorkOrderNo = WorkOrderNo
      .ProductTypeID = ProductTypeID
      .Quantity = Quantity
      .DateCreated = DateCreated
      .Description = Description
      .PlannedStartDate = PlannedStartDate
      .UnitPrice = UnitPrice
      .WorkOrderType = WorkOrderType
      .WoodSpecieID = WoodSpecieID
      .WoodFinish = WoodFinish
      .ImageFile = ImageFile
      .WorkcentreID = WorkcentreID


      .Machining = Machining
      .Assembley = Assembley
      .Sanding = Sanding
      .Painting = Painting
      .MetalWork = MetalWork
      .Upholstery = Upholstery
      .SubContract = SubContract

      'Add entries here for each collection and class property

      .OutputDocuments = OutputDocuments.Clone
      .WOFiles = WOFiles.Clone

      'Entries for object management
      .Product = Product.Clone

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkcentreID() As Int32
    Get
      Return pWorkcentreID
    End Get
    Set(ByVal value As Int32)
      If pWorkcentreID <> value Then IsDirty = True
      pWorkcentreID = value
    End Set
  End Property


  Public Property WorkOrderID() As Int32
    Get
      Return pWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
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

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public Property SalesOrderItemID() As Int32
    Get
      Return pSalesOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemID <> value Then IsDirty = True
      pSalesOrderItemID = value
    End Set
  End Property

  Public Property ParentSalesOrderItem As dmSalesOrderItem
    Get
      Return pParentSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pParentSalesOrderItem = value
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

  Public Property ProductTypeID() As Int32
    Get
      Return pProductTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductTypeID <> value Then IsDirty = True
      pProductTypeID = value
    End Set
  End Property

  Public Property Quantity() As Double
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Double)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property WorkOrderNo As String
    Get
      Return pWorkOrderNo
    End Get
    Set(value As String)
      If pWorkOrderNo <> value Then IsDirty = True
      pWorkOrderNo = value
    End Set
  End Property

  Public Property DateCreated As Date
    Get
      Return pDateCreated
    End Get
    Set(value As Date)
      If pDateCreated <> value Then IsDirty = True
      pDateCreated = value
    End Set
  End Property

  Public Property OutputDocuments As colOutputDocuments
    Get
      Return pOutputDocuments
    End Get
    Set(value As colOutputDocuments)
      pOutputDocuments = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pDescription
    End Get
    Set(value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property PlannedStartDate As DateTime
    Get
      Return pPlannedStartDate
    End Get
    Set(value As DateTime)
      If pPlannedStartDate <> value Then IsDirty = True
      pPlannedStartDate = value
    End Set
  End Property

  Public Property UnitPrice As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(value As Decimal)
      If pUnitPrice <> value Then IsDirty = True
      pUnitPrice = value
    End Set
  End Property

  Public Property ProjectName As String
    Get
      Return pProjectName
    End Get
    Set(value As String)
      If pProjectName <> value Then IsDirty = True
      pProjectName = value
    End Set
  End Property
  Public Property WorkOrderType() As Int32
    Get
      Return pWorkOrderType
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderType <> value Then IsDirty = True
      pWorkOrderType = value
    End Set
  End Property

  Public Property EmployeeName As String
    Get
      Return pEmployeeName
    End Get
    Set(ByVal value As String)
      If pEmployeeName <> value Then IsDirty = True
      pEmployeeName = value
    End Set
  End Property

  Public Property ImageFile As String
    Get
      Return pImageFile
    End Get
    Set(ByVal value As String)
      If pImageFile <> value Then IsDirty = True
      pImageFile = value
    End Set
  End Property

  Public Property Product As RTIS.ERPCore.intItemSpecCore
    Get
      Return pProduct
    End Get
    Set(value As RTIS.ERPCore.intItemSpecCore)
      pProduct = value
    End Set
  End Property

  Public Property WOFiles As colFileTrackers
    Get
      Return pWOFiles
    End Get
    Set(value As colFileTrackers)
      pWOFiles = value
    End Set
  End Property

  Public Property Machining As Boolean
    Get
      Return pMachining
    End Get
    Set(value As Boolean)
      If pMachining <> value Then IsDirty = True
      pMachining = value
    End Set
  End Property


  Public Property Assembley As Boolean
    Get
      Return pAssembley
    End Get
    Set(value As Boolean)
      If pAssembley <> value Then IsDirty = True
      pAssembley = value
    End Set
  End Property

  Public Property Sanding As Boolean
    Get
      Return pSanding
    End Get
    Set(value As Boolean)
      If pSanding <> value Then IsDirty = True
      pSanding = value
    End Set
  End Property

  Public Property Painting As Boolean
    Get
      Return pPainting
    End Get
    Set(value As Boolean)
      If pPainting <> value Then IsDirty = True
      pPainting = value
    End Set
  End Property

  Public Property MetalWork As Boolean
    Get
      Return pMetalWork
    End Get
    Set(value As Boolean)
      If pMetalWork <> value Then IsDirty = True
      pMetalWork = value
    End Set
  End Property

  Public Property Upholstery As Boolean
    Get
      Return pUpholstery
    End Get
    Set(value As Boolean)
      If pUpholstery <> value Then IsDirty = True
      pUpholstery = value
    End Set
  End Property

  Public Property SubContract As Boolean
    Get
      Return pSubContract
    End Get
    Set(value As Boolean)
      If pSubContract <> value Then IsDirty = True
      pSubContract = value
    End Set
  End Property

End Class



''Collection Definition - WorkOrder (to WorkOrder)'Generated from Table:WorkOrder

'Private pWorkOrders As colWorkOrders
'Public Property WorkOrders() As colWorkOrders
'  Get
'    Return pWorkOrders
'  End Get
'  Set(ByVal value As colWorkOrders)
'    pWorkOrders = value
'  End Set
'End Property

'  pWorkOrders = New colWorkOrders 'Add to New
'  pWorkOrders = Nothing 'Add to Finalize
'  .WorkOrders = WorkOrders.Clone 'Add to CloneTo
'  WorkOrders.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WorkOrders.IsDirty 'Add to IsAnyDirty

Public Class colWorkOrders : Inherits colBase(Of dmWorkOrder)
  Implements System.ICloneable

  Private pParentSalesOrderItem As dmSalesOrderItem


  Public Sub New(ByRef rParentSalesOrderItem As dmSalesOrderItem)
    MyBase.New()
    pParentSalesOrderItem = rParentSalesOrderItem
  End Sub

  Public Overrides Function IndexFromKey(ByVal vWorkOrderID As Integer) As Integer
    Dim mItem As dmWorkOrder
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderID = vWorkOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New(ByVal vList As List(Of dmWorkOrder))
    MyBase.New(vList)
  End Sub

  Protected Overrides Sub InsertItem(index As Integer, item As dmWorkOrder)
    MyBase.InsertItem(index, item)
    If pParentSalesOrderItem IsNot Nothing Then item.ParentSalesOrderItem = pParentSalesOrderItem
  End Sub

  Public Overridable Function Clone() As Object Implements System.ICloneable.Clone
    Dim mCol As New colWorkOrders(pParentSalesOrderItem)

    For Each mItem As ICloneable In MyBase.Items
      mCol.Add(CType(mItem.Clone, dmWorkOrder))
    Next

    Return mCol
  End Function

End Class


