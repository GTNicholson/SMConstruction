﻿''Class Definition - PurchaseOrder (to PurchaseOrder)'Generated from Table:PurchaseOrder
Imports RTIS.CommonVB

Public Class dmPurchaseOrder : Inherits dmBase
  Private pPurchaseOrderID As Int32
  Private pPONum As String
  Private pSupplierID As Int32
  Private pSupplierContactName As String
  Private pSupplierContactTel As String
  Private pCategory As Byte
  Private pSubmissionDate As DateTime
  Private pStatus As Byte
  Private pDelStatus As Byte
  Private pInstructions As String
  Private pComments As String
  Private pBuyerID As Byte
  Private pAcknowledgementNo As String
  Private pOrderType As Byte
  Private pCarriage As Double
  Private pVatRate As Decimal
  Private pRequiredDate As DateTime
  Private pPurchaseCategory As Byte
  Private pCoCOrder As Boolean
  Private pCoCType As Byte
  Private pPriceGross As Decimal
  Private pTotalPrice As Decimal
  Private pVATRateCode As Byte
  Private pApplyVATToCarriage As Boolean
  Private pDeliveryContact As String
  Private pDeliveryTel As String
  Private pDeliveryEmail As String

  Private pCallOffType As Byte
  Private pSupplierContactID As Integer
  Private pSupplierRef As String
  Private pLastStatusChangeDate As Date
  Private pFilename As String

  Private pDeliveryAddress As RTIS.ERPCore.dmPostalAddress
  Private pSupplierAddress As RTIS.ERPCore.dmPostalAddress
  Private pInvoiceAddress As RTIS.ERPCore.dmPostalAddress

  Private pPurchaseOrderItems As colPurchaseOrderItems

  Private pSupplier As dmSupplier
  Private pPurchaseOrderAllocations As colPurchaseOrderAllocations

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pPurchaseOrderItems = New colPurchaseOrderItems(Me)

    pDeliveryAddress = New RTIS.ERPCore.dmPostalAddress
    pSupplierAddress = New RTIS.ERPCore.dmPostalAddress
    pInvoiceAddress = New RTIS.ERPCore.dmPostalAddress
    pPurchaseOrderAllocations = New colPurchaseOrderAllocations
    pSupplier = New dmSupplier
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pPurchaseOrderItems = Nothing
    pPurchaseOrderAllocations = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If Not mAnyDirty Then mAnyDirty = PurchaseOrderItems.IsDirty
      If Not mAnyDirty Then mAnyDirty = pDeliveryAddress.IsDirty
      If Not mAnyDirty Then mAnyDirty = pSupplierAddress.IsDirty
      If Not mAnyDirty Then mAnyDirty = pInvoiceAddress.IsDirty
      If Not mAnyDirty Then mAnyDirty = PurchaseOrderAllocations.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    PurchaseOrderID = 0
    PurchaseOrderItems.ClearKeys()
    PurchaseOrderAllocations.ClearKeys()
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPurchaseOrder)
      .PurchaseOrderID = PurchaseOrderID
      .PONum = PONum
      .SupplierID = SupplierID
      .SupplierContactName = SupplierContactName
      .SupplierContactTel = SupplierContactTel
      .Category = Category
      .SubmissionDate = SubmissionDate
      .Status = Status
      .DelStatus = DelStatus
      .Instructions = Instructions
      .Comments = Comments
      .BuyerID = BuyerID
      .AcknowledgementNo = AcknowledgementNo
      .OrderType = OrderType
      .Carriage = Carriage
      .VatRate = VatRate
      .RequiredDate = RequiredDate
      .PurchaseCategory = PurchaseCategory
      .CoCOrder = CoCOrder
      .CoCType = CoCType
      .PriceGross = PriceGross
      .TotalPrice = TotalPrice
      .FileName = FileName

      'Add entries here for each collection and class property
      .PurchaseOrderAllocations = PurchaseOrderAllocations.Clone
      .PurchaseOrderItems = PurchaseOrderItems.Clone
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PurchaseOrderID() As Int32
    Get
      PurchaseOrderID = pPurchaseOrderID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderID <> value Then IsDirty = True
      pPurchaseOrderID = value
    End Set
  End Property

  Public Property PONum() As String
    Get
      PONum = pPONum
    End Get
    Set(ByVal value As String)
      If pPONum <> value Then IsDirty = True
      pPONum = value
    End Set
  End Property

  Public Property SupplierID() As Int32
    Get
      SupplierID = pSupplierID
    End Get
    Set(ByVal value As Int32)
      If pSupplierID <> value Then IsDirty = True
      pSupplierID = value
    End Set
  End Property

  Public Property SupplierContactName() As String
    Get
      SupplierContactName = pSupplierContactName
    End Get
    Set(ByVal value As String)
      If pSupplierContactName <> value Then IsDirty = True
      pSupplierContactName = value
    End Set
  End Property

  Public Property SupplierContactTel() As String
    Get
      SupplierContactTel = pSupplierContactTel
    End Get
    Set(ByVal value As String)
      If pSupplierContactTel <> value Then IsDirty = True
      pSupplierContactTel = value
    End Set
  End Property

  Public Property Category() As Byte
    Get
      Category = pCategory
    End Get
    Set(ByVal value As Byte)
      If pCategory <> value Then IsDirty = True
      pCategory = value
    End Set
  End Property

  Public Property SubmissionDate() As DateTime
    Get
      SubmissionDate = pSubmissionDate
    End Get
    Set(ByVal value As DateTime)
      If pSubmissionDate <> value Then IsDirty = True
      pSubmissionDate = value
    End Set
  End Property

  Public Property Status() As Byte
    Get
      Status = pStatus
    End Get
    Set(ByVal value As Byte)
      If pStatus <> value Then IsDirty = True
      pStatus = value
    End Set
  End Property

  Public Property DelStatus() As Byte
    Get
      DelStatus = pDelStatus
    End Get
    Set(ByVal value As Byte)
      If pDelStatus <> value Then IsDirty = True
      pDelStatus = value
    End Set
  End Property

  Public Property Instructions() As String
    Get
      Instructions = pInstructions
    End Get
    Set(ByVal value As String)
      If pInstructions <> value Then IsDirty = True
      pInstructions = value
    End Set
  End Property

  Public Property Comments() As String
    Get
      Comments = pComments
    End Get
    Set(ByVal value As String)
      If pComments <> value Then IsDirty = True
      pComments = value
    End Set
  End Property

  Public Property BuyerID() As Byte
    Get
      BuyerID = pBuyerID
    End Get
    Set(ByVal value As Byte)
      If pBuyerID <> value Then IsDirty = True
      pBuyerID = value
    End Set
  End Property

  Public Property AcknowledgementNo() As String
    Get
      AcknowledgementNo = pAcknowledgementNo
    End Get
    Set(ByVal value As String)
      If pAcknowledgementNo <> value Then IsDirty = True
      pAcknowledgementNo = value
    End Set
  End Property

  Public Property OrderType() As Byte
    Get
      OrderType = pOrderType
    End Get
    Set(ByVal value As Byte)
      If pOrderType <> value Then IsDirty = True
      pOrderType = value
    End Set
  End Property

  Public Property Carriage() As Double
    Get
      Carriage = pCarriage
    End Get
    Set(ByVal value As Double)
      If pCarriage <> value Then IsDirty = True
      pCarriage = value
    End Set
  End Property

  Public Property VatRate() As Decimal
    Get
      VatRate = pVatRate
    End Get
    Set(ByVal value As Decimal)
      If pVatRate <> value Then IsDirty = True
      pVatRate = value
    End Set
  End Property

  Public Property RequiredDate() As DateTime
    Get
      RequiredDate = pRequiredDate
    End Get
    Set(ByVal value As DateTime)
      If pRequiredDate <> value Then IsDirty = True
      pRequiredDate = value
    End Set
  End Property

  Public Property PurchaseCategory() As Byte
    Get
      PurchaseCategory = pPurchaseCategory
    End Get
    Set(ByVal value As Byte)
      If pPurchaseCategory <> value Then IsDirty = True
      pPurchaseCategory = value
    End Set
  End Property

  Public Property CoCOrder() As Boolean
    Get
      CoCOrder = pCoCOrder
    End Get
    Set(ByVal value As Boolean)
      If pCoCOrder <> value Then IsDirty = True
      pCoCOrder = value
    End Set
  End Property

  Public Property CoCType() As Byte
    Get
      CoCType = pCoCType
    End Get
    Set(ByVal value As Byte)
      If pCoCType <> value Then IsDirty = True
      pCoCType = value
    End Set
  End Property

  Public Property PriceGross() As Decimal
    Get
      PriceGross = pPriceGross
    End Get
    Set(ByVal value As Decimal)
      If pPriceGross <> value Then IsDirty = True
      pPriceGross = value
    End Set
  End Property

  Public Property TotalPrice() As Decimal
    Get
      TotalPrice = pTotalPrice
    End Get
    Set(ByVal value As Decimal)
      If pTotalPrice <> value Then IsDirty = True
      pTotalPrice = value
    End Set
  End Property

  Public Property DeliveryContact As String
    Get
      Return pDeliveryContact
    End Get
    Set(value As String)
      If pDeliveryContact <> value Then IsDirty = True
      pDeliveryContact = value
    End Set
  End Property

  Public Property DeliveryTel As String
    Get
      Return pDeliveryTel
    End Get
    Set(value As String)
      If pDeliveryTel <> value Then IsDirty = True
      pDeliveryTel = value
    End Set
  End Property

  Public Property DeliveryEmail As String
    Get
      Return pDeliveryEmail
    End Get
    Set(value As String)
      If pDeliveryEmail <> value Then IsDirty = True
      pDeliveryEmail = value
    End Set
  End Property

  Public Property DeliveryAddress As RTIS.ERPCore.dmPostalAddress
    Get
      Return pDeliveryAddress
    End Get
    Set(value As RTIS.ERPCore.dmPostalAddress)
      pDeliveryAddress = value
    End Set
  End Property

  Public Property SupplierAddress As RTIS.ERPCore.dmPostalAddress
    Get
      Return pSupplierAddress
    End Get
    Set(value As RTIS.ERPCore.dmPostalAddress)
      pSupplierAddress = value
    End Set
  End Property

  Public Property InvoiceAddress As RTIS.ERPCore.dmPostalAddress
    Get
      Return pInvoiceAddress
    End Get
    Set(value As RTIS.ERPCore.dmPostalAddress)
      pInvoiceAddress = value
    End Set
  End Property

  Public Property VatRateCode() As Byte
    Get
      Return pVATRateCode
    End Get
    Set(ByVal value As Byte)
      If pVATRateCode <> value Then IsDirty = True
      pVATRateCode = value
    End Set
  End Property

  Public Property ApplyVATToCarriage As Boolean
    Get
      Return pApplyVATToCarriage
    End Get
    Set(value As Boolean)
      If pApplyVATToCarriage <> value Then IsDirty = True
      pApplyVATToCarriage = value
    End Set
  End Property

  Public Property CallOffType() As Byte
    Get
      Return pCallOffType
    End Get
    Set(ByVal value As Byte)
      If pCallOffType <> value Then IsDirty = True
      pCallOffType = value
    End Set
  End Property

  Public Property SupplierContactID() As Integer
    Get
      Return pSupplierContactID
    End Get
    Set(ByVal value As Integer)
      If pSupplierContactID <> value Then IsDirty = True
      pSupplierContactID = value
    End Set
  End Property

  Public Property SupplierRef() As String
    Get
      Return pSupplierRef
    End Get
    Set(ByVal value As String)
      If pSupplierRef <> value Then IsDirty = True
      pSupplierRef = value
    End Set
  End Property

  Public Property LastStatusChangeDate() As Date
    Get
      Return pLastStatusChangeDate
    End Get
    Set(ByVal value As Date)
      If pLastStatusChangeDate <> value Then IsDirty = True
      pLastStatusChangeDate = value
    End Set
  End Property



  Public Function CarriageVAT() As Decimal
    Dim mRetVal As Decimal
    Dim mVATPercent As Decimal
    Dim mVATRateCodes As RTIS.ERPCore.colVATRateCodes



    Return mRetVal

  End Function

  Public Function CalculateNetValue() As Decimal

  End Function


  Public Property FileName() As String
    Get
      Return pFilename
    End Get
    Set(ByVal value As String)
      If pFilename <> value Then IsDirty = True
      pFilename = value
    End Set
  End Property


  Public Function VATRatePercent(ByVal vPOCORaisedDate) As Decimal

  End Function

  Public Property PurchaseOrderItems() As colPurchaseOrderItems
    Get
      Return pPurchaseOrderItems
    End Get
    Set(ByVal value As colPurchaseOrderItems)
      pPurchaseOrderItems = value
    End Set
  End Property

  Public Property Supplier As dmSupplier
    Get
      Return pSupplier
    End Get
    Set(value As dmSupplier)
      pSupplier = value
    End Set
  End Property


  Public Property PurchaseOrderAllocations() As colPurchaseOrderAllocations
    Get
      Return pPurchaseOrderAllocations
    End Get
    Set(ByVal value As colPurchaseOrderAllocations)
      pPurchaseOrderAllocations = value
    End Set
  End Property

End Class



''Collection Definition - PurchaseOrder (to PurchaseOrder)'Generated from Table:PurchaseOrder

'Private pPurchaseOrders As colPurchaseOrders
'Public Property PurchaseOrders() As colPurchaseOrders
'  Get
'    PurchaseOrders = pPurchaseOrders
'  End Get
'  Set(ByVal value As colPurchaseOrders)
'    pPurchaseOrders = value
'  End Set
'End Property

'  pPurchaseOrders = New colPurchaseOrders 'Add to New
'  pPurchaseOrders = Nothing 'Add to Finalize
'  .PurchaseOrders = PurchaseOrders.Clone 'Add to CloneTo
'  PurchaseOrders.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PurchaseOrders.IsDirty 'Add to IsAnyDirty

Public Class colPurchaseOrders : Inherits colBase(Of dmPurchaseOrder)

  Public Overrides Function IndexFromKey(ByVal vPurchaseOrderID As Integer) As Integer
    Dim mItem As dmPurchaseOrder
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PurchaseOrderID = vPurchaseOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPurchaseOrder))
    MyBase.New(vList)
  End Sub





End Class





