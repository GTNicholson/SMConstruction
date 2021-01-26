
''DTO Definition - AccoutingCategory (to AccoutingCategory)'Generated from Table:AccoutingCategory

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoAccoutingCategory : Inherits dtoBase

  Private pAccoutingCategory As dmAccoutingCategory

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "AccoutingCategory"
    pKeyFieldName = "AccoutingCategoryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pAccoutingCategory.AccoutingCategoryID
    End Get
    Set(ByVal value As Integer)
      pAccoutingCategory.AccoutingCategoryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pAccoutingCategory.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pAccoutingCategory.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "AccoutingCategoryID", pAccoutingCategory.AccoutingCategoryID)
    End If
    With pAccoutingCategory
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pAccoutingCategory Is Nothing Then SetObjectToNew()
      With pAccoutingCategory
        .AccoutingCategoryID = DBReadInt32(rDataReader, "AccoutingCategoryID")
        .Description = DBReadString(rDataReader, "Description")
        pAccoutingCategory.IsDirty = False
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
    pAccoutingCategory = New dmAccoutingCategory ' Or .NewBlankAccoutingCategory
    Return pAccoutingCategory

  End Function


  Public Function LoadAccoutingCategory(ByRef rAccoutingCategory As dmAccoutingCategory, ByVal vAccoutingCategoryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vAccoutingCategoryID)
    If mOK Then
      rAccoutingCategory = pAccoutingCategory
    Else
      rAccoutingCategory = Nothing
    End If
    pAccoutingCategory = Nothing
    Return mOK
  End Function


  Public Function SaveAccoutingCategory(ByRef rAccoutingCategory As dmAccoutingCategory) As Boolean
    Dim mOK As Boolean
    pAccoutingCategory = rAccoutingCategory
    mOK = SaveObject()
    pAccoutingCategory = Nothing
    Return mOK
  End Function


  Public Function LoadAccoutingCategoryCollection(ByRef rAccoutingCategorys As colAccoutingCategorys) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    'mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rAccoutingCategorys, mParams, "AccoutingCategoryID")
    rAccoutingCategorys.TrackDeleted = True
    If mOK Then rAccoutingCategorys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveAccoutingCategoryCollection(ByRef rCollection As colAccoutingCategorys) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      'mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pAccoutingCategory In rCollection
      ''    If pAccoutingCategory.AccoutingCategoryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pAccoutingCategory.AccoutingCategoryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pAccoutingCategory In rCollection.DeletedItems
          If pAccoutingCategory.AccoutingCategoryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pAccoutingCategory.AccoutingCategoryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pAccoutingCategory In rCollection
        If pAccoutingCategory.IsDirty Or pAccoutingCategory.AccoutingCategoryID = 0 Then 'Or pAccoutingCategory.AccoutingCategoryID = 
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


