Imports RTIS.CommonVB

Public Class clsProductlRequirementInfo
  Private pProductMaterialRequirement As dmSalesOrderItemProductRequirement
  Private pDescription As String
  Private pSalesOrderItemID As Integer

  '//Additional properties that are loaded after main dto
  Private pWorkOrderAllocationWorkOrderNo As String
  Private pWorkOrderAllocationID As Integer
  Private pProductCode As String


  Public Property ProductCode As String
    Get
      Return pProductCode
    End Get
    Set(value As String)
      pProductCode = value
    End Set
  End Property
  Public Sub New(ByRef rProductRequirement As dmSalesOrderItemProductRequirement)
    pProductMaterialRequirement = rProductRequirement

  End Sub

  Public Sub New()
    pProductMaterialRequirement = New dmSalesOrderItemProductRequirement
  End Sub

  Public Property ProductRequirement As dmSalesOrderItemProductRequirement
    Get
      Return pProductMaterialRequirement
    End Get
    Set(ByVal value As dmSalesOrderItemProductRequirement)
      pProductMaterialRequirement = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pDescription
    End Get
    Set(value As String)
      pDescription = value
    End Set
  End Property

  Public Property SalesOrderItemID As Integer
    Get
      Return pProductMaterialRequirement.SalesOrderItemID
    End Get
    Set(value As Integer)
      pProductMaterialRequirement.SalesOrderItemID = value
    End Set
  End Property

  Public Property ItemNumber As String

End Class


Public Class colProductMaterialRequirementInfos : Inherits List(Of clsProductlRequirementInfo)

End Class