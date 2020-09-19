
''DTO Definition - ProductStructureType (to ProductStructureType)'Generated from Table:ProductStructureType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductStructureType : Inherits dtoBase
  Private pProductStructureType As dmProductStructureType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductStructureType"
    pKeyFieldName = "ProductStructureTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductStructureType.ProductStructureTypeID
    End Get
    Set(ByVal value As Integer)
      pProductStructureType.ProductStructureTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductStructureType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductStructureType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductStructureTypeID", pProductStructureType.ProductStructureTypeID)
    End If
    With pProductStructureType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductStructureType Is Nothing Then SetObjectToNew()
      With pProductStructureType
        .ProductStructureTypeID = DBReadInt32(rDataReader, "ProductStructureTypeID")
        .Description = DBReadString(rDataReader, "Description")
        pProductStructureType.IsDirty = False
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
    pProductStructureType = New dmProductStructureType ' Or .NewBlankProductStructureType
    Return pProductStructureType

  End Function


  Public Function LoadProductStructureType(ByRef rProductStructureType As dmProductStructureType, ByVal vProductStructureTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductStructureTypeID)
    If mOK Then
      rProductStructureType = pProductStructureType
    Else
      rProductStructureType = Nothing
    End If
    pProductStructureType = Nothing
    Return mOK
  End Function


  Public Function SaveProductStructureType(ByRef rProductStructureType As dmProductStructureType) As Boolean
    Dim mOK As Boolean
    pProductStructureType = rProductStructureType
    mOK = SaveObject()
    pProductStructureType = Nothing
    Return mOK
  End Function


  Public Function LoadProductStructureTypeCollection(ByRef rProductStructureTypes As colProductStructureTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductStructureTypes, mParams, "ProductStructureTypeID")
    rProductStructureTypes.TrackDeleted = True
    If mOK Then rProductStructureTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductStructureTypeCollection(ByRef rCollection As colProductStructureTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductStructureType In rCollection
      ''    If pProductStructureType.ProductStructureTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductStructureType.ProductStructureTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductStructureType In rCollection.DeletedItems
          If pProductStructureType.ProductStructureTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductStructureType.ProductStructureTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductStructureType In rCollection
        If pProductStructureType.IsDirty Or pProductStructureType.ProductStructureTypeID = 0 Then 'Or pProductStructureType.ProductStructureTypeID = 0

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

