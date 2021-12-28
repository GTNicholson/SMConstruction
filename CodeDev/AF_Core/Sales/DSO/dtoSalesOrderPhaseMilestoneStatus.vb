''DTO Definition - SalesOrderPhaseMilestoneStatus (to SalesOrderPhaseMilestoneStatus)'Generated from Table:SalesOrderPhaseMilestoneStatus

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderPhaseMilestoneStatus : Inherits dtoBase
  Private pSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderPhaseMilestoneStatus"
    pKeyFieldName = "SalesOrderPhaseMilestoneStatusID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderPhaseMilestoneStatus.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderPhaseMilestoneStatus.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderPhaseMilestoneStatusID", pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID)
    End If
    With pSalesOrderPhaseMilestoneStatus
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseID", .SalesOrderPhaseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MilestoneENUM", .MilestoneENUM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TargetDate", DateToDBValue(.TargetDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ActualDate", DateToDBValue(.ActualDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StartDate", DateToDBValue(.StartDate))

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ManReqDays", .ManReqDays)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderPhaseMilestoneStatus Is Nothing Then SetObjectToNew()
      With pSalesOrderPhaseMilestoneStatus
        .SalesOrderPhaseMilestoneStatusID = DBReadInt32(rDataReader, "SalesOrderPhaseMilestoneStatusID")
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .MilestoneENUM = DBReadByte(rDataReader, "MilestoneENUM")
        .Status = DBReadByte(rDataReader, "Status")
        .TargetDate = DBReadDateTime(rDataReader, "TargetDate")
        .ActualDate = DBReadDateTime(rDataReader, "ActualDate")
        .StartDate = DBReadDateTime(rDataReader, "StartDate")
        .ManReqDays = DBReadInt32(rDataReader, "ManReqDays")
        .Notes = DBReadString(rDataReader, "Notes")
        pSalesOrderPhaseMilestoneStatus.IsDirty = False
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
    pSalesOrderPhaseMilestoneStatus = New dmSalesOrderPhaseMilestoneStatus ' Or .NewBlankSalesOrderPhaseMilestoneStatus
    Return pSalesOrderPhaseMilestoneStatus

  End Function


  Public Function LoadSalesOrderPhaseMilestoneStatus(ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus, ByVal vSalesOrderPhaseMilestoneStatusID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderPhaseMilestoneStatusID)
    If mOK Then
      rSalesOrderPhaseMilestoneStatus = pSalesOrderPhaseMilestoneStatus
    Else
      rSalesOrderPhaseMilestoneStatus = Nothing
    End If
    pSalesOrderPhaseMilestoneStatus = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderPhaseMilestoneStatus(ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus) As Boolean
    Dim mOK As Boolean
    pSalesOrderPhaseMilestoneStatus = rSalesOrderPhaseMilestoneStatus
    mOK = SaveObject()
    pSalesOrderPhaseMilestoneStatus = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderPhaseMilestoneStatusCollection(ByRef rSalesOrderPhaseMilestoneStatuss As colSalesOrderPhaseMilestoneStatuss, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
    mOK = MyBase.LoadCollection(rSalesOrderPhaseMilestoneStatuss, mParams, "SalesOrderPhaseMilestoneStatusID")
    rSalesOrderPhaseMilestoneStatuss.TrackDeleted = True
    If mOK Then rSalesOrderPhaseMilestoneStatuss.IsDirty = False
    Return mOK
  End Function

  Public Function LoadSalesOrderPhaseMilestoneStatusCollectionByWhere(ByRef rSalesOrderPhaseMilestoneStatuss As colSalesOrderPhaseMilestoneStatuss, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rSalesOrderPhaseMilestoneStatuss, mParams, "SalesOrderPhaseID, SalesOrderPhaseMilestoneStatusID", vWhere)
    rSalesOrderPhaseMilestoneStatuss.TrackDeleted = True
    If mOK Then rSalesOrderPhaseMilestoneStatuss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderPhaseMilestoneStatusCollection(ByRef rCollection As colSalesOrderPhaseMilestoneStatuss, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderPhaseMilestoneStatus In rCollection
      ''    If pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderPhaseMilestoneStatus In rCollection.DeletedItems
          If pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderPhaseMilestoneStatus In rCollection
        If pSalesOrderPhaseMilestoneStatus.IsDirty Or pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID <> vSalesOrderPhaseID Or pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID = 0 Then 'Or pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseMilestoneStatusID = 0
          pSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID = vSalesOrderPhaseID
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

