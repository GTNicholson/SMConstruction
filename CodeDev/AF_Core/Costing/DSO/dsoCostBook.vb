Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoCostBook : Inherits dsoBase
  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub


  Public Sub LoadCostBookDown(ByRef rCostBook As dmCostBook, ByVal vCostBookID As Integer)
    Dim mdtoCostBook As New dtoCostBook(pDBConn)
    Dim mdtoCostBookEntry As New dtoCostBookEntry(pDBConn)

    Try
      If pDBConn.Connect() Then
        mdtoCostBook.LoadCostBook(rCostBook, vCostBookID)

        If rCostBook IsNot Nothing Then
          mdtoCostBookEntry.LoadCostBookEntryCollection(rCostBook.CostBookEntrys, rCostBook.CostBookID)
        End If


      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadDefaultCostBookDown(ByRef rCostBook As dmCostBook)
    Dim mdtoCostBook As New dtoCostBook(pDBConn)
    Dim mdtoCostBookEntry As New dtoCostBookEntry(pDBConn)
    Dim mDefaultID As Integer
    Dim msql As String
    Dim mIsNewConnection As Boolean

    Try
      If pDBConn.Connect(mIsNewConnection) Then
        msql = "Select Max(CostBookID) From CostBook Where IsDefault = 1"
        mDefaultID = RTIS.CommonVB.clsGeneralA.DBValueToInteger(pDBConn.ExecuteScalar(msql))
        If mDefaultID <> 0 Then
          mdtoCostBook.LoadCostBook(rCostBook, mDefaultID)

          If rCostBook IsNot Nothing Then
            mdtoCostBookEntry.LoadCostBookEntryCollection(rCostBook.CostBookEntrys, rCostBook.CostBookID)
          End If
        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mIsNewConnection Then
        pDBConn.Disconnect()
      End If
    End Try

  End Sub

  Public Sub LoadCostBookEntry(pCostBookEntrys As colCostBookEntrys, pCostBookID As Integer)
    Dim mdtoCostBookEntry As dtoCostBookEntry = New dtoCostBookEntry(pDBConn)
    Try
      If pDBConn.Connect() Then
        mdtoCostBookEntry.LoadCostBookEntryCollection(pCostBookEntrys, pCostBookID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub




  Public Function SaveCostBookEntryCollection(ByRef rCostBookEntrys As colCostBookEntrys, ByVal vCostBookID As Integer) As Boolean
    Dim mdto As New dtoCostBookEntry(pDBConn)
    Dim mOK As Boolean
    Try
      If pDBConn.Connect() Then
        mOK = mdto.SaveCostBookEntryCollection(rCostBookEntrys, vCostBookID)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function SaveCostBookDown(ByRef rCostBook As dmCostBook) As Boolean
    Dim mdtoCostBook As New dtoCostBook(pDBConn)
    Dim mdtoCostBookEntry As New dtoCostBookEntry(pDBConn)
    Dim mOK As Boolean = False
    Try
      If pDBConn.Connect() Then

        mOK = mdtoCostBook.SaveCostBook(rCostBook)

        If mOK Then

          mOK = mdtoCostBookEntry.SaveCostBookEntryCollection(rCostBook.CostBookEntrys, rCostBook.CostBookID)
        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetDefaultCostBookID() As Integer
    Dim mWhere As String = ""
    Dim mRetVal As Integer
    Try
      If pDBConn.Connect() Then
        mWhere = "Select Top 1 CostBookID from CostBook where IsDefault = 1"

        mRetVal = pDBConn.ExecuteScalar(mWhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Sub LoadCostBook(ByRef rCostBook As dmCostBook, ByVal vCostBookID As Integer)
    Dim mdtoCostBook As New dtoCostBook(pDBConn)
    Try
      If pDBConn.Connect() Then
        mdtoCostBook.LoadCostBook(rCostBook, vCostBookID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub




  Public Function saveCostBook(ByRef rCostBook As dmCostBook) As Boolean
    Dim mdtoCostBook As New dtoCostBook(pDBConn)
    Dim mOK As Boolean = False
    Try
      If pDBConn.Connect() Then

        mOK = mdtoCostBook.SaveCostBook(rCostBook)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetDefaultCostBookValueByStockItemIDConnected(ByVal vStockItemID As Integer) As Decimal
    Dim mRetVal As Decimal = 0
    Dim mWhere As String = String.Format("Select isnull(Cost,0) Cost from CostBookEntry where CostBookID = (select CostBookID from CostBook where IsDefault=1) and StockItemID = {0}", vStockItemID)

    Try

      mRetVal = Convert.ToDecimal(pDBConn.ExecuteScalar(mWhere))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw


    End Try

    Return mRetVal
  End Function

  Public Function GetDefaultCostBookValueByStockItemIDUnconnected(ByVal vStockItemID As Integer) As Decimal
    Dim mRetVal As Decimal = 0
    Dim mWhere As String = String.Format("Select isnull(Cost,0) Cost from CostBookEntry where CostBookID = (select CostBookID from CostBook where IsDefault=1) and StockItemID = {0}", vStockItemID)

    Try
      If pDBConn.Connect() Then

        mRetVal = Convert.ToDecimal(pDBConn.ExecuteScalar(mWhere))

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function
End Class
