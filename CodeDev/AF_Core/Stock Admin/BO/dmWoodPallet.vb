''Class Definition - WoodPallet (to WoodPallet)'Generated from Table:WoodPallet
Imports RTIS.CommonVB

Public Class dmWoodPallet : Inherits dmBase
  Private pWoodPalletID As Int32
  Private pPalletRef As String
  Private pCreatedDate As DateTime
  Private pLocationID As Int32
  Private ptmpIsFullyLoadedDown As Boolean
  Private pArchive As Boolean
  Private pDescription As String
  Private pWoodPalletItems As colWoodPalletItems
  Private pPalletType As Integer
  Private pRefPalletOutside As String
  Private pKilnStartDate As Date
  Private pKilnEndDate As Date
  Private pIsComplete As Boolean
  Private pIntoWIPDate As Date
  Private pFarm As Integer
  Private pReceptionID As Integer
  Private pCardNumber As String
  Private pWorkOrderID As Integer
  Private pisProduction As Boolean

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pWoodPalletItems = New colWoodPalletItems
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pWoodPalletItems = Nothing
    MyBase.Finalize()

  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pWoodPalletItems.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    WoodPalletID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWoodPallet)
      .WoodPalletID = WoodPalletID
      .PalletRef = PalletRef
      .CreatedDate = CreatedDate
      .LocationID = LocationID
      .tmpIsFullyLoadedDown = tmpIsFullyLoadedDown
      .Archive = Archive
      .Description = Description
      .PalletType = PalletType
      .RefPalletOutside = RefPalletOutside
      .KilnStartDate = KilnStartDate
      .KilnEndDate = KilnEndDate
      .IsComplete = IsComplete
      .IntoWIPDate = IntoWIPDate
      .Farm = Farm
      .ReceptionID = ReceptionID
      .CardNumber = CardNumber
      .WorkOrderID = WorkOrderID
      .isProduction = isProduction
      .WoodPalletItems = WoodPalletItems.clone
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WoodPalletID() As Int32
    Get
      Return pWoodPalletID
    End Get
    Set(ByVal value As Int32)
      If pWoodPalletID <> value Then IsDirty = True
      pWoodPalletID = value
    End Set
  End Property

  Public Property PalletRef() As String
    Get
      Return pPalletRef
    End Get
    Set(ByVal value As String)
      If pPalletRef <> value Then IsDirty = True
      pPalletRef = value
    End Set
  End Property

  Public Property CreatedDate() As DateTime
    Get
      Return pCreatedDate
    End Get
    Set(ByVal value As DateTime)
      If pCreatedDate <> value Then IsDirty = True
      pCreatedDate = value
    End Set
  End Property

  Public Property LocationID() As Int32
    Get
      Return pLocationID
    End Get
    Set(ByVal value As Int32)
      If pLocationID <> value Then IsDirty = True
      pLocationID = value
    End Set
  End Property

  Public ReadOnly Property LocationDesc As String
    Get
      Dim mRetVal As String = ""

      If LocationID > 0 Then
        mRetVal = clsEnumsConstants.GetEnumDescription(GetType(eLocations), CType(LocationID, eLocations))
      End If

      Return mRetVal
    End Get
  End Property
  Public Property CardNumber As String
    Get
      Return pCardNumber
    End Get
    Set(value As String)
      If pCardNumber <> value Then IsDirty = True
      pCardNumber = value
    End Set
  End Property

  Public Property Archive() As Boolean
    Get
      Return pArchive
    End Get
    Set(ByVal value As Boolean)
      If pArchive <> value Then IsDirty = True
      pArchive = value
    End Set
  End Property
  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property


  Public Property WoodPalletItems As colWoodPalletItems
    Get
      Return pWoodPalletItems
    End Get
    Set(value As colWoodPalletItems)
      pWoodPalletItems = value
    End Set
  End Property

  Public Property tmpIsFullyLoadedDown() As Boolean
    Get
      tmpIsFullyLoadedDown = ptmpIsFullyLoadedDown
    End Get
    Set(ByVal value As Boolean)
      ptmpIsFullyLoadedDown = value
    End Set
  End Property

  Public Property PalletType() As Integer
    Get
      Return pPalletType
    End Get
    Set(ByVal value As Integer)
      If pPalletType <> value Then IsDirty = True
      pPalletType = value
    End Set
  End Property

  Public Property IsComplete As String
    Get
      Return pIsComplete
    End Get
    Set(ByVal value As String)
      If pIsComplete <> value Then IsDirty = True
      pIsComplete = value
    End Set
  End Property

  Public Property RefPalletOutside As String
    Get
      Return pRefPalletOutside
    End Get
    Set(ByVal value As String)
      If pRefPalletOutside <> value Then IsDirty = True
      pRefPalletOutside = value
    End Set
  End Property

  Public Property KilnStartDate As Date
    Get
      Return pKilnStartDate
    End Get
    Set(value As Date)
      If pKilnStartDate <> value Then IsDirty = True

      pKilnStartDate = value
    End Set
  End Property

  Public Property KilnEndDate As Date
    Get
      Return pKilnEndDate
    End Get
    Set(value As Date)
      If pKilnEndDate <> value Then IsDirty = True

      pKilnEndDate = value
    End Set
  End Property

  Public ReadOnly Property PalletTypeDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTimberWood), CType(pPalletType, eStockItemTypeTimberWood.eStockItemTimberWood))

    End Get
  End Property

  Public Property IntoWIPDate As Date
    Get
      Return pIntoWIPDate
    End Get
    Set(value As Date)
      If pIntoWIPDate <> value Then IsDirty = True
      pIntoWIPDate = value
    End Set
  End Property

  Public Property Farm As Integer
    Get
      Return pFarm
    End Get
    Set(value As Integer)
      If pFarm <> value Then IsDirty = True
      pFarm = value
    End Set
  End Property

  Public ReadOnly Property FarmDesc As String
    Get
      Dim mRetVal As String = ""

      mRetVal = clsEnumsConstants.GetEnumDescription(GetType(eFarms), CType(Farm, eFarms))

      Return mRetVal
    End Get
  End Property

  Public Property ReceptionID As Integer
    Get
      Return pReceptionID
    End Get
    Set(value As Integer)
      If pReceptionID <> value Then IsDirty = True
      pReceptionID = value
    End Set
  End Property

  Public Property WorkOrderID As Integer
    Get
      Return pWorkOrderID
    End Get
    Set(value As Integer)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
    End Set
  End Property

  Public Property isProduction As Boolean
    Get
      Return pisProduction
    End Get
    Set(value As Boolean)
      If pisProduction <> value Then IsDirty = True
      pisProduction = value
    End Set
  End Property
End Class



''Collection Definition - WoodPallet (to WoodPallet)'Generated from Table:WoodPallet

'Private pWoodPallets As colWoodPallets
'Public Property WoodPallets() As colWoodPallets
'  Get
'    Return pWoodPallets
'  End Get
'  Set(ByVal value As colWoodPallets)
'    pWoodPallets = value
'  End Set
'End Property

'  pWoodPallets = New colWoodPallets 'Add to New
'  pWoodPallets = Nothing 'Add to Finalize
'  .WoodPallets = WoodPallets.Clone 'Add to CloneTo
'  WoodPallets.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WoodPallets.IsDirty 'Add to IsAnyDirty

Public Class colWoodPallets : Inherits colBase(Of dmWoodPallet)

  Public Overrides Function IndexFromKey(ByVal vWoodPalletID As Integer) As Integer
    Dim mItem As dmWoodPallet
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WoodPalletID = vWoodPalletID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWoodPallet))
    MyBase.New(vList)
  End Sub

End Class




