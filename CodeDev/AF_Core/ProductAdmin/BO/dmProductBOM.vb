''Class Definition - ProductBOM (to ProductBOM)'Generated from Table:ProductBOM
Imports RTIS.CommonVB

Public Class dmProductBOM : Inherits dmBase
  Private pProductBOMID As Int32
  Private pParentID As Int32
  Private pProductID As Int32
  Private pQuantity As Decimal
  Private pStockCode As String
  Private pDescription As String
  Private pMaterialRequirementType As Byte
  Private pUnitPiece As Int32
  Private pNetThickness As Decimal
  Private pNetWidth As Decimal
  Private pNetLenght As Decimal
  Private pQualityType As Int32
  Private pMaterialTypeID As Int32
  Private pWoodSpecie As Int32
  Private pWoodFinish As Int32
  Private pUoM As Integer
  Private pAreaID As Int32
  Private pSupplierStockCode As String
  Private pComments As String
  Private pPiecesPerComponent As Decimal
  Private pTotalPieces As Decimal
  Private pDateChange As DateTime
  Private pDateOtherMaterial As DateTime
  Private pStockItemID As Int32
  Private pComponentDescription As String
  Private pTempInStock As Decimal
  Private pObjectType As Byte
  Private pTmpSelectedItem As Boolean

  Private pStockItemThickness As Integer
  Private pWoodItemType As Integer

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
    ProductBOMID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductBOM)
      .ProductBOMID = ProductBOMID
      .ParentID = ParentID
      .ProductID = ProductID
      .Quantity = Quantity
      .StockCode = StockCode
      .Description = Description
      .MaterialRequirementType = MaterialRequirementType
      .UnitPiece = UnitPiece
      .NetThickness = NetThickness
      .NetWidth = NetWidth
      .NetLenght = NetLenght
      .QualityType = QualityType
      .MaterialTypeID = MaterialTypeID
      .WoodSpecie = WoodSpecie
      .WoodFinish = WoodFinish
      .UoM = UoM
      .AreaID = AreaID
      .SupplierStockCode = SupplierStockCode
      .Comments = Comments
      .PiecesPerComponent = PiecesPerComponent
      .TotalPieces = TotalPieces
      .DateChange = DateChange
      .DateOtherMaterial = DateOtherMaterial
      .StockItemID = StockItemID
      .ComponentDescription = ComponentDescription
      .ObjectType = ObjectType
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductBOMID() As Int32
    Get
      Return pProductBOMID
    End Get
    Set(ByVal value As Int32)
      If pProductBOMID <> value Then IsDirty = True
      pProductBOMID = value
    End Set
  End Property

  Public Property ParentID() As Int32
    Get
      Return pParentID
    End Get
    Set(ByVal value As Int32)
      If pParentID <> value Then IsDirty = True
      pParentID = value
    End Set
  End Property

  Public Property ProductID() As Int32
    Get
      Return pProductID
    End Get
    Set(ByVal value As Int32)
      If pProductID <> value Then IsDirty = True
      pProductID = value
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
      Dim mRetVal As String = ""

      Select Case ObjectType
        Case eProductBOMObjectType.Wood
          mRetVal = pDescription
        Case eProductBOMObjectType.StockItems
          If pStockItemID > 0 Then
            mRetVal = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(pStockItemID).Description
          Else
            mRetVal = ""
          End If
      End Select

      Return mRetVal

    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property MaterialRequirementType() As Byte
    Get
      Return pMaterialRequirementType
    End Get
    Set(ByVal value As Byte)
      If pMaterialRequirementType <> value Then IsDirty = True
      pMaterialRequirementType = value
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

  Public ReadOnly Property WidthInch() As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = clsSMSharedFuncs.CMToQuaterInches(pNetWidth)

      Return mRetVal
    End Get
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

  Public ReadOnly Property LengthInch() As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = clsSMSharedFuncs.CMToHalfInchesLength(NetLenght)

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property GrossInchThickness() As Decimal
    Get
      Dim mRetVal As Decimal

      mRetVal = clsSMSharedFuncs.GrosWoodThickness(NetThickness)

      Return mRetVal
    End Get
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

  Public Property WoodSpecie() As Int32
    Get
      Return pWoodSpecie
    End Get
    Set(ByVal value As Int32)
      If pWoodSpecie <> value Then IsDirty = True
      pWoodSpecie = value
    End Set
  End Property

  Public ReadOnly Property WoodSpecieDesc As String
    Get
      Dim mRetVal As String = ""
      mRetVal = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).DisplayValueString(WoodSpecie)
      Return mRetVal.Trim
    End Get
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

  Public Property UoM() As Integer
    Get
      Return pUoM
    End Get
    Set(ByVal value As Integer)
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

  Public Property PiecesPerComponent() As Decimal
    Get
      Return pPiecesPerComponent
    End Get
    Set(ByVal value As Decimal)
      If pPiecesPerComponent <> value Then IsDirty = True
      pPiecesPerComponent = value
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

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property ComponentDescription() As String
    Get
      Return pComponentDescription
    End Get
    Set(ByVal value As String)
      If pComponentDescription <> value Then IsDirty = True
      pComponentDescription = value
    End Set
  End Property



  Public Property TempInStock As Decimal
    Get
      Return pTempInStock
    End Get
    Set(value As Decimal)
      pTempInStock = value
    End Set

  End Property

  Public Property ObjectType As Byte
    Get
      Return pObjectType
    End Get
    Set(value As Byte)
      pObjectType = value
    End Set

  End Property

  Public Property TmpSelectedItem As Boolean
    Get
      Return pTmpSelectedItem
    End Get
    Set(value As Boolean)
      pTmpSelectedItem = value
    End Set
  End Property

  Public Property StockItemThickness As Integer
    Get
      Return pStockItemThickness
    End Get
    Set(value As Integer)
      If pStockItemThickness <> value Then IsDirty = True
      pStockItemThickness = value
    End Set
  End Property


  Public Property WoodItemType As Integer
    Get
      Return pWoodItemType
    End Get
    Set(value As Integer)
      If pWoodItemType <> value Then IsDirty = True
      pWoodItemType = value
    End Set
  End Property

  Public ReadOnly Property InitialThicknessFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.GrosWoodThickness(pNetThickness))
    End Get
  End Property
  Public ReadOnly Property InitialWidthFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToQuaterInches(NetWidth))
    End Get
  End Property

  Public ReadOnly Property InitialLenghtFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToHalfInchesLength(NetLenght))
    End Get
  End Property
End Class



''Collection Definition - ProductBOM (to ProductBOM)'Generated from Table:ProductBOM

'Private pProductBOMs As colProductBOMs
'Public Property ProductBOMs() As colProductBOMs
'  Get
'    Return pProductBOMs
'  End Get
'  Set(ByVal value As colProductBOMs)
'    pProductBOMs = value
'  End Set
'End Property

'  pProductBOMs = New colProductBOMs 'Add to New
'  pProductBOMs = Nothing 'Add to Finalize
'  .ProductBOMs = ProductBOMs.Clone 'Add to CloneTo
'  ProductBOMs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductBOMs.IsDirty 'Add to IsAnyDirty

Public Class colProductBOMs : Inherits colBase(Of dmProductBOM)

  Public Overrides Function IndexFromKey(ByVal vProductBOMID As Integer) As Integer
    Dim mItem As dmProductBOM
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductBOMID = vProductBOMID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductBOM))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromStockItemID(ByVal vStockItemID As Integer) As Integer
    Dim mItem As dmProductBOM
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

  Public Function ItemFromStockItemID(ByVal vStockItemID As Integer) As dmProductBOM
    Dim mRetVal As dmProductBOM = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromStockItemID(vStockItemID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function

End Class





