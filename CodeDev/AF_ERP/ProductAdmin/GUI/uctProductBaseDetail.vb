Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class uctProductBaseDetail

  Private pRTISGlobal As AppRTISGlobal
  Private pFormController As uccProductBaseDetail

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

    clsDEControlLoading.FillDEComboVI(cboUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))

    mSuppliers = AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Supplier)


  End Sub

  Public Sub RefreshControls()

    If pFormController.CurrentProductInfo IsNot Nothing Then
      With pFormController.CurrentProductInfo.Product
        txtDescription.Text = .Description
        txtStockCode.Text = .Code
        lblStockItemID.Text = "ID: " & .ID
        clsDEControlLoading.SetDECombo(cboProductItemType, .ItemType)
        clsDEControlLoading.SetDECombo(cboSubItemType, .SubItemType)
        clsDEControlLoading.SetDECombo(cboUoM, .UoM)
        bteDrawing.Text = .DrawingFileName
        chkIsGeneric.EditValue = .IsGeneric
      End With


    End If
  End Sub

  Public Sub UpdateObject()

    If pFormController.CurrentProductInfo IsNot Nothing Then
      With pFormController.CurrentProductInfo.Product
        .Description = txtDescription.Text
        .IsGeneric = chkIsGeneric.EditValue
        .Code = txtStockCode.Text
        .ItemType = clsDEControlLoading.GetDEComboValue(cboProductItemType)
        .SubItemType = clsDEControlLoading.GetDEComboValue(cboSubItemType)
        .UoM = clsDEControlLoading.GetDEComboValue(cboUoM)

        UpdateProductBOMs()

      End With
    End If



  End Sub

  Public Sub UpdateProductBOMs()
    Dim mProductBOM As dmProductBOM

    For Each mProductBOMInfo As clsProductBOMInfo In pFormController.ProductBOMInfos

      If pFormController.CurrentProductInfo.Product.ProductBOMs.IndexFromProductID(mProductBOMInfo.ProductBOM.ProductID) = -1 Then
        mProductBOM = New dmProductBOM
        mProductBOM.ParentID = mProductBOMInfo.ProductBOM.ParentID
        mProductBOM.ProductID = mProductBOMInfo.ProductBOM.ProductID
        mProductBOM.Quantity = mProductBOMInfo.ProductBOM.Quantity
        pFormController.CurrentProductInfo.Product.ProductBOMs.Add(mProductBOM)

      Else
        mProductBOM = pFormController.CurrentProductInfo.Product.ProductBOMs.ItemFromProductID(mProductBOMInfo.ProductBOM.ProductID)
        If mProductBOM IsNot Nothing Then
          ''//Update Quantity from CurrentCollection
          mProductBOM.Quantity = mProductBOMInfo.Quantity
        End If
      End If

    Next
  End Sub

  Public Sub RefreshStockItemGrid()
    gvStockItemBOM.RefreshData()
  End Sub

  Public Function GetCurrentEmodeProductType() As eProductType
    Return CType(clsDEControlLoading.GetDEComboValue(cboProductItemType), eProductType)
  End Function

  Public Sub RefreshSubTypesOptions(ByVal vProductConstructionSubTypes As colProductConstructionSubTypes)
    clsDEControlLoading.FillDEComboVIi(cboSubItemType, vProductConstructionSubTypes)
  End Sub

  Public Sub LoadProductBOMS(ByRef rCurrentProductBase As dmProductBase)
    pFormController.LoadProductBOMInfos(pFormController.ProductBOMInfos, rCurrentProductBase.ID)
    grdProductBOMs.DataSource = pFormController.ProductBOMInfos
    grdProductBOMs.RefreshDataSource()
  End Sub

  Friend Sub LoadStockItemBOM(ByRef rProductBase As dmProductBase)
    grdStockItemBOM.DataSource = rProductBase.StockItemBOMs
  End Sub

  Public Sub FocusDescription()
    txtDescription.Focus()
  End Sub

  Public Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)
    txtDescription.ReadOnly = vReadOnly
    cboProductItemType.ReadOnly = vReadOnly
    txtStockCode.ReadOnly = vReadOnly
    cboSubItemType.ReadOnly = vReadOnly
    cboUoM.ReadOnly = vReadOnly
    bteDrawing.Enabled = Not vReadOnly
    btnGenerateCode.Enabled = Not vReadOnly
    chkIsGeneric.ReadOnly = vReadOnly
    gpStockItemBOM.Enabled = Not vReadOnly

  End Sub

  Private Sub gpStockItemBOM_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpStockItemBOM.CustomButtonClick
    Dim mOK As Boolean = False
    Dim mTemProduct As dmProductBase = Nothing
    Try
      Select Case e.Button.Properties.Tag

        Case "Add"
          Dim mSIs As New colStockItems
          Dim mPicker As clsPickerStockItem
          Dim mSelectedSI As dmStockItem

          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In AppRTISGlobal.GetInstance.StockItemRegistry.StockItemsDict
            mSIs.Add(mItem.Value)
          Next

          mPicker = New clsPickerStockItem(mSIs, pFormController.DBConn, AppRTISGlobal.GetInstance)


          For Each mSIBOM As dmStockItemBOM In pFormController.CurrentProductInfo.Product.StockItemBOMs
            mSelectedSI = mSIs.ItemFromKey(mSIBOM.StockItemID)
            If mSelectedSI IsNot Nothing Then
              If mPicker.SelectedObjects.Contains(mSelectedSI) = False Then
                mPicker.SelectedObjects.Add(mSelectedSI)
              End If
            End If
          Next

          frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance)

          pFormController.RefreshStockItemBOMs(mPicker.SelectedObjects)

          mOK = pFormController.SetProductBase(mTemProduct)

          If mOK Then
            SetStockItemBOMGrid(mTemProduct.StockItemBOMs)

          End If

          RefreshStockItemGrid()

      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub bteDrawing_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteDrawing.ButtonClick
    Try

      Try
        Select Case e.Button.Kind
          Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete


          Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
            Dim mFileName As String = ""
            If RTIS.CommonVB.clsGeneralA.GetOpenFileName(mFileName, "Selecionar el Plano") = DialogResult.OK Then


              If CreateDrawingPDF(mFileName) = False Then

              End If
            End If
            RefreshControls()

          Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis
            If File.Exists(pFormController.CurrentProductInfo.Product.DrawingFileName) Then

              Process.Start(pFormController.CurrentProductInfo.Product.DrawingFileName)
            End If
        End Select
      Catch ex As Exception
        If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
      End Try


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Public Sub SetStockItemBOMGrid(ByRef rStockItemBOMs As colStockItemBOMs)
    grdStockItemBOM.DataSource = rStockItemBOMs
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

  Public Sub ShowHideProductBOM(ByVal vShowGrid As Boolean)
    xtpProductBOM.Visible = vShowGrid

  End Sub

  Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click
    UpdateObject()

    If cboSubItemType.SelectedIndex = -1 Then
      MessageBox.Show("No se ha seleccionado el sub tipo del producto. Por favor, ingrese un valor válido en la lista desplegable")

    Else
      pFormController.CheckCreateStockCodeSave()
      RefreshControls()
    End If

  End Sub







  Public Function GetProductInfos() As colProductBaseInfos
    Dim mRetVal As New colProductBaseInfos
    Dim mdso As New dsoProductAdmin(pFormController.DBConn)
    mdso.LoadProductInfosStructureOnly(mRetVal)
    Return mRetVal
  End Function

  Public Sub SetCurrentProductBaseInfo(ByRef rCurrentProductBaseInfo As clsProductBaseInfo)
    pFormController.CurrentProductInfo = rCurrentProductBaseInfo
  End Sub

  Private Sub gpProductBOM_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpProductBOM.CustomButtonClick
    Dim mProductPicker As clsPickerProductItem
    Dim mProductsToAdd As New List(Of clsProductBaseInfo)

    Dim mProductBOMInfo As clsProductBOMInfo
    Select Case e.Button.Properties.Tag
      Case "Add"
        mProductPicker = New clsPickerProductItem(GetProductInfos, pFormController.DBConn, AppRTISGlobal.GetInstance)
        mProductsToAdd = frmProductPicker.OpenPickerMulti(mProductPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance, frmProductPicker.ePickerMode.ProductBOM)

        If mProductsToAdd IsNot Nothing Then
          For Each mProductInfo As clsProductBaseInfo In mProductsToAdd
            mProductBOMInfo = New clsProductBOMInfo
            mProductBOMInfo.ProductBOM.ParentID = pFormController.CurrentProductInfo.Product.ID
            mProductBOMInfo.ProductBOM.ProductID = mProductInfo.Product.ID
            mProductBOMInfo.Description = mProductInfo.Product.Description
            pFormController.ProductBOMInfos.Add(mProductBOMInfo)

            'pFormController.CurrentProductInfo.Product.ProductBOMs.Add(mProductBOM)

          Next
        End If
        grdProductBOMs.DataSource = pFormController.ProductBOMInfos
        grdProductBOMs.RefreshDataSource()
    End Select
  End Sub
End Class
