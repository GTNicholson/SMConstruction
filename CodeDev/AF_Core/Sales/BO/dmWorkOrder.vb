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
  Private pQuantity As Integer
  Private pDateCreated As Date
  Private pDescription As String
  Private pPlannedStartDate As DateTime
  Private pUnitPrice As Decimal
  Private pProjectName As String
  Private pWorkOrderType As Int32
  Private pEmployeeID As Int32
  Private pWoodSpecieID As Int32
  Private pWoodFinish As Int32
  Private pImageFile As String
  Private pWorkcentreID As Int32
  Private pFurnitureCategoryID As Int32
  Private pSubFurnitureCategoryID As Int32
  Private pPlannedDeliverDate As DateTime
  Private pisInternal As Boolean
  Private pSOWONumber As String

  Private pMachining As Boolean
  Private pAssembley As Boolean
  Private pSanding As Boolean
  Private pPainting As Boolean
  Private pMetalWork As Boolean
  Private pUpholstery As Boolean
  Private pSubContract As Boolean

  Private pDrawingDate As DateTime

  Private pQtyPerSalesItem As Integer
  Private pTotalPieces As Decimal

  Private pWorkOrderProcessOption As Integer


  Private pProduct As RTIS.ERPCore.intItemSpecCore

  Private pOutputDocuments As colOutputDocuments
  Private pWOFiles As colFileTrackers

  Private pSalesOrderItemWOIndex As Int32
  Private pWorkOrderTargetWoodType As Integer

  Private pWorkOrderAllocations As colWorkOrderAllocations
  Private pWorkOrderWoodType As Integer
  Private pComments As String
  Private pSourcePallets As colSourcePallets
  Private pOutputPallets As colOutputPallets

  Private pWoodMaterialRequirements As colMaterialRequirements
  Private pStockItemMaterialRequirements As colMaterialRequirements

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pOutputDocuments = New colOutputDocuments
    pWOFiles = New colFileTrackers
    pWorkOrderAllocations = New colWorkOrderAllocations
    pWOFiles.TrackDeleted = True
    pSourcePallets = New colSourcePallets
    pOutputPallets = New colOutputPallets
    pStockItemMaterialRequirements = New colMaterialRequirements
    pWoodMaterialRequirements = New colMaterialRequirements
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pOutputDocuments = Nothing
    pWorkOrderAllocations = Nothing
    pOutputPallets = Nothing
    pSourcePallets = Nothing
    pStockItemMaterialRequirements = Nothing
    pWoodMaterialRequirements = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections

      If mAnyDirty = False Then mAnyDirty = pWOFiles.IsDirty
      If mAnyDirty = False Then mAnyDirty = pOutputDocuments.IsDirty
        If mAnyDirty = False Then mAnyDirty = pWorkOrderAllocations.IsDirty
        If mAnyDirty = False Then mAnyDirty = pSourcePallets.IsDirty
        If mAnyDirty = False Then mAnyDirty = pOutputPallets.IsDirty
        If mAnyDirty = False Then mAnyDirty = pStockItemMaterialRequirements.IsDirty
        If mAnyDirty = False Then mAnyDirty = pWoodMaterialRequirements.IsDirty

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
      .FurnitureCategoryID = FurnitureCategoryID
      .SubFurnitureCategoryID = SubFurnitureCategoryID
      .Machining = Machining
      .Assembley = Assembley
      .Sanding = Sanding
      .Painting = Painting
      .MetalWork = MetalWork
      .Upholstery = Upholstery
      .SubContract = SubContract
      .EmployeeID = EmployeeID
      .QtyPerSalesItem = QtyPerSalesItem
      .DrawingDate = DrawingDate
      .PlannedDeliverDate = PlannedDeliverDate
      .TotalPieces = TotalPieces
      .SalesOrderItemWOIndex = SalesOrderItemWOIndex
      .isInternal = isInternal
      .SOWONumber = SOWONumber
      .WorkOrderWoodType = WorkOrderWoodType
      .WorkOrderProcessOption = WorkOrderProcessOption
      .WorkOrderTargetWoodType = WorkOrderTargetWoodType
      .Comments = Comments
      .StockItemMaterialRequirements = StockItemMaterialRequirements.Clone
      .WoodMaterialRequirements = WoodMaterialRequirements.Clone
      'Add entries here for each collection and class property

      .OutputDocuments = OutputDocuments.Clone
      .WOFiles = WOFiles.Clone
      .WorkOrderAllocations = WorkOrderAllocations.Clone
      'Entries for object management
      .Product = Product.Clone
      .OutputPallets = OutputPallets.clone
      .SourcePallets = SourcePallets.clone
      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PlannedDeliverDate As Date
    Get
      Return pPlannedDeliverDate
    End Get
    Set(value As Date)
      If pPlannedDeliverDate <> value Then IsDirty = True
      pPlannedDeliverDate = value
    End Set
  End Property


  Public Property WorkcentreID() As Int32
    Get
      Return pWorkcentreID
    End Get
    Set(ByVal value As Int32)
      If pWorkcentreID <> value Then IsDirty = True
      pWorkcentreID = value
    End Set
  End Property

  Public Property SalesOrderItemWOIndex() As Int32
    Get
      Return pSalesOrderItemWOIndex
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemWOIndex <> value Then IsDirty = True
      pSalesOrderItemWOIndex = value
    End Set
  End Property


  Public Property isInternal() As Boolean
    Get
      Return pisInternal
    End Get
    Set(ByVal value As Boolean)
      If pisInternal <> value Then IsDirty = True
      pisInternal = value
    End Set
  End Property

  Public Property TotalPieces() As Decimal
    Get
      Return pTotalPieces
    End Get
    Set(ByVal value As Decimal)
      If pTotalPieces <> value Then IsDirty = True
      pTotalPieces = value
    End Set
  End Property


  Public Property SOWONumber() As String
    Get
      Return pSOWONumber
    End Get
    Set(ByVal value As String)
      If pSOWONumber <> value Then IsDirty = True
      pSOWONumber = value
    End Set
  End Property

  Public Property FurnitureCategoryID() As Int32
    Get
      Return pFurnitureCategoryID
    End Get
    Set(ByVal value As Int32)
      If pFurnitureCategoryID <> value Then IsDirty = True
      pFurnitureCategoryID = value
    End Set
  End Property

  Public Property SubFurnitureCategoryID() As Int32
    Get
      Return pSubFurnitureCategoryID
    End Get
    Set(ByVal value As Int32)
      If pSubFurnitureCategoryID <> value Then IsDirty = True
      pSubFurnitureCategoryID = value
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

  Public Property QtyPerSalesItem() As Integer
    Get
      Return pQtyPerSalesItem
    End Get
    Set(ByVal value As Integer)
      If pQtyPerSalesItem <> value Then IsDirty = True
      pQtyPerSalesItem = value
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

  Public Property DrawingDate As Date
    Get
      Return pDrawingDate
    End Get
    Set(value As Date)
      If pDrawingDate <> value Then IsDirty = True
      pDrawingDate = value
    End Set
  End Property

  Public Property WorkOrderProcessOption As Integer
    Get
      Return pWorkOrderProcessOption
    End Get
    Set(value As Integer)
      If pWorkOrderProcessOption <> value Then IsDirty = True
      pWorkOrderProcessOption = value
    End Set
  End Property

  Public Property WorkOrderAllocations As colWorkOrderAllocations
    Get
      Return pWorkOrderAllocations
    End Get
    Set(value As colWorkOrderAllocations)
      pWorkOrderAllocations = value
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

  Public Property EmployeeID As Int32
    Get
      Return pEmployeeID
    End Get
    Set(ByVal value As Int32)
      If pEmployeeID <> value Then IsDirty = True
      pEmployeeID = value
    End Set
  End Property

  Public ReadOnly Property EmployeeDesc As String
    Get
      Dim mRetVal As String = ""
      mRetVal = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).DisplayValueString(EmployeeID)
      Return mRetVal
    End Get
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

  Public Property Comments As String
    Get
      Return pComments
    End Get
    Set(value As String)
      If pComments <> value Then IsDirty = True
      pComments = value
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

  Public Property WorkOrderTargetWoodType As Integer
    Get
      Return pWorkOrderTargetWoodType
    End Get
    Set(value As Integer)
      If WorkOrderTargetWoodType <> value Then IsDirty = True
      pWorkOrderTargetWoodType = value
    End Set
  End Property

  Public Property WorkOrderWoodType() As Int32
    Get
      Return pWorkOrderWoodType
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderWoodType <> value Then IsDirty = True
      pWorkOrderWoodType = value
    End Set
  End Property


  Public Property OutputPallets As colOutputPallets
    Get
      Return pOutputPallets
    End Get
    Set(value As colOutputPallets)
      pOutputPallets = value
    End Set
  End Property

  Public Property SourcePallets As colSourcePallets
    Get
      Return pSourcePallets
    End Get
    Set(value As colSourcePallets)
      pSourcePallets = value
    End Set
  End Property

  Public Property StockItemMaterialRequirements As colMaterialRequirements
    Get
      Return pStockItemMaterialRequirements
    End Get
    Set(value As colMaterialRequirements)
      pStockItemMaterialRequirements = value
    End Set
  End Property

  Public Property WoodMaterialRequirements As colMaterialRequirements
    Get
      Return pWoodMaterialRequirements
    End Get
    Set(value As colMaterialRequirements)
      pWoodMaterialRequirements = value
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

  Public Sub New()
    MyBase.New()

  End Sub

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


