﻿Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccProductDetaiL_New
  Private pPrimaryKeyID As Integer

  Private pProductStructure As dmProductStructure
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pProductBaseInfo As clsProductBaseInfo

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pProductBaseInfo = New clsProductBaseInfo()
    pProductBaseInfo.Product = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
  End Sub

  Public Property ProductBaseInfo As clsProductBaseInfo
    Get
      Return pProductBaseInfo
    End Get
    Set(value As clsProductBaseInfo)
      pProductBaseInfo = value
    End Set

  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property
  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public Property ProductStructure As dmProductStructure
    Get
      Return pProductStructure
    End Get
    Set(value As dmProductStructure)
      pProductStructure = value
    End Set
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoProductAdmin

    pProductStructure = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoProductAdmin(pDBConn)



      mdso.LoadProductStructureDown(pProductStructure, pPrimaryKeyID)

    Else
      pProductBaseInfo.Product = pProductStructure
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoProductAdmin

    mdso = New dsoProductAdmin(pDBConn)

    mdso.SaveProductStructureDown(pProductStructure)


    If pPrimaryKeyID = 0 Then
      pPrimaryKeyID = pProductStructure.ID
    End If

  End Sub
  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function



  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pProductStructure.IsAnyDirty
    Return mIsDirty
  End Function
  Public Sub CreateCopyProductSelected(ByVal vSIBOMs As colProductBOMs, ByVal vWoodBOMs As colProductBOMs)
    Dim mNewProduct As dmProductStructure

    mNewProduct = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)

    mNewProduct.Description = "Copia de- " & pProductStructure.Description
    mNewProduct.Code = ""
    mNewProduct.ItemType = pProductStructure.ItemType
    mNewProduct.SubItemType = pProductStructure.SubItemType

    If vWoodBOMs IsNot Nothing Then
      For Each mPSIBOM In vSIBOMs

        If mPSIBOM.TmpSelectedItem Then
          Dim mSIBOM As New dmProductBOM

          mSIBOM.AreaID = mPSIBOM.AreaID
          mSIBOM.Comments = mPSIBOM.Comments
          mSIBOM.ComponentDescription = mPSIBOM.ComponentDescription
          mSIBOM.DateChange = mPSIBOM.DateChange
          mSIBOM.DateOtherMaterial = mPSIBOM.DateOtherMaterial
          mSIBOM.Description = mPSIBOM.Description
          mSIBOM.MaterialRequirementType = mPSIBOM.MaterialRequirementType
          mSIBOM.MaterialTypeID = mPSIBOM.MaterialTypeID
          mSIBOM.NetLenght = mPSIBOM.NetLenght
          mSIBOM.NetThickness = mPSIBOM.NetThickness
          mSIBOM.NetWidth = mPSIBOM.NetWidth
          mSIBOM.ObjectType = mPSIBOM.ObjectType
          mSIBOM.ParentID = mPSIBOM.ParentID
          mSIBOM.PiecesPerComponent = mPSIBOM.PiecesPerComponent
          mSIBOM.QualityType = mPSIBOM.QualityType
          mSIBOM.Quantity = mPSIBOM.Quantity
          mSIBOM.StockCode = mPSIBOM.StockCode
          mSIBOM.StockItemID = mPSIBOM.StockItemID
          mSIBOM.SupplierStockCode = mPSIBOM.SupplierStockCode
          mSIBOM.TotalPieces = mPSIBOM.TotalPieces
          mSIBOM.UnitPiece = mPSIBOM.UnitPiece
          mSIBOM.UoM = mPSIBOM.UoM
          mSIBOM.WoodFinish = mPSIBOM.WoodFinish
          mSIBOM.WoodSpecie = mPSIBOM.WoodSpecie
          mNewProduct.ProductStockItemBOMs.Add(mSIBOM)
        End If
      Next
    End If


    If vWoodBOMs IsNot Nothing Then
      For Each mPSIBOM In vWoodBOMs
        If mPSIBOM.TmpSelectedItem Then
          Dim mSIBOM As New dmProductBOM

          mSIBOM.AreaID = mPSIBOM.AreaID
          mSIBOM.Comments = mPSIBOM.Comments
          mSIBOM.ComponentDescription = mPSIBOM.ComponentDescription
          mSIBOM.DateChange = mPSIBOM.DateChange
          mSIBOM.DateOtherMaterial = mPSIBOM.DateOtherMaterial
          mSIBOM.Description = mPSIBOM.Description
          mSIBOM.MaterialRequirementType = mPSIBOM.MaterialRequirementType
          mSIBOM.MaterialTypeID = mPSIBOM.MaterialTypeID
          mSIBOM.NetLenght = mPSIBOM.NetLenght
          mSIBOM.NetThickness = mPSIBOM.NetThickness
          mSIBOM.NetWidth = mPSIBOM.NetWidth
          mSIBOM.ObjectType = mPSIBOM.ObjectType
          mSIBOM.ParentID = mPSIBOM.ParentID
          mSIBOM.PiecesPerComponent = mPSIBOM.PiecesPerComponent
          mSIBOM.QualityType = mPSIBOM.QualityType
          mSIBOM.Quantity = mPSIBOM.Quantity
          mSIBOM.StockCode = mPSIBOM.StockCode
          mSIBOM.StockItemID = mPSIBOM.StockItemID
          mSIBOM.SupplierStockCode = mPSIBOM.SupplierStockCode
          mSIBOM.TotalPieces = mPSIBOM.TotalPieces
          mSIBOM.UnitPiece = mPSIBOM.UnitPiece
          mSIBOM.UoM = mPSIBOM.UoM
          mSIBOM.WoodFinish = mPSIBOM.WoodFinish
          mSIBOM.WoodSpecie = mPSIBOM.WoodSpecie

          mNewProduct.ProductWoodBOMs.Add(mSIBOM)
        End If
      Next
    End If

    mNewProduct.ProductStructureTypeID = pProductStructure.ProductStructureTypeID




    pProductBaseInfo.Product = mNewProduct
    pProductStructure = mNewProduct


    SaveObjects()


  End Sub
  Public Sub CreateCopyProduct()
    Dim mNewProduct As dmProductStructure

    mNewProduct = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)

    mNewProduct.Description = "Copia de- " & pProductStructure.Description
    mNewProduct.Code = ""
    mNewProduct.ItemType = pProductStructure.ItemType
    mNewProduct.SubItemType = pProductStructure.SubItemType

    For Each mPSIBOM In pProductStructure.ProductStockItemBOMs
      Dim mSIBOM As New dmProductBOM

      mSIBOM.AreaID = mPSIBOM.AreaID
      mSIBOM.Comments = mPSIBOM.Comments
      mSIBOM.ComponentDescription = mPSIBOM.ComponentDescription
      mSIBOM.DateChange = mPSIBOM.DateChange
      mSIBOM.DateOtherMaterial = mPSIBOM.DateOtherMaterial
      mSIBOM.Description = mPSIBOM.Description
      mSIBOM.MaterialRequirementType = mPSIBOM.MaterialRequirementType
      mSIBOM.MaterialTypeID = mPSIBOM.MaterialTypeID
      mSIBOM.NetLenght = mPSIBOM.NetLenght
      mSIBOM.NetThickness = mPSIBOM.NetThickness
      mSIBOM.NetWidth = mPSIBOM.NetWidth
      mSIBOM.ObjectType = mPSIBOM.ObjectType
      mSIBOM.ParentID = mPSIBOM.ParentID
      mSIBOM.PiecesPerComponent = mPSIBOM.PiecesPerComponent
      mSIBOM.QualityType = mPSIBOM.QualityType
      mSIBOM.Quantity = mPSIBOM.Quantity
      mSIBOM.StockCode = mPSIBOM.StockCode
      mSIBOM.StockItemID = mPSIBOM.StockItemID
      mSIBOM.SupplierStockCode = mPSIBOM.SupplierStockCode
      mSIBOM.TotalPieces = mPSIBOM.TotalPieces
      mSIBOM.UnitPiece = mPSIBOM.UnitPiece
      mSIBOM.UoM = mPSIBOM.UoM
      mSIBOM.WoodFinish = mPSIBOM.WoodFinish
      mSIBOM.WoodSpecie = mPSIBOM.WoodSpecie
      mNewProduct.ProductStockItemBOMs.Add(mSIBOM)

    Next


    For Each mPSIBOM In pProductStructure.ProductWoodBOMs
      Dim mSIBOM As New dmProductBOM

      mSIBOM.AreaID = mPSIBOM.AreaID
      mSIBOM.Comments = mPSIBOM.Comments
      mSIBOM.ComponentDescription = mPSIBOM.ComponentDescription
      mSIBOM.DateChange = mPSIBOM.DateChange
      mSIBOM.DateOtherMaterial = mPSIBOM.DateOtherMaterial
      mSIBOM.Description = mPSIBOM.Description
      mSIBOM.MaterialRequirementType = mPSIBOM.MaterialRequirementType
      mSIBOM.MaterialTypeID = mPSIBOM.MaterialTypeID
      mSIBOM.NetLenght = mPSIBOM.NetLenght
      mSIBOM.NetThickness = mPSIBOM.NetThickness
      mSIBOM.NetWidth = mPSIBOM.NetWidth
      mSIBOM.ObjectType = mPSIBOM.ObjectType
      mSIBOM.ParentID = mPSIBOM.ParentID
      mSIBOM.PiecesPerComponent = mPSIBOM.PiecesPerComponent
      mSIBOM.QualityType = mPSIBOM.QualityType
      mSIBOM.Quantity = mPSIBOM.Quantity
      mSIBOM.StockCode = mPSIBOM.StockCode
      mSIBOM.StockItemID = mPSIBOM.StockItemID
      mSIBOM.SupplierStockCode = mPSIBOM.SupplierStockCode
      mSIBOM.TotalPieces = mPSIBOM.TotalPieces
      mSIBOM.UnitPiece = mPSIBOM.UnitPiece
      mSIBOM.UoM = mPSIBOM.UoM
      mSIBOM.WoodFinish = mPSIBOM.WoodFinish
      mSIBOM.WoodSpecie = mPSIBOM.WoodSpecie

      mNewProduct.ProductWoodBOMs.Add(mSIBOM)

    Next

    mNewProduct.ProductStructureTypeID = pProductStructure.ProductStructureTypeID




    pProductBaseInfo.Product = mNewProduct
    pProductStructure = mNewProduct


    SaveObjects()


  End Sub

End Class
