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
    RefreshControls()
  End Sub


  Private Sub RefreshControls()
    With pFormController.Customer
      txtCustomerID.Text = .CustomerID
      txtCustomerName.Text = .CompanyName


    End With
  End Sub

  Private Sub UpdateObjects()
    With pFormController.Customer
      .CompanyName = txtCustomerName.Text



    End With
  End Sub

  Private Sub frmCustomerDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    UpdateObjects()
    pFormController.SaveObjects()
  End Sub
End Class