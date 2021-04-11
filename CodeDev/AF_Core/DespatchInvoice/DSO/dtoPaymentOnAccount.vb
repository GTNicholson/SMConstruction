Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPaymentOnAccount : Inherits dtoBase
  Private pPaymentOnAccount As dmPaymentOnAccount

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PaymentOnAccount"
    pKeyFieldName = "PaymentOnAccountID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPaymentOnAccount.PaymentOnAccountID
    End Get
    Set(ByVal value As Integer)
      pPaymentOnAccount.PaymentOnAccountID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPaymentOnAccount.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPaymentOnAccount.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PaymentOnAccountID", pPaymentOnAccount.PaymentOnAccountID)
    End If
    With pPaymentOnAccount


      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RequestDate", DateToDBValue(.RequestDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RequestValue", .RequestValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReceivedValue", .ReceivedValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AllocatedValue", .AllocatedValue)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPaymentOnAccount Is Nothing Then SetObjectToNew()
      With pPaymentOnAccount
        .PaymentOnAccountID = DBReadInt32(rDataReader, "PaymentOnAccountID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")

        .RequestDate = DBReadDateTime(rDataReader, "RequestDate")
        .RequestValue = DBReadDecimal(rDataReader, "RequestValue")
        .ReceivedValue = DBReadDecimal(rDataReader, "ReceivedValue")
        .AllocatedValue = DBReadDecimal(rDataReader, "AllocatedValue")
        pPaymentOnAccount.IsDirty = False
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
    pPaymentOnAccount = New dmPaymentOnAccount ' Or .NewBlankPaymentOnAccount
    Return pPaymentOnAccount

  End Function


  Public Function LoadPaymentOnAccount(ByRef rPaymentOnAccount As dmPaymentOnAccount, ByVal vPaymentOnAccountID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPaymentOnAccountID)
    If mOK Then
      rPaymentOnAccount = pPaymentOnAccount
    Else
      rPaymentOnAccount = Nothing
    End If
    pPaymentOnAccount = Nothing
    Return mOK
  End Function


  Public Function SavePaymentOnAccount(ByRef rPaymentOnAccount As dmPaymentOnAccount) As Boolean
    Dim mOK As Boolean
    pPaymentOnAccount = rPaymentOnAccount
    mOK = SaveObject()
    pPaymentOnAccount = Nothing
    Return mOK
  End Function


  Public Function LoadPaymentOnAccountCollection(ByRef rPaymentOnAccounts As colPaymentOnAccounts, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rPaymentOnAccounts, mParams, "PaymentOnAccountID")
    rPaymentOnAccounts.TrackDeleted = True
    If mOK Then rPaymentOnAccounts.IsDirty = False
    Return mOK
  End Function


  Public Function SavePaymentOnAccountCollection(ByRef rCollection As colPaymentOnAccounts, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vSalesOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPaymentOnAccount In rCollection
      ''    If pPaymentOnAccount.PaymentOnAccountID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPaymentOnAccount.PaymentOnAccountID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPaymentOnAccount In rCollection.DeletedItems
          If pPaymentOnAccount.PaymentOnAccountID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPaymentOnAccount.PaymentOnAccountID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPaymentOnAccount In rCollection
        If pPaymentOnAccount.IsDirty Or pPaymentOnAccount.SalesOrderID <> vSalesOrderID Or pPaymentOnAccount.PaymentOnAccountID = 0 Then 'Or pPaymentOnAccount.PaymentOnAccountID = 0
          pPaymentOnAccount.SalesOrderID = vSalesOrderID
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
