Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmGlobalStockItemChanges
  Private pFormController As fccGlobalStockItemChange
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False
  Private pSelectedItemsCount As Integer
  Public Property FormController() As fccGlobalStockItemChange
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccGlobalStockItemChange)
      pFormController = value
    End Set
  End Property

  Public Property SelectedItemsCount() As Int32
    Get
      Return pSelectedItemsCount
    End Get
    Set(ByVal value As Int32)
      pSelectedItemsCount = value
    End Set
  End Property

  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef rStockItemEditors As colStockItems, ByVal vFormMode As eFormMode, ByVal vSelectedItemsCount As Int32)
    Dim mfrm As New frmGlobalStockItemChanges
    mfrm.FormController = New fccGlobalStockItemChange
    mfrm.FormController.DBConn = rDBConn
    mfrm.FormController.RTISGlobal = rRTISGlobal
    mfrm.pFormController.StockItemEditors = rStockItemEditors
    mfrm.FormMode = vFormMode
    mfrm.pSelectedItemsCount = vSelectedItemsCount
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

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub frmGlobalStockItemChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try
      LoadCombos()
      SetCaptionButtons()
    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True

  End Sub

  Private Sub LoadCombos()
    'clsDEControlLoading.FillDEComboVI(cboStockManagementType, clsEnumsConstants.EnumToVIs(GetType(eStockItemManagementType)))

  End Sub

  Private Sub SetCaptionButtons()
    Dim mSelectedItemCount As Integer



    If pSelectedItemsCount = 0 Then
      btnGenerateDescription.Text = "Generate Description Item"
      btnGenerateDescription.Enabled = False


      btnGenrateStockCode.Text = "Generate Code Item"
      btnGenrateStockCode.Enabled = False

      btnSetObsolete.Text = "Set Obsolete Item"
      btnSetObsolete.Enabled = False
    Else
      btnGenerateDescription.Enabled = True
      btnGenerateDescription.Text = String.Format("Generate ({0}) Item(s) Description", pSelectedItemsCount)

      btnGenrateStockCode.Text = String.Format("Generate ({0}) Item(s) Stock Code", pSelectedItemsCount)
      btnGenrateStockCode.Enabled = True

      btnSetObsolete.Text = String.Format("Set Obsolete ({0}) Item(s)", pSelectedItemsCount)
      btnSetObsolete.Enabled = True

    End If


  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub btnGenerateDescription_Click(sender As Object, e As EventArgs) Handles btnGenerateDescription.Click
    Dim mIndex As Integer = -1

    For Each mStockItemEditor As dmStockItem In pFormController.StockItemEditors

      If mStockItemEditor.IsSelected = True Then
        pFormController.SetCurrentStockItemInfo(mStockItemEditor)
        If mStockItemEditor IsNot Nothing Then
          mStockItemEditor.IsSelected = True
          pFormController.CurrentStockItem.Description = GenerateDescription(mStockItemEditor)
          pFormController.SaveObject()
        End If
      End If

    Next
  End Sub

  Private Function GenerateDescription(ByRef rStockItem As dmStockItem) As String
    Dim mRetval As String = ""
    Dim mCategoryBase As clsStockItemCategoryBase

    mCategoryBase = eStockItemCategoryEnums.GetInstance.ItemFromCategory(rStockItem.Category)

    If mCategoryBase IsNot Nothing Then

      mRetval = mCategoryBase.GetDescription(rStockItem)

      If rStockItem.PartNo = "" Then
        mRetval = mRetval & " " & pFormController.GetNextStockCodeSuffix(mRetval)
      End If

    End If


    Return mRetval
  End Function

  Private Function GenerateStockCode(ByRef rStockItem As dmStockItem) As String
    Dim mRetval As String = ""
    Dim mCategoryBase As clsStockItemCategoryBase

    mCategoryBase = eStockItemCategoryEnums.GetInstance.ItemFromCategory(rStockItem.Category)

    If mCategoryBase IsNot Nothing Then

      mRetval = mCategoryBase.GetStockCode(rStockItem)

      If rStockItem.PartNo = "" Then
        mRetval = mRetval & "." & pFormController.GetNextStockCodeSuffix(mRetval)
      End If


    End If


    Return mRetval
  End Function
  Private Sub btnGenrateStockCode_Click(sender As Object, e As EventArgs) Handles btnGenrateStockCode.Click

    For Each mStockItemEditor As dmStockItem In pFormController.StockItemEditors

      If mStockItemEditor.IsSelected = True Then
        pFormController.SetCurrentStockItemInfo(mStockItemEditor)
        If mStockItemEditor IsNot Nothing Then

          pFormController.CurrentStockItem.StockCode = GenerateStockCode(mStockItemEditor)
          pFormController.SaveObject()
        End If
      End If

    Next
  End Sub

  Private Sub btnSetObsolete_Click(sender As Object, e As EventArgs) Handles btnSetObsolete.Click

    For Each mStockItemEditor As dmStockItem In pFormController.StockItemEditors

      If mStockItemEditor.IsSelected = True Then
        pFormController.SetCurrentStockItemInfo(mStockItemEditor)
        If mStockItemEditor IsNot Nothing Then
          pFormController.CurrentStockItem.Inactive = True
          pFormController.SaveObject()
        End If
      End If

    Next
  End Sub

End Class