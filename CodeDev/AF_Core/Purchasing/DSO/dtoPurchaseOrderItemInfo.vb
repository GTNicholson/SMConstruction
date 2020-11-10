
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderItemInfo : Inherits dtoBase
  Private pPurchaseOrderItemInfo As clsPurchaseOrderItemInfo



  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwPurchaseOrderItemInfo"
    pKeyFieldName = "PurchaseOrderItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderItemInfo.PurchaseOrderItemID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderItemInfo.PurchaseOrderItem.PurchaseOrderItemID = value
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
      If pPurchaseOrderItemInfo Is Nothing Then SetObjectToNew()
      With pPurchaseOrderItemInfo

        With .PurchaseOrderItem

          .PurchaseOrderItemID = DBReadInt32(rDataReader, "PurchaseOrderItemID")
          .Description = DBReadString(rDataReader, "Description")
          .PartNo = DBReadString(rDataReader, "PartNo")
          .UoM = DBReadInt32(rDataReader, "UoM")
          .StockCode = DBReadString(rDataReader, "StockCode")
          .QtyRequired = DBReadDecimal(rDataReader, "QtyRequired")
          .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")

        End With

        With .PurchaseOrderItemAllocation
          .PurchaseOrderItemAllocationID = DBReadInt32(rDataReader, "PurchaseOrderItemAllocationID")
          .ReceivedQty = DBReadDecimal(rDataReader, "ReceivedQty")

        End With


        With .PurchaseOrder
          .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
          .Category = DBReadByte(rDataReader, "PurchaseCategory")
          .Carriage = DBReadDouble(rDataReader, "Carriage")
          .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
          .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
          .MaterialRequirementTypeID = DBReadInt32(rDataReader, "MaterialRequirementTypeID")
          .RefMatType = DBReadString(rDataReader, "RefMatType")
          .RequiredDate = DBReadDate(rDataReader, "RequiredDate")
          .Status = DBReadByte(rDataReader, "Status")
          .SubmissionDate = DBReadDate(rDataReader, "SubmissionDate")
          .PONum = DBReadString(rDataReader, "PONum")
          .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
        End With

        With .StockItem
          .StockItemID = DBReadInt32(rDataReader, "StockItemID")
          .Category = DBReadByte(rDataReader, "Category")
          .ItemType = DBReadByte(rDataReader, "ItemType")

        End With

        With .SalesOrderPhase
          .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        End With

        With .SalesOrder
          .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
          .ProjectName = DBReadString(rDataReader, "ProjectName")
          .OrderNo = DBReadString(rDataReader, "OrderNo")
        End With

        With .Customer
          .CustomerID = DBReadInt32(rDataReader, "CustomerID")
          .CompanyName = DBReadString(rDataReader, "CompanyName")
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
    pPurchaseOrderItemInfo = New clsPurchaseOrderItemInfo
    Return pPurchaseOrderItemInfo

  End Function


  Public Function LoadPurchaseOrderItemByID(ByRef rPurchaseOrderItemInfo As clsPurchaseOrderItemInfo, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPrimaryKeyID)
    If mOK Then
      rPurchaseOrderItemInfo = pPurchaseOrderItemInfo
    Else
      rPurchaseOrderItemInfo = Nothing
    End If
    pPurchaseOrderItemInfo = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderItemInfoCollectionByWhere(ByRef rPurchaseOrderItemInfos As colPurchaseOrderItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rPurchaseOrderItemInfos, mParams, "PurchaseOrderItemID", vWhere)
    Return mOK
  End Function


End Class


