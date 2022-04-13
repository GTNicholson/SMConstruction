''DTO Definition - MaintenanceWorkOrderItem (to MaintenanceWorkOrderItem)'Generated from Table:MaintenanceWorkOrderItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaintenanceWorkOrderItem : Inherits dtoBase
  Private pMaintenanceWorkOrderItem As dmMaintenanceWorkOrderItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "MaintenanceWorkOrderItem"
    pKeyFieldName = "MaintenanceWorkOrderItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID
    End Get
    Set(ByVal value As Integer)
      pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pMaintenanceWorkOrderItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pMaintenanceWorkOrderItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "MaintenanceWorkOrderItemID", pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID)
    End If
    With pMaintenanceWorkOrderItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaintenanceWorkOrderID", .MaintenanceWorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitCost", .UnitCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comments", StringToDBValue(.Comments))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pMaintenanceWorkOrderItem Is Nothing Then SetObjectToNew()
      With pMaintenanceWorkOrderItem
        .MaintenanceWorkOrderItemID = DBReadInt32(rDataReader, "MaintenanceWorkOrderItemID")
        .MaintenanceWorkOrderID = DBReadInt32(rDataReader, "MaintenanceWorkOrderID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .UnitCost = DBReadDecimal(rDataReader, "UnitCost")
        .Comments = DBReadString(rDataReader, "Comments")
        pMaintenanceWorkOrderItem.IsDirty = False
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
    pMaintenanceWorkOrderItem = New dmMaintenanceWorkOrderItem ' Or .NewBlankMaintenanceWorkOrderItem
    Return pMaintenanceWorkOrderItem

  End Function


  Public Function LoadMaintenanceWorkOrderItem(ByRef rMaintenanceWorkOrderItem As dmMaintenanceWorkOrderItem, ByVal vMaintenanceWorkOrderItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vMaintenanceWorkOrderItemID)
    If mOK Then
      rMaintenanceWorkOrderItem = pMaintenanceWorkOrderItem
    Else
      rMaintenanceWorkOrderItem = Nothing
    End If
    pMaintenanceWorkOrderItem = Nothing
    Return mOK
  End Function


  Public Function SaveMaintenanceWorkOrderItem(ByRef rMaintenanceWorkOrderItem As dmMaintenanceWorkOrderItem) As Boolean
    Dim mOK As Boolean
    pMaintenanceWorkOrderItem = rMaintenanceWorkOrderItem
    mOK = SaveObject()
    pMaintenanceWorkOrderItem = Nothing
    Return mOK
  End Function


  Public Function LoadMaintenanceWorkOrderItemCollection(ByRef rMaintenanceWorkOrderItems As colMaintenanceWorkOrderItems, ByVal vMaintenanceWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@MaintenanceWorkOrderID", vMaintenanceWorkOrderID)
    mOK = MyBase.LoadCollection(rMaintenanceWorkOrderItems, mParams, "MaintenanceWorkOrderItemID")
    rMaintenanceWorkOrderItems.TrackDeleted = True
    If mOK Then rMaintenanceWorkOrderItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveMaintenanceWorkOrderItemCollection(ByRef rCollection As colMaintenanceWorkOrderItems, ByVal vMaintenanceWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@MaintenanceWorkOrderID", vMaintenanceWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pMaintenanceWorkOrderItem In rCollection
      ''    If pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pMaintenanceWorkOrderItem In rCollection.DeletedItems
          If pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pMaintenanceWorkOrderItem In rCollection
        If pMaintenanceWorkOrderItem.IsDirty Or pMaintenanceWorkOrderItem.MaintenanceWorkOrderID <> vMaintenanceWorkOrderID Or pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID = 0 Then 'Or pMaintenanceWorkOrderItem.MaintenanceWorkOrderItemID = 0
          pMaintenanceWorkOrderItem.MaintenanceWorkOrderID = vMaintenanceWorkOrderID
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


