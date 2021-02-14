Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemTransactionLogInfo : Inherits dtoBase

  Private pStockItemTransactionLogInfo As clsStockItemTransactionLogInfo
  Private pMode As eMode
  Public Enum eMode
    StockItemTransactionLogInfo = 1
    WoodStockItemTransactionLogInfo = 2
  End Enum
  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal veLoadingMode As eMode)
    MyBase.New(rDBSource)
    pMode = veLoadingMode
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode

      Case eMode.StockItemTransactionLogInfo
        pTableName = "vwStockItemTransactionLogInfo"
        pKeyFieldName = "StockItemTransactionLogID"
      Case eMode.WoodStockItemTransactionLogInfo
        pTableName = "vwStockItemWoodTransactionLogInfo"
        pKeyFieldName = "StockItemTransactionLogID"
    End Select


    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemTransactionLogInfo.StockItemTransactionLogID
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
      If pStockItemTransactionLogInfo Is Nothing Then SetObjectToNew()

      Select Case pMode
        Case eMode.StockItemTransactionLogInfo

          With pStockItemTransactionLogInfo
            .StockItemTransactionLogID = DBReadInt32(rDataReader, "StockItemTransactionLogID")
            .TransQuantity = DBReadDecimal(rDataReader, "Tranvalue")
            .PrevValue = DBReadDecimal(rDataReader, "PrevValue")
            .NewValue = DBReadDecimal(rDataReader, "NewValue")
            .TransType = DBReadByte(rDataReader, "TransactionType")
            .RefObjectType = DBReadByte(rDataReader, "RefObjectType")
            .RefObjectID = DBReadInt32(rDataReader, "RefObjectID")
            ''.GRNumber = DBReadString(rDataReader, "GRNumber")
            .TransDate = DBReadDateTime(rDataReader, "TransactionDate")
            ''.SupplierName = DBReadString(rDataReader, "SupplierName")
            ''.PONum = DBReadString(rDataReader, "PONum")
            ''.ChangeDetails = DBReadString(rDataReader, "ChangeDetails")
            .StockTakeDesc = DBReadString(rDataReader, "StockTakeDescription")
            .UserName = DBReadString(rDataReader, "UserName")
            .TransactionValuation = DBReadDecimal(rDataReader, "TransactionValuation")
            .StockValuation = DBReadDecimal(rDataReader, "StockValuation")
            .ReferenceNo = DBReadString(rDataReader, "ReferenceNo")
            .TransactionValuationDollar = DBReadDecimal(rDataReader, "TransactionValuationDollar")


          End With
          With pStockItemTransactionLogInfo.CurrentStockItem
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
            .Category = DBReadByte(rDataReader, "Category")
            .ItemType = DBReadByte(rDataReader, "ItemType")
            .StockCode = DBReadString(rDataReader, "StockCode")
            .Description = DBReadString(rDataReader, "Description")
            .StdCost = DBReadDecimal(rDataReader, "StdCost")
            .AverageCost = DBReadDecimal(rDataReader, "AverageCost")
          End With

          With pStockItemTransactionLogInfo.WorkOrder
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .Description = DBReadString(rDataReader, "WODESCRIPTION")

          End With

          With pStockItemTransactionLogInfo.MaterialRequirement
            .AreaID = DBReadInt32(rDataReader, "AreaID")

          End With

          With pStockItemTransactionLogInfo.SalesOrder
            .ProjectName = DBReadString(rDataReader, "ProjectName")

          End With

          With pStockItemTransactionLogInfo.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")

          End With

        Case eMode.WoodStockItemTransactionLogInfo
          With pStockItemTransactionLogInfo
            .StockItemTransactionLogID = DBReadInt32(rDataReader, "StockItemTransactionLogID")
            .TransQuantity = DBReadDecimal(rDataReader, "Tranvalue")
            .PrevValue = DBReadDecimal(rDataReader, "PrevValue")
            .NewValue = DBReadDecimal(rDataReader, "NewValue")
            .TransType = DBReadByte(rDataReader, "TransactionType")
            .RefObjectType = DBReadByte(rDataReader, "RefObjectType")
            .RefObjectID = DBReadInt32(rDataReader, "RefObjectID")
            ''.GRNumber = DBReadString(rDataReader, "GRNumber")
            .TransDate = DBReadDateTime(rDataReader, "TransactionDate")
            ''.SupplierName = DBReadString(rDataReader, "SupplierName")
            ''.PONum = DBReadString(rDataReader, "PONum")
            ''.ChangeDetails = DBReadString(rDataReader, "ChangeDetails")
            .StockTakeDesc = DBReadString(rDataReader, "StockTakeDescription")
            .UserName = DBReadString(rDataReader, "UserName")
            .TransactionValuation = DBReadDecimal(rDataReader, "TransactionValuation")
            .StockValuation = DBReadDecimal(rDataReader, "StockValuation")
            .ReferenceNo = DBReadString(rDataReader, "ReferenceNo")
            .TransactionValuationDollar = DBReadDecimal(rDataReader, "TransactionValuationDollar")


          End With
          With pStockItemTransactionLogInfo.CurrentStockItem
            .StockItemID = DBReadInt32(rDataReader, "StockItemID")
            .Category = DBReadByte(rDataReader, "Category")
            .ItemType = DBReadByte(rDataReader, "ItemType")
            .StockCode = DBReadString(rDataReader, "StockCode")
            .Description = DBReadString(rDataReader, "Description")
            .StdCost = DBReadDecimal(rDataReader, "StdCost")
          End With

          With pStockItemTransactionLogInfo
            .PalletRef = DBReadString(rDataReader, "PalletRef")
            .PalletOutsideRef = DBReadString(rDataReader, "RefPalletOutside")
            .LocationID = DBReadByte(rDataReader, "LocationID")
          End With

          With pStockItemTransactionLogInfo.MaterialRequirement
            .AreaID = DBReadInt32(rDataReader, "AreaID")

          End With

          With pStockItemTransactionLogInfo.SalesOrder
            .ProjectName = DBReadString(rDataReader, "ProjectName")

          End With

          With pStockItemTransactionLogInfo.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")

          End With

          With pStockItemTransactionLogInfo
            .WorkOrder.Description = DBReadString(rDataReader, "WODESCRIPTION")
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
    pStockItemTransactionLogInfo = New clsStockItemTransactionLogInfo
    Return pStockItemTransactionLogInfo

  End Function



  Public Function LoadStockItemTransactionLogInfoCollection(ByRef rStockItemTransactionLogInfos As colStockItemTransactionLogInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rStockItemTransactionLogInfos, mParams, "StockItemTransactionLogID", vWhere)
    Return mOK
  End Function


End Class

