''Class Definition - OutputPallet (to OutputPallet)'Generated from Table:OutputPallet
Imports RTIS.CommonVB

Public Class dmOutputPallet : Inherits dmBase
  Private pOutputPalletID As Int32
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
    OutputPalletID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmOutputPallet)
      .OutputPalletID = OutputPalletID
      .WorkOrderID = WorkOrderID
      .WoodPalletID = WoodPalletID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property OutputPalletID() As Int32
    Get
      Return pOutputPalletID
    End Get
    Set(ByVal value As Int32)
      If pOutputPalletID <> value Then IsDirty = True
      pOutputPalletID = value
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



''Collection Definition - OutputPallet (to OutputPallet)'Generated from Table:OutputPallet

'Private pOutputPallets As colOutputPallets
'Public Property OutputPallets() As colOutputPallets
'  Get
'    Return pOutputPallets
'  End Get
'  Set(ByVal value As colOutputPallets)
'    pOutputPallets = value
'  End Set
'End Property

'  pOutputPallets = New colOutputPallets 'Add to New
'  pOutputPallets = Nothing 'Add to Finalize
'  .OutputPallets = OutputPallets.Clone 'Add to CloneTo
'  OutputPallets.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = OutputPallets.IsDirty 'Add to IsAnyDirty

Public Class colOutputPallets : Inherits colBase(Of dmOutputPallet)

  Public Overrides Function IndexFromKey(ByVal vOutputPalletID As Integer) As Integer
    Dim mItem As dmOutputPallet
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.OutputPalletID = vOutputPalletID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmOutputPallet))
    MyBase.New(vList)
  End Sub

End Class


