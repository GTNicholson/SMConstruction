''DTO Definition - HostCompany (to HostCompany)'Generated from Table:HostCompany

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoHostCompany : Inherits dtoBase
  Private pHostCompany As dmHostCompany

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "HostCompany"
    pKeyFieldName = "HostCompanyID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pHostCompany.HostCompanyID
    End Get
    Set(ByVal value As Integer)
      pHostCompany.HostCompanyID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pHostCompany.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pHostCompany.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "HostCompanyID", pHostCompany.HostCompanyID)
    End If
    With pHostCompany
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CompanyName", StringToDBValue(.CompanyName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CompanyNumber", StringToDBValue(.CompanyNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRegNo", StringToDBValue(.VATRegNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TelNo", StringToDBValue(.TelNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Fax", StringToDBValue(.Fax))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Email", StringToDBValue(.Email))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WebURL", StringToDBValue(.WebURL))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Address1", StringToDBValue(.Address1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Address2", StringToDBValue(.Address2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Address3", StringToDBValue(.Address3))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Town", StringToDBValue(.Town))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "County", StringToDBValue(.County))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PostCode", StringToDBValue(.PostCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Country", StringToDBValue(.Country))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abreviation", StringToDBValue(.Abreviation))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pHostCompany Is Nothing Then SetObjectToNew()
      With pHostCompany
        .HostCompanyID = DBReadInt32(rDataReader, "HostCompanyID")
        .CompanyName = DBReadString(rDataReader, "CompanyName")
        .CompanyNumber = DBReadString(rDataReader, "CompanyNumber")
        .VATRegNo = DBReadString(rDataReader, "VATRegNo")
        .TelNo = DBReadString(rDataReader, "TelNo")
        .Fax = DBReadString(rDataReader, "Fax")
        .Email = DBReadString(rDataReader, "Email")
        .WebURL = DBReadString(rDataReader, "WebURL")
        .Address1 = DBReadString(rDataReader, "Address1")
        .Address2 = DBReadString(rDataReader, "Address2")
        .Address3 = DBReadString(rDataReader, "Address3")
        .Town = DBReadString(rDataReader, "Town")
        .County = DBReadString(rDataReader, "County")
        .PostCode = DBReadString(rDataReader, "PostCode")
        .Country = DBReadString(rDataReader, "Country")
        .Notes = DBReadString(rDataReader, "Notes")
        .Abreviation = DBReadString(rDataReader, "Abreviation")
        pHostCompany.IsDirty = False
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
    pHostCompany = New dmHostCompany ' Or .NewBlankHostCompany
    Return pHostCompany

  End Function


  Public Function LoadHostCompany(ByRef rHostCompany As dmHostCompany, ByVal vHostCompanyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vHostCompanyID)
    If mOK Then
      rHostCompany = pHostCompany
    Else
      rHostCompany = Nothing
    End If
    pHostCompany = Nothing
    Return mOK
  End Function


  Public Function SaveHostCompany(ByRef rHostCompany As dmHostCompany) As Boolean
    Dim mOK As Boolean
    pHostCompany = rHostCompany
    mOK = SaveObject()
    pHostCompany = Nothing
    Return mOK
  End Function


  Public Function LoadHostCompanyCollection(ByRef rHostCompanys As colHostCompanys) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rHostCompanys, mParams, "HostCompanyID")
    rHostCompanys.TrackDeleted = True
    If mOK Then rHostCompanys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveHostCompanyCollection(ByRef rCollection As colHostCompanys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pHostCompany In rCollection
      ''    If pHostCompany.HostCompanyID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pHostCompany.HostCompanyID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pHostCompany In rCollection.DeletedItems
          If pHostCompany.HostCompanyID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pHostCompany.HostCompanyID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pHostCompany In rCollection
        If pHostCompany.IsDirty Or pHostCompany.HostCompanyID = 0 Then 'Or pHostCompany.HostCompanyID = 0
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

