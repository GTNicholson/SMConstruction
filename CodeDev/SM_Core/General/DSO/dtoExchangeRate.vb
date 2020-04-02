
''DTO Definition - ExchangeRate (to ExchangeRate)'Generated from Table:ExchangeRate

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoExchangeRate : Inherits dtoBase
  Private pExchangeRate As dmExchangeRate

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ExchangeRate"
    pKeyFieldName = "ExchangeRateID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pExchangeRate.ExchangeRateID
    End Get
    Set(ByVal value As Integer)
      pExchangeRate.ExchangeRateID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pExchangeRate.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pExchangeRate.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ExchangeRateID", pExchangeRate.ExchangeRateID)
    End If
    With pExchangeRate
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ExchangeRateDate", DateToDBValue(.ExchangeRateDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ExchangeRateValue", .ExchangeRateValue)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pExchangeRate Is Nothing Then SetObjectToNew()
      With pExchangeRate
        .ExchangeRateID = DBReadInt32(rDataReader, "ExchangeRateID")
        .ExchangeRateDate = DBReadDateTime(rDataReader, "ExchangeRateDate")
        .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
        pExchangeRate.IsDirty = False
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
    pExchangeRate = New dmExchangeRate ' Or .NewBlankExchangeRate
    Return pExchangeRate

  End Function


  Public Function LoadExchangeRate(ByRef rExchangeRate As dmExchangeRate, ByVal vExchangeRateID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vExchangeRateID)
    If mOK Then
      rExchangeRate = pExchangeRate
    Else
      rExchangeRate = Nothing
    End If
    pExchangeRate = Nothing
    Return mOK
  End Function


  Public Function SaveExchangeRate(ByRef rExchangeRate As dmExchangeRate) As Boolean
    Dim mOK As Boolean
    pExchangeRate = rExchangeRate
    mOK = SaveObject()
    pExchangeRate = Nothing
    Return mOK
  End Function


  Public Function LoadExchangeRateCollection(ByRef rExchangeRates As colExchangeRates) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rExchangeRates, mParams, "ExchangeRateID")
    rExchangeRates.TrackDeleted = True
    If mOK Then rExchangeRates.IsDirty = False
    Return mOK
  End Function


  Public Function SaveExchangeRateCollection(ByRef rCollection As colExchangeRates, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pExchangeRate In rCollection
      ''    If pExchangeRate.ExchangeRateID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pExchangeRate.ExchangeRateID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pExchangeRate In rCollection.DeletedItems
          If pExchangeRate.ExchangeRateID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pExchangeRate.ExchangeRateID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pExchangeRate In rCollection
        If pExchangeRate.IsDirty Or pExchangeRate.ExchangeRateID = 0 Then 'Or pExchangeRate.ExchangeRateID = 0

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