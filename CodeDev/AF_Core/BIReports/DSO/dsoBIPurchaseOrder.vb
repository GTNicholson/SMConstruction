
Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoBIPurchaseOrder
  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView

  Private pPurchaseOrderInfos As colPurchaseOrderInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pPurchaseOrderInfos
    End Get
    Set(value As Object)
      pPurchaseOrderInfos = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase Implements iDataSourceLoader.DBConn
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property ManReport As clsBIReportView Implements iDataSourceLoader.ManReport
    Get
      Return pBIReportView
    End Get
    Set(value As clsBIReportView)
      pBIReportView = value
    End Set
  End Property

  Public ReadOnly Property RecordCount As Integer Implements iDataSourceLoader.RecordCount
    Get
      Throw New NotImplementedException()
    End Get
  End Property

  Public Function LoadDataSource() As Boolean Implements iDataSourceLoader.LoadDataSource

    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""
    Dim dtoPurchaseOrderInfo As New dtoPurchaseOrderInfo(pDBConn)

    Dim mdtoSalesOrderPhaseItemInfo As New dtoSalesOrderPhaseItemInfo(pDBConn, dtoSalesOrderPhaseItemInfo.eMode.SalesOrderPhaseItemInfo)
    Dim mdtoPOA As dtoPurchaseOrderAllocation
    Dim mdtoPOI As dtoPurchaseOrderItem
    Dim mPOItemInfos As New colPOItemInfos

    Try

      pPurchaseOrderInfos = New colPurchaseOrderInfos()

      pDBConn.Connect()


      mSQLWhere1 = pBIReportView.ConditionSetters(0).FilterSQL
      mSQLWhere2 = pBIReportView.ConditionSetters(1).FilterSQL

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      dtoPurchaseOrderInfo.LoadPurchaseOrderInfoCollection(pPurchaseOrderInfos, mSQLWhere)

      If pPurchaseOrderInfos IsNot Nothing Then
        mdtoPOA = New dtoPurchaseOrderAllocation(pDBConn)
        mdtoPOI = New dtoPurchaseOrderItem(pDBConn)

        For Each mPOI As clsPurchaseOrderInfo In pPurchaseOrderInfos
          mPOItemInfos = New colPOItemInfos
          mdtoPOA.LoadPurchaseOrderAllocationCollection(mPOI.PurchaseOrder.PurchaseOrderAllocations, mPOI.PurchaseOrder.PurchaseOrderID)


          mdtoSalesOrderPhaseItemInfo.LoadSOPICollectionByWhere(mPOI.SalesOrderPhaseItemInfos, "")

          mdtoPOI.LoadPurchaseOrderItemCollection(mPOI.PurchaseOrder.PurchaseOrderItems, mPOI.PurchaseOrder.PurchaseOrderID)

          For Each mPOItem As dmPurchaseOrderItem In mPOI.PurchaseOrder.PurchaseOrderItems
            If String.IsNullOrEmpty(mPOItem.Description) = False Then
              mPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
            End If
          Next
          mPOI.POItemInfos = mPOItemInfos

        Next



      End If




    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Function
End Class

