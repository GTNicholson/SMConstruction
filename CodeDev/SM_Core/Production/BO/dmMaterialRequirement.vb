﻿''Class Definition - MaterialRequirement (to MaterialRequirement)'Generated from Table:MaterialRequirement
Imports RTIS.CommonVB

Public Class dmMaterialRequirement : Inherits dmBase
  Private pMaterialRequirementID As Int32
  Private pObjectType As Byte
  Private pObjectID As Int32
  Private pMaterialRequirementType As Int32
  Private pStockCode As String
  Private pDescription As String
  Private pQuantity As Decimal
  Private pUnitPiece As Int32
  Private pNetThickness As Decimal
  Private pNetWidth As Decimal
  Private pNetLenght As Decimal
  Private pQualityType As Int32
  Private pMaterialTypeID As Int32
  Private pWoodSpecie As Int32
  Private pWoodFinish As Int32
  Private pPiecesPerComponent As Decimal

  Private pUoM As String
  Private pAreaID As Int32
  Private pSupplierStockCode As String
  Private pComments As String

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
      .MaterialRequirementType = MaterialRequirementType
      .StockCode = StockCode
      .Description = Description
      .Quantity = Quantity
      .UnitPiece = UnitPiece
      .NetThickness = NetThickness
      .NetWidth = NetWidth
      .NetLenght = NetLenght
      .QualityType = QualityType
      .MaterialTypeID = MaterialTypeID
      .WoodFinish = WoodFinish
      .WoodSpecie = WoodSpecie

      .UoM = UoM
      .AreaID = AreaID
      .SupplierStockCode = SupplierStockCode
      .Comments = Comments

      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property UoM() As String
    Get
      Return pUoM
    End Get
    Set(ByVal value As String)
      If pUoM <> value Then IsDirty = True
      pUoM = value
    End Set
  End Property

  Public Property AreaID() As Int32
    Get
      Return pAreaID
    End Get
    Set(ByVal value As Int32)
      If pAreaID <> value Then IsDirty = True
      pAreaID = value
    End Set
  End Property

  Public Property SupplierStockCode() As String
    Get
      Return pSupplierStockCode
    End Get
    Set(ByVal value As String)
      If pSupplierStockCode <> value Then IsDirty = True
      pSupplierStockCode = value
    End Set
  End Property

  Public Property Comments() As String
    Get
      Return pComments
    End Get
    Set(ByVal value As String)
      If pComments <> value Then IsDirty = True
      pComments = value
    End Set
  End Property

  Public Property MaterialRequirementID() As Int32
    Get
      Return pMaterialRequirementID
    End Get
    Set(ByVal value As Int32)
      If pMaterialRequirementID <> value Then IsDirty = True
      pMaterialRequirementID = value
    End Set
  End Property

  Public Property WoodSpecie() As Int32
    Get
      Return pWoodSpecie
    End Get
    Set(ByVal value As Int32)
      If pWoodSpecie <> value Then IsDirty = True
      pWoodSpecie = value
    End Set
  End Property

  Public Property WoodFinish() As Int32
    Get
      Return pWoodFinish
    End Get
    Set(ByVal value As Int32)
      If pWoodFinish <> value Then IsDirty = True
      pWoodFinish = value
    End Set
  End Property

  Public Property UnitPiece() As Int32
    Get
      Return pUnitPiece
    End Get
    Set(ByVal value As Int32)
      If pUnitPiece <> value Then IsDirty = True
      pUnitPiece = value
    End Set
  End Property

  Public Property PiecesPerComponent() As Decimal
    Get
      Return pPiecesPerComponent
    End Get
    Set(ByVal value As Decimal)
      If pPiecesPerComponent <> value Then IsDirty = True
      pPiecesPerComponent = value
    End Set
  End Property

  Public Property NetThickness() As Decimal
    Get
      Return pNetThickness
    End Get
    Set(ByVal value As Decimal)
      If pNetThickness <> value Then IsDirty = True
      pNetThickness = value
    End Set
  End Property

  Public Property NetWidth() As Decimal
    Get
      Return pNetWidth
    End Get
    Set(ByVal value As Decimal)
      If pNetWidth <> value Then IsDirty = True
      pNetWidth = value
    End Set
  End Property

  Public Property NetLenght() As Decimal
    Get
      Return pNetLenght
    End Get
    Set(ByVal value As Decimal)
      If pNetLenght <> value Then IsDirty = True
      pNetLenght = value
    End Set
  End Property

  Public Property QualityType() As Int32
    Get
      Return pQualityType
    End Get
    Set(ByVal value As Int32)
      If pQualityType <> value Then IsDirty = True
      pQualityType = value
    End Set
  End Property

  Public Property MaterialTypeID() As Int32
    Get
      Return pMaterialTypeID
    End Get
    Set(ByVal value As Int32)
      If pMaterialTypeID <> value Then IsDirty = True
      pMaterialTypeID = value
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

  Public Property MaterialRequirementType() As Int32
    Get
      Return pMaterialRequirementType
    End Get
    Set(ByVal value As Int32)
      If pMaterialRequirementType <> value Then IsDirty = True
      pMaterialRequirementType = value
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


Public Class colMaterialRequirementsChanges : Inherits colBase(Of dmMaterialRequirement)

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

