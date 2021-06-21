''DTO Definition - WorkOrderPickStatus (to WorkOrderPickStatus)'Generated from Table:WorkOrderPickStatus

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrderPickStatus : Inherits dtoBase
  Private pWorkOrderPickStatus As dmWorkOrderPickStatus

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrderPickStatus"
    pKeyFieldName = "WorkOrderPickStatusID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderPickStatus.WorkOrderPickStatusID
    End Get
    Set(ByVal value As Integer)
      pWorkOrderPickStatus.WorkOrderPickStatusID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrderPickStatus.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrderPickStatus.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderPickStatusID", pWorkOrderPickStatus.WorkOrderPickStatusID)
    End If
    With pWorkOrderPickStatus
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MatReqCategory", .MatReqCategory)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TargetDate", DateToDBValue(.TargetDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LastDate", DateToDBValue(.LastDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickStatus", .PickStatus)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrderPickStatus Is Nothing Then SetObjectToNew()
      With pWorkOrderPickStatus
        .WorkOrderPickStatusID = DBReadInt32(rDataReader, "WorkOrderPickStatusID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .MatReqCategory = DBReadByte(rDataReader, "MatReqCategory")
        .TargetDate = DBReadDateTime(rDataReader, "TargetDate")
        .LastDate = DBReadDateTime(rDataReader, "LastDate")
        .Notes = DBReadString(rDataReader, "Notes")
        .PickStatus = DBReadByte(rDataReader, "PickStatus")
        pWorkOrderPickStatus.IsDirty = False
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
    pWorkOrderPickStatus = New dmWorkOrderPickStatus ' Or .NewBlankWorkOrderPickStatus
    Return pWorkOrderPickStatus

  End Function


  Public Function LoadWorkOrderPickStatus(ByRef rWorkOrderPickStatus As dmWorkOrderPickStatus, ByVal vWorkOrderPickStatusID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderPickStatusID)
    If mOK Then
      rWorkOrderPickStatus = pWorkOrderPickStatus
    Else
      rWorkOrderPickStatus = Nothing
    End If
    pWorkOrderPickStatus = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrderPickStatus(ByRef rWorkOrderPickStatus As dmWorkOrderPickStatus) As Boolean
    Dim mOK As Boolean
    pWorkOrderPickStatus = rWorkOrderPickStatus
    mOK = SaveObject()
    pWorkOrderPickStatus = Nothing
    Return mOK
  End Function


  Public Function LoadWorkOrderPickStatusCollection(ByRef rWorkOrderPickStatuss As colWorkOrderPickStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rWorkOrderPickStatuss, mParams, "WorkOrderPickStatusID")
    rWorkOrderPickStatuss.TrackDeleted = True
    If mOK Then rWorkOrderPickStatuss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderPickStatusCollection(ByRef rCollection As colWorkOrderPickStatuss, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWorkOrderPickStatus In rCollection
      ''    If pWorkOrderPickStatus.WorkOrderPickStatusID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWorkOrderPickStatus.WorkOrderPickStatusID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrderPickStatus In rCollection.DeletedItems
          If pWorkOrderPickStatus.WorkOrderPickStatusID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrderPickStatus.WorkOrderPickStatusID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrderPickStatus In rCollection
        If pWorkOrderPickStatus.IsDirty Or pWorkOrderPickStatus.WorkOrderPickStatusID = 0 Then 'Or pWorkOrderPickStatus.WorkOrderPickStatusID = 0
          pWorkOrderPickStatus.WorkOrderID = vWorkOrderID
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
