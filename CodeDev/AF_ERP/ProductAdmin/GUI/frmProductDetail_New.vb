Imports System.ComponentModel
Imports RTIS.CommonVB

Public Class frmProductDetail_New
  Private pFormController As fccProductDetaiL_New
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Public Shared Function OpenFormModal(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase) As Integer
    Dim mfrm As frmProductDetail_New = Nothing

    mfrm = New frmProductDetail_New
    mfrm.pFormController = New fccProductDetaiL_New(rDBConn)
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.ShowDialog()

    Return mfrm.FormController.PrimaryKeyID
  End Function

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub
  Public ReadOnly Property FormController As fccProductDetaiL_New
    Get
      Return pFormController
    End Get
  End Property


  Private Sub frmProductDetail_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      pFormController.ProductBaseInfo.Product = pFormController.ProductStructure
      uctProductDetail.ConfigureControl(pFormController.DBConn, AppRTISGlobal.GetInstance)
      uctProductDetail.SetDetailsControlsReadonly(False)
      uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)
      If pFormController.PrimaryKeyID > 0 Then
        uctProductDetail.FormController.ReloadProduct(pFormController.PrimaryKeyID)
      End If

      uctProductDetail.ConfigureBrowseFilesControl(pFormController.DBConn, AppRTISGlobal.GetInstance)
      uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)
      uctProductDetail.LoadCombos()
      uctProductDetail.RefreshControls()

      AddHandler uctProductDetail.repoChkSelectedSI.CheckedChanged, AddressOf repoChkSelectedSI_CheckedChanged
      AddHandler uctProductDetail.repoChkSelectedItem.CheckedChanged, AddressOf repoChkSelectedWood_CheckedChanged


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
  Public Sub repoChkSelectedWood_CheckedChanged(sender As Object, e As EventArgs)

    If pFormController IsNot Nothing Then

      If uctProductDetail IsNot Nothing Then



        If uctProductDetail.ItemsSelected > 0 Then

          bbtnCreateCopySelected.Enabled = True


        Else
          bbtnCreateCopySelected.Enabled = False

        End If


        If uctProductDetail.WoodItemsSelected > 0 Then

          bbtnChangeSpecies.Enabled = True


        Else
          bbtnChangeSpecies.Enabled = False

        End If

      End If

      End If

  End Sub
  Public Sub repoChkSelectedSI_CheckedChanged(sender As Object, e As EventArgs)
    If pFormController IsNot Nothing Then

      If uctProductDetail IsNot Nothing Then



        If uctProductDetail.ItemsSelected > 0 Then

          bbtnCreateCopySelected.Enabled = True
        Else
          bbtnCreateCopySelected.Enabled = False

        End If



      End If

    End If
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    uctProductDetail.UpdateObject()
    pFormController.SaveObjects()
    Me.Close()
  End Sub

  Private Sub frmProductDetail_New_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    pForceExit = True
    uctProductDetail.UpdateObject()
    pFormController.SaveObjects()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    uctProductDetail.UpdateObject()
    uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)
    pFormController.ProductStructure = uctProductDetail.FormController.CurrentProductInfo.Product
    pFormController.SaveObjects()

    uctProductDetail.FormController.ReloadProduct(pFormController.PrimaryKeyID)
    uctProductDetail.RefreshControls()
  End Sub

  Private Sub bbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSaveAndClose.ItemClick
    Try

      uctProductDetail.UpdateObject()
      uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)
      pFormController.ProductStructure = uctProductDetail.FormController.CurrentProductInfo.Product
      pFormController.SaveObjects()

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

  Private Sub bbtnCreateCopy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnCreateCopy.ItemClick
    pFormController.CreateCopyProduct()

    uctProductDetail.FormController.CurrentProductInfo.Product = pFormController.ProductStructure
    uctProductDetail.RefreshControls()
    uctProductDetail.UpdateObject()
    uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)


    pFormController.PrimaryKeyID = 0
    pFormController.SaveObjects()

    pFormController.ProductStructure = uctProductDetail.FormController.CurrentProductInfo.Product
    uctProductDetail.FormController.ReloadProduct(pFormController.PrimaryKeyID)
    uctProductDetail.RefreshControls()

  End Sub








  Private Sub frmProductDetail_New_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    If uctProductDetail IsNot Nothing Then

      If uctProductDetail.ItemsSelected > 0 Then
        bbtnCreateCopySelected.Enabled = True

      Else
        bbtnCreateCopySelected.Enabled = False
      End If


      If uctProductDetail.WoodItemsSelected > 0 Then
        bbtnChangeSpecies.Enabled = True

      Else
        bbtnChangeSpecies.Enabled = False
      End If
    End If
  End Sub

  Private Sub bbtnCreateCopySelected_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnCreateCopySelected.ItemClick
    Dim mSIBOMs As colProductBOMs
    Dim mWoodBOMs As colProductBOMs

    uctProductDetail.gvStockItemMaterialRequirements.CloseEditor()
    uctProductDetail.gvWoodMaterialRequirements.CloseEditor()

    mSIBOMs = uctProductDetail.gvStockItemMaterialRequirements.DataSource
    mWoodBOMs = uctProductDetail.gvWoodMaterialRequirements.DataSource

    pFormController.CreateCopyProductSelected(mSIBOMs, mWoodBOMs)

    uctProductDetail.FormController.CurrentProductInfo.Product = pFormController.ProductStructure
    uctProductDetail.RefreshControls()
    uctProductDetail.UpdateObject()
    uctProductDetail.SetCurrentProductBaseInfo(pFormController.ProductBaseInfo)


    pFormController.PrimaryKeyID = 0
    pFormController.SaveObjects()

    pFormController.ProductStructure = uctProductDetail.FormController.CurrentProductInfo.Product
    uctProductDetail.FormController.ReloadProduct(pFormController.PrimaryKeyID)
    uctProductDetail.RefreshControls()
    bbtnCreateCopySelected.Enabled = False
    uctProductDetail.ItemsSelected = 0
  End Sub

  Private Sub bbtnChangeSpecies_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnChangeSpecies.ItemClick
    Dim mSelectedWoodItems As New colProductBOMs
    Dim mSelectedItem As dmProductBOM

    If uctProductDetail IsNot Nothing Then

      If uctProductDetail.gvWoodMaterialRequirements IsNot Nothing Then
        uctProductDetail.gvWoodMaterialRequirements.CloseEditor()



        For Each mWoodBOM As dmProductBOM In uctProductDetail.gvWoodMaterialRequirements.DataSource

          If mWoodBOM.TmpSelectedItem Then
            mSelectedItem = mWoodBOM

            If mSelectedItem IsNot Nothing Then
              mSelectedWoodItems.Add(mSelectedItem)
            End If
          End If
        Next
      End If
    End If


    frmProductGlobalChange.OpenForm(pFormController.DBConn, mSelectedWoodItems)

  End Sub
End Class