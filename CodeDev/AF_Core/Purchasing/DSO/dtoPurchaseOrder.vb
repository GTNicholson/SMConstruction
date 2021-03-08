''DTO Definition - PurchaseOrder (to PurchaseOrder)'Generated from Table:PurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrder : Inherits dtoBase
  Private pPurchaseOrder As dmPurchaseOrder

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PurchaseOrder"
    pKeyFieldName = "PurchaseOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrder.PurchaseOrderID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrder.PurchaseOrderID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPurchaseOrder.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPurchaseOrder.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      Return 0
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PurchaseOrderID", pPurchaseOrder.PurchaseOrderID)
    End If
    With pPurchaseOrder
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PONum", StringToDBValue(.PONum))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierID", .SupplierID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierContactName", StringToDBValue(.SupplierContactName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierContactTel", StringToDBValue(.SupplierContactTel))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Category", .Category)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubmissionDate", DateToDBValue(.SubmissionDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DelStatus", .DelStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Instructions", StringToDBValue(.Instructions))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comments", StringToDBValue(.Comments))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "BuyerID", .BuyerID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AcknowledgementNo", StringToDBValue(.AcknowledgementNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderType", .OrderType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Carriage", .Carriage)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatRate", .VatRate)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RequiredDate", DateToDBValue(.RequiredDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseCategory", .PurchaseCategory)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CoCOrder", .CoCOrder)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CoCType", .CoCType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PriceGross", .PriceGross)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPrice", .TotalPrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryAddress1", StringToDBValue(.DeliveryAddress.Address1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryAddress2", StringToDBValue(.DeliveryAddress.Address2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryAddress3", StringToDBValue(.DeliveryAddress.Address3))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryTown", StringToDBValue(.DeliveryAddress.Town))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryCounty", StringToDBValue(.DeliveryAddress.County))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryPostCode", StringToDBValue(.DeliveryAddress.PostCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryContact", StringToDBValue(.DeliveryContact))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryTel", StringToDBValue(.DeliveryTel))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DeliveryEmail", StringToDBValue(.DeliveryEmail))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CallOffType", .CallOffType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatRateCode", .VatRateCode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ApplyVATToCarriage", .ApplyVATToCarriage)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierContactID", .SupplierContactID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierRef", StringToDBValue(.SupplierRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LastStatusChangeDate", DateToDBValue(.LastStatusChangeDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileName", StringToDBValue(.FileName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierAddress1", StringToDBValue(.SupplierAddress.Address1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierAddress2", StringToDBValue(.SupplierAddress.Address2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierAddress3", StringToDBValue(.SupplierAddress.Address3))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierTown", StringToDBValue(.SupplierAddress.Town))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierCounty", StringToDBValue(.SupplierAddress.County))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierPostCode", StringToDBValue(.SupplierAddress.PostCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceAddress1", StringToDBValue(.InvoiceAddress.Address1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceAddress2", StringToDBValue(.InvoiceAddress.Address2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceAddress3", StringToDBValue(.InvoiceAddress.Address3))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceTown", StringToDBValue(.InvoiceAddress.Town))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceCounty", StringToDBValue(.InvoiceAddress.County))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoicePostCode", StringToDBValue(.InvoiceAddress.PostCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ExchangeRateValue", .ExchangeRateValue)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentStatus", .PaymentStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalNetValue", .TotalNetValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialRequirementTypeID", .MaterialRequirementTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultCurrency", .DefaultCurrency)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RefMatType", StringToDBValue(.RefMatType))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentMethod", .PaymentMethod)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AccoutingCategoryID", .AccoutingCategoryID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "POStage", .POStage)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RetentionPercentage", .RetentionPercentage)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ValuationMode", .ValuationMode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentDate", DateToDBValue(.PaymentDate))



    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPurchaseOrder Is Nothing Then SetObjectToNew()
      With pPurchaseOrder
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .PONum = DBReadString(rDataReader, "PONum")
        .SupplierID = DBReadInt32(rDataReader, "SupplierID")
        .SupplierContactName = DBReadString(rDataReader, "SupplierContactName")
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
        .DeliveryContact = DBReadString(rDataReader, "DeliveryContact")
        .DeliveryTel = DBReadString(rDataReader, "DeliveryTel")
        .DeliveryEmail = DBReadString(rDataReader, "DeliveryEmail")
        .CallOffType = DBReadByte(rDataReader, "CallOffType")
        .VatRateCode = DBReadByte(rDataReader, "VatRateCode")
        .ApplyVATToCarriage = DBReadBoolean(rDataReader, "ApplyVATToCarriage")
        .SupplierContactID = DBReadInt32(rDataReader, "SupplierContactID")
        .SupplierRef = DBReadString(rDataReader, "SupplierRef")
        .LastStatusChangeDate = DBReadDateTime(rDataReader, "LastStatusChangeDate")
        .FileName = DBReadString(rDataReader, "FileName")
        .SupplierAddress.Address1 = DBReadString(rDataReader, "SupplierAddress1")
        .SupplierAddress.Address2 = DBReadString(rDataReader, "SupplierAddress2")
        .SupplierAddress.Address3 = DBReadString(rDataReader, "SupplierAddress3")
        .SupplierAddress.Town = DBReadString(rDataReader, "SupplierTown")
        .SupplierAddress.County = DBReadString(rDataReader, "SupplierCounty")
        .SupplierAddress.PostCode = DBReadString(rDataReader, "SupplierPostCode")
        .InvoiceAddress.Address1 = DBReadString(rDataReader, "InvoiceAddress1")
        .InvoiceAddress.Address2 = DBReadString(rDataReader, "InvoiceAddress2")
        .InvoiceAddress.Address3 = DBReadString(rDataReader, "InvoiceAddress3")
        .InvoiceAddress.Town = DBReadString(rDataReader, "InvoiceTown")
        .InvoiceAddress.County = DBReadString(rDataReader, "InvoiceCounty")
        .InvoiceAddress.PostCode = DBReadString(rDataReader, "InvoicePostCode")
        .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")

        .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
        .TotalNetValue = DBReadDecimal(rDataReader, "TotalNetValue")
        .MaterialRequirementTypeID = DBReadInt32(rDataReader, "MaterialRequirementTypeID")
        .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
        .PaymentMethod = DBReadInt32(rDataReader, "PaymentMethod")

        .RefMatType = DBReadString(rDataReader, "RefMatType")

        .AccoutingCategoryID = DBReadInt32(rDataReader, "AccoutingCategoryID")
        .POStage = DBReadInt32(rDataReader, "POStage")
        .RetentionPercentage = DBReadDecimal(rDataReader, "RetentionPercentage")

        .ValuationMode = DBReadInt32(rDataReader, "ValuationMode")
        .PaymentDate = DBReadDate(rDataReader, "PaymentDate")
        pPurchaseOrder.IsDirty = False
        pPurchaseOrder.DeliveryAddress.IsDirty = False
        pPurchaseOrder.SupplierAddress.IsDirty = False
        pPurchaseOrder.InvoiceAddress.IsDirty = False
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
    pPurchaseOrder = New dmPurchaseOrder ' Or .NewBlankPurchaseOrder
    Return pPurchaseOrder

  End Function


  Public Function LoadPurchaseOrder(ByRef rPurchaseOrder As dmPurchaseOrder, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderID)
    If mOK Then
      rPurchaseOrder = pPurchaseOrder
    Else
      rPurchaseOrder = Nothing
    End If
    pPurchaseOrder = Nothing
    Return mOK
  End Function


  Public Function SavePurchaseOrder(ByRef rPurchaseOrder As dmPurchaseOrder) As Boolean
    Dim mOK As Boolean
    pPurchaseOrder = rPurchaseOrder
    mOK = SaveObject()
    pPurchaseOrder = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderCollection(ByRef rPurchaseOrders As colPurchaseOrders, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rPurchaseOrders, mParams, "PurchaseOrderID", vWhere)
    If mOK Then rPurchaseOrders.IsDirty = False
    Return mOK
  End Function


  Public Function SavePurchaseOrderCollection(ByRef rCollection As colPurchaseOrders) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    'Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPurchaseOrder In rCollection
      ''    If pPurchaseOrder.PurchaseOrderID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''      mIDs = mIDs & pPurchaseOrder.PurchaseOrderID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''  mAllOK = True
      ''End If

      'Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPurchaseOrder In rCollection.DeletedItems
          If pPurchaseOrder.PurchaseOrderID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPurchaseOrder.PurchaseOrderID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPurchaseOrder In rCollection
        If pPurchaseOrder.IsDirty Or pPurchaseOrder.PurchaseOrderID = 0 Then 'Or pPurchaseOrder.PurchaseOrderID = 0
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
