''DTO Definition - SalesOrder (to SalesOrder)'Generated from Table:SalesOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrder : Inherits dtoBase
  Private pSalesOrder As dmSalesOrder

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrder"
    pKeyFieldName = "SalesOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrder.SalesOrderID
    End Get
    Set(ByVal value As Integer)
      pSalesOrder.SalesOrderID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrder.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrder.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderID", pSalesOrder.SalesOrderID)
    End If
    With pSalesOrder
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerID", .CustomerID)
      'DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPrice", StringToDBValue(.ProjectName))

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerContactID", .CustomerContactID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductCostBookID", .ProductCostBookID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProjectName", StringToDBValue(.ProjectName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EstimatorEmployeeID", .EstimatorEmployeeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderTypeID", .OrderTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderStatusENUM", .OrderStatusENUM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderNo", StringToDBValue(.OrderNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateEntered", DateToDBValue(.DateEntered))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InternalComments", StringToDBValue(.InternalComments))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VisibleNotes", StringToDBValue(.VisibleNotes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerRef", StringToDBValue(.CustomerRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ContractManagerID", .ContractManagerID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesAreaID", .SalesAreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DelAddress1", StringToDBValue(.DelAddress1))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DelAddress2", StringToDBValue(.DelAddress2))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HostCompanyID", .HostCompanyID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "BusinessSectorID", .BusinessSectorID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ClientInfo", StringToDBValue(.ClientInfo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FinishDate", DateToDBValue(.FinishDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DueTime", DateToDBValue(.DueTime))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesDelAreaID", .SalesDelAreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CustomerDelContacID", .CustomerDelContactID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ShippingCost", DBValueToDecimal(.ShippingCost))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrdersIssued", DBValueToBoolean(.WorkOrdersIssued))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PodioPath", StringToDBValue(.PodioPath))

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Version", StringToDBValue(.Version))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OrderPhaseType", .OrderPhaseType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentTermDesc", StringToDBValue(.PaymentTermDesc))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletID", .WoodPalletID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletType", .WoodPalletType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsDepatch", .IsDepatch)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CIFValue", .CIFValue)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrder Is Nothing Then SetObjectToNew()
      With pSalesOrder
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .CustomerID = DBReadInt32(rDataReader, "CustomerID")
        .CustomerContactID = DBReadInt32(rDataReader, "CustomerContactID")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        .EstimatorEmployeeID = DBReadInt32(rDataReader, "EstimatorEmployeeID")
        .OrderTypeID = DBReadInt32(rDataReader, "OrderTypeID")
        .OrderStatusENUM = DBReadInt32(rDataReader, "OrderStatusENUM")
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .DateEntered = DBReadDateTime(rDataReader, "DateEntered")
        .InternalComments = DBReadString(rDataReader, "InternalComments")
        .VisibleNotes = DBReadString(rDataReader, "VisibleNotes")
        .CustomerRef = DBReadString(rDataReader, "CustomerRef")
        .ContractManagerID = DBReadInt32(rDataReader, "ContractManagerID")
        .SalesAreaID = DBReadInt32(rDataReader, "SalesAreaID")
        .DelAddress1 = DBReadString(rDataReader, "DelAddress1")
        .DelAddress2 = DBReadString(rDataReader, "DelAddress2")
        .HostCompanyID = DBReadInt32(rDataReader, "HostCompanyID")
        .BusinessSectorID = DBReadInt32(rDataReader, "BusinessSectorID")
        .ProductCostBookID = DBReadInt32(rDataReader, "ProductCostBookID")

        .ClientInfo = DBReadString(rDataReader, "ClientInfo")
        .FinishDate = DBReadDateTime(rDataReader, "FinishDate")
        .DueTime = DBReadDateTime(rDataReader, "DueTime")
        .Version = DBReadString(rDataReader, "Version")
        .CustomerDelContactID = DBReadInt32(rDataReader, "CustomerDelContacID")
        .ShippingCost = DBReadDecimal(rDataReader, "ShippingCost")
        .WorkOrdersIssued = DBReadBoolean(rDataReader, "WorkOrdersIssued")
        .PodioPath = DBReadString(rDataReader, "PodioPath")
        .OrderPhaseType = DBReadByte(rDataReader, "OrderPhaseType")
        .PaymentTermDesc = DBReadString(rDataReader, "PaymentTermDesc")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        .WoodPalletType = DBReadInt32(rDataReader, "WoodPalletType")
        .IsDepatch = DBReadBoolean(rDataReader, "IsDepatch")
        .CIFValue = DBReadDecimal(rDataReader, "CIFValue")

        pSalesOrder.IsDirty = False
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
    pSalesOrder = New dmSalesOrder ' Or .NewBlankSalesOrder
    Return pSalesOrder

  End Function


  Public Function LoadSalesOrder(ByRef rSalesOrder As dmSalesOrder, ByVal vSalesOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderID)
    If mOK Then
      rSalesOrder = pSalesOrder
    Else
      rSalesOrder = Nothing
    End If
    pSalesOrder = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrder(ByRef rSalesOrder As dmSalesOrder) As Boolean
    Dim mOK As Boolean
    pSalesOrder = rSalesOrder
    mOK = SaveObject()
    pSalesOrder = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderCollection(ByRef rSalesOrders As colSalesOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rSalesOrders, mParams, "SalesOrderID")
    rSalesOrders.TrackDeleted = True
    If mOK Then rSalesOrders.IsDirty = False
    Return mOK
  End Function

  Public Function LoadSalesOrderCollectionByWhere(ByRef rSalesOrders As colSalesOrders, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rSalesOrders, mParams, "SalesOrderID", vWhere)
    rSalesOrders.TrackDeleted = True
    If mOK Then rSalesOrders.IsDirty = False
    Return mOK
  End Function



  Public Function LoadSalesOrderInfo(ByRef rSalesOrder As colSalesOrders, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '    mParams.Add("@SupplierID", vWhere)
    mOK = MyBase.LoadCollection(rSalesOrder, mParams, "SalesOrderID", vWhere)
    '  If mOK Then rPurchaseInvoiceTranCodeInfos.IsDirty = False
    Return mOK
  End Function

  Public Function SaveSalesOrderCollection(ByRef rCollection As colSalesOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrder In rCollection
      ''    If pSalesOrder.SalesOrderID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrder.SalesOrderID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrder In rCollection.DeletedItems
          If pSalesOrder.SalesOrderID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrder.SalesOrderID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrder In rCollection
        If pSalesOrder.IsDirty Or pSalesOrder.SalesOrderID = 0 Then 'Or pSalesOrder.SalesOrderID = 0

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



