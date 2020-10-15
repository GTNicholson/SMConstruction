''DTO Definition - SalesOrderPhase (to SalesOrderPhase)'Generated from Table:SalesOrderPhase

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderPhase : Inherits dtoBase
  Private pSalesOrderPhase As dmSalesOrderPhase

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderPhase"
    pKeyFieldName = "SalesOrderPhaseID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderPhase.SalesOrderPhaseID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderPhase.SalesOrderPhaseID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderPhase.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderPhase.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderPhaseID", pSalesOrderPhase.SalesOrderPhaseID)
    End If
    With pSalesOrderPhase
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderNo", StringToDBValue(.SalesOrderNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCreated", DateToDBValue(.DateCreated))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CreatedBy", .CreatedBy)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateRequired", DateToDBValue(.DateRequired))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QuantityItems", .QuantityItems)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPrice", .TotalPrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PhaseNumber", .PhaseNumber)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ScheduleFile", StringToDBValue(.ScheduleFile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PhaseRef", StringToDBValue(.PhaseRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DespatchStatus", .DespatchStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpecificationStatus", .SpecificationStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceStatus", .InvoiceStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductionStatus", .ProductionStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MatReqStatus", .MatReqStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CommittedBy", .CommittedBy)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCommitted", DateToDBValue(.DateCommitted))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "JobNo", StringToDBValue(.JobNo))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderPhase Is Nothing Then SetObjectToNew()
      With pSalesOrderPhase
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .SalesOrderNo = DBReadString(rDataReader, "SalesOrderNo")
        .DateCreated = DBReadDateTime(rDataReader, "DateCreated")
        .CreatedBy = DBReadInt32(rDataReader, "CreatedBy")
        .DateRequired = DBReadDateTime(rDataReader, "DateRequired")
        .QuantityItems = DBReadInt32(rDataReader, "QuantityItems")
        .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")
        .PhaseNumber = DBReadInt32(rDataReader, "PhaseNumber")
        .ScheduleFile = DBReadString(rDataReader, "ScheduleFile")
        .PhaseRef = DBReadString(rDataReader, "PhaseRef")
        .DespatchStatus = DBReadByte(rDataReader, "DespatchStatus")
        .SpecificationStatus = DBReadByte(rDataReader, "SpecificationStatus")
        .InvoiceStatus = DBReadByte(rDataReader, "InvoiceStatus")
        .ProductionStatus = DBReadByte(rDataReader, "ProductionStatus")
        .MatReqStatus = DBReadByte(rDataReader, "MatReqStatus")
        .CommittedBy = DBReadInt32(rDataReader, "CommittedBy")
        .DateCommitted = DBReadDateTime(rDataReader, "DateCommitted")
        .JobNo = DBReadString(rDataReader, "JobNo")
        pSalesOrderPhase.IsDirty = False
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
    pSalesOrderPhase = New dmSalesOrderPhase ' Or .NewBlankSalesOrderPhase
    Return pSalesOrderPhase

  End Function


  Public Function LoadSalesOrderPhase(ByRef rSalesOrderPhase As dmSalesOrderPhase, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderPhaseID)
    If mOK Then
      rSalesOrderPhase = pSalesOrderPhase
    Else
      rSalesOrderPhase = Nothing
    End If
    pSalesOrderPhase = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderPhase(ByRef rSalesOrderPhase As dmSalesOrderPhase) As Boolean
    Dim mOK As Boolean
    pSalesOrderPhase = rSalesOrderPhase
    mOK = SaveObject()
    pSalesOrderPhase = Nothing
    Return mOK
  End Function
  Public Function LoadSalesOrderPhaseCollectionByWhere(ByRef rSalesOrderPhases As colSalesOrderPhases, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rSalesOrderPhases, mParams, "SalesOrderPhaseID", vWhere)
    rSalesOrderPhases.TrackDeleted = True
    If mOK Then rSalesOrderPhases.IsDirty = False
    Return mOK
  End Function


  Public Function LoadSalesOrderPhaseCollection(ByRef rSalesOrderPhases As colSalesOrderPhases, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rSalesOrderPhases, mParams, "SalesOrderPhaseID")
    rSalesOrderPhases.TrackDeleted = True
    If mOK Then rSalesOrderPhases.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderPhaseCollection(ByRef rCollection As colSalesOrderPhases, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vSalesOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderPhase In rCollection
      ''    If pSalesOrderPhase.SalesOrderPhaseID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderPhase.SalesOrderPhaseID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderPhase In rCollection.DeletedItems
          If pSalesOrderPhase.SalesOrderPhaseID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderPhase.SalesOrderPhaseID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderPhase In rCollection
        If pSalesOrderPhase.IsDirty Or pSalesOrderPhase.SalesOrderID <> vSalesOrderID Or pSalesOrderPhase.SalesOrderPhaseID = 0 Then 'Or pSalesOrderPhase.SalesOrderPhaseID = 0
          pSalesOrderPhase.SalesOrderID = vSalesOrderID
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

