Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderItemAllocationInfo : Inherits dtoBase

  Private pStockItem As dmStockItem
  Private pPurchaseOrderItemAllocationInfo As clsPurchaseOrderItemAllocationInfo
  Private pPurchaseOrderItem As dmPurchaseOrderItem
  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
  End Enum


  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    SetTableDetails()
    pMode = vMode
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwPurchaseOrderItemAllocationInfo"
    pKeyFieldName = "PurchaseOrderItemAllocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderItemAllocationInfo.PurchaseOrderItemAllocationID

    End Get
    Set(ByVal value As Integer)
      ''pStockItemTransactionLogInfo.StockCode = value
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
      If pPurchaseOrderItemAllocationInfo Is Nothing Then SetObjectToNew()

      With pPurchaseOrderItemAllocationInfo
        .SUPPLIERCOMPANYNAME = DBReadString(rDataReader, "CompanyName")
        .PONum = DBReadString(rDataReader, "PONum")
        .RequiredDate = DBReadDate(rDataReader, "RequiredDate")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")

      End With

      With pPurchaseOrderItemAllocationInfo.PurchaseOrderItemAllocation

        .PurchaseOrderItemAllocationID = DBReadInt32(rDataReader, "PurchaseOrderItemAllocationID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .ReceivedQty = DBReadDecimal(rDataReader, "ReceivedQty")
        .CallOffID = DBReadInt32(rDataReader, "CallOffID")
      End With


      With pPurchaseOrderItemAllocationInfo.PurchaseOrder
        ''.PONum = DBReadString(rDataReader, "PONum")
        ''.RequiredDate = DBReadDate(rDataReader, "RequiredDate")
        .Status = DBReadByte(rDataReader, "POStatus")
        .SubmissionDate = DBReadDate(rDataReader, "SubmissionDate")
        .DefaultCurrency = DBReadInt32(rDataReader, "DefaultCurrency")
        .ExchangeRateValue = DBReadDecimal(rDataReader, "ExchangeRateValue")
        .AccoutingCategoryID = DBReadInt32(rDataReader, "AccoutingCategoryID")
        .Category = DBReadByte(rDataReader, "PO_CATEGORY")
      End With

      With pPurchaseOrderItemAllocationInfo.PurchaseOrderItem

        .PurchaseOrderItemID = DBReadInt32(rDataReader, "PurchaseOrderItemID")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .Status = DBReadByte(rDataReader, "Status")
        .QtyRequired = DBReadDecimal(rDataReader, "QtyRequired")
        .Description = DBReadString(rDataReader, "Description")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .UoM = DBReadInt32(rDataReader, "UoM")
        .VatValue = DBReadDecimal(rDataReader, "VatValue")
        .RetentionValue = DBReadDecimal(rDataReader, "RetentionValue")
      End With
      With pPurchaseOrderItemAllocationInfo.StockItem
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "STOCKDESCRIPTION")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .PartNo = DBReadString(rDataReader, "PartNo")
        .Category = DBReadByte(rDataReader, "Category")
      End With

      With pPurchaseOrderItemAllocationInfo.SalesOrder
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        ''.Description = DBReadString(rDataReader, "WODESCRIPTION")
      End With

      With pPurchaseOrderItemAllocationInfo.SalesOrderPhase
        .JobNo = DBReadString(rDataReader, "JobNo")

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
    Select Case pMode
      Case eMode.Info
        pPurchaseOrderItemAllocationInfo = New clsPurchaseOrderItemAllocationInfo
      Case eMode.Processor
        pPurchaseOrderItemAllocationInfo = New clsPurchaseOrderItemAllocationProcessor(New dmPurchaseOrderItemAllocation)
    End Select


    Return pPurchaseOrderItemAllocationInfo

  End Function


  Public Function LoadPurchaseOrderItemAllocationProcessorsByWhere(ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rPurchaseOrderProcessors, mParams, "PurchaseOrderItemAllocationID", vWhere)
    Return mOK
  End Function

  Public Function LoadPurchaseOrderItemAllocationInfos(ByRef rvwPurchaseOrderItemAllocationInfo As colPurchaseOrderItemAllocationInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rvwPurchaseOrderItemAllocationInfo, mParams, "PurchaseOrderItemAllocationID", vWhere)
    Return mOK
  End Function


End Class
