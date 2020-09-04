''DTO Definition - PhaseItemComponent (to PhaseItemComponent)'Generated from Table:PhaseItemComponent

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPhaseItemComponent : Inherits dtoBase
  Private pPhaseItemComponent As dmPhaseItemComponent

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PhaseItemComponent"
    pKeyFieldName = "PhaseItemComponentID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPhaseItemComponent.PhaseItemComponentID
    End Get
    Set(ByVal value As Integer)
      pPhaseItemComponent.PhaseItemComponentID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPhaseItemComponent.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPhaseItemComponent.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PhaseItemComponentID", pPhaseItemComponent.PhaseItemComponentID)
    End If
    With pPhaseItemComponent
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseID", .SalesOrderPhaseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPhaseItemComponent Is Nothing Then SetObjectToNew()
      With pPhaseItemComponent
        .PhaseItemComponentID = DBReadInt32(rDataReader, "PhaseItemComponentID")
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        pPhaseItemComponent.IsDirty = False
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
    pPhaseItemComponent = New dmPhaseItemComponent ' Or .NewBlankPhaseItemComponent
    Return pPhaseItemComponent

  End Function


  Public Function LoadPhaseItemComponent(ByRef rPhaseItemComponent As dmPhaseItemComponent, ByVal vPhaseItemComponentID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPhaseItemComponentID)
    If mOK Then
      rPhaseItemComponent = pPhaseItemComponent
    Else
      rPhaseItemComponent = Nothing
    End If
    pPhaseItemComponent = Nothing
    Return mOK
  End Function


  Public Function SavePhaseItemComponent(ByRef rPhaseItemComponent As dmPhaseItemComponent) As Boolean
    Dim mOK As Boolean
    pPhaseItemComponent = rPhaseItemComponent
    mOK = SaveObject()
    pPhaseItemComponent = Nothing
    Return mOK
  End Function


  Public Function LoadPhaseItemComponentCollection(ByRef rPhaseItemComponents As colPhaseItemComponents, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
    mOK = MyBase.LoadCollection(rPhaseItemComponents, mParams, "PhaseItemComponentID")
    rPhaseItemComponents.TrackDeleted = True
    If mOK Then rPhaseItemComponents.IsDirty = False
    Return mOK
  End Function


  Public Function SavePhaseItemComponentCollection(ByRef rCollection As colPhaseItemComponents, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPhaseItemComponent In rCollection
      ''    If pPhaseItemComponent.PhaseItemComponentID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPhaseItemComponent.PhaseItemComponentID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPhaseItemComponent In rCollection.DeletedItems
          If pPhaseItemComponent.PhaseItemComponentID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPhaseItemComponent.PhaseItemComponentID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPhaseItemComponent In rCollection
        If pPhaseItemComponent.IsDirty Or pPhaseItemComponent.SalesOrderPhaseID <> vSalesOrderPhaseID Or pPhaseItemComponent.PhaseItemComponentID = 0 Then 'Or pPhaseItemComponent.PhaseItemComponentID = 0
          pPhaseItemComponent.SalesOrderPhaseID = vSalesOrderPhaseID
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

