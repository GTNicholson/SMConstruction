''DTO Definition - SalesOrderStage (to SalesOrderStage)'Generated from Table:SalesOrderStage

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderStage : Inherits dtoBase
  Private pSalesOrderStage As dmSalesOrderStage

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderStage"
    pKeyFieldName = "SalesOrderStageID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderStage.SalesOrderStageID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderStage.SalesOrderStageID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderStage.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderStage.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderStageID", pSalesOrderStage.SalesOrderStageID)
    End If
    With pSalesOrderStage
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalCost", .TotalCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StageTypeID", .StageTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderStage Is Nothing Then SetObjectToNew()
      With pSalesOrderStage
        .SalesOrderStageID = DBReadInt32(rDataReader, "SalesOrderStageID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .TotalCost = DBReadDecimal(rDataReader, "TotalCost")
        .StageTypeID = DBReadInt32(rDataReader, "StageTypeID")
        .Description = DBReadString(rDataReader, "Description")
        pSalesOrderStage.IsDirty = False
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
    pSalesOrderStage = New dmSalesOrderStage ' Or .NewBlankSalesOrderStage
    Return pSalesOrderStage

  End Function


  Public Function LoadSalesOrderStage(ByRef rSalesOrderStage As dmSalesOrderStage, ByVal vSalesOrderStageID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderStageID)
    If mOK Then
      rSalesOrderStage = pSalesOrderStage
    Else
      rSalesOrderStage = Nothing
    End If
    pSalesOrderStage = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderStage(ByRef rSalesOrderStage As dmSalesOrderStage) As Boolean
    Dim mOK As Boolean
    pSalesOrderStage = rSalesOrderStage
    mOK = SaveObject()
    pSalesOrderStage = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderStageCollection(ByRef rSalesOrderStages As colSalesOrderStages, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rSalesOrderStages, mParams, "SalesOrderStageID")
    rSalesOrderStages.TrackDeleted = True
    If mOK Then rSalesOrderStages.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderStageCollection(ByRef rCollection As colSalesOrderStages, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vSalesOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderStage In rCollection
      ''    If pSalesOrderStage.SalesOrderStageID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderStage.SalesOrderStageID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderStage In rCollection.DeletedItems
          If pSalesOrderStage.SalesOrderStageID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderStage.SalesOrderStageID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderStage In rCollection
        If pSalesOrderStage.IsDirty Or pSalesOrderStage.SalesOrderID <> vSalesOrderID Or pSalesOrderStage.SalesOrderStageID = 0 Then 'Or pSalesOrderStage.SalesOrderStageID = 0
          pSalesOrderStage.SalesOrderID = vSalesOrderID
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

