Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock

Public Class frmPickerStockItem

  Private pPickerStockItem As clsPickerStockItem
  Private pRemainOpen As Boolean
  Private pStockItems As dmStockItem
  Private pFormController As fccStocktem



  Public Property StockItem As dmStockItem
    Get
      Return pStockItems
    End Get
    Set(value As dmStockItem)
      pStockItems = value
    End Set
  End Property



  Public Property FormController() As fccStocktem
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccStocktem)
      pFormController = value
    End Set
  End Property

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

    mfrm.pFormController = New fccStocktem(rDBConn, rRTISGlobal)


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


      ''  mOK = pFormController.LoadObject()

      LoadCombo()



      RefreshControls()


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



  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerStockItem.DataSource
    gvItemList.FocusedRowHandle = grdItemList.AutoFilterRowHandle
    gvItemList.FocusedColumn = gcStockCode
    gvItemList.ShowEditor()
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
    Dim mRetVal As dmStockItem
    Dim mCategories As New List(Of eStockItemCategory)
    mCategories.Add(eStockItemCategory.Abrasivos)
    mCategories.Add(eStockItemCategory.NailsAndBolds)
    mCategories.Add(eStockItemCategory.EPP)
    mCategories.Add(eStockItemCategory.Herramientas)
    mCategories.Add(eStockItemCategory.MatElect)
    mCategories.Add(eStockItemCategory.MatEmpaque)
    mCategories.Add(eStockItemCategory.MatVarios)
    mCategories.Add(eStockItemCategory.Metal)
    mCategories.Add(eStockItemCategory.PinturaYQuimico)
    mCategories.Add(eStockItemCategory.Laminas)
    mCategories.Add(eStockItemCategory.Repuestos)
    mCategories.Add(eStockItemCategory.Tapiceria)
    mCategories.Add(eStockItemCategory.VidrioYEspejo)
    mCategories.Add(eStockItemCategory.Herrajes)



    Try
      frmStockItem.GetNewStockItem(pFormController.DBConn, pFormController.RTISGlobal, mCategories)
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

End Class