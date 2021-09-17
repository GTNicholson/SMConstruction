Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmHomePurchasing

  Private pFormController As fccHomePurchasing
  Private Shared sActiveForms As Collection



  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmHomePurchasing = Nothing
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    '' Add code here if need to check if a Detail Form for this ID is already open
    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmHomePurchasing
      mfrm.pFormController = New fccHomePurchasing
      mfrm.pFormController.DBConn = rUserSession.CreateMainDBConn
      mfrm.pFormController.RTISGlobal = rRTISGlobal

      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmHomePurchasing
    Dim mfrmWanted As frmHomePurchasing = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmHomePurchasing
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmHomePurchasing Then
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


  Private Sub LoadData()
    lblUserName.Text = My.Application.RTISUserSession.UserName


    pFormController.LoadPurchaseOrderInfosUnpaid()
    pFormController.LoadPurchaseOrderInfosCurrentMonth()
    pFormController.LoadPODeliveryInfosThisWeek()

    grdPurchaseOrderUnpaid.DataSource = pFormController.PurchaseOrderInfoUnpaids
    chrPurchaseOrderCategory.DataSource = pFormController.PurchaseOrderCategoryMonthlys

    grdSalesTracking.DataSource = pFormController.PODeliveryInfos
  End Sub

  Private Sub frmHomeManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
    LoadData()
  End Sub
  Private Sub RepositoryItemButtonOpenPO_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonOpenPO.ButtonClick
    Dim mPOInfo As clsPurchaseOrderInfo
    Try
      mPOInfo = TryCast(gvPurchaseOrderInfoUnpaid.GetFocusedRow, clsPurchaseOrderInfo)

      If mPOInfo IsNot Nothing Then

        'frmPurchaseOrder.OpenFormMDI(mPOInfo.PurchaseOrderID, pFormController.DBConn, AppRTISGlobal.GetInstance, Me.ParentForm)


      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try

  End Sub




  Private Sub btnRefreshData_Click(sender As Object, e As EventArgs) Handles btnRefreshData.Click

    LoadData()
  End Sub

End Class