Imports System.ComponentModel

Public Class clsPOItemEditor

  Private pPurchaseOrder As dmPurchaseOrder
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem


  Public Sub New(ByVal vPurchaseOrder As dmPurchaseOrder, ByVal vPOItem As dmPurchaseOrderItem)
    pPurchaseOrder = vPurchaseOrder
    pPOItem = vPOItem


  End Sub


  Public ReadOnly Property POItem As dmPurchaseOrderItem
    Get
      Return pPOItem
    End Get
  End Property


  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pPOItem.Description
    End Get
    Set(value As String)
      pPOItem.Description = value
    End Set
  End Property

  Public Property SupplierCode As String
    Get
      Return pPOItem.SupplierCode
    End Get
    Set(value As String)
      pPOItem.SupplierCode = value
    End Set
  End Property



  Public Property PartNo As String
    Get
      Return pPOItem.PartNo
    End Get
    Set(value As String)
      pPOItem.PartNo = value
    End Set
  End Property

  Public Property PricingUnit As Byte
    Get
      'If pStockItem IsNot Nothing Then
      '  Return pStockItem.PricingUnit
      'Else
      Return pPOItem.PricingUnit
      ' End If
    End Get
    Set(value As Byte)
      '   If pStockItem Is Nothing Then
      pPOItem.PricingUnit = value
      ' End If
    End Set
  End Property

  Public ReadOnly Property PricingUnitDesc As String
    Get
      'If pStockItem IsNot Nothing Then
      '  Return eUnit.GetInstance.DisplayValueFromKey(pStockItem.PricingUnit)
      'Else
      'Return eUnit.GetInstance.DisplayValueFromKey(pPOItem.PricingUnit)
      'End If
    End Get
  End Property

  Public Property UnitPrice As Decimal
    Get
      Return pPOItem.UnitPrice
    End Get
    Set(value As Decimal)
      'pPOItem.UnitPrice = value
      clsPurchasingSharedFuncs.ApplyPOItemUnitPrice(pPurchaseOrder, pPOItem, value)
    End Set
  End Property


  Public Property VatRateCode As Byte
    Get
      Return pPOItem.VatRateCode
    End Get
    Set(value As Byte)
      pPOItem.VatRateCode = value
    End Set
  End Property

  Public ReadOnly Property VatValue As Decimal
    Get
      Return pPOItem.VatValue
    End Get
  End Property

  Public Property Notes As String
    Get
      Return pPOItem.Notes
    End Get
    Set(value As String)
      pPOItem.Notes = value
    End Set
  End Property

  Public ReadOnly Property Barcode As String
    Get
      If pStockItem IsNot Nothing Then
        Return pStockItem.StockItemID.ToString("00000000")
      End If

      Return String.Empty
    End Get
  End Property


  Public Property PackQuantity As Decimal

  Public Sub UpdateVatValue(ByVal vOrderDate As DateTime)
    Dim mVATPercent As Decimal
    Dim mVATRateCodes As RTIS.ERPCore.colVATRateCodes


  End Sub

  Public Sub UpdatePartNoFromStockItem()
    Dim mPartNo As String = String.Empty
    If pStockItem IsNot Nothing Then
      mPartNo = pStockItem.StockCode
    End If
    Me.PartNo = mPartNo
  End Sub

  Public Sub UpdateDescriptionFromStockItem()
    Dim mDescription As String = String.Empty
    If pStockItem IsNot Nothing Then
      mDescription = pStockItem.Description
    End If
    Me.Description = mDescription
  End Sub


  Public Sub SetDefaultsFromStockItem(ByVal vSupplierID As Integer)
    UpdatePartNoFromStockItem()
    UpdateDescriptionFromStockItem()

  End Sub

  Public Property NominalAccountCode As String
    Get
      Return pPOItem.NominalAccountCode
    End Get
    Set(value As String)
      pPOItem.NominalAccountCode = value
    End Set
  End Property

  Public Property NominalCostCentre As String
    Get
      Return pPOItem.NominalCostCentre
    End Get
    Set(value As String)
      pPOItem.NominalCostCentre = value
    End Set
  End Property

End Class

Public Class colPOItemEditors : Inherits BindingList(Of clsPOItemEditor)




End Class