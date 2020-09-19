''DTO Definition - FurnitureCategory (to FurnitureCategory)'Generated from Table:FurnitureCategory

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoFurnitureCategory : Inherits dtoBase
  Private pFurnitureCategory As dmFurnitureCategory

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "FurnitureCategory"
    pKeyFieldName = "FurnitureCategoryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pFurnitureCategory.FurnitureCategoryID
    End Get
    Set(ByVal value As Integer)
      pFurnitureCategory.FurnitureCategoryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pFurnitureCategory.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pFurnitureCategory.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "FurnitureCategoryID", pFurnitureCategory.FurnitureCategoryID)
    End If
    With pFurnitureCategory
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EnglishDescription", StringToDBValue(.EnglishDescription))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpanishDescription", StringToDBValue(.SpanishDescription))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pFurnitureCategory Is Nothing Then SetObjectToNew()
      With pFurnitureCategory
        .FurnitureCategoryID = DBReadInt32(rDataReader, "FurnitureCategoryID")
        .EnglishDescription = DBReadString(rDataReader, "EnglishDescription")
        .SpanishDescription = DBReadString(rDataReader, "SpanishDescription")
        pFurnitureCategory.IsDirty = False
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
    pFurnitureCategory = New dmFurnitureCategory ' Or .NewBlankFurnitureCategory
    Return pFurnitureCategory

  End Function


  Public Function LoadFurnitureCategory(ByRef rFurnitureCategory As dmFurnitureCategory, ByVal vFurnitureCategoryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vFurnitureCategoryID)
    If mOK Then
      rFurnitureCategory = pFurnitureCategory
    Else
      rFurnitureCategory = Nothing
    End If
    pFurnitureCategory = Nothing
    Return mOK
  End Function


  Public Function SaveFurnitureCategory(ByRef rFurnitureCategory As dmFurnitureCategory) As Boolean
    Dim mOK As Boolean
    pFurnitureCategory = rFurnitureCategory
    mOK = SaveObject()
    pFurnitureCategory = Nothing
    Return mOK
  End Function


  Public Function LoadFurnitureCategoryCollection(ByRef rFurnitureCategorys As colFurnitureCategorys) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rFurnitureCategorys, mParams, "FurnitureCategoryID")
    rFurnitureCategorys.TrackDeleted = True
    If mOK Then rFurnitureCategorys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveFurnitureCategoryCollection(ByRef rCollection As colFurnitureCategorys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pFurnitureCategory In rCollection
      ''    If pFurnitureCategory.FurnitureCategoryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pFurnitureCategory.FurnitureCategoryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pFurnitureCategory In rCollection.DeletedItems
          If pFurnitureCategory.FurnitureCategoryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pFurnitureCategory.FurnitureCategoryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pFurnitureCategory In rCollection
        If pFurnitureCategory.IsDirty Or pFurnitureCategory.FurnitureCategoryID = 0 Then 'Or pFurnitureCategory.FurnitureCategoryID = 0
          ''pFurnitureCategory.ParentID = vParentID
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