''Class Definition - SourcePallet (to SourcePallet)'Generated from Table:SourcePallet
Imports RTIS.CommonVB

Public Class dmSourcePallet : Inherits dmBase
  Private pSourcePalletID As Int32
  Private pWorkOrderID As Int32
  Private pWoodPalletID As Int32

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
    SourcePalletID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSourcePallet)
      .SourcePalletID = SourcePalletID
      .WorkOrderID = WorkOrderID
      .WoodPalletID = WoodPalletID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SourcePalletID() As Int32
    Get
      Return pSourcePalletID
    End Get
    Set(ByVal value As Int32)
      If pSourcePalletID <> value Then IsDirty = True
      pSourcePalletID = value
    End Set
  End Property

  Public Property WorkOrderID() As Int32
    Get
      Return pWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
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


End Class



''Collection Definition - SourcePallet (to SourcePallet)'Generated from Table:SourcePallet

'Private pSourcePallets As colSourcePallets
'Public Property SourcePallets() As colSourcePallets
'  Get
'    Return pSourcePallets
'  End Get
'  Set(ByVal value As colSourcePallets)
'    pSourcePallets = value
'  End Set
'End Property

'  pSourcePallets = New colSourcePallets 'Add to New
'  pSourcePallets = Nothing 'Add to Finalize
'  .SourcePallets = SourcePallets.Clone 'Add to CloneTo
'  SourcePallets.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SourcePallets.IsDirty 'Add to IsAnyDirty

Public Class colSourcePallets : Inherits colBase(Of dmSourcePallet)

  Public Overrides Function IndexFromKey(ByVal vSourcePalletID As Integer) As Integer
    Dim mItem As dmSourcePallet
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SourcePalletID = vSourcePalletID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSourcePallet))
    MyBase.New(vList)
  End Sub

End Class

