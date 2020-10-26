Imports System.ComponentModel
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports RTIS.ProductCore

Public Class frmHouseType

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccHouseType

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private pFilterGrid As DevExpress.XtraGrid.GridControl

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

    pFilterGrid = New DevExpress.XtraGrid.GridControl

  End Sub

  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rParentMDI As frmTabbedMDI, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmHouseType = Nothing

    mfrm = GetFormIfLoaded(vPrimaryKeyID)
    If mfrm Is Nothing Then
      mfrm = New frmHouseType
      If vPrimaryKeyID <> 0 Then
        mfrm.FormMode = eFormMode.eFMFormModeEdit
      Else
        mfrm.FormMode = eFormMode.eFMFormModeAdd
      End If
      mfrm.pFormController = New fccHouseType(rDBConn, rRTISGlobal)
      mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmHouseType
    Dim mfrmWanted As frmHouseType = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmHouseType
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmHouseType_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      pFormController.LoadProducts()

      '// set it to the first Assembly
      If pFormController.HouseType.SalesItemAssemblys.Count >= 1 Then
        pFormController.SetCurrentHouseTypeAssembly(pFormController.HouseType.SalesItemAssemblys(0))
      End If

      UctHouseTypeOptions1.RTISGlobal = pFormController.RTISGlobal
      UctHouseTypeOptions1.HouseType = pFormController.HouseType

      LoadCombos()
      LoadGrids()

      If FormMode = eFormMode.eFMFormModeEdit And pFormController.HaveLock = False Then
        FormMode = eFormMode.eFMFormModeView
      End If

      RefreshTabs()

      UctHouseTypeOptions1.cboModel.ReadOnly = True
      UctHouseTypeOptions1.cboGroup.ReadOnly = True

      If mOK Then RefreshControls()

      ''If mOK Then SetupUserPermissions()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True

  End Sub

  Public Sub LoadGrids()
    grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.GroupType)
    clsDEControlLoading.FillDEComboVI(cboGroupType, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.ProductCostBook)
    clsDEControlLoading.FillDEComboVI(cboProductCostBook, mVIs)


    UctHouseTypeOptions1.LoadCombos()

    '// Load the Filter editor control
    ConfigureFilterControl()
  End Sub


  Private Sub ConfigureFilterControl()
    ''Dim mFilterProperties As RTIS.ProductCore.clsFilterProperties
    ''Dim mComponentProps As intComponentProperties
    Dim mObject As RTIS.ProductCore.intObjectProperties

    ''mComponentProps = colDoorsetObjectTypes.GetInstance(FormController.Part.ComponentType).ObjectCompProps()
    ''mObject = colDoorsetObjectTypes.GetInstance(FormController.Part.ComponentType).CreateObject
    mObject = New clsHouseTypePropertyDef

    If Not mObject Is Nothing Then
      UctConditionFilter1.SetUp(pFormController.RTISGlobal.RefLists, Nothing)
      UctConditionFilter1.RefreshControl(New RTIS.ProductCore.clsCondition(RTIS.ProductCore.eNodeTypes.eNT_Container), mObject)
    End If

  End Sub



  Private Sub RefreshControls()
    Dim mIsActive As Boolean
    Try
      mIsActive = pIsActive

      With pFormController.HouseType
        txtModelName.Text = .ModelName
        clsDEControlLoading.SetDECombo(cboGroupType, .GroupID)

        ''Refreshing UCT Option controls
        clsDEControlLoading.SetDECombo(UctHouseTypeOptions1.cboModel, .HouseTypeID)
        clsDEControlLoading.SetDECombo(UctHouseTypeOptions1.cboGroup, .GroupID)

        txtArea.Text = .Area

        pIsActive = mIsActive

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateObjects()
    Try
      With pFormController.HouseType

        .ModelName = txtModelName.Text
        .GroupID = clsDEControlLoading.GetDEComboValue(cboGroupType)
        .Area = txtArea.Text

      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()
    'pFormController.SaveObjects()
    If Me.pFormController.HaveLock Or pFormController.PrimaryKeyID = 0 Or FormMode = eFormMode.eFMFormModeAdd Then
      If pFormController.IsDirty() Then
        If rOption Then
          mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
          Select Case mResponse
            Case MsgBoxResult.Yes
              mSaveRequired = True
              mRetVal = False
              ExitMode = Windows.Forms.DialogResult.Yes
            Case MsgBoxResult.No
              mSaveRequired = False
              mRetVal = True
              ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
            Case MsgBoxResult.Cancel
              mSaveRequired = False
              mRetVal = False
          End Select
        Else
          ExitMode = Windows.Forms.DialogResult.Yes
          mSaveRequired = True
          mRetVal = False
        End If
      Else
        ExitMode = Windows.Forms.DialogResult.Ignore
        mSaveRequired = False
        mRetVal = True
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.Ignore
      mSaveRequired = False
      mRetVal = True
    End If
    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then


        pFormController.SaveObjects()


        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If

    CheckSave = mRetVal
  End Function

  Private Sub frmHouseType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub frmHouseType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
    If vWithCheck Then
      If CheckSave(True) Then
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If

  End Sub

  Private Sub bbtnSaveExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSaveExit.ItemClick
    Try
      CheckSave(False)
      CloseForm()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RefreshTabs()
    Dim mPos As Integer = 0
    Dim mPage As DevExpress.XtraTab.XtraTabPage
    Dim mIsActive As Boolean
    Dim mCurrentPage As DevExpress.XtraTab.XtraTabPage = Nothing

    mIsActive = pIsActive
    pIsActive = False

    'First remove excess tabs
    For mloop As Integer = tabHouseTypeAssemblys.TabPages.Count - 1 To 1 Step -1 'Note that it only counts down to 1 so it doesn't remove the last tab
      If mloop >= pFormController.HouseType.SalesItemAssemblys.Count - 1 Then
        tabHouseTypeAssemblys.TabPages.RemoveAt(mloop)
      End If
    Next

    'If there are no items then make page 0 invisible
    If pFormController.HouseType.SalesItemAssemblys.Count = 0 Then
      tabHouseTypeAssemblys.TabPages(0).PageVisible = False
    Else
      tabHouseTypeAssemblys.TabPages(0).PageVisible = True
    End If

    'Name and Add in tabs
    mPos = 0
    mCurrentPage = Nothing
    For Each mHTA As dmSalesItemAssembly In pFormController.HouseType.SalesItemAssemblys
      If mPos > tabHouseTypeAssemblys.TabPages.Count - 1 Then
        tabHouseTypeAssemblys.TabPages.Add()
      End If
      mPage = tabHouseTypeAssemblys.TabPages(mPos)
      mPage.Tag = mHTA
      mPage.Text = String.Format("{0}/{1}", mHTA.Ref, mHTA.Description)

      If mHTA Is pFormController.CurrentHouseTypeAssembly Then mCurrentPage = mPage
      mPos += 1
    Next

    If mCurrentPage Is Nothing Then
      tabHouseTypeAssemblys.SelectedTabPageIndex = 0
      pnlHouseTypeAssembly.Parent = tabHouseTypeAssemblys.TabPages(0)
    Else
      tabHouseTypeAssemblys.SelectedTabPage = mCurrentPage
      pnlHouseTypeAssembly.Parent = mCurrentPage
    End If
    RefreshHouseTypePanel()

    pIsActive = mIsActive

  End Sub

  Public Sub RefreshHouseTypePanel()
    If pFormController.CurrentHouseTypeAssembly IsNot Nothing Then
      With pFormController.CurrentHouseTypeAssembly
        txtAssDescription.Text = .Description
        txtAssRef.Text = .Ref
        txtAssArea.Text = .Area
      End With
    End If
  End Sub

  Public Sub UpdateHouseTypePanel()
    If pFormController.CurrentHouseTypeAssembly IsNot Nothing Then
      With pFormController.CurrentHouseTypeAssembly
        .Description = txtAssDescription.Text
        .Ref = txtAssRef.Text
        .Area = txtAssArea.Text
      End With
    End If
  End Sub

  Private Sub tabHouseTypeAssemblys_CustomHeaderButtonClick(sender As Object, e As CustomHeaderButtonEventArgs) Handles tabHouseTypeAssemblys.CustomHeaderButtonClick
    Try
      Dim mIsActive As Boolean
      mIsActive = pIsActive
      Select Case e.Button.Tag
        Case "Add"
          ClearAssemblyControls()
          pFormController.AddAssembly()
          grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
          gvHouseSalesItems.RefreshData()
        Case "Delete"
          If pFormController.HouseType.SalesItemAssemblys.Count = 1 Then
            MessageBox.Show("No se puede eliminar esta pestaña, debido a que la configuración de la casa requiere al menos un elemento")
          Else
            pFormController.DeleteAssembly(pFormController.CurrentHouseTypeAssembly)

          End If
      End Select
      RefreshTabs()
      pIsActive = mIsActive
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub ClearAssemblyControls()
    txtAssArea.Text = ""
    txtAssDescription.Text = ""
    txtAssRef.Text = ""
  End Sub

  Private Sub tabHouseTypeAssemblys_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles tabHouseTypeAssemblys.SelectedPageChanged
    Try
      If pIsActive Then
        UpdateHouseTypePanel()
        If e.Page.Tag IsNot Nothing Then

          pnlHouseTypeAssembly.Parent = e.Page
          pFormController.SetCurrentHouseTypeAssembly(e.Page.Tag)

        Else
          pFormController.SetCurrentHouseTypeAssembly(Nothing)
        End If
      Else
        pFormController.SetCurrentHouseTypeAssembly(Nothing)
      End If
      RefreshHouseTypePanel()
      grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try

      UpdateObjects()
      UpdateHouseTypePanel()
      pFormController.SaveObjects()
      RefreshTabs()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub bbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub grpStockItemDetail_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpProductLists.CustomButtonClick
    Dim mProductBaseInfoList As New List(Of clsProductBaseInfo)
    Dim mHTSalesItemInfo As clsHouseTypeSalesItemInfo
    Dim mProductBaseInfo As clsProductBaseInfo
    Dim mProductInfos As colProductBaseInfos
    Dim mProductPicker As clsPickerProductItem
    Dim mProductsToAdd As New List(Of clsProductBaseInfo)
    Dim mProductBaseInfos As colProductBaseInfos


    Select Case e.Button.Properties.Tag

      Case "Add"
        Try
          ''Load CostBook
          ''pFormController.LoadProductCostBookDown(clsDEControlLoading.GetDEComboValue(cboProductCostBook))


          ''mProductBaseInfos = pFormController.GetProductInfos
          ''''For Each mItem As clsProductBaseInfo In mProductBaseInfos

          ''''  mProductBaseInfos.Add(mItem)
          ''''Next

          ''mProductPicker = New clsPickerProductItem(pFormController.GetProductInfos, pFormController.DBConn, AppRTISGlobal.GetInstance)

          ''For Each mHTSalesItem In pFormController.HouseType.HTSalesItems
          ''  If mHTSalesItem.ProductID > 0 Then
          ''    mProductBaseInfo = mProductBaseInfos.ItemFromProductTypeAndID(mHTSalesItem.ProductTypeID, mHTSalesItem.ProductID)
          ''    If Not mProductPicker.SelectedObjects.Contains(mProductBaseInfo) Then
          ''      mProductPicker.SelectedObjects.Add(mProductBaseInfo)
          ''    End If
          ''  End If
          ''Next

          ''mProductsToAdd = frmProductPicker.OpenPickerMulti(mProductPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance)
          ''For Each mSelectedItem In mProductPicker.SelectedObjects
          ''  If mSelectedItem IsNot Nothing Then

          ''    If pFormController.HouseType.HTSalesItems.ItemFromProductID_ProductType(mSelectedItem.ID, mSelectedItem.ProductTypeID) Is Nothing Then
          ''      CheckSave(False)
          ''      pFormController.AddProducts(mProductsToAdd)
          ''      grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
          ''      gvHouseSalesItems.RefreshData()

          ''    End If




          ''  End If
          ''Next


          ''''-------------------------


          mProductPicker = New clsPickerProductItem(pFormController.GetProductInfos, pFormController.DBConn, pFormController.RTISGlobal)
          mProductsToAdd = frmProductPicker.OpenPickerMulti(mProductPicker, True, pFormController.DBConn, pFormController.RTISGlobal)

          CheckSave(False)
          pFormController.AddProducts(mProductsToAdd)
          grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
          gvHouseSalesItems.RefreshData()
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

      Case "AddDuplicates"
        ''  Dim mCount As Integer


        mHTSalesItemInfo = CType(gvHouseSalesItems.GetFocusedRow, clsHouseTypeSalesItemInfo)

        If mHTSalesItemInfo IsNot Nothing Then
          mProductInfos = pFormController.GetProductInfos
          mProductBaseInfo = mProductInfos.ItemFromProductTypeAndID(mHTSalesItemInfo.Product.ProductTypeID, mHTSalesItemInfo.Product.ID)

          If mProductBaseInfo IsNot Nothing Then
            mProductBaseInfoList.Add(mProductBaseInfo)
            CheckSave(False)

            pFormController.AddProducts(mProductBaseInfoList)
            grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
            gvHouseSalesItems.RefreshData()
          End If

        End If

      Case "Delete"
        mHTSalesItemInfo = TryCast(gvHouseSalesItems.GetFocusedRow, clsHouseTypeSalesItemInfo)
        If mHTSalesItemInfo IsNot Nothing Then
          If MsgBox("Eliminar este Articulo?", vbYesNo) = vbYes Then
            UpdateObjects()
            pFormController.DeleteHTSalesItemInfo(mHTSalesItemInfo)
            grdHouseSalesItems.DataSource = pFormController.CurrentHTSalesItemInfos
            gvHouseSalesItems.RefreshData()
            RefreshControls()
          End If
        End If

    End Select


  End Sub

  Private Sub repoPopupContainerCriteria_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repoPopupContainerCriteria.QueryPopUp
    Dim mFC As DevExpress.XtraEditors.FilterControl
    Dim mHouseTypeSalesItemInfo As clsHouseTypeSalesItemInfo
    mHouseTypeSalesItemInfo = CType(gvHouseSalesItems.GetFocusedRow(), clsHouseTypeSalesItemInfo)

    mFC = CType(UctConditionFilter1.Controls(0), DevExpress.XtraEditors.FilterControl)
    If mHouseTypeSalesItemInfo IsNot Nothing AndAlso mFC IsNot Nothing Then
      '’ If storing condition as string
      mFC.FilterString = mHouseTypeSalesItemInfo.ConditionString
      mFC.Refresh()

      '’ If not storing condition as string then 
      '’mFC.RefreshControl(mPartBOM.ProfilePartCondition, pObject)  ‘’ need pObject (intObjectProperties) available

    End If

  End Sub

  Private Sub repoPopupContainerCriteria_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles repoPopupContainerCriteria.CloseUp
    Try
      Dim mFC As DevExpress.XtraEditors.FilterControl
      Dim mHouseTypeSalesItemInfo As clsHouseTypeSalesItemInfo

      mHouseTypeSalesItemInfo = CType(gvHouseSalesItems.GetFocusedRow(), clsHouseTypeSalesItemInfo)
      mFC = CType(UctConditionFilter1.Controls(0), DevExpress.XtraEditors.FilterControl)
      If mHouseTypeSalesItemInfo IsNot Nothing AndAlso mFC IsNot Nothing Then

        If mFC.ActiveEditor IsNot Nothing Then
          mFC.ActiveEditor.DoValidate()
        End If

        mHouseTypeSalesItemInfo.ConditionString = mFC.FilterString
        mHouseTypeSalesItemInfo.ConditionStringUI = GetDisplayText(mFC)
        e.Value = mHouseTypeSalesItemInfo.ConditionStringUI
      Else
        e.Value = ""
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
    UctHouseTypeOptions1.UpdateObjects()
    pFormController.ProductCostBookID = clsDEControlLoading.GetDEComboValue(cboProductCostBook)
    pFormController.SetPrevHTSalesItemInfos(pFormController.ProductCostBookID)
    grdPrevHouseTypeSalesItems.DataSource = pFormController.PrevtHTSalesItemInfos


    pFormController.RefreshProductCostSummaryInfo(pFormController.PrevtHTSalesItemInfos)
    grdSummaryCostBookEntry.DataSource = pFormController.ProductCostSummaryInfo
    gvSummaryCostBookEntry.RefreshData()
  End Sub


  Private Function GetDisplayText(ByVal vFilterControl As DevExpress.XtraEditors.FilterControl) As String
    Dim mFilterString As String = String.Empty
    Dim mObject As intObjectProperties = New clsHouseTypePropertyDef(pFormController.HouseType)

    If mObject IsNot Nothing Then
      Dim mGrid As New DevExpress.XtraGrid.GridControl
      Dim mGridView As New DevExpress.XtraGrid.Views.Grid.GridView

      mGrid.MainView = mGridView


      For Each mProp As clsPropertyDef In mObject.PropertyList
        Dim mCol As New DevExpress.XtraGrid.Columns.GridColumn()

        mCol.FieldName = mProp.PropertyName

        If mProp.LookUpRef > 0 Then
          RTIS.Elements.clsDEControlLoading.LoadGridLookUpEditiVI(mGrid, mCol, pFormController.RTISGlobal.RefLists.RefListVI(mProp.LookUpRef))
        End If

        mGridView.Columns.Add(mCol)
      Next

      mGridView.ActiveFilterString = vFilterControl.FilterString
      mFilterString = mGridView.FilterPanelText
    End If

    Return mFilterString
  End Function


End Class