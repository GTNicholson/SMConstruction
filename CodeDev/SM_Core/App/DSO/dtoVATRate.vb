''DTO Definition - VATRate (to VATRate)'Generated from Table:VATRate

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoVATRate : Inherits dtoBase
  Private pVATRate As dmVATRate

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "VATRate"
    pKeyFieldName = "VATRateRecordID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pVATRate.VATRateRecordID
    End Get
    Set(ByVal value As Integer)
      pVATRate.VATRateRecordID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pVATRate.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pVATRate.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      RowVersionValue = pVATRate.rowversion
    End Get
    Set(ByVal value As ULong)
      pVATRate.rowversion = value
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "VATRateRecordID", pVATRate.VATRateRecordID)
    End If
    With pVATRate
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRateCode", .VATRateCode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VATRate", .VATRate)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Protected", .ProtectedVAT)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateStart", DateToDBValue(.DateStart))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateEnd", DateToDBValue(.DateEnd))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pVATRate Is Nothing Then SetObjectToNew()
      With pVATRate
        .VATRateRecordID = DBReadInt32(rDataReader, "VATRateRecordID")
        .VATRateCode = DBReadInt32(rDataReader, "VATRateCode")
        .VATRate = DBReadDecimal(rDataReader, "VATRate")
        .ProtectedVAT = DBReadBoolean(rDataReader, "Protected")
        .rowversion = DBReadRowVersion2Long(rDataReader, "rowversion")
        .DateStart = DBReadDateTime(rDataReader, "DateStart")
        .DateEnd = DBReadDateTime(rDataReader, "DateEnd")
        pVATRate.IsDirty = False
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
    pVATRate = New dmVATRate ' Or .NewBlankVATRate
    Return pVATRate

  End Function


  Public Function LoadVATRate(ByRef rVATRate As dmVATRate, ByVal vVATRateRecordID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vVATRateRecordID)
    If mOK Then
      rVATRate = pVATRate
    Else
      rVATRate = Nothing
    End If
    pVATRate = Nothing
    Return mOK
  End Function


  Public Function SaveVATRate(ByRef rVATRate As dmVATRate) As Boolean
    Dim mOK As Boolean
    pVATRate = rVATRate
    mOK = SaveObject()
    pVATRate = Nothing
    Return mOK
  End Function


  Public Function LoadVATRateCollection(ByRef rVATRates As colVATRates) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)

    mOK = MyBase.LoadCollection(rVATRates, mParams, "VATRateRecordID")
    rVATRates.TrackDeleted = True
    If mOK Then rVATRates.IsDirty = False
    Return mOK
  End Function


  Public Function SaveVATRateCollection(ByRef rCollection As colVATRates, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pVATRate In rCollection
      ''    If pVATRate.VATRateRecordID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pVATRate.VATRateRecordID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pVATRate In rCollection.DeletedItems
          If pVATRate.VATRateRecordID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pVATRate.VATRateRecordID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pVATRate In rCollection
        If pVATRate.IsDirty Or pVATRate.VATRateRecordID = 0 Then 'Or pVATRate.VATRateRecordID = 0
          ''pVATRate.ParentID = vParentID
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