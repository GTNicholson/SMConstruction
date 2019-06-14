﻿''Class Definition - MaterialRequirement (to MaterialRequirement)'Generated from Table:MaterialRequirement
Imports RTIS.CommonVB

Public Class dmMaterialRequirement : Inherits dmBase
  Private pMaterialRequirementID As Int32
  Private pObjectType As Byte
  Private pObjectID As Int32
  Private pStockCode As String
  Private pDescription As String
  Private pQuantity As Decimal

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
    MaterialRequirementID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmMaterialRequirement)
      .MaterialRequirementID = MaterialRequirementID
      .ObjectType = ObjectType
      .ObjectID = ObjectID
      .StockCode = StockCode
      .Description = Description
      .Quantity = Quantity
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property MaterialRequirementID() As Int32
    Get
      Return pMaterialRequirementID
    End Get
    Set(ByVal value As Int32)
      If pMaterialRequirementID <> value Then IsDirty = True
      pMaterialRequirementID = value
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

  Public Property StockCode() As String
    Get
      Return pStockCode
    End Get
    Set(ByVal value As String)
      If pStockCode <> value Then IsDirty = True
      pStockCode = value
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

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property


End Class



''Collection Definition - MaterialRequirement (to MaterialRequirement)'Generated from Table:MaterialRequirement

'Private pMaterialRequirements As colMaterialRequirements
'Public Property MaterialRequirements() As colMaterialRequirements
'  Get
'    Return pMaterialRequirements
'  End Get
'  Set(ByVal value As colMaterialRequirements)
'    pMaterialRequirements = value
'  End Set
'End Property

'  pMaterialRequirements = New colMaterialRequirements 'Add to New
'  pMaterialRequirements = Nothing 'Add to Finalize
'  .MaterialRequirements = MaterialRequirements.Clone 'Add to CloneTo
'  MaterialRequirements.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = MaterialRequirements.IsDirty 'Add to IsAnyDirty

Public Class colMaterialRequirements : Inherits colBase(Of dmMaterialRequirement)

  Public Overrides Function IndexFromKey(ByVal vMaterialRequirementID As Integer) As Integer
    Dim mItem As dmMaterialRequirement
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.MaterialRequirementID = vMaterialRequirementID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmMaterialRequirement))
    MyBase.New(vList)
  End Sub

End Class
