Public Class clsStockTakeItemEditor
  Private pStockTakeItem As dmStockTakeItem
  Private pStockItem As dmStockItem
  Private pTempSelected As Boolean

  Public Sub New()
    pStockTakeItem = New dmStockTakeItem
    pStockItem = New dmStockItem
  End Sub

  Public Property StockTakeItem As dmStockTakeItem
    Get
      Return pStockTakeItem
    End Get
    Set(value As dmStockTakeItem)
      pStockTakeItem = value
    End Set
  End Property

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property TempSelected As Boolean
    Get
      Return pTempSelected
    End Get
    Set(value As Boolean)
      pTempSelected = value
    End Set
  End Property

  Public Property SnapshotQty As Decimal
    Get
      Return pStockTakeItem.SnapshotQty
    End Get
    Set(value As Decimal)
      pStockTakeItem.SnapshotQty = value
    End Set
  End Property

  Public Property CountedQty As Decimal
    Get
      Return pStockTakeItem.CountedQty
    End Get
    Set(value As Decimal)
      pStockTakeItem.CountedQty = value
    End Set
  End Property

  Public Property IsCounted As Boolean
    Get
      Return pStockTakeItem.IsCounted
    End Get
    Set(value As Boolean)
      pStockTakeItem.IsCounted = value
    End Set
  End Property

  Public Property WriteOffQuantity As Decimal
    Get
      Return pStockTakeItem.WriteOffQuantity
    End Get
    Set(value As Decimal)
      pStockTakeItem.WriteOffQuantity = value
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

  Public ReadOnly Property StdCost As Decimal
    Get

      Return pStockItem.StdCost
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

  Public ReadOnly Property StockItemTypeDesc As String
    Get
      Dim mStockItemTypeDescription As String = ""
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mStockItemTypeDescription = clsStockItemSharedFuncs.GetStockItemTypeDescription(pStockItem)
        If mStockItemTypeDescription <> "" Then
          mRetVal = mStockItemTypeDescription
        End If
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property PartNo As String
    Get
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mRetVal = pStockItem.PartNo
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ASISID As Integer
    Get
      Dim mRetVal As Integer
      If pStockItem IsNot Nothing Then
        mRetVal = pStockItem.ASISID
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property CountedValue As Decimal
    Get
      Dim mRetVal As Decimal
      If pStockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.getStockItemValue(pStockItem, pStockTakeItem.CountedQty)
      End If
      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property DiscrepancyValue As Decimal
    Get
      Dim mRetVal As Decimal
      Dim mStockCountedQty As Decimal
      Dim mDiscrepancy As Decimal

      mStockCountedQty = pStockTakeItem.CountedQty + pStockTakeItem.WriteOffQuantity
      mDiscrepancy = pStockTakeItem.SnapshotQty - mStockCountedQty

      If pStockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.getStockItemValue(pStockItem, mDiscrepancy)
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property WriteOffValue As Decimal
    Get
      Dim mRetVal As Decimal
      If pStockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.getStockItemValue(pStockItem, pStockTakeItem.WriteOffQuantity)
      End If
      Return mRetVal
    End Get
  End Property

End Class

Public Class colStockTakeItemEditors : Inherits List(Of clsStockTakeItemEditor)


  Public Function IndexFromStockItemIDLocationID(vStockItemID As Integer, vLocationID As Integer) As Integer
    Dim mItem As clsStockTakeItemEditor
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.StockItem IsNot Nothing Then
        If mItem.StockItem.StockItemID = vStockItemID And mItem.StockTakeItem.StockItemLocationID = vLocationID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromStockItemIDLocationID(vStockItemID As Integer, vLocationID As Integer) As clsStockTakeItemEditor
    Dim mRetVal As clsStockTakeItemEditor = Nothing
    Dim mIndex As Integer

    mIndex = IndexFromStockItemIDLocationID(vStockItemID, vLocationID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function
End Class

