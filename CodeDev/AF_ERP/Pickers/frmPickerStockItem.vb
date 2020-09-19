﻿Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock



Public Class frmPickerStockItem
  Private pRTISGlobal As AppRTISGlobal

  Private pPickerStockItem As clsPickerStockItem
  Private pRemainOpen As Boolean
  Private pStockItems As dmStockItem
  Private pActive As Boolean


  Public Property StockItem As dmStockItem
    Get
      Return pStockItems
    End Get
    Set(value As dmStockItem)
      pStockItems = value
    End Set
  End Property


  Public Shared Function PickPurchaseOrderItems(ByRef rPickerStockItem As clsPickerStockItem, ByRef rRTISGlobal As clsRTISGlobal) As Boolean
    Dim mfrm As frmPickerStockItem
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    mfrm = New frmPickerStockItem
    mfrm.pPickerStockItem = rPickerStockItem
    mfrm.pRTISGlobal = rRTISGlobal
    mfrm.pRemainOpen = True




    mfrm.ShowDialog()
    Return True
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerStockItem As clsPickerStockItem) As intStockItemDef
    Dim mfrm As New frmPickerStockItem
    Dim mRetVal As intStockItemDef = Nothing

    mfrm.pPickerStockItem = vPickerStockItem
    mfrm.ShowDialog()

    If mfrm.pPickerStockItem.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerStockItem.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerStockItem.SelectedObjects(0)
    End If

    Return mRetVal
  End Function



  Public Shared Function OpenPickerMulti(ByVal vPickerStockItem As clsPickerStockItem, ByVal vRemainOpen As Boolean, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As List(Of intStockItemDef)
    Dim mfrm As New frmPickerStockItem
    Dim mRetVal As New List(Of intStockItemDef)


    mfrm.pPickerStockItem = vPickerStockItem
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerStockItem.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerStockItem.SelectedObjects.Count > 0 Then
      For Each mItem As intStockItemDef In mfrm.pPickerStockItem.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If

    With mfrm.StockItem


    End With

    Return mRetVal
  End Function

  Private Sub frmPickerStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try
      pActive = False
      LoadCombo()
      grdItemList.DataSource = pPickerStockItem.DataSource

      CreateTabs()
      SetCurrentTab(eStockItemCategory.Abrasivos)

      pActive = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema en cargar el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombo()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCategory, mVIs)

  End Sub


  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemSelect.ButtonClick
    Try
      Dim mItem As intStockItemDef
      mItem = TryCast(gvItemList.GetFocusedRow, intStockItemDef)
      If mItem IsNot Nothing Then
        pPickerStockItem.SelectedObjects.Add(mItem)
        If pRemainOpen = False Then Me.Close()
      End If
      gvItemList.CloseEditor()
      RefeshTabCaption(pPickerStockItem.CurrentCategory)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemRemove.ButtonClick
    Try
      Dim mItem As intStockItemDef
      mItem = TryCast(gvItemList.GetFocusedRow, intStockItemDef)
      If mItem IsNot Nothing Then
        pPickerStockItem.SelectedObjects.Remove(mItem)
        If pRemainOpen = False Then Me.Close()
      End If
      gvItemList.CloseEditor()
      RefeshTabCaption(pPickerStockItem.CurrentCategory)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvItemList_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvItemList.CustomUnboundColumnData
    Dim mRow As dmStockItem
    Dim mVIs As New colValueItems

    Dim mText As String = ""
    mRow = TryCast(e.Row, dmStockItem)
    If mRow IsNot Nothing Then
      If e.IsGetData Then
        Select Case e.Column.Name
          Case gcItemType.Name
            Select Case mRow.Category

              Case eStockItemCategory.Abrasivos
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeAbrasivos), CType(mRow.ItemType, eStockItemTypeAbrasivos.eStockItemAbrasivos))
                e.Value = mText
              Case eStockItemCategory.Herrajes
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerrajes), CType(mRow.ItemType, eStockItemTypeHerrajes.eStockItemHerrajes))
                e.Value = mText

              Case eStockItemCategory.MatElect
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialElectrico), CType(mRow.ItemType, eStockItemTypeMaterialElectrico.eStockItemMaterialElectrico))
                e.Value = mText


              Case eStockItemCategory.MatEmpaque
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialEmpaque), CType(mRow.ItemType, eStockItemTypeMaterialEmpaque.StockItemMaterialEmpaque))
                e.Value = mText

              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText

              Case eStockItemCategory.NailsAndBolds
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeNailsAndBolts), CType(mRow.ItemType, eStockItemTypeNailsAndBolts.eStockItemNailAndBolts))
                e.Value = mText

              Case eStockItemCategory.Repuestos
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeRepuestosYPartes), CType(mRow.ItemType, eStockItemTypeRepuestosYPartes.eStockItemRepuestosYPartes))
                e.Value = mText

              Case eStockItemCategory.Tapiceria
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTapiceria), CType(mRow.ItemType, eStockItemTypeTapiceria.eStockItemTapiceria))
                e.Value = mText

              Case eStockItemCategory.VidrioYEspejo
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeVidrioYEspejo), CType(mRow.ItemType, eStockItemTypeVidrioYEspejo.eStockItemVidrioYEspejo))
                e.Value = mText

              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText

              Case Else
                e.Value = ""

            End Select


        End Select


      End If
    End If

  End Sub

  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvItemList.CustomRowCellEdit
    Dim mRow As dmStockItem
    mRow = TryCast(gvItemList.GetRow(e.RowHandle), dmStockItem)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcStockCode.Name Then

        If pPickerStockItem.SelectedObjects.Contains(mRow) Then
          e.RepositoryItem = repoItemRemove
        Else
          e.RepositoryItem = repoItemSelect
        End If

      End If

    End If
  End Sub

  Private Sub bbtnNewStockItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnNewStockItem.ItemClick

    Dim mCategories As New List(Of eStockItemCategory)
    Dim mCurrentID As Integer
    Dim mCurrentItem As dmStockItem = Nothing


    Try
      mCategories.Add(pPickerStockItem.CurrentCategory)

      mCurrentID = frmStockItem.OpenAsModalGetID(pPickerStockItem.DBConn, pPickerStockItem.RTISGlobal, mCategories, pPickerStockItem.RTISGlobal.StockItemRegistry)

      Dim mSIs = New List(Of dmStockItem)
      For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pPickerStockItem.RTISGlobal.StockItemRegistry.StockItemsDict
        mSIs.Add(mItem.Value)
        If mItem.Value.StockItemID = mCurrentID Then
          mCurrentItem = mItem.Value
        End If
      Next
      pPickerStockItem.DataSource = mSIs
      grdItemList.DataSource = pPickerStockItem.DataSource
      gvItemList.RefreshData()

      If mCurrentItem IsNot Nothing Then
        gvItemList.FocusedRowHandle = gvItemList.FindRow(mCurrentItem)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub CreateTabs()
    Dim mVIs As colValueItems
    Dim mTabPage As DevExpress.XtraTab.XtraTabPage

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    Do While xtabCategories.TabPages.Count > 1
      xtabCategories.TabPages.RemoveAt(xtabCategories.TabPages.Count - 1)
    Loop

    For Each mVI As clsValueItem In mVIs
      mTabPage = New DevExpress.XtraTab.XtraTabPage
      mTabPage.Text = mVI.DisplayValue
      mTabPage.Tag = mVI.ItemValue
      xtabCategories.TabPages.Add(mTabPage)
    Next

    For Each mTabPage In xtabCategories.TabPages
      If mTabPage.Tag Is Nothing OrElse mTabPage.Tag = 0 Then
        mTabPage.PageVisible = False
      Else
        RefeshTabCaption(mTabPage.Tag)
      End If
    Next

    SetCurrentTab(eStockItemCategory.Abrasivos)

  End Sub

  Private Sub SetCurrentTab(ByVal vCategory As eStockItemCategory)
    For Each mTabPage As DevExpress.XtraTab.XtraTabPage In xtabCategories.TabPages
      If mTabPage.Tag IsNot Nothing AndAlso mTabPage.Tag = vCategory Then
        xtabCategories.SelectedTabPage = mTabPage
        grdItemList.Parent = mTabPage
        pPickerStockItem.CurrentCategory = vCategory
        gvItemList.ActiveFilterString = "Category = " & pPickerStockItem.CurrentCategory
      End If
    Next

  End Sub

  Private Sub RefeshTabCaption(ByVal vCategory As eStockItemCategory)
    Dim mSelected As Integer = 0
    For Each mTabPage As DevExpress.XtraTab.XtraTabPage In xtabCategories.TabPages
      If mTabPage.Tag IsNot Nothing AndAlso mTabPage.Tag = vCategory Then
        mSelected = pPickerStockItem.SelectedCount(vCategory)
        If mSelected = 0 Then
          mTabPage.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), vCategory)
        Else
          mTabPage.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), vCategory) & " (" & mSelected & ")"
        End If
      End If
    Next

  End Sub

  Private Sub xtabCategories_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles xtabCategories.SelectedPageChanged
    SetCurrentTab(e.Page.Tag)
  End Sub


End Class