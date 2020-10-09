
''DTO Definition - SalesItemAssembly (to SalesItemAssembly)'Generated from Table:SalesItemAssembly

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesItemAssembly : Inherits dtoBase
  Private pSalesItemAssembly As dmSalesItemAssembly
  Private pMode As eMode

  Public Enum eMode
    SalesOrderItemAssembly = 1
    HouseTypeSalesItemAssembly = 2
  End Enum

  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    pMode = vMode
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode
      Case eMode.SalesOrderItemAssembly
        pTableName = "SalesOrderItemAssembly"
        pKeyFieldName = "SalesOrderItemAssemblyID"
      Case eMode.HouseTypeSalesItemAssembly
        pTableName = "HouseTypeSalesItemAssembly"
        pKeyFieldName = "HouseTypeSalesItemAssemblyID"
    End Select

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
      Select Case pMode
        Case eMode.SalesOrderItemAssembly
          DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderItemAssemblyID", pSalesItemAssembly.SalesItemAssemblyID)
        Case eMode.HouseTypeSalesItemAssembly
          DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "HouseTypeSalesItemAssemblyID", pSalesItemAssembly.SalesItemAssemblyID)
      End Select
    End If
    With pSalesItemAssembly
      Select Case pMode
        Case eMode.SalesOrderItemAssembly
          DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .ParentID)
          DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
          DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PricePerUnit", .PricePerUnit)
          DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPrice", .TotalPrice)

        Case eMode.HouseTypeSalesItemAssembly
          DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HouseTypeID", .ParentID)
      End Select
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Ref", StringToDBValue(.Ref))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesItemAssembly Is Nothing Then SetObjectToNew()
      With pSalesItemAssembly
        Select Case pMode
          Case eMode.SalesOrderItemAssembly
            .SalesItemAssemblyID = DBReadInt32(rDataReader, "SalesOrderItemAssemblyID")
            .ParentID = DBReadInt32(rDataReader, "SalesOrderID")
            .Quantity = DBReadInt32(rDataReader, "Quantity")
            .PricePerUnit = DBReadDecimal(rDataReader, "PricePerUnit")
            .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")
          Case eMode.HouseTypeSalesItemAssembly
            .SalesItemAssemblyID = DBReadInt32(rDataReader, "HouseTypeSalesItemAssemblyID")
            .ParentID = DBReadInt32(rDataReader, "HouseTypeID")
        End Select
        .Ref = DBReadString(rDataReader, "Ref")
        .Description = DBReadString(rDataReader, "Description")
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
    Select Case pMode
      Case eMode.SalesOrderItemAssembly
        mParams.Add("@SalesOrderID", vSalesOrderID)
        mOK = MyBase.LoadCollection(rSalesItemAssemblys, mParams, "SalesOrderItemAssemblyID")
      Case eMode.HouseTypeSalesItemAssembly
        mParams.Add("@HouseTypeID", vSalesOrderID)
        mOK = MyBase.LoadCollection(rSalesItemAssemblys, mParams, "HouseTypeSalesItemAssemblyID")

    End Select
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
      ''mParams.Add("@SalesOrderID", vSalesOrderID)
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
        If pSalesItemAssembly.IsDirty Or pSalesItemAssembly.ParentID <> vSalesOrderID Or pSalesItemAssembly.SalesItemAssemblyID = 0 Then 'Or pSalesItemAssembly.SalesItemAssemblyID = 0
          pSalesItemAssembly.ParentID = vSalesOrderID
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

