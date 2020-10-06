
''DTO Definition - SalesItemAssembly (to SalesItemAssembly)'Generated from Table:SalesItemAssembly

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesItemAssembly : Inherits dtoBase
  Private pSalesItemAssembly As dmSalesItemAssembly

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderItemAssembly"
    pKeyFieldName = "SalesOrderItemAssemblyID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesItemAssembly.SalesItemAssemblyID
    End Get
    Set(ByVal value As Integer)
      pSalesItemAssembly.SalesItemAssemblyID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesItemAssembly.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesItemAssembly.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderItemAssemblyID", pSalesItemAssembly.SalesItemAssemblyID)
    End If
    With pSalesItemAssembly
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
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
      If pSalesItemAssembly Is Nothing Then SetObjectToNew()
      With pSalesItemAssembly
        .SalesItemAssemblyID = DBReadInt32(rDataReader, "SalesOrderItemAssemblyID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .Ref = DBReadString(rDataReader, "Ref")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .PricePerUnit = DBReadDecimal(rDataReader, "PricePerUnit")
        .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")
        pSalesItemAssembly.IsDirty = False
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
    pSalesItemAssembly = New dmSalesItemAssembly ' Or .NewBlankSalesItemAssembly
    Return pSalesItemAssembly

  End Function


  Public Function LoadSalesItemAssembly(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByVal vSalesItemAssemblyID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesItemAssemblyID)
    If mOK Then
      rSalesItemAssembly = pSalesItemAssembly
    Else
      rSalesItemAssembly = Nothing
    End If
    pSalesItemAssembly = Nothing
    Return mOK
  End Function


  Public Function SaveSalesItemAssembly(ByRef rSalesItemAssembly As dmSalesItemAssembly) As Boolean
    Dim mOK As Boolean
    pSalesItemAssembly = rSalesItemAssembly
    mOK = SaveObject()
    pSalesItemAssembly = Nothing
    Return mOK
  End Function


  Public Function LoadSalesItemAssemblyCollection(ByRef rSalesItemAssemblys As colSalesItemAssemblys, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderID", vSalesOrderID)
    mOK = MyBase.LoadCollection(rSalesItemAssemblys, mParams, "SalesOrderItemAssemblyID")
    rSalesItemAssemblys.TrackDeleted = True
    If mOK Then rSalesItemAssemblys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesItemAssemblyCollection(ByRef rCollection As colSalesItemAssemblys, ByVal vSalesOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderID", vSalesOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesItemAssembly In rCollection
      ''    If pSalesItemAssembly.SalesItemAssemblyID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesItemAssembly.SalesItemAssemblyID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesItemAssembly In rCollection.DeletedItems
          If pSalesItemAssembly.SalesItemAssemblyID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesItemAssembly.SalesItemAssemblyID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesItemAssembly In rCollection
        If pSalesItemAssembly.IsDirty Or pSalesItemAssembly.SalesOrderID <> vSalesOrderID Or pSalesItemAssembly.SalesItemAssemblyID = 0 Then 'Or pSalesItemAssembly.SalesItemAssemblyID = 0
          pSalesItemAssembly.SalesOrderID = vSalesOrderID
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

