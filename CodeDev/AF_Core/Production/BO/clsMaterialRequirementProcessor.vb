Public Class clsMaterialRequirementProcessor : Inherits clsMaterialRequirementInfo
  Private pToProcessQty As Decimal
  Private pReferenceNo As String

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

  Public Property ReferenceNo As String
    Get
      Return pReferenceNo
    End Get
    Set(value As String)
      pReferenceNo = value
    End Set
  End Property


End Class

Public Class colMaterialRequirementProcessors : Inherits List(Of clsMaterialRequirementProcessor)

End Class


