Imports RTIS.DataLayer
Imports RTIS.CommonVB
Public Class fccStockItemPurchasing

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pStockItems As colStockItemProcessors
  Private pSuppliers As colSuppliers
  Private pCurrentCategory As Integer
  Private pStockItemLocations As colStockItemLocations
  Private pStockItemProcessors As colStockItemProcessors
  Private pWoodMatReqs As colMaterialRequirementInfos
  Private pPOCOItemAllocationInfos As colPurchaseOrderInfos
  Public ProjectID As Integer
  Public IsBulkOrdering As Boolean

  Public ReadOnly Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public ReadOnly Property WoodMatReqs As colMaterialRequirementInfos
    Get
      Return pWoodMatReqs
    End Get
  End Property


  Public ReadOnly Property StockItemProcessors As colStockItemProcessors
    Get
      Return pStockItemProcessors
    End Get
  End Property


  Public Property CurrentCategory As Integer
    Get
      Return pCurrentCategory
    End Get
    Set(value As Integer)
      pCurrentCategory = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pStockItemProcessors = New colStockItemProcessors
    pWoodMatReqs = New colMaterialRequirementInfos
  End Sub

  Public Sub LoadObject()
    pCurrentCategory = 0
    pStockItemLocations = New colStockItemLocations
    pStockItemProcessors = New colStockItemProcessors
    pPOCOItemAllocationInfos = New colPurchaseOrderInfos
    pWoodMatReqs = New colMaterialRequirementInfos
    pSuppliers = New colSuppliers

  End Sub

  Public Sub LoadStockItems()
    Dim mdsoStock As New dsoStock(pDBConn)

    Dim mWhere As String = ""
    Dim mOK As Boolean
    Try

      pStockItemProcessors.Clear()

      mdsoStock.LoadStockItemProcessors(pStockItemProcessors, mWhere, dtoStockItemInfo.eMode.StockItemProcessor)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub


  Public Sub LoadWoodMatReq()
    Dim mdsoStock As New dsoStock(pDBConn)

    Dim mWhere As String = ""
    Dim mOK As Boolean
    Try

      pWoodMatReqs.Clear()

      mdsoStock.LoadWoodMaterialRequirementInfosByWhere(pWoodMatReqs, mWhere, dtoMaterialRequirementInfo.eMode.WoodMat)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

  Public Sub SaveObject()
    Try



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



End Class
