Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoStock
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function GetOrCreateStockItemLocation(ByVal vStockItemID As Integer, vLocationID As Integer) As dmStockItemLocation
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemLocation As dmStockItemLocation = Nothing

    LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID =" & vStockItemID & " AND LocationID =" & vLocationID)

    If mStockItemLocations.Count > 0 Then
      mStockItemLocation = mStockItemLocations(0)
    Else
      mStockItemLocation = New dmStockItemLocation
      mStockItemLocation.StockItemID = vStockItemID
      mStockItemLocation.LocationID = vLocationID
      mStockItemLocations.Add(mStockItemLocation)
      SaveStockItemLocations(mStockItemLocations)
    End If
    Return mStockItemLocation
  End Function

  Public Sub LoadStockItem(ByRef rStockItem As dmStockItem, ByVal vStockItemID As Integer)

  End Sub

  Public Function LoadStockItemProcessors(ByRef rStockItemProcessors As colStockItemProcessors, ByVal vWhere As String, ByVal vMode As dtoStockItemInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoStockItemInfo


    Try

      pDBConn.Connect()
      mdto = New dtoStockItemInfo(pDBConn, vMode)
      mdto.LoadStockItemProcessorCollection(rStockItemProcessors, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

  Public Function LoadWoodMaterialRequirementInfosByWhere(ByRef rWoodMatReq As colMaterialRequirementInfos, ByVal vWhere As String, ByVal vMode As dtoMaterialRequirementInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoMaterialRequirementInfo


    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(pDBConn, vMode)
      mdto.LoadWoodMatReqByWhere(rWoodMatReq, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

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

  Public Function GetNextStockCodeSuffixNo(ByVal vStockCodeStem As String) As Integer
    Dim mRetVal As Integer

    Try

      pDBConn.Connect()
      mRetVal = GetNextStockCodeSuffixNoConnected(vStockCodeStem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetNextStockCodeSuffixNoConnected(ByVal vStockCodeStem As String) As Integer
    Dim mReader As IDataReader
    Dim mSQL As String
    Dim mRetVal As Integer
    Dim mExistingCode As String
    Dim mLastDotPos As Integer
    Try


      mSQL = "Select Top 1 StockCode from StockItem where StockCode Like '" & vStockCodeStem & "%' Order By StockCode Desc"
      mReader = pDBConn.LoadReader(mSQL)
      If mReader.Read Then
        mExistingCode = RTIS.DataLayer.clsDBConnBase.DBReadString(mReader, "StockCode")
        mLastDotPos = mExistingCode.LastIndexOf(".")
        If mLastDotPos <> -1 And mExistingCode.Length >= mLastDotPos + 1 Then
          mRetVal = Val(mExistingCode.Substring(mLastDotPos + 1)) + 1
        Else
          '// invalid code
          mRetVal = -1
        End If
      Else
        mRetVal = 1
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mReader IsNot Nothing Then
        If mReader.IsClosed = False Then mReader.Close()
        mReader.Dispose()
        mReader = Nothing
      End If
    End Try
    Return mRetVal
  End Function

  Public Function LoadStockItemInfos(ByRef rStockItemInfos As colStockItemInfos, ByVal vWhere As String, ByVal vMode As dtoStockItemInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoStockItemInfo


    Try

      pDBConn.Connect()
      mdto = New dtoStockItemInfo(pDBConn, vMode)
      mdto.LoadStockItemCollection(rStockItemInfos, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

  Public Function LoadStockItemLocationsByWhere(ByVal vStockItemLocations As colStockItemLocations, ByVal vWhere As String) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = mdtoSILocation.LoadStockItemLocationCollectionByWhere(vStockItemLocations, vWhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mOK
  End Function

  Public Function SaveStockItemLocations(ByVal vSILocations As colStockItemLocations) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = mdtoSILocation.SaveStockItemLocationCollection(vSILocations)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetCurrentInventory(ByVal vStockItemID As Integer) As Decimal
    Dim mSQL As String
    Dim mRetVal As Decimal = 0
    Try
      pDBConn.Connect()
      mSQL = "Select Sum(Qty) from StockItemLocation Where StockItemID = " & vStockItemID
      mRetVal = pDBConn.ExecuteScalar(mSQL)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetOrCreateStockItemLocationConnected(ByVal vStockItemID As Integer, vLocationID As Integer, ByVal vBatchID As Integer) As dmStockItemLocation
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemLocation As dmStockItemLocation = Nothing
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    mOK = mdtoSILocation.LoadStockItemLocationCollectionByWhere(mStockItemLocations, "StockItemID =" & vStockItemID & " AND LocationID =" & vLocationID & " AND BatchID =" & vBatchID)


    If mStockItemLocations.Count > 0 Then
      mStockItemLocation = mStockItemLocations(0)
    Else
      mStockItemLocation = New dmStockItemLocation
      mStockItemLocation.StockItemID = vStockItemID
      mStockItemLocation.LocationID = vLocationID

      ''mStockItemLocation.BatchID = vBatchID

      mStockItemLocations.Add(mStockItemLocation)
      mOK = mdtoSILocation.SaveStockItemLocationCollection(mStockItemLocations)
    End If
    Return mStockItemLocation
  End Function
End Class
