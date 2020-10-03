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

  Protected pDescription As String
  Protected pID As Integer

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

  Public Property ID As Integer
    Get
      Return pID
    End Get
    Set(value As Integer)
      If value <> pID Then pIsDirty = True
      pID = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pDescription
    End Get
    Set(value As String)
      If value <> pDescription Then pIsDirty = True
      pDescription = value
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

Public Class colProductBases : Inherits List(Of dmProductBase)
  Public Function ItemFromProductID(ByVal vID As Integer) As dmProductBase
    Dim mItem As dmProductBase
    Dim mRetVal As dmProductBase = Nothing


    For Each mItem In Me

      If mItem.ID = vID Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

  Public Sub New()
    MyBase.New()
  End Sub
  Public Sub New(ByVal vList As List(Of dmProductBase))
    MyBase.New(vList)
  End Sub
End Class


