Imports RTIS.CommonVB

Public Class clsEmployeeOverTimeInfos

  Private pEmployee As dmEmployeeRateOfPay
  Private pTimeSheetEntry As dmTimeSheetEntry

  Public Sub New()
    MyBase.New()
    pTimeSheetEntry = New dmTimeSheetEntry
    pEmployee = New dmEmployeeRateOfPay

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub


  Public Property dmTimeSheetEntry() As dmTimeSheetEntry
    Get
      Return pTimeSheetEntry
    End Get
    Set(ByVal value As dmTimeSheetEntry)
      pTimeSheetEntry = value
    End Set
  End Property


  Public ReadOnly Property EmployeeId() As Int32
    Get
      Return pTimeSheetEntry.EmployeeID
    End Get

  End Property


  Public ReadOnly Property StdSalary() As Decimal
    Get
      Return pEmployee.EmployeeRateOfPayID
    End Get

  End Property

  Public ReadOnly Property Overtime() As Int32
    Get
      Return pTimeSheetEntry.OverTimeMinutes
    End Get

  End Property

  Public ReadOnly Property StartDay() As DateTime
    Get
      Return pTimeSheetEntry.StartTime
    End Get

  End Property

  Public ReadOnly Property EndTime() As DateTime
    Get
      Return pTimeSheetEntry.EndTime
    End Get

  End Property


End Class

Public Class colEmployeeOverTimeInfos : Inherits List(Of clsStockItemInfo)

End Class