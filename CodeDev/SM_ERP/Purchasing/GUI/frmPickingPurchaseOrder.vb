Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Public Class frmPickingPurchaseOrder
  Dim pFormController As fccPickPurchaseOrder
  ''Dim pMaterialRequirementInfos As colMaterialRequirementInfos
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

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdPurchaseOrderItemInfo, gcCategory, mVIs)

  End Sub

  Public Property FormController() As fccPickPurchaseOrder
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccPickPurchaseOrder)
      pFormController = value
    End Set
  End Property

  Public Sub New()

    ''pMaterialRequirementInfos = New colMaterialRequirementInfos
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmPickingPurchaseOrder = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmPickingPurchaseOrder
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccPickPurchaseOrder(rDBConn)

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Private Shared Function GetFormIfLoaded() As frmPickingPurchaseOrder


    Dim mfrmWanted As frmPickingPurchaseOrder = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPickingPurchaseOrder
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPickingPurchaseOrder Then
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

  Private Sub RefreshControls()

    Try


      With pFormController.PurchaseOrderInfo
        btnSelectPurchaseOrder.Text = .PONum
        txtCategory.Text = .Category
        txtRequiredDate.Text = .RequiredDate
        txtSupplierCompanyName.Text = .CompanyName


      End With



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub frmPickMaterials_Load(sender As Object, e As EventArgs) Handles Me.Load
    LoadCombos()
  End Sub

  Private Sub frmPickMaterials_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btnSelectProductionBatch_Click(sender As Object, e As EventArgs) Handles btnSelectPurchaseOrder.Click
    Dim mPickerPurchaseOrder As clsPickerPurchaseOrder
    Dim mPurchaseorderInfos As New colPurchaseOrderInfos

    pFormController.LoadPurchaseOrderInfos(mPurchaseorderInfos)

    mPickerPurchaseOrder = New clsPickerPurchaseOrder(mPurchaseorderInfos)

    Dim mPB As clsPurchaseOrderInfo

    mPB = frmPickerPurchaseOrder.OpenPickerSingle(mPickerPurchaseOrder)

    If mPB IsNot Nothing Then
      pFormController.PurchaseOrderInfo = mPB
      RefreshControls()
      pFormController.LoadPurchaseOrderItemAllocationProcessorss()
      grdPurchaseOrderItemInfo.DataSource = pFormController.PurchaseOrderProcessors

    End If


  End Sub



  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    ''pFormController.LoadMaterialRequirementProcessorss()
    ''grdPurchaseOrderItemInfo.DataSource = pFormController.MaterialRequirementProcessors
  End Sub


End Class