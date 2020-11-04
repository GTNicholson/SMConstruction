Imports RTIS.CommonVB

Public Class clsHouseTypeSalesItemInfo
  Private pHouseTypeSalesItem As dmHouseTypeSalesItem
  Private pProduct As dmProductBase
  Private pAssemblyDescription As String
  Private Shared sProductConstructionTypes As RTIS.CommonVB.colValueItems
  Private pItemNumber As String


  Public Sub New(ByRef rHouseTypeSalesItem As dmHouseTypeSalesItem, ByRef rProduct As dmProductBase, ByVal vAssemblyDescription As String)
    pHouseTypeSalesItem = rHouseTypeSalesItem
    pProduct = rProduct
    pAssemblyDescription = vAssemblyDescription
    If sProductConstructionTypes Is Nothing Then
      sProductConstructionTypes = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionType)
    End If
  End Sub

  Public Property AssemblyDescription As String
    Get
      Return pAssemblyDescription
    End Get
    Set(value As String)
      pAssemblyDescription = value
    End Set
  End Property

  Public Property Product As dmProductBase
    Get
      Return pProduct
    End Get
    Set(value As dmProductBase)
      pProduct = value
    End Set
  End Property
  Public Property HouseTypeSalesItem As dmHouseTypeSalesItem
    Get
      Return pHouseTypeSalesItem
    End Get
    Set(value As dmHouseTypeSalesItem)
      pHouseTypeSalesItem = value
    End Set
  End Property
  Public ReadOnly Property Description As String
    Get
      Return pHouseTypeSalesItem.Description
    End Get
  End Property

  Public ReadOnly Property SubItemType As Int32
    Get
      Return pProduct.SubItemType
    End Get
  End Property

  Public ReadOnly Property ItemType As Int32
    Get
      Return pProduct.ItemType
    End Get
  End Property

  Public ReadOnly Property ProductCode As String
    Get
      Return pProduct.Code
    End Get
  End Property

  Public ReadOnly Property ProductConstructionTypeDesc As String
    Get
      Dim mRetVal As String
      mRetVal = sProductConstructionTypes.ItemValueToDisplayValue(pProduct.ItemType)
      Return mRetVal
    End Get
  End Property
  Public Property Quantity As Decimal
    Get
      Return pHouseTypeSalesItem.Quantity
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.Quantity = value
    End Set
  End Property

  Public Property Cost As Decimal
    Get
      Return pHouseTypeSalesItem.Cost
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.Cost = value
    End Set
  End Property

  Public Property DirectLabourCost As Decimal
    Get
      Return pHouseTypeSalesItem.DirectLabourCost
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.DirectLabourCost = value
    End Set
  End Property

  Public Property DirectMaterialCost As Decimal
    Get
      Return pHouseTypeSalesItem.DirectMaterialCost
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.DirectMaterialCost = value
    End Set
  End Property

  Public Property DirectTransportationAndEquipment As Decimal
    Get
      Return pHouseTypeSalesItem.DirectTransportationAndEquipment
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.DirectTransportationAndEquipment = value
    End Set
  End Property

  Public Property OutsourcingCost As Decimal
    Get
      Return pHouseTypeSalesItem.OutsourcingCost
    End Get
    Set(value As Decimal)
      pHouseTypeSalesItem.OutsourcingCost = value
    End Set
  End Property

  Public Property ConditionString As String
    Get
      Return pHouseTypeSalesItem.ConditionString
    End Get
    Set(value As String)
      pHouseTypeSalesItem.ConditionString = value
    End Set
  End Property

  Public Property ConditionStringUI As String
    Get
      Return pHouseTypeSalesItem.ConditionStringUI
    End Get
    Set(value As String)
      pHouseTypeSalesItem.ConditionStringUI = value
    End Set
  End Property

  Public ReadOnly Property HouseTypeSalesItemAssemblyID As Int32
    Get
      Return pHouseTypeSalesItem.HouseTypeSalesItemAssemblyID
    End Get
  End Property

  Public ReadOnly Property UoM As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pProduct.UoM, eUoM))
    End Get
  End Property

  Public ReadOnly Property TotalCostValue As Decimal
    Get
      Return pHouseTypeSalesItem.Quantity * pHouseTypeSalesItem.Cost
    End Get
  End Property

  Public Property ProductConstructionType As Int32
    Get
      Return pHouseTypeSalesItem.ProductConstructionType
    End Get
    Set(value As Int32)
      pHouseTypeSalesItem.ProductConstructionType = value
    End Set
  End Property
  Public ReadOnly Property HouseTypeProductConstructionTypeDesc As String

    Get
      Dim mRetVal As String
      mRetVal = sProductConstructionTypes.ItemValueToDisplayValue(pHouseTypeSalesItem.ProductConstructionType)
      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property HouseTypeProductConstructionSequence As Integer
    Get
      Dim mProductTypes As New colProductConstructionTypes
      Dim mRetVal As Integer
      Dim mProductType As dmProductConstructionType

      mProductTypes = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes)

      mProductType = mProductTypes.ItemFromKey(pHouseTypeSalesItem.ProductConstructionType)

      If mProductType IsNot Nothing Then
        mRetVal = mProductType.SequenceNo
      Else
        mRetVal = -1
      End If

      Return mRetVal
    End Get
  End Property
  Public Property ItemNumber As String
    Get
      Return pItemNumber
    End Get
    Set(value As String)
      pItemNumber = value
    End Set
  End Property


End Class




Public Class colHouseTypeSalesItemInfos : Inherits List(Of clsHouseTypeSalesItemInfo)

End Class
