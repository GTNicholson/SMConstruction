Imports RTIS.CommonVB

Public Class fccSalesOrderProgress
  Private pPrimaryKeyID As Integer

  Private pSalesOrderProgressInfos As colSalesOrderProgressInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pSalesOrderProgressInfos = New colSalesOrderProgressInfos
    pRTISGlobal = rRTISGlobal

  End Sub


  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property


  Public ReadOnly Property SalesOrderProgressInfos As colSalesOrderProgressInfos
    Get
      Return pSalesOrderProgressInfos
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSales

    pSalesOrderProgressInfos.Clear()


    mdso = New dsoSales(pDBConn)
    mdso.LoadSalesOrderProgressInfos(pSalesOrderProgressInfos, "")


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
