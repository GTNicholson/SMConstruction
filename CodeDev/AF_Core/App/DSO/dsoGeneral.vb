Imports RTIS.CommonVB
Imports RTIS.DataLayer
Public Class dsoGeneral
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function GetNextTallyWorkOrderNo() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.WorkOrder)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function
  Public Function getNextTally(ByVal vTallyNumber As Integer) As Integer
    Dim mRetVal As Int32 = 0

    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(vTallyNumber)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function
  Public Function GetNextTallyWONo() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.StructureWO)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function
  Public Function GetNextTallyPONo() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.PurchaseOrderNo)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetNextTallyWoodPallet() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.WoodPallet)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetNextTallyWoodPalletConnected() As Integer
    Dim mRetVal As Integer
    Try

      mRetVal = pDBConn.NextTally(eTallyIDs.WoodPallet)
    Catch ex As Exception
    Finally

    End Try
    Return mRetVal
  End Function
  Public Function LoadHostCompanys(ByRef rHostCompanys As colHostCompanys) As Boolean
    Dim mdto As dtoHostCompany
    Dim mOK As Boolean
    Try

      mdto = New dtoHostCompany(pDBConn)

      mOK = mdto.LoadHostCompanyCollection(rHostCompanys)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function GetExchangeRate(ByVal vDate As Date, ByVal vCurrency As Integer) As Decimal
    Dim mRetval As Decimal = 0
    Dim mExchangeRate As New dmExchangeRate
    Dim mReader As IDataReader
    Dim mSql As String = String.Format("Select * from ExchangeRate Where ExchangeRateDate >= '{0}' and Currency = {1} Order By ExchangeRateDate", vDate.ToString("yyyyMMdd"), vCurrency)
    Try

      pDBConn.Connect()

      mReader = pDBConn.LoadReader(mSql)

      If mReader.Read Then
        mRetval = RTIS.DataLayer.clsDBConnBase.DBReadDecimal(mReader, "ExchangeRateValue")
      End If
      mReader.Close()

      ''//If it does not found a value, try to find the last one Rate
      If mRetval = 0 Then


        mSql = String.Format("Select * from ExchangeRate Where ExchangeRateDate <= '{0}' and Currency = {1} Order By ExchangeRateDate desc", vDate.ToString("yyyyMMdd"), vCurrency)

        mReader = pDBConn.LoadReader(mSql)

        If mReader.Read Then
          mRetval = RTIS.DataLayer.clsDBConnBase.DBReadDecimal(mReader, "ExchangeRateValue")
        End If

      End If
      mReader.Close()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try


    Return mRetval
  End Function

End Class
