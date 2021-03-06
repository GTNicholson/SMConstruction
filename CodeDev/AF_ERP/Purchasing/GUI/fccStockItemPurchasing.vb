﻿Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.DoorsetCore
Imports DatimCore

Public Class fccStockItemPurchasing

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pStockItems As colStockItemProcessors
  Private pSuppliers As colSuppliers
  Private pCurrentCategory As Integer
  Private pStockItemLocations As colStockItemLocations
  Private pStockItemProcessors As colStockItemProcessors
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
  End Sub

  Public Sub LoadObject()
    pCurrentCategory = 0
    pStockItemLocations = New colStockItemLocations
    pStockItemProcessors = New colStockItemProcessors
    pPOCOItemAllocationInfos = New colPurchaseOrderInfos
    pSuppliers = New colSuppliers

  End Sub

  Public Sub LoadStockItems(rValueItem As Int32)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mWhere As String = ""
    Dim mOK As Boolean
    Try

      pStockItemProcessors.Clear()


      mWhere = "( Category = " & rValueItem & ")"

      mdsoStock.LoadStockItemProcessors(pStockItemProcessors, mWhere, dtoStockItemInfo.eMode.StockItemProcessor)



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub



  Public Sub LoadMatReqInfos(ByRef rMaterialRequirementsInfos As colMaterialRequirementInfos, ByVal vStockItemID As Integer)
    Dim mdso As dsoStock
    Dim mWhere As String

    mdso = New dsoStock(pDBConn)
    mWhere = String.Format("StockItemID = {0}", vStockItemID)

    mdso.LoadMaterialRequirementInfosByWhere(rMaterialRequirementsInfos, mWhere, dtoMaterialRequirementInfo.eMode.Info)


  End Sub

  Public Sub LoadPurchaseOrderItemAllocationInfos(ByRef rPOIAInfos As colPurchaseOrderItemAllocationInfos, ByVal vStockItemID As Integer)
    Dim mdso As dsoPurchasing

    mdso = New dsoPurchasing(pDBConn)
    mdso.LoadPurchaseOrderItemAllocationInfos(rPOIAInfos, "StockItemID = " & vStockItemID)



  End Sub

End Class
