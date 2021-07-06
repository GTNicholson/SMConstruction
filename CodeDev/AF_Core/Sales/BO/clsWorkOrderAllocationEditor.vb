Imports System.ComponentModel
Imports RTIS.CommonVB

Public Class clsWorkOrderAllocationEditor

  Private pWorkOrder As dmWorkOrder
  Private pWorkOrderAllocation As dmWorkOrderAllocation

  Private pSalesOrderNo As String
  Private pItemNumber As String
  Private pClientName As String
  Private pProjectName As String
  Private pRequiredDate As Date
  Private pAssemblyRef As String
  Private pSalesItemType As Int32
  Private pDescriptionItem As String

  Public Sub New(ByRef rWorkOrder As dmWorkOrder, ByRef rWorkOrderAllocation As dmWorkOrderAllocation)
    pWorkOrder = rWorkOrder
    pWorkOrderAllocation = rWorkOrderAllocation
  End Sub

  Public Sub New()
    pWorkOrder = New dmWorkOrder
    pWorkOrderAllocation = New dmWorkOrderAllocation
  End Sub

  'Public Sub PopulateSalesOrderPhaseItemInfo(ByRef rSalesOrderPhaseInfo As clsSalesOrderPhaseInfo)
  Public Sub PopulateSalesOrderPhaseItemInfo(ByRef rSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo)
    If rSalesOrderPhaseItemInfo IsNot Nothing Then
      pSalesOrderNo = rSalesOrderPhaseItemInfo.OrderNo
      If rSalesOrderPhaseItemInfo.PhaseRef.ToString <> "" Then pSalesOrderNo = pSalesOrderNo & "-" & rSalesOrderPhaseItemInfo.PhaseRef.ToString
      pItemNumber = rSalesOrderPhaseItemInfo.ItemNumber
      pClientName = rSalesOrderPhaseItemInfo.CompanyName
      pProjectName = rSalesOrderPhaseItemInfo.ProjectName
      pRequiredDate = rSalesOrderPhaseItemInfo.DateRequired
      pDescriptionItem = rSalesOrderPhaseItemInfo.Description

    End If
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

  Public Property SalesOrderPhaseItemID As Int32
    Get
      Return pWorkOrderAllocation.SalesOrderPhaseItemID
    End Get
    Set(value As Int32)
      pWorkOrderAllocation.SalesOrderPhaseItemID = value
    End Set
  End Property

  Public Property SalesOrderNo As String
    Get
      Return pSalesOrderNo
    End Get
    Set(value As String)
      pSalesOrderNo = value
    End Set
  End Property

  Public Property ItemNumber As String
    Get
      Return pItemNumber
    End Get
    Set(value As String)
      pItemNumber = value
    End Set
  End Property

  Public Property SalesItemType As Int32
    Get
      Return pSalesItemType
    End Get
    Set(value As Int32)
      pSalesItemType = value
    End Set
  End Property

  Public ReadOnly Property SalesItemTypeDesc As String
    Get
      Dim mRetVal As String = ""
      Dim mProductConstructionType As dmProductConstructionType
      mProductConstructionType = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes).ItemFromKey(pSalesItemType)

      If mProductConstructionType IsNot Nothing Then
        mRetVal = mProductConstructionType.Description
      End If

      Return mRetVal
    End Get

  End Property

  Public Property DescriptionItem As String
    Get
      Return pDescriptionItem
    End Get
    Set(value As String)
      pDescriptionItem = value
    End Set
  End Property
  Public Property ClientName As String
    Get
      Return pClientName
    End Get
    Set(value As String)
      pClientName = value
    End Set
  End Property

  Public Property ProjectName As String
    Get
      Return pProjectName
    End Get
    Set(value As String)
      pProjectName = value
    End Set
  End Property

  Public Property RequiredDate As Date
    Get
      Return pRequiredDate
    End Get
    Set(value As Date)
      pRequiredDate = value
    End Set
  End Property

  Public Property AssemblyRef As String
    Get
      Return pAssemblyRef
    End Get
    Set(value As String)
      pAssemblyRef = value
    End Set
  End Property



End Class

Public Class colWorkOrderAllocationEditors : Inherits BindingList(Of clsWorkOrderAllocationEditor)


End Class