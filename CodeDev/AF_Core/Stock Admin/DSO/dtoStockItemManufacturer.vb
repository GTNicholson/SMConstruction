''DTO Definition - StockItemManufacturer (to StockItemManufacturer)'Generated from Table:StockItemManufacturer

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemManufacturer : Inherits dtoBase
  Private pStockItemManufacturer As dmStockItemManufacturer

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemManufacturer"
    pKeyFieldName = "StockItemManufacturerID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemManufacturer.StockItemManufacturerID
    End Get
    Set(ByVal value As Integer)
      pStockItemManufacturer.StockItemManufacturerID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemManufacturer.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemManufacturer.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemManufacturerID", pStockItemManufacturer.StockItemManufacturerID)
    End If
    With pStockItemManufacturer
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Name", StringToDBValue(.Name))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abbreviation", StringToDBValue(.Abbreviation))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemManufacturer Is Nothing Then SetObjectToNew()
      With pStockItemManufacturer
        .StockItemManufacturerID = DBReadInt32(rDataReader, "StockItemManufacturerID")
        .Name = DBReadString(rDataReader, "Name")
        .Abbreviation = DBReadString(rDataReader, "Abbreviation")
        pStockItemManufacturer.IsDirty = False
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
    pStockItemManufacturer = New dmStockItemManufacturer ' Or .NewBlankStockItemManufacturer
    Return pStockItemManufacturer

  End Function


  Public Function LoadStockItemManufacturer(ByRef rStockItemManufacturer As dmStockItemManufacturer, ByVal vStockItemManufacturerID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemManufacturerID)
    If mOK Then
      rStockItemManufacturer = pStockItemManufacturer
    Else
      rStockItemManufacturer = Nothing
    End If
    pStockItemManufacturer = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemManufacturer(ByRef rStockItemManufacturer As dmStockItemManufacturer) As Boolean
    Dim mOK As Boolean
    pStockItemManufacturer = rStockItemManufacturer
    mOK = SaveObject()
    pStockItemManufacturer = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemManufacturerCollection(ByRef rStockItemManufacturers As colStockItemManufacturers) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rStockItemManufacturers, mParams, "StockItemManufacturerID")
    rStockItemManufacturers.TrackDeleted = True
    If mOK Then rStockItemManufacturers.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockItemManufacturerCollection(ByRef rCollection As colStockItemManufacturers) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then

      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItemManufacturer In rCollection
      ''    If pStockItemManufacturer.StockItemManufacturerID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItemManufacturer.StockItemManufacturerID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemManufacturer In rCollection.DeletedItems
          If pStockItemManufacturer.StockItemManufacturerID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemManufacturer.StockItemManufacturerID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemManufacturer In rCollection
        If pStockItemManufacturer.IsDirty Or pStockItemManufacturer.StockItemManufacturerID = 0 Then 'Or pStockItemManufacturer.StockItemManufacturerID = 0
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
