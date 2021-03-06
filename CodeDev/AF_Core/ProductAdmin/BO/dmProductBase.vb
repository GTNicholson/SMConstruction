﻿Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public MustInherit Class dmProductBase : Inherits dmBase
  Implements RTIS.ERPCore.intItemSpecCore

  Protected pLeadTime As Decimal
  Protected pMargin As Decimal
  Protected pMaterialCost As Decimal
  Protected pParentID As Integer
  Protected pSalesPrice As Decimal
  Protected pProcessCost As Decimal
  Protected pUoM As String
  Protected pDescription As String
  Protected pID As Integer
  Protected pCode As String
  Protected pSubItemType As Integer '// from productconstructionsubtype
  Protected pItemType As Integer '// from productconstructiontype
  Protected pDrawingFileName As String
  Protected pIsGeneric As Boolean
  Protected pFullyDefined As Boolean
  Protected pSalesOrderID As Integer
  Protected pPOFiles As colFileTrackers
  Public MustOverride Overrides ReadOnly Property IsAnyDirty As Boolean Implements intItemSpecCore.IsAnyDirty

  Public MustOverride Property ProductTypeID As Integer Implements intItemSpecCore.ItemType '// from eProductType

  Private pStatus As Boolean


  Public Property Leadtime As Decimal Implements intItemSpecCore.Leadtime
    Get
      Return pLeadTime
    End Get
    Set(value As Decimal)
      If value <> pLeadTime Then pIsDirty = True
      pLeadTime = value
    End Set
  End Property

  Public MustOverride Property ID As Integer


  Public Property ItemType As Integer
    Get
      Return pItemType
    End Get
    Set(value As Integer)
      If value <> pItemType Then pIsDirty = True
      pItemType = value
    End Set
  End Property

  Public Property SubItemType As Integer
    Get
      Return pSubItemType
    End Get
    Set(value As Integer)
      If value <> pSubItemType Then pIsDirty = True
      pSubItemType = value
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

  Public Property Code As String
    Get
      Return pCode
    End Get
    Set(value As String)
      If value <> pCode Then pIsDirty = True
      pCode = value
    End Set
  End Property
  Public Property UoM As Int32
    Get
      Return pUoM
    End Get
    Set(value As Int32)
      If value <> pUoM Then pIsDirty = True
      pUoM = value
    End Set
  End Property

  Public Property Status As Boolean
    Get
      Return pStatus
    End Get
    Set(value As Boolean)
      If pStatus <> value Then IsDirty = True
      pStatus = value
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

  Public Property DrawingFileName As String
    Get
      Return pDrawingFileName
    End Get
    Set(value As String)
      If value <> pDrawingFileName Then pIsDirty = True
      pDrawingFileName = value
    End Set
  End Property

  Public Property IsGeneric As Boolean
    Get
      Return pIsGeneric
    End Get
    Set(value As Boolean)
      If value <> pIsGeneric Then pIsDirty = True
      pIsGeneric = value
    End Set
  End Property

  Public Property FullyDefined As Boolean
    Get
      Return pFullyDefined
    End Get
    Set(value As Boolean)
      If value <> pFullyDefined Then pIsDirty = True
      pFullyDefined = value
    End Set
  End Property


  Public Property SalesOrderID As Boolean
    Get
      Return pSalesOrderID
    End Get
    Set(value As Boolean)
      If value <> pSalesOrderID Then pIsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public MustOverride Sub CalculateCostAndPrice() Implements intItemSpecCore.CalculateCostAndPrice

  Public MustOverride Overrides Sub ClearKeys() Implements intItemSpecCore.ClearKeys

  Public MustOverride Overrides Function Clone() As Object Implements intItemSpecCore.Clone

  Public Property POFiles As colFileTrackers
    Get
      Return pPOFiles
    End Get
    Set(value As colFileTrackers)
      pPOFiles = value
    End Set
  End Property
End Class

Public Class colProductBases : Inherits List(Of dmProductBase)
  Public Function ItemFromProductTypeAndID(ByVal vProductType As eProductType, ByVal vID As Integer) As dmProductBase
    Dim mItem As dmProductBase
    Dim mRetVal As dmProductBase = Nothing


    For Each mItem In Me

      If mItem.ID = vID And mItem.ProductTypeID = vProductType Then
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


