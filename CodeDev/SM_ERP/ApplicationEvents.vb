Imports RTIS.DataLayer
Imports RTIS.CommonVB

Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Private pRTISUserSession As clsRTISUser

        Public ReadOnly Property RTISUserSession() As clsRTISUser
            Get
                RTISUserSession = pRTISUserSession
            End Get
        End Property

        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged

        End Sub

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            Dim mMainDB As clsDBConnBase
            Try
                If Not pRTISUserSession Is Nothing Then
                    If pRTISUserSession.DBLocks.Count > 0 Then

                        clsErrorHandler.HandleError(New clsRTISErrorMessage("User locks remain on Application Shutdown!" & pRTISUserSession.DBLocks.LockDetails), clsErrorHandler.PolicyUserInterface)
                    End If
                    mMainDB = pRTISUserSession.CreateMainDBConn()
                    If Not mMainDB Is Nothing Then
                        If mMainDB.Connect Then
                            mMainDB.dsoUserLogin.LogOut(pRTISUserSession)
                            mMainDB.Disconnect()

                        End If
                        mMainDB = Nothing
                    End If
                    pRTISUserSession = Nothing
                End If
                AppRTISGlobal.KillInstance()

            Catch ex As Exception
                If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
            End Try
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            AppRTISGlobal.CreateInstance() 'New appRefLists) 'clsRTISGlobal
            pRTISUserSession = New clsRTISUser
            pRTISUserSession.InformAboutLockConflictsDelegate = AddressOf RTIS.Elements.frmDisplayMessage.DisplayLockConflicts
            pRTISUserSession.ThrowErrorOnLockFailure = False
            pRTISUserSession.LockEntitys = appLockEntitys.GetInstance
            ''pRTISUserSession.SetCreatedsoUserSessionDelegate(AddressOf dsoRTISUserSQL_VB6Link.CreatedsoRTISUserSQL_VB6Link)

            If Not appInit.StartApp(AppRTISGlobal.GetInstance, pRTISUserSession) Then
                ''MsgBox("Unable to login.")
                End
            End If


        End Sub

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim mGiveUserOption As Boolean = True

            'Log Exception Details
            Try
                AppRTISGlobal.GetInstance.ProcessUnhandledException(e.Exception, True, False)
            Catch Ex As Exception
                mGiveUserOption = False
            End Try


            Try
                'Check if a Connection
                ''If Not My.Application.MainDB Is Nothing Then
                ''  mGiveUserOption = My.Application.MainDB.OnErrorResetTransactionResumeOK()
                ''Else
                ''  mGiveUserOption = False
                ''End If
            Catch Ex As Exception
                mGiveUserOption = False
            End Try

            If mGiveUserOption Then
                If MsgBox("An unexpected error has occurred. Would you the application to attempt to retain your session (Yes)?" & vbCrLf _
        & "Select 'No' to close the application." & vbCrLf _
        & "(If you have received this message a number of times in quick succession please select 'No' to close down the application.)" & vbCrLf & vbCrLf _
        & "(Error details: " & e.Exception.Message & ")", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "RTIS") = MsgBoxResult.Yes Then
                    e.ExitApplication = False
                Else
                    'TODO Generate a log file
                    e.ExitApplication = True
                End If
            Else
                e.ExitApplication = True
            End If
        End Sub




    End Class
End Namespace
