Imports RTIS.CommonVB

Public Class frmCustomerDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccCustomerDetail

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
    Dim mfrm As frmCustomerDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmCustomerDetail
      mfrm.pFormController = New fccCustomerDetail(rDBConn)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmCustomerDetail
    Dim mfrmWanted As frmCustomerDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmCustomerDetail
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

  Public ReadOnly Property FormController As fccCustomerDetail
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmCustomerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pFormController.LoadObjects()
    grdContacts.DataSource = pFormController.Customer.CustomerContacts
    LoadCombos()
    RefreshControls()
  End Sub

  Private Sub LoadCombos()
    Try
      RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboCountry, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))
      RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboPaymentTermsType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Tenders))
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub


  'Here put the fields
  Private Sub RefreshControls()
    With pFormController.Customer

      txtCustomerReference.Text = .CustomerReference
      txtCustomerName.Text = .CompanyName
      txtRazonSocial.Text = .RazonSocial
      txtRucNumber.Text = .Rucnumber
      txtMainAddress1.Text = .MainAddress1
      txtTelNo.Text = .TelNo
      txtEmail.Text = .Email
      txtWebUrl.Text = .WebURL
      txtAcountRef.Text = .AccountRef
      txtBancoIntermediario.Text = .BancoIntermediario
      txtSwift.Text = .Numero_SWIFT
      txtABA.Text = .Numero_ABA
      txtMainTown.Text = .MainTown
      txtCustomerReference.Text = .CustomerReference
      txtCustomerNotes.Text = .CustomerNotes
      RTIS.Elements.clsDEControlLoading.SetDECombo(cboCountry, .SalesAreaID)
      RTIS.Elements.clsDEControlLoading.SetDECombo(cboPaymentTermsType, .PaymentTermsType)

    End With
  End Sub

  'Change the fields
  Private Sub UpdateObjects()
    With pFormController.Customer
      .CompanyName = txtCustomerName.Text
      .CompanyName = txtCustomerName.Text
      .RazonSocial = txtRazonSocial.Text
      .Rucnumber = txtRucNumber.Text
      .MainAddress1 = txtMainAddress1.Text
      .TelNo = txtTelNo.Text
      .Email = txtEmail.Text
      .WebURL = txtWebUrl.Text
      .AccountRef = txtAcountRef.Text
      .BancoIntermediario = txtBancoIntermediario.Text
      .Numero_SWIFT = txtSwift.Text
      .Numero_ABA = txtABA.Text
      .MainTown = txtMainTown.Text
      .MainPostCode = txtMainPostCode.Text
      .SalesAreaID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCountry)
      .CustomerReference = txtCustomerReference.Text
      .PaymentTermsType = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboPaymentTermsType)
      .CustomerNotes = txtCustomerNotes.Text
    End With
  End Sub

  Private Sub frmCustomerDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick

    Try
      UpdateObjects()
      pFormController.SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub


End Class