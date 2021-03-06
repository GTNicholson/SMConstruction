﻿''Class Definition - HouseTypeSalesItems (to HouseTypeSalesItems)'Generated from Table:HouseTypeSalesItems
Imports RTIS.CommonVB

Public Class dmHouseTypeSalesItem : Inherits dmBase
  Private pHouseTypeSalesItemID As Int32
  Private pHouseTypeID As Int32
  Private pProductID As Integer
  Private pProductTypeID As eProductType
  Private pHouseTypeSalesItemAssemblyID As Int32
  Private pItemNumber As String
  Private pDescription As String
  Private pQuantity As Decimal
  Private pUnitPrice As Decimal
  Private pImageFile As String
  Private pWoodSpeciesID As Int32
  Private pWoodFinish As Int32
  Private pConditionString As String
  Private pConditionStringUI As String
  Private pCost As Decimal
  Private pDirectLabourCost As Decimal
  Private pDirectMaterialCost As Decimal
  Private pDirectTransportationAndEquipment As Decimal
  Private pOutsourcingCost As Decimal
  Private pProductConstructionType As Int32
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
    HouseTypeSalesItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmHouseTypeSalesItem)
      .HouseTypeSalesItemID = HouseTypeSalesItemID
      .HouseTypeID = HouseTypeID
      .ProductID = ProductID
      .ProductTypeID = ProductTypeID
      .HouseTypeSalesItemAssemblyID = HouseTypeSalesItemAssemblyID
      .ItemNumber = ItemNumber
      .Description = Description
      .Quantity = Quantity
      .UnitPrice = UnitPrice
      .ImageFile = ImageFile
      .WoodSpeciesID = WoodSpeciesID
      .WoodFinish = WoodFinish
      .ConditionString = ConditionString
      .ConditionStringUI = ConditionStringUI
      .Cost = Cost
      .DirectLabourCost = DirectLabourCost
      .DirectMaterialCost = DirectMaterialCost
      .DirectTransportationAndEquipment = DirectTransportationAndEquipment
      .OutsourcingCost = OutsourcingCost
      .ProductConstructionType = ProductConstructionType
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub


  Public Property DirectLabourCost() As Decimal
    Get
      Return pDirectLabourCost
    End Get
    Set(ByVal value As Decimal)
      If pDirectLabourCost <> value Then IsDirty = True
      pDirectLabourCost = value
    End Set
  End Property
  Public Property DirectMaterialCost() As Decimal
    Get
      Return pDirectMaterialCost
    End Get
    Set(ByVal value As Decimal)
      If pDirectMaterialCost <> value Then IsDirty = True
      pDirectMaterialCost = value
    End Set
  End Property
  Public Property DirectTransportationAndEquipment() As Decimal
    Get
      Return pDirectTransportationAndEquipment
    End Get
    Set(ByVal value As Decimal)
      If pDirectTransportationAndEquipment <> value Then IsDirty = True
      pDirectTransportationAndEquipment = value
    End Set
  End Property

  Public Property OutsourcingCost() As Decimal
    Get
      Return pOutsourcingCost
    End Get
    Set(ByVal value As Decimal)
      If pOutsourcingCost <> value Then IsDirty = True
      pOutsourcingCost = value
    End Set
  End Property
  Public Property Cost() As Decimal
    Get
      Return pCost
    End Get
    Set(ByVal value As Decimal)
      If pCost <> value Then IsDirty = True
      pCost = value
    End Set
  End Property
  Public Property ConditionString() As String
    Get
      Return pConditionString
    End Get
    Set(ByVal value As String)
      If pConditionString <> value Then IsDirty = True
      pConditionString = value
    End Set
  End Property

  Public Property ConditionStringUI() As String
    Get
      Return pConditionStringUI
    End Get
    Set(ByVal value As String)
      If pConditionStringUI <> value Then IsDirty = True
      pConditionStringUI = value
    End Set
  End Property

  Public Property HouseTypeSalesItemID() As Int32
    Get
      Return pHouseTypeSalesItemID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeSalesItemID <> value Then IsDirty = True
      pHouseTypeSalesItemID = value
    End Set
  End Property

  Public Property HouseTypeID() As Int32
    Get
      Return pHouseTypeID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeID <> value Then IsDirty = True
      pHouseTypeID = value
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

  Public Property ProductTypeID() As eProductType
    Get
      Return pProductTypeID
    End Get
    Set(ByVal value As eProductType)
      If pProductTypeID <> value Then IsDirty = True
      pProductTypeID = value
    End Set
  End Property

  Public Property ItemNumber() As String
    Get
      Return pItemNumber
    End Get
    Set(ByVal value As String)
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

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property
  Public Property ProductConstructionType() As Int32
    Get
      Return pProductConstructionType
    End Get
    Set(ByVal value As Int32)
      If pProductConstructionType <> value Then IsDirty = True
      pProductConstructionType = value
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

  Public Property ImageFile() As String
    Get
      Return pImageFile
    End Get
    Set(ByVal value As String)
      If pImageFile <> value Then IsDirty = True
      pImageFile = value
    End Set
  End Property

  Public Property WoodSpeciesID() As Int32
    Get
      Return pWoodSpeciesID
    End Get
    Set(ByVal value As Int32)
      If pWoodSpeciesID <> value Then IsDirty = True
      pWoodSpeciesID = value
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

  Public Property HouseTypeSalesItemAssemblyID As Integer
    Get
      Return pHouseTypeSalesItemAssemblyID
    End Get
    Set(value As Integer)
      pHouseTypeSalesItemAssemblyID = value
    End Set
  End Property
End Class



''Collection Definition - HouseTypeSalesItems (to HouseTypeSalesItems)'Generated from Table:HouseTypeSalesItems

'Private pHouseTypeSalesItemss As colHouseTypeSalesItemss
'Public Property HouseTypeSalesItemss() As colHouseTypeSalesItemss
'  Get
'    Return pHouseTypeSalesItemss
'  End Get
'  Set(ByVal value As colHouseTypeSalesItemss)
'    pHouseTypeSalesItemss = value
'  End Set
'End Property

'  pHouseTypeSalesItemss = New colHouseTypeSalesItemss 'Add to New
'  pHouseTypeSalesItemss = Nothing 'Add to Finalize
'  .HouseTypeSalesItemss = HouseTypeSalesItemss.Clone 'Add to CloneTo
'  HouseTypeSalesItemss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = HouseTypeSalesItemss.IsDirty 'Add to IsAnyDirty

Public Class colHouseTypeSalesItems : Inherits colBase(Of dmHouseTypeSalesItem)

  Public Overrides Function IndexFromKey(ByVal vHouseTypeSalesItemsID As Integer) As Integer
    Dim mItem As dmHouseTypeSalesItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HouseTypeSalesItemID = vHouseTypeSalesItemsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmHouseTypeSalesItem))
    MyBase.New(vList)
  End Sub

  Public Function ItemFromProductID_ProductType(ByVal vProductID As Integer, ByVal vProductType As eProductType) As dmHouseTypeSalesItem
    Dim mItem As dmHouseTypeSalesItem
    Dim mRetVal As dmHouseTypeSalesItem = Nothing

    For Each mItem In MyBase.Items

      If mItem.ProductID = vProductID And mItem.ProductTypeID = vProductType Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function
End Class



