Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.ERPCore

Public Class dsoAdminEmployeeOverride : Inherits dsoAdminEmployee

  'Use if table structure different or extended from the default
  'e.g. use a different dto

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Overrides Function CreateNewEmployee() As dmEmployee
    CreateNewEmployee = New dmEmployeeSM
  End Function


  Public Overrides Function LoadEmployees(ByRef rEmployees As colEmployees) As Boolean
    Dim mOk As Boolean
    Dim mdto As dtoEmployeeDTM

    Try

      If pDBConn.Connect Then
        mdto = New dtoEmployeeDTM(pDBConn)

        mOk = mdto.LoadEmployeeCollection(rEmployees)

        For Each mEmployee As dmEmployee In rEmployees
          ''  mdtoEmployeeSERoles.LoadEmployeeSERoles(mEmployee.Roles, mEmployee.EmployeeID)
        Next

        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Overrides Function SaveEmployee(ByRef rEmployee As dmEmployee) As Boolean
    Dim mOk As Boolean
    Dim mdto As dtoEmployeeDTM
    'Dim mdtoEmployeeSERoles As New dtoEmployeeSERole(pDBConn)


    Try

      If pDBConn.Connect Then
        mdto = New dtoEmployeeDTM(pDBConn)

        mOk = mdto.SaveEmployee(rEmployee)


      End If

    Catch ex As Exception
      mOk = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  ''Public Overrides Function CheckUniqueEmployeeName(ByRef rEmployee As dmEmployee) As Boolean
  ''  Dim mOk As Boolean
  ''  Dim mDuplicate As Boolean = False
  ''  Dim mCheckString As String = ""

  ''  Try
  ''    If pDBConn.Connect Then

  ''      If rEmployee.LastName IsNot Nothing Then mCheckString = mCheckString & rEmployee.LastName.Trim
  ''      If rEmployee.MiddleName IsNot Nothing Then mCheckString = mCheckString & rEmployee.MiddleName.Trim
  ''      If rEmployee.FirstName IsNot Nothing Then mCheckString = mCheckString & rEmployee.FirstName.Trim

  ''      If pDBConn.CheckStringFieldNotDuplicate(mDuplicate, "Employee", "ISNULL(LastName,'') + ISNULL(MiddleName,'') + ISNULL(FirstName,'')", "EmployeeID", mCheckString, rEmployee.EmployeeID) Then
  ''        mOk = Not mDuplicate
  ''      Else
  ''        mOk = False
  ''      End If
  ''    Else
  ''      mOk = False
  ''    End If
  ''  Catch ex As Exception
  ''    mOk = False
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try
  ''  Return mOk
  ''End Function

  Public Function HasEmployeeBeenEnrolled(ByVal vEmployeeID As Integer)
    Dim mEnrolled As Boolean = False

    Try
      If pDBConn.Connect Then
        Dim mSql As String = String.Format("SELECT * FROM TAEnrollment WHERE EmployeeID = {0}", vEmployeeID)
        Dim mReader As IDataReader = pDBConn.LoadReader(mSql)

        mEnrolled = mReader.Read

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mEnrolled
  End Function

End Class
