Imports RTIS.CommonVB

Public Class fccPurchaseOrderConsole
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pMaterialRequirementGroup As Integer
  Private pOpenPOs As colPurchaseOrders
  Private pRefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker

  Private pSubSuppliersRefList As colSuppliers

  Public Sub New()
    pMaterialRequirementGroup = 1
    pSubSuppliersRefList = New colSuppliers
    pRefreshTracker = New RTIS.Elements.clsBasicBrowseRefreshTracker
  End Sub

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  ''Public Property RefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker
  ''  Get
  ''    Return pRefreshTracker
  ''  End Get
  ''  Set(value As RTIS.Elements.clsBasicBrowseRefreshTracker)
  ''    pRefreshTracker = value
  ''  End Set
  ''End Property

  ''Public Property MaterialRequirementGroup() As Integer
  ''  Get
  ''    Return pMaterialRequirementGroup
  ''  End Get
  ''  Set(value As Integer)
  ''    pMaterialRequirementGroup = value
  ''  End Set
  ''End Property

  Public ReadOnly Property IsDirty As Boolean
    Get
      ''MsgBox("todo")
    End Get
  End Property

  Public Property OpenPOs As colPurchaseOrders
    Get
      Return pOpenPOs
    End Get
    Set(value As colPurchaseOrders)
      pOpenPOs = value
    End Set
  End Property

  Public Function SaveObject() As Boolean

  End Function



  Public Function LoadPurchaseOrderInfos(ByVal vWhere As String) As colPurchaseOrderInfos
    Dim mPOInfos As New colPurchaseOrderInfos
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Try
      ''mdsoPurchaseOrder.LoadPurchaseOrderInfos(mPOInfos, vWhere, "PurchaseOrderID")
      mdsoPurchaseOrder.LoadPurchaseOrderInfos(mPOInfos, vWhere) ''Adapted according to HallAndTawse
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoPurchaseOrder = Nothing
    End Try

    Return mPOInfos
  End Function

  ''Public Function FindCreateDefaultPO(ByVal vSupplierID As Integer) As dmPurchaseOrder
  ''  Dim mPO As dmPurchaseOrder
  ''  Dim mFound As Boolean
  ''  Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
  ''  Dim mRetVal As dmPurchaseOrder = Nothing
  ''  If pOpenPOs Is Nothing Then pOpenPOs = New colPurchaseOrders
  ''  For Each mPO In pOpenPOs
  ''    If mPO.SupplierID = vSupplierID Then
  ''      mFound = True
  ''      mRetVal = mPO
  ''      Exit For
  ''    End If
  ''  Next

  ''  If Not mFound Then
  ''    'Create and save a new Purchase Order
  ''    mPO = New dmPurchaseOrder
  ''    mPO.Status = ePurchaseOrderStatus.ePOSOutstanding
  ''    mPO.SupplierID = vSupplierID
  ''    mPO.DateSubmitted = Today
  ''    mPO.CreatedInERP = True

  ''    mdsoPurchasing.SavePurchaseOrder(mPO, False)

  ''    mRetVal = mPO

  ''  End If

  ''  Return mRetVal

  ''End Function

End Class
