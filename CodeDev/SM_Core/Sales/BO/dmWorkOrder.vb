﻿''Class Definition - WorkOrder (to WorkOrder)'Generated from Table:WorkOrder
Imports RTIS.CommonVB

Public Class dmWorkOrder : Inherits dmBase
  Private pWorkOrderID As Int32
  Private pSalesOrderID As Int32
  Private pProductTypeID As Int32
  Private pQuantity As Double

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
    WorkOrderID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrder)
      .WorkOrderID = WorkOrderID
      .SalesOrderID = SalesOrderID
      .ProductTypeID = ProductTypeID
      .Quantity = Quantity
      'Add entries here for each collection and class property

      'Entries for object management

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


