Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock



Public Class frmProductBOMPicker
  Private pRTISGlobal As AppRTISGlobal

  Private pPickerProductBOM As clsPickerProductBOM
  Private pRemainOpen As Boolean
  Private pProductBase As dmProductBase
  Private pActive As Boolean
  Private pMode As ePickerMode

  Public Enum ePickerMode
    SinglePick = 1
    MultiPick = 2
  End Enum

  Public Property ProductBase As dmProductBase
    Get
      Return pProductBase
    End Get
    Set(value As dmProductBase)
      pProductBase = value
    End Set
  End Property


  Public Shared Function PickProducts(ByRef rPickerProductBOM As clsPickerProductBOM, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPickMode As ePickerMode) As Boolean
    Dim mfrm As frmProductBOMPicker
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    mfrm = New frmProductBOMPicker
    mfrm.pPickerProductBOM = rPickerProductBOM
    mfrm.pRTISGlobal = rRTISGlobal
    mfrm.pRemainOpen = True
    mfrm.pMode = vPickMode



    mfrm.ShowDialog()
    Return True
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerProductBOM As clsPickerProductBOM) As clsProductBaseInfo
    Dim mfrm As New frmProductBOMPicker
    Dim mRetVal As clsProductBaseInfo

    mfrm.pMode = ePickerMode.SinglePick
    mfrm.pPickerProductBOM = vPickerProductBOM
    mfrm.ShowDialog()

    If mfrm.pPickerProductBOM.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerProductBOM.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerProductBOM.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vPickerProductBOM As clsPickerProductBOM, ByVal vRemainOpen As Boolean, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As List(Of clsProductBaseInfo)
    Dim mfrm As New frmProductBOMPicker
    Dim mRetVal As New List(Of clsProductBaseInfo)

    mfrm.pMode = ePickerMode.MultiPick
    mfrm.pPickerProductBOM = vPickerProductBOM
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerProductBOM.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerProductBOM.SelectedObjects.Count > 0 Then
      For Each mItem As clsProductBaseInfo In mfrm.pPickerProductBOM.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function

  Private Sub frmPickerProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try
      pActive = False
      LoadCombo()
      grdItemList.DataSource = pPickerProductBOM.DataSource

      CreateTabs()
      SetCurrentTab(eProductType.StructureAF)

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

  End Sub


  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemSelect.ButtonClick
    Try
      Dim mProductBase As clsProductBaseInfo

      Select Case pMode
        Case ePickerMode.SinglePick

          mProductBase = TryCast(gvItemList.GetFocusedRow, clsProductBaseInfo)
          If mProductBase IsNot Nothing Then
            pPickerProductBOM.SelectedObjects.Add(mProductBase)
            Me.Close()
          End If

        Case ePickerMode.MultiPick
          mProductBase = TryCast(gvItemList.GetFocusedRow, clsProductBaseInfo)
          If mProductBase IsNot Nothing Then
            pPickerProductBOM.SelectedObjects.Add(mProductBase)
            If pRemainOpen = False Then Me.Close()
          End If
      End Select


      gvItemList.CloseEditor()
      RefeshTabCaption(pPickerProductBOM.CurrentCategory)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemRemove.ButtonClick
    Try
      Dim mItem As clsProductBaseInfo
      Dim mProductBaseInfos As New colProductBaseInfos
      Dim mSelectedItem As clsProductBaseInfo
      For Each mProductBaseInfo As clsProductBaseInfo In pPickerProductBOM.SelectedObjects
        mProductBaseInfos.Add(mProductBaseInfo)
      Next

      mItem = TryCast(gvItemList.GetFocusedRow, clsProductBaseInfo)

      If mItem IsNot Nothing Then
        mSelectedItem = mProductBaseInfos.ItemFromProductTypeAndID(mItem.ProductTypeID, mItem.ID)

        If mSelectedItem IsNot Nothing Then
          mProductBaseInfos.Remove(mSelectedItem)
          If pRemainOpen = False Then Me.Close()
        End If
      End If

      pPickerProductBOM.SelectedObjects.Clear()

      For Each mProductBaseInfo As clsProductBaseInfo In mProductBaseInfos
        pPickerProductBOM.SelectedObjects.Add(mProductBaseInfo)
      Next

      gvItemList.CloseEditor()
      RefeshTabCaption(pPickerProductBOM.CurrentCategory)
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
          Case gcSubItemType.Name
            Select Case mRow.Category

              Case eProductType.ProductInstallation, eProductType.ProductFurniture, eProductType.StructureAF
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), CType(mRow.ItemType, eProductType))
                e.Value = mText
              Case Else
                e.Value = ""

            End Select


        End Select


      End If
    End If

  End Sub

  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvItemList.CustomRowCellEdit
    Dim mRow As clsProductBaseInfo
    Dim mProductBaseInfos As New colProductBaseInfos

    For Each mProductBaseInfo As clsProductBaseInfo In pPickerProductBOM.SelectedObjects
      mProductBaseInfos.Add(mProductBaseInfo)
    Next

    mRow = TryCast(gvItemList.GetRow(e.RowHandle), clsProductBaseInfo)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcStockCode.Name Then

        If mProductBaseInfos.ItemFromProductTypeAndID(mRow.ProductTypeID, mRow.ID) IsNot Nothing Then
          e.RepositoryItem = repoItemRemove
        Else
          e.RepositoryItem = repoItemSelect
        End If

      End If

    End If
  End Sub

  Private Sub bbtnNewStockItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnNewStockItem.ItemClick

  End Sub

  Private Sub CreateTabs()
    Dim mVIs As colValueItems
    Dim mTabPage As DevExpress.XtraTab.XtraTabPage

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eProductType))
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

    SetCurrentTab(eProductType.ProductFurniture)

  End Sub

  Private Sub SetCurrentTab(ByVal vCategory As eProductType)
    For Each mTabPage As DevExpress.XtraTab.XtraTabPage In xtabCategories.TabPages
      If mTabPage.Tag IsNot Nothing AndAlso mTabPage.Tag = vCategory Then
        xtabCategories.SelectedTabPage = mTabPage
        grdItemList.Parent = mTabPage
        pPickerProductBOM.CurrentCategory = vCategory
        gvItemList.ActiveFilterString = "ProductTypeID = " & pPickerProductBOM.CurrentCategory
      End If
    Next

  End Sub

  Private Sub RefeshTabCaption(ByVal vCategory As eProductType)
    Dim mSelected As Integer = 0
    For Each mTabPage As DevExpress.XtraTab.XtraTabPage In xtabCategories.TabPages
      If mTabPage.Tag IsNot Nothing AndAlso mTabPage.Tag = vCategory Then
        mSelected = pPickerProductBOM.SelectedCount(vCategory)
        If mSelected = 0 Then
          mTabPage.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), vCategory)
        Else
          mTabPage.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), vCategory) & " (" & mSelected & ")"
        End If
      End If
    Next

  End Sub

  Private Sub xtabCategories_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles xtabCategories.SelectedPageChanged
    SetCurrentTab(e.Page.Tag)
  End Sub


End Class