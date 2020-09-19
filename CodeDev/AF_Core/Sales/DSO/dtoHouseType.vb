''DTO Definition - HouseType (to HouseType)'Generated from Table:HouseType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoHouseType : Inherits dtoBase
  Private pHouseType As dmHouseType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "HouseType"
    pKeyFieldName = "HouseTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pHouseType.HouseTypeID
    End Get
    Set(ByVal value As Integer)
      pHouseType.HouseTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pHouseType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pHouseType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "HouseTypeID", pHouseType.HouseTypeID)
    End If
    With pHouseType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Name", StringToDBValue(.Name))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pHouseType Is Nothing Then SetObjectToNew()
      With pHouseType
        .HouseTypeID = DBReadInt32(rDataReader, "HouseTypeID")
        .Name = DBReadString(rDataReader, "Name")
        pHouseType.IsDirty = False
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
    pHouseType = New dmHouseType ' Or .NewBlankHouseType
    Return pHouseType

  End Function


  Public Function LoadHouseType(ByRef rHouseType As dmHouseType, ByVal vHouseTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vHouseTypeID)
    If mOK Then
      rHouseType = pHouseType
    Else
      rHouseType = Nothing
    End If
    pHouseType = Nothing
    Return mOK
  End Function


  Public Function SaveHouseType(ByRef rHouseType As dmHouseType) As Boolean
    Dim mOK As Boolean
    pHouseType = rHouseType
    mOK = SaveObject()
    pHouseType = Nothing
    Return mOK
  End Function


  Public Function LoadHouseTypeCollection(ByRef rHouseTypes As colHouseTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''  mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rHouseTypes, mParams, "HouseTypeID")
    rHouseTypes.TrackDeleted = True
    If mOK Then rHouseTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveHouseTypeCollection(ByRef rCollection As colHouseTypes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pHouseType In rCollection
      ''    If pHouseType.HouseTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pHouseType.HouseTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pHouseType In rCollection.DeletedItems
          If pHouseType.HouseTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pHouseType.HouseTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pHouseType In rCollection
        If pHouseType.IsDirty Or pHouseType.HouseTypeID = 0 Then 'Or pHouseType.HouseTypeID = 0
          ''pHouseType.ParentID = vParentID
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

