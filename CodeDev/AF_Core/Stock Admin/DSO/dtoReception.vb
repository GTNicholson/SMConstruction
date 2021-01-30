''DTO Definition - Reception (to Reception)'Generated from Table:Reception

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoReception : Inherits dtoBase
  Private pReception As dmReception


  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Reception"
    pKeyFieldName = "ReceptionID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pReception.ReceptionID
    End Get
    Set(ByVal value As Integer)
      pReception.ReceptionID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pReception.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pReception.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ReceptionID", pReception.ReceptionID)
    End If
    With pReception
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Farm", .Farm)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReceptionDate", DateToDBValue(.ReceptionDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemType", .ItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReceptionNo", .ReceptionNo)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CardNumber", StringToDBValue(.CardNumber))


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pReception Is Nothing Then SetObjectToNew()
      With pReception
        .ReceptionID = DBReadInt32(rDataReader, "ReceptionID")
        .Farm = DBReadInt32(rDataReader, "Farm")
        .ReceptionDate = DBReadDateTime(rDataReader, "ReceptionDate")
        .ItemType = DBReadInt32(rDataReader, "ItemType")
        .ReceptionNo = DBReadString(rDataReader, "ReceptionNo")
        .CardNumber = DBReadString(rDataReader, "CardNumber")
        pReception.IsDirty = False
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
    pReception = New dmReception ' Or .NewBlankReception
    Return pReception

  End Function


  Public Function LoadReception(ByRef rReception As dmReception, ByVal vReceptionID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vReceptionID)
    If mOK Then
      rReception = pReception
    Else
      rReception = Nothing
    End If
    pReception = Nothing
    Return mOK
  End Function


  Public Function SaveReception(ByRef rReception As dmReception) As Boolean
    Dim mOK As Boolean
    pReception = rReception
    mOK = SaveObject()
    pReception = Nothing
    Return mOK
  End Function


  Public Function LoadReceptionCollection(ByRef rReceptions As colReceptions) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rReceptions, mParams, "ReceptionID")
    rReceptions.TrackDeleted = True
    If mOK Then rReceptions.IsDirty = False
    Return mOK
  End Function

  Public Function LoadReceptionCollectionByWhere(ByRef rReceptions As colReceptions, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rReceptions, mParams, "ReceptionID", vWhere)
    rReceptions.TrackDeleted = True
    If mOK Then rReceptions.IsDirty = False
    Return mOK
  End Function
  Public Function SaveReceptionCollection(ByRef rCollection As colReceptions) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pReception In rCollection
      ''    If pReception.ReceptionID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pReception.ReceptionID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pReception In rCollection.DeletedItems
          If pReception.ReceptionID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pReception.ReceptionID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pReception In rCollection
        If pReception.IsDirty Or pReception.ReceptionID = 0 Then 'Or pReception.ReceptionID = 0
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

