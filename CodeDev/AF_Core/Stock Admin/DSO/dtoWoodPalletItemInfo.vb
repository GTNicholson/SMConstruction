
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodPalletItemInfo : Inherits dtoBase
  Private pWoodPalletItemInfo As clsWoodPalletItemInfo



  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwWoodPalletItemInfo"
    pKeyFieldName = "WoodPalletItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodPalletItemInfo.WoodPalletItem.WoodPalletItemID
    End Get
    Set(ByVal value As Integer)
      pWoodPalletItemInfo.WoodPalletItem.WoodPalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      Return False
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)



  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodPalletItemInfo Is Nothing Then SetObjectToNew()
      With pWoodPalletItemInfo

        With .WoodPalletItem

          .WoodPalletItemID = DBReadInt32(rDataReader, "WoodPalletItemID")
          .Width = DBReadDecimal(rDataReader, "Width")
          .Length = DBReadDecimal(rDataReader, "Length")
          .Quantity = DBReadDecimal(rDataReader, "Quantity")
          .QuantityUsed = DBReadDecimal(rDataReader, "QuantityUsed")
          .OutstandingQty = DBReadDecimal(rDataReader, "OutstandingQty")
        End With

        With .WoodPallet
          .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
          .PalletRef = DBReadString(rDataReader, "PalletRef")
          .RefPalletOutside = DBReadString(rDataReader, "RefPalletOutside")
          .CreatedDate = DBReadDate(rDataReader, "CreatedDate")
          .LocationID = DBReadInt32(rDataReader, "LocationID")


        End With

        With .StockItem
          .StockItemID = DBReadInt32(rDataReader, "StockItemID")
          .StockCode = DBReadString(rDataReader, "StockCode")
          .Description = DBReadString(rDataReader, "Description")

          .Category = DBReadByte(rDataReader, "Category")
          .ItemType = DBReadByte(rDataReader, "ItemType")
          .Thickness = DBReadDecimal(rDataReader, "Thickness")
          .Species = DBReadInt32(rDataReader, "Species")
        End With


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
    pWoodPalletItemInfo = New clsWoodPalletItemInfo
    Return pWoodPalletItemInfo

  End Function


  Public Function LoadPODeliveryItemInfoByID(ByRef rWoodPalletItemInfo As clsWoodPalletItemInfo, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPrimaryKeyID)
    If mOK Then
      rWoodPalletItemInfo = pWoodPalletItemInfo
    Else
      rWoodPalletItemInfo = Nothing
    End If
    pWoodPalletItemInfo = Nothing
    Return mOK
  End Function


  Public Function LoadWoodPalletItemInfoCollectionByWhere(ByRef rWoodPalletItemInfos As colWoodPalletItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWoodPalletItemInfos, mParams, "WoodPalletItemID", vWhere)
    Return mOK
  End Function


End Class


