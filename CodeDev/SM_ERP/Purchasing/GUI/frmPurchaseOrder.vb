Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmPurchaseOrder
  Private pFormController As fccPurchaseOrder
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmPurchaseOrder = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmPurchaseOrder
      mfrm.pFormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub


  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode)
    Dim mfrm As New frmPurchaseOrder
    mfrm.FormController = New fccPurchaseOrder(rDBConn, rRTISGlobal)
    mfrm.FormController.DBConn = rDBConn
    mfrm.FormController.RTISGlobal = rRTISGlobal
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.FormMode = vFormMode
    mfrm.Owner = rParentForm
    mfrm.ShowDialog()
    If mfrm.ExitMode = Windows.Forms.DialogResult.Yes Then
      ''vPrimaryKeyID = mfrm.FormController.PrimaryKeyID - Problem with .FormController being set to nothing
    End If
    mfrm.FormController = Nothing
    mfrm.Owner = Nothing
    mfrm.Dispose()
    mfrm = Nothing
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmPurchaseOrder
    Dim mfrmWanted As frmPurchaseOrder = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPurchaseOrder
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.FormController.PrimaryKeyID = vPrimaryKeyID Then
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

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub frmDetailForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

  End Sub

  Private Sub frmDetailForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    FormController.UpdateCOMOs()
    FormController.ClearObjects()
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Public Property FormController() As fccPurchaseOrder
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPurchaseOrder)
      pFormController = value
    End Set
  End Property

  Private Sub frmDetailForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub frmDetailForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

  End Sub

  Private Sub frmDetailForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObject()
      grdPurchaseOrderItems.DataSource = pFormController.PurchaseOrder.PurchaseOrderItems
      LoadCombo()
      RefreshControls()
      If mOK Then RefreshControls()

      ''If mOK Then SetupUserPermissions()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True

  End Sub

  Private Sub LoadCombo()

  End Sub



  Private Sub SetupUserPermissions()
    'Dim mPermisionLevel As ePermissionCode
    'mPermisionLevel = pDBConn.RTISUser.ActivityPermissions.GetActivityPermission(eActivityCode.UserConfig)


  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()

    If pFormController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Changes have been made. Do you wish to save them?", MsgBoxStyle.YesNoCancel)
        Select Case mResponse
          Case MsgBoxResult.Yes
            mSaveRequired = True
            mRetVal = False
            ExitMode = Windows.Forms.DialogResult.Yes
          Case MsgBoxResult.No
            mSaveRequired = False
            mRetVal = True
            ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
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
        mRetVal = pFormController.SaveObject()
        'TODO - If mRetVal then AddHandler InstanceData to  BrowseTracker
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub RefreshControls()
    ' Check User Permissions here
    Dim mStartActive As Boolean = pIsActive
    Dim mSupplier As dmSupplier

    pIsActive = False

    ''Populate controls with data for the current object/record
    ''Reposition Combos
    pIsActive = mStartActive
  End Sub

  Private Sub UpdateObject()

  End Sub

  ''Private Sub ControlForceValidateExample()
  ''  '' knock on effects of a property/control change - example event template
  ''  Try
  ''    If pIsActive Then
  ''      UpdateObject()
  ''
  ''      ''Knock-on effects
  ''
  ''      RefreshControls()
  ''    End If
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''  End Try
  ''End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
    If vWithCheck Then
      If CheckSave(True) Then 'Changed from False 20150206 !!!
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If

  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub barbtnSaveExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbutSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      CheckSave(False)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Protected Overrides Sub Finalize()
    If FormController IsNot Nothing Then FormController = Nothing
    MyBase.Finalize()
  End Sub

  Private Sub btedSupplier_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)

    Dim mSelectedSupplier As dmSupplier

    Try

      UpdateObject()



      If mSelectedSupplier IsNot Nothing Then
        pFormController.PurchaseOrder.SupplierID = mSelectedSupplier.SupplierID

        pFormController.LoadSuppliers()
        pFormController.PurchaseOrder.Supplier = mSelectedSupplier

        'pFormController.PurchaseOrder.InvoiceAddress = mSelectedSupplier.MainSupplierAddress

        RefreshControls()
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbiPrintPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    'Dim mPOInfo As New clsPurchaseOrderInfo
    'Dim mPOItemInfos As New colPOItemInfos
    'Dim mBuyer As clsEmployee
    'Dim mEmployees As colEmployees
    'Try
    '  UpdateObject()
    '  mPOInfo.PurchaseOrder = pFormController.PurchaseOrder
    '  For Each mPOItem As dmPurchaseOrderItem In pFormController.PurchaseOrder.PurchaseOrderItems
    '    If String.IsNullOrEmpty(mPOItem.Description) = False Then
    '      mPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
    '    End If
    '  Next

    '  mEmployees = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.Employee)
    '  mBuyer = mEmployees.ItemFromKey(pFormController.PurchaseOrder.BuyerID)

    '  repPurchaseOrder.CreateReport(mPOInfo, mPOItemInfos, mBuyer, True)

    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    'End Try
  End Sub

  Private Sub gpnlPOItems_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs)

  End Sub



  Private Sub btnEditPurchaseOrderPDF_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    Try

      UpdateObject()
      Select Case e.Button.Kind
        Case ButtonPredefines.Plus
          pFormController.CreatePurchaseOrderPDF()

          If File.Exists(pFormController.PurchaseOrder.FileName) Then
            '  frmSpreadSheetControl.OpenFormModal(pUserController.CallOff.CustomerScheduleItemisedFileXLS)
            Process.Start(pFormController.PurchaseOrder.FileName)
          End If

        Case ButtonPredefines.Delete
          If File.Exists(pFormController.PurchaseOrder.FileName) Then File.Delete(pFormController.PurchaseOrder.FileName)
          pFormController.PurchaseOrder.FileName = ""
        Case ButtonPredefines.Ellipsis
          If File.Exists(pFormController.PurchaseOrder.FileName) Then
            ' frmSpreadSheetControl.OpenFormModal(pUserController.CallOff.CustomerScheduleItemisedFileXLS)
            Process.Start(pFormController.PurchaseOrder.FileName)
          End If
      End Select
      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub LabelControl13_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

  End Sub
End Class