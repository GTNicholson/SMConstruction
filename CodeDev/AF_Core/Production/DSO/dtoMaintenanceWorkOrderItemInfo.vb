﻿Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaintenanceWorkOrderItemInfo : Inherits dtoBase

  Private pMaterialRequirment As clsMaintenanceMaterialRequirementInfo

  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
  End Enum


  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    pMode = vMode
    SetTableDetails()

  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode

      Case eMode.Info, eMode.Processor
        pTableName = "vwMaintenanceWorkOrderItemTracking"
        pKeyFieldName = "MaterialRequirementID"

    End Select


    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges


  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaterialRequirment.MaterialRequirementID

    End Get
    Set(ByVal value As Integer)
      'pStockItemTransactionLogInfo.StockCode = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = False
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      Return Nothing
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pMaterialRequirment Is Nothing Then SetObjectToNew()

      Select Case pMode
        Case eMode.Info, eMode.Processor


          pMaterialRequirment.OSQty = DBReadDecimal(rDataReader, "OSQty")
          pMaterialRequirment.WorkOrderAllocationID = DBReadInt32(rDataReader, "WorkOrderAllocationID")
          pMaterialRequirment.SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
          pMaterialRequirment.SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
          pMaterialRequirment.SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
          pMaterialRequirment.ItemNumber = DBReadString(rDataReader, "ItemNumber")
          pMaterialRequirment.SOIDescription = DBReadString(rDataReader, "SOIDescription")
          pMaterialRequirment.StockItemLocationsQty = DBReadDecimal(rDataReader, "StockItemLocationsQty")
          pMaterialRequirment.OrderedQty = DBReadDecimal(rDataReader, "OrderedQty")
          pMaterialRequirment.ReceivedQty = DBReadDecimal(rDataReader, "ReceivedQty")
          pMaterialRequirment.CurrentOrderQty = DBReadDecimal(rDataReader, "CurrentOrderQty")
          pMaterialRequirment.TotalOTQuantity = DBReadDecimal(rDataReader, "TotalAreaQuantity")
          pMaterialRequirment.OutstandingFromStockQtyHousing = DBReadDecimal(rDataReader, "OutstandingFromStockQty") ' DBReadDecimal(rDataReader, "OutstandingFromStockQtyHousing")
          'pMaterialRequirment.OutstandingFromStockQtyFurniture = DBReadDecimal(rDataReader, "OutstandingFromStockQtyFurniture")

          pMaterialRequirment.DateCommitted = DBReadDate(rDataReader, "DateCommitted")
          pMaterialRequirment.DateEntered = DBReadDate(rDataReader, "DateEntered")
          With pMaterialRequirment.MaterialRequirement

            .MaterialRequirementID = DBReadInt32(rDataReader, "MaterialRequirementID")
            .StockCode = DBReadString(rDataReader, "StockCode")
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
            .AreaID = DBReadInt32(rDataReader, "AreaID")
            .Comments = DBReadString(rDataReader, "Comments")
            .MaterialRequirementType = DBReadByte(rDataReader, "MaterialRequirementType")
            .Quantity = DBReadDecimal(rDataReader, "Quantity")
            .UoM = DBReadInt32(rDataReader, "UoM")
            .SetPickedQty(DBReadDecimal(rDataReader, "PickedQty"))
            .SupplierStockCode = DBReadString(rDataReader, "SupplierStockCode")
            .ObjectID = DBReadInt32(rDataReader, "WorkOrderID")
            .Description = DBReadString(rDataReader, "Description")
            .FromStockQty = DBReadDecimal(rDataReader, "FromStockQty")
            .SetReturndQty(DBReadDecimal(rDataReader, "ReturnQty"))
            .IsFromStockValidated = DBReadBoolean(rDataReader, "IsFromStockValidated")
            .DateChange = DBReadDate(rDataReader, "DateChange")
          End With


          With pMaterialRequirment.StockItem
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
            .StockCode = DBReadString(rDataReader, "STOCKITEMCODE")
            .Category = DBReadByte(rDataReader, "Category")
            .PartNo = DBReadString(rDataReader, "PartNo")
            .Description = DBReadString(rDataReader, "SIDESCRIPTION")
            .AverageCost = DBReadDecimal(rDataReader, "AverageCost")
            .StdCost = DBReadDecimal(rDataReader, "StdCost")

          End With


          With pMaterialRequirment.WorkOrder
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .Description = DBReadString(rDataReader, "WODESCRIPTION")
            .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
            .PlannedDeliverDate = DBReadDate(rDataReader, "PlannedDeliverDate")
            .DateCreated = DBReadDate(rDataReader, "DateCreated")
            .PurchasingDate = DBReadDate(rDataReader, "PurchasingDate")

          End With

          With pMaterialRequirment.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")
          End With

          With pMaterialRequirment.SalesOrder
            .ProjectName = DBReadString(rDataReader, "ProjectName")
            .OrderNo = DBReadString(rDataReader, "OrderNo")
          End With

          'With pMaterialRequirment.StockItemTransactionLog
          '  .TransactionDate = DBReadDate(rDataReader, "TransactionDate")
          '  .TransactionValuationDollar = DBReadDecimal(rDataReader, "TransactionValuationDollar")
          'End With

        Case eMode.WoodMat
          With pMaterialRequirment.MaterialRequirement

            .MaterialRequirementID = DBReadInt32(rDataReader, "MaterialRequirementID")
            .Description = DBReadString(rDataReader, "Description")
            .UnitPiece = DBReadInt32(rDataReader, "UnitPiece")
            .NetLenght = DBReadDecimal(rDataReader, "NetLenght")
            .NetWidth = DBReadDecimal(rDataReader, "NetWidth")
            .NetThickness = DBReadDecimal(rDataReader, "NetThickness")
            .QualityType = DBReadInt32(rDataReader, "QualityType")
            .WoodSpecie = DBReadInt32(rDataReader, "WoodSpecie")
            .PiecesPerComponent = DBReadDecimal(rDataReader, "PiecesPerComponent")
            .SetPickedQty(DBReadDecimal(rDataReader, "PickedQty"))
            .SetReturndQty(DBReadDecimal(rDataReader, "ReturnQty"))

          End With





          With pMaterialRequirment.WorkOrder
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .Description = DBReadString(rDataReader, "Description")
            .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
            .Quantity = DBReadInt32(rDataReader, "Quantity")
            .WorkOrderID = DBReadInt32(rDataReader, "ObjectID")
            .ProductID = DBReadInt32(rDataReader, "ProductStructureID")
          End With

          With pMaterialRequirment.SalesOrder
            .ProjectName = DBReadString(rDataReader, "ProjectName")
          End With

          With pMaterialRequirment.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")
          End With

          With pMaterialRequirment.StockItem
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
          End With
      End Select




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
  Public Function LoadWorkOrderPhaseMatReqInfosByWhere(ByRef rSalesOrderPhaseMatReqInfos As colMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rSalesOrderPhaseMatReqInfos, mParams, "MaterialRequirementID", vWhere)
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    Select Case pMode
      Case eMode.Info
        pMaterialRequirment = New clsMaintenanceMaterialRequirementInfo
      Case eMode.Processor
        pMaterialRequirment = New clsMaterialRequirementProcessor(New dmMaterialRequirement)
      Case eMode.WoodMat
        pMaterialRequirment = New clsMaintenanceMaterialRequirementInfo
    End Select


    Return pMaterialRequirment

  End Function


  Public Function LoadMaterialRequirementProcessorsByWhere(ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rMaterialRequirementProcessors, mParams, "MaterialRequirementID", vWhere)
    Return mOK
  End Function

  Public Function LoadWoodMatReqByWhere(ByRef rWoodMatReq As colMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rWoodMatReq, mParams, "MaterialRequirementID", vWhere)
    Return mOK
  End Function

  Public Function LoadMaterialRequirementCollection(ByRef rMaterialRequirementInfos As colMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    ''mParams.Add("@ParentID", vParentID)
    If vWhere <> "" Then
      mOK = MyBase.LoadCollection(rMaterialRequirementInfos, mParams, "MaterialRequirementID", vWhere)
    Else
      mOK = MyBase.LoadCollection(rMaterialRequirementInfos, mParams, "MaterialRequirementID")
    End If

    Return mOK


  End Function

End Class

