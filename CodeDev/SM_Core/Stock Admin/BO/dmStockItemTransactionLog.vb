''Class Definition - StockItemTransactionLog (to StockItemTransactionLog)'Generated from Table:StockItemTransactionLog
Imports RTIS.CommonVB

Public Class dmStockItemTransactionLog : Inherits dmBase
  Private pStockItemTransactionLogID As Int32
  Private pObjectType As Byte
  Private pObjectID As Int32
  Private pTransactionType As Byte
  Private pUserID As Int32
  Private pTranValue As Decimal
  Private pPrevValue As Decimal
  Private pNewValue As Decimal
  Private pSystemDate As DateTime
  Private pTransactionDate As DateTime
  Private pRefObjectType As Byte
  Private pRefObjectID As Int32
  Private pAdditionalRef As Int32
  Private pNote As String
  Private pStdCost As Decimal
  Private pTransactionValuation As Decimal
  Private pStockValuation As Decimal

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
    StockItemTransactionLogID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemTransactionLog)
      .StockItemTransactionLogID = StockItemTransactionLogID
      .ObjectType = ObjectType
      .ObjectID = ObjectID
      .TransactionType = TransactionType
      .UserID = UserID
      .TranValue = TranValue
      .PrevValue = PrevValue
      .NewValue = NewValue
      .SystemDate = SystemDate
      .TransactionDate = TransactionDate
      .RefObjectType = RefObjectType
      .RefObjectID = RefObjectID
      .AdditionalRef = AdditionalRef
      .Note = Note
      .TransactionValuation = TransactionValuation
      .StockValuation = StockValuation
      .StdCost = StdCost
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemTransactionLogID() As Int32
    Get
      Return pStockItemTransactionLogID
    End Get
    Set(ByVal value As Int32)
      If pStockItemTransactionLogID <> value Then IsDirty = True
      pStockItemTransactionLogID = value
    End Set
  End Property

  Public Property ObjectType() As Byte
    Get
      Return pObjectType
    End Get
    Set(ByVal value As Byte)
      If pObjectType <> value Then IsDirty = True
      pObjectType = value
    End Set
  End Property

  Public Property ObjectID() As Int32
    Get
      Return pObjectID
    End Get
    Set(ByVal value As Int32)
      If pObjectID <> value Then IsDirty = True
      pObjectID = value
    End Set
  End Property

  Public Property TransactionType() As Byte
    Get
      Return pTransactionType
    End Get
    Set(ByVal value As Byte)
      If pTransactionType <> value Then IsDirty = True
      pTransactionType = value
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

  Public Property TranValue() As Decimal
    Get
      Return pTranValue
    End Get
    Set(ByVal value As Decimal)
      If pTranValue <> value Then IsDirty = True
      pTranValue = value
    End Set
  End Property

  Public Property PrevValue() As Decimal
    Get
      Return pPrevValue
    End Get
    Set(ByVal value As Decimal)
      If pPrevValue <> value Then IsDirty = True
      pPrevValue = value
    End Set
  End Property

  Public Property NewValue() As Decimal
    Get
      Return pNewValue
    End Get
    Set(ByVal value As Decimal)
      If pNewValue <> value Then IsDirty = True
      pNewValue = value
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

  Public Property TransactionDate() As DateTime
    Get
      Return pTransactionDate
    End Get
    Set(ByVal value As DateTime)
      If pTransactionDate <> value Then IsDirty = True
      pTransactionDate = New Date(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second)
    End Set
  End Property

  Public Property RefObjectType() As Byte
    Get
      Return pRefObjectType
    End Get
    Set(ByVal value As Byte)
      If pRefObjectType <> value Then IsDirty = True
      pRefObjectType = value
    End Set
  End Property

  Public Property RefObjectID() As Int32
    Get
      Return pRefObjectID
    End Get
    Set(ByVal value As Int32)
      If pRefObjectID <> value Then IsDirty = True
      pRefObjectID = value
    End Set
  End Property

  Public Property AdditionalRef() As Int32
    Get
      Return pAdditionalRef
    End Get
    Set(ByVal value As Int32)
      If pAdditionalRef <> value Then IsDirty = True
      pAdditionalRef = value
    End Set
  End Property

  Public Property Note() As String
    Get
      Return pNote
    End Get
    Set(ByVal value As String)
      If pNote <> value Then IsDirty = True
      pNote = value
    End Set
  End Property

  Public Property StdCost() As Decimal
    Get
      Return pStdCost
    End Get
    Set(ByVal value As Decimal)
      If pStdCost <> value Then IsDirty = True
      pStdCost = value
    End Set
  End Property

  Public Property TransactionValuation() As Decimal
    Get
      Return pTransactionValuation
    End Get
    Set(ByVal value As Decimal)
      If pTransactionValuation <> value Then IsDirty = True
      pTransactionValuation = value
    End Set
  End Property

  Public Property StockValuation() As Decimal
    Get
      Return pStockValuation
    End Get
    Set(ByVal value As Decimal)
      If pStockValuation <> value Then IsDirty = True
      pStockValuation = value
    End Set
  End Property

  Public Shared Function SortStockItemTransactionLog() As IComparer(Of dmStockItemTransactionLog)
    Return CType(New clsStockItemTransactionLogSorter, IComparer(Of dmStockItemTransactionLog))
  End Function

  Public Class clsStockItemTransactionLogSorter
    Implements IComparer(Of dmStockItemTransactionLog)

    Public Function Compare(ByVal mObj1 As dmStockItemTransactionLog, ByVal mObj2 As dmStockItemTransactionLog) As Integer Implements IComparer(Of dmStockItemTransactionLog).Compare
      Dim mRetval As Integer
      If mObj1.ObjectType < mObj2.ObjectType Then
        mRetval = -1
      ElseIf mObj1.ObjectType > mObj2.ObjectType Then
        mRetval = 1
      Else
        If mObj1.ObjectID < mObj2.ObjectID Then
          mRetval = -1
        ElseIf mObj1.ObjectID > mObj2.ObjectID Then
          mRetval = 1
        Else
          If mObj1.TransactionDate < mObj2.TransactionDate Then
            mRetval = -1
          ElseIf mObj1.TransactionDate > mObj2.TransactionDate Then
            mRetval = 1
          Else
            If mObj1.StockItemTransactionLogID < mObj2.StockItemTransactionLogID Then
              mRetval = -1
            ElseIf mObj1.StockItemTransactionLogID > mObj2.StockItemTransactionLogID Then
              mRetval = 1
            Else
              mRetval = 0
            End If
          End If
        End If
      End If
      Return mRetval
    End Function

  End Class

