Imports RTIS.CommonVB
Imports RTIS.Elements
Imports RTIS.DataLayer
Imports RTIS.ERPCore

Public Class uccEmployeeDetailsOverride : Inherits uccEmployeeDetailsBase


  Public Sub New(ByRef rdsoAdminEmployee As dsoAdminEmployeeOverride, ByRef rRTISGlobal As clsRTISGlobal, ByRef rPermissionCode As ePermissionCode)
    MyBase.New(rdsoAdminEmployee, rRTISGlobal, rPermissionCode)
  End Sub

  Public Sub New(ByRef rdsoAdminEmployee As dsoAdminEmployeeOverride, ByRef rRTISGlobal As clsRTISGlobal, ByRef rPermissionCode As ePermissionCode, ByRef rRoleList As IList)
    MyBase.New(rdsoAdminEmployee, rRTISGlobal, rPermissionCode, rRoleList)

  End Sub

  Public Overrides Sub ValidateObject(ByRef rValidate As clsValidate)

  End Sub

  Public Function HasEmployeeBeenEnrolled() As Boolean
    Dim mEnrolled As Boolean = False

    Try

      If pCurrentEmployee IsNot Nothing AndAlso pCurrentEmployee.EmployeeID > 0 Then
        mEnrolled = CType(pdsoAdminEmployee, dsoAdminEmployeeOverride).HasEmployeeBeenEnrolled(pCurrentEmployee.EmployeeID)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mEnrolled
  End Function


End Class
