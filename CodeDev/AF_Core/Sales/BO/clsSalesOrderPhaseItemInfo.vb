Public Class clsSalesOrderPhaseItemInfo
  Private pSalesOrderPhaseItem As dmSalesOrderPhaseItem
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrderItem As dmSalesOrderItem
  Private pCustomer As dmCustomer
  Private pSalesItemAssembly As dmSalesItemAssembly
  Private pProduct As dmProductBase
  Private pWorkOrder As dmWorkOrder
  Private pStockItemCost As Decimal
  Private pSOPItemMatReqCost As Decimal
  Private pUnitPrice As Decimal
  Private pDateEntered As Date
  Private pExchangeRate As Decimal
  Private pDateCommitted As Date
  Private pTempDateExchange As Date
  Private pSOPIStockItemMatReqDollarValue As Decimal
  Private pSOPItemPickMatReqCost As Decimal
  Private pSOPIPickDollarValue As Decimal
  Private pSpecifiedWoodCost As Decimal
  Private pWoodCost As Decimal

  Public Sub New()
    pSalesOrderPhaseItem = New dmSalesOrderPhaseItem
    pSalesOrder = New dmSalesOrder
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrderItem = New dmSalesOrderItem
    pCustomer = New dmCustomer
    pSalesItemAssembly = New dmSalesItemAssembly
    pWorkOrder = New dmWorkOrder
  End Sub


  Public Property SalesItemAssembly As dmSalesItemAssembly
    Get
      Return pSalesItemAssembly
    End Get
    Set(value As dmSalesItemAssembly)
      pSalesItemAssembly = value
    End Set
  End Property

  Public Property SalesOrderPhaseItem As dmSalesOrderPhaseItem
    Get
      Return pSalesOrderPhaseItem
    End Get
    Set(value As dmSalesOrderPhaseItem)
      pSalesOrderPhaseItem = value
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

  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property

  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
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

  Public Property Product As dmProductBase
    Get
      Return pProduct
    End Get
    Set(value As dmProductBase)
      pProduct = value
    End Set
  End Property

  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public ReadOnly Property SalesOrderPhaseItemID As Int32
    Get
      Return pSalesOrderPhaseItem.SalesOrderPhaseItemID
    End Get

  End Property

  Public ReadOnly Property Qty As Int32
    Get
      Return pSalesOrderPhaseItem.Qty
    End Get

  End Property


  Public ReadOnly Property SalesOrderID As Integer
    Get
      Return pSalesOrder.SalesOrderID
    End Get
  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property


  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property


  Public ReadOnly Property SalesOrderPhaseID As Integer
    Get
      Return pSalesOrderPhase.SalesOrderPhaseID
    End Get
  End Property

  Public ReadOnly Property DateRequired As Date
    Get
      Return pSalesOrderPhase.DateRequired
    End Get
  End Property

  Public ReadOnly Property PhaseNumber As Integer
    Get
      Return pSalesOrderPhase.PhaseNumber
    End Get
  End Property

  Public ReadOnly Property PhaseRef As String
    Get
      Return pSalesOrderPhase.PhaseRef
    End Get
  End Property

  Public ReadOnly Property JobNo As String
    Get
      Return pSalesOrderPhase.JobNo
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property

  Public ReadOnly Property SalesOrderItemID As Int32
    Get
      Return pSalesOrderItem.SalesOrderItemID
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pSalesOrderItem.Description
    End Get
  End Property

  Public ReadOnly Property AssemblyRef As String
    Get
      Return pSalesItemAssembly.Ref
    End Get

  End Property

  Public ReadOnly Property ItemNumber As String
    Get
      Return pSalesOrderItem.ItemNumber
    End Get
  End Property

  Public ReadOnly Property SalesItemType As Integer
    Get
      Return pSalesOrderItem.SalesItemType
    End Get
  End Property

  Public ReadOnly Property ProductCode As String
    Get
      Dim mRetVal As String = ""
      If pProduct IsNot Nothing Then
        mRetVal = pProduct.Code
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property WorkOrderNo As String
    Get
      Dim mRetVal As String = ""
      If pWorkOrder IsNot Nothing Then
        mRetVal = pWorkOrder.WorkOrderNo

      End If
      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property ItemNumberRef As String
    Get
      Dim mRetVal As String = ""
      mRetVal = ItemNumber
      Return mRetVal
    End Get
  End Property

  Public Property WoodCost As Decimal
    Get
      Return pWoodCost
    End Get
    Set(value As Decimal)
      pWoodCost = value
    End Set
  End Property
  Public Property StockItemCost As Decimal
    Get
      Return pStockItemCost
    End Get
    Set(value As Decimal)
      pStockItemCost = value
    End Set
  End Property

  Public Property SOPItemMatReqCost As Decimal
    Get

      Return pSOPItemMatReqCost
    End Get
    Set(value As Decimal)
      pSOPItemMatReqCost = value
    End Set
  End Property

  Public Property SOPItemPickMatReqCost As Decimal
    Get
      Return pSOPItemPickMatReqCost
    End Get
    Set(value As Decimal)
      pSOPItemPickMatReqCost = value
    End Set
  End Property

  Public Property UnitPrice As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(value As Decimal)
      pUnitPrice = value
    End Set
  End Property

  Public Property DateEntered As Date
    Get
      Return pDateEntered
    End Get
    Set(value As Date)
      pDateEntered = value
    End Set
  End Property

  Public Property SOPIPickDollarValue As Decimal
    Get
      Return pSOPIPickDollarValue
    End Get
    Set(value As Decimal)
      pSOPIPickDollarValue = value
    End Set
  End Property

  Public Property SOPIStockItemMatReqDollarValue As Decimal
    Get
      Return pSOPIStockItemMatReqDollarValue
    End Get
    Set(value As Decimal)
      pSOPIStockItemMatReqDollarValue = value
    End Set
  End Property
  Public Property DateCommitted As Date
    Get
      Return pDateCommitted
    End Get
    Set(value As Date)
      pDateCommitted = value
    End Set
  End Property

  Public Property ExchangeRate As Decimal
    Get
      Return pExchangeRate
    End Get
    Set(value As Decimal)
      pExchangeRate = value
    End Set
  End Property

  Public Property TempDateExchange As Date
    Get
      Return pTempDateExchange
    End Get
    Set(value As Date)
      pTempDateExchange = value
    End Set
  End Property

  Public Property SpecifiedWoodCost As Decimal
    Get
      Return pSpecifiedWoodCost
    End Get
    Set(value As Decimal)
      pSpecifiedWoodCost = value
    End Set
  End Property
