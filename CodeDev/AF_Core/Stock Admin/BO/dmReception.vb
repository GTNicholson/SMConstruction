''Class Definition - Reception (to Reception)'Generated from Table:Reception
Imports RTIS.CommonVB

Public Class dmReception : Inherits dmBase
  Private pReceptionID As Int32
  Private pFarm As Int32
  Private pReceptionDate As DateTime
  Private pItemType As Int32
  Private pReceptionNo As String
  Private pWoodPallets As colWoodPallets
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    pWoodPallets = New colWoodPallets
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pWoodPallets = Nothing
    MyBase.Finalize()

  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pWoodPallets.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ReceptionID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmReception)
      .ReceptionID = ReceptionID
      .Farm = Farm
      .ReceptionDate = ReceptionDate
      .ItemType = ItemType
      .ReceptionNo = ReceptionNo
      'Add entries here for each collection and class property

      .WoodPallets = WoodPallets
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ReceptionID() As Int32
    Get
      Return pReceptionID
    End Get
    Set(ByVal value As Int32)
      If pReceptionID <> value Then IsDirty = True
      pReceptionID = value
    End Set
  End Property

  Public Property Farm() As Int32
    Get
      Return pFarm
    End Get
    Set(ByVal value As Int32)
      If pFarm <> value Then IsDirty = True
      pFarm = value
    End Set
  End Property

  Public ReadOnly Property FarmDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eFarms), CType(Farm, eFarms))
    End Get
  End Property


  Public Property ReceptionNo() As String
    Get
      Return pReceptionNo
    End Get
    Set(ByVal value As String)
      If pReceptionNo <> value Then IsDirty = True
      pReceptionNo = value
    End Set
  End Property
  Public Property ReceptionDate() As DateTime
    Get
      Return pReceptionDate
    End Get
    Set(ByVal value As DateTime)
      If pReceptionDate <> value Then IsDirty = True
      pReceptionDate = value
    End Set
  End Property

  Public Property ItemType() As Int32
    Get
      Return pItemType
    End Get
    Set(ByVal value As Int32)
      If pItemType <> value Then IsDirty = True
      pItemType = value
    End Set
  End Property

  Public ReadOnly Property ItemTypeDesc As String
    Get
      Dim mRetVal = ""

      mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTimberWood), CType(ItemType, eStockItemTypeTimberWood.eStockItemTimberWood))
      mRetVal = mRetVal.Trim
      Return mRetVal
    End Get
  End Property
  Public Property WoodPallets As colWoodPallets
    Get
      Return pWoodPallets
    End Get
    Set(value As colWoodPallets)
      pWoodPallets = value
    End Set
  End Property
End Class



''Collection Definition - Reception (to Reception)'Generated from Table:Reception

'Private pReceptions As colReceptions
'Public Property Receptions() As colReceptions
'  Get
'    Return pReceptions
'  End Get
'  Set(ByVal value As colReceptions)
'    pReceptions = value
'  End Set
'End Property

'  pReceptions = New colReceptions 'Add to New
'  pReceptions = Nothing 'Add to Finalize
'  .Receptions = Receptions.Clone 'Add to CloneTo
'  Receptions.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Receptions.IsDirty 'Add to IsAnyDirty

Public Class colReceptions : Inherits colBase(Of dmReception)

  Public Overrides Function IndexFromKey(ByVal vReceptionID As Integer) As Integer
    Dim mItem As dmReception
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ReceptionID = vReceptionID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmReception))
    MyBase.New(vList)
  End Sub

End Class



