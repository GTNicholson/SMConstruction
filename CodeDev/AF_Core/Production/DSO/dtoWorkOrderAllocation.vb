
''DTO Definition - WorkOrderAllocation (to WorkOrderAllocation)'Generated from Table:WorkOrderAllocation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrderAllocation : Inherits dtoBase
  Private pWorkOrderAllocation As dmWorkOrderAllocation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrderAllocation"
    pKeyFieldName = "WorkOrderAllocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderAllocation.WorkOrderAllocationID
    End Get
    Set(ByVal value As Integer)
      pWorkOrderAllocation.WorkOrderAllocationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrderAllocation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrderAllocation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderAllocationID", pWorkOrderAllocation.WorkOrderAllocationID)
    End If
    With pWorkOrderAllocation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseItemID", .SalesOrderPhaseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QuantityRequired", .QuantityRequired)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QuantityDone", .QuantityDone)



    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrderAllocation Is Nothing Then SetObjectToNew()
      With pWorkOrderAllocation
        .WorkOrderAllocationID = DBReadInt32(rDataReader, "WorkOrderAllocationID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
        .QuantityRequired = DBReadInt32(rDataReader, "QuantityRequired")
        .QuantityDone = DBReadInt32(rDataReader, "QuantityDone")


        pWorkOrderAllocation.IsDirty = False
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
    pWorkOrderAllocation = New dmWorkOrderAllocation ' Or .NewBlankWorkOrderAllocation
    Return pWorkOrderAllocation

  End Function


  Public Function LoadWorkOrderAllocation(ByRef rWorkOrderAllocation As dmWorkOrderAllocation, ByVal vWorkOrderAllocationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderAllocationID)
    If mOK Then
      rWorkOrderAllocation = pWorkOrderAllocation
    Else
      rWorkOrderAllocation = Nothing
    End If
    pWorkOrderAllocation = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrderAllocation(ByRef rWorkOrderAllocation As dmWorkOrderAllocation) As Boolean
    Dim mOK As Boolean
    pWorkOrderAllocation = rWorkOrderAllocation
    mOK = SaveObject()
    pWorkOrderAllocation = Nothing
    Return mOK
  End Function


  Public Function LoadWorkOrderAllocationCollection(ByRef rWorkOrderAllocations As colWorkOrderAllocations, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rWorkOrderAllocations, mParams, "WorkOrderAllocationID")
    rWorkOrderAllocations.TrackDeleted = True
    If mOK Then rWorkOrderAllocations.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderAllocationCollection(ByRef rCollection As colWorkOrderAllocations, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWorkOrderAllocation In rCollection
      ''    If pWorkOrderAllocation.WorkOrderAllocationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWorkOrderAllocation.WorkOrderAllocationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrderAllocation In rCollection.DeletedItems
          If pWorkOrderAllocation.WorkOrderAllocationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrderAllocation.WorkOrderAllocationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrderAllocation In rCollection
        If pWorkOrderAllocation.IsDirty Or pWorkOrderAllocation.WorkOrderID <> vWorkOrderID Or pWorkOrderAllocation.WorkOrderAllocationID = 0 Then 'Or pWorkOrderAllocation.WorkOrderAllocationID = 0
          pWorkOrderAllocation.WorkOrderID = vWorkOrderID
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