End Class


Public Class colSalesOrderPhaseItemInfos : Inherits List(Of clsSalesOrderPhaseItemInfo)

  Public Sub New()

  End Sub

  Public Sub New(ByVal vList As List(Of clsSalesOrderPhaseItemInfo))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromSOPhaseID(ByVal vSalesOrderPhaseID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mSOPI As clsSalesOrderPhaseItemInfo In Me
      mIndex += 1
      If mSOPI.SalesOrderPhase.SalesOrderPhaseID = vSalesOrderPhaseID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromKey(ByVal vPhaseItemComponentID As Integer) As clsSalesOrderPhaseItemInfo
    Dim mItem As clsSalesOrderPhaseItemInfo
    Dim mRetVal As clsSalesOrderPhaseItemInfo = Nothing

    For Each mItem In Me

      If mItem IsNot Nothing Then


        If mItem.SalesOrderPhaseItemID = vPhaseItemComponentID Then
          mRetVal = mItem
          Exit For
        End If
      End If
    Next

    Return mRetVal
  End Function

  Public Function GetTotalStockItemMatReqReal() As Decimal
    Dim mRetVal As Decimal

    For Each mItem In Me

      If mItem IsNot Nothing Then

        mRetVal += mItem.SOPIStockItemMatReqDollarValue

      End If
    Next

    Return mRetVal
  End Function

  Public Function GetTotalWoodMatReqReal() As Decimal
    Dim mRetVal As Decimal

    For Each mItem In Me

      If mItem IsNot Nothing Then

        mRetVal += mItem.SOPIStockItemMatReqDollarValue

      End If
    Next

    Return mRetVal
  End Function

  Public Function GetTotalStockItemMatReqPickReal() As Decimal
    Dim mRetVal As Decimal

    For Each mItem In Me

      If mItem IsNot Nothing Then

        mRetVal += mItem.SOPIPickDollarValue

      End If
    Next

    Return mRetVal
  End Function
End Class