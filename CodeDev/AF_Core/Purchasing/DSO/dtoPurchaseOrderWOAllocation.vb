''DTO Definition - PurchaseOrderWOAllocation (to PurchaseOrderWOAllocation)'Generated from Table:PurchaseOrderWOAllocation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderWOAllocation : Inherits dtoBase
  Private pPurchaseOrderWOAllocation As dmPurchaseOrderWOAllocation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PurchaseOrderWOAllocation"
    pKeyFieldName = "PurchaseOrderWOAllocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPurchaseOrderWOAllocation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPurchaseOrderWOAllocation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PurchaseOrderWOAllocationID", pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID)
    End If
    With pPurchaseOrderWOAllocation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseOrderID", .PurchaseOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPurchaseOrderWOAllocation Is Nothing Then SetObjectToNew()
      With pPurchaseOrderWOAllocation
        .PurchaseOrderWOAllocationID = DBReadInt32(rDataReader, "PurchaseOrderWOAllocationID")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        pPurchaseOrderWOAllocation.IsDirty = False
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
    pPurchaseOrderWOAllocation = New dmPurchaseOrderWOAllocation ' Or .NewBlankPurchaseOrderWOAllocation
    Return pPurchaseOrderWOAllocation

  End Function


  Public Function LoadPurchaseOrderWOAllocation(ByRef rPurchaseOrderWOAllocation As dmPurchaseOrderWOAllocation, ByVal vPurchaseOrderWOAllocationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderWOAllocationID)
    If mOK Then
      rPurchaseOrderWOAllocation = pPurchaseOrderWOAllocation
    Else
      rPurchaseOrderWOAllocation = Nothing
    End If
    pPurchaseOrderWOAllocation = Nothing
    Return mOK
  End Function


  Public Function SavePurchaseOrderWOAllocation(ByRef rPurchaseOrderWOAllocation As dmPurchaseOrderWOAllocation) As Boolean
    Dim mOK As Boolean
    pPurchaseOrderWOAllocation = rPurchaseOrderWOAllocation
    mOK = SaveObject()
    pPurchaseOrderWOAllocation = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderWOAllocationCollection(ByRef rPurchaseOrderWOAllocations As colPurchaseOrderWOAllocations, ByVal vPurchaseOrderID As Integer, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
    mParams.Add("@WorkOrderID", vWorkOrderID)

    mOK = MyBase.LoadCollection(rPurchaseOrderWOAllocations, mParams, "PurchaseOrderWOAllocationID")
    rPurchaseOrderWOAllocations.TrackDeleted = True
    If mOK Then rPurchaseOrderWOAllocations.IsDirty = False
    Return mOK
  End Function


  Public Function SavePurchaseOrderWOAllocationCollection(ByRef rCollection As colPurchaseOrderWOAllocations, ByVal vPurchaseOrderID As Integer, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
      mParams.Add("@WorkOrderID", vWorkOrderID)

      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPurchaseOrderWOAllocation In rCollection
      ''    If pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPurchaseOrderWOAllocation In rCollection.DeletedItems
          If pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPurchaseOrderWOAllocation In rCollection
        If pPurchaseOrderWOAllocation.IsDirty Or pPurchaseOrderWOAllocation.PurchaseOrderID <> vPurchaseOrderID Or pPurchaseOrderWOAllocation.WorkOrderID <> vWorkOrderID Or pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID = 0 Then 'Or pPurchaseOrderWOAllocation.PurchaseOrderWOAllocationID = 0
          pPurchaseOrderWOAllocation.PurchaseOrderID = vPurchaseOrderID
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


