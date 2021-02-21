Public Class clsDecValueTracker
  Private pDecValue As Decimal

  Public ReadOnly Property DecValue() As Decimal
    Get
      DecValue = pDecValue
    End Get
  End Property

  Public Sub SetDecValue(ByVal vNewValue As Double)
    pDecValue = vNewValue
  End Sub

  Public Function CreateTransactionAdjust(ByVal vPrevValue As Decimal, ByVal vAdjustvalue As Decimal, ByVal vObjectType As Byte, ByVal vObjectID As Integer, ByVal vRef As Integer, ByVal vTranDate As Date, ByVal vTranType As Byte, ByVal vUserID As Integer,
                                          ByVal vNote As String, ByVal vRefObjectType As Byte, ByVal vRefObjectID As Long, ByVal vAdditionalRef As Int32, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal) As dmStockItemTransactionLog

    Dim mTransaction As New dmStockItemTransactionLog
    With mTransaction
      .TranValue = vAdjustvalue
      .ObjectType = vObjectType
      .ObjectID = vObjectID
      .ReferenceNo = vRef
      .SystemDate = Now
      .TransactionDate = vTranDate
      .TransactionType = vTranType
      .UserID = vUserID
      .RefObjectType = vRefObjectType
      .RefObjectID = vRefObjectID
      .AdditionalRef = vAdditionalRef
      .Note = vNote
      .PrevValue = vPrevValue
      .NewValue = vPrevValue + vAdjustvalue


      Select Case vDefaultCurrency
        Case eCurrency.Cordobas
          .TransactionValuationDollar = (vUnitCost * vAdjustvalue) / vExchangeRate
          .TransactionValuation = vUnitCost * vAdjustvalue


        Case eCurrency.Dollar
          .TransactionValuationDollar = (vUnitCost * vAdjustvalue)
          .TransactionValuation = (vUnitCost * vAdjustvalue) / vExchangeRate

      End Select
      ''//Rouding in 4 decimal places as per Leonels'Request
      .TransactionValuationDollar = Math.Round(.TransactionValuationDollar, 4, MidpointRounding.AwayFromZero)

      .TransactionValuation = Math.Round(.TransactionValuation, 4, MidpointRounding.AwayFromZero)

    End With
    pDecValue = pDecValue + vAdjustvalue
    Return mTransaction
  End Function

  Public Function CreateTransactionSet(ByVal vPrevValue As Decimal, ByVal vSetValue As Decimal, ByVal vObjectType As Byte, ByVal vObjectID As Integer, ByVal vRef As Integer, ByVal vTranDate As Date, ByVal vTranType As Byte, ByVal vUserID As Integer, ByVal vNote As String, ByVal vRefObjectType As Byte, ByVal vRefObjectID As Long, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal) As dmStockItemTransactionLog
    Dim mTransaction As New dmStockItemTransactionLog
    mTransaction.TranValue = vSetValue
    mTransaction.ObjectType = vObjectType
    mTransaction.ObjectID = vObjectID
    mTransaction.AdditionalRef = vRef
    mTransaction.SystemDate = Now
    mTransaction.TransactionDate = vTranDate
    mTransaction.TransactionType = vTranType
    mTransaction.UserID = vUserID
    mTransaction.RefObjectType = vRefObjectType
    mTransaction.RefObjectID = vRefObjectID
    mTransaction.Note = vNote
    mTransaction.PrevValue = vPrevValue
    mTransaction.NewValue = vSetValue

    Select Case vDefaultCurrency
      Case eCurrency.Cordobas
        mTransaction.TransactionValuationDollar = (vUnitCost * vSetValue) / vExchangeRate
        mTransaction.TransactionValuation = vUnitCost * vSetValue

      Case eCurrency.Dollar
        mTransaction.TransactionValuationDollar = (vUnitCost * vSetValue)
        mTransaction.TransactionValuation = (vUnitCost * vSetValue) / vExchangeRate

    End Select


    pDecValue = vSetValue
    Return mTransaction
  End Function

  Public Function CreateTransactionStockCheck(ByVal vNewValue As Decimal, ByVal vPrevValue As Decimal, ByVal vObjectType As Byte, ByVal vObjectID As Integer, ByVal vRef As Integer, ByVal vTranDate As Date, ByVal vUserID As Integer, ByVal vNote As String, ByVal vRefObjectType As Byte, ByVal vRefObjectID As Long) As dmStockItemTransactionLog
    Dim mTransaction As New dmStockItemTransactionLog

    mTransaction.ObjectType = vObjectType
    mTransaction.ObjectID = vObjectID
    mTransaction.AdditionalRef = vRef
    mTransaction.SystemDate = Now
    mTransaction.TransactionDate = vTranDate
    mTransaction.TransactionType = eTransactionType.StockCheck
    mTransaction.UserID = vUserID
    mTransaction.RefObjectType = vRefObjectType
    mTransaction.RefObjectID = vRefObjectID
    mTransaction.Note = vNote

    mTransaction.TranValue = vNewValue
    mTransaction.PrevValue = vPrevValue
    mTransaction.NewValue = vNewValue


    Return mTransaction
  End Function




End Class

