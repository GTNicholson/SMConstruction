Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements



Public Class frmListToStockTake
  Private pDBConn As clsDBConnBase
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCategory As Integer
  Private pItemType As Integer
  Private pStockItemEditors As colStockTakeItemEditors
  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rStockItemEditors As colStockTakeItemEditors)
    Dim mfrm As frmListToStockTake = Nothing

    mfrm = GetFormIfLoaded()
    mfrm.pDBConn = rDBConn
    mfrm.pStockItemEditors = rStockItemEditors
    mfrm.Show()


  End Sub
  Private Shared Function GetFormIfLoaded() As frmListToStockTake


    Dim mfrmWanted As frmListToStockTake = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmListToStockTake
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmListToStockTake Then
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

  Private Sub frmStockItem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub

  Private Sub frmListToStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pCategory = -1
    pItemType = -1
    LoadCombos()
  End Sub

  Private Sub LoadCombos()

    Dim mVIs As colValueItems
    mVIs = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboCategory, mVIs)


  End Sub

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged



    pCategory = clsDEControlLoading.GetDEComboValue(cboCategory)

    RefreshCategorySpecificControls(pCategory)

  End Sub

  Private Sub cboItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemType.SelectedIndexChanged



    pItemType = clsDEControlLoading.GetDEComboValue(cboItemType)



  End Sub


  Private Sub RefreshCategorySpecificControls(ByVal vCategory As Integer)

    Select Case vCategory

      Case eStockItemCategory.Abrasivos

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeAbrasivos.GetInstance.ValueItems)

      Case eStockItemCategory.Fixings

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeFixings.GetInstance.ValueItems)


      Case eStockItemCategory.EPP
        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeEPP.GetInstance.ValueItems)


      Case eStockItemCategory.Herrajes


        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerrajes.GetInstance.ValueItems)
      Case eStockItemCategory.Herramientas


        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerramientas.GetInstance.ValueItems)



      Case eStockItemCategory.MatElect

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialElectrico.GetInstance.ValueItems)



      Case eStockItemCategory.MatEmpaque

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialEmpaque.GetInstance.ValueItems)


      Case eStockItemCategory.Plumbing

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePlumbings.GetInstance.ValueItems)

      Case eStockItemCategory.MatVarios

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMatVarioss.GetInstance.ValueItems)

      Case eStockItemCategory.Metal

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMetales.GetInstance.ValueItems)




      Case eStockItemCategory.PinturaYQuimico

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePintura.GetInstance.ValueItems)


      Case eStockItemCategory.Laminas

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeLamina.GetInstance.ValueItems)


      Case eStockItemCategory.Repuestos

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeRepuestosYPartes.GetInstance.ValueItems)



      Case eStockItemCategory.Tapiceria

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeTapiceria.GetInstance.ValueItems)



      Case eStockItemCategory.VidrioYEspejo

        clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeVidrioYEspejo.GetInstance.ValueItems)


    End Select


  End Sub

  Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
    Dim mReport As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mDataSource As New colStockTakeItemEditors
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Dim mRepTools As DevExpress.XtraReports.UI.ReportPrintTool

    For Each mStockTakeItemEditor As clsStockTakeItemEditor In pStockItemEditors

      If pCategory > 0 And pItemType <= 0 Then
        If mStockTakeItemEditor.StockItem.Category = pCategory Then
          mDataSource.Add(mStockTakeItemEditor)
        End If

      ElseIf pItemType > 0 And pCategory <= 0 Then
        If mStockTakeItemEditor.StockItem.ItemType = pItemType Then
          mDataSource.Add(mStockTakeItemEditor)
        End If

      Else
        If mStockTakeItemEditor.StockItem.ItemType = pItemType And mStockTakeItemEditor.StockItem.Category = pCategory Then
          mDataSource.Add(mStockTakeItemEditor)
        End If
      End If


    Next


    If mDataSource.Count > 0 Then
      mReport = repoListToStockTake.GenerateReport(mDataSource)

      mRepTools = New DevExpress.XtraReports.UI.ReportPrintTool(mReport)
      mRepTools.ShowPreviewDialog()

      mReport.Dispose()
    End If

    Me.Activate()

  End Sub
End Class