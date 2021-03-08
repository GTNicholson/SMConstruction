Imports RTIS.CommonVB

Public Class fccHomeManagement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPurchaseOrderItemAllocationInfos As colPODeliveryItemInfos
  Private pWoodPalletItemInfos As colWoodPalletItemInfos
  Private pStockItemInfos As colStockItemInfos
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

  Public ReadOnly Property WoodPalletItemInfos As colWoodPalletItemInfos
    Get
      Return pWoodPalletItemInfos
    End Get
  End Property


  Public ReadOnly Property PODeliveryItemInfos As colPODeliveryItemInfos
    Get
      Return pPurchaseOrderItemAllocationInfos
    End Get
  End Property

  Public ReadOnly Property StockItemInfos As colStockItemInfos
    Get
      Return pStockItemInfos
    End Get
  End Property


  Public Sub LoadWoodPalletItemInfos()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mwhere As String = ""
    Try


      pWoodPalletItemInfos = New colWoodPalletItemInfos
      mdsoStock.LoadWoodPalletItemInfosByStockItemID(pWoodPalletItemInfos, "")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub LoadPODeliveryItemInfos()
    Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
    Dim mStartDate As Date
    Dim mEndDate As Date


    mStartDate = New Date(Now.Year, Now.Month, 1)
    mEndDate = Now

    Dim mwhere As String = String.Format("DateCreated between '{0}' and '{1}' and GRNumber <> ''", mStartDate.ToShortDateString, mEndDate.ToShortDateString)

    Try


      pPurchaseOrderItemAllocationInfos = New colPODeliveryItemInfos
      mdsoPurchasing.LoadPODeliveryItemInfoByWhere(pPurchaseOrderItemAllocationInfos, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub LoadStockItemInfos()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mwhere As String = String.Format("Category <> {0} and IsCostingOnly=0 or IsCostingOnly is null", CInt(eStockItemCategory.Timber))
    Try


      pStockItemInfos = New colStockItemInfos
      mdsoStock.LoadStockItemInfos(pStockItemInfos, mwhere, dtoStockItemInfo.eMode.StockItemInfos)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub
End Class
