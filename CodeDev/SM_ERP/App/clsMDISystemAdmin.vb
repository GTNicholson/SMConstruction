Imports RTIS.Elements
Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class clsMDISystemAdmin : Inherits clsMDIShellContextBase
  Private pLocks As colDBLocks
  Private pLocksObtained As Boolean
  Private pTitle As String

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)
    MyBase.New(rDBConn, rRTISGlobal)
    Me.MinHeight = 520
    Me.MinWidth = 880
    Me.pStartWidth = 980
    Me.pStartHeight = 700
    Me.StartMaximised = False
  End Sub

  Public Sub GetLocks()
    pLocks = New colDBLocks
    pLocks.Add(New clsDBLock(appLockEntitys.cUserList, 0, clsDBLock.eLockType.WriteTableLock))
    pLocks.Add(New clsDBLock(appLockEntitys.cEmployee, 0, clsDBLock.eLockType.WriteTableLock))
    pLocksObtained = False
    Try
      If pDBConn.Connect Then
        If pDBConn.dsoUserLogin.ObtainLocks(pLocks) Then
          pLocksObtained = True
        End If
      End If
    Catch ex As Exception
      pLocksObtained = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub


  Public Overrides Sub FormsClosed()
    If pLocksObtained Then
      Try
        If pDBConn.Connect Then
          If Not pDBConn.dsoUserLogin.ReleaseLocks(pLocks) Then
            MsgBox("Problem releasing locks")
          End If
        End If
      Catch ex As Exception
        If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
      Finally
        If pDBConn.IsConnected Then pDBConn.Disconnect()
      End Try
    End If
  End Sub

  Public Overrides Sub LoadForms(ByRef rMDIParent As Form)
    Dim mPermissionCode As ePermissionCode
    Dim mEeesLocked As Boolean = False
    Dim mUsersLocked As Boolean = False
    Try
      pTitle = "Administración del Sistema: Empleados y Usuarios"
      mPermissionCode = pDBConn.RTISUser.ActivityPermission(eActivityCode.UserConfig)
      If mPermissionCode > ePermissionCode.ePC_None Then
        If mPermissionCode > ePermissionCode.ePC_View Then
          GetLocks()
          If Not pLocksObtained Then
            mPermissionCode = ePermissionCode.ePC_View
          End If
        End If
        If mPermissionCode = ePermissionCode.ePC_View Then
          pTitle = pTitle & " (Read-only)"
        End If
        Dim mRoleList As IList = CType(RTISGlobal, AppRTISGlobal).RefLists.RefIList(appRefLists.Roles)
        ''RTIS.ERPCore.frmAdminEmployee.OpenAsMDI(rMDIParent, pDBConn, pRTISGlobal, mPermissionCode, mRoleList)  'Role list is optional
        RTIS.ERPCore.frmAdminEmployeeStandard.OpenAsMDI(rMDIParent, pDBConn, pRTISGlobal, mPermissionCode, mRoleList)

        Dim mEeeList As IList = CType(RTISGlobal, AppRTISGlobal).RefLists.RefIList(appRefLists.Employees)
        Dim mHomeFormList As New colValueItems
        mHomeFormList.AddNewItem(1, "General KPI")
        mHomeFormList.AddNewItem(2, "Quoting/Sales")
        mHomeFormList.AddNewItem(3, "Production")
        RTIS.Elements.frmAdminUser.OpenAsMDI(rMDIParent, pDBConn, pRTISGlobal, mPermissionCode, mEeeList, mHomeFormList) 'Eee List is optional

        ''Dim mAppList As New colValueItems
        ''mAppList.AddNewItem(1, "Current")
        ''mAppList.AddNewItem(2, "Legacy")
        RTIS.Elements.frmUserGroupEdit.ShowUserGroupEditForm(rMDIParent, pDBConn, pRTISGlobal, mPermissionCode, fccUserGroupEdit.eGridEditOptions.User_Groupings) ', mAppList) 'AppList is optional

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Overrides ReadOnly Property MDITitle As String
    Get
      MDITitle = pTitle
    End Get
  End Property

End Class
