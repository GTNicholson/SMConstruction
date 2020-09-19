Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmSalesOrderProgress

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pFormController As fccSalesOrderProgress

  Public FormMode As eCurrentDetailMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Public Sub New()
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum

  Public Shared Sub OpenFormMDI(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmSalesOrderProgress
    mfrm = New frmSalesOrderProgress
    mfrm.pFormController = New fccSalesOrderProgress(rDBConn, rRTISGlobal)
    mfrm.MdiParent = rMDI
    mfrm.Show()
  End Sub


  Private Sub frmSalesOrderProgress_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mMsg As String
    Dim mOK As Boolean
    Dim mErrorDisplayed As Boolean
    Try
      pIsActive = False
      pFormController.LoadObjects()
      grdSalesOrderProgress.DataSource = pFormController.SalesOrderProgressInfos
      mOK = True

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))
    End If
    pIsActive = True
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub


End Class