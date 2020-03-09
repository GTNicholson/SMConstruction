﻿Public Class clsCompanyDay
  Private pCompanyDayDate As DateTime
  Private pSOIEngineered As colSalesOrderItemProgressInfos
  Private pSOIPacked As colSalesOrderItemProgressInfos
  Private pTSECosts As colTimeSheetEntryInfos
  Private pMatOtherCosts As colStockItemTransactionLogInfos
  Private pMatOtherCost As Decimal

  Public Sub New()
    pMatOtherCosts = New colStockItemTransactionLogInfos
  End Sub

  Public Property CompanyDayDate As DateTime
    Get
      Return pCompanyDayDate
    End Get
    Set(value As DateTime)
      pCompanyDayDate = value
    End Set
  End Property

  Public ReadOnly Property MatOtherCosts As colStockItemTransactionLogInfos
    Get
      Return pMatOtherCosts
    End Get
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

  Public Property MatOtherCost As Decimal
    Get
      Return pMatOtherCost
    End Get
    Set(value As Decimal)
      pMatOtherCost = value
    End Set
  End Property

End Class

Public Class colCompanyDays : Inherits List(Of clsCompanyDay)
  Public Function GetItemFromDate(ByVal vDate As DateTime) As clsCompanyDay
    Dim mRetval As clsCompanyDay = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromDate(vDate)
    If mIndex <> -1 Then
      mRetval = Me(mIndex)
    End If
    Return mRetval

  End Function
  'write a function to return the correct member fo the collection
  Public Function IndexFromDate(ByVal vDate As DateTime) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mCompanyDay As clsCompanyDay In Me
      mIndex += 1
      If mCompanyDay.CompanyDayDate = vDate Then
        mRetVal = mIndex
        Exit For

      End If

    Next
    Return mRetVal
  End Function
End Class