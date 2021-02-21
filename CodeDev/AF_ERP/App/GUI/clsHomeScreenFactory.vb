Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Interface iHomeForm

End Interface

Public Class clsHomeScreenFactory
  Private pRTISGlobal As AppRTISGlobal
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rRTISGlobal As AppRTISGlobal, ByRef rDBConn As clsDBConnBase)
    pRTISGlobal = rRTISGlobal
    pDBConn = rDBConn
  End Sub

  Public Sub LoadHomeScreen(ByRef rMDIParent As Form)
    Try
      Dim mHomeScreen As Integer = My.Application.RTISUserSession.UserListItem.HomeFormID

      Select Case mHomeScreen
        Case eHomeScreen.Management
          frmHomeManagement.OpenFormAsMDIChild(rMDIParent, My.Application.RTISUserSession, pRTISGlobal)
        Case eHomeScreen.Purchasing
          frmHomePurchasing.OpenFormAsMDIChild(rMDIParent, My.Application.RTISUserSession, pRTISGlobal)
        Case Else
          frmHomeManagement.OpenFormAsMDIChild(rMDIParent, My.Application.RTISUserSession, pRTISGlobal)
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


End Class
