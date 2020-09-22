
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderInfo : Inherits dtoBase
  Private pPurchaseOrderInfo As clsPurchaseOrderInfo
  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
  End Enum

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub
  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    SetTableDetails()
    pMode = vMode
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwPurchaseOrder"
    pKeyFieldName = "PurchaseOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderInfo.PurchaseOrderID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderInfo.PurchaseOrder.PurchaseOrderID = value
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
      If pPurchaseOrderInfo Is Nothing Then SetObjectToNew()
      With pPurchaseOrderInfo

        .SupplierContactName = DBReadString(rDataReader, "SupplierContactName")
        .BuyerName = DBReadString(rDataReader, "BuyerName")

        With .PurchaseOrder
          .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
          .PONum = DBReadString(rDataReader, "PONum")
          .SupplierContactTel = DBReadString(rDataReader, "SupplierContactTel")
          .Category = DBReadByte(rDataReader, "Category")
          .SubmissionDate = DBReadDateTime(rDataReader, "SubmissionDate")
          .Status = DBReadByte(rDataReader, "Status")
          .DelStatus = DBReadByte(rDataReader, "DelStatus")
          .Instructions = DBReadString(rDataReader, "Instructions")
          .Comments = DBReadString(rDataReader, "Comments")
          .BuyerID = DBReadByte(rDataReader, "BuyerID")
          .AcknowledgementNo = DBReadString(rDataReader, "AcknowledgementNo")
          .OrderType = DBReadByte(rDataReader, "OrderType")
          .Carriage = DBReadDouble(rDataReader, "Carriage")
          .VatRate = DBReadDecimal(rDataReader, "VatRate")
          .RequiredDate = DBReadDateTime(rDataReader, "RequiredDate")
          .PurchaseCategory = DBReadByte(rDataReader, "PurchaseCategory")
          .CoCOrder = DBReadBoolean(rDataReader, "CoCOrder")
          .CoCType = DBReadByte(rDataReader, "CoCType")
          .PriceGross = DBReadDecimal(rDataReader, "PriceGross")
          .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")
          .DeliveryAddress.Address1 = DBReadString(rDataReader, "DeliveryAddress1")
          .DeliveryAddress.Address2 = DBReadString(rDataReader, "DeliveryAddress2")
          .DeliveryAddress.Address3 = DBReadString(rDataReader, "DeliveryAddress3")
          .DeliveryAddress.Town = DBReadString(rDataReader, "DeliveryTown")
          .DeliveryAddress.County = DBReadString(rDataReader, "DeliveryCounty")
          .DeliveryAddress.PostCode = DBReadString(rDataReader, "DeliveryPostCode")
          .SupplierRef = DBReadString(rDataReader, "SupplierRef")
          .LastStatusChangeDate = DBReadDateTime(rDataReader, "LastStatusChangeDate")
          .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
          .TotalNetValue = DBReadDecimal(rDataReader, "TotalNetValue")
          .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
          .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
          .Supplier.CompanyName = DBReadString(rDataReader, "CompanyName")
          .RefMatType = DBReadString(rDataReader, "RefMatType")
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
    pPurchaseOrderInfo = New clsPurchaseOrderInfo  ' Or .NewBlankvwPurchaseOrder
    Return pPurchaseOrderInfo

  End Function


  Public Function LoadvwPurchaseOrder(ByRef rvwPurchaseOrder As clsPurchaseOrderInfo, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderID)
    If mOK Then
      rvwPurchaseOrder = pPurchaseOrderInfo
    Else
      rvwPurchaseOrder = Nothing
    End If
    pPurchaseOrderInfo = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderInfoCollection(ByRef rvwPurchaseOrders As colPurchaseOrderInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rvwPurchaseOrders, mParams, "PurchaseOrderID")
    Return mOK
  End Function

  Public Function LoadPurchaseOrderInfo(ByRef rvwPurchaseOrder As clsPurchaseOrderInfo, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderID)
    If mOK Then
      rvwPurchaseOrder = pPurchaseOrderInfo
    Else
      rvwPurchaseOrder = Nothing
    End If
    pPurchaseOrderInfo = Nothing
    Return mOK
  End Function
End Class

