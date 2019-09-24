
''DTO Definition - WorkOrderBatch (to WorkOrderBatch)'Generated from Table:WorkOrderBatch

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrderBatch : Inherits dtoBase
  Private pWorkOrderBatch As dmWorkOrderBatch

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrderBatch"
    pKeyFieldName = "WorkOrderBatchID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderBatch.WorkOrderBatchID
    End Get
    Set(ByVal value As Integer)
      pWorkOrderBatch.WorkOrderBatchID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrderBatch.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrderBatch.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderBatchID", pWorkOrderBatch.WorkOrderBatchID)
    End If
    With pWorkOrderBatch
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Ref", StringToDBValue(.Ref))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PlannedStartDate", DateToDBValue(.PlannedStartDate))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrderBatch Is Nothing Then SetObjectToNew()
      With pWorkOrderBatch
        .WorkOrderBatchID = DBReadInt32(rDataReader, "WorkOrderBatchID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .Ref = DBReadString(rDataReader, "Ref")
        .PlannedStartDate = DBReadDateTime(rDataReader, "PlannedStartDate")
        pWorkOrderBatch.IsDirty = False
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
    pWorkOrderBatch = New dmWorkOrderBatch ' Or .NewBlankWorkOrderBatch
    Return pWorkOrderBatch

  End Function


  Public Function LoadWorkOrderBatch(ByRef rWorkOrderBatch As dmWorkOrderBatch, ByVal vWorkOrderBatchID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderBatchID)
    If mOK Then
      rWorkOrderBatch = pWorkOrderBatch
    Else
      rWorkOrderBatch = Nothing
    End If
    pWorkOrderBatch = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrderBatch(ByRef rWorkOrderBatch As dmWorkOrderBatch) As Boolean
    Dim mOK As Boolean
    pWorkOrderBatch = rWorkOrderBatch
    mOK = SaveObject()
    pWorkOrderBatch = Nothing
    Return mOK
  End Function


  Public Function LoadWorkOrderBatchCollection(ByRef rWorkOrderBatchs As colWorkOrderBatchs, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vParentID)
    mOK = MyBase.LoadCollection(rWorkOrderBatchs, mParams, "WorkOrderBatchID")
    rWorkOrderBatchs.TrackDeleted = True
    If mOK Then rWorkOrderBatchs.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderBatchCollection(ByRef rCollection As colWorkOrderBatchs, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vParentID)

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrderBatch In rCollection.DeletedItems
          If pWorkOrderBatch.WorkOrderBatchID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrderBatch.WorkOrderBatchID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrderBatch In rCollection
        If pWorkOrderBatch.IsDirty Or pWorkOrderBatch.WorkOrderID <> vParentID Or pWorkOrderBatch.WorkOrderBatchID = 0 Then 'Or pWorkOrderBatch.WorkOrderBatchID = 0
          pWorkOrderBatch.WorkOrderID = vParentID
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


