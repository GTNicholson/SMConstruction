Imports System.ComponentModel

Public Class clsWorkOrderAllocationEditor

  Private pWorkOrder As dmWorkOrder
  Private pWorkOrderAllocation As dmWorkOrderAllocation

  Public Sub New(ByRef rWorkOrder As dmWorkOrder, ByRef rWorkOrderAllocation As dmWorkOrderAllocation)
    pWorkOrder = rWorkOrder
    pWorkOrderAllocation = rWorkOrderAllocation

  End Sub

  Public Sub New()
    pWorkOrder = New dmWorkOrder
    pWorkOrderAllocation = New dmWorkOrderAllocation
  End Sub



  Public ReadOnly Property WorkOrderAllocation As dmWorkOrderAllocation
    Get
      Return pWorkOrderAllocation
    End Get
  End Property
  Public Property QuantityDone As Decimal
    Get
      Return pWorkOrderAllocation.QuantityDone
    End Get
    Set(value As Decimal)
      pWorkOrderAllocation.QuantityDone = value
    End Set
  End Property

  Public Property QuantityRequired As Decimal
    Get
      Return pWorkOrderAllocation.QuantityRequired
    End Get
    Set(value As Decimal)
      pWorkOrderAllocation.QuantityRequired = value
    End Set
  End Property

  Public Property WorkOrderAllocationID As Int32
    Get
      Return pWorkOrderAllocation.WorkOrderAllocationID
    End Get
    Set(value As Int32)
      pWorkOrderAllocation.WorkOrderAllocationID = value
    End Set
  End Property

  Public Property WorkOrderID As Int32
    Get
      Return pWorkOrderAllocation.WorkOrderID
    End Get
    Set(value As Int32)
      pWorkOrderAllocation.WorkOrderID = value
    End Set
  End Property

  Public Property PhaseItemComponentID As Int32
    Get
      Return pWorkOrderAllocation.PhaseItemComponentID
    End Get
    Set(value As Int32)
      pWorkOrderAllocation.PhaseItemComponentID = value
    End Set
  End Property

  Public Property SalesItemType As Decimal
    Get
      Return pWorkOrderAllocation.QuantityDone
    End Get
    Set(value As Decimal)
      pWorkOrderAllocation.QuantityDone = value
    End Set
  End Property

End Class

Public Class colWorkOrderAllocationEditors : Inherits BindingList(Of clsWorkOrderAllocationEditor)




End Class