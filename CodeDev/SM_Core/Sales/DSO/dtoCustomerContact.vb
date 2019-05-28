
''DTO Definition - CustomerContact (to CustomerContact)'Generated from Table:CustomerContact

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoCustomerContact : Inherits dtoBase
  Private pCustomerContact As dmCustomerContact

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "CustomerContact"
    pKeyFieldName = "CustomerContactID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pCustomerContact.CustomerContactID
    End Get
    Set(ByVal value As Integer)
      pCustomerContact.CustomerContactID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pCustomerContact.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pCustomerContact.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "CustomerContactID", pCustomerContact.CustomerContactID)
    End If
    With pCustomerContact
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerID", .CustomerID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Title", StringToDBValue(.Title))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FirstName", StringToDBValue(.FirstName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LastName", StringToDBValue(.LastName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TelNo", StringToDBValue(.TelNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Email", StringToDBValue(.Email))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Mobile", StringToDBValue(.Mobile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ContactType", .ContactType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ContactOptions", .ContactOptions)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsActive", .IsActive)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateStart", DateToDBValue(.DateStart))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateEnd", DateToDBValue(.DateEnd))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Position", StringToDBValue(.Position))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pCustomerContact Is Nothing Then SetObjectToNew()
      With pCustomerContact
        .CustomerContactID = DBReadInt32(rDataReader, "CustomerContactID")
        .CustomerID = DBReadInt32(rDataReader, "CustomerID")
        .Title = DBReadString(rDataReader, "Title")
        .FirstName = DBReadString(rDataReader, "FirstName")
        .LastName = DBReadString(rDataReader, "LastName")
        .TelNo = DBReadString(rDataReader, "TelNo")
        .Email = DBReadString(rDataReader, "Email")
        .Mobile = DBReadString(rDataReader, "Mobile")
        .ContactType = DBReadInt32(rDataReader, "ContactType")
        .ContactOptions = DBReadInt32(rDataReader, "ContactOptions")
        .IsActive = DBReadBoolean(rDataReader, "IsActive")
        .DateStart = DBReadDateTime(rDataReader, "DateStart")
        .DateEnd = DBReadDateTime(rDataReader, "DateEnd")
        .Position = DBReadString(rDataReader, "Position")
        pCustomerContact.IsDirty = False
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
    pCustomerContact = New dmCustomerContact ' Or .NewBlankCustomerContact
    Return pCustomerContact

  End Function


  Public Function LoadCustomerContact(ByRef rCustomerContact As dmCustomerContact, ByVal vCustomerContactID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vCustomerContactID)
    If mOK Then
      rCustomerContact = pCustomerContact
    Else
      rCustomerContact = Nothing
    End If
    pCustomerContact = Nothing
    Return mOK
  End Function


  Public Function SaveCustomerContact(ByRef rCustomerContact As dmCustomerContact) As Boolean
    Dim mOK As Boolean
    pCustomerContact = rCustomerContact
    mOK = SaveObject()
    pCustomerContact = Nothing
    Return mOK
  End Function


  Public Function LoadCustomerContactCollection(ByRef rCustomerContacts As colCustomerContacts, ByVal vCustomerID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@CustomerID", vCustomerID)
    mOK = MyBase.LoadCollection(rCustomerContacts, mParams, "CustomerContactID")
    rCustomerContacts.TrackDeleted = True
    If mOK Then rCustomerContacts.IsDirty = False
    Return mOK
  End Function


  Public Function SaveCustomerContactCollection(ByRef rCollection As colCustomerContacts, ByVal vCustomerID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@CustomerID", vCustomerID)
      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pCustomerContact In rCollection.DeletedItems
          If pCustomerContact.CustomerContactID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pCustomerContact.CustomerContactID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pCustomerContact In rCollection
        If pCustomerContact.IsDirty Or pCustomerContact.CustomerID <> vCustomerID Or pCustomerContact.CustomerContactID = 0 Then 'Or pCustomerContact.CustomerContactID = 0
          pCustomerContact.CustomerID = vCustomerID
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



