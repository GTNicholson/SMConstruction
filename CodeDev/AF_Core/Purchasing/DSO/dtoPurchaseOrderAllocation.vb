''DTO Definition - PurchaseOrderAllocation (to PurchaseOrderAllocation)'Generated from Table:PurchaseOrderAllocation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderAllocation : Inherits dtoBase
  Private pPurchaseOrderAllocation As dmPurchaseOrderAllocation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PurchaseOrderAllocation"
    pKeyFieldName = "PurchaseOrderAllocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderAllocation.PurchaseOrderAllocationID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderAllocation.PurchaseOrderAllocationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPurchaseOrderAllocation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPurchaseOrderAllocation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PurchaseOrderAllocationID", pPurchaseOrderAllocation.PurchaseOrderAllocationID)
    End If
    With pPurchaseOrderAllocation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseOrderID", .PurchaseOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CallOffID", .CallOffID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesorderPhaseItemID", .SalesorderPhaseItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaintenanceWorkOrderID", .MaintenanceWorkOrderID)



    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPurchaseOrderAllocation Is Nothing Then SetObjectToNew()
      With pPurchaseOrderAllocation
        .PurchaseOrderAllocationID = DBReadInt32(rDataReader, "PurchaseOrderAllocationID")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .CallOffID = DBReadInt32(rDataReader, "CallOffID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .SalesorderPhaseItemID = DBReadInt32(rDataReader, "SalesorderPhaseItemID")
        .MaintenanceWorkOrderID = DBReadInt32(rDataReader, "MaintenanceWorkOrderID")
        pPurchaseOrderAllocation.IsDirty = False
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
    pPurchaseOrderAllocation = New dmPurchaseOrderAllocation ' Or .NewBlankPurchaseOrderAllocation
    Return pPurchaseOrderAllocation

  End Function


  Public Function LoadPurchaseOrderAllocation(ByRef rPurchaseOrderAllocation As dmPurchaseOrderAllocation, ByVal vPurchaseOrderAllocationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderAllocationID)
    If mOK Then
      rPurchaseOrderAllocation = pPurchaseOrderAllocation
    Else
      rPurchaseOrderAllocation = Nothing
    End If
    pPurchaseOrderAllocation = Nothing
    Return mOK
  End Function


  Public Function SavePurchaseOrderAllocation(ByRef rPurchaseOrderAllocation As dmPurchaseOrderAllocation) As Boolean
    Dim mOK As Boolean
    pPurchaseOrderAllocation = rPurchaseOrderAllocation
    mOK = SaveObject()
    pPurchaseOrderAllocation = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderAllocationCollection(ByRef rPurchaseOrderAllocations As colPurchaseOrderAllocations, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
    mOK = MyBase.LoadCollection(rPurchaseOrderAllocations, mParams, "PurchaseOrderAllocationID")
    rPurchaseOrderAllocations.TrackDeleted = True
    If mOK Then rPurchaseOrderAllocations.IsDirty = False
    Return mOK
  End Function


  Public Function SavePurchaseOrderAllocationCollection(ByRef rCollection As colPurchaseOrderAllocations, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPurchaseOrderAllocation In rCollection
      ''    If pPurchaseOrderAllocation.PurchaseOrderAllocationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPurchaseOrderAllocation.PurchaseOrderAllocationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPurchaseOrderAllocation In rCollection.DeletedItems
          If pPurchaseOrderAllocation.PurchaseOrderAllocationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPurchaseOrderAllocation.PurchaseOrderAllocationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPurchaseOrderAllocation In rCollection
        If pPurchaseOrderAllocation.IsDirty Or pPurchaseOrderAllocation.PurchaseOrderID <> vPurchaseOrderID Or pPurchaseOrderAllocation.PurchaseOrderAllocationID = 0 Then 'Or pPurchaseOrderAllocation.PurchaseOrderAllocationID = 0
          pPurchaseOrderAllocation.PurchaseOrderID = vPurchaseOrderID
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

  Public Function LoadPurchaseOrderAllocationCollectionByWhere(ByRef rPurchaseOrderAllocations As colPurchaseOrderAllocations, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rPurchaseOrderAllocations, mParams, "PurchaseOrderAllocationID", vWhere)
    rPurchaseOrderAllocations.TrackDeleted = True
    If mOK Then rPurchaseOrderAllocations.IsDirty = False
    Return mOK
  End Function
End Class