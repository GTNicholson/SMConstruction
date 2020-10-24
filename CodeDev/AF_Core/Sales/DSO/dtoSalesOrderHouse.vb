''DTO Definition - SalesOrderHouse (to SalesOrderHouse)'Generated from Table:SalesOrderHouse

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderHouse : Inherits dtoBase
  Private pSalesOrderHouse As dmSalesOrderHouse

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderHouse"
    pKeyFieldName = "SalesOrderHouseID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderHouse.SalesOrderHouseID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderHouse.SalesOrderHouseID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderHouse.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderHouse.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderHouseID", pSalesOrderHouse.SalesOrderHouseID)
    End If
    With pSalesOrderHouse
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HouseTypeID", .HouseTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Ref", StringToDBValue(.Ref))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PricePerUnit", .PricePerUnit)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPrice", .TotalPrice)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderHouse Is Nothing Then SetObjectToNew()
      With pSalesOrderHouse
        .SalesOrderHouseID = DBReadInt32(rDataReader, "SalesOrderHouseID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .HouseTypeID = DBReadInt32(rDataReader, "HouseTypeID")
        .Ref = DBReadString(rDataReader, "Ref")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .PricePerUnit = DBReadDecimal(rDataReader, "PricePerUnit")
        .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")
        pSalesOrderHouse.IsDirty = False
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
    pSalesOrderHouse = New dmSalesOrderHouse ' Or .NewBlankSalesOrderHouse
    Return pSalesOrderHouse

  End Function


  Public Function LoadSalesOrderHouse(ByRef rSalesOrderHouse As dmSalesOrderHouse, ByVal vSalesOrderHouseID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderHouseID)
    If mOK Then
      rSalesOrderHouse = pSalesOrderHouse
    Else
      rSalesOrderHouse = Nothing
    End If
    pSalesOrderHouse = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderHouse(ByRef rSalesOrderHouse As dmSalesOrderHouse) As Boolean
    Dim mOK As Boolean
    pSalesOrderHouse = rSalesOrderHouse
    mOK = SaveObject()
    pSalesOrderHouse = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderHouseCollection(ByRef rSalesOrderHouses As colSalesOrderHouses, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rSalesOrderHouses, mParams, "SalesOrderHouseID")
    rSalesOrderHouses.TrackDeleted = True
    If mOK Then rSalesOrderHouses.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderHouseCollection(ByRef rCollection As colSalesOrderHouses, ByVal vParentID As Integer) As Boolean
    ''Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderHouse In rCollection
      ''    If pSalesOrderHouse.SalesOrderHouseID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderHouse.SalesOrderHouseID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderHouse In rCollection.DeletedItems
          If pSalesOrderHouse.SalesOrderHouseID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderHouse.SalesOrderHouseID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderHouse In rCollection
        If pSalesOrderHouse.IsDirty Or pSalesOrderHouse.SalesOrderID <> vParentID Or pSalesOrderHouse.SalesOrderHouseID = 0 Then 'Or pSalesOrderHouse.SalesOrderHouseID = 0
          pSalesOrderHouse.SalesOrderID = vParentID
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



