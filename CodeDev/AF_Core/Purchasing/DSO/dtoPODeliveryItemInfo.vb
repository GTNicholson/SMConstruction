
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPODeliveryItemInfo : Inherits dtoBase
  Private pPODeliveryItemInfo As clsPODeliveryItemInfo



  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwPODeliveryItemInfo"
    pKeyFieldName = "PODeliveryItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPODeliveryItemInfo.PODeliveryItemID
    End Get
    Set(ByVal value As Integer)
      pPODeliveryItemInfo.PODelivery.PODeliveryID = value
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
      If pPODeliveryItemInfo Is Nothing Then SetObjectToNew()
      With pPODeliveryItemInfo

        With .PODeliveryItem

          .PODeliveryItemID = DBReadInt32(rDataReader, "PODeliveryItemID")
          .QtyReceived = DBReadDecimal(rDataReader, "QtyReceived")
        End With

        With .PurchaseOrderItem

          .Description = DBReadString(rDataReader, "Description")
          .PartNo = DBReadString(rDataReader, "PartNo")
          .StockCode = DBReadString(rDataReader, "StockCode")
          .QtyRequired = DBReadDecimal(rDataReader, "QtyRequired")
          .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")

        End With

        With .PODelivery

          .GRNumber = DBReadString(rDataReader, "GRNumber")
          .DateCreated = DBReadDate(rDataReader, "DateCreated")

        End With

        With .PurchaseOrder
          .PONum = DBReadString(rDataReader, "PONum")
          .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
          .Category = DBReadByte(rDataReader, "Category")
          .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
          .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
          .RefMatType = DBReadString(rDataReader, "RefMatType")
        End With

        With .StockItem
          .Category = DBReadByte(rDataReader, "StockItemCategory")
          .ItemType = DBReadByte(rDataReader, "ItemType")

        End With

        With .SalesOrderPhase
          .JobNo = DBReadString(rDataReader, "JobNo")
        End With

        With .SalesOrder
          .ProjectName = DBReadString(rDataReader, "ProjectName")
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
    pPODeliveryItemInfo = New clsPODeliveryItemInfo
    Return pPODeliveryItemInfo

  End Function


  Public Function LoadPODeliveryItemInfoByID(ByRef rPODeliveryItemInfo As clsPODeliveryItemInfo, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPrimaryKeyID)
    If mOK Then
      rPODeliveryItemInfo = pPODeliveryItemInfo
    Else
      rPODeliveryItemInfo = Nothing
    End If
    pPODeliveryItemInfo = Nothing
    Return mOK
  End Function


  Public Function LoadPODeliveryItemInfoCollectionByWhere(ByRef rPODeliveryItemInfos As colPODeliveryItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rPODeliveryItemInfos, mParams, "PODeliveryItemID", vWhere)
    Return mOK
  End Function


End Class


