Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports RTIS.ERPCore

Public Class frmAdminEmployeeOverride

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    Me.puctEeeDetails = New uctEmployeeDetailsReplacement


    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  ''Public Shared Sub OpenAsMDI(ByRef rParentForm As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef rPermissionCode As ePermissionCode)
  ''  Dim mFrm As New frmAdminEmployeeOverride
  ''  Dim mdso As New dsoAdminEmployeeOverride(rDBConn)
  ''  Dim mucc As New uccEmployeeDetailsBase(mdso, rRTISGlobal, rPermissionCode) ' or could useinherited one uccEmployeeDetailsOverride(mdso, rRTISGlobal, rPermissionCode)
  ''  ''Dim muct As New uctEmployeeDetails
  ''  ''muct.uctController = mucc
  ''  mFrm.puctEeeDetails.Controller = mucc
  ''  mFrm.pFormController = New fccAdminEmployeeBase(mucc) 'This fccAdminEmployeeBase could be overridden if required

  ''  mFrm.MdiParent = rParentForm

  ''  mFrm.Show()
  ''End Sub


  Public Shared Sub OpenAsMDI(ByRef rParentForm As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal, ByRef rPermissionCode As ePermissionCode, ByRef rRoleList As IList)
    Dim mFrm As frmAdminEmployeeOverride
    Dim mdso As dsoAdminEmployeeOverride
    Dim mucc As uccEmployeeDetailsBase ' or could useinherited one uccEmployeeDetailsOverride(mdso, rRTISGlobal, rPermissionCode,rRoleList)

    mFrm = GetFormIfLoaded()

    If mFrm Is Nothing Then

      mFrm = New frmAdminEmployeeOverride
      mdso = New dsoAdminEmployeeOverride(rDBConn)
      mucc = New uccEmployeeDetailsOverride(mdso, rRTISGlobal, rPermissionCode, rRoleList) ' or could useinherited one uccEmployeeDetailsOverride(mdso, rRTISGlobal, rPermissionCode,rRoleList)

      mFrm.puctEeeDetails.Controller = mucc
      mFrm.pFormController = New fccAdminEmployeeOverride(mucc, rDBConn) 'This fccAdminEmployeeBase could be overridden if required

      mFrm.MdiParent = rParentForm

      mFrm.Show()
    Else
      mFrm.Focus()
    End If

  End Sub

  Private Sub frmAdminEmployeeOverride_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    'pFormController.ClearObjects()
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub frmAdminEmployeeOverride_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mRefreshButton As DevExpress.XtraBars.BarButtonItem
    mRefreshButton = New DevExpress.XtraBars.BarButtonItem
    mRefreshButton.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    mRefreshButton.Caption = "Refrescar Lista de Empleados"

    AddHandler mRefreshButton.ItemClick, AddressOf RefreshEmployees
    Me.Bar1.AddItem(mRefreshButton)

    CType(puctEeeDetails, uctEmployeeDetailsReplacement).LoadGrids()
  End Sub

  Private Sub RefreshEmployees()
    CType(pFormController, fccAdminEmployeeOverride).RefreshEmployees
  End Sub

  Private Shared Function GetFormIfLoaded() As frmAdminEmployeeOverride
    Dim mfrmWanted As frmAdminEmployeeOverride = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmAdminEmployeeOverride
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      'If mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID Then
      mfrmWanted = mfrm
      mFound = True
      Exit For
      'End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  ''Protected Overrides Sub frmAdminEmployee_Load(sender As Object, e As EventArgs) 'Handles Me.Load
  ''  If MyBase.pFormController IsNot Nothing Then

  ''  End If

  ''End Sub



End Class
