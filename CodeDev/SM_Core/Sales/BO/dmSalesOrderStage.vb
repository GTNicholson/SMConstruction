''Class Definition - SalesOrderStage (to SalesOrderStage)'Generated from Table:SalesOrderStage
Imports RTIS.CommonVB

Public Class dmSalesOrderStage : Inherits dmBase
  Private pSalesOrderStageID As Int32
  Private pSalesOrderID As Int32
  Private pTotalCost As Decimal
  Private pStageTypeID As Int32
  Private pDescription As String

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
    SalesOrderStageID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderStage)
      .SalesOrderStageID = SalesOrderStageID
      .SalesOrderID = SalesOrderID
      .TotalCost = TotalCost
      .StageTypeID = StageTypeID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderStageID() As Int32
    Get
      Return pSalesOrderStageID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderStageID <> value Then IsDirty = True
      pSalesOrderStageID = value
    End Set
  End Property

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public Property TotalCost() As Decimal
    Get
      Return pTotalCost
    End Get
    Set(ByVal value As Decimal)
      If pTotalCost <> value Then IsDirty = True
      pTotalCost = value
    End Set
  End Property

  Public Property StageTypeID() As Int32
    Get
      Return pStageTypeID
    End Get
    Set(ByVal value As Int32)
      If pStageTypeID <> value Then IsDirty = True
      pStageTypeID = value
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


End Class



''Collection Definition - SalesOrderStage (to SalesOrderStage)'Generated from Table:SalesOrderStage

'Private pSalesOrderStages As colSalesOrderStages
'Public Property SalesOrderStages() As colSalesOrderStages
'  Get
'    Return pSalesOrderStages
'  End Get
'  Set(ByVal value As colSalesOrderStages)
'    pSalesOrderStages = value
'  End Set
'End Property

'  pSalesOrderStages = New colSalesOrderStages 'Add to New
'  pSalesOrderStages = Nothing 'Add to Finalize
'  .SalesOrderStages = SalesOrderStages.Clone 'Add to CloneTo
'  SalesOrderStages.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderStages.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderStages : Inherits colBase(Of dmSalesOrderStage)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderStageID As Integer) As Integer
    Dim mItem As dmSalesOrderStage
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderStageID = vSalesOrderStageID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderStage))
    MyBase.New(vList)
  End Sub

End Class



