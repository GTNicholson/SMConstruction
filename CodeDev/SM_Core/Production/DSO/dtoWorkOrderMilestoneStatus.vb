
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrderMilestoneStatus : Inherits dtoBase
  Private pWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrderMilestoneStatus"
    pKeyFieldName = "WorkOrderMilestoneStatusID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID
    End Get
    Set(ByVal value As Integer)
      pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrderMilestoneStatus.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrderMilestoneStatus.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderMilestoneStatusID", pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID)
    End If
    With pWorkOrderMilestoneStatus
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MilestoneENUM", .MilestoneENUM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TargetDate", DateToDBValue(.TargetDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ActualDate", DateToDBValue(.ActualDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrderMilestoneStatus Is Nothing Then SetObjectToNew()
      With pWorkOrderMilestoneStatus
        .WorkOrderMilestoneStatusID = DBReadInt32(rDataReader, "WorkOrderMilestoneStatusID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .MilestoneENUM = DBReadByte(rDataReader, "MilestoneENUM")
        .Status = DBReadByte(rDataReader, "Status")
        .TargetDate = DBReadDateTime(rDataReader, "TargetDate")
        .ActualDate = DBReadDateTime(rDataReader, "ActualDate")
        .Notes = DBReadString(rDataReader, "Notes")
        pWorkOrderMilestoneStatus.IsDirty = False
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
    pWorkOrderMilestoneStatus = New dmWorkOrderMilestoneStatus ' Or .NewBlankWorkOrderMilestoneStatus
    Return pWorkOrderMilestoneStatus

  End Function


  Public Function LoadWorkOrderMilestoneStatus(ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus, ByVal vWorkOrderMilestoneStatusID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderMilestoneStatusID)
    If mOK Then
      rWorkOrderMilestoneStatus = pWorkOrderMilestoneStatus
    Else
      rWorkOrderMilestoneStatus = Nothing
    End If
    pWorkOrderMilestoneStatus = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrderMilestoneStatus(ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus) As Boolean
    Dim mOK As Boolean
    pWorkOrderMilestoneStatus = rWorkOrderMilestoneStatus
    mOK = SaveObject()
    pWorkOrderMilestoneStatus = Nothing
    Return mOK
  End Function


  Public Function LoadWorkOrderMilestoneStatusCollection(ByRef rWorkOrderMilestoneStatuss As colWorkOrderMilestoneStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rWorkOrderMilestoneStatuss, mParams, "WorkOrderMilestoneStatusID")
    rWorkOrderMilestoneStatuss.TrackDeleted = True
    If mOK Then rWorkOrderMilestoneStatuss.IsDirty = False
    Return mOK
  End Function

  Public Function LoadWorkOrderMilestoneStatusCollectionByWhere(ByRef rWorkOrderMilestoneStatuss As colWorkOrderMilestoneStatuss, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rWorkOrderMilestoneStatuss, mParams, "WorkOrderID, WorkOrderMilestoneStatusID", vWhere)
    rWorkOrderMilestoneStatuss.TrackDeleted = True
    If mOK Then rWorkOrderMilestoneStatuss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderMilestoneStatusCollection(ByRef rCollection As colWorkOrderMilestoneStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWorkOrderMilestoneStatus In rCollection
      ''    If pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrderMilestoneStatus In rCollection.DeletedItems
          If pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrderMilestoneStatus In rCollection
        If pWorkOrderMilestoneStatus.IsDirty Or pWorkOrderMilestoneStatus.WorkOrderID <> vWorkOrderID Or pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID = 0 Then 'Or pWorkOrderMilestoneStatus.WorkOrderMilestoneStatusID = 0
          pWorkOrderMilestoneStatus.WorkOrderID = vWorkOrderID
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
