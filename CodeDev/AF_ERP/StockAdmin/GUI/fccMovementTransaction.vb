﻿Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccMovementTransaction
  Private pDBConn As clsDBConnBase
  Private pStockItem As dmStockItem
  Private pWoodPallet As dmWoodPallet

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property WoodPallet As dmWoodPallet
    Get
      Return pWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pWoodPallet = value
    End Set
  End Property

  Public Sub New()
    pStockItem = New dmStockItem
  End Sub


  Public Sub ApplyWoodPalletMovement(ByVal vLocationID As Byte, ByVal vAdjustDate As DateTime)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Try

      Dim mtmpSO As New dmSalesOrder
      mdsoStockTran.MoveWoodPallet(pWoodPallet, vLocationID, mtmpSO, vAdjustDate, eCurrency.Dollar, 1)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class