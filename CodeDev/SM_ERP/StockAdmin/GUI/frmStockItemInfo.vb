Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base

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

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmStockItemInfo = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmStockItemInfo
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStockItemInfos(rDBConn, rRTISGlobal)

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

    pIsActive = mStartActive
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemInfos, gcCategory, mVIs)

  End Sub

  Private Sub gvStockItemInfos_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItemInfos.CustomUnboundColumnData
    Dim mRow As clsStockItemInfo
    Dim mVIs As New colValueItems

    Dim mText As String = ""
    mRow = TryCast(e.Row, clsStockItemInfo)
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

    RefreshControls()
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



End Class