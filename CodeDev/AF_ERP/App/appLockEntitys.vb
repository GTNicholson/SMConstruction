Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class appLockEntitys : Inherits colLockEntitys
  Public Const cUserList As String = "UserList"
  Public Const cEmployee As String = "Employee"
  Public Const cRole As String = "Role"
  Public Const cCustomer As String = "Customer"

  Private Sub New()
    MyBase.New()
    Me.Add(New clsLockEntity(cUserList, "UserID", "User Name:", "UserName"))
    Me.Add(New clsLockEntity(cEmployee, "EmployeeID", "Employee name:", "LastName"))
    Me.Add(New clsLockEntity(cRole, "RoleID", "Role:", "Role"))

    Me.Add(New clsLockEntity(cCustomer, "CustomerID", "Customer:", "CompanyName"))
    ''Example
    ''Dim mclsLockEntity As clsLockEntity = New clsLockEntity(cTableScope, "PrimaryKeyFieldName", "Ref Caption:", "RefFieldName")
    ''mclsLockEntity.BaseTableName = "" 'If different to cTableScope, e.g. if TableScope = "TableSubset" .BaseTableName = "Tablename"
    ''mclsLockEntity.LookUpSQL = "" 'If standard select not enough
    ''Me.Add(mclsLockEntity)


  End Sub

  Public Shared Function GetInstance() As colLockEntitys
    If mSharedInstance Is Nothing Then
      mSharedInstance = New appLockEntitys
    End If
    Return mSharedInstance
  End Function

  Public Shared Function GetEntityReference(ByRef rDBConn As clsDBConnBase, ByVal vTableScope As String, ByVal vPrimaryKeyID As Integer) As String
    Return GetInstance.EntityReference(rDBConn, vTableScope, vPrimaryKeyID)
  End Function
End Class

