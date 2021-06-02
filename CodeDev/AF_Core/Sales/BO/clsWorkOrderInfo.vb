Imports RTIS.CommonVB

Public Class clsWorkOrderInfo
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer

  Public Sub New()
    pWorkOrder = New dmWorkOrder
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(value As dmCustomer)
      pCustomer = value
    End Set
  End Property

  Public ReadOnly Property CustomerName As String
    Get
      Return pCustomer.CompanyName
    End Get

  End Property

  Public ReadOnly Property WorkOrderID As Integer
    Get
      Return pWorkOrder.WorkOrderID
    End Get
  End Property

  Public ReadOnly Property WorkOrderNo As String
    Get
      Return pWorkOrder.WorkOrderNo
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pWorkOrder.Description
    End Get
  End Property

  Public ReadOnly Property Quantity As Integer
    Get
      Return pWorkOrder.Quantity
    End Get
  End Property



  Public ReadOnly Property QtyPerSalesItem As Integer
    Get
      Return pWorkOrder.QtyPerSalesItem
    End Get
  End Property

  Public ReadOnly Property ProductTypeID As Integer
    Get
      Return pWorkOrder.ProductTypeID
    End Get
  End Property

  Public ReadOnly Property PlannedStartDate As DateTime
    Get
      Return pWorkOrder.PlannedStartDate
    End Get
  End Property

  Public ReadOnly Property PlannedDeliverDate As DateTime
    Get
      Return pWorkOrder.PlannedDeliverDate
    End Get
  End Property


  Public ReadOnly Property UnitPrice As Decimal
    Get
      Return pWorkOrder.UnitPrice
    End Get
  End Property

  Public ReadOnly Property PlannedStartDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pSalesOrder.FinishDate)
    End Get
  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property

  Public ReadOnly Property BusinessSector As Integer
    Get
      Return pSalesOrder.BusinessSectorID
    End Get
  End Property

  Public ReadOnly Property OrderTypeID As Integer
    Get
      Return pSalesOrder.OrderTypeID
    End Get
  End Property

  Public ReadOnly Property OrderStatusENUM As Integer
    Get
      Return pSalesOrder.OrderStatusENUM
    End Get
  End Property

  Public ReadOnly Property CustomerRef As String
    Get
      Return pSalesOrder.CustomerRef
    End Get
  End Property


  Public ReadOnly Property ContractManagerID As Integer
    Get
      Return pSalesOrder.ContractManagerID
    End Get
  End Property

  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property PurchasingDate As Date
    Get
      Return pWorkOrder.PurchasingDate
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property

  Public ReadOnly Property SalesAreaID As String
    Get
      Return pCustomer.SalesAreaID
    End Get
  End Property

  Public ReadOnly Property WorkOrderType As Int32
    Get
      Return pWorkOrder.WorkOrderType
    End Get
  End Property

  Public ReadOnly Property EmployeeID As Int32
    Get
      Return pWorkOrder.EmployeeID
    End Get
  End Property


  Public ReadOnly Property WoodSpecieID As Int32
    Get
      Return pWorkOrder.WoodSpecieID
    End Get
  End Property


  Public ReadOnly Property FinishDate As Date
    Get
      Return pSalesOrder.FinishDate
    End Get
  End Property

  Public ReadOnly Property WorkOrderWoodType As Integer
    Get
      Return pWorkOrder.WorkOrderWoodType
    End Get
  End Property

  Public ReadOnly Property WorkOrderWoodTypeDesc As String
    Get
      Return eStockItemTypeTimberWood.GetInstance.DisplayValueFromKey(WorkOrderWoodType)
    End Get
  End Property

  Public ReadOnly Property WorkOrderProcessOption As Integer
    Get
      Return pWorkOrder.WorkOrderProcessOption
    End Get
  End Property

  Public ReadOnly Property WorkOrderTargetWoodType As Integer
    Get
      Return pWorkOrder.WorkOrderTargetWoodType
    End Get
  End Property
End Class


Public Class colWorkOrderInfos : Inherits List(Of clsWorkOrderInfo)

  Public Function IndexFromWorkOrderID(ByVal vWorkOrderID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mWO As clsWorkOrderInfo In Me
      mIndex += 1
      If mWO.WorkOrder.WorkOrderID = vWorkOrderID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromWorkOrderID(ByVal vWorkOrderID As String) As clsWorkOrderInfo
    Dim mRetVal As clsWorkOrderInfo = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromWorkOrderID(vWorkOrderID)
    If mIndex <> -1 Then
      mRetVal = Me(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromWorkOrderNo(ByVal vWorkOrderNo As String) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mWO As clsWorkOrderInfo In Me
      mIndex += 1
      If mWO.WorkOrderNo.Length > 2 Then
        If mWO.WorkOrder.WorkOrderNo.Contains("-") = False Then
          If Val(mWO.WorkOrder.WorkOrderNo.Substring(2)) = Val(vWorkOrderNo) Then
            mRetVal = mIndex
            Exit For
          End If
        Else
          If vWorkOrderNo.Contains("-") = True Then
            If Val(mWO.WorkOrder.WorkOrderNo.Substring(2)) = Val(vWorkOrderNo) Then
              If mWO.WorkOrder.WorkOrderNo.Substring(mWO.WorkOrder.WorkOrderNo.IndexOf("-")) = vWorkOrderNo.Substring(vWorkOrderNo.IndexOf("-")) Then
                mRetVal = mIndex
                Exit For
              End If
            End If
          End If
        End If
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromWorkOrderNo(ByVal vWorkOrderNo As String) As clsWorkOrderInfo
    Dim mRetVal As clsWorkOrderInfo = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromWorkOrderNo(vWorkOrderNo)
    If mIndex <> -1 Then
      mRetVal = Me(mIndex)
    End If
    Return mRetVal
  End Function

End Class