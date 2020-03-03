Public Class clsCompanyDay
  Private pCompanyDayDate As DateTime
  Private pSOIEngineered As colSalesOrderItemProgressInfos
  Private pSOIPacked As colSalesOrderItemProgressInfos
  Private pTSECosts As colTimeSheetEntryInfos
  Private pMatIOtherCosts As colStockItemTransactionLogInfos

  Public Property CompanyDayDate As DateTime
    Get
      Return pCompanyDayDate
    End Get
    Set(value As DateTime)
      pCompanyDayDate = value
    End Set
  End Property

  Public ReadOnly Property CompanyDayDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pCompanyDayDate)
    End Get
  End Property

  Public ReadOnly Property CompanyDayDateMC As DateTime
    Get
      Return New Date(Year(pCompanyDayDate), Month(pCompanyDayDate), 1)
    End Get
  End Property

  Public ReadOnly Property ValueEngineered As Decimal
    Get
      Dim mRND As New Random
      Dim mRetVal As Decimal
      mRetVal = mRND.Next(1, 100)
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ValuePacked As Decimal
    Get
      Dim mRND As New Random
      Dim mRetVal As Decimal
      mRetVal = mRND.Next(1, 100)
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property LabcourCostStd As Decimal
    Get
      Dim mRND As New Random
      Dim mRetVal As Decimal
      mRetVal = mRND.Next(1, 100)
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property LabcourCostOT As Decimal
    Get
      Dim mRND As New Random
      Dim mRetVal As Decimal
      mRetVal = mRND.Next(1, 100)
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property MatOtherCost As Decimal
    Get
      Dim mRND As New Random
      Dim mRetVal As Decimal
      mRetVal = mRND.Next(1, 100)
      Return mRetVal
    End Get
  End Property

End Class

Public Class colCompanyDays : Inherits List(Of clsCompanyDay)

End Class