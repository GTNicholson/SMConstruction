''DTO Definition - StockItemTransactionLog (to StockItemTransactionLog)'Generated from Table:StockItemTransactionLog

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemTransactionLog : Inherits dtoBase
  Private pStockItemTransactionLog As dmStockItemTransactionLog

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemTransactionLog"
    pKeyFieldName = "StockItemTransactionLogID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemTransactionLog.StockItemTransactionLogID
    End Get
    Set(ByVal value As Integer)
      pStockItemTransactionLog.StockItemTransactionLogID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemTransactionLog.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemTransactionLog.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemTransactionLogID", pStockItemTransactionLog.StockItemTransactionLogID)
    End If
    With pStockItemTransactionLog
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectType", .ObjectType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectID", .ObjectID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TransactionType", .TransactionType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UserID", .UserID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TranValue", .TranValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrevValue", .PrevValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NewValue", .NewValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SystemDate", DateToDBValue(.SystemDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TransactionDate", DateToDBValue(.TransactionDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RefObjectType", .RefObjectType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RefObjectID", .RefObjectID)
      ''DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StdCost", .StdCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AdditionalRef", .AdditionalRef)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Note", StringToDBValue(.Note))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReferenceNo", StringToDBValue(.ReferenceNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TransactionValuation", .TransactionValuation)

      '// TransactionValue not in write
      '// StockValue not in write
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemTransactionLog Is Nothing Then SetObjectToNew()
      With pStockItemTransactionLog
        .StockItemTransactionLogID = DBReadInt32(rDataReader, "StockItemTransactionLogID")
        .ObjectType = DBReadByte(rDataReader, "ObjectType")
        .ObjectID = DBReadInt32(rDataReader, "ObjectID")
        .TransactionType = DBReadByte(rDataReader, "TransactionType")
        .UserID = DBReadInt32(rDataReader, "UserID")
        .TranValue = DBReadDecimal(rDataReader, "TranValue")
        .PrevValue = DBReadDecimal(rDataReader, "PrevValue")
        .NewValue = DBReadDecimal(rDataReader, "NewValue")
        .SystemDate = DBReadDateTime(rDataReader, "SystemDate")
        .TransactionDate = DBReadDateTime(rDataReader, "TransactionDate")
        .RefObjectType = DBReadByte(rDataReader, "RefObjectType")
        .RefObjectID = DBReadInt32(rDataReader, "RefObjectID")
        .AdditionalRef = DBReadInt32(rDataReader, "AdditionalRef")
        .Note = DBReadString(rDataReader, "Note")
        .ReferenceNo = DBReadString(rDataReader, "ReferenceNo")

        ''.StdCost = DBReadDecimal(rDataReader, "StdCost")
        .TransactionValuation = DBReadDecimal(rDataReader, "TransactionValuation")
        .StockValuation = DBReadDecimal(rDataReader, "StockValuation")
        pStockItemTransactionLog.IsDirty = False
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
    pStockItemTransactionLog = New dmStockItemTransactionLog ' Or .NewBlankStockItemTransactionLog
    Return pStockItemTransactionLog

  End Function


  Public Function LoadStockItemTransactionLog(ByRef rStockItemTransactionLog As dmStockItemTransactionLog, ByVal vStockItemTransactionLogID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemTransactionLogID)
    If mOK Then
      rStockItemTransactionLog = pStockItemTransactionLog
    Else
      rStockItemTransactionLog = Nothing
    End If
    pStockItemTransactionLog = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemTransactionLog(ByRef rStockItemTransactionLog As dmStockItemTransactionLog) As Boolean
    Dim mOK As Boolean
    pStockItemTransactionLog = rStockItemTransactionLog
    mOK = SaveObject()
    pStockItemTransactionLog = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemTransactionLogCollection(ByRef rStockItemTransactionLogs As colStockItemTransactionLogs, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStockItemTransactionLogs, mParams, "StockItemTransactionLogID")
    rStockItemTransactionLogs.TrackDeleted = True
    If mOK Then rStockItemTransactionLogs.IsDirty = False
    Return mOK
  End Function

  Public Function LoadStockItemTransactionLogCollectionByWhere(ByRef rStockItemTransactionLogs As colStockItemTransactionLogs, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rStockItemTransactionLogs, mParams, "TransactionDate, StockItemTransactionLogID", vWhere)
    rStockItemTransactionLogs.TrackDeleted = True
    If mOK Then rStockItemTransactionLogs.IsDirty = False
    Return mOK
  End Function

  Public Function LoadStockItemTransactionLogCollectionLastPrior(ByRef rStockItemTransactionLogs As colStockItemTransactionLogs, ByVal vDate As Date) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mParams.Add("@CutOffDate", vDate)

    mOK = MyBase.LoadCollectionFromSP(rStockItemTransactionLogs, "spLastPriorTransactions", mParams)

    If mOK Then rStockItemTransactionLogs.IsDirty = False
    Return mOK
  End Function

  Public Function LoadStockItemTransactionLogTOP1ByWhere(ByRef rStockItemTransactionLogs As colStockItemTransactionLogs, ByVal vWhere As String, ByVal vDescending As Boolean) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    Dim mOrderBy As String
    pDefinedSelectSQL = "SELECT TOP 1 * FROM dbo.StockItemTransactionLog WHERE " & vWhere
    If vDescending = True Then
      mOrderBy = "TransactionDate DESC, StockItemTransactionLogID Desc"
    Else
      mOrderBy = "TransactionDate Asc, StockItemTransactionLogID Asc"
    End If

    mOK = MyBase.LoadCollection(rStockItemTransactionLogs, mParams, mOrderBy)
    rStockItemTransactionLogs.TrackDeleted = True
    If mOK Then rStockItemTransactionLogs.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockItemTransactionLogCollection(ByRef rCollection As colStockItemTransactionLogs) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItemTransactionLog In rCollection
      ''    If pStockItemTransactionLog.StockItemTransactionLogID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItemTransactionLog.StockItemTransactionLogID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemTransactionLog In rCollection.DeletedItems
          If pStockItemTransactionLog.StockItemTransactionLogID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemTransactionLog.StockItemTransactionLogID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemTransactionLog In rCollection
        If pStockItemTransactionLog.IsDirty Or pStockItemTransactionLog.StockItemTransactionLogID = 0 Then 'Or pStockItemTransactionLog.StockItemTransactionLogID = 0
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


