Imports RTIS.DataLayer
Imports RTIS.WorkflowCore

'From code
'clsWorkflowEventHandler.ProcessWorkflowEvent(clsWorkflowEventHandler.WFEventOne, Object, DBConn)

Public Class clsWorkflowEventHandler 'COuld make this a base class ??
  Public Const WFEQuoteSubmitted As Integer = 1
  Public Const WFESpoolEmail As Integer = 2

  Public Shared Function ProcessWorkflowEvent(ByVal vEventID As Integer, ByRef rObject As Object, ByRef rDBConn As clsDBConnBase) As Boolean
    Dim mWorkflowEventProcess As clsWorkflowEventProcess
    Dim mdsoWorkflow As dsoWorkflowCore
    Dim mOK As Boolean = False
    Dim mAllOK As Boolean = False
    mWorkflowEventProcess = InitiateWorkflowEventProcess(vEventID, rObject, rDBConn)
    If mWorkflowEventProcess IsNot Nothing Then
      mWorkflowEventProcess.RecipientFinderFactoryBase = New clsRecipientFinderFactory
      mWorkflowEventProcess.RecipientFinderFactoryBase.DBConn = rDBConn
      mWorkflowEventProcess.ContextConverterFactoryBase = New clsContextConverterFactory 'OR set just the converter for each type of event?
      mWorkflowEventProcess.GenerateActionResults()

      mdsoWorkflow = New dsoWorkflowCore(rDBConn)
      ''mOK = mWorkflowEventProcess.SaveActionResults(mdsoWorkflow)
      mOK = mWorkflowEventProcess.SaveActionTasks(mdsoWorkflow)
      mAllOK = mOK

      ''IF Spooling for Emails etc.
      mOK = mWorkflowEventProcess.SaveActionSpool(mdsoWorkflow)
      ''Otherwise to send direct
      ''mOK = clsWorkflowEventHandler.SendEmailsDirect(mWorkflowEventProcess)

      If mOK Then mAllOK = mOK


    End If
    Return mAllOK
  End Function

  Private Shared Function SendEmailsDirect(ByRef rWorkflowEventProcess As clsWorkflowEventProcess) As Boolean
    ''Dim pWorkflowEmailHandler As New clsWorkflowEmailHandler
    ''Dim mAction As intWorkflowActionResult
    ''Dim mWorkflowSpools As New colWorkflowSpools
    ''Dim mSentOK As Boolean = True
    ''For Each mAction In rWorkflowEventProcess.ActionResults
    ''  Select Case mAction.WorkflowActionType
    ''    Case clsWorkflowENUM.eActionType.Email '', clsWorkflowENUM.eActionType.SMS ', clsWorkflowENUM.eActionType.Fax
    ''      mWorkflowSpools.Add(mAction)
    ''  End Select
    ''Next
    ''If mWorkflowSpools.Count > 0 Then

    ''  pWorkflowEmailHandler.EmailInfo = AppRTISGlobal.GetInstance.EmailInfo
    ''  pWorkflowEmailHandler.EmailFromAddress = AppRTISGlobal.GetInstance.DefaultEmailFrom
    ''  pWorkflowEmailHandler.WorkflowSpoolItems = mWorkflowSpools

    ''  mSentOK = pWorkflowEmailHandler.SendPendingEmails()

    ''  pWorkflowEmailHandler = Nothing
    ''End If
    ''Return mSentOK
  End Function


  Private Shared Function InitiateWorkflowEventProcess(ByVal vEventID As Integer, ByRef rObject As Object, ByRef rDBConn As clsDBConnBase) As clsWorkflowEventProcess
    Dim mWorkflowEventProcess As clsWorkflowEventProcess = Nothing

    Select Case vEventID
      Case WFEQuoteSubmitted 'Fully coded as EventProcess

       ' mWorkflowEventProcess = New clsWFEPQuoteSubmitted(vEventID, rDBConn, CType(rObject, clsSalesOrder))

      Case WFESpoolEmail

        '  mWorkflowEventProcess = New clsWFEPEmailQuote(vEventID, rObject)

    End Select

    Return mWorkflowEventProcess
  End Function

  Private Shared Function LoadWorkflowEventData(ByVal vEventID As Integer, ByVal mWorkflowEvent As clsWorkflowEvent, ByRef rDBConn As clsDBConnBase) As Boolean
    Dim mdsoWorkflow As dsoWorkflowCore
    Dim mOK As Boolean
    mdsoWorkflow = New dsoWorkflowCore(rDBConn)
    mOK = mdsoWorkflow.LoadWorkflowEventData(mWorkflowEvent, vEventID)
    mdsoWorkflow = Nothing
    LoadWorkflowEventData = mOK
  End Function

End Class

