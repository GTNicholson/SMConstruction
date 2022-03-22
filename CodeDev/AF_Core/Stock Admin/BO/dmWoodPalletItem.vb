''Class Definition - WoodPalletItem (to WoodPalletItem)'Generated from Table:WoodPalletItem
Imports RTIS.CommonVB

Public Class dmWoodPalletItem : Inherits dmBase
  Private pWoodPalletItemID As Int32
  Private pWoodPalletID As Int32
  Private pStockItemID As Int32
  Private pWidth As Decimal
  Private pLength As Decimal
  Private pQuantityUsed As Decimal
  Private pQuantity As Decimal
  Private pDescription As String
  Private pStockCode As String
  Private pThickness As Decimal
  Private pOutstandingQty As Decimal
  Private pVolumeM3 As Decimal
  Private pDifferenceTranQty As Decimal
  Private PTrozaRef As String
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    WoodPalletItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodPalletItem)
      .WoodPalletItemID = WoodPalletItemID
      .WoodPalletID = WoodPalletID
      .StockItemID = StockItemID
      .Width = Width
      .Length = Length
      .Quantity = Quantity
      .QuantityUsed = QuantityUsed
      .Description = Description
      .StockCode = StockCode
      .Thickness = Thickness
      .OutstandingQty = OutstandingQty
      .VolumeM3 = VolumeM3
      .TrozaRef = TrozaRef
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodPalletItemID() As Int32
    Get
      Return pWoodPalletItemID
    End Get
    Set(ByVal value As Int32)
      If pWoodPalletItemID <> value Then IsDirty = True
      pWoodPalletItemID = value
    End Set
  End Property

  Public Property WoodPalletID() As Int32
    Get
      Return pWoodPalletID
    End Get
    Set(ByVal value As Int32)
      If pWoodPalletID <> value Then IsDirty = True
      pWoodPalletID = value
    End Set
  End Property

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property Width() As Decimal
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      If pWidth <> value Then IsDirty = True
      pWidth = value
    End Set
  End Property

  Public Property Length() As Decimal
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      If pLength <> value Then IsDirty = True
      pLength = value
    End Set
  End Property


  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property QuantityUsed() As Decimal
    Get
      Return pQuantityUsed
    End Get
    Set(ByVal value As Decimal)
      If pQuantityUsed <> value Then IsDirty = True
      pQuantityUsed = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pDescription
    End Get
    Set(value As String)
      If pDescription <> value Then IsDirty = True

      pDescription = value
    End Set
  End Property

  Public Property StockCode As String
    Get
      Return pStockCode
    End Get
    Set(value As String)
      If pStockCode <> value Then IsDirty = True

      pStockCode = value
    End Set
  End Property

  Public Property Thickness As Decimal
    Get
      Return pThickness
    End Get
    Set(value As Decimal)
      If pThickness <> value Then IsDirty = True

      pThickness = value
    End Set
  End Property

  Public Sub SetQtyUsed(ByVal vNewValue As Decimal)
    pQuantityUsed = vNewValue
  End Sub


  Public Property OutstandingQty As Decimal
    Get
      Return pOutstandingQty
    End Get
    Set(value As Decimal)
      If pOutstandingQty <> value Then IsDirty = True

      pOutstandingQty = value
    End Set
  End Property

  Public Property VolumeM3 As Decimal
    Get
      Return pVolumeM3
    End Get
    Set(value As Decimal)
      If pVolumeM3 <> value Then IsDirty = True

      pVolumeM3 = value
    End Set
  End Property

  Public Property DifferenceTranQty As Decimal
    Get
      Return pDifferenceTranQty
    End Get
    Set(value As Decimal)
      pDifferenceTranQty = value
    End Set
  End Property

  Public Property TrozaRef As String
    Get
      Return pTrozaRef
    End Get
    Set(value As String)
      If pTrozaRef <> value Then IsDirty = True
      pTrozaRef = value
    End Set
  End Property
End Class



''Collection Definition - WoodPalletItem (to WoodPalletItem)'Generated from Table:WoodPalletItem

'Private pWoodPalletItems As colWoodPalletItems
'Public Property WoodPalletItems() As colWoodPalletItems
'  Get
'    Return pWoodPalletItems
'  End Get
'  Set(ByVal value As colWoodPalletItems)
'    pWoodPalletItems = value
'  End Set
'End Property

'  pWoodPalletItems = New colWoodPalletItems 'Add to New
'  pWoodPalletItems = Nothing 'Add to Finalize
'  .WoodPalletItems = WoodPalletItems.Clone 'Add to CloneTo
'  WoodPalletItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodPalletItems.IsDirty 'Add to IsAnyDirty

Public Class colWoodPalletItems : Inherits colBase(Of dmWoodPalletItem)

  Public Overrides Function IndexFromKey(ByVal vWoodPalletItemID As Integer) As Integer
    Dim mItem As dmWoodPalletItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodPalletItemID = vWoodPalletItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Function GetTotalBoardFeet(ByVal vStockItemID As Integer) As Decimal
    Dim mRetVal As Decimal
    Dim mStockItem As dmStockItem

    For Each mItem In Me

      If mItem.StockItemID = vStockItemID Then
        mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mItem.StockItemID)

        If mStockItem IsNot Nothing Then




          mRetVal += clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mItem, mStockItem)
        End If
      End If
    Next

    Return mRetVal
  End Function

  Public Sub New(ByVal vList As List(Of dmWoodPalletItem))
    MyBase.New(vList)
  End Sub

  Public Function ItemByStockItemID(ByVal vStockItemID As Integer) As dmWoodPalletItem
    Dim mRetVal As dmWoodPalletItem = Nothing

    For Each mItem As dmWoodPalletItem In MyBase.Items
      If mItem.StockItemID = vStockItemID Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemFromWoodPalletItem(ByVal vWoodPalletID As Integer) As dmWoodPalletItem
    Dim mRetVal As dmWoodPalletItem = Nothing

    For Each mItem As dmWoodPalletItem In MyBase.Items
      If mItem.WoodPalletID = vWoodPalletID Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function GetIndexByWoodPalletItemID(ByVal vWoodPalletItemID As Integer) As Integer
    Dim mIndex As Integer = -1
    Dim mRetVal As Integer = -1
    For Each mItem As dmWoodPalletItem In MyBase.Items
      mIndex = mIndex + 1
      If mItem.WoodPalletItemID = vWoodPalletItemID Then
        mRetVal = mIndex

        Exit For
      End If
    Next
    Return mRetVal
  End Function
End Class




