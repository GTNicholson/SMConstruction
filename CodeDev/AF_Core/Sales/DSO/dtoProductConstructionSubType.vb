''DTO Definition - ProductConstructionSubType (to ProductConstructionSubType)'Generated from Table:ProductConstructionSubType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductConstructionSubType : Inherits dtoBase
  Private pProductConstructionSubType As dmProductConstructionSubType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductConstructionSubType"
    pKeyFieldName = "ProductConstructionSubTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductConstructionSubType.ProductConstructionSubTypeID
    End Get
    Set(ByVal value As Integer)
      pProductConstructionSubType.ProductConstructionSubTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductConstructionSubType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductConstructionSubType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductConstructionSubTypeID", pProductConstructionSubType.ProductConstructionSubTypeID)
    End If
    With pProductConstructionSubType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductConstructionTypeID", .ProductConstructionTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abbreviation", StringToDBValue(.Abbreviation))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SequenceNo", .SequenceNo)

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductConstructionSubType Is Nothing Then SetObjectToNew()
      With pProductConstructionSubType
        .ProductConstructionSubTypeID = DBReadInt32(rDataReader, "ProductConstructionSubTypeID")
        .ProductConstructionTypeID = DBReadInt32(rDataReader, "ProductConstructionTypeID")
        .Description = DBReadString(rDataReader, "Description")
        .Abbreviation = DBReadString(rDataReader, "Abbreviation")
        .SequenceNo = DBReadInt32(rDataReader, "SequenceNo")

        pProductConstructionSubType.IsDirty = False
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
    pProductConstructionSubType = New dmProductConstructionSubType ' Or .NewBlankProductConstructionSubType
    Return pProductConstructionSubType

  End Function


  Public Function LoadProductConstructionSubType(ByRef rProductConstructionSubType As dmProductConstructionSubType, ByVal vProductConstructionSubTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductConstructionSubTypeID)
    If mOK Then
      rProductConstructionSubType = pProductConstructionSubType
    Else
      rProductConstructionSubType = Nothing
    End If
    pProductConstructionSubType = Nothing
    Return mOK
  End Function


  Public Function SaveProductConstructionSubType(ByRef rProductConstructionSubType As dmProductConstructionSubType) As Boolean
    Dim mOK As Boolean
    pProductConstructionSubType = rProductConstructionSubType
    mOK = SaveObject()
    pProductConstructionSubType = Nothing
    Return mOK
  End Function

  Public Function LoadAllProductConstructionSubTypeCollection(ByRef rProductConstructionSubTypes As colProductConstructionSubTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ProductConstructionTypeID", vProductConstructionTypeID)
    mOK = MyBase.LoadCollection(rProductConstructionSubTypes, mParams, "ProductConstructionSubTypeID")
    rProductConstructionSubTypes.TrackDeleted = True
    If mOK Then rProductConstructionSubTypes.IsDirty = False
    Return mOK
  End Function

  Public Function LoadProductConstructionSubTypeCollectionByItemTypeID(ByRef rProductConstructionSubTypes As colProductConstructionSubTypes, ByVal vProductConstructionTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ProductConstructionTypeID", vProductConstructionTypeID)
    mOK = MyBase.LoadCollection(rProductConstructionSubTypes, mParams, "ProductConstructionSubTypeID")
    rProductConstructionSubTypes.TrackDeleted = True
    If mOK Then rProductConstructionSubTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductConstructionSubTypeCollection(ByRef rCollection As colProductConstructionSubTypes, ByVal vProductConstructionTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ProductConstructionTypeID", vProductConstructionTypeID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductConstructionSubType In rCollection
      ''    If pProductConstructionSubType.ProductConstructionSubTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductConstructionSubType.ProductConstructionSubTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductConstructionSubType In rCollection.DeletedItems
          If pProductConstructionSubType.ProductConstructionSubTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductConstructionSubType.ProductConstructionSubTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductConstructionSubType In rCollection
        If pProductConstructionSubType.IsDirty Or pProductConstructionSubType.ProductConstructionTypeID <> vProductConstructionTypeID Or pProductConstructionSubType.ProductConstructionSubTypeID = 0 Then 'Or pProductConstructionSubType.ProductConstructionSubTypeID = 0
          pProductConstructionSubType.ProductConstructionTypeID = vProductConstructionTypeID
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


