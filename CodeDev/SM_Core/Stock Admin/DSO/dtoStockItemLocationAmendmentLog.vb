''DTO Definition - StockItemLocationAmendmentLog (to StockItemLocationAmendmentLog)'Generated from Table:StockItemLocationAmendmentLog

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemLocationAmendmentLog : Inherits dtoBase
  Private pStockItemLocationAmendmentLog As dmStockItemLocationAmendmentLog

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemLocationAmendmentLog"
    pKeyFieldName = "StockItemLocationAmendmentLogID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID
    End Get
    Set(ByVal value As Integer)
      pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemLocationAmendmentLog.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemLocationAmendmentLog.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      Return Nothing
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemLocationAmendmentLogID", pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID)
    End If
    With pStockItemLocationAmendmentLog
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SystemDate", DateToDBValue(.SystemDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AmendmentDate", DateToDBValue(.AmendmentDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemLocationID", .StockItemLocationID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ChangeDetails", StringToDBValue(.ChangeDetails))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UserID", .UserID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UserNotes", StringToDBValue(.UserNotes))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemLocationAmendmentLog Is Nothing Then SetObjectToNew()
      With pStockItemLocationAmendmentLog
        .StockItemLocationAmendmentLogID = DBReadInt32(rDataReader, "StockItemLocationAmendmentLogID")
        .SystemDate = DBReadDateTime(rDataReader, "SystemDate")
        .AmendmentDate = DBReadDateTime(rDataReader, "AmendmentDate")
        .StockItemLocationID = DBReadInt32(rDataReader, "StockItemLocationID")
        .ChangeDetails = DBReadString(rDataReader, "ChangeDetails")
        .UserID = DBReadInt32(rDataReader, "UserID")
        .UserNotes = DBReadString(rDataReader, "UserNotes")
        pStockItemLocationAmendmentLog.IsDirty = False
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
    pStockItemLocationAmendmentLog = New dmStockItemLocationAmendmentLog ' Or .NewBlankStockItemLocationAmendmentLog
    Return pStockItemLocationAmendmentLog

  End Function


  Public Function LoadStockItemLocationAmendmentLog(ByRef rStockItemLocationAmendmentLog As dmStockItemLocationAmendmentLog, ByVal vStockItemLocationAmendmentLogID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemLocationAmendmentLogID)
    If mOK Then
      rStockItemLocationAmendmentLog = pStockItemLocationAmendmentLog
    Else
      rStockItemLocationAmendmentLog = Nothing
    End If
    pStockItemLocationAmendmentLog = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemLocationAmendmentLog(ByRef rStockItemLocationAmendmentLog As dmStockItemLocationAmendmentLog) As Boolean
    Dim mOK As Boolean
    pStockItemLocationAmendmentLog = rStockItemLocationAmendmentLog
    mOK = SaveObject()
    pStockItemLocationAmendmentLog = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemLocationAmendmentLogCollection(ByRef rStockItemLocationAmendmentLogs As colStockItemLocationAmendmentLogs) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rStockItemLocationAmendmentLogs, mParams, "StockItemLocationAmendmentLogID")
    rStockItemLocationAmendmentLogs.TrackDeleted = True
    If mOK Then rStockItemLocationAmendmentLogs.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockItemLocationAmendmentLogCollection(ByRef rCollection As colStockItemLocationAmendmentLogs) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then

      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItemLocationAmendmentLog In rCollection
      ''    If pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemLocationAmendmentLog In rCollection.DeletedItems
          If pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemLocationAmendmentLog In rCollection
        If pStockItemLocationAmendmentLog.IsDirty Or pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID = 0 Then 'Or pStockItemLocationAmendmentLog.StockItemLocationAmendmentLogID = 0
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


