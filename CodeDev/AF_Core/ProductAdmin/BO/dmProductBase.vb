Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public MustInherit Class dmProductBase : Inherits dmBase
  Implements RTIS.ERPCore.intItemSpecCore

  Protected pLeadTime As Decimal
  Protected pMargin As Decimal
  Protected pMaterialCost As Decimal
  Protected pParentID As Integer
  Protected pSalesPrice As Decimal
  Protected pProcessCost As Decimal

  Public MustOverride Overrides ReadOnly Property IsAnyDirty As Boolean Implements intItemSpecCore.IsAnyDirty

  Public MustOverride Property ItemType As Integer Implements intItemSpecCore.ItemType

  Public Property Leadtime As Decimal Implements intItemSpecCore.Leadtime
    Get
      Return pLeadTime
    End Get
    Set(value As Decimal)
      If value <> pLeadTime Then pIsDirty = True
      pLeadTime = value
    End Set
  End Property

  Public Property Margin As Decimal Implements intItemSpecCore.Margin
    Get
      Return pMargin
    End Get
    Set(value As Decimal)
      If value <> pMargin Then pIsDirty = True
      pMargin = value
    End Set
  End Property

  Public Property MaterialCost As Decimal Implements intItemSpecCore.MaterialCost
    Get
      Return pMaterialCost
    End Get
    Set(value As Decimal)
      If value <> pMaterialCost Then pIsDirty = True
      pMaterialCost = value
    End Set
  End Property

  Public Property ParentID As Integer Implements intItemSpecCore.ParentID
    Get
      Return pParentID
    End Get
    Set(value As Integer)
      If value <> pParentID Then pIsDirty = True
      pParentID = value
    End Set
  End Property

  Public Property ProcessCost As Decimal Implements intItemSpecCore.ProcessCost
    Get
      Return pProcessCost
    End Get
    Set(value As Decimal)
      If value <> pProcessCost Then pIsDirty = True
      pProcessCost = value
    End Set
  End Property

  Public Property SalesPrice As Decimal Implements intItemSpecCore.SalesPrice
    Get
      Return pSalesPrice
    End Get
    Set(value As Decimal)
      If value <> pSalesPrice Then pIsDirty = True
      pSalesPrice = value
    End Set
  End Property

  Public MustOverride Sub CalculateCostAndPrice() Implements intItemSpecCore.CalculateCostAndPrice

  Public MustOverride Overrides Sub ClearKeys() Implements intItemSpecCore.ClearKeys

  Public MustOverride Overrides Function Clone() As Object Implements intItemSpecCore.Clone

End Class