End Class



''Collection Definition - StockItemTransactionLog (to StockItemTransactionLog)'Generated from Table:StockItemTransactionLog

'Private pStockItemTransactionLogs As colStockItemTransactionLogs
'Public Property StockItemTransactionLogs() As colStockItemTransactionLogs
'  Get
'    Return pStockItemTransactionLogs
'  End Get
'  Set(ByVal value As colStockItemTransactionLogs)
'    pStockItemTransactionLogs = value
'  End Set
'End Property

'  pStockItemTransactionLogs = New colStockItemTransactionLogs 'Add to New
'  pStockItemTransactionLogs = Nothing 'Add to Finalize
'  .StockItemTransactionLogs = StockItemTransactionLogs.Clone 'Add to CloneTo
'  StockItemTransactionLogs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemTransactionLogs.IsDirty 'Add to IsAnyDirty

Public Class colStockItemTransactionLogs : Inherits colBase(Of dmStockItemTransactionLog)

  Public Overrides Function IndexFromKey(ByVal vStockItemTransactionLogID As Integer) As Integer
    Dim mItem As dmStockItemTransactionLog
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemTransactionLogID = vStockItemTransactionLogID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemTransactionLog))
    MyBase.New(vList)
    TrackDeleted = True
  End Sub

  Public Function ItemsByObjectType(ByVal vObjectType As Byte) As colStockItemTransactionLogs
    Dim mRetVal As New colStockItemTransactionLogs

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      If mItem.ObjectType = vObjectType Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemsByObjectID(ByVal vObjectID As Integer) As colStockItemTransactionLogs
    Dim mRetVal As New colStockItemTransactionLogs

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      If mItem.ObjectID = vObjectID Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemsByTransType(ByVal vTranTypeID As eTransactionType) As colStockItemTransactionLogs
    Dim mRetVal As New colStockItemTransactionLogs

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      If mItem.TransactionType = vTranTypeID Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemsByRefObjectType(ByVal vRefObjectType As Byte) As colStockItemTransactionLogs
    Dim mRetVal As New colStockItemTransactionLogs

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      If mItem.RefObjectType = vRefObjectType Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemsByRefObjectID(ByVal vRefObjectID As Integer) As colStockItemTransactionLogs
    Dim mRetVal As New colStockItemTransactionLogs

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      If mItem.RefObjectID = vRefObjectID Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function OrderTransDate() As colStockItemTransactionLogs
    Dim mRetVal As colStockItemTransactionLogs
    Dim mOrderedItems = MyBase.OrderBy(Function(mPack) mPack.TransactionDate).ToList

    mRetVal = New colStockItemTransactionLogs(mOrderedItems)
    Return mRetVal
  End Function

  Public Function TotalTransValue() As Decimal
    Dim mRetVal As Decimal

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      mRetVal += mItem.TranValue
    Next

    Return mRetVal
  End Function

  Public Function TotalAdjustValue() As Decimal
    Dim mRetVal As Decimal

    For Each mItem As dmStockItemTransactionLog In MyBase.Items
      mRetVal += (mItem.PrevValue - mItem.NewValue)
    Next

    Return mRetVal
  End Function

End Class
