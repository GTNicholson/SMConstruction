Imports RTIS.CommonVB

Public Class clsPurchaseOrderInfo
  Private pPurchaseOrder As dmPurchaseOrder

  Private pPOItemInfos As colPOItemInfos
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem
  Private pBuyerName As String
  Private pSupplierContactName As String
  Private pTotalNetValueInfo As Decimal
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
  Private pTotalVatValue As Decimal
  Private pTotalRetentionValue As Decimal
  Private pTotalValue As Decimal

  Public Sub New()
    pPurchaseOrder = New dmPurchaseOrder
    pPOItem = New dmPurchaseOrderItem
    pPOItemInfos = New colPOItemInfos
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
  End Sub

  Public Property BuyerName As String
    Get
      Return pBuyerName
    End Get
    Set(value As String)
      pBuyerName = value
    End Set
  End Property



  Public ReadOnly Property PurchaseOrderItem As dmPurchaseOrderItem
    Get
      Return pPOItem
    End Get
  End Property

  Public ReadOnly Property PaymentMethod As Int32
    Get
      Return pPurchaseOrder.PaymentMethod
    End Get
  End Property

  Public ReadOnly Property PaymentMethodDes As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePaymentMethod), CType(pPurchaseOrder.PaymentMethod, ePaymentMethod))
    End Get
  End Property

  Public ReadOnly Property PurchaseOrderItemID As Int32
    Get
      Return pPOItem.PurchaseOrderItemID
    End Get
  End Property

  Public Property PurchaseOrder As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property

  Public ReadOnly Property FileName As String
    Get
      Return pPurchaseOrder.FileName
    End Get
  End Property

  Public Property POItemInfos As colPOItemInfos
    Get
      Return pPOItemInfos
    End Get
    Set(value As colPOItemInfos)
      pPOItemInfos = value
    End Set
  End Property

  Public ReadOnly Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrder.PurchaseOrderID
    End Get

  End Property
  Public ReadOnly Property AccoutingCategoryID() As Int32
    Get
      Return pPurchaseOrder.AccoutingCategoryID
    End Get

  End Property

  Public ReadOnly Property POStage As Integer
    Get
      Return pPurchaseOrder.POStage
    End Get
  End Property

  Public ReadOnly Property POStageDesc As String
    Get
      If POStage > 0 Then
        Return clsEnumsConstants.GetEnumDescription(GetType(ePOStage), CType(pPurchaseOrder.POStage, ePOStage))
      Else
        Return AccoutingCategoryDesc
      End If

    End Get
  End Property


  Public ReadOnly Property ExchangeRateValue() As Decimal
    Get
      Return pPurchaseOrder.ExchangeRateValue
    End Get

  End Property

  Public ReadOnly Property MaterialRequirementTypeID() As Int32
    Get
      Return pPurchaseOrder.MaterialRequirementTypeID
    End Get

  End Property
  Public ReadOnly Property MaterialRequirementTypeWorkOrderID() As Int32
    Get
      Return pPurchaseOrder.MaterialRequirementTypeWorkOrderID
    End Get

  End Property
  Public ReadOnly Property DefaultCurrency() As Int32
    Get
      Return pPurchaseOrder.DefaultCurrency
    End Get

  End Property
  Public ReadOnly Property CategoryDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(pPurchaseOrder.Category, ePurchaseCategories))
    End Get

  End Property

  Public ReadOnly Property PurchaseStateDes As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseOrderDueDateStatus), CType(pPurchaseOrder.Status, ePurchaseOrderDueDateStatus))
    End Get

  End Property
  Public ReadOnly Property TotalReceivedAmountCordobas As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = pTotalNetValueInfo

        Case eCurrency.Dollar
          If ExchangeRateValue > 0 Then
            mRetVal = pTotalNetValueInfo * ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property TotalReceivedAmountUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = pTotalNetValueInfo

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = pTotalNetValueInfo / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return Math.Round(mRetVal, 2, MidpointRounding.AwayFromZero)
    End Get

  End Property

  Public ReadOnly Property CarriageUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = Carriage

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = Carriage / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property CarriageCordobas As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = Carriage

        Case eCurrency.Dollar
          If ExchangeRateValue > 0 Then
            mRetVal = Carriage * ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public Property SalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
    Get
      Return pSalesOrderPhaseItemInfos
    End Get
    Set(value As colSalesOrderPhaseItemInfos)
      pSalesOrderPhaseItemInfos = value
    End Set
  End Property
  Public ReadOnly Property DefaultCurrencyDesc() As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eCurrency), CType(pPurchaseOrder.DefaultCurrency, eCurrency))
    End Get

  End Property

  Public ReadOnly Property RefMatType() As String
    Get
      Return pPurchaseOrder.RefMatType
    End Get


  End Property
  Public ReadOnly Property PONum() As String
    Get
      Return pPurchaseOrder.PONum
    End Get

  End Property

  Public ReadOnly Property SupplierContactTel() As String
    Get
      Return pPurchaseOrder.SupplierContactTel
    End Get

  End Property

  Public ReadOnly Property Category() As Byte
    Get
      Return pPurchaseOrder.Category
    End Get

  End Property

  Public ReadOnly Property SubmissionDate() As DateTime
    Get
      Return pPurchaseOrder.SubmissionDate
    End Get

  End Property
  Public ReadOnly Property SubmissionDateWC() As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pPurchaseOrder.SubmissionDate)
    End Get

  End Property
  Public ReadOnly Property SubmissionDateMC As Date
    Get
      Return New Date(Year(pPurchaseOrder.SubmissionDate), Month(pPurchaseOrder.SubmissionDate), 1)
    End Get
  End Property

  Public ReadOnly Property Status() As Byte
    Get
      Return pPurchaseOrder.Status
    End Get
  End Property

  Public ReadOnly Property DelStatus() As Byte
    Get
      Return pPurchaseOrder.DelStatus
    End Get
  End Property

  Public ReadOnly Property Instructions() As String
    Get
      Return pPurchaseOrder.Instructions
    End Get
  End Property

  Public ReadOnly Property Comments() As String
    Get
      Return pPurchaseOrder.Comments
    End Get
  End Property

  Public ReadOnly Property BuyerID() As Byte
    Get
      Return pPurchaseOrder.BuyerID
    End Get
  End Property

  Public ReadOnly Property AcknowledgementNo() As String
    Get
      Return pPurchaseOrder.AcknowledgementNo
    End Get
  End Property

  Public ReadOnly Property OrderType() As Byte
    Get
      Return pPurchaseOrder.OrderType
    End Get
  End Property

  Public ReadOnly Property Carriage() As Double
    Get
      Return pPurchaseOrder.Carriage
    End Get
  End Property

  Public ReadOnly Property VatRate() As Decimal
    Get
      Return pPurchaseOrder.VatRate
    End Get
  End Property

  Public Property RequiredDate() As DateTime
    Get
      Return pPurchaseOrder.RequiredDate
    End Get
    Set(value As DateTime)
      pPurchaseOrder.RequiredDate = value
    End Set
  End Property

  Public ReadOnly Property PurchaseCategory() As Byte
    Get
      Return pPurchaseOrder.PurchaseCategory
    End Get
  End Property

  Public ReadOnly Property CoCOrder() As Boolean
    Get
      Return pPurchaseOrder.CoCOrder
    End Get
  End Property

  Public ReadOnly Property CoCType() As Byte
    Get
      Return pPurchaseOrder.CoCType
    End Get
  End Property

  Public ReadOnly Property PriceGross() As Decimal
    Get
      Return pPurchaseOrder.PriceGross
    End Get
  End Property

  Public ReadOnly Property TotalPrice() As Decimal
    Get
      Return pPurchaseOrder.TotalPrice
    End Get
  End Property


  Public ReadOnly Property PaymentStatus As Integer
    Get
      Return pPurchaseOrder.PaymentStatus
    End Get
  End Property
  Public ReadOnly Property DeliveryAddress As String
    Get
      Return pPurchaseOrder.DeliveryAddress.FullAddress(vbCrLf)
    End Get
  End Property


  Public ReadOnly Property BankName() As String
    Get
      Return pPurchaseOrder.Supplier.BankName
    End Get

  End Property
  Public ReadOnly Property isBigTaxPayer() As Boolean
    Get
      Return pPurchaseOrder.Supplier.isBigTaxPayer
    End Get

  End Property

  Public ReadOnly Property CompanyName() As String
    Get
      Return pPurchaseOrder.Supplier.CompanyName
    End Get

  End Property

  Public ReadOnly Property TotalVAT As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.VATAmount
      Next
      mRetVal += pPurchaseOrder.CarriageVAT()
      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property TotalRetention As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += (mPOItemInfo.Qty * mPOItemInfo.UnitPrice) * PurchaseOrder.RetentionPercentage
      Next
      Return mRetVal
    End Get
  End Property

  Public Property TotalVatValueReport As Decimal
    Get
      Return pTotalVatValue
    End Get
    Set(value As Decimal)
      pTotalVatValue = value
    End Set
  End Property

  Public ReadOnly Property TotalVatValueReportUSD As Decimal

    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalVatValueReport

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = TotalVatValueReport / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return Math.Round(mRetVal, 2, MidpointRounding.AwayFromZero)
    End Get

  End Property


  Public Property TotalRetentionValueReport As Decimal
    Get
      Return pTotalRetentionValue
    End Get
    Set(value As Decimal)
      pTotalRetentionValue = value
    End Set
  End Property

  Public ReadOnly Property TotalValueReport As Decimal
    Get
      Dim mRetVal As Decimal = 0


      mRetVal = TotalReceivedAmountUSD - TotalRetentionValueReportUSD + TotalVatValueReportUSD + CarriageUSD

      Return Math.Round(mRetVal, 2, MidpointRounding.AwayFromZero)
    End Get
  End Property
  Public ReadOnly Property TotalRetentionValueReportUSD As Decimal

    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalRetentionValueReport

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = TotalRetentionValueReport / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return Math.Round(mRetVal, 2, MidpointRounding.AwayFromZero)
    End Get

  End Property
  Public ReadOnly Property TotalRetentionCordobas As Decimal

    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = TotalRetention

        Case eCurrency.Dollar
          If ExchangeRateValue > 0 Then
            mRetVal = TotalRetention * ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalRetentionUSD As Decimal

    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalRetention

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = TotalRetention / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalVATCordobas As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = TotalVAT

        Case eCurrency.Dollar
          If ExchangeRateValue > 0 Then
            mRetVal = TotalVAT * ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property TotalVATUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalVAT

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = TotalVAT / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property TotalNetValue As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += Math.Round(mPOItemInfo.Price, 2, MidpointRounding.AwayFromZero)
      Next
      'mRetVal += pPurchaseOrder.Carriage
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property RetentionPercentage As Decimal
    Get
      Return pPurchaseOrder.RetentionPercentage
    End Get
  End Property
  Public ReadOnly Property TotalGrossValueGUI As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.GrossPrice  '* (1 - RetentionPercentage)
      Next
      mRetVal = mRetVal - TotalRetention
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalGrossValue As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.GrossPrice
      Next
      mRetVal += (pPurchaseOrder.Carriage + pPurchaseOrder.CarriageVAT)
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalGrossValueUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalGrossValueGUI

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = TotalGrossValueGUI / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalGrossValueCordobas As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = TotalGrossValueGUI

        Case eCurrency.Dollar
          If ExchangeRateValue > 0 Then
            mRetVal = TotalGrossValueGUI * ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property AnyCoC As Boolean
    Get
      Dim mRetVal As Boolean = False
      For Each mPOItem As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems
        If mPOItem.CoCType <> eCOCType.None And mPOItem.CoCType <> eCOCType.Uncertified Then
          mRetVal = True
          Exit For
        End If
      Next
      Return mRetVal
    End Get
  End Property

  Public Property TotalNetValueInfo As Decimal
    Get
      Return pTotalNetValueInfo
    End Get
    Set(value As Decimal)
      pTotalNetValueInfo = value
    End Set
  End Property
  Public ReadOnly Property AccoutingCategoryDesc As String
    Get
      Dim mRetVal As String = ""
      mRetVal = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).DisplayValueString(AccoutingCategoryID)

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property PaymentDate As Date
    Get
      Return pPurchaseOrder.PaymentDate
    End Get
  End Property
  Public ReadOnly Property ProjectName As String
    Get
      Dim mRetVal As String = ""
      Dim mSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
      For Each mPOA As dmPurchaseOrderAllocation In PurchaseOrder.PurchaseOrderAllocations
        mSalesOrderPhaseItemInfo = pSalesOrderPhaseItemInfos.ItemFromKey(mPOA.SalesorderPhaseItemID)

        If mSalesOrderPhaseItemInfo IsNot Nothing Then
          If mSalesOrderPhaseItemInfo.ProjectName <> "" Then
            mRetVal &= mSalesOrderPhaseItemInfo.ProjectName & " /"

          Else
            mRetVal = AccoutingCategoryDesc
          End If
        End If
      Next
      If mRetVal.Length > 0 Then
        If mRetVal.Substring(mRetVal.Length - 1) = "/" Then
          mRetVal = mRetVal.Remove(mRetVal.Length - 1)
        End If
      Else
        mRetVal = AccoutingCategoryDesc
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ValuationMode As Int32
    Get
      Return pPurchaseOrder.ValuationMode
    End Get
  End Property


