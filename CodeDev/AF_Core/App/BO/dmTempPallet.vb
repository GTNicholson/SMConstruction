''Class Definition - TempPallet (to TempPallet)'Generated from Table:TempPallet
Imports RTIS.CommonVB

Public Class dmTempPallet : Inherits dmBase
  Private pTempPalletID As Int32
  Private pSpeciesID As Int32
  Private pBulto As String
  Private pGrosor As Decimal
  Private pAncho As Decimal
  Private pLargo As Decimal
  Private pItemTypeID As Int32
  Private pCantidad As Int32
  Private pLocationID As Integer
  Private pWorkOrderID As Integer
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
    TempPalletID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmTempPallet)
      .TempPalletID = TempPalletID
      .SpeciesID = SpeciesID
      .Bulto = Bulto
      .Grosor = Grosor
      .Ancho = Ancho
      .Largo = Largo
      .ItemTypeID = ItemTypeID
      .Cantidad = Cantidad
      .WorkOrderID = WorkOrderID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property TempPalletID() As Int32
    Get
      Return pTempPalletID
    End Get
    Set(ByVal value As Int32)
      If pTempPalletID <> value Then IsDirty = True
      pTempPalletID = value
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

  Public Property Bulto() As String
    Get
      Return pBulto
    End Get
    Set(ByVal value As String)
      If pBulto <> value Then IsDirty = True
      pBulto = value
    End Set
  End Property

  Public Property Grosor() As Decimal
    Get
      Return pGrosor
    End Get
    Set(ByVal value As Decimal)
      If pGrosor <> value Then IsDirty = True
      pGrosor = value
    End Set
  End Property

  Public Property Ancho() As Decimal
    Get
      Return pAncho
    End Get
    Set(ByVal value As Decimal)
      If pAncho <> value Then IsDirty = True
      pAncho = value
    End Set
  End Property

  Public Property Largo() As Decimal
    Get
      Return pLargo
    End Get
    Set(ByVal value As Decimal)
      If pLargo <> value Then IsDirty = True
      pLargo = value
    End Set
  End Property

  Public Property ItemTypeID() As Int32
    Get
      Return pItemTypeID
    End Get
    Set(ByVal value As Int32)
      If pItemTypeID <> value Then IsDirty = True
      pItemTypeID = value
    End Set
  End Property

  Public Property Cantidad() As Int32
    Get
      Return pCantidad
    End Get
    Set(ByVal value As Int32)
      If pCantidad <> value Then IsDirty = True
      pCantidad = value
    End Set
  End Property

  Public Property LocationID As Integer
    Get
      Return pLocationID
    End Get
    Set(value As Integer)
      If pLocationID <> value Then IsDirty = True
      pLocationID = value
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
End Class



''Collection Definition - TempPallet (to TempPallet)'Generated from Table:TempPallet

'Private pTempPallets As colTempPallets
'Public Property TempPallets() As colTempPallets
'  Get
'    Return pTempPallets
'  End Get
'  Set(ByVal value As colTempPallets)
'    pTempPallets = value
'  End Set
'End Property

'  pTempPallets = New colTempPallets 'Add to New
'  pTempPallets = Nothing 'Add to Finalize
'  .TempPallets = TempPallets.Clone 'Add to CloneTo
'  TempPallets.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = TempPallets.IsDirty 'Add to IsAnyDirty

Public Class colTempPallets : Inherits colBase(Of dmTempPallet)

  Public Overrides Function IndexFromKey(ByVal vTempPalletID As Integer) As Integer
    Dim mItem As dmTempPallet
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.TempPalletID = vTempPalletID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmTempPallet))
    MyBase.New(vList)
  End Sub

End Class



