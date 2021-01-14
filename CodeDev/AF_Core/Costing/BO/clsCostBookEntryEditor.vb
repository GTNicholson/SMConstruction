Public Class clsCostBookEntryEditor

  Private pStockItem As dmStockItem
  Private pCostBookEntry As dmCostBookEntry
  Private Shared sRefLists As appRefLists

  Public Sub New()
    pCostBookEntry = New dmCostBookEntry
    pStockItem = New dmStockItem

    If sRefLists Is Nothing Then
      sRefLists = AppRTISGlobal.GetInstance.RefLists
    End If

  End Sub


  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property CostBookEntry As dmCostBookEntry
    Get
      Return pCostBookEntry
    End Get
    Set(value As dmCostBookEntry)
      pCostBookEntry = value
    End Set
  End Property

  Public Property Cost As Decimal
    Get
      Return pCostBookEntry.Cost
    End Get
    Set(value As Decimal)
      pCostBookEntry.Cost = value
    End Set
  End Property

  Public Property CostUnit As Integer
    Get
      Return pCostBookEntry.CostUnit
    End Get
    Set(value As Integer)
      pCostBookEntry.CostUnit = value
    End Set
  End Property
  Public Property MinCost As Decimal
    Get
      Return pCostBookEntry.MinCost
    End Get
    Set(value As Decimal)
      pCostBookEntry.MinCost = value
    End Set
  End Property


  Public Property StockItemID As Integer
    Get
      Return pStockItem.StockItemID
    End Get
    Set(value As Integer)
      pStockItem.StockItemID = value
    End Set
  End Property

  Public ReadOnly Property CostBookEntryID As Integer
    Get
      Return pCostBookEntry.CostBookEntryID
    End Get

  End Property

  Public ReadOnly Property CostBookID As Integer
    Get
      Return pCostBookEntry.CostBookID
    End Get

  End Property



  Public Property CategoryID As Byte
    Get
      Return pStockItem.Category
    End Get
    Set(value As Byte)
      pStockItem.Category = value
    End Set
  End Property


  Public ReadOnly Property SIDescription As String
    Get
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mRetVal = pStockItem.Description
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property SIStockCode As String
    Get
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mRetVal = pStockItem.StockCode
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property StockItemCategoryDesc As String
    Get
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pStockItem.Category, eStockItemCategory))
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property CostUnitDes As String
    Get
      Dim mRetVal As String = ""
      If pCostBookEntry IsNot Nothing Then
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pCostBookEntry.CostUnit, eUoM))
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ItemType As Int32
    Get
      Return pStockItem.ItemType

    End Get
  End Property

  Public ReadOnly Property Width As Decimal
    Get
      Return pStockItem.Width

    End Get
  End Property


  Public ReadOnly Property SpeciesDesc As String

    Get


      Return clsStockItemSharedFuncs.GetSpeciesDescription(pStockItem)
    End Get


  End Property

  Public ReadOnly Property Length As Decimal
    Get
      Return pStockItem.Length

    End Get
  End Property
  Public ReadOnly Property Thickness As Decimal
    Get
      Return pStockItem.Thickness

    End Get
  End Property

  Public ReadOnly Property SpeciesID As Int32
    Get
      Return pStockItem.Species

    End Get
  End Property

End Class

Public Class colCostBookEntryEditors : Inherits List(Of clsCostBookEntryEditor)

  Public Function IndexFromStockItemID(vStockItemID As Integer) As Integer
    Dim mItem As clsCostBookEntryEditor
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.CostBookEntry IsNot Nothing Then
        If mItem.CostBookEntry.StockItemID = vStockItemID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

  Public Function IndexFromCostBookEntryID(vCostBookEntryID As Integer) As Integer
    Dim mItem As clsCostBookEntryEditor
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.CostBookEntry IsNot Nothing Then
        If mItem.CostBookEntry.CostBookEntryID = vCostBookEntryID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromCostBookEntryID(vCostBookEntryID As Integer) As clsCostBookEntryEditor
    Dim mRetVal As clsCostBookEntryEditor = Nothing
    Dim mIndex As Integer

    mIndex = IndexFromCostBookEntryID(vCostBookEntryID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function

End Class

