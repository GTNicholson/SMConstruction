''Class Definition - StockItemLocationAmendmentLog (to StockItemLocationAmendmentLog)'Generated from Table:StockItemLocationAmendmentLog
Imports RTIS.CommonVB

Public Class dmStockItemLocationAmendmentLog : Inherits dmBase
  Private pStockItemLocationAmendmentLogID As Int32
  Private pSystemDate As DateTime
  Private pAmendmentDate As DateTime
  Private pStockItemLocationID As Int32
  Private pChangeDetails As String
  Private pUserID As Int32
  Private pUserNotes As String

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
    StockItemLocationAmendmentLogID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemLocationAmendmentLog)
      .StockItemLocationAmendmentLogID = StockItemLocationAmendmentLogID
      .SystemDate = SystemDate
      .AmendmentDate = AmendmentDate
      .StockItemLocationID = StockItemLocationID
      .ChangeDetails = ChangeDetails
      .UserID = UserID
      .UserNotes = UserNotes
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemLocationAmendmentLogID() As Int32
    Get
      Return pStockItemLocationAmendmentLogID
    End Get
    Set(ByVal value As Int32)
      If pStockItemLocationAmendmentLogID <> value Then IsDirty = True
      pStockItemLocationAmendmentLogID = value
    End Set
  End Property

  Public Property SystemDate() As DateTime
    Get
      Return pSystemDate
    End Get
    Set(ByVal value As DateTime)
      If pSystemDate <> value Then IsDirty = True
      pSystemDate = value
    End Set
  End Property

  Public Property AmendmentDate() As DateTime
    Get
      Return pAmendmentDate
    End Get
    Set(ByVal value As DateTime)
      If pAmendmentDate <> value Then IsDirty = True
      pAmendmentDate = value
    End Set
  End Property

  Public Property StockItemLocationID() As Int32
    Get
      Return pStockItemLocationID
    End Get
    Set(ByVal value As Int32)
      If pStockItemLocationID <> value Then IsDirty = True
      pStockItemLocationID = value
    End Set
  End Property

  Public Property ChangeDetails() As String
    Get
      Return pChangeDetails
    End Get
    Set(ByVal value As String)
      If pChangeDetails <> value Then IsDirty = True
      pChangeDetails = value
    End Set
  End Property

  Public Property UserID() As Int32
    Get
      Return pUserID
    End Get
    Set(ByVal value As Int32)
      If pUserID <> value Then IsDirty = True
      pUserID = value
    End Set
  End Property

  Public Property UserNotes() As String
    Get
      Return pUserNotes
    End Get
    Set(ByVal value As String)
      If pUserNotes <> value Then IsDirty = True
      pUserNotes = value
    End Set
  End Property


End Class



''Collection Definition - StockItemLocationAmendmentLog (to StockItemLocationAmendmentLog)'Generated from Table:StockItemLocationAmendmentLog

'Private pStockItemLocationAmendmentLogs As colStockItemLocationAmendmentLogs
'Public Property StockItemLocationAmendmentLogs() As colStockItemLocationAmendmentLogs
'  Get
'    Return pStockItemLocationAmendmentLogs
'  End Get
'  Set(ByVal value As colStockItemLocationAmendmentLogs)
'    pStockItemLocationAmendmentLogs = value
'  End Set
'End Property

'  pStockItemLocationAmendmentLogs = New colStockItemLocationAmendmentLogs 'Add to New
'  pStockItemLocationAmendmentLogs = Nothing 'Add to Finalize
'  .StockItemLocationAmendmentLogs = StockItemLocationAmendmentLogs.Clone 'Add to CloneTo
'  StockItemLocationAmendmentLogs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemLocationAmendmentLogs.IsDirty 'Add to IsAnyDirty

Public Class colStockItemLocationAmendmentLogs : Inherits colBase(Of dmStockItemLocationAmendmentLog)

  Public Overrides Function IndexFromKey(ByVal vStockItemLocationAmendmentLogID As Integer) As Integer
    Dim mItem As dmStockItemLocationAmendmentLog
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemLocationAmendmentLogID = vStockItemLocationAmendmentLogID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemLocationAmendmentLog))
    MyBase.New(vList)
  End Sub

End Class


