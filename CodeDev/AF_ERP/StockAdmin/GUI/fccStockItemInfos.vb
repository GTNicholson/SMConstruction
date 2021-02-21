Imports RTIS.CommonVB

Public Class fccStockItemInfos
  Private pPrimaryKeyID As Integer

  Private pStockItemInfos As colStockItemInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pCategorys As Int32
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentStockItemInfo As clsStockItemInfo
  Private pIsWood As Boolean
  Private pCostBookID As Integer


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsWood As Boolean)
    pDBConn = rDBConn
    pStockItemInfos = New colStockItemInfos
    pRTISGlobal = rRTISGlobal
    pIsWood = vIsWood
  End Sub

  Public Property CostBookID As Integer
    Get
      Return pCostBookID
    End Get
    Set(value As Integer)
      pCostBookID = value
    End Set
  End Property
  Public Property IsWood As Boolean
    Get
      Return pIsWood
    End Get
    Set(value As Boolean)
      pIsWood = value
    End Set
  End Property
  Public Property CurrentStockItemInfo As clsStockItemInfo
    Get
      Return pCurrentStockItemInfo
    End Get
    Set(value As clsStockItemInfo)
      pCurrentStockItemInfo = value
    End Set
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property


  Public ReadOnly Property StockItemInfos As colStockItemInfos
    Get
      Return pStockItemInfos
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoStock
    Dim mWhere As String = ""
    Dim mdsoCosting As dsoCostBook
    pStockItemInfos.Clear()
    mdso = New dsoStock(pDBConn)

    If pIsWood Then
      mdsoCosting = New dsoCostBook(pDBConn)
      mWhere = "Category = " & eStockItemCategory.Timber
      mdso.LoadStockItemInfos(pStockItemInfos, mWhere, dtoStockItemInfo.eMode.WoodStockInfo)

    Else
      mWhere = "Category <>" & eStockItemCategory.Timber
      mdso.LoadStockItemInfos(pStockItemInfos, mWhere, dtoStockItemInfo.eMode.StockItemInfos)

    End If



  End Sub


  Public Sub LoadStockItemExtraDetails()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Try
      If pCurrentStockItemInfo IsNot Nothing Then
        Dim mSI As dmStockItem
        mSI = pCurrentStockItemInfo.StockItem
        'mdsoStock.LoadStockItem(mSI, pCurrentStockItemInfo.StockItemID)
        mSI.tmpIsFullyLoadedDown = True
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

  Public Function GetCostByStockItemIDM(ByVal vStockItemID As Integer) As Decimal
    Dim mRetVal As Decimal = 0
    Dim mdso As New dsoCostBook(pDBConn)

    mRetVal = mdso.GetDefaultCostBookValueByStockItemIDUnconnected(vStockItemID)


    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub


  Public Sub ApplyStockAdjust(ByVal vStockItem As dmStockItem, ByVal vLocationID As Byte, ByVal vTransactionType As eTransactionType, ByVal vTranQty As Decimal, ByVal vAdjustDate As DateTime, ByVal vNotes As String)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mStockItemLocation As dmStockItemLocation
    Dim mExchangeRate As Decimal = 0
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mUnitCost As Decimal = 0
    Try

      mStockItemLocation = mdsoStock.GetOrCreateStockItemLocation(vStockItem.StockItemID, vLocationID)

      If mStockItemLocation IsNot Nothing Then
        Dim mLocationAmendment As New dmStockItemLocationAmendmentLog

        With mLocationAmendment
          .SystemDate = DateTime.Now
          .AmendmentDate = vAdjustDate
          .ChangeDetails = vNotes
          .UserID = pDBConn.RTISUser.UserID
          .StockItemLocationID = mStockItemLocation.StockItemLocationID
        End With

        ''If mdsoStock.SaveStockItemLocationAmendmentLog(mLocationAmendment) Then

        mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, eCurrency.Cordobas)

        ''//Avoid any error
        If mExchangeRate = 0 Then
          mExchangeRate = 1
        End If

        If vStockItem.AverageCost = 0 Then
          mUnitCost = vStockItem.StdCost
        Else
          mUnitCost = vStockItem.AverageCost
        End If

        Select Case vTransactionType
          Case eTransactionType.Adjustment
            mdsoStockTran.AdjustmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Cordobas, mUnitCost, mExchangeRate)
          Case eTransactionType.Amendment
            mdsoStockTran.AmendmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Cordobas, mUnitCost, mExchangeRate)
        End Select

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RefreshStockItemCurrentInventory(ByRef rStockItemInfo As clsStockItemInfo)
    Dim mDso As dsoStock
    Dim mCurrentLevel As Decimal

    Try

      mDso = New dsoStock(pDBConn)
      mCurrentLevel = mDso.GetCurrentInventory(rStockItemInfo.StockItem.StockItemID)
      rStockItemInfo.CurrentInventory = mCurrentLevel
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub LoadPurchaseOrderItemAllocationInfos(ByRef rPOIAInfos As colPurchaseOrderItemAllocationInfo, ByVal vStockItemID As Integer)
    Dim mdso As dsoPurchasing
    Dim mWhere As String = "StockItemID = " & vStockItemID

    mWhere &= " and POStatus <>" & ePurchaseOrderDueDateStatus.Cancelled
    mdso = New dsoPurchasing(pDBConn)
    mdso.LoadPurchaseOrderItemAllocationInfos(rPOIAInfos, mWhere)



  End Sub

  Public Sub LoadMaterialRequirementInfos(ByRef rMatReqInfos As colMaterialRequirementInfos, ByVal vStockItemID As Integer)
    Dim mdso As dsoStock
    Dim mWhere As String = "StockItemID = " & vStockItemID & " and OSQty<>0"
    mdso = New dsoStock(pDBConn)
    mdso.LoadWoodMaterialRequirementInfosByWhere(rMatReqInfos, mWhere, dtoMaterialRequirementInfo.eMode.Info)

  End Sub

  Public Sub LoadWoodPalletItemInfosByStockItemID(ByRef rWoodPalletItemInfos As colWoodPalletItemInfos, ByVal vStockItemID As Integer, ByVal vWoodPalletID As Integer)
    Dim mdso As dsoStock
    Dim mWhere As String = "StockItemID = " & vStockItemID & " and Quantity<>0 and locationID<>0 and WoodPalletID = " & vWoodPalletID
    mdso = New dsoStock(pDBConn)
    mdso.LoadWoodPalletItemInfosByStockItemID(rWoodPalletItemInfos, mWhere)
  End Sub

  Public Function LoadWoodPalletItemContentByWhere(ByRef rWoodPalletItemContents As colWoodPalletItemContents, ByVal vWhere As String) As Boolean
    Dim mdso As dsoStock
    Dim mOK As Boolean = False

    mdso = New dsoStock(pDBConn)
    mOK = mdso.LoadWoodPalletItemContentByWhere(rWoodPalletItemContents, vWhere)
    Return mOK
  End Function

End Class
