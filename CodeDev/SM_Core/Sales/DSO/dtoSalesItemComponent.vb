
''DTO Definition - SalesItemComponent (to SalesItemComponent)'Generated from Table:SalesItemComponent

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesItemComponent : Inherits dtoBase
  Private pSalesItemComponent As dmSalesItemComponent

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesItemComponent"
    pKeyFieldName = "SalesItemComponentID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesItemComponent.SalesItemComponentID
    End Get
    Set(ByVal value As Integer)
      pSalesItemComponent.SalesItemComponentID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesItemComponent.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesItemComponent.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesItemComponentID", pSalesItemComponent.SalesItemComponentID)
    End If
    With pSalesItemComponent
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderItemID", .SalesOrderItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderStageID", .SalesOrderStageID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesItemComponent Is Nothing Then SetObjectToNew()
      With pSalesItemComponent
        .SalesItemComponentID = DBReadInt32(rDataReader, "SalesItemComponentID")
        .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .SalesOrderStageID = DBReadInt32(rDataReader, "SalesOrderStageID")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        pSalesItemComponent.IsDirty = False
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
    pSalesItemComponent = New dmSalesItemComponent ' Or .NewBlankSalesItemComponent
    Return pSalesItemComponent

  End Function


  Public Function LoadSalesItemComponent(ByRef rSalesItemComponent As dmSalesItemComponent, ByVal vSalesItemComponentID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesItemComponentID)
    If mOK Then
      rSalesItemComponent = pSalesItemComponent
    Else
      rSalesItemComponent = Nothing
    End If
    pSalesItemComponent = Nothing
    Return mOK
  End Function


  Public Function SaveSalesItemComponent(ByRef rSalesItemComponent As dmSalesItemComponent) As Boolean
    Dim mOK As Boolean
    pSalesItemComponent = rSalesItemComponent
    mOK = SaveObject()
    pSalesItemComponent = Nothing
    Return mOK
  End Function


  Public Function LoadSalesItemComponentCollection(ByRef rSalesItemComponents As colSalesItemComponents, ByVal vSalesOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderItemID", vSalesOrderItemID)
    mOK = MyBase.LoadCollection(rSalesItemComponents, mParams, "SalesItemComponentID")
    rSalesItemComponents.TrackDeleted = True
    If mOK Then rSalesItemComponents.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesItemComponentCollection(ByRef rCollection As colSalesItemComponents, ByVal vSalesOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderItemID", vSalesOrderItemID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesItemComponent In rCollection
      ''    If pSalesItemComponent.SalesItemComponentID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesItemComponent.SalesItemComponentID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesItemComponent In rCollection.DeletedItems
          If pSalesItemComponent.SalesItemComponentID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesItemComponent.SalesItemComponentID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesItemComponent In rCollection
        If pSalesItemComponent.IsDirty Or pSalesItemComponent.SalesOrderItemID <> vSalesOrderItemID Or pSalesItemComponent.SalesItemComponentID = 0 Then 'Or pSalesItemComponent.SalesItemComponentID = 0
          pSalesItemComponent.SalesOrderItemID = vSalesOrderItemID
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

