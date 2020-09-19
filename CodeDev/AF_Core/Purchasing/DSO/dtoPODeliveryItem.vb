''DTO Definition - PODeliveryItem (to PODeliveryItem)'Generated from Table:PODeliveryItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPODeliveryItem : Inherits dtoBase
  Private pPODeliveryItem As dmPODeliveryItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PODeliveryItem"
    pKeyFieldName = "PODeliveryItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPODeliveryItem.PODeliveryItemID
    End Get
    Set(ByVal value As Integer)
      pPODeliveryItem.PODeliveryItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPODeliveryItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPODeliveryItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PODeliveryItemID", pPODeliveryItem.PODeliveryItemID)
    End If
    With pPODeliveryItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PODeliveryID", .PODeliveryID)
      '  DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "POCallOffItemID", .POCallOffItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "POItemAllocationID", .POItemAllocationID)
      ' DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyReceived", .QtyReceived)
      ''DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyInvoiced", .QtyInvoiced)
      '' DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReplacementQty", .ReplacementQty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPODeliveryItem Is Nothing Then SetObjectToNew()
      With pPODeliveryItem
        .PODeliveryItemID = DBReadInt32(rDataReader, "PODeliveryItemID")
        .PODeliveryID = DBReadInt32(rDataReader, "PODeliveryID")
        '  .POCallOffItemID = DBReadInt32(rDataReader, "POCallOffItemID")
        .POItemAllocationID = DBReadInt32(rDataReader, "POItemAllocationID")
        .SetQtyReceived(DBReadDecimal(rDataReader, "QtyReceived"))
        .SetQtyRejected(DBReadDecimal(rDataReader, "QtyRejected"))
        ''.QtyInvoiced = DBReadDecimal(rDataReader, "QtyInvoiced")
        pPODeliveryItem.IsDirty = False
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
    pPODeliveryItem = New dmPODeliveryItem ' Or .NewBlankPODeliveryItem
    Return pPODeliveryItem

  End Function


  Public Function LoadPODeliveryItem(ByRef rPODeliveryItem As dmPODeliveryItem, ByVal vPODeliveryItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPODeliveryItemID)
    If mOK Then
      rPODeliveryItem = pPODeliveryItem
    Else
      rPODeliveryItem = Nothing
    End If
    pPODeliveryItem = Nothing
    Return mOK
  End Function


  Public Function SavePODeliveryItem(ByRef rPODeliveryItem As dmPODeliveryItem) As Boolean
    Dim mOK As Boolean
    pPODeliveryItem = rPODeliveryItem
    mOK = SaveObject()
    pPODeliveryItem = Nothing
    Return mOK
  End Function


  Public Function LoadPODeliveryItemCollection(ByRef rPODeliveryItems As colPODeliveryItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PODeliveryID", vParentID)
    mOK = MyBase.LoadCollection(rPODeliveryItems, mParams, "PODeliveryItemID")
    rPODeliveryItems.TrackDeleted = True
    If mOK Then rPODeliveryItems.IsDirty = False
    Return mOK
  End Function


  Public Function SavePODeliveryItemCollection(ByRef rCollection As colPODeliveryItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PODeliveryID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPODeliveryItem In rCollection
      ''    If pPODeliveryItem.PODeliveryItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPODeliveryItem.PODeliveryItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPODeliveryItem In rCollection.DeletedItems
          If pPODeliveryItem.PODeliveryItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPODeliveryItem.PODeliveryItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPODeliveryItem In rCollection
        If pPODeliveryItem.IsDirty Or pPODeliveryItem.PODeliveryID <> vParentID Or pPODeliveryItem.PODeliveryItemID = 0 Then 'Or pPODeliveryItem.PODeliveryItemID = 0
          pPODeliveryItem.PODeliveryID = vParentID
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


