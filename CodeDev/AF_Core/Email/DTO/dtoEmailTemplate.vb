''DTO Definition - EmailTemplate (to EmailTemplate)'Generated from Table:EmailTemplate

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoEmailTemplate : Inherits dtoBase
  Private pEmailTemplate As dmEmailTemplate

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "EmailTemplate"
    pKeyFieldName = "EmailTemplateEnum"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pEmailTemplate.EmailTemplateID
    End Get
    Set(ByVal value As Integer)
      pEmailTemplate.EmailTemplateID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pEmailTemplate.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pEmailTemplate.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "EmailTemplateID", pEmailTemplate.EmailTemplateID)
    End If
    With pEmailTemplate
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmailTemplateEnum", .EmailTemplateEnum)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DistributionEnum", .DistributionEnum)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Subject", StringToDBValue(.Subject))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Body", StringToDBValue(.Body))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pEmailTemplate Is Nothing Then SetObjectToNew()
      With pEmailTemplate
        .EmailTemplateID = DBReadInt32(rDataReader, "EmailTemplateID")
        .EmailTemplateEnum = DBReadByte(rDataReader, "EmailTemplateEnum")
        .DistributionEnum = DBReadByte(rDataReader, "DistributionEnum")
        .Subject = DBReadString(rDataReader, "Subject")
        .Body = DBReadString(rDataReader, "Body")
        pEmailTemplate.IsDirty = False
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
    pEmailTemplate = New dmEmailTemplate ' Or .NewBlankEmailTemplate
    Return pEmailTemplate

  End Function


  Public Function LoadEmailTemplate(ByRef rEmailTemplate As dmEmailTemplate, ByVal vTemplate As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vTemplate)
    If mOK Then
      rEmailTemplate = pEmailTemplate
    Else
      rEmailTemplate = Nothing
    End If
    pEmailTemplate = Nothing
    Return mOK
  End Function


  Public Function SaveEmailTemplate(ByRef rEmailTemplate As dmEmailTemplate) As Boolean
    Dim mOK As Boolean
    pEmailTemplate = rEmailTemplate
    mOK = SaveObject()
    pEmailTemplate = Nothing
    Return mOK
  End Function


  Public Function LoadEmailTemplateCollectionByWhere(ByRef rEmailTemplates As colEmailTemplates, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rEmailTemplates, mParams, "EmailTemplateID", vWhere)
    rEmailTemplates.TrackDeleted = True
    If mOK Then rEmailTemplates.IsDirty = False
    Return mOK
  End Function


  'Public Function SaveEmailTemplateCollection(ByRef rCollection As colEmailTemplates, ByVal vParentID As Integer) As Boolean
  '  Dim mParams As New Hashtable
  '  Dim mAllOK As Boolean
  '  Dim mCount As Integer
  '  Dim mIDs As String = ""
  '  If rCollection.IsDirty Then
  '    mParams.Add("@ParentID", vParentID)
  '    ''Approach where delete items not found in the collection
  '    ''If rCollection.SomeRemoved Then
  '    ''  For Each Me.pEmailTemplate In rCollection
  '    ''    If pEmailTemplate.EmailTemplateID <> 0 Then
  '    ''      mCount = mCount + 1
  '    ''      If mCount > 1 Then mIDs = mIDs & ", "
  '    ''       mIDs = mIDs & pEmailTemplate.EmailTemplateID.ToString
  '    ''    End If
  '    ''  Next
  '    ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
  '    ''Else
  '    ''   mAllOK = True
  '    ''End If

  '    ''Alternative Approach - where maintain collection of deleted items
  '    If rCollection.SomeDeleted Then
  '      mAllOK = True
  '      For Each Me.pEmailTemplate In rCollection.DeletedItems
  '        If pEmailTemplate.EmailTemplateID <> 0 Then
  '          If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pEmailTemplate.EmailTemplateID)
  '        End If
  '      Next
  '    Else
  '      mAllOK = True
  '    End If

  '    For Each Me.pEmailTemplate In rCollection
  '      If pEmailTemplate.IsDirty Or pEmailTemplate.ParentID <> vParentID Or pEmailTemplate.EmailTemplateID = 0 Then 'Or pEmailTemplate.EmailTemplateID = 0
  '        pEmailTemplate.ParentID = vParentID
  '        If mAllOK Then mAllOK = SaveObject()
  '      End If
  '    Next
  '    If mAllOK Then rCollection.IsDirty = False
  '  Else
  '    mAllOK = True
  '  End If

  '  Return mAllOK
  'End Function

End Class


