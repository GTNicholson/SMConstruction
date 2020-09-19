Public Class clsPaySlipItem : Inherits colEmployeeRateOfPays

  Private pItemDate As Date
  Private pStartTime As DateTime
  Private pEndTime As DateTime
  Private pStandardHours As Decimal
  Private pOverTimeHours As Decimal
  Private pInStandardRange As Boolean
  Private pInOverTimeRange As Boolean
  Private pStdPayment As Decimal
  Private pOverTimePayment As Decimal
  Private pTotalPayment As Decimal

  Public Property ItemDate As Date
    Get
      Return pItemDate
    End Get
    Set(value As Date)
      pItemDate = value
    End Set
  End Property

  Public Property StartTime As Date
    Get
      Return pStartTime
    End Get
    Set(value As Date)
      pStartTime = value
    End Set
  End Property

  Public Property EndTime As Date
    Get
      Return pEndTime
    End Get
    Set(value As Date)
      pEndTime = value
    End Set
  End Property

  Public Property StandardHours As Decimal
    Get
      Return pStandardHours
    End Get
    Set(value As Decimal)
      pStandardHours = value
    End Set
  End Property

  Public Property StdPayment As Decimal
    Get
      Return pStdPayment
    End Get
    Set(value As Decimal)
      pStdPayment = value
    End Set
  End Property

  Public Property TotalPayment As Decimal
    Get
      Return pTotalPayment
    End Get
    Set(value As Decimal)
      pTotalPayment = value
    End Set
  End Property

  Public Property OverTimePayment As Decimal
    Get
      Return pOverTimePayment
    End Get
    Set(value As Decimal)
      pOverTimePayment = value
    End Set
  End Property

  Public Property OverTimeHours As Decimal
    Get
      Return pOverTimeHours
    End Get
    Set(value As Decimal)
      pOverTimeHours = value
    End Set
  End Property

  Public Property InStandardRange As Boolean
    Get
      Return pInStandardRange
    End Get
    Set(value As Boolean)
      pInStandardRange = value
    End Set
  End Property

  Public Property InOverTimeRange As Boolean
    Get
      Return pInOverTimeRange
    End Get
    Set(value As Boolean)
      pInOverTimeRange = value
    End Set
  End Property


End Class

Public Class colPaySlipItems : Inherits List(Of clsPaySlipItem)

  Public Function ItemFromDate(ByVal vDate As DateTime) As clsPaySlipItem
    Dim mRetVal As clsPaySlipItem = Nothing
    For Each mItem As clsPaySlipItem In Me
      If mItem.ItemDate = vDate Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

End Class
