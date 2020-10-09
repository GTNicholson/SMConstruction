Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSupplier : Inherits dtoBase
  Private pSupplier As dmSupplier

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "Supplier"
    pKeyFieldName = "SupplierID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSupplier.SupplierID
    End Get
    Set(ByVal value As Integer)
      pSupplier.SupplierID = value
    End Set
  End Property

  Public Function LoadSupplierCollection(ByRef rSupplier As colSuppliers) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rSupplier, mParams, "SupplierID")
    rSupplier.TrackDeleted = True
    If mOK Then rSupplier.IsDirty = False


    Return mOK
  End Function


  Public Function LoadSupplierCollectionByWhere(ByRef rSupplier As colSuppliers, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rSupplier, mParams, "SupplierID", vWhere)
    rSupplier.TrackDeleted = True
    If mOK Then rSupplier.IsDirty = False


    Return mOK
  End Function

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSupplier.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSupplier.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SupplierID", pSupplier.SupplierID)
    End If
    With pSupplier
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CompanyName", StringToDBValue(.CompanyName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierStatusID", .SupplierStatusID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierTypeID", .SupplierTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentSupplierID", .ParentSupplierID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AccountCode", StringToDBValue(.AccountCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TelNo", StringToDBValue(.TelNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Fax", StringToDBValue(.Fax))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Email", StringToDBValue(.Email))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WebURL", StringToDBValue(.WebURL))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesAreaID", .SalesAreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentTermsType", .PaymentTermsType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentTermsParam", .PaymentTermsParam)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRefNo", StringToDBValue(.VATRefNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateEntered", DateToDBValue(.DateEntered))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateAmended", DateToDBValue(.DateAmended))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EnteredByUserID", .EnteredByUserID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AmendedByUserID", .AmendedByUserID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultAddressID", .DefaultAddressID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultContactID", .DefaultContactID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceParentCompany", .InvoiceParentCompany)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RazonSocial", StringToDBValue(.RazonSocial))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "BancoIntermediario", StringToDBValue(.BancoIntermediario))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Numero_SWIFT", StringToDBValue(.Numero_SWIFT))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Numero_ABA", StringToDBValue(.Numero_ABA))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Rucnumber", StringToDBValue(.Rucnumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierReferenceID", StringToDBValue(.SupplierReferenceID))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchasingTermsType", .PurchasingTermsType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainAddress1", StringToDBValue(.MainAddress1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainAddress2", StringToDBValue(.MainAddress2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainTown", StringToDBValue(.MainTown))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainCounty", StringToDBValue(.MainCounty))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MainCountry", StringToDBValue(.MainCountry))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "BankName", StringToDBValue(.BankName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AccountSecondaryNumber", StringToDBValue(.AccountSecondaryNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrintAccountOption", .PrintAccountOption)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultCurrency", .DefaultCurrency)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSupplier Is Nothing Then SetObjectToNew()
      With pSupplier

        With .MainAddress
          .Address1 = DBReadString(rDataReader, "MainAddress1")
          .Address2 = DBReadString(rDataReader, "MainAddress2")
          ''.Address3 = DBReadString(rDataReader, "Address3")
          .Town = DBReadString(rDataReader, "MainTown")
          .County = DBReadString(rDataReader, "MainCounty")
          ''.PostCode = DBReadString(rDataReader, "PostCode")
          .Country = DBReadString(rDataReader, "MainCountry")
        End With
        .PrintAccountOption = DBReadInt32(rDataReader, "PrintAccountOption")

        .SupplierID = DBReadInt32(rDataReader, "SupplierID")
        .CompanyName = DBReadString(rDataReader, "CompanyName")
        .SupplierStatusID = DBReadInt32(rDataReader, "SupplierStatusID")
        .SupplierTypeID = DBReadInt32(rDataReader, "SupplierTypeID")
        .ParentSupplierID = DBReadInt32(rDataReader, "ParentSupplierID")
        .AccountCode = DBReadString(rDataReader, "AccountCode")
        .TelNo = DBReadString(rDataReader, "TelNo")
        .Fax = DBReadString(rDataReader, "Fax")
        .Email = DBReadString(rDataReader, "Email")
        .WebURL = DBReadString(rDataReader, "WebURL")
        .SalesAreaID = DBReadInt32(rDataReader, "SalesAreaID")
        .PaymentTermsType = DBReadByte(rDataReader, "PaymentTermsType")
        .PaymentTermsParam = DBReadInt32(rDataReader, "PaymentTermsParam")
        .VATRefNo = DBReadString(rDataReader, "VATRefNo")
        .Notes = DBReadString(rDataReader, "Notes")
        .DateEntered = DBReadDateTime(rDataReader, "DateEntered")
        .DateAmended = DBReadDateTime(rDataReader, "DateAmended")
        .EnteredByUserID = DBReadInt32(rDataReader, "EnteredByUserID")
        .AmendedByUserID = DBReadInt32(rDataReader, "AmendedByUserID")
        .DefaultAddressID = DBReadInt32(rDataReader, "DefaultAddressID")
        .DefaultContactID = DBReadInt32(rDataReader, "DefaultContactID")
        .InvoiceParentCompany = DBReadBoolean(rDataReader, "InvoiceParentCompany")
        .RazonSocial = DBReadString(rDataReader, "RazonSocial")
        .BancoIntermediario = DBReadString(rDataReader, "BancoIntermediario")
        .Numero_SWIFT = DBReadString(rDataReader, "Numero_SWIFT")
        .Numero_ABA = DBReadString(rDataReader, "Numero_ABA")
        .Rucnumber = DBReadString(rDataReader, "Rucnumber")
        .SupplierReferenceID = DBReadString(rDataReader, "SupplierReferenceID")
        .PurchasingTermsType = DBReadInt32(rDataReader, "PurchasingTermsType")
        .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
        .BankName = DBReadString(rDataReader, "BankName")
        .AccountSecondaryNumber = DBReadString(rDataReader, "AccountSecondaryNumber")

        pSupplier.IsDirty = False
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
    pSupplier = New dmSupplier ' Or .NewBlankSupplier
    Return pSupplier

  End Function


  Public Function LoadSupplier(ByRef rSupplier As dmSupplier, ByVal vSupplierID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSupplierID)
    If mOK Then
      rSupplier = pSupplier
    Else
      rSupplier = Nothing
    End If
    pSupplier = Nothing
    Return mOK
  End Function


  Public Function SaveSupplier(ByRef rSupplier As dmSupplier) As Boolean
    Dim mOK As Boolean
    pSupplier = rSupplier
    mOK = SaveObject()
    pSupplier = Nothing
    Return mOK
  End Function


  Public Function SaveSupplierCollection(ByRef rCollection As colSuppliers, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSupplier In rCollection
      ''    If pSupplier.SupplierID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSupplier.SupplierID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSupplier In rCollection.DeletedItems
          If pSupplier.SupplierID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSupplier.SupplierID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSupplier In rCollection
        If pSupplier.IsDirty <> vParentID Or pSupplier.SupplierID = 0 Then 'Or pSupplier.SupplierID = 0

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