Imports RTIS.CommonVB

Public Class fccMaintenanceMaterialRequirement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pMatReqItemProcessors As colMaintenanceMaterialRequirementProcessors
  Private pStockItemRegister As colStockItems
  Private pOptionView As eMatReqOptionView
  Public Property pConsoleOptionView As ePOConsoleOption


  Public Enum eMatReqOptionView
    Hide = 0
    Show = 1
    LiveOTs = 2
  End Enum

  Public Property OptionView As eMatReqOptionView
    Get
      Return pOptionView
    End Get
    Set(value As eMatReqOptionView)
      pOptionView = value
    End Set
  End Property

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property



  Public Property MatReqItemProcessors As colMaintenanceMaterialRequirementProcessors
    Get
      Return pMatReqItemProcessors
    End Get
    Set(value As colMaintenanceMaterialRequirementProcessors)
      pMatReqItemProcessors = value
    End Set
  End Property

  Public ReadOnly Property StockItemRegister As colStockItems
    Get
      Return pStockItemRegister
    End Get
  End Property


  Public Sub LoadMatReqs()
    Dim mWhere As String = String.Empty
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Dim mMaintenanceMaterialRequirementInfos As New colMaintenanceMaterialRequirementInfos
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mStockItemIDs As New List(Of Integer)
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemTransactions As New colStockItemTransactionLogs
    Dim mRemove As Boolean
    Dim mShowOTs As Boolean = False
    Try

      pMatReqItemProcessors = New colMaintenanceMaterialRequirementProcessors
      pStockItemRegister = New colStockItems

      mWhere &= " IsNull(Status,1) = " & eMaintenanceWorkOrderStatus.InProgress

      mdsoPurchaseOrder.LoadMaintenanceItemProcessorByWhere(pMatReqItemProcessors, mWhere)



      For Each mMatReqProc As clsMaintenanceMaterialRequirementProcessor In pMatReqItemProcessors

        If mMatReqProc.StockItem.StockItemID <> 0 AndAlso mStockItemIDs.Contains(mMatReqProc.StockItem.StockItemID) = False AndAlso pStockItemRegister.ItemFromKey(mMatReqProc.StockItem.StockItemID) Is Nothing Then
          mStockItemIDs.Add(mMatReqProc.StockItem.StockItemID)
        End If

      Next

      If pDBConn.IsConnected Then
        pDBConn.Disconnect()
      End If


      For mIndex As Integer = pMatReqItemProcessors.Count - 1 To 0 Step -1
        mRemove = False
        Dim mMatReqProc As clsMaintenanceMaterialRequirementProcessor = pMatReqItemProcessors(mIndex)

        ''//Remove as per mode option
        Select Case pOptionView
          Case eMatReqOptionView.Hide
            If mRemove = False Then
              If ((mMatReqProc.CurrentOrderQty + mMatReqProc.FromStockQty) >= mMatReqProc.TotalOTQuantity) Then 'mMatReqProc.Quantity) Then
                mRemove = True
                mShowOTs = False
              End If
            End If

          Case eMatReqOptionView.LiveOTs
            mShowOTs = True

        End Select


        If mRemove = False Then
          If mMatReqProc.MaterialRequirement.Quantity = 0 And mMatReqProc.MaterialRequirement.PickedQty = 0 And mMatReqProc.FromStockQty = 0 And mMatReqProc.OrderedQty = 0 Then
            mRemove = True
          End If
        End If

        If mRemove = False And mShowOTs = False Then

          If mMatReqProc.MaterialRequirement.PickedQty >= mMatReqProc.MaterialRequirement.FromStockQty Then
            If (mMatReqProc.MaterialRequirement.PickedQty - mMatReqProc.MaterialRequirement.ReturnQty) >= mMatReqProc.MaterialRequirement.Quantity Then
              mRemove = True
            End If
          Else
            If (mMatReqProc.MaterialRequirement.FromStockQty - mMatReqProc.MaterialRequirement.ReturnQty) >= mMatReqProc.MaterialRequirement.Quantity Then
              mRemove = True
            End If
          End If



        End If


        If mRemove = True Then
          pMatReqItemProcessors.RemoveAt(mIndex)
        End If

      Next


      If mStockItemIDs.Count > 0 Then
        mdsoStock.LoadStockItemsByWhere(pStockItemRegister, "StockItemID IN (" & String.Join(",", mStockItemIDs.ToArray) & ")")
        mdsoStock.LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID IN (" & String.Join(",", mStockItemIDs.ToArray) & ")")
      End If

      For Each mMRP As clsMaintenanceMaterialRequirementProcessor In pMatReqItemProcessors
        mMRP.StockItem = pStockItemRegister.ItemFromKey(mMRP.StockItem.StockItemID)
        mMRP.StockItemLocations = mStockItemLocations.ItemsFromStockItemID(mMRP.StockItem.StockItemID)
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function UpdateMaterialRequirementFromStockQty(ByVal vMatReq As dmMaterialRequirement) As Boolean
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mOK As Boolean
    Try
      mOK = mdsoSalesOrder.UpdateMaterialRequirementFromStockQty(vMatReq)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function

  Public Function ProcessFromStock() As Integer
    Dim mCount As Integer = 0

    Try

      For Each mMRProcessor As clsMaintenanceMaterialRequirementProcessor In pMatReqItemProcessors

        If mMRProcessor.FromStock <> 0 Then
          mMRProcessor.MaterialRequirement.FromStockQty += mMRProcessor.FromStock
          mMRProcessor.FromStock = 0

          If UpdateMaterialRequirementFromStockQty(mMRProcessor.MaterialRequirement) Then
            mCount += 1
          End If
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mCount
  End Function

  Public Sub SetQtyFromStock(rMatReqItemProcessor As clsMaintenanceMaterialRequirementProcessor)
    rMatReqItemProcessor.ToOrder = 0
    rMatReqItemProcessor.FromStock = Math.Max(0.0, rMatReqItemProcessor.Quantity - rMatReqItemProcessor.OrderedQty - rMatReqItemProcessor.MaterialRequirement.FromStockQty)
  End Sub

  Public Sub ClearMatReqProcs()
    For Each mMatReqProc As clsMaintenanceMaterialRequirementProcessor In pMatReqItemProcessors
      mMatReqProc.ToOrder = 0
      mMatReqProc.FromStock = 0
    Next
  End Sub

  Public Sub SetBalQtyToOrder(ByRef rMatReqItemProcessor As clsMaintenanceMaterialRequirementProcessor)
    rMatReqItemProcessor.ToOrder = Math.Max(0.0, rMatReqItemProcessor.Quantity - rMatReqItemProcessor.OrderedQty - rMatReqItemProcessor.FromStock)
  End Sub

  Public Sub LoadTransactions(ByVal vMatReqProc As clsMaintenanceMaterialRequirementProcessor)
    Dim mWhere As String
    Dim mdsoStock As New dsoStockTransactions(pDBConn)
    Try

      mWhere = String.Format("RefObjectType = {0}  AND RefObjectID ={1}", CInt(eObjectType.MaterialRequirement), vMatReqProc.MaterialRequirement.MaterialRequirementID)
      mWhere &= " and SalesOrderPhaseID = " & vMatReqProc.SalesOrderPhaseID & " AND StockItemID = " & vMatReqProc.StockItem.StockItemID

      mdsoStock.LoadStockItemTransactionsByWhere(vMatReqProc.StockItemTransactionInfoss, mWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub UpdateMaterialRequirementValidatedFromStock(ByVal vCheckedValue As Boolean, ByVal vMaterialRequirementID As Integer)

    Dim mWhere As String

    Try

      pDBConn.Connect()

      mWhere = "Update MaterialRequirement set IsFromStockValidated=" & CInt(vCheckedValue) & " where MaterialRequirementID = " & vMaterialRequirementID

      pDBConn.ExecuteNonQuery(mWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
End Class
