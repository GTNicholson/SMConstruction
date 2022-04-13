''DTO Definition - MaintenanceWorkOrder (to MaintenanceWorkOrder)'Generated from Table:MaintenanceWorkOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaintenanceWorkOrder : Inherits dtoBase
  Private pMaintenanceWorkOrder As dmMaintenanceWorkOrder

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "MaintenanceWorkOrder"
    pKeyFieldName = "MaintenanceWorkOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaintenanceWorkOrder.MaintenanceWorkOrderID
    End Get
    Set(ByVal value As Integer)
      pMaintenanceWorkOrder.MaintenanceWorkOrderID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pMaintenanceWorkOrder.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pMaintenanceWorkOrder.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "MaintenanceWorkOrderID", pMaintenanceWorkOrder.MaintenanceWorkOrderID)
    End If
    With pMaintenanceWorkOrder
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaintenanceWorkOrderNo", StringToDBValue(.MaintenanceWorkOrderNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkCentreID", .WorkCentreID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaintenanceType", .MaintenanceType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EquipmentID", .EquipmentID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmployeeID", .EmployeeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Priority", .Priority)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PlannedDate", DateToDBValue(.PlannedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Duration", .Duration)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaintenanceWorkOrderDocument", StringToDBValue(.MaintenanceWorkOrderDocument))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pMaintenanceWorkOrder Is Nothing Then SetObjectToNew()
      With pMaintenanceWorkOrder
        .MaintenanceWorkOrderID = DBReadInt32(rDataReader, "MaintenanceWorkOrderID")
        .MaintenanceWorkOrderNo = DBReadString(rDataReader, "MaintenanceWorkOrderNo")
        .Description = DBReadString(rDataReader, "Description")
        .WorkCentreID = DBReadByte(rDataReader, "WorkCentreID")
        .MaintenanceType = DBReadByte(rDataReader, "MaintenanceType")
        .EquipmentID = DBReadInt32(rDataReader, "EquipmentID")
        .EmployeeID = DBReadInt32(rDataReader, "EmployeeID")
        .Priority = DBReadInt32(rDataReader, "Priority")
        .PlannedDate = DBReadDateTime(rDataReader, "PlannedDate")
        .Status = DBReadByte(rDataReader, "Status")
        .Duration = DBReadDecimal(rDataReader, "Duration")
        .Notes = DBReadString(rDataReader, "Notes")
        .MaintenanceWorkOrderDocument = DBReadString(rDataReader, "MaintenanceWorkOrderDocument")
        pMaintenanceWorkOrder.IsDirty = False
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
    pMaintenanceWorkOrder = New dmMaintenanceWorkOrder ' Or .NewBlankMaintenanceWorkOrder
    Return pMaintenanceWorkOrder

  End Function


  Public Function LoadMaintenanceWorkOrder(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder, ByVal vMaintenanceWorkOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vMaintenanceWorkOrderID)
    If mOK Then
      rMaintenanceWorkOrder = pMaintenanceWorkOrder
    Else
      rMaintenanceWorkOrder = Nothing
    End If
    pMaintenanceWorkOrder = Nothing
    Return mOK
  End Function


  Public Function SaveMaintenanceWorkOrder(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder) As Boolean
    Dim mOK As Boolean
    pMaintenanceWorkOrder = rMaintenanceWorkOrder
    mOK = SaveObject()
    pMaintenanceWorkOrder = Nothing
    Return mOK
  End Function


  Public Function LoadMaintenanceWorkOrderCollection(ByRef rMaintenanceWorkOrders As colMaintenanceWorkOrders) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rMaintenanceWorkOrders, mParams, "MaintenanceWorkOrderID")
    rMaintenanceWorkOrders.TrackDeleted = True
    If mOK Then rMaintenanceWorkOrders.IsDirty = False
    Return mOK
  End Function


  Public Function SaveMaintenanceWorkOrderCollection(ByRef rCollection As colMaintenanceWorkOrders) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pMaintenanceWorkOrder In rCollection
      ''    If pMaintenanceWorkOrder.MaintenanceWorkOrderID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pMaintenanceWorkOrder.MaintenanceWorkOrderID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pMaintenanceWorkOrder In rCollection.DeletedItems
          If pMaintenanceWorkOrder.MaintenanceWorkOrderID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pMaintenanceWorkOrder.MaintenanceWorkOrderID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pMaintenanceWorkOrder In rCollection
        If pMaintenanceWorkOrder.IsDirty Or pMaintenanceWorkOrder.MaintenanceWorkOrderID = 0 Then 'Or pMaintenanceWorkOrder.MaintenanceWorkOrderID = 0
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


