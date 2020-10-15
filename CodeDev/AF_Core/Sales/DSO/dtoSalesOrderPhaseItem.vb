
''DTO Definition - SalesOrderPhaseItem (to SalesOrderPhaseItem)'Generated from Table:SalesOrderPhaseItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderPhaseItem : Inherits dtoBase
  Private pSalesOrderPhaseItem As dmSalesOrderPhaseItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderPhaseItem"
    pKeyFieldName = "SalesOrderPhaseItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderPhaseItem.SalesOrderPhaseItemID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderPhaseItem.SalesOrderPhaseItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderPhaseItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderPhaseItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderPhaseItemID", pSalesOrderPhaseItem.SalesOrderPhaseItemID)
    End If
    With pSalesOrderPhaseItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseID", .SalesOrderPhaseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesItemID", .SalesItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Qty", .Qty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderPhaseItem Is Nothing Then SetObjectToNew()
      With pSalesOrderPhaseItem
        .SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .SalesItemID = DBReadInt32(rDataReader, "SalesItemID")
        .Qty = DBReadInt32(rDataReader, "Qty")
        pSalesOrderPhaseItem.IsDirty = False
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
    pSalesOrderPhaseItem = New dmSalesOrderPhaseItem ' Or .NewBlankSalesOrderPhaseItem
    Return pSalesOrderPhaseItem

  End Function


  Public Function LoadSalesOrderPhaseItem(ByRef rSalesOrderPhaseItem As dmSalesOrderPhaseItem, ByVal vSalesOrderPhaseItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderPhaseItemID)
    If mOK Then
      rSalesOrderPhaseItem = pSalesOrderPhaseItem
    Else
      rSalesOrderPhaseItem = Nothing
    End If
    pSalesOrderPhaseItem = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderPhaseItem(ByRef rSalesOrderPhaseItem As dmSalesOrderPhaseItem) As Boolean
    Dim mOK As Boolean
    pSalesOrderPhaseItem = rSalesOrderPhaseItem
    mOK = SaveObject()
    pSalesOrderPhaseItem = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderPhaseItemCollectionByWhere(ByRef rSalesOrderPhaseItems As colSalesOrderPhaseItems, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@SalesOrderPhaseID")
    mOK = MyBase.LoadCollection(rSalesOrderPhaseItems, mParams, "SalesOrderPhaseItemID", vWhere)
    rSalesOrderPhaseItems.TrackDeleted = True
    If mOK Then rSalesOrderPhaseItems.IsDirty = False
    Return mOK
  End Function
  Public Function LoadSalesOrderPhaseItemCollection(ByRef rSalesOrderPhaseItems As colSalesOrderPhaseItems, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
    mOK = MyBase.LoadCollection(rSalesOrderPhaseItems, mParams, "SalesOrderPhaseItemID")
    rSalesOrderPhaseItems.TrackDeleted = True
    If mOK Then rSalesOrderPhaseItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderPhaseItemCollection(ByRef rCollection As colSalesOrderPhaseItems, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderPhaseItem In rCollection
      ''    If pSalesOrderPhaseItem.SalesOrderPhaseItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderPhaseItem.SalesOrderPhaseItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderPhaseItem In rCollection.DeletedItems
          If pSalesOrderPhaseItem.SalesOrderPhaseItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderPhaseItem.SalesOrderPhaseItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderPhaseItem In rCollection
        If pSalesOrderPhaseItem.IsDirty Or pSalesOrderPhaseItem.SalesOrderPhaseID <> vSalesOrderPhaseID Or pSalesOrderPhaseItem.SalesOrderPhaseItemID = 0 Then 'Or pSalesOrderPhaseItem.SalesOrderPhaseItemID = 0
          pSalesOrderPhaseItem.SalesOrderPhaseID = vSalesOrderPhaseID
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


