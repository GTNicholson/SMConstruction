Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

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
      gcItemType.Caption = "Sub Categoría"
      gvStockItemInfos.OptionsView.ShowGroupPanel = False
      gcItemType.GroupIndex = -1
    End If

    pIsActive = mStartActive
  End Sub

  Private Sub RefreshGridCurrency()

    gvStockItemInfos.Columns("ActualValueInventory").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    gvStockItemInfos.Columns("ActualValueInventory").DisplayFormat.FormatString = "$#,##0.00;;#"
    gvStockItemInfos.Columns("ActualValueInventory").SummaryItem.DisplayFormat = "{0:$#,##0.00;;#}"

    gvStockItemInfos.Columns("StdCost").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    gvStockItemInfos.Columns("StdCost").DisplayFormat.FormatString = "$#,##0.00;;#"
    ' gvStockItemInfos.Columns("StdCost").SummaryItem.DisplayFormat = "{0:$#,##0.00;;#}"

  End Sub

  Private Sub UpdateCostByCostBookID()

    For Each mSI As clsStockItemInfo In pFormController.StockItemInfos
      mSI.StockItem.StdCost = pFormController.GetCostByStockItemID(mSI.StockItem.StockItemID)
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


              Case eStockItemCategory.NailsAndBolds
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeNailsAndBolts), CType(mRow.ItemType, eStockItemTypeNailsAndBolts.eStockItemNailAndBolts))
                e.Value = mText


              Case eStockItemCategory.EPP
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeEPP), CType(mRow.ItemType, eStockItemTypeEPP.eStockItemMaterialEPP))
                e.Value = mText

              Case eStockItemCategory.Herrajes
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerrajes), CType(mRow.ItemType, eStockItemTypeHerrajes.eStockItemHerrajes))
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
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMatVarios), CType(mRow.ItemType, eStockItemTypeMatVarios.eStockItemMaterialMatVarios))
                e.Value = mText


              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText


              Case eStockItemCategory.PinturaYQuimico
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypePintura), CType(mRow.ItemType, eStockItemTypePintura.eStockItemPintura))
                e.Value = mText

              Case eStockItemCategory.Laminas
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeLamina), CType(mRow.ItemType, eStockItemTypeLamina.eStockItemLamina))
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
        pFormController.ClearObjects()
        pFormController.LoadObjects()

        grdStockItemInfos.DataSource = pFormController.StockItemInfos
        LoadCombos()

        RefreshControls()
    End Select

  End Sub


  Private Sub repoPopupPOAllocationItems_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles repoPopupPOAllocationItems.QueryPopUp
    Dim mAllocations As New colPurchaseOrderItemAllocationInfo

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
    Dim mWoodPallets As New colWoodPalletItemInfos

    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemInfo

    mSIP = gvStockItemInfos.GetFocusedRow
    mStockItemID = mSIP.StockItem.StockItemID

    pFormController.LoadWoodPalletItemInfosByStockItemID(mWoodPallets, mStockItemID)
    grdWoodPalletInfo.DataSource = mWoodPallets
  End Sub
End Class