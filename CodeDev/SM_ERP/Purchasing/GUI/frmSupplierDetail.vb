Imports RTIS.CommonVB

Public Class frmSupplierDetail
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccSupplierDetail

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
    Dim mfrm As frmSupplierDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSupplierDetail
      mfrm.pFormController = New fccSupplierDetail(rDBConn)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Public Shared Sub OpenFormModal(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmSupplierDetail = Nothing

    mfrm = New frmSupplierDetail
    mfrm.pFormController = New fccSupplierDetail(rDBConn)
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.ShowDialog()

  End Sub


  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmSupplierDetail
    Dim mfrmWanted As frmSupplierDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSupplierDetail
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


  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Public ReadOnly Property FormController As fccSupplierDetail
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmSupplierDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()

      ''LoadCombos()

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


  Private Sub RefreshControls()
    With pFormController.Supplier

      ''  lblCustomerID.Text = "ID:" & .CustomerID.ToString("00000")

      txtSupplierReference.Text = .SupplierReferenceID
      txtCompanyName.Text = .CompanyName
      ''  txtRazonSocial.Text = .RazonSocial
      ''  txtRucNumber.Text = .Rucnumber
      ''  txtMainAddress1.Text = .MainAddress1
      ''  txtTelNo.Text = .TelNo
      ''  txtEmail.Text = .Email
      ''  txtWebUrl.Text = .WebURL
      ''  txtAcountRef.Text = .AccountRef
      ''  txtBancoIntermediario.Text = .BancoIntermediario
      ''  txtSwift.Text = .Numero_SWIFT
      ''  txtABA.Text = .Numero_ABA
      ''  txtMainTown.Text = .MainTown
      ''  txtCustomerReference.Text = .CustomerReference
      ''  txtCustomerNotes.Text = .CustomerNotes
      ''  RTIS.Elements.clsDEControlLoading.SetDECombo(cboCountry, .SalesAreaID)
      ''  RTIS.Elements.clsDEControlLoading.SetDECombo(cboPaymentTermsType, .PaymentTermsType)
      ''  RTIS.Elements.clsDEControlLoading.SetDECombo(cboSalesTermsType, .SalesTermsType)
      ''  txtMainPostCode.Text = .MainPostCode
      ''  rgEstatus.EditValue = .CustomerStatusID

    End With
  End Sub

  Private Sub UpdateObjects()
    With pFormController.Supplier
      .CompanyName = txtCompanyName.Text

    End With
  End Sub

  Private Sub bbtnSavenAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSavenAndClose.ItemClick

    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()
    'pFormController.SaveObjects()
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
End Class