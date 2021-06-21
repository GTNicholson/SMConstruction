Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmStockItemInfo

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCurrentDetailMode As eCurrentDetailMode
  Private pFormController As fccStockItemInfos

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
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

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsWood As Boolean)
    Dim mfrm As frmStockItemInfo = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmStockItemInfo
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStockItemInfos(rDBConn, rRTISGlobal, vIsWood)

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Private Sub frmStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    pIsActive = False
    pFormController.LoadObjects()

    grdStockItemInfos.DataSource = pFormController.StockItemInfos
    LoadCombos()

    RefreshControls()
    pIsActive = True
  End Sub

  Private Sub RefreshControls()

    Dim mStartActive As Boolean = pIsActive

    pIsActive = False

    If pFormController.IsWood Then
      gcThickness.Visible = True
      gcItemType.Visible = True
      gcSpecies.Visible = True
      gcPartNo.Visible = False
      gcSupplier.Visible = False
      gcTotalCubicMeter.Visible = True
      gcCategory.Visible = False

      gcItemType.Caption = "Tipo de Madera"
      gcActualWoodValueInventory.Visible = True
      gcCostWoodCost.Visible = True
      gcCostWoodCost.VisibleIndex = 4

      gcActualValueInventory.Visible = False
      gcStdCost.Visible = False
      CreateGroupSummary()


      gcCurrentInventory.ColumnEdit = repoPopUpWoodPalletItemInfo
      gcCurrentInventory.ShowButtonMode = ShowButtonModeEnum.ShowAlways

      repoPopUpWoodPalletItemInfo.PopupControl = popupWoodPalletInfo
      gvStockItemInfos.OptionsView.ShowGroupPanel = True
      UpdateCostByCostBookID()


      RefreshGridCurrency()


      gvStockItemInfos.RefreshData()
    Else
      gcLength.Visible = False
      gcWidth.Visible = False
      gcThickness.Visible = False
      gcSpecies.Visible = False
      gcSpecies.GroupIndex = -1
      gcSupplier.Visible = False
      gcPartNo.Visible = True
      gcTotalCubicMeter.Visible = False
      gcCategory.Visible = True
      gcCategory.GroupIndex = 1
      gcItemType.Caption = "Sub Categoría"
      gvStockItemInfos.OptionsView.ShowGroupPanel = True
      CreateCategoryGroupSummary()
      gcItemType.GroupIndex = -1
    End If

    pIsActive = mStartActive
  End Sub

  Private Sub CreateCategoryGroupSummary()
    Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
    gvStockItemInfos.GroupSummary.Clear()

    'gvStockItemInfos.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
    gvStockItemInfos.OptionsView.ShowFooter = True



    item.FieldName = "Category"
    item.SummaryType = DevExpress.Data.SummaryItemType.Sum
    item.DisplayFormat = "Valor Total = {C$#,##0.00;;#}"
    gvStockItemInfos.GroupSummary.Add(item)

    gcCategory.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    gcCategory.SummaryItem.DisplayFormat = "{0:n3}"
    gcCategory.SummaryItem.FieldName = "ActualValueInventory"

    gvStockItemInfos.GroupSummary.Add(SummaryItemType.Sum, "ActualValueInventory")

  End Sub

  Private Sub CreateGroupSummary()
    Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
    gvStockItemInfos.GroupSummary.Clear()

    'gvStockItemInfos.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
    gvStockItemInfos.OptionsView.ShowFooter = True



    item.FieldName = "SpeciesDesc"
    item.SummaryType = DevExpress.Data.SummaryItemType.Sum
    item.DisplayFormat = "Total PT Especie{0:n3}"
    gvStockItemInfos.GroupSummary.Add(item)

    gcCurrentInventory.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    gcCurrentInventory.SummaryItem.DisplayFormat = "{0:n3}"
    gcCurrentInventory.SummaryItem.FieldName = "CurrentInventory"

    gvStockItemInfos.GroupSummary.Add(SummaryItemType.Sum, "CurrentInventory")
  End Sub

  Private Sub RefreshGridCurrency()

    gvStockItemInfos.Columns("ActualWoodValueInventory").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    gvStockItemInfos.Columns("ActualWoodValueInventory").DisplayFormat.FormatString = "$#,##0.00;;#"
    gvStockItemInfos.Columns("ActualWoodValueInventory").SummaryItem.DisplayFormat = "{0:$#,##0.00;;#}"

    gvStockItemInfos.Columns("CostWoodCost").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    gvStockItemInfos.Columns("CostWoodCost").DisplayFormat.FormatString = "$#,##0.00;;#"
    ' gvStockItemInfos.Columns("StdCost").SummaryItem.DisplayFormat = "{0:$#,##0.00;;#}"

  End Sub

  Private Sub UpdateCostByCostBookID()

    For Each mSI As clsStockItemInfo In pFormController.StockItemInfos
      mSI.CostWoodCost = pFormController.GetCostByStockItemIDM(mSI.StockItem.StockItemID)

      Select Case mSI.StockItem.CostUoM
        Case eUoM.MT3
          mSI.CostWoodCost = mSI.CostWoodCost / 423.77
      End Select
    Next

  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemInfos, gcCategory, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Supplier)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemInfos, gcSupplier, mVIs)

  End Sub

  Private Sub gvStockItemInfos_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItemInfos.CustomUnboundColumnData
    Dim mRow As clsStockItemInfo
    Dim mVIs As New colValueItems
    ''Dim mSubTypes As colSubItemTypes
    ''Dim mSubType As clsSubItemType
    ''Dim mSubItemTypes As colStockItemType

    Dim mText As String = ""
    ''Dim mSISubItemTypeIron As clsStockSubItemTypeIronmongery
    mRow = TryCast(e.Row, clsStockItemInfo)
    If mRow IsNot Nothing Then
      If e.IsGetData Then
        Select Case e.Column.Name
          Case gcItemType.Name
            Select Case mRow.Category

              Case eStockItemCategory.Abrasivos
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeAbrasivos), CType(mRow.ItemType, eStockItemTypeAbrasivos.eStockItemAbrasivos))
                e.Value = mText


              Case eStockItemCategory.Fixings
                mText = eStockItemTypeFixings.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.BrickWork
                mText = eStockItemTypeBrickWork.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.EPP
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeEPP), CType(mRow.ItemType, eStockItemTypeEPP.eStockItemMaterialEPP))
                e.Value = mText

              Case eStockItemCategory.Herrajes
                mText = eStockItemTypeHerrajes.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Herramientas
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerramientas), CType(mRow.ItemType, eStockItemTypeHerramientas.eStockItemMaterialHerramientas))
                e.Value = mText

              Case eStockItemCategory.MatElect
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialElectrico), CType(mRow.ItemType, eStockItemTypeMaterialElectrico.eStockItemMaterialElectrico))
                e.Value = mText


              Case eStockItemCategory.MatEmpaque
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialEmpaque), CType(mRow.ItemType, eStockItemTypeMaterialEmpaque.StockItemMaterialEmpaque))
                e.Value = mText

              Case eStockItemCategory.MatVarios
                mText = eStockItemTypeMatVarioss.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText


              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText


              Case eStockItemCategory.PinturaYQuimico
                mText = eStockItemTypePintura.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Laminas
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeLamina), CType(mRow.ItemType, eStockItemTypeLamina.eStockItemLamina))
                e.Value = mText


              Case eStockItemCategory.Repuestos
                mText = eStockItemTypeRepuestosYPartes.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Tapiceria
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTapiceria), CType(mRow.ItemType, eStockItemTypeTapiceria.eStockItemTapiceria))
                e.Value = mText

              Case eStockItemCategory.VidrioYEspejo
                mText = eStockItemTypeVidrioYEspejo.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Timber

                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTimberWood), CType(mRow.ItemType, eStockItemTypeTimberWood.eStockItemTimberWood))
                e.Value = mText
              Case Else
                e.Value = ""

            End Select


        End Select


      End If
    End If

    '  RefreshControls()
  End Sub

  Private Sub frmStockItem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub

  Private Shared Function GetFormIfLoaded() As frmStockItemInfo


    Dim mfrmWanted As frmStockItemInfo = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockItemInfo
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmStockItemInfo Then
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

  Private Sub repitbtCurrentInventory_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repitbtCurrentInventory.ButtonClick
    Try
      If pFormController.CurrentStockItemInfo IsNot Nothing Then
        Dim mfrm As New frmStockAdjust

        If mfrm.ShowDialog = DialogResult.OK Then
          Dim mDate As DateTime = mfrm.SelectedDate
          Dim mQty As Decimal = mfrm.SelectedQty
          Dim mNotes As String = mfrm.Notes

          Select Case mfrm.TransactionType
            Case eTransactionType.Adjustment
              pFormController.ApplyStockAdjust(pFormController.CurrentStockItemInfo.StockItem, 1, eTransactionType.Adjustment, mQty, mDate, mNotes)
            Case eTransactionType.Amendment
              pFormController.ApplyStockAdjust(pFormController.CurrentStockItemInfo.StockItem, 1, eTransactionType.Amendment, mQty, mDate, mNotes)
          End Select
          pFormController.RefreshStockItemCurrentInventory(pFormController.CurrentStockItemInfo)
          gvStockItemInfos.CloseEditor()
          gvStockItemInfos.UpdateCurrentRow()
        End If

        mfrm = Nothing
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvStockItemInfos_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvStockItemInfos.FocusedRowObjectChanged
    Try
      Dim mSII As clsStockItemInfo
      If gvStockItemInfos.IsDataRow(e.FocusedRowHandle) Then
        mSII = TryCast(e.Row, clsStockItemInfo)
        pFormController.CurrentStockItemInfo = mSII
      Else
        pFormController.CurrentStockItemInfo = Nothing
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub grpItemDetail_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpItemDetail.CustomButtonClick
    Select Case e.Button.Properties.Tag
      Case "Export"
        Dim mFileName As String = "Exportar Lista" + ".xlsx"
        If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
          gvStockItemInfos.ExportToXlsx(mFileName)
        End If
      Case "Reload"
        RefreshControls()
        pFormController.ClearObjects()
        pFormController.LoadObjects()

        UpdateCostByCostBookID()

        grdStockItemInfos.DataSource = pFormController.StockItemInfos



        LoadCombos()


    End Select

  End Sub


  Private Sub repoPopupPOAllocationItems_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles repoPopupPOAllocationItems.QueryPopUp
    Dim mAllocations As New colPurchaseOrderItemAllocationInfos

    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemInfo

    mSIP = gvStockItemInfos.GetFocusedRow
    mStockItemID = mSIP.StockItemID

    pFormController.LoadPurchaseOrderItemAllocationInfos(mAllocations, mStockItemID)
    grdPOItemInfo.DataSource = mAllocations
  End Sub

  Private Sub repoPopuMaterialRequirement_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repoPopuMaterialRequirement.QueryPopUp
    Dim mMaterialRequirementInfos As New colMaterialRequirementInfos

    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemInfo

    mSIP = gvStockItemInfos.GetFocusedRow
    mStockItemID = mSIP.StockItemID

    pFormController.LoadMaterialRequirementInfos(mMaterialRequirementInfos, mStockItemID)
    grdStockItemAllocations.DataSource = mMaterialRequirementInfos
  End Sub

  Private Sub repoPopUpWoodPalletItemInfo_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repoPopUpWoodPalletItemInfo.QueryPopUp
    Dim mWoodPalletItemContents As New colWoodPalletItemContents
    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemInfo
    Dim mWoodPalletItemInfos As colWoodPalletItemInfos
    Dim mBalanceQty As Decimal = 0
    Dim mDatasource As New colWoodPalletItemContents

    Dim mWhere As String = ""
    mSIP = gvStockItemInfos.GetFocusedRow
    mStockItemID = mSIP.StockItem.StockItemID

    If mStockItemID > 0 Then
      mWhere = "StockItemID = " & mStockItemID
      pFormController.LoadWoodPalletItemContentByWhere(mWoodPalletItemContents, mWhere)

      If mWoodPalletItemContents IsNot Nothing Then

        For Each mWPIC In mWoodPalletItemContents

          mBalanceQty = mWPIC.SUMQuantity - mWPIC.SUMQuantityUsed

          If mBalanceQty > 0 Then

            mWoodPalletItemInfos = New colWoodPalletItemInfos
            pFormController.LoadWoodPalletItemInfosByStockItemID(mWoodPalletItemInfos, mWPIC.StockItemID, mWPIC.WoodPalletID)
            mWPIC.WoodPalletItems = mWoodPalletItemInfos
            mDatasource.Add(mWPIC)
          End If
        Next
        grdWoodPalletInfo.DataSource = mDatasource
      End If


    End If
    'pFormController.LoadWoodPalletItemInfosByStockItemID(mWoodPalletItemInfos, mStockItemID)


  End Sub
End Class