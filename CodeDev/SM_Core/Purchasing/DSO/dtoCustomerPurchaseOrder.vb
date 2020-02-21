Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoCustomerPurchaseOrder : Inherits dtoBase
  Private pCustomerPurchaseOrder As dmCustomerPurchaseOrder

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "CustomerPurchaseOrder"
    pKeyFieldName = "CustomerPurchaseOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pCustomerPurchaseOrder.CustomerPurchaseOrderID
    End Get
    Set(ByVal value As Integer)
      pCustomerPurchaseOrder.CustomerPurchaseOrderID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pCustomerPurchaseOrder.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pCustomerPurchaseOrder.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "CustomerPurchaseOrderID", pCustomerPurchaseOrder.CustomerPurchaseOrderID)
    End If
    With pCustomerPurchaseOrder
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderNo", StringToDBValue(.OrderNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderDate", DateToDBValue(.OrderDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderValue", .OrderValue)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pCustomerPurchaseOrder Is Nothing Then SetObjectToNew()
      With pCustomerPurchaseOrder
        .CustomerPurchaseOrderID = DBReadInt32(rDataReader, "CustomerPurchaseOrderID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .OrderDate = DBReadDateTime(rDataReader, "OrderDate")
        .OrderValue = DBReadDecimal(rDataReader, "OrderValue")
        pCustomerPurchaseOrder.IsDirty = False
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
    pCustomerPurchaseOrder = New dmCustomerPurchaseOrder ' Or .NewBlankCustomerPurchaseOrder
    Return pCustomerPurchaseOrder

  End Function


  Public Function LoadCustomerPurchaseOrder(ByRef rCustomerPurchaseOrder As dmCustomerPurchaseOrder, ByVal vCustomerPurchaseOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vCustomerPurchaseOrderID)
    If mOK Then
      rCustomerPurchaseOrder = pCustomerPurchaseOrder
    Else
      rCustomerPurchaseOrder = Nothing
    End If
    pCustomerPurchaseOrder = Nothing
    Return mOK
  End Function


  Public Function SaveCustomerPurchaseOrder(ByRef rCustomerPurchaseOrder As dmCustomerPurchaseOrder) As Boolean
    Dim mOK As Boolean
    pCustomerPurchaseOrder = rCustomerPurchaseOrder
    mOK = SaveObject()
    pCustomerPurchaseOrder = Nothing
    Return mOK
  End Function


  Public Function LoadCustomerPurchaseOrderCollection(ByRef rCustomerPurchaseOrders As colCustomerPurchaseOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vParentID)
    mOK = MyBase.LoadCollection(rCustomerPurchaseOrders, mParams, "CustomerPurchaseOrderID")
    rCustomerPurchaseOrders.TrackDeleted = True
    If mOK Then rCustomerPurchaseOrders.IsDirty = False
    Return mOK
  End Function


  Public Function SaveCustomerPurchaseOrderCollection(ByRef rCollection As colCustomerPurchaseOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pCustomerPurchaseOrder In rCollection
      ''    If pCustomerPurchaseOrder.CustomerPurchaseOrderID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pCustomerPurchaseOrder.CustomerPurchaseOrderID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pCustomerPurchaseOrder In rCollection.DeletedItems
          If pCustomerPurchaseOrder.CustomerPurchaseOrderID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pCustomerPurchaseOrder.CustomerPurchaseOrderID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pCustomerPurchaseOrder In rCollection
        If pCustomerPurchaseOrder.IsDirty Or pCustomerPurchaseOrder.SalesOrderID <> vParentID Or pCustomerPurchaseOrder.CustomerPurchaseOrderID = 0 Then 'Or pCustomerPurchaseOrder.CustomerPurchaseOrderID = 0
          pCustomerPurchaseOrder.SalesOrderID = vParentID
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


