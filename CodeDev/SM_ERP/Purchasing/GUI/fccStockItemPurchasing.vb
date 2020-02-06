Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.DoorsetCore
Imports DatimCore

Public Class fccStockItemPurchasing

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pStockItems As colStockItems
    Private pSuppliers As colSuppliers
    ''Private pCurrentStockItem As dmStockItem
    Private pCurrentCategory As Integer
    Private pStockItemLocations As colStockItemLocations
    Private pStockItemInfos As colStockItemInfos
    Private pPOCOItemAllocationInfos As colPurchaseOrderInfos
    ''Private pPBMatReqInfos As colMaterialRequirementsinfos
    Public ProjectID As Integer
    Public IsBulkOrdering As Boolean

    Public ReadOnly Property DBConn As clsDBConnBase
        Get
            Return pDBConn
        End Get
    End Property

    Public ReadOnly Property RTISGlobal As AppRTISGlobal
        Get
            Return pRTISGlobal
        End Get
    End Property

    Public ReadOnly Property StockItems As colStockItems
        Get
            Return pStockItems
        End Get
    End Property


    Public ReadOnly Property StockItemInfos As colStockItemInfos
        Get
            Return pStockItemInfos
        End Get
    End Property


    Public Property CurrentCategory As Integer
        Get
            Return pCurrentCategory
        End Get
        Set(value As Integer)
            pCurrentCategory = value
        End Set
    End Property

    Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
        pDBConn = rDBConn
        pRTISGlobal = rRTISGlobal
        pStockItems = New colStockItems
        pStockItemInfos = New colStockItemInfos
    End Sub

    Public Sub LoadObject()
        pCurrentCategory = 0
        pStockItems = New colStockItems
        pStockItemLocations = New colStockItemLocations
        pStockItemInfos = New colStockItemInfos
        pPOCOItemAllocationInfos = New colPurchaseOrderInfos
        ''pPBMatReqInfos = New colMaterialRequirementInfos
        pSuppliers = New colSuppliers
        ''LoadStockItems()
    End Sub

    Public Sub LoadStockItems(rValueItem As Int32)


  End Sub

    Public Sub CreateStockItemInfo()
        Dim mStockItemInfo As clsStockItemInfo
        Dim mSIDict As New Dictionary(Of Integer, colStockItems)

        pStockItemInfos.Clear()

        Dim mStockItem As dmStockItem
        For Each mStockItem In pStockItems
            mStockItemInfo = New clsStockItemInfo
            mStockItemInfo.StockItem = mStockItem
            mSIDict.Add(mStockItem.StockItemID, New colStockItems)
            pStockItemInfos.Add(mStockItemInfo)
        Next

        ''For Each mSIL As dmStockItemLocation In pStockItemLocations
        ''    If mSIDict.ContainsKey(mSIL.StockItemID) Then
        ''        mSIProc = mSIDict(mSIL.StockItemID)
        ''        If mSIProc IsNot Nothing Then
        ''            mSIProc.StockItemLocations.Add(mSIL)
        ''        End If
        ''    End If
        ''Next

        ''For Each mPOII As clsPurchaseOrderItemInfo In pPOCOItemAllocationInfos
        ''    If mSIDict.ContainsKey(mPOII.StockItemID) Then
        ''        mSIProc = mSIDict(mPOII.StockItemID)
        ''        If mSIProc IsNot Nothing Then
        ''            mSIProc.POCallOffItemAlloctionInfos.Add(mPOII)
        ''        End If
        ''    End If
        ''Next

        ''For Each mMRI As clsMaterialRequirementInfo In pPBMatReqInfos
        ''    If mSIDict.ContainsKey(mMRI.MatReqStockItemID) Then
        ''        mSIProc = mSIDict(mMRI.MatReqStockItemID)
        ''        If mSIProc IsNot Nothing Then
        ''            mSIProc.PBMatReqInfos.Add(mMRI)
        ''        End If
        ''    End If
        ''Next

        ''For Each mKVP As KeyValuePair(Of Integer, clsSICurrentStockProcessor) In mSIDict
        ''    If mKVP.Value IsNot Nothing Then
        ''        'If mKVP.Value.ProposedQty > 0 Then
        ''        If mKVP.Value.StockItem.DefaultSupplier > 0 And pSuppliers IsNot Nothing Then
        ''            Dim mSupplier As dmSupplier
        ''            mSupplier = pSuppliers.ItemFromKey(mKVP.Value.StockItem.DefaultSupplier)
        ''            If mSupplier IsNot Nothing Then
        ''                mKVP.Value.DefaultSupplier = mSupplier.SupplierName
        ''            End If
        ''        End If
        ''        pSICurrentStockProcessors.Add(mKVP.Value)
        ''        ' End If
        ''    End If
        ''Next

    End Sub

    Public Sub SaveObject()
        Try

            'If pCurrentStockItem IsNot Nothing Then
            '  Dim mdsoStock As New dsoStock(pDBConn)
            '  mdsoStock.SaveStockItem(pCurrentStockItem)
            '  mdsoStock.SaveStockItemDrawings(pCurrentStockItemDrawings, pCurrentStockItem.StockItemID)

            '  mdsoStock = Nothing
            'End If

        Catch ex As Exception
            If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try
    End Sub



End Class
