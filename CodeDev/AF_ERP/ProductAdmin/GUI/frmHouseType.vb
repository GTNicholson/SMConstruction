Imports RTIS.CommonVB
Public Class frmHouseType

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccHouseType

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmHouseType = Nothing

    mfrm = GetFormIfLoaded(vPrimaryKeyID)
    If mfrm Is Nothing Then
      mfrm = New frmHouseType
      If vPrimaryKeyID <> 0 Then
        mfrm.FormMode = eFormMode.eFMFormModeEdit
      Else
        mfrm.FormMode = eFormMode.eFMFormModeAdd
      End If
      mfrm.pFormController = New fccHouseType(rDBConn)
      mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmHouseType
    Dim mfrmWanted As frmHouseType = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmHouseType
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID Then
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

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmHouseType_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()

      LoadCombos()


      If FormMode = eFormMode.eFMFormModeEdit And pFormController.HaveLock = False Then
        FormMode = eFormMode.eFMFormModeView
      End If

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

  Private Sub LoadCombos()

  End Sub

  Private Sub RefreshControls()

  End Sub

  Private Sub UpdateObjects()

  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()
    'pFormController.SaveObjects()
    If Me.pFormController.HaveLock Or pFormController.PrimaryKeyID = 0 Or FormMode = eFormMode.eFMFormModeAdd Then
      If pFormController.IsDirty() Then
        If rOption Then
          mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
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
    Else
      ExitMode = Windows.Forms.DialogResult.Ignore
      mSaveRequired = False
      mRetVal = True
    End If
    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then


        pFormController.SaveObjects()


        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If

    CheckSave = mRetVal
  End Function

  Private Sub frmHouseType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub frmHouseType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
    If vWithCheck Then
      If CheckSave(True) Then
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If

  End Sub

End Class