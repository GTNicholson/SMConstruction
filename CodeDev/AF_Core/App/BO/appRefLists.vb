Imports RTIS.CommonVB

Public Class appRefLists : Inherits colRefLists

  Public Const None As Integer = 0
  Public Const RefList As Integer = 1
  Public Const YesNo As Integer = 2

  'Optional
  Public Const VATRateCodes As Integer = 3
  Public Const Employees As Integer = 4
  Public Const Roles As Integer = 5
  Public Const Country As Integer = 6
  Public Const OrderType As Integer = 7
  Public Const PaymentTermsType As Integer = 8
  Public Const WorkOrderType As Integer = 9
  Public Const WoodSpecie As Integer = 10
  Public Const WoodFinish As Integer = 11
  Public Const SalesTermType As Integer = 12
  Public Const Material As Integer = 13
  Public Const Quality As Integer = 14
  Public Const FurnitureCategory As Integer = 15
  Public Const SubCategory As Integer = 16
  Public Const Shift As Integer = 17
  Public Const PurchaseTermType As Integer = 18
  Public Const Supplier As Integer = 19
  Public Const ExchangeRate As Integer = 20
  Public Const WoodValue As Integer = 21
  Public Const VATRate As Integer = 22
  Public Const HouseType As Integer = 23
  Public Const ProductConstructionSubType As Integer = 24
  Public Const ProductConstructionType As Integer = 25
  Public Const Model As Integer = 26
  Public Const GroupType As Integer = 27
  Public Const FoundationOptions As Integer = 28

  Public Const FloorOptions As Integer = 29
  Public Const WallOptions As Integer = 30
  Public Const WindowOptions As Integer = 31

  Public Const ProductCostBook As Integer = 32
  Public Const BankList As Integer = 33

  Public Const PurchaseStatus As Integer = 34
  Public Const TransactionType As Integer = 35

  Public Const CostBook As Integer = 36

  Public Const StockItemType As Integer = 37
  Public Const AccoutingCategory As Integer = 38
  Public Const ThicknessValue As Integer = 39
  Public Const WoodTypeValue As Integer = 40

  Public Const FixingSpecies As Integer = 41
  Public Const StockItemCategory As Integer = 42
  Public Sub New()
    MyBase.New()
    Me.AddRefList(None, "None", clsRefListItem.eLoadMode.Coded)
    Me.AddRefList(RefList, "RefList", clsRefListItem.eLoadMode.Coded, "Description", "RefListType")
    Me.AddRefList(YesNo, "YesNo", clsRefListItem.eLoadMode.Coded)

    'Optional
    Me.AddRefList(VATRateCodes, "VAT Rate Codes", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Employees, "Employees", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Roles, "Roles", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Country, "Country", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(OrderType, "OrderType", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(PaymentTermsType, "Tenders", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WorkOrderType, "WorkOrderType", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WoodSpecie, "WoodSpecie", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WoodFinish, "WoodFinish", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(SalesTermType, "SalesTermType", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Material, "Material", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Quality, "Quality", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(FurnitureCategory, "FurnitureCategory", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(SubCategory, "SubCategory", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Shift, "Shift", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(PurchaseTermType, "PurchaseTermType", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(Supplier, "Supplier", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(ExchangeRate, "ExchangeRate", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WoodValue, "WoodValue", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(VATRate, "VATRate", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(HouseType, "HouseType", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(ProductConstructionSubType, "ProductConstructionSubType", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(ProductConstructionType, "ProductConstructionType", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(Model, "Model", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(GroupType, "GroupType", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(FoundationOptions, "FoundationOptions", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(FloorOptions, "FloorOptions", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WallOptions, "WallOptions", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(WindowOptions, "WindowOptions", clsRefListItem.eLoadMode.Unloaded)


    Me.AddRefList(ProductCostBook, "ProductCostBook", clsRefListItem.eLoadMode.Unloaded)
    Me.AddRefList(BankList, "BankList", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(PurchaseStatus, "Status", clsRefListItem.eLoadMode.Coded)
    Me.AddRefList(TransactionType, "TransactionType", clsRefListItem.eLoadMode.Coded)
    Me.AddRefList(CostBook, "Cost Book", clsRefListItem.eLoadMode.Unloaded)


    Me.AddRefList(StockItemType, "StockItemType", clsRefListItem.eLoadMode.Coded)

    Me.AddRefList(AccoutingCategory, "AccoutingCategory", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(ThicknessValue, "ThicknessValue", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(WoodTypeValue, "WoodItemValue", clsRefListItem.eLoadMode.Unloaded)

    Me.AddRefList(FixingSpecies, "FixingSpecies", clsRefListItem.eLoadMode.Unloaded)


    Me.AddRefList(StockItemCategory, "StockItemCategory", clsRefListItem.eLoadMode.Unloaded)

  End Sub


End Class