End Class

Public Class colPurchaseOrderInfos : Inherits List(Of clsPurchaseOrderInfo)

  Public Function GetLivePOCountByCategory(ByVal vCategory As Integer) As Integer



  End Function
End Class

Public Class clsPOItemInfo
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem
  Private pPOItemAllocations As colPurchaseOrderItemAllocations

  Public Sub New(ByRef rPOItem As dmPurchaseOrderItem, ByRef rStockItem As dmStockItem)
    pPOItem = rPOItem
    pStockItem = rStockItem
    pPOItemAllocations = rPOItem.PurchaseOrderItemAllocations
  End Sub


  Public ReadOnly Property PurchaseRefCodes As String
    Get
      Dim mRetVal As String = ""
      mRetVal = pPOItem.PartNo
      If pPOItem.SupplierCode <> "" Then
        If mRetVal <> "" Then mRetVal &= " / "
        mRetVal = mRetVal & pPOItem.SupplierCode
      End If
      Return mRetVal
    End Get
  End Property

  Public Property PurchaseOrderItemAllocations As colPurchaseOrderItemAllocations
    Get
      Return pPOItemAllocations
    End Get
    Set(value As colPurchaseOrderItemAllocations)
      pPOItemAllocations = value
    End Set
  End Property

  Public Property StockCode As String
    Get
      Dim mRetVal As String
      Dim mSI As dmStockItem

      mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(pPOItem.StockItemID)

      If mSI IsNot Nothing Then
        mRetVal = mSI.StockCode
      Else
        mRetVal = ""
      End If

      Return mRetVal
    End Get
    Set(value As String)
      pPOItem.StockCode = value
    End Set
  End Property

  Public ReadOnly Property Qty As Decimal
    Get
      Return pPOItem.QtyRequired
    End Get
  End Property

  Public ReadOnly Property SupplierCode As String
    Get
      Return pPOItem.SupplierCode
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pPOItem.Description
    End Get
  End Property

  Public ReadOnly Property UnitPrice As Decimal
    Get
      Return pPOItem.UnitPrice
    End Get
  End Property

  Public ReadOnly Property Density As Decimal
    Get
      Return pPOItem.Density
    End Get
  End Property

  Public ReadOnly Property CoCType As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCOCType), CType(pPOItem.CoCType, eCOCType))
    End Get
  End Property

  Public ReadOnly Property UoM As Integer
    Get
      Return pPOItem.UoM
    End Get
  End Property

  Public ReadOnly Property UoMDesc As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pPOItem.UoM, eUoM))
    End Get
  End Property
  Public ReadOnly Property Price As Decimal
    Get
      Return pPOItem.NetAmount
    End Get
  End Property

  Public ReadOnly Property VATAmount As Decimal
    Get
      Return pPOItem.VATAmount
    End Get

  End Property

  Public ReadOnly Property RetentionValue As Decimal
    Get
      Return pPOItem.RetentionValue
    End Get

  End Property

  Public ReadOnly Property GrossPrice As Decimal
    Get
      Return pPOItem.GrossAmount
    End Get
  End Property

  Public ReadOnly Property AllocationItemRefSummary As String
    Get
      Dim mRetVal As String = ""

      For Each mPOIA As dmPurchaseOrderItemAllocation In pPOItem.PurchaseOrderItemAllocations
        If mRetVal = "" Then mRetVal &= vbCrLf

        mRetVal &= mPOIA.ItemRef & " / " & mPOIA.Quantity.ToString("N2") & vbCrLf

      Next

      Return Description & vbCrLf & mRetVal
    End Get
  End Property


  Public ReadOnly Property DisplayReportPOIDesc As String
    Get
      Dim mRetVal As String

      mRetVal = String.Format("{0} {1} de {2}", clsSMSharedFuncs.FractStrFromDec(Qty), UoMDesc, Description)

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property PurchaseOrderItemID As Integer
    Get
      Return pPOItem.PurchaseOrderID
    End Get
  End Property

End Class

Public Class colPOItemInfos : Inherits List(Of clsPOItemInfo)

  Public Function GetItemFromKey(ByVal vPurchaseOrderItemID As Integer) As clsPOItemInfo
    Dim mRetVal As clsPOItemInfo = Nothing

    For Each mItem In Me
      If mItem.PurchaseOrderItemID = vPurchaseOrderItemID Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function
End Class
