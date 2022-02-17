''Class Definition - WoodGuideItemSummary (to WoodGuideItemSummary)'Generated from Table:WoodGuideItemSummary
Imports RTIS.CommonVB

Public Class dmWoodGuideItemSummary : Inherits dmBase
  Private pWoodGuideItemSummaryID As Int32
  Private pWoodReceptionID As Int32
  Private pSpeciesID As Int32
  Private pQuantity As Int32
  Private pAverageDiameter As Decimal
  Private pLength As Decimal
  Private pVolumeM3 As Decimal
  Private pTmpTotalDiameterSUM As Decimal
  Private pTotalQtyByLength As Integer
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
    WoodGuideItemSummaryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodGuideItemSummary)
      .WoodGuideItemSummaryID = WoodGuideItemSummaryID
      .WoodReceptionID = WoodReceptionID
      .SpeciesID = SpeciesID
      .Quantity = Quantity
      .AverageDiameter = AverageDiameter
      .Length = Length
      .VolumeM3 = VolumeM3
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodGuideItemSummaryID() As Int32
    Get
      Return pWoodGuideItemSummaryID
    End Get
    Set(ByVal value As Int32)
      If pWoodGuideItemSummaryID <> value Then IsDirty = True
      pWoodGuideItemSummaryID = value
    End Set
  End Property

  Public Property WoodReceptionID() As Int32
    Get
      Return pWoodReceptionID
    End Get
    Set(ByVal value As Int32)
      If pWoodReceptionID <> value Then IsDirty = True
      pWoodReceptionID = value
    End Set
  End Property

  Public Property SpeciesID() As Int32
    Get
      Return pSpeciesID
    End Get
    Set(ByVal value As Int32)
      If pSpeciesID <> value Then IsDirty = True
      pSpeciesID = value
    End Set
  End Property

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property AverageDiameter() As Decimal
    Get
      Return pAverageDiameter
    End Get
    Set(ByVal value As Decimal)
      If pAverageDiameter <> value Then IsDirty = True
      pAverageDiameter = value
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

  Public Property VolumeM3() As Decimal
    Get
      Return pVolumeM3
    End Get
    Set(ByVal value As Decimal)
      If pVolumeM3 <> value Then IsDirty = True
      pVolumeM3 = value
    End Set
  End Property

  Public Property TempTotalQtyByLength As Integer
    Get
      Return pTotalQtyByLength
    End Get
    Set(value As Integer)
      pTotalQtyByLength = value
    End Set
  End Property

  Public Property TempTotalDiameterSUM As Decimal
    Get
      Return pTmpTotalDiameterSUM
    End Get
    Set(value As Decimal)
      pTmpTotalDiameterSUM = value
    End Set
  End Property
End Class



''Collection Definition - WoodGuideItemSummary (to WoodGuideItemSummary)'Generated from Table:WoodGuideItemSummary

'Private pWoodGuideItemSummarys As colWoodGuideItemSummarys
'Public Property WoodGuideItemSummarys() As colWoodGuideItemSummarys
'  Get
'    Return pWoodGuideItemSummarys
'  End Get
'  Set(ByVal value As colWoodGuideItemSummarys)
'    pWoodGuideItemSummarys = value
'  End Set
'End Property

'  pWoodGuideItemSummarys = New colWoodGuideItemSummarys 'Add to New
'  pWoodGuideItemSummarys = Nothing 'Add to Finalize
'  .WoodGuideItemSummarys = WoodGuideItemSummarys.Clone 'Add to CloneTo
'  WoodGuideItemSummarys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodGuideItemSummarys.IsDirty 'Add to IsAnyDirty

Public Class colWoodGuideItemSummarys : Inherits colBase(Of dmWoodGuideItemSummary)

  Public Overrides Function IndexFromKey(ByVal vWoodGuideItemSummaryID As Integer) As Integer
    Dim mItem As dmWoodGuideItemSummary
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodGuideItemSummaryID = vWoodGuideItemSummaryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodGuideItemSummary))
    MyBase.New(vList)
  End Sub

  Public Function GetItemFromSpeciesAndLength(ByVal vSpeciesID As Integer, ByVal vLength As Decimal, ByVal vDiameter As Decimal) As dmWoodGuideItemSummary
    Dim mRetVal As dmWoodGuideItemSummary = Nothing

    For Each mItem In Me.Items

      If mItem.SpeciesID = vSpeciesID And mItem.Length = vLength Then
        mRetVal = mItem
        Exit For
      End If

    Next

    Return mRetVal
  End Function


End Class


