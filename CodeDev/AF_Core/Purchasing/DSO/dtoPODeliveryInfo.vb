
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPODeliveryInfo : Inherits dtoBase
  Private pPODeliveryInfo As clsPODeliveryInfo



  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwPODeliveryInfo"
    pKeyFieldName = "PODeliveryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPODeliveryInfo.PODeliveryID
    End Get
    Set(ByVal value As Integer)
      pPODeliveryInfo.PODelivery.PODeliveryID = value
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
      If pPODeliveryInfo Is Nothing Then SetObjectToNew()
      With pPODeliveryInfo

        With .PODelivery
          .PODeliveryID = DBReadInt32(rDataReader, "PODeliveryID")
          .GRNumber = DBReadString(rDataReader, "GRNumber")
          .ReceivedDate = DBReadDate(rDataReader, "ReceivedDate")
          .Comment = DBReadString(rDataReader, "Comment")
          .DateCreated = DBReadDate(rDataReader, "DateCreated")
          .PODeliveryValue = DBReadDecimal(rDataReader, "PODeliveryValue")
          .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
          .FileExport = DBReadString(rDataReader, "FileExport")
          .Status = DBReadByte(rDataReader, "Status")
        End With

        With .PurchaseOrder
          .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
          .PurchaseCategory = DBReadByte(rDataReader, "PurchaseCategory")
          .PONum = DBReadString(rDataReader, "PONum")
          .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
          .RequiredDate = DBReadDate(rDataReader, "RequiredDate")
          .DeliveryAddress.Address1 = DBReadString(rDataReader, "DeliveryAddress1")

        End With


        With .Supplier
          .SupplierID = DBReadInt32(rDataReader, "SupplierID")
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
    pPODeliveryInfo = New clsPODeliveryInfo  ' Or .NewBlankvwPurchaseOrder
    Return pPODeliveryInfo

  End Function


  Public Function LoadPODeliveryInfoByID(ByRef rPODeliveryInfo As clsPODeliveryInfo, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPrimaryKeyID)
    If mOK Then
      rPODeliveryInfo = pPODeliveryInfo
    Else
      rPODeliveryInfo = Nothing
    End If
    pPODeliveryInfo = Nothing
    Return mOK
  End Function


  Public Function LoadPODeliveryInfoCollectionByWhere(ByRef rPODeliveryInfos As colPODeliveryInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rPODeliveryInfos, mParams, "PODeliveryID", vWhere)
    Return mOK
  End Function


End Class

