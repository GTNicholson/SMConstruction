Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoStock
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Sub LoadStockItem(ByRef rStockItem As dmStockItem, ByVal vStockItemID As Integer)

  End Sub

  Public Sub LoadStockItemsByWhere(ByRef rStockItems As colStockItems, ByVal vWhere As String)
    Dim mdto As dtoStockItem
    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mdto.LoadStockItemsByWhere(rStockItems, vWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function SaveStockItem(ByRef rStockItem As dmStockItem) As Boolean
    Dim mdto As dtoStockItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mOK = mdto.SaveStockItem(rStockItem)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadStockTakeDown(ByRef rStockTake As dmStockTake, ByVal vStockTakeID As Integer) As Boolean
    Dim mdto As dtoStockTake
    Dim mdtoSTI As dtoStockTakeItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockTake(pDBConn)
      mOK = mdto.LoadStockTake(rStockTake, vStockTakeID)
      mdtoSTI = New dtoStockTakeItem(pDBConn)
      If mOK Then mOK = mdtoSTI.LoadStockTakeItemCollection(rStockTake.StockTakeItems, rStockTake.StockTakeID)

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function


  Public Function SaveStockTakeDown(ByRef rStockTake As dmStockTake) As Boolean
    Dim mdto As dtoStockTake
    Dim mdtoSTI As dtoStockTakeItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockTake(pDBConn)
      mOK = mdto.SaveStockTake(rStockTake)
      mdtoSTI = New dtoStockTakeItem(pDBConn)
      If mOK Then mOK = mdtoSTI.SaveStockTakeItemCollection(rStockTake.StockTakeItems, rStockTake.StockTakeID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadStockItemLocationsByStockItemID(ByRef rStockItemLocations As colStockItemLocations, ByVal vStockItemID As Integer) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then

        mOK = mdtoSILocation.LoadStockItemLocationCollectionByStockItemID(rStockItemLocations, vStockItemID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetStockItemLocationByStockItemIDLocationID(ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As dmStockItemLocation
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mRetVal As dmStockItemLocation = Nothing

    Try
      If pDBConn.Connect() Then
        mRetVal = mdtoSILocation.LoadStockItemLocationByStockItemIDLocationID(vStockItemID, vLocationID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SaveStockItemLocation(ByRef rStockItemLocation As dmStockItemLocation) As Boolean
    Dim mdto As dtoStockItemLocation
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockItemLocation(pDBConn)
      mOK = mdto.SaveStockItemLocation(rStockItemLocation)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function
End Class
