Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductCostBook : Inherits dtoBase
  Private pProductCostBook As dmProductCostBook

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductCostBook"
    pKeyFieldName = "ProductCostBookID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductCostBook.ProductCostBookID
    End Get
    Set(ByVal value As Integer)
      pProductCostBook.ProductCostBookID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductCostBook.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductCostBook.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductCostBookID", pProductCostBook.ProductCostBookID)
    End If
    With pProductCostBook
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookName", StringToDBValue(.CostBookName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookDate", DateToDBValue(.CostBookDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsDefault", .IsDefault)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DirectLabourCost", .DirectLabourCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DirectMaterialCost", .DirectMaterialCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DirectTransportationAndEquipment", .DirectTransportationAndEquipment)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OutsourcingCost", .OutsourcingCost)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductCostBook Is Nothing Then SetObjectToNew()
      With pProductCostBook
        .ProductCostBookID = DBReadInt32(rDataReader, "ProductCostBookID")
        .CostBookName = DBReadString(rDataReader, "CostBookName")
        .CostBookDate = DBReadDateTime(rDataReader, "CostBookDate")
        .IsDefault = DBReadBoolean(rDataReader, "IsDefault")
        .DirectLabourCost = DBReadDecimal(rDataReader, "DirectLabourCost")
        .DirectMaterialCost = DBReadDecimal(rDataReader, "DirectMaterialCost")
        .DirectTransportationAndEquipment = DBReadDecimal(rDataReader, "DirectTransportationAndEquipment")
        .OutsourcingCost = DBReadDecimal(rDataReader, "OutsourcingCost")
        pProductCostBook.IsDirty = False
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
    pProductCostBook = New dmProductCostBook ' Or .NewBlankProductCostBook
    Return pProductCostBook

  End Function


  Public Function LoadProductCostBook(ByRef rProductCostBook As dmProductCostBook, ByVal vProductCostBookID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductCostBookID)
    If mOK Then
      rProductCostBook = pProductCostBook
    Else
      rProductCostBook = Nothing
    End If
    pProductCostBook = Nothing
    Return mOK
  End Function


  Public Function SaveProductCostBook(ByRef rProductCostBook As dmProductCostBook) As Boolean
    Dim mOK As Boolean
    pProductCostBook = rProductCostBook
    mOK = SaveObject()
    pProductCostBook = Nothing
    Return mOK
  End Function


  Public Function LoadProductCostBookCollection(ByRef rProductCostBooks As colProductCostBooks) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductCostBooks, mParams, "ProductCostBookID")
    rProductCostBooks.TrackDeleted = True
    If mOK Then rProductCostBooks.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductCostBookCollection(ByRef rCollection As colProductCostBooks) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductCostBook In rCollection
      ''    If pProductCostBook.ProductCostBookID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductCostBook.ProductCostBookID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductCostBook In rCollection.DeletedItems
          If pProductCostBook.ProductCostBookID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductCostBook.ProductCostBookID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductCostBook In rCollection
        If pProductCostBook.IsDirty Or pProductCostBook.ProductCostBookID = 0 Then 'Or pProductCostBook.ProductCostBookID = 0
          ''pProductCostBook.ParentID = vParentID
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


