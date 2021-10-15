Imports System.IO
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
  Private pItemsSelected As Integer
  Private pTempInWoodStock As Integer
  Private pWoodItemsSelected As Integer


  Public Event OnCheckChanged As EventHandler

  Private Sub checkbox_CheckedChanged(sender As Object, e As EventArgs)
    RaiseEvent OnCheckChanged(Me, e)
  End Sub


  Public Property WoodItemsSelected As Integer
    Get
      Return pWoodItemsSelected
    End Get
    Set(value As Integer)
      pWoodItemsSelected = value
    End Set
  End Property

  Public Property ItemsSelected As Integer
    Get
      Return pItemsSelected
    End Get
    Set(value As Integer)
      pItemsSelected = value
    End Set
  End Property

  Public Property TempInWoodStock As Integer
    Get
      Return pTempInWoodStock
    End Get
    Set(value As Integer)
      pTempInWoodStock = value
    End Set
  End Property
  Private Enum eMaterialRequirementsButtons
    Copy = 1
    Paste = 2
    ExportList = 3
    AddInv = 4
    ChangeSpecies = 5
    AddProvInv = 6
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



    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodTypeValue)
    RTIS.Elements.clsDEControlLoading.LoadRepItemLookUpEditiVI(repoWoodItemTypeLK, mVIs)
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
        If UctFileControl1.UserController Is Nothing Then
          UctFileControl1.UserController = New uccFileControl()
        End If
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



  Private Sub gvStockItemMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItemMaterialRequirements.CustomUnboundColumnData
    Dim mMatReq As dmProductBOM
    Dim mSI As dmStockItem

    mMatReq = CType(e.Row, dmProductBOM)

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

  Private Sub gvMaterialRequirements_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles gvWoodMaterialRequirements.InitNewRow
    Dim mMatReq As dmProductBOM
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
    grpStockItemMaterialRequirement.CustomHeaderButtons.Item(1).Properties.Visible = Not vReadOnly
    grpWoodMaterialRequirements.CustomHeaderButtons.Item(1).Properties.Visible = Not vReadOnly
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



        Case eMaterialRequirementsButtons.ChangeSpecies
          Dim mSelectedWoodItems As New colProductBOMs
          Dim mSelectedItem As dmProductBOM
          gvWoodMaterialRequirements.CloseEditor()
          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

          If mProductStructure IsNot Nothing Then

            For Each mProductStockBOM In mProductStructure.ProductWoodBOMs ''.POItemsMinusAllocatedItem

              If mProductStockBOM.TmpSelectedItem Then
                mSelectedItem = mProductStockBOM

                If mSelectedItem IsNot Nothing Then
                  mSelectedWoodItems.Add(mSelectedItem)
                End If
              End If


            Next
          End If


          frmProductGlobalChange.OpenForm(pFormController.DBConn, mSelectedWoodItems)
          gvWoodMaterialRequirements.CloseEditor()
          gvWoodMaterialRequirements.RefreshData()
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try


  End Sub

  Private Sub repobtnChangeSpecie_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles repobtnChangeSpecie.ButtonPressed
    Dim mWoodProductBOM As dmProductBOM
    Dim mSI As dmStockItem
    Dim mPicker As clsPickerStockItem
    Dim mStockItemsForPickers As New colStockItems

    Try
      mWoodProductBOM = TryCast(gvWoodMaterialRequirements.GetFocusedRow, dmProductBOM)

      If mWoodProductBOM IsNot Nothing Then

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict

          If mItem.Value.StockItemType = eStockItemTypeTimberWood.Aserrado Or mItem.Value.StockItemType = eStockItemTypeTimberWood.MAS Or
                mItem.Value.StockItemType = eStockItemTypeTimberWood.Primera Or mItem.Value.StockItemType = eStockItemTypeTimberWood.Segunda Or
                mItem.Value.StockItemType = eStockItemTypeTimberWood.Tercera Or mItem.Value.StockItemType = eStockItemTypeTimberWood.ClasificadoZ Then
            mStockItemsForPickers.Add(mItem.Value)

          End If
        Next


        mPicker = New clsPickerStockItem(mStockItemsForPickers, pFormController.DBConn, pFormController.RTISGlobal)
        mSI = frmPickerStockItem.OpenPickerSingle(mPicker, True)

        If mSI IsNot Nothing Then
          mWoodProductBOM.StockItemID = mSI.StockItemID
          mWoodProductBOM.WoodSpecie = mSI.Species

        End If

      End If
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
            If TryCast(mItem.Value, dmStockItem).Inactive = False Then
              mSIs.Add(mItem.Value)
            End If

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

        Case eMaterialRequirementsButtons.AddProvInv
          Dim mProvStockItem As dmStockItem

          gvStockItemMaterialRequirements.CloseEditor()

          mProvStockItem = frmNewStockItemProv.OpenForm(pFormController.DBConn)

          If mProvStockItem IsNot Nothing Then

            pFormController.CreateStockItemProductBoMProvisional(mProvStockItem)
            RefreshControls()
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

      gvWoodMaterialRequirements.CloseEditor()
      mProductBOM = TryCast(e.Row, dmProductBOM)


      If mProductBOM IsNot Nothing Then
        Select Case e.Column.Name
            'Case gcThicknessInch.Name
            '  If e.IsGetData Then
            '    mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mProductBOM.StockItemID)

            '    If mStockItem IsNot Nothing Then
            '      e.Value = mStockItem.Thickness

            '    End If

            '  End If

          Case gcQtyBoardFeet.Name
            Dim mValue As Decimal
            Dim mQty As Integer


            If e.IsGetData Then



              mQty = mProductBOM.UnitPiece
              mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mProductBOM.NetLenght, mProductBOM.NetWidth, mProductBOM.NetThickness)
              mValue = mValue
              e.Value = mValue


            End If

          Case gcThicknessCM.Name
            Dim mThicknessNetCM As Decimal
            Dim mThicknessInch As Decimal

            If e.IsGetData Then

              mThicknessNetCM = mProductBOM.NetThickness
              e.Value = mThicknessNetCM
            End If
            If e.IsSetData Then
              Dim mSpeciesID As Integer

              mThicknessInch = clsSMSharedFuncs.GrosWoodThickness(e.Value)

              mProductBOM.NetThickness = e.Value

              If mProductBOM.WoodItemType > 0 Then
                mSpeciesID = mProductBOM.WoodSpecie

                pFormController.ChangeSpeciesForSelectedWoodItems(mSpeciesID, mThicknessInch, mProductBOM, mProductBOM.WoodItemType)
              Else
                MessageBox.Show("Seleccione una clasificación válida", "Clasificación de Madera", MessageBoxButtons.OK, MessageBoxIcon.Information)
              End If
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
        mDuplicatedProductBOM.WoodItemType = mSelectedProductBOM.WoodItemType


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

  Private Sub repoChkSelectedSI_CheckedChanged(sender As Object, e As EventArgs) Handles repoChkSelectedSI.CheckedChanged
    Dim mProductStructure As dmProductStructure

    gvStockItemMaterialRequirements.CloseEditor()
    ItemsSelected = 0
    If pFormController IsNot Nothing Then

      If pFormController.CurrentProductInfo IsNot Nothing Then

        If pFormController.CurrentProductInfo.Product IsNot Nothing Then

          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

          If mProductStructure IsNot Nothing Then
            For Each mPWBOM As dmProductBOM In gvStockItemMaterialRequirements.DataSource

              If mPWBOM.TmpSelectedItem Then
                ItemsSelected += 1
              End If

            Next

          End If

        End If

      End If

    End If
  End Sub



  Private Sub repoChkSelectedItem_CheckedChanged(sender As Object, e As EventArgs) Handles repoChkSelectedItem.CheckedChanged
    Dim mProductStructure As dmProductStructure

    gvWoodMaterialRequirements.CloseEditor()
    ItemsSelected = 0
    WoodItemsSelected = 0
    If pFormController IsNot Nothing Then

      If pFormController.CurrentProductInfo IsNot Nothing Then

        If pFormController.CurrentProductInfo.Product IsNot Nothing Then

          mProductStructure = TryCast(pFormController.CurrentProductInfo.Product, dmProductStructure)

          If mProductStructure IsNot Nothing Then
            For Each mPWBOM As dmProductBOM In gvWoodMaterialRequirements.DataSource

              If mPWBOM.TmpSelectedItem Then
                ItemsSelected += 1
                WoodItemsSelected += 1
              End If

            Next

          End If

        End If

      End If

    End If
  End Sub



  Private Sub repoThicknessValueLK_EditValueChanged(sender As Object, e As EventArgs) Handles repoThicknessValueLK.EditValueChanged
    Dim mThicknessValueIndex As Integer
    Dim mProductBOM As dmProductBOM
    Dim mSIThickness As Decimal

    If pFormController IsNot Nothing Then

      gvWoodMaterialRequirements.CloseEditor()

      If pFormController.CurrentProductInfo IsNot Nothing Then

        mProductBOM = TryCast(gvWoodMaterialRequirements.GetFocusedRow, dmProductBOM)

        If mProductBOM IsNot Nothing Then
          mThicknessValueIndex = mProductBOM.StockItemThickness
          If mThicknessValueIndex > 0 Then


            mSIThickness = Decimal.Parse(AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ThicknessValue).DisplayValueString(mThicknessValueIndex))

            If mSIThickness > 0 Then
              Dim mWoodItemTypeID As Integer
              Dim mSpeciesID As Integer


              If mProductBOM.WoodItemType > 0 Then
                mSpeciesID = mProductBOM.WoodSpecie

                pFormController.ChangeSpeciesForSelectedWoodItems(mSpeciesID, mSIThickness, mProductBOM, mProductBOM.WoodItemType)
              Else
                MessageBox.Show("Seleccione una clasificación válida", "Clasificación de Madera", MessageBoxButtons.OK, MessageBoxIcon.Information)
              End If






            End If
          End If
        End If
      End If


    End If
  End Sub


  Private Sub repoWoodItemTypeLK_EditValueChanged(sender As Object, e As EventArgs) Handles repoWoodItemTypeLK.EditValueChanged
    Dim mThicknessValueIndex As Integer
    Dim mProductBOM As dmProductBOM
    Dim mSIThickness As Decimal
    Dim mWoodItemTypeID As Integer

    If pFormController IsNot Nothing Then

      gvWoodMaterialRequirements.CloseEditor()

      If pFormController.CurrentProductInfo IsNot Nothing Then

        mProductBOM = TryCast(gvWoodMaterialRequirements.GetFocusedRow, dmProductBOM)

        If mProductBOM IsNot Nothing Then
          mThicknessValueIndex = mProductBOM.StockItemThickness

          If mThicknessValueIndex > 0 Then
            mSIThickness = Decimal.Parse(AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ThicknessValue).DisplayValueString(mThicknessValueIndex))



            If mProductBOM.WoodItemType > 0 Then
              If mSIThickness > 0 Then

                Dim mWoodTypeID As Integer

                mWoodTypeID = mProductBOM.WoodItemType

                pFormController.ChangeWoodTypeForSelectedWoodItems(mWoodTypeID, mSIThickness, mProductBOM)
              End If
            Else
              MessageBox.Show("Por favor, seleccione una clasificación de madera válida")
            End If
          End If
        End If
      End If


    End If
  End Sub

  Private Sub cboProductItemType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProductItemType.KeyPress


    If e.KeyChar = Convert.ToChar(Keys.Back) Then
      clsDEControlLoading.SetDECombo(cboProductItemType, 0)

    End If
  End Sub
End Class
