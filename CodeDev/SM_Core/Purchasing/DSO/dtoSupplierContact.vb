''DTO Definition - SupplierContact (to SupplierContact)'Generated from Table:SupplierContact

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSupplierContact : Inherits dtoBase
  Private pSupplierContact As dmSupplierContact

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SupplierContact"
    pKeyFieldName = "SupplierContactID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSupplierContact.SupplierContactID
    End Get
    Set(ByVal value As Integer)
      pSupplierContact.SupplierContactID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSupplierContact.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSupplierContact.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SupplierContactID", pSupplierContact.SupplierContactID)
    End If
    With pSupplierContact
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierID", .SupplierID)
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
      If pSupplierContact Is Nothing Then SetObjectToNew()
      With pSupplierContact
        .SupplierContactID = DBReadInt32(rDataReader, "SupplierContactID")
        .SupplierID = DBReadInt32(rDataReader, "SupplierID")
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
        pSupplierContact.IsDirty = False
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
    pSupplierContact = New dmSupplierContact ' Or .NewBlankSupplierContact
    Return pSupplierContact

  End Function


  Public Function LoadSupplierContact(ByRef rSupplierContact As dmSupplierContact, ByVal vSupplierContactID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSupplierContactID)
    If mOK Then
      rSupplierContact = pSupplierContact
    Else
      rSupplierContact = Nothing
    End If
    pSupplierContact = Nothing
    Return mOK
  End Function


  Public Function SaveSupplierContact(ByRef rSupplierContact As dmSupplierContact) As Boolean
    Dim mOK As Boolean
    pSupplierContact = rSupplierContact
    mOK = SaveObject()
    pSupplierContact = Nothing
    Return mOK
  End Function


  Public Function LoadSupplierContactCollection(ByRef rSupplierContacts As colSupplierContacts, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SupplierID", vParentID)
    mOK = MyBase.LoadCollection(rSupplierContacts, mParams, "SupplierContactID")
    rSupplierContacts.TrackDeleted = True
    If mOK Then rSupplierContacts.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSupplierContactCollection(ByRef rCollection As colSupplierContacts, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SupplierID", vParentID)
      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSupplierContact In rCollection.DeletedItems
          If pSupplierContact.SupplierContactID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSupplierContact.SupplierContactID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSupplierContact In rCollection
        If pSupplierContact.IsDirty Or pSupplierContact.SupplierID <> vParentID Or pSupplierContact.SupplierContactID = 0 Then 'Or pCustomerContact.CustomerContactID = 0
          pSupplierContact.SupplierID = vParentID
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

