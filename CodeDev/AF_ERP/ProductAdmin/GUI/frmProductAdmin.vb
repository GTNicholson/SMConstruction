Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.IO

Public Class frmProductAdmin
  Private pFormController As fccProductAdmin

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pForceExit As Boolean = False
  Private pIsActive As Boolean
  Public ExitMode As Windows.Forms.DialogResult

  Private pCurrentDetailMode As eCurrentDetailMode

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum

  Private Enum eDetailButtons
    Save = 1
    Edit = 2
    CreateDuplicates = 3
  End Enum
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vProductTypes As List(Of eProductType))
    Dim mfrm As frmProductAdmin = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmProductAdmin
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccProductAdmin(rDBConn, rRTISGlobal)
      mfrm.pFormController.ProductTypes = vProductTypes
      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Private Sub frmProductAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False

    Try
      mOK = True

      pFormController.LoadObject()
      UctProductBaseDetail1.ConfigureControl(pFormController.DBConn, pFormController.RTISGlobal)
      UctProductBaseDetail1.LoadCombos()
      ''RefreshAddBtn()


      grdProductBase.DataSource = pFormController.ProductBaseInfos

      RefreshControls()


    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor, intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True
  End Sub

  Private Shared Function GetFormIfLoaded() As frmProductAdmin
    Dim mfrmWanted As frmProductAdmin = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmProductAdmin
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmProductAdmin Then
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

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UctProductBaseDetail1.UpdateObject()
    'pFormController.SaveObjects()
    If pFormController.IsAnyDirty() Then
      If rOption Then
        mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
        Select Case mResponse
          Case MsgBoxResult.Yes
            mSaveRequired = True
            mRetVal = False
            ExitMode = Windows.Forms.DialogResult.Yes
          Case MsgBoxResult.No
            Dim mSI As New dmStockItem


            mSaveRequired = False
            mRetVal = True

            ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
            pFormController.LoadMainCollection()
            pFormController.LoadStockItemBOM()
            grdProductBase.RefreshDataSource()
            RefreshControls()
            gvProductBase.RefreshData()
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

    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then


        pFormController.SaveObject()


        mRetVal = True
      Else
        MsgBox(String.Format("Problema cargando el formulario... Intente nuevamente {0}", vbCrLf), vbExclamation)
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  'Private Sub LoadCombos()
  '  Dim mVIs As colValueItems
  '  Dim mSuppliers As colSuppliers

  '  mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.ProductConstructionType)

  '  'clsDEControlLoading.FillDEComboVI(cboProductItemType, mVIs)
  '  '' clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcCategory, mVIs)

  '  'clsDEControlLoading.FillDEComboVI(cboUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))

  '  mSuppliers = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.Supplier)
  '  '' clsDEControlLoading.FillDEComboVIi(cboSupplier, mSuppliers)

  'End Sub

  Private Sub RefreshControls()

    Dim mControlEnabled As Boolean
    Dim mStartActive As Boolean = pIsActive

    pIsActive = False
    If pFormController.CurrentProductInfo IsNot Nothing Then
      mControlEnabled = True
      UctProductBaseDetail1.SetCurrentProductBaseInfo(pFormController.CurrentProductInfo)
      UctProductBaseDetail1.RefreshControls()

      UctProductBaseDetail1.txtDescription.Enabled = mControlEnabled
      UctProductBaseDetail1.txtStockCode.Enabled = mControlEnabled

    End If

    pIsActive = mStartActive

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)
    End If

  End Sub

  'Private Sub UpdateObject()

  '  If pFormController.CurrentProductBase IsNot Nothing Then
  '    With pFormController.CurrentProductBase
  '      '.Description = txtDescription.Text
  '      '.IsGeneric = chkIsGeneric.EditValue
  '      '.Code = txtStockCode.Text
  '      '.ItemType = clsDEControlLoading.GetDEComboValue(cboProductItemType)
  '      '.SubItemType = clsDEControlLoading.GetDEComboValue(cboSubItemType)
  '      '.UoM = clsDEControlLoading.GetDEComboValue(cboUoM)

  '    End With
  '  End If

  'End Sub

  Private Sub gvStockItems_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvProductBase.FocusedRowObjectChanged
    Try
      Dim mSII As clsProductBaseInfo

      '' UpdateObject()
      mSII = TryCast(e.Row, clsProductBaseInfo)

      If mSII IsNot Nothing Then

        If pCurrentDetailMode = eCurrentDetailMode.eEdit Then

          If pFormController.CurrentProductBase IsNot Nothing And pFormController.CurrentProductBase.ID > 0 Then

            If pFormController.IsLocked Then
              pFormController.UnLockStockItem(pFormController.CurrentProductBase.ID)
              pFormController.IsLocked = False
            End If

          Else
            gvProductBase.RefreshData()
          End If
        End If
        pFormController.SetCurrentStockItemInfo(mSII)
        UctProductBaseDetail1.SetCurrentProductBaseInfo(mSII)

        RefreshPCSubItemTypes()


        RefreshControls()

        LoadStockItemBOM()
        LoadProductBOMs()
        RefreshControls()
        pCurrentDetailMode = eCurrentDetailMode.eView
        RefreshDetailButtons()
        ShowHideProductBOM()
        gvProductBase.RefreshData()
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub AddStockItemCat(sender As Object, e As EventArgs)



    pFormController.AddProductItem_SetToCurrent(pFormController.CurrentEmodeProductType)
    UctProductBaseDetail1.SetCurrentProductBaseInfo(pFormController.CurrentProductInfo)
    grdProductBase.RefreshDataSource()
    pFormController.GotoGridRowByRowObject(gvProductBase, pFormController.CurrentProductInfo)

    pCurrentDetailMode = eCurrentDetailMode.eEdit
    RefreshControls()
    RefreshDetailButtons()
    SetDetailFocus()

    pFormController.SaveObject()

  End Sub

  Private Sub ShowHideProductBOM()

    Select Case pFormController.CurrentProductInfo.ProductTypeID
      Case eProductType.StructureAF
        UctProductBaseDetail1.ShowHideProductBOM(True)

      Case Else
        UctProductBaseDetail1.ShowHideProductBOM(False)
    End Select

  End Sub


  Private Sub frmProductAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try

      UctProductBaseDetail1.UpdateObject()
      pFormController.SaveObject()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub




  Private Sub frmProductAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub

  Private Sub gvStockItems_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)

  End Sub

  Private Sub RefreshDetailButtons()
    Select Case pCurrentDetailMode
      Case eCurrentDetailMode.eEdit
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpStockItemDetail.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.CreateDuplicates Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = True
        Next
      Case eCurrentDetailMode.eView
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpStockItemDetail.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.CreateDuplicates Then mBtn.Enabled = True
        Next
    End Select
  End Sub
  ''Private Sub RefreshAddBtn()

  ''  Dim mValueItems As colValueItems


  ''  repoCategory.Items.Clear()



  ''  btnAddStockItem.Caption = "Agregar Producto de " & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), pFormController.CurrentEmodeProductType)

  ''  mValueItems = clsEnumsConstants.EnumToVIs(GetType(eProductType))

  ''  clsDEControlLoading.FillDERepComboVI(repoCategory, mValueItems)



  ''End Sub

  Private Sub repoCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repoCategory.SelectedIndexChanged
    ''Try
    ''  Dim mValueItem As clsValueItem
    ''  UpdateObject()
    ''  pFormController.SaveObject()
    ''  mValueItem = beCategory.EditValue
    ''  pFormController.CurrentEmodeProductType = mValueItem.ItemValue


    ''  ''pFormController.CurrentProductType = bargCategory.EditValue
    ''  pFormController.LoadMainCollection()
    ''  grdProductBase.DataSource = pFormController.ProductBaseInfos
    ''  grdProductBase.RefreshDataSource()
    ''  RefreshPCSubItemTypes()
    ''  RefreshAddBtn()
    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    ''End Try
  End Sub

  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)
    UctProductBaseDetail1.SetDetailsControlsReadonly(vReadOnly)

  End Sub
  Private Sub grpStockItemDetail_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpStockItemDetail.CustomButtonClick


    If pFormController.ProductBaseInfos.Count <> 0 Then ''If the user click on Edit

      Select Case e.Button.Properties.Tag

        Case eDetailButtons.Edit
          pFormController.LoadStockItemExtraDetails()

          '' RefreshAddBtn()

          If pFormController.CurrentProductBase IsNot Nothing Then
            pFormController.LockStockItem(pFormController.CurrentProductBase.ID)
            pFormController.IsLocked = True
          End If

          pCurrentDetailMode = eCurrentDetailMode.eEdit
          SetDetailsControlsReadonly(False)
          SetDetailFocus()
          RefreshPCSubItemTypes()
          RefreshControls()

          RefreshDetailButtons()



        Case eDetailButtons.Save

          If pFormController.CurrentProductBase IsNot Nothing Then
            UctProductBaseDetail1.UpdateObject()

            If UctProductBaseDetail1.cboSubItemType.SelectedIndex = -1 Then
              MessageBox.Show("No se ha seleccionado el sub tipo del producto. Por favor, ingrese un valor válido en la lista desplegable")
              gvProductBase.RefreshData()
              SetDetailsControlsReadonly(False)
              pCurrentDetailMode = eCurrentDetailMode.eView
            Else
              pFormController.SaveObject()
              gvProductBase.RefreshData()
              SetDetailsControlsReadonly(True)
              pCurrentDetailMode = eCurrentDetailMode.eView
            End If

          End If
          If pFormController.IsLocked Then
            pFormController.UnLockStockItem(pFormController.CurrentProductBase.ID)
            pFormController.IsLocked = False
          End If




      End Select
      RefreshDetailButtons()
    End If



  End Sub



  Private Sub SetDetailFocus()
    UctProductBaseDetail1.FocusDescription()
    '
  End Sub
  Public Sub LoadStockItemBOM()
    pFormController.LoadStockItemBOM()
    UctProductBaseDetail1.LoadStockItemBOM(pFormController.CurrentProductBase)
    'grdStockItemBOM.DataSource = pFormController.CurrentProductBase.StockItemBOMs
  End Sub
  Public Sub LoadProductBOMs()
    UctProductBaseDetail1.LoadProductBOMS(pFormController.CurrentProductBase)

  End Sub
  Private Sub RefreshPCSubItemTypes()

    Dim mStartActive As Boolean = pIsActive
    Dim mProductConstructionSubTypes As New colProductConstructionSubTypes

    pIsActive = False

    If pFormController.CurrentProductBase IsNot Nothing Then

      If pFormController.CurrentEmodeProductType = 0 Then
        pFormController.CurrentEmodeProductType = pFormController.CurrentProductBase.ItemType
      End If


      pFormController.LoadProductConstructionSubTypes(mProductConstructionSubTypes, pFormController.CurrentProductBase.ItemType)
      UctProductBaseDetail1.RefreshSubTypesOptions(mProductConstructionSubTypes)
      'clsDEControlLoading.FillDEComboVIi(cboSubItemType, mProductConstructionSubTypes)



    End If

    pIsActive = mStartActive
  End Sub

  Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
    If pIsActive Then
      pFormController.CurrentEmodeProductType = UctProductBaseDetail1.GetCurrentEmodeProductType
      pFormController.CurrentProductBase.ItemType = pFormController.CurrentEmodeProductType
      UctProductBaseDetail1.UpdateObject()
      RefreshPCSubItemTypes()
      RefreshControls()
    End If
  End Sub

  Private Sub gvStockItems_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles gvProductBase.BeforeLeaveRow
    RefreshControls()
    UctProductBaseDetail1.UpdateObject()

    If pFormController.IsAnyDirty And pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      If CheckSave(True) = False Then
        e.Allow = False
      End If
    End If
  End Sub

  Private Sub barbtnAddStockItemCat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbtnAddStockItemCat.ItemClick
    Try
      Dim mItem As BarItem = e.Item

      UctProductBaseDetail1.UpdateObject()
      pFormController.SaveObject()

      pFormController.CurrentEmodeProductType = mItem.Tag
      pFormController.LoadMainCollection()
      grdProductBase.DataSource = pFormController.ProductBaseInfos
      grdProductBase.RefreshDataSource()
      ''  RefreshAddBtn()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnAddStockItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddStockItem.ItemClick
    AddStockItemCat(sender, e)
  End Sub

  Private Sub repoStockItemOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repoStockItemOption.SelectedIndexChanged



    grdProductBase.RefreshDataSource()
  End Sub


  Private Sub RefreshGridAndKeepSelectedRow(ByVal vGridView As DevExpress.XtraGrid.Views.Grid.GridView)
    Dim mIndex As Integer = vGridView.GetDataSourceRowIndex(vGridView.FocusedRowHandle)
    vGridView.RefreshData()
    Dim rowHandle As Integer = vGridView.GetRowHandle(mIndex)
    vGridView.FocusedRowHandle = rowHandle
  End Sub



  Private Sub bbtnAddStructure_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnAddStructure.ItemClick
    pFormController.CurrentEmodeProductType = eProductType.StructureAF
    AddStockItemCat(sender, e)
  End Sub

  Private Sub bbtnAddProductInstallation_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnAddProductInstallation.ItemClick
    pFormController.CurrentEmodeProductType = eProductType.ProductInstallation
    AddStockItemCat(sender, e)
  End Sub







End Class
