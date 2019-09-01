''Class Definition - WorkOrder (to WorkOrder)'Generated from Table:WorkOrder
Imports RTIS.CommonVB

Public Class dmWorkOrder : Inherits dmBase
  Private pWorkOrderID As Int32
  Private pSalesOrderID As Int32
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
      .WorkOrderNo = WorkOrderNo
      .ProductTypeID = ProductTypeID
      .Quantity = Quantity
      .DateCreated = DateCreated
      .Description = Description
      .PlannedStartDate = PlannedStartDate
      .UnitPrice = UnitPrice
      .WorkOrderType = WorkOrderType

      'Add entries here for each collection and class property

      .OutputDocuments = OutputDocuments.Clone
      .WOFiles = WOFiles.Clone

      'Entries for object management
      .Product = Product.Clone

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderID() As Int32
    Get
      Return pWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
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

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrder))
    MyBase.New(vList)
  End Sub

End Class


