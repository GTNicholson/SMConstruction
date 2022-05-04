''Class Definition - MaintenanceWorkOrderItem (to MaintenanceWorkOrderItem)'Generated from Table:MaintenanceWorkOrderItem
Imports RTIS.CommonVB

Public Class dmMaintenanceWorkOrderItem : Inherits dmBase
  Private pMaintenanceWorkOrderItemID As Int32
  Private pMaintenanceWorkOrderID As Int32
  Private pStockItemID As Int32
  Private pQuantity As Decimal
  Private pUnitCost As Decimal
  Private pComments As String

  Private pMaterialRequirement As dmMaterialRequirement
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pMaterialRequirement = New dmMaterialRequirement
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pMaterialRequirement = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections

      If mAnyDirty = False Then mAnyDirty = pMaterialRequirement.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    MaintenanceWorkOrderItemID = 0
    pMaterialRequirement.ClearKeys()
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmMaintenanceWorkOrderItem)
      .MaintenanceWorkOrderItemID = MaintenanceWorkOrderItemID
      .MaintenanceWorkOrderID = MaintenanceWorkOrderID
      .StockItemID = StockItemID
      .Quantity = Quantity
      .UnitCost = UnitCost
      .Comments = Comments
      .pMaterialRequirement = pMaterialRequirement
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property MaintenanceWorkOrderItemID() As Int32
    Get
      Return pMaintenanceWorkOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pMaintenanceWorkOrderItemID <> value Then IsDirty = True
      pMaintenanceWorkOrderItemID = value
    End Set
  End Property

  Public Property MaintenanceWorkOrderID() As Int32
    Get
      Return pMaintenanceWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pMaintenanceWorkOrderID <> value Then IsDirty = True
      pMaintenanceWorkOrderID = value
    End Set
  End Property

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property UnitCost() As Decimal
    Get
      Return pUnitCost
    End Get
    Set(ByVal value As Decimal)
      If pUnitCost <> value Then IsDirty = True
      pUnitCost = value
    End Set
  End Property

  Public Property Comments() As String
    Get
      Return pComments
    End Get
    Set(ByVal value As String)
      If pComments <> value Then IsDirty = True
      pComments = value
    End Set
  End Property

  Public ReadOnly Property StockItem As dmStockItem
    Get
      Dim mRetVal As dmStockItem

      mRetVal = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(pStockItemID)


      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property StockCode As String
    Get
      Dim mRetVal As String = ""

      If StockItem IsNot Nothing Then
        mRetVal = StockItem.StockCode
      End If

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property StockDescription As String
    Get
      Dim mRetVal As String = ""

      If StockItem IsNot Nothing Then
        mRetVal = StockItem.Description
      End If

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property UoMDesc As String
    Get
      Dim mRetVal As String = ""

      If StockItem IsNot Nothing Then
        mRetVal = StockItem.UoMDesc
      End If

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalCost As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = UnitCost * Quantity

      Return mRetVal
    End Get
  End Property

  Public Property MaterialRequirement As dmMaterialRequirement
    Get
      Return pMaterialRequirement
    End Get
    Set(value As dmMaterialRequirement)
      pMaterialRequirement = value
    End Set
  End Property

End Class



''Collection Definition - MaintenanceWorkOrderItem (to MaintenanceWorkOrderItem)'Generated from Table:MaintenanceWorkOrderItem

'Private pMaintenanceWorkOrderItems As colMaintenanceWorkOrderItems
'Public Property MaintenanceWorkOrderItems() As colMaintenanceWorkOrderItems
'  Get
'    Return pMaintenanceWorkOrderItems
'  End Get
'  Set(ByVal value As colMaintenanceWorkOrderItems)
'    pMaintenanceWorkOrderItems = value
'  End Set
'End Property

'  pMaintenanceWorkOrderItems = New colMaintenanceWorkOrderItems 'Add to New
'  pMaintenanceWorkOrderItems = Nothing 'Add to Finalize
'  .MaintenanceWorkOrderItems = MaintenanceWorkOrderItems.Clone 'Add to CloneTo
'  MaintenanceWorkOrderItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = MaintenanceWorkOrderItems.IsDirty 'Add to IsAnyDirty

Public Class colMaintenanceWorkOrderItems : Inherits colBase(Of dmMaintenanceWorkOrderItem)

  Public Overrides Function IndexFromKey(ByVal vMaintenanceWorkOrderItemID As Integer) As Integer
    Dim mItem As dmMaintenanceWorkOrderItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.MaintenanceWorkOrderItemID = vMaintenanceWorkOrderItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmMaintenanceWorkOrderItem))
    MyBase.New(vList)
  End Sub

  Public Function ItemByStockItemID(ByVal vStockItemID As Integer) As dmMaintenanceWorkOrderItem
    Dim mRetVal As dmMaintenanceWorkOrderItem = Nothing

    For Each mItem In Me.Items

      If mItem.StockItemID = vStockItemID Then
        mRetVal = mItem
        Exit For
      End If

    Next

    Return mRetVal
  End Function
End Class


