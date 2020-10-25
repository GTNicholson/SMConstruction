''DTO Definition - ProductConstructionType (to ProductConstructionType)'Generated from Table:ProductConstructionType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductConstructionType : Inherits dtoBase
  Private pProductConstructionType As dmProductConstructionType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductConstructionType"
    pKeyFieldName = "ProductConstructionTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductConstructionType.ProductConstructionTypeID
    End Get
    Set(ByVal value As Integer)
      pProductConstructionType.ProductConstructionTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductConstructionType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductConstructionType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductConstructionTypeID", pProductConstructionType.ProductConstructionTypeID)
    End If
    With pProductConstructionType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abbreviation", StringToDBValue(.Abbreviation))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SequenceNo", .SequenceNo)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductConstructionType Is Nothing Then SetObjectToNew()
      With pProductConstructionType
        .ProductConstructionTypeID = DBReadInt32(rDataReader, "ProductConstructionTypeID")
        .Description = DBReadString(rDataReader, "Description")
        .Abbreviation = DBReadString(rDataReader, "Abbreviation")
        .SequenceNo = DBReadInt32(rDataReader, "SequenceNo")
        pProductConstructionType.IsDirty = False
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
    pProductConstructionType = New dmProductConstructionType ' Or .NewBlankProductConstructionType
    Return pProductConstructionType

  End Function


  Public Function LoadProductConstructionType(ByRef rProductConstructionType As dmProductConstructionType, ByVal vProductConstructionTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductConstructionTypeID)
    If mOK Then
      rProductConstructionType = pProductConstructionType
    Else
      rProductConstructionType = Nothing
    End If
    pProductConstructionType = Nothing
    Return mOK
  End Function


  Public Function SaveProductConstructionType(ByRef rProductConstructionType As dmProductConstructionType) As Boolean
    Dim mOK As Boolean
    pProductConstructionType = rProductConstructionType
    mOK = SaveObject()
    pProductConstructionType = Nothing
    Return mOK
  End Function


  Public Function LoadProductConstructionTypeCollection(ByRef rProductConstructionTypes As colProductConstructionTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductConstructionTypes, mParams, "ProductConstructionTypeID")
    rProductConstructionTypes.TrackDeleted = True
    If mOK Then rProductConstructionTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductConstructionTypeCollection(ByRef rCollection As colProductConstructionTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductConstructionType In rCollection
      ''    If pProductConstructionType.ProductConstructionTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductConstructionType.ProductConstructionTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductConstructionType In rCollection.DeletedItems
          If pProductConstructionType.ProductConstructionTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductConstructionType.ProductConstructionTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductConstructionType In rCollection
        If pProductConstructionType.IsDirty Or pProductConstructionType.ProductConstructionTypeID = 0 Then 'Or pProductConstructionType.ProductConstructionTypeID = 0
          ''pProductConstructionType.ParentID = vParentID
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


