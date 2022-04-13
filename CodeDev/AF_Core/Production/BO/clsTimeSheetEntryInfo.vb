
Imports System.Globalization

Public Class clsTimeSheetEntryInfo
  Private pTimeSheetEntry As dmTimeSheetEntry
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer
  Private pEmployeeRateOfPay As dmEmployeeRateOfPay
  Private Shared sEmployeeVIs As RTIS.CommonVB.colValueItems
  Private pStandarRate As Decimal
  Private pOverTimeRate As Decimal
  Private pUserName As String


  Public Sub New()
    pTimeSheetEntry = New dmTimeSheetEntry
    pWorkOrder = New dmWorkOrder
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
    pEmployeeRateOfPay = New dmEmployeeRateOfPay

    If sEmployeeVIs Is Nothing Then
      sEmployeeVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees)
    End If

  End Sub

  Public ReadOnly Property TimeSheetEntry As dmTimeSheetEntry
    Get
      Return pTimeSheetEntry
    End Get
  End Property

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property

  Public ReadOnly Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
  End Property

  Public ReadOnly Property CustomerName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property



  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property
  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property TimeSheetEntryID As Integer
    Get
      Return pTimeSheetEntry.TimeSheetEntryID
    End Get
  End Property


  Public ReadOnly Property OverTimeMinutes As Int32
    Get
      Return pTimeSheetEntry.OverTimeMinutes
    End Get
  End Property

  Public ReadOnly Property OverTimeHour As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = Math.Round(OverTimeMinutes / 60, 2, MidpointRounding.AwayFromZero)

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TimeSheetEntryTypeID As Integer
    Get
      Return pTimeSheetEntry.TimeSheetEntryTypeID
    End Get
  End Property

  Public ReadOnly Property TimeSheetDateGUI As String
    Get
      Dim mRetVal As String
      mRetVal = TimeSheetDateWC.ToString("dddd-dd") & " al " & TimeSheetDateWC.AddDays(6).ToString("dddd-dd")

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property TimeSheetEntryTypeDesc As String
    Get
      Return colTimeSheetCodes.GetInstance.DisplayValueFromKey(pTimeSheetEntry.TimeSheetEntryTypeID)
    End Get
  End Property

  Public ReadOnly Property EmployeeID As Integer
    Get
      Return pTimeSheetEntry.EmployeeID
    End Get
  End Property

  Public ReadOnly Property EmployeeName As String
    Get
      Return sEmployeeVIs.ItemValueToDisplayValue(pTimeSheetEntry.EmployeeID)
    End Get
  End Property

  Public ReadOnly Property WorkOrderID As Integer
    Get
      Return pTimeSheetEntry.WorkOrderID
    End Get
  End Property

  Public ReadOnly Property StartTime As DateTime
    Get
      Return pTimeSheetEntry.StartTime
    End Get
  End Property

  Public ReadOnly Property TimeSheetDate As DateTime
    Get
      Return pTimeSheetEntry.StartTime.Date
    End Get
  End Property

  Public ReadOnly Property EmployeeRateOfPay As dmEmployeeRateOfPay
    Get
      Return pEmployeeRateOfPay
    End Get
  End Property

  Public Property StandardRate As Decimal
    Get
      pStandarRate = (pEmployeeRateOfPay.StandardRate)
      Return pStandarRate
    End Get
    Set(value As Decimal)
      pStandarRate = value
    End Set
  End Property

  Public Property OverTimeRate As Decimal
    Get
      pOverTimeRate = pEmployeeRateOfPay.OverTimeRate

      Return pOverTimeRate
    End Get
    Set(value As Decimal)
      pOverTimeRate = value
    End Set
  End Property

  Public ReadOnly Property WODescriptionRef As String
    Get
      If pWorkOrder.WorkOrderNo <> "" Then
        Return pWorkOrder.WorkOrderNo.Substring(3) & "-" & pWorkOrder.Description


      Else
        Return ""
      End If
    End Get
  End Property
  Public ReadOnly Property TotalStandardValueIncludingOverTimeCost As Decimal
    Get
      Dim mRetVal As Decimal
      mRetVal = TotalStandardValue + TotalOverTimeValue
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalStandardValue As Decimal
    Get
      Dim mNetDuration As Decimal
      Dim mRetVal As Decimal

      If pTimeSheetEntry.Duration > OverTimeHour Then
        mNetDuration = pTimeSheetEntry.Duration - OverTimeHour
        mRetVal = StandardRate * mNetDuration

      Else
        mNetDuration = pTimeSheetEntry.Duration
        mRetVal = StandardRate * pTimeSheetEntry.Duration
      End If
      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property TotalOverTimeValue As Decimal
    Get

      Return OverTimeRate * OverTimeHour
    End Get

  End Property


  Public ReadOnly Property TimeSheetDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pTimeSheetEntry.StartTime.Date)
    End Get
  End Property

  Public ReadOnly Property TimeSheetDateMC As DateTime
    Get
      Return New Date(Year(pTimeSheetEntry.StartTime), Month(pTimeSheetEntry.StartTime), 1)
    End Get
  End Property

  Public ReadOnly Property EndTime As DateTime
    Get
      Return pTimeSheetEntry.EndTime
    End Get
  End Property
  Public ReadOnly Property BreakMins As Integer
    Get
      Return pTimeSheetEntry.BreakMins
    End Get
  End Property
  Public ReadOnly Property Duration As Decimal
    Get
      Return pTimeSheetEntry.Duration
    End Get
  End Property

  Public ReadOnly Property Note As String
    Get
      Return pTimeSheetEntry.Note
    End Get
  End Property

  Public ReadOnly Property WorkCentreID As Integer
    Get
      Return pTimeSheetEntry.WorkCentreID
    End Get
  End Property

  Public ReadOnly Property WorkCentreDesc As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eWorkCentre), CType(pTimeSheetEntry.WorkCentreID, eWorkCentre))
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


  Public ReadOnly Property WeekNumber As String
    Get
      Dim mRetVal As String = ""
      Dim mCultureInfoNica As New CultureInfo("es-NI")
      Dim mCalendar As Calendar
      mCalendar = mCultureInfoNica.Calendar

      mRetVal = "Semana #" & mCalendar.GetWeekOfYear(pTimeSheetEntry.StartTime, CalendarWeekRule.FirstDay, DayOfWeek.Sunday)

      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property ProjectNameWithCustomer As String
    Get
      Dim mRetVal As String = ""


      mRetVal = CustomerName & ": " & ProjectName

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ProjectNameWithReference As String
    Get
      Dim mRetVal As String = ""


      mRetVal = pSalesOrder.OrderNo & ": " & ProjectName

      Return mRetVal
    End Get
  End Property

  Public Property UserIDDesc As String
    Get
      Return pUserName
    End Get
    Set(value As String)
      pUserName = value
    End Set
  End Property

End Class

Public Class colTimeSheetEntryInfos : Inherits List(Of clsTimeSheetEntryInfo)

End Class