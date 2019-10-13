''DTO Definition - WorkOrder (to WorkOrder)'Generated from Table:WorkOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWorkOrder : Inherits dtoBase
  Private pWorkOrder As dmWorkOrder

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WorkOrder"
    pKeyFieldName = "WorkOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrder.WorkOrderID
    End Get
    Set(ByVal value As Integer)
      pWorkOrder.WorkOrderID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWorkOrder.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWorkOrder.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WorkOrderID", pWorkOrder.WorkOrderID)
    End If
    With pWorkOrder
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderID", .SalesOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmployeeID", .EmployeeID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderItemID", .SalesOrderItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductTypeID", .ProductTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderNo", StringToDBValue(.WorkOrderNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PlannedStartDate", DateToDBValue(.PlannedStartDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderType", .WorkOrderType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodSpecieID", .WoodSpecieID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodFinish", .WoodFinish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPrice", .UnitPrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ImageFile", StringToDBValue(.ImageFile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkcentreID", .WorkcentreID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FurnitureCategoryID", .FurnitureCategoryID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubFurnitureCategoryID", .SubFurnitureCategoryID)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Machining", .Machining)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Assembley", .Assembley)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Sanding", .Sanding)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Painting", .Painting)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MetalWork", .MetalWork)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Upholstery", .Upholstery)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubContract", .SubContract)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyPerSalesItem", .QtyPerSalesItem)
      'DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmployeeName", StringToDBValue(.EmployeeName))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWorkOrder Is Nothing Then SetObjectToNew()
      With pWorkOrder
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .ProductTypeID = DBReadInt32(rDataReader, "ProductTypeID")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
        .Description = DBReadString(rDataReader, "Description")
        .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .WorkOrderType = DBReadInt32(rDataReader, "WorkOrderType")
        .WoodSpecieID = DBReadInt32(rDataReader, "WoodSpecieID")
        .WoodFinish = DBReadInt32(rDataReader, "WoodFinish")
        .ImageFile = DBReadString(rDataReader, "ImageFile")
        .WorkcentreID = DBReadInt32(rDataReader, "WorkcentreID")

        .FurnitureCategoryID = DBReadInt32(rDataReader, "FurnitureCategoryID")
        .SubFurnitureCategoryID = DBReadInt32(rDataReader, "SubFurnitureCategoryID")

        .EmployeeID = DBReadInt32(rDataReader, "EmployeeID")


        .Machining = DBReadBoolean(rDataReader, "Machining")
        .Assembley = DBReadBoolean(rDataReader, "Assembley")
        .Sanding = DBReadBoolean(rDataReader, "Sanding")
        .Painting = DBReadBoolean(rDataReader, "Painting")
        .MetalWork = DBReadBoolean(rDataReader, "MetalWork")
        .Upholstery = DBReadBoolean(rDataReader, "Upholstery")
        .SubContract = DBReadBoolean(rDataReader, "SubContract")

        .QtyPerSalesItem = DBReadInt32(rDataReader, "QtyPerSalesItem")


        '.EmployeeName = DBReadString(rDataReader, "EmployeeName")
        pWorkOrder.IsDirty = False
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
    pWorkOrder = New dmWorkOrder ' Or .NewBlankWorkOrder
    Return pWorkOrder

  End Function


  Public Function LoadWorkOrder(ByRef rWorkOrder As dmWorkOrder, ByVal vWorkOrderID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWorkOrderID)
    If mOK Then
      rWorkOrder = pWorkOrder
    Else
      rWorkOrder = Nothing
    End If
    pWorkOrder = Nothing
    Return mOK
  End Function


  Public Function SaveWorkOrder(ByRef rWorkOrder As dmWorkOrder) As Boolean
    Dim mOK As Boolean
    pWorkOrder = rWorkOrder
    mOK = SaveObject()
    pWorkOrder = Nothing
    Return mOK
  End Function


  Public Function LoadWorkOrderCollection(ByRef rWorkOrders As colWorkOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderItemID", vParentID)
    mOK = MyBase.LoadCollection(rWorkOrders, mParams, "WorkOrderID")
    rWorkOrders.TrackDeleted = True
    If mOK Then rWorkOrders.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWorkOrderCollection(ByRef rCollection As colWorkOrders, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWorkOrder In rCollection.DeletedItems
          If pWorkOrder.WorkOrderID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWorkOrder.WorkOrderID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWorkOrder In rCollection
        If pWorkOrder.IsDirty Or pWorkOrder.WorkOrderID = 0 Or pWorkOrder.SalesOrderItemID = 0 Then
          pWorkOrder.SalesOrderItemID = vParentID
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


