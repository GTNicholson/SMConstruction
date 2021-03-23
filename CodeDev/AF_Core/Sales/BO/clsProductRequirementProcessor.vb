Public Class clsProductRequirementProcessor : Inherits clsProductlRequirementInfo
  Private pToProcessQty As Decimal
  Private pProduct As dmProductStructure
  Private pProductRequirement As dmSalesOrderItemProductRequirement

  Public Sub New(ByRef rProductMaterial As dmSalesOrderItemProductRequirement)
    MyBase.New(rProductMaterial)
    pProduct = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
    pProductRequirement = rProductMaterial
  End Sub

  Public Sub New()
    MyBase.New(New dmSalesOrderItemProductRequirement)
    pProduct = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
    pProductRequirement = New dmSalesOrderItemProductRequirement
  End Sub


  Public Property ToProcessQty As Decimal
    Get
      Return pProductRequirement.AllocatedQty
    End Get
    Set(value As Decimal)
      pProductRequirement.AllocatedQty = value
    End Set
  End Property

  Public Property Product As dmProductStructure
    Get
      Return pProduct
    End Get
    Set(value As dmProductStructure)
      pProduct = value
    End Set
  End Property

  Public Property Workorderno As String
  Public Property WorkOrderAllocationID As Integer

End Class

Public Class colProductRequirementProcessors : Inherits List(Of clsProductRequirementProcessor)


End Class


