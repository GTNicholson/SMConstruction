Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.Data
Imports RTIS.Elements
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB.clsGeneralA
Imports DevExpress.XtraEditors.Controls

Public Class frmWorkOrderPicker


  Private pSelectedID As Integer
  Private pSelectedSOID As Integer
  Private pSelectedIDs As Dictionary(Of Integer, Boolean)



  Private pPickerWO As clsPickerWorkOrder


  Public Shared Function OpenPickerSingle(ByVal vPickerWO As clsPickerWorkOrder) As clsWorkOrderInfo
    Dim mfrm As New frmWorkOrderPicker


    Dim mRetVal As clsWorkOrderInfo = Nothing
    mfrm.pPickerWO = vPickerWO
    mfrm.ShowDialog()

    If mfrm.pPickerWO.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerWO.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerWO.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Private Sub frmWorkOrderPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Try
      LoadCombos()
      RefreshControls()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargado el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombos()
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCustomerType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CustomerTypes))
  End Sub

  Private Sub RefreshControls()
    grdWorkOrder.DataSource = pPickerWO.DataSource
  End Sub

  Private Sub repbtnSelectOt_Click(sender As Object, e As EventArgs) Handles repbtnSelectOt.Click

  End Sub

  Private Sub repbtnSelectOt_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repbtnSelectOt.ButtonClick
    Try
      Dim mItem As clsWorkOrderInfo
      mItem = TryCast(gvWorkOrder.GetFocusedRow, clsWorkOrderInfo)
      If mItem IsNot Nothing Then
        pPickerWO.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub




  ''Public Property SelectedID() As Integer
  ''  Get
  ''    SelectedID = pSelectedID
  ''  End Get
  ''  Set(ByVal value As Integer)
  ''    pSelectedID = value
  ''  End Set
  ''End Property

  ''Public Property SelectedIDs() As Dictionary(Of Integer, Boolean)
  ''  Get
  ''    SelectedIDs = pSelectedIDs
  ''  End Get
  ''  Set(ByVal value As Dictionary(Of Integer, Boolean))
  ''    pSelectedIDs = value
  ''  End Set
  ''End Property


  ''Public Property SelectedSOID() As Integer
  ''  Get
  ''    SelectedSOID = pSelectedSOID
  ''  End Get
  ''  Set(ByVal value As Integer)
  ''    pSelectedSOID = value
  ''  End Set
  ''End Property

  ''Public Property FormController() As fccWorkOrderPicker
  ''  Get
  ''    FormController = pFormController
  ''  End Get
  ''  Set(ByVal value As fccWorkOrderPicker)
  ''    pFormController = value
  ''  End Set
  ''End Property

  ''Public Function GetSelectedID(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase) As Integer
  ''  Dim mfrm As New frmWorkOrderPicker
  ''  mfrm.FormController = New fccWorkOrderPicker(rDBConn)
  ''  mfrm.FormController.DBConn = rDBConn
  ''  mfrm.Owner = rParentForm
  ''  mfrm.ShowDialog()
  ''  pSelectedID = mfrm.pSelectedID
  ''  'rSelectedSOID = mfrm.pSelectedSOID

  ''  mfrm.Owner = Nothing
  ''  mfrm.Dispose()
  ''  mfrm = Nothing
  ''  Return pSelectedID
  ''End Function

  ''Private Shared Function GetFormIfLoaded() As frmWorkOrderPicker
  ''  Dim mfrmWanted As frmWorkOrderPicker = Nothing
  ''  Dim mFound As Boolean = False
  ''  Dim mfrm As frmWorkOrderPicker
  ''  '  Check if exisits already
  ''  If sActiveForms Is Nothing Then sActiveForms = New Collection
  ''  For Each mfrm In sActiveForms
  ''    mfrmWanted = mfrm
  ''    mFound = True
  ''    Exit For
  ''  Next
  ''  If Not mFound Then
  ''    mfrmWanted = Nothing
  ''  End If
  ''  Return mfrmWanted
  ''End Function


  ''Public Function GetSelectedIDs(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rSelectedIDs As Dictionary(Of Integer, Boolean)) As DialogResult
  ''  Dim mfrm As New frmWorkOrderPicker
  ''  Dim mSelectedIDs As New List(Of Integer)
  ''  Dim mDialogResult As DialogResult
  ''  mfrm.FormController = New fccWorkOrderPicker(rDBConn)
  ''  mfrm.FormController.DBConn = rDBConn
  ''  mfrm.Owner = rParentForm
  ''  mfrm.SelectedIDs = rSelectedIDs
  ''  mDialogResult = mfrm.ShowDialog()
  ''  If mDialogResult = DialogResult.OK Then
  ''    rSelectedIDs = mfrm.SelectedIDs


  ''  End If
  ''  mfrm.Owner = Nothing
  ''  mfrm.Dispose()
  ''  mfrm = Nothing
  ''  Return mDialogResult
  ''End Function

End Class