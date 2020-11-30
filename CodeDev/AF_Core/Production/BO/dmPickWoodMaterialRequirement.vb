''Class Definition - PickWoodMaterialRequirement (to PickWoodMaterialRequirement)'Generated from Table:PickWoodMaterialRequirement
Imports RTIS.CommonVB

Public Class dmPickWoodMaterialRequirement : Inherits dmBase
  Private pPickWoodMaterialRequirementID As Int32
  Private pWoodPalletID As Int32
  Private pPickNumber As String
  Private pPickedDate As DateTime
  Private pComment As String
  Private pIsProductionReturn As Boolean
  Private pDateCreated As DateTime
  Private pStatus As Byte
  Private pReturnReasonID As Byte
  Private pActionRequiredID As Byte
  Private pFileExport As String
  Private pFullyDespatched As Boolean
  Private pWorkOrderID As Int32
  Private pWoodPickValue As Decimal
  Private pPickWoodMaterialItems As colPickWoodMaterialItems

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pPickWoodMaterialItems = New colPickWoodMaterialItems
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pPickWoodMaterialItems = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pPickWoodMaterialItems.IsDirty


      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    PickWoodMaterialRequirementID = 0

  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPickWoodMaterialRequirement)
      .PickWoodMaterialRequirementID = PickWoodMaterialRequirementID
      .WoodPalletID = WoodPalletID
      .PickNumber = PickNumber
      .PickedDate = PickedDate
      .Comment = Comment
      .IsProductionReturn = IsProductionReturn
      .DateCreated = DateCreated
      .Status = Status
      .ReturnReasonID = ReturnReasonID
      .ActionRequiredID = ActionRequiredID
      .FileExport = FileExport
      .FullyDespatched = FullyDespatched
      .WorkOrderID = WorkOrderID
      .WoodPickValue = WoodPickValue
      .PickWoodMaterialItems = PickWoodMaterialItems
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PickWoodMaterialRequirementID() As Int32
    Get
      Return pPickWoodMaterialRequirementID
    End Get
    Set(ByVal value As Int32)
      If pPickWoodMaterialRequirementID <> value Then IsDirty = True
      pPickWoodMaterialRequirementID = value
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

  Public Property PickNumber() As String
    Get
      Return pPickNumber
    End Get
    Set(ByVal value As String)
      If pPickNumber <> value Then IsDirty = True
      pPickNumber = value
    End Set
  End Property

  Public Property PickedDate() As DateTime
    Get
      Return pPickedDate
    End Get
    Set(ByVal value As DateTime)
      If pPickedDate <> value Then IsDirty = True
      pPickedDate = value
    End Set
  End Property

  Public Property Comment() As String
    Get
      Return pComment
    End Get
    Set(ByVal value As String)
      If pComment <> value Then IsDirty = True
      pComment = value
    End Set
  End Property

  Public Property IsProductionReturn() As Boolean
    Get
      Return pIsProductionReturn
    End Get
    Set(ByVal value As Boolean)
      If pIsProductionReturn <> value Then IsDirty = True
      pIsProductionReturn = value
    End Set
  End Property

  Public Property DateCreated() As DateTime
    Get
      Return pDateCreated
    End Get
    Set(ByVal value As DateTime)
      If pDateCreated <> value Then IsDirty = True
      pDateCreated = value
    End Set
  End Property

  Public Property Status() As Byte
    Get
      Return pStatus
    End Get
    Set(ByVal value As Byte)
      If pStatus <> value Then IsDirty = True
      pStatus = value
    End Set
  End Property

  Public Property ReturnReasonID() As Byte
    Get
      Return pReturnReasonID
    End Get
    Set(ByVal value As Byte)
      If pReturnReasonID <> value Then IsDirty = True
      pReturnReasonID = value
    End Set
  End Property

  Public Property ActionRequiredID() As Byte
    Get
      Return pActionRequiredID
    End Get
    Set(ByVal value As Byte)
      If pActionRequiredID <> value Then IsDirty = True
      pActionRequiredID = value
    End Set
  End Property

  Public Property FileExport() As String
    Get
      Return pFileExport
    End Get
    Set(ByVal value As String)
      If pFileExport <> value Then IsDirty = True
      pFileExport = value
    End Set
  End Property

  Public Property FullyDespatched() As Boolean
    Get
      Return pFullyDespatched
    End Get
    Set(ByVal value As Boolean)
      If pFullyDespatched <> value Then IsDirty = True
      pFullyDespatched = value
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

  Public Property WoodPickValue() As Decimal
    Get
      Return pWoodPickValue
    End Get
    Set(ByVal value As Decimal)
      If pWoodPickValue <> value Then IsDirty = True
      pWoodPickValue = value
    End Set
  End Property

  Public Property PickWoodMaterialItems As colPickWoodMaterialItems
    Get
      Return pPickWoodMaterialItems
    End Get
    Set(value As colPickWoodMaterialItems)
      pPickWoodMaterialItems = value
    End Set
  End Property
End Class



''Collection Definition - PickWoodMaterialRequirement (to PickWoodMaterialRequirement)'Generated from Table:PickWoodMaterialRequirement

'Private pPickWoodMaterialRequirements As colPickWoodMaterialRequirements
'Public Property PickWoodMaterialRequirements() As colPickWoodMaterialRequirements
'  Get
'    Return pPickWoodMaterialRequirements
'  End Get
'  Set(ByVal value As colPickWoodMaterialRequirements)
'    pPickWoodMaterialRequirements = value
'  End Set
'End Property

'  pPickWoodMaterialRequirements = New colPickWoodMaterialRequirements 'Add to New
'  pPickWoodMaterialRequirements = Nothing 'Add to Finalize
'  .PickWoodMaterialRequirements = PickWoodMaterialRequirements.Clone 'Add to CloneTo
'  PickWoodMaterialRequirements.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PickWoodMaterialRequirements.IsDirty 'Add to IsAnyDirty

Public Class colPickWoodMaterialRequirements : Inherits colBase(Of dmPickWoodMaterialRequirement)

  Public Overrides Function IndexFromKey(ByVal vPickWoodMaterialRequirementID As Integer) As Integer
    Dim mItem As dmPickWoodMaterialRequirement
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PickWoodMaterialRequirementID = vPickWoodMaterialRequirementID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPickWoodMaterialRequirement))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - PickWoodMaterialRequirement (to PickWoodMaterialRequirement)'Generated from Table:PickWoodMaterialRequirement


