Imports RTIS.CommonVB

Public Class fccStockItemInfos
  Private pPrimaryKeyID As Integer

  Private pStockItemInfos As colStockItemInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pCategorys As Int32
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentStockItemInfo As clsStockItemInfo
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pStockItemInfos = New colStockItemInfos
    pRTISGlobal = rRTISGlobal

  End Sub

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

    pStockItemInfos.Clear()


    mdso = New dsoStock(pDBConn)
    mdso.LoadStockItemInfos(pStockItemInfos, "")


  End Sub


  Public Sub LoadStockItemExtraDetails()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Try
      If pCurrentStockItemInfo IsNot Nothing Then
        Dim mSI As dmStockItem
        mSI = pCurrentStockItemInfo.StockItem
        mdsoStock.LoadStockItem(mSI, pCurrentStockItemInfo.StockItemID)
        mSI.tmpIsFullyLoadedDown = True
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

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
        Select Case vTransactionType
          Case eTransactionType.Adjustment
            mdsoStockTran.AdjustmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, "", 0)
          Case eTransactionType.Amendment
            mdsoStockTran.AmendmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment)
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

End Class
