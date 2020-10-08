''Class Definition - HouseType (to HouseType)'Generated from Table:HouseType
Imports RTIS.CommonVB

Public Class dmHouseType : Inherits dmBase
  Implements iValueItem

  Private pHouseTypeID As Int32
  Private pModelName As String
  Private pGroupID As Integer
  Private pModelID As Integer
  Private pArea As Decimal

  Private pSalesItemAssemblys As colSalesItemAssemblys
  Private pHTSalesItems As colHouseTypeSalesItemss

  Public Sub New()
    MyBase.New()
    pSalesItemAssemblys = New colSalesItemAssemblys
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
      If mAnyDirty = False Then mAnyDirty = pSalesItemAssemblys.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    HouseTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmHouseType)
      .HouseTypeID = HouseTypeID
      .ModelName = ModelName
      .GroupID = GroupID
      .ModelID = ModelID
      .Area = Area

      'Add entries here for each collection and class property
      .SalesItemAssemblys = SalesItemAssemblys.Clone

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property GroupID() As Int32
    Get
      Return pGroupID
    End Get
    Set(ByVal value As Int32)
      If pGroupID <> value Then IsDirty = True
      pGroupID = value
    End Set
  End Property

  Public Property ModelID() As Int32
    Get
      Return pModelID
    End Get
    Set(ByVal value As Int32)
      If pModelID <> value Then IsDirty = True
      pModelID = value
    End Set
  End Property

  Public Property Area() As Decimal
    Get
      Return pArea
    End Get
    Set(ByVal value As Decimal)
      If pArea <> value Then IsDirty = True
      pArea = value
    End Set
  End Property
  Public Property HouseTypeID() As Int32
    Get
      Return pHouseTypeID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeID <> value Then IsDirty = True
      pHouseTypeID = value
    End Set
  End Property

  Public Property ModelName() As String
    Get
      Return pModelName
    End Get
    Set(ByVal value As String)
      If pModelName <> value Then IsDirty = True
      pModelName = value
    End Set
  End Property

  Public Property ItemValue As Integer Implements iValueItem.ItemValue
    Get
      Return pHouseTypeID
    End Get
    Set(value As Integer)
      pHouseTypeID = value
    End Set
  End Property

  Public Property DisplayValue As String Implements iValueItem.DisplayValue
    Get
      Return pModelName
    End Get
    Set(value As String)
      pModelName = value
    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property


  Public Property SalesItemAssemblys As colSalesItemAssemblys
    Get
      Return pSalesItemAssemblys
    End Get
    Set(value As colSalesItemAssemblys)
      pSalesItemAssemblys = value
    End Set
  End Property

End Class



''Collection Definition - HouseType (to HouseType)'Generated from Table:HouseType

'Private pHouseTypes As colHouseTypes
'Public Property HouseTypes() As colHouseTypes
'  Get
'    Return pHouseTypes
'  End Get
'  Set(ByVal value As colHouseTypes)
'    pHouseTypes = value
'  End Set
'End Property

'  pHouseTypes = New colHouseTypes 'Add to New
'  pHouseTypes = Nothing 'Add to Finalize
'  .HouseTypes = HouseTypes.Clone 'Add to CloneTo
'  HouseTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = HouseTypes.IsDirty 'Add to IsAnyDirty

Public Class colHouseTypes : Inherits colBase(Of dmHouseType)

  Public Overrides Function IndexFromKey(ByVal vHouseTypeID As Integer) As Integer
    Dim mItem As dmHouseType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HouseTypeID = vHouseTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmHouseType))
    MyBase.New(vList)
  End Sub

End Class



