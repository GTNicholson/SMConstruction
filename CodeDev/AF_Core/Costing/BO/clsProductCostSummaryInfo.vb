Public Class clsProductCostSummaryInfo
  Private pProductBase As dmProductBase
  Private pHouseTypeSalesItemInfos As colHouseTypeSalesItemInfos
  Private Shared sRefLists As appRefLists
  Private pTotalLabourCost As Decimal
  Private pTotalMaterialCost As Decimal
  Private pTotalTransportationCost As Decimal
  Private pTotalOutsourcingCost As Decimal
  Private pTotalCost As Decimal

  Public Sub New(ByRef rHouseTypeSalesItemInfos As colHouseTypeSalesItemInfos)
    pHouseTypeSalesItemInfos = rHouseTypeSalesItemInfos
  End Sub

  Public Property HouseTypeSalesItemInfos As colHouseTypeSalesItemInfos
    Get
      Return pHouseTypeSalesItemInfos
    End Get
    Set(value As colHouseTypeSalesItemInfos)
      pHouseTypeSalesItemInfos = value
    End Set
  End Property

  Public ReadOnly Property TotalOutsourcingCost As Decimal
    Get
      Return pTotalOutsourcingCost
    End Get

  End Property

  Public ReadOnly Property TotalTransportationCost As Decimal
    Get
      Return pTotalTransportationCost
    End Get

  End Property

  Public ReadOnly Property TotalMaterialCost As Decimal
    Get
      Return pTotalMaterialCost
    End Get

  End Property

  Public ReadOnly Property TotalLabourCost As Decimal
    Get


      Return pTotalLabourCost
    End Get

  End Property

  Public ReadOnly Property TotalCost As Decimal
    Get


      Return pTotalCost
    End Get

  End Property


  Public Sub UpdateTotalLabourCost()

    If pHouseTypeSalesItemInfos IsNot Nothing Then

      For Each mHTSII As clsHouseTypeSalesItemInfo In pHouseTypeSalesItemInfos

        pTotalLabourCost += mHTSII.DirectLabourCost * mHTSII.Quantity
        pTotalMaterialCost += mHTSII.DirectMaterialCost * mHTSII.Quantity
        pTotalOutsourcingCost += mHTSII.OutsourcingCost * mHTSII.Quantity
        pTotalTransportationCost += mHTSII.DirectTransportationAndEquipment * mHTSII.Quantity
      Next
      pTotalCost = TotalLabourCost + TotalMaterialCost + TotalOutsourcingCost + TotalTransportationCost
    End If

  End Sub

End Class



Public Class colProductCostSummaryInfos : Inherits List(Of clsProductCostSummaryInfo)


End Class
