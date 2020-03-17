
''DTO Definition - InvoiceItem (to InvoiceItem)'Generated from Table:InvoiceItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoInvoiceItem : Inherits dtoBase
  Private pInvoiceItem As dmInvoiceItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "InvoiceItem"
    pKeyFieldName = "InvoiceItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pInvoiceItem.InvoiceItemID
    End Get
    Set(ByVal value As Integer)
      pInvoiceItem.InvoiceItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pInvoiceItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pInvoiceItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "InvoiceItemID", pInvoiceItem.InvoiceItemID)
    End If
    With pInvoiceItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InvoiceID", .InvoiceID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesItemID", .SalesItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPrice", .UnitPrice)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pInvoiceItem Is Nothing Then SetObjectToNew()
      With pInvoiceItem
        .InvoiceItemID = DBReadInt32(rDataReader, "InvoiceItemID")
        .InvoiceID = DBReadInt32(rDataReader, "InvoiceID")
        .SalesItemID = DBReadInt32(rDataReader, "SalesItemID")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        pInvoiceItem.IsDirty = False
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
    pInvoiceItem = New dmInvoiceItem ' Or .NewBlankInvoiceItem
    Return pInvoiceItem

  End Function


  Public Function LoadInvoiceItem(ByRef rInvoiceItem As dmInvoiceItem, ByVal vInvoiceItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vInvoiceItemID)
    If mOK Then
      rInvoiceItem = pInvoiceItem
    Else
      rInvoiceItem = Nothing
    End If
    pInvoiceItem = Nothing
    Return mOK
  End Function


  Public Function SaveInvoiceItem(ByRef rInvoiceItem As dmInvoiceItem) As Boolean
    Dim mOK As Boolean
    pInvoiceItem = rInvoiceItem
    mOK = SaveObject()
    pInvoiceItem = Nothing
    Return mOK
  End Function


  Public Function LoadInvoiceItemCollection(ByRef rInvoiceItems As colInvoiceItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@InvoiceID", vParentID)
    mOK = MyBase.LoadCollection(rInvoiceItems, mParams, "InvoiceItemID")
    rInvoiceItems.TrackDeleted = True
    If mOK Then rInvoiceItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveInvoiceItemCollection(ByRef rCollection As colInvoiceItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@InvoiceID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pInvoiceItem In rCollection
      ''    If pInvoiceItem.InvoiceItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pInvoiceItem.InvoiceItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pInvoiceItem In rCollection.DeletedItems
          If pInvoiceItem.InvoiceItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pInvoiceItem.InvoiceItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pInvoiceItem In rCollection
        If pInvoiceItem.IsDirty Or pInvoiceItem.InvoiceID <> vParentID Or pInvoiceItem.InvoiceItemID = 0 Then 'Or pInvoiceItem.InvoiceItemID = 0
          pInvoiceItem.InvoiceID = vParentID
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
