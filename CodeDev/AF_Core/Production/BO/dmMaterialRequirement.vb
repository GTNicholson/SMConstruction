''Class Definition - MaterialRequirement (to MaterialRequirement)'Generated from Table:MaterialRequirement
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
  Private pTotalPieces As Decimal
  Private pDateOtherMaterial As DateTime
  Private pStockItemID As Int32
  Private pDateChange As DateTime
  Private pComponentDescription As String
  Private pUoM As Integer
  Private pAreaID As Int32
  Private pSupplierStockCode As String
  Private pComments As String
  Private pPickedQty As Decimal
  Private pTempAllocatedQty As Decimal
  Private pThicknessInch As Decimal
  Private pFromStockQty As Decimal
  Private pGeneratedQty As Decimal
  Private pReturnQty As Decimal
  Private pIsFromStockValidated As Boolean

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
      .TotalPieces = TotalPieces
      .DateChange = DateChange
      .DateOtherMaterial = DateOtherMaterial
      .StockItemID = StockItemID
      .ComponentDescription = ComponentDescription
      .SetPickedQty(PickedQty)
      .UoM = UoM
      .AreaID = AreaID
      .SupplierStockCode = SupplierStockCode
      .Comments = Comments
      .FromStockQty = FromStockQty
      .GeneratedQty = GeneratedQty
      .IsFromStockValidated = IsFromStockValidated
      .SetReturndQty(ReturnQty)

      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public ReadOnly Property PickedQty As Decimal
    Get
      PickedQty = pPickedQty
    End Get
  End Property

  Public Sub SetPickedQty(ByVal vNewValue As Decimal)
    pPickedQty = vNewValue
  End Sub
  Public Sub SetReturndQty(ByVal vNewValue As Decimal)
    pReturnQty = vNewValue
  End Sub

  Public Property UoM() As Integer
    Get
      Return pUoM
    End Get
    Set(ByVal value As Integer)
      If pUoM <> value Then IsDirty = True
      pUoM = value
    End Set
  End Property

  Public ReadOnly Property UoMDesc As String
    Get
      Dim mRetVal As String = ""
      Dim mStockItem As dmStockItem

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(pStockItemID)

      If mStockItem IsNot Nothing Then
        mRetVal = clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(mStockItem.UoM, eUoM))
      End If

      Return mRetVal
    End Get
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

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
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


  Public Property DateChange() As DateTime
    Get
      Return pDateChange
    End Get
    Set(ByVal value As DateTime)
      If pDateChange <> value Then IsDirty = True
      pDateChange = value
    End Set
  End Property

  Public Property DateOtherMaterial() As DateTime
    Get
      Return pDateOtherMaterial
    End Get
    Set(ByVal value As DateTime)
      If pDateOtherMaterial <> value Then IsDirty = True
      pDateOtherMaterial = value
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

  Public Property TotalPieces() As Decimal
    Get
      Return pTotalPieces
    End Get
    Set(ByVal value As Decimal)
      If pTotalPieces <> value Then IsDirty = True
      pTotalPieces = value
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
  Public ReadOnly Property QuantityFraction As String
    Get
      Dim mRetVal As String

      mRetVal = clsSMSharedFuncs.FractStrFromDec(Quantity)

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property WoodSpecieDesc As String
    Get
      If WoodSpecie > 0 Then
        Return AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).DisplayValueString(WoodSpecie).Trim
      End If

      Return ""
    End Get
  End Property

  Public Property FromStockQty() As Decimal
    Get
      Return pFromStockQty
    End Get
    Set(value As Decimal)
      If pFromStockQty <> value Then IsDirty = True
      pFromStockQty = value
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

  Public Property ComponentDescription As String
    Get
      Return pComponentDescription
    End Get
    Set(value As String)
      If pComponentDescription <> value Then IsDirty = True
      pComponentDescription = value
    End Set
  End Property



  Public ReadOnly Property WidthInch As String
    Get
      Dim mRetVal As Decimal

      mRetVal = clsSMSharedFuncs.CMToInches_AFNew(NetWidth)

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property LengthInch As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = clsSMSharedFuncs.CMToInches_AFNew(NetLenght)

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property ThicknessCM As Decimal
    Get
      Dim mRetVal As String
      mRetVal = Math.Round(NetThickness * 2.54, 0, MidpointRounding.AwayFromZero)
      Return mRetVal
    End Get
  End Property

  Public Property TempAllocatedQty As Decimal
    Get
      Return pTempAllocatedQty
    End Get
    Set(value As Decimal)
      pTempAllocatedQty = value
    End Set
  End Property

  Public Property ThicknessInch As Decimal
    Get
      Return pThicknessInch
    End Get
    Set(value As Decimal)
      pThicknessInch = value
    End Set
  End Property

  Public ReadOnly Property BoardFeetPerLine As Decimal
    Get
      Dim mQty As Decimal
      Dim mValue As Decimal
      mQty = UnitPiece
      mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, NetLenght, NetWidth, NetThickness)


      Return mValue
    End Get
  End Property
  Public ReadOnly Property InitialWidth As Decimal
    Get
      Return clsSMSharedFuncs.CMToQuaterInches(NetWidth)
    End Get
  End Property


  Public ReadOnly Property InitialWidthFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToQuaterInches(NetWidth))
    End Get
  End Property
  Public ReadOnly Property InitialLenght As Decimal
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToHalfInchesLength(NetLenght))

    End Get
  End Property


  Public ReadOnly Property InitialLenghtFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToHalfInchesLength(NetLenght))
    End Get
  End Property

  Public ReadOnly Property InitialLenghtFractionFeet As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.WoodLengthFeet(NetLenght))
    End Get
  End Property


  Public ReadOnly Property InitialThicknessFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.GrosWoodThickness(NetThickness))
    End Get
  End Property


  Public Property GeneratedQty As Decimal
    Get
      Return pGeneratedQty
    End Get
    Set(value As Decimal)
      If pGeneratedQty <> value Then IsDirty = True
      pGeneratedQty = value
    End Set
  End Property

  Public Property ReturnQty As Decimal
    Get
      Return pReturnQty
    End Get
    Set(value As Decimal)
      If pReturnQty <> value Then IsDirty = True
      pReturnQty = value
    End Set
  End Property

  Public Property IsFromStockValidated As Boolean
    Get
      Return pIsFromStockValidated
    End Get
    Set(value As Boolean)
      If pIsFromStockValidated <> value Then IsDirty = True
      pIsFromStockValidated = value
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

  Public Function ItemFromStockItemID(ByVal vStockItemID As Integer) As dmMaterialRequirement
    Dim mRetVal As dmMaterialRequirement = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromStockItemID(vStockItemID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromStockItemID(ByVal vStockItemID As Integer) As Integer
    Dim mItem As dmMaterialRequirement
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemID = vStockItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function GetTotalBoardFeets() As Decimal
    Dim mRetVal As Decimal

    For Each mItem In MyBase.Items
      mRetVal += clsSMSharedFuncs.BoardFeetFromCMAndQty(mItem.UnitPiece, mItem.NetLenght, mItem.NetWidth, mItem.NetThickness)
    Next
    Return mRetVal
  End Function

  Public Sub SetQuantitysToZero()
    For Each mItem As dmMaterialRequirement In Me.Items
      mItem.Quantity = 0
      mItem.UnitPiece = 0
    Next
  End Sub

  Public Function GetItemByIDAndStockItemID(ByVal vMaterialRequirementID As Integer, ByVal vStockItemID As Integer) As dmMaterialRequirement
    Dim mRetVal As dmMaterialRequirement = Nothing

    For Each mItem As dmMaterialRequirement In Me.Items
      If mItem.MaterialRequirementID = vMaterialRequirementID And mItem.StockItemID = vStockItemID Then
        mRetVal = mItem
      End If
    Next
    Return mRetVal
  End Function
End Class


