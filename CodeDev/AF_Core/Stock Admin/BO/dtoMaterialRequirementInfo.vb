Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaterialRequirementInfo : Inherits dtoBase

  Private pStockItem As dmStockItem
  Private pMaterialRequirment As clsMaterialRequirementInfo

  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
    WoodMat = 3
  End Enum


  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    pMode = vMode
    SetTableDetails()

  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode

      Case eMode.Info, eMode.Processor
        pTableName = "vwMaterialRequirementPicking"
        pKeyFieldName = "MaterialRequirementID"
      Case eMode.WoodMat
        pTableName = "vwWoodMatReqInfo"
        pKeyFieldName = "MaterialRequirementID"
    End Select


    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges


  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaterialRequirment.MaterialRequirement.MaterialRequirementID

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

            .Description = DBReadString(rDataReader, "Description")
          End With


          With pMaterialRequirment.StockItem
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
            .StockCode = DBReadString(rDataReader, "STOCKITEMCODE")
            .Category = DBReadByte(rDataReader, "Category")
            .PartNo = DBReadString(rDataReader, "PartNo")
            .Description = DBReadString(rDataReader, "SIDESCRIPTION")
            .StdCost = DBReadDecimal(rDataReader, "StdCost")

          End With


          With pMaterialRequirment.WorkOrder
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .Description = DBReadString(rDataReader, "WODESCRIPTION")
            .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
            .PlannedDeliverDate = DBReadDate(rDataReader, "PlannedDeliverDate")
          End With

          With pMaterialRequirment.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")
          End With

          With pMaterialRequirment.SalesOrder
            .ProjectName = DBReadString(rDataReader, "ProjectName")
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

          End With


          With pMaterialRequirment.ProductFurniture
            .ProductFurnitureID = DBReadInt32(rDataReader, "ProductFurnitureID")
          End With


          With pMaterialRequirment.WorkOrder
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .Description = DBReadString(rDataReader, "Description")
            .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
            .Quantity = DBReadInt32(rDataReader, "Quantity")
            .WorkOrderID = DBReadInt32(rDataReader, "ObjectID")
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


  Protected Overrides Function SetObjectToNew() As Object
    Select Case pMode
      Case eMode.Info
        pMaterialRequirment = New clsMaterialRequirementInfo
      Case eMode.Processor
        pMaterialRequirment = New clsMaterialRequirementProcessor(New dmMaterialRequirement)
      Case eMode.WoodMat
        pMaterialRequirment = New clsMaterialRequirementInfo
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

