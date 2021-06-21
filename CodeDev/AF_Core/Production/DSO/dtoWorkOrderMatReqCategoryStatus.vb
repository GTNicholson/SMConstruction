Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrderMatReqCategoryStatus : Inherits dtoBase
  Private pWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrderMatReqCategoryStatus"
    pKeyFieldName = "WorkOrderMatReqCategoryStatusID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID
    End Get
    Set(ByVal value As Integer)
      pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrderMatReqCategoryStatus.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrderMatReqCategoryStatus.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderMatReqCategoryStatusID", pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID)
    End If
    With pWorkOrderMatReqCategoryStatus
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MatReqCategory", .MatReqCategory)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TargetDate", DateToDBValue(.TargetDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LastDate", DateToDBValue(.LastDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickStatus", .PickStatus)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrderMatReqCategoryStatus Is Nothing Then SetObjectToNew()
      With pWorkOrderMatReqCategoryStatus
        .WorkOrderMatReqCategoryStatusID = DBReadInt32(rDataReader, "WorkOrderMatReqCategoryStatusID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .MatReqCategory = DBReadByte(rDataReader, "MatReqCategory")
        .Status = DBReadByte(rDataReader, "Status")
        .TargetDate = DBReadDateTime(rDataReader, "TargetDate")
        .LastDate = DBReadDateTime(rDataReader, "LastDate")
        .Notes = DBReadString(rDataReader, "Notes")
        .PickStatus = DBReadByte(rDataReader, "PickStatus")
        pWorkOrderMatReqCategoryStatus.IsDirty = False
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
    pWorkOrderMatReqCategoryStatus = New dmWorkOrderMatReqCategoryStatus ' Or .NewBlankWorkOrderMatReqCategoryStatus
    Return pWorkOrderMatReqCategoryStatus

  End Function


  Public Function LoadWorkOrderMatReqCategoryStatus(ByRef rWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus, ByVal vWorkOrderMatReqCategoryStatusID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderMatReqCategoryStatusID)
    If mOK Then
      rWorkOrderMatReqCategoryStatus = pWorkOrderMatReqCategoryStatus
    Else
      rWorkOrderMatReqCategoryStatus = Nothing
    End If
    pWorkOrderMatReqCategoryStatus = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrderMatReqCategoryStatus(ByRef rWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus) As Boolean
    Dim mOK As Boolean
    pWorkOrderMatReqCategoryStatus = rWorkOrderMatReqCategoryStatus
    mOK = SaveObject()
    pWorkOrderMatReqCategoryStatus = Nothing
    Return mOK
  End Function

  Public Function LoadWorkOrderMatReqCategoryStatusCollectionByWhere(ByRef rWorkOrderMatReqCategoryStatuss As colWorkOrderMatReqCategoryStatuss, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWorkOrderMatReqCategoryStatuss, mParams, "WorkOrderMatReqCategoryStatusID", vWhere)
    rWorkOrderMatReqCategoryStatuss.TrackDeleted = True
    If mOK Then rWorkOrderMatReqCategoryStatuss.IsDirty = False
    Return mOK
  End Function

  Public Function LoadWorkOrderMatReqCategoryStatusCollection(ByRef rWorkOrderMatReqCategoryStatuss As colWorkOrderMatReqCategoryStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rWorkOrderMatReqCategoryStatuss, mParams, "WorkOrderMatReqCategoryStatusID")
    rWorkOrderMatReqCategoryStatuss.TrackDeleted = True
    If mOK Then rWorkOrderMatReqCategoryStatuss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderMatReqCategoryStatusCollection(ByRef rCollection As colWorkOrderMatReqCategoryStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWorkOrderMatReqCategoryStatus In rCollection
      ''    If pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrderMatReqCategoryStatus In rCollection.DeletedItems
          If pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrderMatReqCategoryStatus In rCollection
        If pWorkOrderMatReqCategoryStatus.IsDirty Or pWorkOrderMatReqCategoryStatus.WorkOrderID <> vWorkOrderID Or pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID = 0 Then 'Or pWorkOrderMatReqCategoryStatus.WorkOrderMatReqCategoryStatusID = 0
          pWorkOrderMatReqCategoryStatus.WorkOrderID = vWorkOrderID
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


