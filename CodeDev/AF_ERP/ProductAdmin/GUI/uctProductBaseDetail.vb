﻿Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class uctProductBaseDetail

  Private pRTISGlobal As AppRTISGlobal
  Private pFormController As uccProductBaseDetail

  Private Enum eMaterialRequirementsButtons
    Copy = 1
    Paste = 2
    ExportList = 3
    AddInv = 4
    CopyChange = 5
    PasteChange = 6
  End Enum

  Public Sub ConfigureBrowseFilesControl(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mFileDirectory As String

    ''//Setup file browse
    If pFormController.CurrentProductInfo.Product IsNot Nothing Then
      mFileDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.cProductFiles, clsGeneralA.GetFileSafeName(pFormController.CurrentProductInfo.Product.ID.ToString("00000")))

      UctFileControl1.UserController = New uccFileControl(Me)
      UctFileControl1.UserController.Directory = mFileDirectory
      UctFileControl1.UserController.FileTrackers = pFormController.CurrentProductInfo.Product.POFiles
      UctFileControl1.UserController.ConfigSystemWatcher()

    End If
  End Sub
  Public Sub ConfigureControl(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)

    pFormController = New uccProductBaseDetail
    pFormController.DBConn = rDBConn
    pFormController.RTISGlobal = rRTISGlobal



  End Sub

  Public Property FormController As uccProductBaseDetail
    Get
      Return pFormController
    End Get
    Set(value As uccProductBaseDetail)
      pFormController = value
    End Set
  End Property

  Public Sub LoadCombos()
    Dim mVIs As colValueItems
    Dim mSuppliers As colSuppliers

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionType)

    clsDEControlLoading.FillDEComboVI(cboProductItemType, mVIs)
    mSuppliers = AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Supplier)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Material)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdWoodMaterialRequirements, gcMaterialTypeID, mVIs)



    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Quality)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdWoodMaterialRequirements, gcQuality, mVIs)

    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemsMaterialRequirement, gcStockItemUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))


  End Sub

  Public Sub RefreshControls()
    Dim mProductStructure As dmProductStructure

    If pFormController.CurrentProductInfo IsNot Nothing Then
      If pFormController.CurrentProductInfo.Product IsNot Nothing Then
        With pFormController.CurrentProductInfo.Product
          txtDescription.Text = .Description
          txtStockCode.Text = .Code
          lblStockItemID.Text = "ID: " & .ID
          cheStatus.EditValue = .Status
          clsDEControlLoading.SetDECombo(cboProductItemType, .ItemType)

          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)
          If mProductStructure IsNot Nothing Then
            grdStockItemsMaterialRequirement.DataSource = mProductStructure.ProductStockItemBOMs
            grdWoodMaterialRequirements.DataSource = mProductStructure.ProductWoodBOMs
          End If
        End With
        UctFileControl1.UserController.FileTrackers = mProductStructure.POFiles
        UctFileControl1.LoadControls()
        UctFileControl1.RefreshControls()
      End If


    End If
  End Sub

  Public Sub UpdateObject()

    If pFormController.CurrentProductInfo IsNot Nothing Then
      If pFormController.CurrentProductInfo.Product IsNot Nothing Then
        With pFormController.CurrentProductInfo.Product
          .Description = txtDescription.Text
          .Code = txtStockCode.Text
          .ItemType = clsDEControlLoading.GetDEComboValue(cboProductItemType)
          .Status = cheStatus.EditValue

          gvWoodMaterialRequirements.CloseEditor()
          gvStockItemMaterialRequirements.CloseEditor()
          UctFileControl1.UpdateObject()
        End With
      End If

    End If



  End Sub




  Public Function GetCurrentEmodeProductType() As eProductType
    Return CType(clsDEControlLoading.GetDEComboValue(cboProductItemType), eProductType)
  End Function



  Private Sub gvStockItemMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs)
    Dim mMatReq As dmMaterialRequirement
    Dim mSI As dmStockItem

    mMatReq = CType(e.Row, dmMaterialRequirement)

    If mMatReq.StockItemID = 0 Then


      Select Case e.Column.Name
        Case gcMatReqOtherDescription.Name
          If e.IsGetData Then
            e.Value = mMatReq.Description
          ElseIf e.IsSetData Then
            mMatReq.Description = e.Value
          End If
        Case gcStockCode.Name
          If e.IsGetData Then
            e.Value = mMatReq.StockCode
          ElseIf e.IsSetData Then
            mMatReq.StockCode = e.Value
          End If

        Case gcPartNo.Name
          If e.IsGetData Then
            e.Value = mMatReq.SupplierStockCode
          ElseIf e.IsSetData Then
            mMatReq.SupplierStockCode = e.Value
          End If
      End Select
    Else
      mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)
      If mSI IsNot Nothing Then

        Select Case e.Column.Name
          Case gcMatReqOtherDescription.Name
            If e.IsGetData Then
              If String.IsNullOrEmpty(mSI.ShortDescription) Then
                e.Value = mSI.Description
              Else
                e.Value = mSI.ShortDescription
              End If


            End If
          Case gcStockCode.Name
            If e.IsGetData Then
              e.Value = mSI.StockCode

            End If

          Case gcPartNo.Name
            If e.IsGetData Then
              e.Value = mSI.PartNo

            End If
        End Select
      End If
    End If
  End Sub

  Private Sub grdStockItemsMaterialRequirement_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdStockItemsMaterialRequirement.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvStockItemMaterialRequirements.MoveNext()
    End If
  End Sub
  Private Sub grdWoodMaterialRequirements_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdWoodMaterialRequirements.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvWoodMaterialRequirements.MoveNext()
    End If
  End Sub

  Private Sub gvMaterialRequirements_InitNewRow(sender As Object, e As InitNewRowEventArgs)
    Dim mMatReq As dmMaterialRequirement
    mMatReq = gvWoodMaterialRequirements.GetRow(e.RowHandle)
    mMatReq.PiecesPerComponent = 1
  End Sub
  Public Sub FocusDescription()
    txtDescription.Focus()
  End Sub





  Public Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)

    txtDescription.ReadOnly = vReadOnly
    cboProductItemType.ReadOnly = vReadOnly
    txtStockCode.ReadOnly = vReadOnly
    btnGenerateCode.Enabled = Not vReadOnly
    cheStatus.ReadOnly = vReadOnly
    gvWoodMaterialRequirements.OptionsBehavior.ReadOnly = vReadOnly
    gvStockItemMaterialRequirements.OptionsBehavior.ReadOnly = vReadOnly


    grpStockItemMaterialRequirement.CustomHeaderButtons.Item(0).Properties.Visible = Not vReadOnly
    grpWoodMaterialRequirements.CustomHeaderButtons.Item(0).Properties.Visible = Not vReadOnly

    UctFileControl1.Enabled = Not vReadOnly



  End Sub


  Public Function CreateDrawingPDF(ByVal vFileName As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try
      If IO.File.Exists(vFileName) Then
        mFileName = "DRAWING_" & pFormController.CurrentProductInfo.Product.ID

        mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.ProductFileFolderSys, clsGeneralA.GetFileSafeName(pFormController.CurrentProductInfo.Product.ID.ToString("00000")))

        mFileName &= IO.Path.GetExtension(vFileName)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)

        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vFileName, mFilePath, True)
        pFormController.CurrentProductInfo.Product.DrawingFileName = mFilePath

        If pFormController.CurrentProductInfo.Product.DrawingFileName <> "" Then
          mRetVal = True

        Else

          pFormController.CurrentProductInfo.Product.DrawingFileName = ""
          mRetVal = False
        End If
      End If

    Catch ex As Exception


      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal
  End Function

  Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click
    UpdateObject()

    pFormController.CheckCreateStockCodeSave()
    RefreshControls()

  End Sub


  Public Function GetProductInfos() As colProductBaseInfos
    Dim mRetVal As New colProductBaseInfos
    Dim mdso As New dsoProductAdmin(pFormController.DBConn)
    mdso.LoadProductInfosStructureOnly(mRetVal)
    Return mRetVal
  End Function

  Public Sub SetCurrentProductBaseInfo(ByRef rCurrentProductBaseInfo As clsProductBaseInfo)
    pFormController.CurrentProductInfo = rCurrentProductBaseInfo

    If UctFileControl1.UserController IsNot Nothing Then
      If rCurrentProductBaseInfo.Product IsNot Nothing Then
        UctFileControl1.UserController.FileTrackers = rCurrentProductBaseInfo.Product.POFiles
        UctFileControl1.RefreshControls()

      End If

    End If
  End Sub

  Private Sub grpWoodMaterialRequirements_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWoodMaterialRequirements.CustomButtonClick
    Dim mProductStructure As dmProductStructure
    Dim mStockItem As dmStockItem
    Dim mStockItems As New colStockItems
    Dim mPicker As clsPickerStockItem

    Try

      Select Case e.Button.Properties.Tag

        Case eMaterialRequirementsButtons.ExportList
          Dim mFileName As String = "Exportar MRP " + pFormController.CurrentProductInfo.Description & ".xlsx"
          If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
            gvWoodMaterialRequirements.ExportToXlsx(mFileName)
          End If

        Case eMaterialRequirementsButtons.AddInv

          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict

            If mItem.Value.StockItemType = eStockItemTypeTimberWood.Aserrado Or mItem.Value.StockItemType = eStockItemTypeTimberWood.MAS Or
              mItem.Value.StockItemType = eStockItemTypeTimberWood.Primera Or mItem.Value.StockItemType = eStockItemTypeTimberWood.Segunda Or
              mItem.Value.StockItemType = eStockItemTypeTimberWood.Tercera Or mItem.Value.StockItemType = eStockItemTypeTimberWood.ClasificadoZ Then
              mStockItems.Add(mItem.Value)

            End If
          Next

          mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, pFormController.RTISGlobal)

          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

          If mProductStructure IsNot Nothing Then
            For Each mProductStockBOM In mProductStructure.ProductWoodBOMs ''.POItemsMinusAllocatedItem
              If mProductStockBOM.StockItemID > 0 Then
                mStockItem = mStockItems.ItemFromKey(mProductStockBOM.StockItemID)

                If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                  mPicker.SelectedObjects.Add(mStockItem)
                End If
              End If
            Next
            frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, pFormController.RTISGlobal, True, -1)

            pFormController.CreateWoodProductBOM(mPicker.SelectedObjects)




            RefreshControls()
          End If




      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try


  End Sub


  Private Sub grpStockItemMaterialRequirement_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpStockItemMaterialRequirement.CustomButtonClick

    Try


      Select Case e.Button.Properties.Tag

        Case eMaterialRequirementsButtons.AddInv
          Dim mSIs As New colStockItems
          Dim mPicker As clsPickerStockItem
          Dim mSelectedSI As dmStockItem

          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
            mSIs.Add(mItem.Value)
          Next

          mPicker = New clsPickerStockItem(mSIs, pFormController.DBConn, pFormController.RTISGlobal)

          Dim mProductStructure As dmProductStructure
          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

          For Each mProductStockItemBOM As dmProductBOM In mProductStructure.ProductStockItemBOMs
            mSelectedSI = mSIs.ItemFromKey(mProductStockItemBOM.StockItemID)
            If mSelectedSI IsNot Nothing Then
              If mPicker.SelectedObjects.Contains(mSelectedSI) = False Then
                mPicker.SelectedObjects.Add(mSelectedSI)
              End If
            End If
          Next

          frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, pFormController.RTISGlobal, False, -1)

          pFormController.CreateStockItemProductBoM(mPicker.SelectedObjects)

          RefreshControls()

        Case eMaterialRequirementsButtons.ExportList
          Dim mFileName As String = "Exportar LMR " + pFormController.CurrentProductInfo.Product.Description & ".xlsx"
          If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
            gvStockItemMaterialRequirements.ExportToXlsx(mFileName)
          End If
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try

  End Sub

  Private Sub gvWoodMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWoodMaterialRequirements.CustomUnboundColumnData
    Dim mProductBOM As dmProductBOM
    Dim mStockItem As dmStockItem

    Try

      mProductBOM = TryCast(e.Row, dmProductBOM)


      If mProductBOM IsNot Nothing Then
        Select Case e.Column.Name
          Case gcThicknessInch.Name
            If e.IsGetData Then
              mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mProductBOM.StockItemID)

              If mStockItem IsNot Nothing Then
                e.Value = mStockItem.Thickness

              End If

            End If

          Case gcQtyBoardFeet.Name
            Dim mValue As Decimal
            Dim mQty As Integer


            If e.IsGetData Then
              Try


                mQty = mProductBOM.UnitPiece
                mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mProductBOM.NetLenght, mProductBOM.NetWidth, mProductBOM.NetThickness)
                mValue = mValue
                e.Value = mValue


              Catch ex As Exception
                If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
              End Try

            End If

        End Select
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoCreateDuplicate_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoCreateDuplicate.ButtonClick
    Dim mSelectedProductBOM As dmProductBOM
    Dim mDuplicatedProductBOM As dmProductBOM
    Dim mProductStructure As dmProductStructure

    If pFormController.CurrentProductInfo.Product IsNot Nothing Then

      mSelectedProductBOM = TryCast(gvWoodMaterialRequirements.GetFocusedRow, dmProductBOM)

      If mSelectedProductBOM IsNot Nothing Then
        mDuplicatedProductBOM = New dmProductBOM
        mDuplicatedProductBOM.ObjectType = eProductBOMObjectType.Wood
        mDuplicatedProductBOM.StockItemID = mSelectedProductBOM.StockItemID
        mDuplicatedProductBOM.MaterialTypeID = 1
        mDuplicatedProductBOM.UoM = mSelectedProductBOM.UoM
        mDuplicatedProductBOM.WoodSpecie = mSelectedProductBOM.WoodSpecie
        mDuplicatedProductBOM.StockCode = mSelectedProductBOM.StockCode
        mDuplicatedProductBOM.NetLenght = mSelectedProductBOM.NetLenght
        mDuplicatedProductBOM.NetWidth = mSelectedProductBOM.NetWidth
        mDuplicatedProductBOM.NetThickness = mSelectedProductBOM.NetThickness
        mDuplicatedProductBOM.DateChange = Now
        mDuplicatedProductBOM.SupplierStockCode = mSelectedProductBOM.SupplierStockCode


        mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

        If mProductStructure IsNot Nothing Then

          mProductStructure.ProductWoodBOMs.Add(mDuplicatedProductBOM)

          gvWoodMaterialRequirements.RefreshData()

        End If

      End If


    End If


    gvWoodMaterialRequirements.CloseEditor()

  End Sub

  Private Sub gvWoodMaterialRequirements_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles gvWoodMaterialRequirements.ShownEditor
    Dim view As GridView = TryCast(sender, GridView)
    Dim activeEditor As TextEdit = TryCast(view.ActiveEditor, TextEdit)
    If activeEditor Is Nothing Then
      Return
    End If
    RemoveHandler activeEditor.Spin, AddressOf activeEditor_Spin
    AddHandler activeEditor.Spin, AddressOf activeEditor_Spin
  End Sub

  Private Sub activeEditor_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs)
    gvWoodMaterialRequirements.CloseEditor()
    gvStockItemMaterialRequirements.CloseEditor()

  End Sub


  Private Sub gvStockItemMaterialRequirements_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles gvStockItemMaterialRequirements.ShownEditor
    Dim view As GridView = TryCast(sender, GridView)
    Dim activeEditor As TextEdit = TryCast(view.ActiveEditor, TextEdit)
    If activeEditor Is Nothing Then
      Return
    End If
    RemoveHandler activeEditor.Spin, AddressOf activeEditor_Spin
    AddHandler activeEditor.Spin, AddressOf activeEditor_Spin
  End Sub


End Class
