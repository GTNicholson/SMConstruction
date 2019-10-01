﻿''Class Definition - SalesOrderItem (to SalesOrderItem)'Generated from Table:SalesOrderItem
Imports RTIS.CommonVB

Public Class dmSalesOrderItem : Inherits dmBase
  Private pSalesOrderItemID As Int32
  Private pSalesOrderID As Int32
  Private pItemNumber As Int32
  Private pDescription As String
  Private pQuantity As Int32
  Private pUnitPrice As Decimal

  Private pWorkOrders As colWorkOrders

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pWorkOrders = New colWorkOrders(Me)

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
    SalesOrderItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderItem)
      .SalesOrderItemID = SalesOrderItemID
      .SalesOrderID = SalesOrderID
      .ItemNumber = ItemNumber
      .Description = Description
      .Quantity = Quantity
      .UnitPrice = UnitPrice
      'Add entries here for each collection and class property
      .WorkOrders = WorkOrders.Clone

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderItemID() As Int32
    Get
      Return pSalesOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemID <> value Then IsDirty = True
      pSalesOrderItemID = value
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

  Public Property ItemNumber() As Int32
    Get
      Return pItemNumber
    End Get
    Set(ByVal value As Int32)
      If pItemNumber <> value Then IsDirty = True
      pItemNumber = value
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

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property UnitPrice() As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(ByVal value As Decimal)
      If pUnitPrice <> value Then IsDirty = True
      pUnitPrice = value
    End Set
  End Property


  Public Property WorkOrders As colWorkOrders
    Get
      Return pWorkOrders
    End Get
    Set(value As colWorkOrders)
      pWorkOrders = value
    End Set
  End Property

End Class



''Collection Definition - SalesOrderItem (to SalesOrderItem)'Generated from Table:SalesOrderItem

'Private pSalesOrderItems As colSalesOrderItems
'Public Property SalesOrderItems() As colSalesOrderItems
'  Get
'    Return pSalesOrderItems
'  End Get
'  Set(ByVal value As colSalesOrderItems)
'    pSalesOrderItems = value
'  End Set
'End Property

'  pSalesOrderItems = New colSalesOrderItems 'Add to New
'  pSalesOrderItems = Nothing 'Add to Finalize
'  .SalesOrderItems = SalesOrderItems.Clone 'Add to CloneTo
'  SalesOrderItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderItems.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderItems : Inherits colBase(Of dmSalesOrderItem)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderItemID As Integer) As Integer
    Dim mItem As dmSalesOrderItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderItemID = vSalesOrderItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderItem))
    MyBase.New(vList)
  End Sub

  Public Function GetNextItemNumber() As Integer
    Dim mRetVal As Integer = 0
    For Each mItem As dmSalesOrderItem In Me.Items
      If mItem.ItemNumber > mRetVal Then mRetVal = mItem.ItemNumber
    Next
    mRetVal = mRetVal + 1
    Return mRetVal
  End Function

End Class





