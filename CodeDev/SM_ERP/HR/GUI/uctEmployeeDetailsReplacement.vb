Imports DevExpress.XtraBars.Docking2010
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPCore

Public Class uctEmployeeDetailsReplacement
  Implements IuctEmployeeDetails

  Private pCurrentMode As eFormMode
  Private puctController As uccEmployeeDetailsOverride
  Private pIsActive As Boolean = True
  Public Event Ok As EventHandler Implements IuctEmployeeDetails.AddButton
  Public Event Cancel As EventHandler Implements IuctEmployeeDetails.CancelButton

  ''Public Enum eMode
  ''  Add = 1
  ''  Edit = 2
  ''End Enum

  Public Property uctController As uccEmployeeDetailsBase Implements IuctEmployeeDetails.Controller
    Get
      uctController = puctController
    End Get
    Set(value As uccEmployeeDetailsBase)
      puctController = value
    End Set
  End Property

  Public Sub ForceUpdateObjects()
    UpdateObject()
  End Sub

  Public Property CurrentMode As eFormMode Implements IuctEmployeeDetails.CurrentMode
    Get
      CurrentMode = pCurrentMode
    End Get
    Set(value As eFormMode)
      pCurrentMode = value
    End Set
  End Property


  Public Sub LoadCombos() Implements IuctEmployeeDetails.LoadCombos
    Dim mOK As Boolean = False
    If puctController.DisplayRoles AndAlso puctController.RoleList IsNot Nothing Then
      Try
        clsDEControlLoading.FillDEComboVIi(cboMainRole, puctController.RoleList)
        grdEmployeeRoles.DataSource = puctController.RoleList
        mOK = True
      Catch ex As Exception
        puctController.DisplayRoles = False
        If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
      End Try
    End If

    '' clsDEControlLoading.FillDEComboVIi(cboSalesArea, CType(puctController.RTISGlobal, AppRTISGlobal).RefLists.RefIList(appRefLists.SalesArea))

    lblMainRole.Visible = mOK
    cboMainRole.Visible = mOK
    grpRoles.Visible = mOK

    SetupUserPermissions()
  End Sub

  Public Sub SetupUserPermissions() Implements IuctEmployeeDetails.SetupUserPermissions
    'Dim mPermisionLevel As ePermissionCode
    'mPermisionLevel = pDBConn.RTISUser.ActivityPermissions.GetActivityPermission(eActivityCode.UserConfig)
    If puctController.PermissionCode < ePermissionCode.ePC_Edit Then
      Me.grpDetails.Enabled = False
      Me.grpRoles.Enabled = False
    End If
  End Sub

  Public Sub RefreshControls() Implements IuctEmployeeDetails.RefreshControls
    Dim mEmpSD As dmEmployeeSM
    pIsActive = False

    mEmpSD = TryCast(puctController.CurrentEmployee, dmEmployeeSM)

    If mEmpSD IsNot Nothing Then
      With mEmpSD
        txtFirstName.EditValue = .FirstName
        'txtMiddleName.EditValue = .MiddleName
        txtLastName.EditValue = .LastName
        txtPosition.EditValue = .Position
        txtRefNo.EditValue = .EmployeeRefNo
        txtEmail.EditValue = .Email
        txtTelephone.EditValue = .TelNo
        txtMobile.EditValue = .Mobile
        memNotes.EditValue = .Notes
        datDateStart.EditValue = .ValidDateRange.DateStart
        datDateEnd.EditValue = .ValidDateRange.DateEnd

        If puctController.DisplayRoles Then
          clsDEControlLoading.SetDECombo(cboMainRole, .MainRoleID)
          gvEmployeeRoles.RefreshData()
        End If

        ''clsDEControlLoading.SetDECombo(cboSalesArea, .SalesAreaID)

        ''radEmployeeGrouop.EditValue = CInt(.EmployeeGroup)
        ''radPaymentType.EditValue = CInt(.PaymentType)
      End With

      grpDetails.Enabled = True
      grpRoles.Enabled = True

      grpDetails.CustomHeaderButtons(0).Properties.Enabled = puctController.CurrentEmployee.EmployeeID > 0


      '//Rates of Pay
      grdRateOfPay.Enabled = True
      grdRateOfPay.DataSource = mEmpSD.EmployeeRateOfPays

    Else

      txtFirstName.EditValue = String.Empty
      'txtMiddleName.EditValue = String.Empty
      txtLastName.EditValue = String.Empty
      txtPosition.EditValue = String.Empty
      txtRefNo.EditValue = String.Empty
      txtEmail.EditValue = String.Empty
      txtTelephone.EditValue = String.Empty
      txtMobile.EditValue = String.Empty
      datDateStart.EditValue = DateTime.MinValue
      datDateEnd.EditValue = DateTime.MinValue
      memNotes.EditValue = String.Empty
      If puctController.DisplayRoles Then
        cboMainRole.SelectedIndex = -1
        gvEmployeeRoles.RefreshData()
      End If

      radEmployeeGrouop.EditValue = 0
      radPaymentType.EditValue = 0

      cboSalesArea.SelectedIndex = -1

      grpDetails.Enabled = False
      grpRoles.Enabled = False
      grpDetails.CustomHeaderButtons(0).Properties.Enabled = False
      'btnEnroll.Enabled = False
      grdRateOfPay.DataSource = Nothing
      grdRateOfPay.Enabled = False
    End If


    '//Show/Hide Rates of Pay
    If puctController.dsoAdminEmployee.DBConn.RTISUser.ActivityPermission(eActivityCode.EmployeeSalaries) <> ePermissionCode.ePC_Full Then
      grpRateOfPay.Visible = False
    Else
      grpRateOfPay.Visible = True
    End If

    Select Case pCurrentMode
      Case eFormMode.eFMFormModeAdd
        btnCancel.Visible = True
        btnOk.Visible = True
      Case Else 'eMode.Edit
        btnCancel.Visible = False
        btnOk.Visible = False
    End Select
    pIsActive = True

  End Sub

  Public Sub UpdateObject() Implements IuctEmployeeDetails.UpdateObject
    Dim mEmpSD As dmEmployeeSM

    mEmpSD = TryCast(puctController.CurrentEmployee, dmEmployeeSM)

    If mEmpSD IsNot Nothing Then

      With mEmpSD
        .FirstName = txtFirstName.EditValue
        '.MiddleName = Me.txtMiddleName.EditValue
        .LastName = txtLastName.EditValue
        .Position = txtPosition.EditValue
        .EmployeeRefNo = txtRefNo.EditValue
        .Email = txtEmail.EditValue
        .TelNo = txtTelephone.EditValue
        .Mobile = txtMobile.EditValue
        .Notes = memNotes.EditValue
        .ValidDateRange.DateStart = datDateStart.EditValue
        .ValidDateRange.DateEnd = datDateEnd.EditValue
        If puctController.DisplayRoles Then
          .MainRoleID = clsDEControlLoading.GetDEComboValue(cboMainRole)
        End If

        ''.SalesAreaID = clsDEControlLoading.GetDEComboValue(cboSalesArea)

        ''.PaymentType = radPaymentType.EditValue
        ''.EmployeeGroup = radEmployeeGrouop.EditValue

      End With

    End If

  End Sub

  Private Sub gvEmployeeRoles_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvEmployeeRoles.CustomUnboundColumnData

    If e.Column.AbsoluteIndex = gcSelectRole.AbsoluteIndex Then

      If e.IsGetData Then
        If puctController.CurrentEmployee IsNot Nothing Then
          e.Value = puctController.CurrentEmployee.IsInRole(CType(e.Row, clsValueItem).ItemValue)
        Else
          e.Value = False
        End If
      End If
      If e.IsSetData Then
        If puctController.CurrentEmployee IsNot Nothing Then
          If Not e.Value Then
            puctController.CurrentEmployee.RemoveFromRole(CType(e.Row, clsValueItem).ItemValue)
          End If
          If e.Value Then
            puctController.CurrentEmployee.AddToRole(CType(e.Row, clsValueItem).ItemValue)
          End If
        End If
      End If
    End If

  End Sub

  Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
    RaiseEvent Ok(Me, EventArgs.Empty)
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    RaiseEvent Cancel(Me, EventArgs.Empty)
  End Sub

  Private Sub cboMainRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMainRole.SelectedIndexChanged
    If pIsActive Then
      UpdateObject()
      RefreshControls()
    End If
  End Sub


  Public Property ControlDock() As System.Windows.Forms.DockStyle Implements IuctEmployeeDetails.Dock
    Get
      ControlDock = Me.Dock
    End Get
    Set(value As System.Windows.Forms.DockStyle)
      Me.Dock = value
    End Set
  End Property

  Public Property ControlVisible As Boolean Implements IuctEmployeeDetails.Visible
    Get
      ControlVisible = Me.Visible
    End Get
    Set(value As Boolean)
      Me.Visible = value
    End Set
  End Property

  ''Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
  ''  Try
  ''    realtimeTA.frmEnrollmentDetail.OpenFormAsModal(Me.ParentForm, puctController.dsoAdminEmployee.DBConn, puctController.RTISGlobal, puctController.CurrentEmployee.EmployeeID, puctController.CurrentEmployee.FullName, eFormMode.eFMFormModeAdd)
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''  End Try
  ''End Sub

  Public Sub LoadGrids()

    ' gvEmployeeShiftPatternOptions.Columns.Clear()
    'gvEmployeeShiftPatternOptions.PopulateColumns()
  End Sub

  Private Sub grpDetails_Paint(sender As Object, e As PaintEventArgs) Handles grpDetails.Paint

  End Sub
End Class
