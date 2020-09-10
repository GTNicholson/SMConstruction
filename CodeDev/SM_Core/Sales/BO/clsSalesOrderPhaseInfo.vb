Public Class clsSalesOrderPhaseInfo
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer

  Public Sub New()
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
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

  Public ReadOnly Property QuantityItems As Integer
    Get
      Return pSalesOrderPhase.QuantityItems
    End Get
  End Property

  Public ReadOnly Property TotalPrice As Decimal
    Get
      Return pSalesOrderPhase.TotalPrice
    End Get
  End Property



  Public ReadOnly Property PhaseNumber As Integer
    Get
      Return pSalesOrderPhase.PhaseNumber
    End Get
  End Property

  Public ReadOnly Property DespatchStatus As Byte
    Get
      Return pSalesOrderPhase.DespatchStatus
    End Get
  End Property

  Public ReadOnly Property InvoiceStatus As Byte
    Get
      Return pSalesOrderPhase.InvoiceStatus
    End Get
  End Property

  Public ReadOnly Property ProductionStatus As Byte
    Get
      Return pSalesOrderPhase.ProductionStatus
    End Get
  End Property


  Public ReadOnly Property MatReqStatus As Byte
    Get
      Return pSalesOrderPhase.MatReqStatus
    End Get
  End Property

  Public ReadOnly Property DateCreatedWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pSalesOrderPhase.DateCreated)
    End Get
  End Property


  Public ReadOnly Property DateCreated As Date
    Get
      Return pSalesOrderPhase.DateCreated
    End Get
  End Property

  Public ReadOnly Property DateCommittedWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pSalesOrderPhase.DateCommitted)
    End Get
  End Property


  Public ReadOnly Property DateCommitted As Date
    Get
      Return pSalesOrderPhase.DateCommitted
    End Get
  End Property


  Public ReadOnly Property CommittedBy As Integer
    Get
      Return pSalesOrderPhase.CommittedBy
    End Get
  End Property

  Public ReadOnly Property SOPJobNo As String
    Get
      Return pSalesOrderPhase.JobNo
    End Get
  End Property

  Public ReadOnly Property PhaseRef As Integer
    Get
      Return pSalesOrderPhase.PhaseRef
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


  Public ReadOnly Property ContractManagerID As Integer
    Get
      Return pSalesOrder.ContractManagerID
    End Get
  End Property

  Public ReadOnly Property DateEntered As Date
    Get
      Return pSalesOrder.DateEntered
    End Get
  End Property



  Public ReadOnly Property OrderStatusENUM As Integer
    Get
      Return pSalesOrder.OrderStatusENUM
    End Get
  End Property

  Public ReadOnly Property OrderTypeID As Integer
    Get
      Return pSalesOrder.OrderTypeID
    End Get
  End Property

  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property



End Class


Public Class colSalesOrderPhaseInfos : Inherits List(Of clsSalesOrderPhaseInfo)

  Public Function IndexFromSOPhaseID(ByVal vSalesOrderPhaseID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mSOPI As clsSalesOrderPhaseInfo In Me
      mIndex += 1
      If mSOPI.SalesOrderPhase.SalesOrderPhaseID = vSalesOrderPhaseID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromWorkOrderID(ByVal vSalesOrderPhaseID As String) As clsSalesOrderPhaseInfo
    Dim mRetVal As clsSalesOrderPhaseInfo = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromSOPhaseID(vSalesOrderPhaseID)
    If mIndex <> -1 Then
      mRetVal = Me(mIndex)
    End If
    Return mRetVal
  End Function


End Class