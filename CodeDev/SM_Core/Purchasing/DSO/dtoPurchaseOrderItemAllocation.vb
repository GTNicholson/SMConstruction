
''DTO Definition - PurchaseOrderItemAllocation (to PurchaseOrderItemAllocation)'Generated from Table:PurchaseOrderItemAllocation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderItemAllocation : Inherits dtoBase
  Private pPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PurchaseOrderItemAllocation"
    pKeyFieldName = "PurchaseOrderItemAllocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPurchaseOrderItemAllocation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPurchaseOrderItemAllocation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PurchaseOrderItemAllocationID", pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID)
    End If
    With pPurchaseOrderItemAllocation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseOrderItemID", .PurchaseOrderItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CallOffID", .CallOffID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReceivedQty", .ReceivedQty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPurchaseOrderItemAllocation Is Nothing Then SetObjectToNew()
      With pPurchaseOrderItemAllocation
        .PurchaseOrderItemAllocationID = DBReadInt32(rDataReader, "PurchaseOrderItemAllocationID")
        .PurchaseOrderItemID = DBReadInt32(rDataReader, "PurchaseOrderItemID")
        .CallOffID = DBReadInt32(rDataReader, "CallOffID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .ReceivedQty = DBReadDecimal(rDataReader, "ReceivedQty")
        pPurchaseOrderItemAllocation.IsDirty = False
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
    pPurchaseOrderItemAllocation = New dmPurchaseOrderItemAllocation ' Or .NewBlankPurchaseOrderItemAllocation
    Return pPurchaseOrderItemAllocation

  End Function


  Public Function LoadPurchaseOrderItemAllocation(ByRef rPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation, ByVal vPurchaseOrderItemAllocationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderItemAllocationID)
    If mOK Then
      rPurchaseOrderItemAllocation = pPurchaseOrderItemAllocation
    Else
      rPurchaseOrderItemAllocation = Nothing
    End If
    pPurchaseOrderItemAllocation = Nothing
    Return mOK
  End Function


  Public Function SavePurchaseOrderItemAllocation(ByRef rPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation) As Boolean
    Dim mOK As Boolean
    pPurchaseOrderItemAllocation = rPurchaseOrderItemAllocation
    mOK = SaveObject()
    pPurchaseOrderItemAllocation = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderItemAllocationCollection(ByRef rPurchaseOrderItemAllocations As colPurchaseOrderItemAllocations, ByVal vPurchaseOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PurchaseOrderItemID", vPurchaseOrderItemID)
    mOK = MyBase.LoadCollection(rPurchaseOrderItemAllocations, mParams, "PurchaseOrderItemAllocationID")
    rPurchaseOrderItemAllocations.TrackDeleted = True
    If mOK Then rPurchaseOrderItemAllocations.IsDirty = False
    Return mOK
  End Function


  Public Function SavePurchaseOrderItemAllocationCollection(ByRef rCollection As colPurchaseOrderItemAllocations, ByVal vPurchaseOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PurchaseOrderItemID", vPurchaseOrderItemID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPurchaseOrderItemAllocation In rCollection
      ''    If pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPurchaseOrderItemAllocation In rCollection.DeletedItems
          If pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPurchaseOrderItemAllocation In rCollection
        If pPurchaseOrderItemAllocation.IsDirty Or pPurchaseOrderItemAllocation.PurchaseOrderItemID <> vPurchaseOrderItemID Or pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID = 0 Then 'Or pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID = 0
          pPurchaseOrderItemAllocation.PurchaseOrderItemID = vPurchaseOrderItemID
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



