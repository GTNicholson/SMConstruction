Imports RTIS.CommonVB
Imports RTIS.DataLayer



Public Class frmPickMaterials

  Dim pFormController As fccPickMaterials
  Dim pMaterialRequirementInfos As colMaterialRequirementInfos
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum



  Public Property FormController() As fccPickMaterials
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPickMaterials)
      pFormController = value
    End Set
  End Property

  Public Sub New()

    pMaterialRequirementInfos = New colMaterialRequirementInfos
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub
  Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

  End Sub


  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmPickMaterials = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmPickMaterials
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccPickMaterials(rDBConn)

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub


  Private Shared Function GetFormIfLoaded() As frmPickMaterials


    Dim mfrmWanted As frmPickMaterials = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPickMaterials
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPickMaterials Then
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

  Private Sub btnSelectOT_Click(sender As Object, e As EventArgs) Handles btnSelectOT.Click
    Dim mWOPicker As clsPickerWorkOrder
    Dim mWOIs As New colWorkOrderInfos

    pFormController.LoadWorkOrderInfos(mWOIs)

    mWOPicker = New clsPickerWorkOrder(mWOIs, pFormController.DBConn)

    Dim mWO As clsWorkOrderInfo
    mWO = frmWorkOrderPicker.OpenPickerSingle(mWOPicker)

    If mWO IsNot Nothing Then
      pFormController.CurrentWorkOrderInfo = mWO
      RefreshControls()

    End If



  End Sub

  Private Sub RefreshControls()

    Try



      With pFormController.CurrentWorkOrderInfo
        btnSelectOT.Text = .WorkOrderNo
        txtCompanyName.Text = .CustomerName
      End With

      pFormController.LoadMaterialRequirementProcessorss()
      grdMaterialRequirementInfo.DataSource = pFormController.MaterialRequirementProcessors
      gvMaterialRequirementInfos.RefreshData()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub


  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    '// call formcontroller to load workorderinfos collection where objectytype = WO and objectid = eProductType.ProductFurniture


    '// Bind the grid to the new collection

  End Sub

  Private Sub frmPickMaterials_Load(sender As Object, e As EventArgs) Handles Me.Load
    ''Dim mWOIs As New colWorkOrderInfos



  End Sub

  Private Sub frmPickMaterials_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btnProcessPicks_Click(sender As Object, e As EventArgs) Handles btnProcessPicks.Click
    Try
      pFormController.ProcessPicks
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class