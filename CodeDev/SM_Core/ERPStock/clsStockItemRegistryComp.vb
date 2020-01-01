﻿Imports SM_Core

Public Class clsStockItemRegistryComp : Inherits clsStockItemRegistryBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Overrides Sub LoadInitial()
    Dim mdto As intdtoStockItem
    Dim mParams As New Hashtable
    mdto = CreateDtoStockItem()
    mdto.LoadStockItemsDictByParams(pStockItemsDict, mParams)
  End Sub



  Public Overrides Function CreateDtoStockItem() As intdtoStockItem
    Dim mRetVal As intdtoStockItem
    mRetVal = New dtoStockItem(pDBConn)
    Return mRetVal
  End Function
End Class
