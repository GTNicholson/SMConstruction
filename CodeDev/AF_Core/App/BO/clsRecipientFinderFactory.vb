Imports RTIS.ERPCore
Imports RTIS.WorkflowCore

Public Class clsRecipientFinderFactory : Inherits clsRecipientFinderFactoryBase
  Public Const cUsers As Integer = 1

  Public Overrides Function CreateRecipientFinder(ByVal vRecipientFinderID As Integer, ByRef rEventObject As Object) As clsRecipientFinderBase 'intWorkflowEventObject) As clsRecipientFinderBase
    Dim mRetVal As clsRecipientFinderBase = Nothing
    Select Case vRecipientFinderID
      Case cUsers
        mRetVal = New clsRecipientFinderQuoteFollowUp(rEventObject)
    End Select

    If mRetVal IsNot Nothing Then mRetVal.DBConn = Me.DBConn
    Return mRetVal
  End Function

End Class

Public Class clsRecipientFinderQuoteFollowUp : Inherits clsRecipientFinderBase


  Public Sub New(ByRef rEventObject As Object) 'intWorkflowEventObject)
    MyBase.New(rEventObject)
  End Sub

  Public Overrides Function GetRecipients(ByVal vRecipientItemID As Integer) As colWorkflowRecipients 'List(Of clsWorkflowRecipient)
    Dim mRecipients As New colWorkflowRecipients 'List(Of clsWorkflowRecipient)
    Dim mRecipient As New clsWorkflowRecipient
    Dim mUsers As colRTISUsers
    Dim mUser As RTIS.DataLayer.clsRTISUser

    'Look through employees for role "Follow Up quotes" then find the users
    Dim mEmployees As colEmployees = New colEmployees 'CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.EmpQuoteFollowUp), colEmployees)

    '  mUsers = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Users), colRTISUsers)

    If vRecipientItemID > 0 Then
      mUser = mUsers.UserFromEmployeeID(vRecipientItemID)
      If Not mUser Is Nothing Then
        mRecipient.UserID = mUser.UserID
        mRecipients.Add(mRecipient)
      End If
    Else
      For Each mEmployee As dmEmployee In mEmployees
        mRecipient = New clsWorkflowRecipient()
        mUser = mUsers.UserFromEmployeeID(mEmployee.EmployeeID)
        If Not mUser Is Nothing Then
          mRecipient.UserID = mUser.UserID
          mRecipients.Add(mRecipient)
        End If
      Next
    End If

    Return mRecipients
  End Function


End Class


