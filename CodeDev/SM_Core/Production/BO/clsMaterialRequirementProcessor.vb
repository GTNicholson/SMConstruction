Public Class clsMaterialRequirementProcessor : Inherits clsMaterialRequirementInfo
  Private pToProcessQty As Decimal

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    MyBase.New(rMaterialRequirement)
  End Sub

  Public Property ToProcessQty As Decimal
    Get
      Return pToProcessQty
    End Get
    Set(value As Decimal)
      pToProcessQty = value
    End Set
  End Property

End Class


