﻿
''DTO Definition - SalesOrderItem (to SalesOrderItem)'Generated from Table:SalesOrderItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderItem : Inherits dtoBase
  Private pSalesOrderItem As dmSalesOrderItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderItem"
    pKeyFieldName = "SalesOrderItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderItem.SalesOrderItemID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderItem.SalesOrderItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderItem.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderItemID", pSalesOrderItem.SalesOrderItemID)
    End If
    With pSalesOrderItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemNumber", StringToDBValue(.ItemNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPrice", .UnitPrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ImageFile", StringToDBValue(.ImageFile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodFinish", .WoodFinish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodSpecieID", .WoodSpecieID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyInvoiced", .QtyInvoiced)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesItemAssemblyID", .SalesItemAssemblyID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HouseTypeID", .SalesHouseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductTypeID", .ProductTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesItemType", .SalesItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesSubItemType", .SalesSubItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductConstructionType", .ProductConstructionType)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comments", StringToDBValue(.Comments))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", .UoM)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodCost", .WoodCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemCost", .StockItemCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TransportationCost", .TransportationCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ManpowerCost", .ManpowerCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubContractCost", .SubContractCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialCost", .MaterialCost)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatRateCode", .VatRateCode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatValue", .VatValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LineValue", .LineValue)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderItem Is Nothing Then SetObjectToNew()
      With pSalesOrderItem
        .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .ItemNumber = DBReadString(rDataReader, "ItemNumber")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .ImageFile = DBReadString(rDataReader, "ImageFile")
        .WoodFinish = DBReadInt32(rDataReader, "WoodFinish")
        .WoodSpecieID = DBReadInt32(rDataReader, "WoodSpecieID")
        .QtyInvoiced = DBReadInt32(rDataReader, "QtyInvoiced")
        .SalesItemAssemblyID = DBReadInt32(rDataReader, "SalesItemAssemblyID")
        .SalesHouseID = DBReadInt32(rDataReader, "HouseTypeID")
        .ProductTypeID = DBReadByte(rDataReader, "ProductTypeID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .SalesSubItemType = DBReadInt32(rDataReader, "SalesSubItemType")
        .SalesItemType = DBReadInt32(rDataReader, "SalesItemType")
        .ProductConstructionType = DBReadInt32(rDataReader, "ProductConstructionType")
        .Comments = DBReadString(rDataReader, "Comments")
        .UoM = DBReadInt32(rDataReader, "UoM")

        .WoodCost = DBReadDecimal(rDataReader, "WoodCost")
        .StockItemCost = DBReadDecimal(rDataReader, "StockItemCost")
        .TransportationCost = DBReadDecimal(rDataReader, "TransportationCost")
        .ManpowerCost = DBReadDecimal(rDataReader, "ManpowerCost")
        .SubContractCost = DBReadDecimal(rDataReader, "SubContractCost")
        .VatValue = DBReadDecimal(rDataReader, "VatValue")
        .VatRateCode = DBReadInt32(rDataReader, "VatRateCode")
        .LineValue = DBReadDecimal(rDataReader, "LineValue")
        .MaterialCost = DBReadDecimal(rDataReader, "MaterialCost")
        pSalesOrderItem.IsDirty = False
      End With
      mOK = True
    Catch Ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      ' or raise an error ?
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pSalesOrderItem = New dmSalesOrderItem ' Or .NewBlankSalesOrderItem
    Return pSalesOrderItem

  End Function


  Public Function LoadSalesOrderItem(ByRef rSalesOrderItem As dmSalesOrderItem, ByVal vSalesOrderItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderItemID)
    If mOK Then
      rSalesOrderItem = pSalesOrderItem
    Else
      rSalesOrderItem = Nothing
    End If
    pSalesOrderItem = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderItem(ByRef rSalesOrderItem As dmSalesOrderItem) As Boolean
    Dim mOK As Boolean
    pSalesOrderItem = rSalesOrderItem
    mOK = SaveObject()
    pSalesOrderItem = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderItemCollection(ByRef rSalesOrderItems As colSalesOrderItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vParentID)
    mOK = MyBase.LoadCollection(rSalesOrderItems, mParams, "SalesOrderItemID")
    rSalesOrderItems.TrackDeleted = True
    If mOK Then rSalesOrderItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderItemCollection(ByRef rCollection As colSalesOrderItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vParentID)


      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderItem In rCollection.DeletedItems
          If pSalesOrderItem.SalesOrderItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderItem.SalesOrderItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderItem In rCollection
        If pSalesOrderItem.IsDirty Or pSalesOrderItem.SalesOrderID <> vParentID Or pSalesOrderItem.SalesOrderItemID = 0 Then 'Or pSalesOrderItem.SalesOrderItemID = 0
          pSalesOrderItem.SalesOrderID = vParentID
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

End Class