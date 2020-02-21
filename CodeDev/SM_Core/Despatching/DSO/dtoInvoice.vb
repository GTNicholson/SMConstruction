
''DTO Definition - Invoice (to Invoice)'Generated from Table:Invoice

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoInvoice : Inherits dtoBase
  Private pInvoice As dmInvoice

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Invoice"
    pKeyFieldName = "InvoiceID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pInvoice.InvoiceID
    End Get
    Set(ByVal value As Integer)
      pInvoice.InvoiceID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pInvoice.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pInvoice.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "InvoiceID", pInvoice.InvoiceID)
    End If
    With pInvoice
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceDate", DateToDBValue(.InvoiceDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CreatedDate", DateToDBValue(.CreatedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetValue", .NetValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TaxValue", .TaxValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceStatus", .InvoiceStatus)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerPurchaseOrder", StringToDBValue(.CustomerPurchaseOrder))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pInvoice Is Nothing Then SetObjectToNew()
      With pInvoice
        .InvoiceID = DBReadInt32(rDataReader, "InvoiceID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .InvoiceDate = DBReadDateTime(rDataReader, "InvoiceDate")
        .CreatedDate = DBReadDateTime(rDataReader, "CreatedDate")
        .NetValue = DBReadDecimal(rDataReader, "NetValue")
        .TaxValue = DBReadDecimal(rDataReader, "TaxValue")
        .InvoiceStatus = DBReadInt16(rDataReader, "InvoiceStatus")
        .CustomerPurchaseOrder = DBReadString(rDataReader, "CustomerPurchaseOrder")
        pInvoice.IsDirty = False
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
    pInvoice = New dmInvoice ' Or .NewBlankInvoice
    Return pInvoice

  End Function


  Public Function LoadInvoice(ByRef rInvoice As dmInvoice, ByVal vInvoiceID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vInvoiceID)
    If mOK Then
      rInvoice = pInvoice
    Else
      rInvoice = Nothing
    End If
    pInvoice = Nothing
    Return mOK
  End Function


  Public Function SaveInvoice(ByRef rInvoice As dmInvoice) As Boolean
    Dim mOK As Boolean
    pInvoice = rInvoice
    mOK = SaveObject()
    pInvoice = Nothing
    Return mOK
  End Function


  Public Function LoadInvoiceCollection(ByRef rInvoices As colInvoices, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vParentID)
    mOK = MyBase.LoadCollection(rInvoices, mParams, "InvoiceID")
    rInvoices.TrackDeleted = True
    If mOK Then rInvoices.IsDirty = False
    Return mOK
  End Function


  Public Function SaveInvoiceCollection(ByRef rCollection As colInvoices, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pInvoice In rCollection
      ''    If pInvoice.InvoiceID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pInvoice.InvoiceID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pInvoice In rCollection.DeletedItems
          If pInvoice.InvoiceID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pInvoice.InvoiceID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pInvoice In rCollection
        If pInvoice.IsDirty Or pInvoice.SalesOrderID <> vParentID Or pInvoice.InvoiceID = 0 Then 'Or pInvoice.InvoiceID = 0
          pInvoice.SalesOrderID = vParentID
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