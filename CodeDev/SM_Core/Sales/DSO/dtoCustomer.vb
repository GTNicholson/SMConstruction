''DTO Definition - Customer (to Customer)'Generated from Table:Customer

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoCustomer : Inherits dtoBase
  Private pCustomer As dmCustomer

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Customer"
    pKeyFieldName = "CustomerID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pCustomer.CustomerID
    End Get
    Set(ByVal value As Integer)
      pCustomer.CustomerID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pCustomer.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pCustomer.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "CustomerID", pCustomer.CustomerID)
    End If
    With pCustomer
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CompanyName", StringToDBValue(.CompanyName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerStatusID", .CustomerStatusID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerTypeID", .CustomerTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesAreaID", .SalesAreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AccountRef", StringToDBValue(.AccountRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TelNo", StringToDBValue(.TelNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Fax", StringToDBValue(.Fax))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Email", StringToDBValue(.Email))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WebURL", StringToDBValue(.WebURL))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesCreditPosition", .SalesCreditPosition)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesCreditLimit", .SalesCreditLimit)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOnStop", .SalesOnStop)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateLastSCreditReview", DateToDBValue(.DateLastSCreditReview))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateSCreditReviewDue", DateToDBValue(.DateSCreditReviewDue))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesCreditComment", StringToDBValue(.SalesCreditComment))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentTermsType", .PaymentTermsType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentTermsParam", .PaymentTermsParam)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRegNo", StringToDBValue(.VATRegNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRateCode", .VATRateCode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentCompanyID", .ParentCompanyID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceParentCompany", .InvoiceParentCompany)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateEntered", DateToDBValue(.DateEntered))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultNominalCode", StringToDBValue(.DefaultNominalCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainAddress1", StringToDBValue(.MainAddress1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainAddress2", StringToDBValue(.MainAddress2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainTown", StringToDBValue(.MainTown))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainCounty", StringToDBValue(.MainCounty))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainPostCode", StringToDBValue(.MainPostCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainCountry", StringToDBValue(.MainCountry))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerNotes", StringToDBValue(.CustomerNotes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesEmployeeID", .SalesEmployeeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "rucnumber", StringToDBValue(.Rucnumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RazonSocial", StringToDBValue(.RazonSocial))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "BancoIntermediario", StringToDBValue(.BancoIntermediario))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Numero_SWIFT", StringToDBValue(.Numero_SWIFT))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Numero_ABA", StringToDBValue(.Numero_ABA))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerReference", StringToDBValue(.CustomerReference))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pCustomer Is Nothing Then SetObjectToNew()
      With pCustomer
        .CustomerID = DBReadInt32(rDataReader, "CustomerID")
        .CompanyName = DBReadString(rDataReader, "CompanyName")
        .CustomerStatusID = DBReadInt32(rDataReader, "CustomerStatusID")
        .CustomerTypeID = DBReadInt32(rDataReader, "CustomerTypeID")
        .SalesAreaID = DBReadInt32(rDataReader, "SalesAreaID")
        .AccountRef = DBReadString(rDataReader, "AccountRef")
        .TelNo = DBReadString(rDataReader, "TelNo")
        .Fax = DBReadString(rDataReader, "Fax")
        .Email = DBReadString(rDataReader, "Email")
        .WebURL = DBReadString(rDataReader, "WebURL")
        .SalesCreditPosition = DBReadByte(rDataReader, "SalesCreditPosition")
        .SalesCreditLimit = DBReadDecimal(rDataReader, "SalesCreditLimit")
        .SalesOnStop = DBReadBoolean(rDataReader, "SalesOnStop")
        .DateLastSCreditReview = DBReadDateTime(rDataReader, "DateLastSCreditReview")
        .DateSCreditReviewDue = DBReadDateTime(rDataReader, "DateSCreditReviewDue")
        .SalesCreditComment = DBReadString(rDataReader, "SalesCreditComment")
        .PaymentTermsType = DBReadByte(rDataReader, "PaymentTermsType")
        .PaymentTermsParam = DBReadInt32(rDataReader, "PaymentTermsParam")
        .VATRegNo = DBReadString(rDataReader, "VATRegNo")
        .VATRateCode = DBReadInt16(rDataReader, "VATRateCode")
        .ParentCompanyID = DBReadInt32(rDataReader, "ParentCompanyID")
        .InvoiceParentCompany = DBReadBoolean(rDataReader, "InvoiceParentCompany")
        .DateEntered = DBReadDateTime(rDataReader, "DateEntered")
        .DefaultNominalCode = DBReadString(rDataReader, "DefaultNominalCode")
        .MainAddress1 = DBReadString(rDataReader, "MainAddress1")
        .MainAddress2 = DBReadString(rDataReader, "MainAddress2")
        .MainTown = DBReadString(rDataReader, "MainTown")
        .MainCounty = DBReadString(rDataReader, "MainCounty")
        .MainPostCode = DBReadString(rDataReader, "MainPostCode")
        .MainCountry = DBReadString(rDataReader, "MainCountry")
        .CustomerNotes = DBReadString(rDataReader, "CustomerNotes")
        .SalesEmployeeID = DBReadInt32(rDataReader, "SalesEmployeeID")
        .Rucnumber = DBReadString(rDataReader, "rucnumber")
        .RazonSocial = DBReadString(rDataReader, "RazonSocial")
        .BancoIntermediario = DBReadString(rDataReader, "BancoIntermediario")
        .Numero_SWIFT = DBReadString(rDataReader, "Numero_SWIFT")
        .Numero_ABA = DBReadString(rDataReader, "Numero_ABA")
        .CustomerReference = DBReadString(rDataReader, "CustomerReference")
        pCustomer.IsDirty = False
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
    pCustomer = New dmCustomer ' Or .NewBlankCustomer
    Return pCustomer

  End Function


  Public Function LoadCustomer(ByRef rCustomer As dmCustomer, ByVal vCustomerID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vCustomerID)
    If mOK Then
      rCustomer = pCustomer
    Else
      rCustomer = Nothing
    End If
    pCustomer = Nothing
    Return mOK
  End Function


  Public Function SaveCustomer(ByRef rCustomer As dmCustomer) As Boolean
    Dim mOK As Boolean
    pCustomer = rCustomer
    mOK = SaveObject()
    pCustomer = Nothing
    Return mOK
  End Function


  Public Function LoadCustomerCollection(ByRef rCustomers As colCustomers) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rCustomers, mParams, "CustomerID")
    rCustomers.TrackDeleted = True
    If mOK Then rCustomers.IsDirty = False
    Return mOK
  End Function


  Public Function SaveCustomerCollection(ByRef rCollection As colCustomers, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pCustomer In rCollection
      ''    If pCustomer.CustomerID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pCustomer.CustomerID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pCustomer In rCollection.DeletedItems
          If pCustomer.CustomerID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pCustomer.CustomerID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pCustomer In rCollection
        If pCustomer.IsDirty Or pCustomer.CustomerID = 0 Then 'Or pCustomer.CustomerID = 0
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
