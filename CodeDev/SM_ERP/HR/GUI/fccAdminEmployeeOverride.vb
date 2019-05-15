Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class fccAdminEmployeeOverride : Inherits RTIS.ERPCore.fccAdminEmployeeBase
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByVal ucc As RTIS.ERPCore.uccEmployeeDetailsBase, ByVal vDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New(ucc)
    pDBConn = vDBConn
  End Sub

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property



  Public Overrides Function LoadObject() As Boolean
    Dim mOK As Boolean = False
    Dim mdso As dsoAdminEmployeeOverride
    Try
      'Dim mdsoEmployee As New dsoAdminEmployee(pDBConn)
      Employees = New RTIS.ERPCore.colEmployees
      mdso = New dsoAdminEmployeeOverride(pDBConn)
      mOK = mdso.LoadEmployees(Employees)


      'mdsoEmployee = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function

  Public Overrides Function SaveObject() As Boolean
    Dim mOK As Boolean = False
    Dim mdso As dsoAdminEmployeeOverride
    'Dim mdsoEmployee As New dsoAdminEmployee(pDBConn)

    Try
      If uccEmployeeDetails.CurrentEmployee IsNot Nothing Then
        mdso = New dsoAdminEmployeeOverride(pDBConn)
        mOK = mdso.SaveEmployee(uccEmployeeDetails.CurrentEmployee)
      Else
        mOK = True
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      ' mdsoEmployee = Nothing
    End Try
    Return mOK
  End Function

  Public Sub RefreshEmployees()
    Dim mEmps As colEmployees
    Dim mEmpsRefList As colEmployees
    Dim mdso As New dsoAppRefLists(DBConn)
    Dim mAppGlobal As AppRTISGlobal
    mEmps = mdso.LoadEmployees
    mAppGlobal = CType(RTISGlobal, AppRTISGlobal)
    mEmpsRefList = mAppGlobal.RefLists.RefIList(appRefLists.Employees)
    mEmpsRefList.Clear()

    For Each mEmp In mEmps
      mEmpsRefList.Add(mEmp)
    Next
  End Sub

End Class
