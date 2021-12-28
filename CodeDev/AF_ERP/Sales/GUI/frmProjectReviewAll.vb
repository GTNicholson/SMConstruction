
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmProjectReviewAll
  Private pFormController As fccProjectReviewAll
  Private Shared sActiveForms As Collection

  Public Property FormController As fccProjectReviewAll
    Get
      Return pFormController
    End Get
    Set(value As fccProjectReviewAll)
      pFormController = value
    End Set
  End Property
  Public Shared Sub OpenModal(ByRef rDBConn As clsDBConnBase)
    Dim mfrm As frmProjectReviewAll
    mfrm = New frmProjectReviewAll
    mfrm.pFormController = New fccProjectReviewAll(rDBConn)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmProjectReviewAll_Load(sender As Object, e As EventArgs) Handles Me.Load

    LoadCombos()
    RefreshControls()
    Me.Text = "Revisión de Proyectos"

    clsDEControlLoading.SetDECombo(cboSalesOrderType, eOrderType.Sales)
    clsDEControlLoading.SetDECombo(cboStatus, 0)

  End Sub

  Private Sub LoadCombos()
    Dim mColValueItems As New colValueItems
    Dim mVI As clsValueItem

    For Each mVI In clsEnumsConstants.EnumToVIs(GetType(eOrderType))
      Select Case mVI.ItemValue
        Case eOrderType.Furnitures, eOrderType.Sales
          mColValueItems.Add(mVI)
      End Select
    Next
    clsDEControlLoading.FillDEComboVI(cboSalesOrderType, mColValueItems)

    mColValueItems = New colValueItems
    mVI = New clsValueItem
    mVI.ItemValue = 0
    mVI.DisplayValue = "Todos"
    mColValueItems.Add(mVI)
    For Each mVI In clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus))
      Select Case mVI.ItemValue
        Case eSalesOrderstatus.EnProgreso, eSalesOrderstatus.Completed
          mColValueItems.Add(mVI)
      End Select
    Next
    clsDEControlLoading.FillDEComboVI(cboStatus, mColValueItems)


  End Sub

  Private Sub RefreshControls()
    Dim mStartDate As Date

    mStartDate = New Date(Now.Year, 1, 1)

    dteStartDate.DateTime = mStartDate.Date
    dteEndDate.DateTime = Now.Date


  End Sub

  Private Sub LoadGrids()

    grdSalesOrderPhaseItemInfos.DataSource = pFormController.SalesOrderPhaseItemInfos
    chrSalesProjectCost.DataSource = pFormController.SalesOrderProjectReviews.OrderByDescending(Function(s) s.LineValue).Take(5).ToList

    grdSpeciesByProject.DataSource = pFormController.WoodPalletItemInfosPicked
    chrWoodPalletItemInfo.DataSource = pFormController.WoodPalletItemInfosPicked

    grdTimeSheetEntry.DataSource = pFormController.TimeSheetProjects
    chrTimeSheet.DataSource = pFormController.TimeSheetProjects

    chrOtherExpenses.DataSource = pFormController.MaterialsByCategories
    grdMaterials.DataSource = pFormController.MaterialsByCategories

  End Sub

  Public Shared Sub OpenForm(ByVal vRTISGlobal As AppRTISGlobal, ByVal vDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vMDIForm As Form)
    Dim mfrm As frmProjectReviewAll = Nothing

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmProjectReviewAll
      mfrm.pFormController = New fccProjectReviewAll(vDBConn)
      mfrm.MdiParent = vMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmProjectReviewAll
    Dim mfrmWanted As frmProjectReviewAll = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmProjectReviewAll
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmProjectReviewAll Then
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

  Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

    pFormController.StartDate = dteStartDate.DateTime
    pFormController.EndDate = dteEndDate.DateTime
    pFormController.OrderType = clsDEControlLoading.GetDEComboValue(cboSalesOrderType)
    pFormController.OrderStatus = clsDEControlLoading.GetDEComboValue(cboStatus)

    pFormController.LoadDataRef()
    LoadGrids()

  End Sub
End Class