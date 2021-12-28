Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmSalesOrderPhaseMilestoneStatusDetail
  Private pController As fccSalesOrderPhaseMilestoneStatusDetail

  Public ExitMode As Windows.Forms.DialogResult

  Private pIsActive As Boolean
  Private pLoadError As Boolean


  Public Shared Sub OpenForm(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus, ByVal vSalesOrderPhaseID As Integer, ByVal vCategory As Integer)
    Dim mfrm As frmSalesOrderPhaseMilestoneStatusDetail

    mfrm = New frmSalesOrderPhaseMilestoneStatusDetail
    mfrm.StartPosition = FormStartPosition.CenterParent

    mfrm.pController = New fccSalesOrderPhaseMilestoneStatusDetail(rDBConn, rSalesOrderPhaseMilestoneStatus, vSalesOrderPhaseID, vCategory)
    mfrm.ShowDialog(rParentForm)


  End Sub

  Private Sub frmSalesOrderPhaseMilestoneStatusDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False
    pLoadError = False

    Try

      pController.LoadObjects()

      LoadCombo()

      'If mOK Then LoadExtensionControls()


      If mOK Then RefreshControls()

      If mOK Then SetupUserPermissions()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True
  End Sub

  Public Sub LoadCombo()
    dtePlannedDate.Properties.NullDate = Date.MinValue
    dteActualDate.Properties.NullDate = Date.MinValue
    dteStartDate.Properties.NullDate = Date.MinValue
  End Sub

  Public Sub RefreshControls()
    Try
      pIsActive = False

      'If pController.SalesOrderPhaseMilestoneStatus.MilestoneENUM = eSalesOrderPhaseMileStone.DeliveryToSiteDate Then
      '  bbtnUpdateInCascade.Visible = True

      'Else
      bbtnUpdateInCascade.Visible = False
      'End If

      'lblTitle.Text = eSalesOrderPhaseMileStone.GetInstance.DisplayValueFromKey(pController.SalesOrderPhaseMilestone) & " for Phase : " & pController.salesorder & " - " & pController.SalesOrderPhase.JobNo
      radgrpPUStatusSetting.EditValue = CInt(pController.SalesOrderPhaseMilestoneStatus.Status)

      dteActualDate.DateTime = pController.SalesOrderPhaseMilestoneStatus.ActualDate
      dtePlannedDate.DateTime = pController.SalesOrderPhaseMilestoneStatus.TargetDate
      dteStartDate.DateTime = pController.SalesOrderPhaseMilestoneStatus.StartDate
      txtNotes.Text = pController.SalesOrderPhaseMilestoneStatus.Notes
      txtReqManDays.Text = pController.SalesOrderPhaseMilestoneStatus.ManReqDays
    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      pIsActive = True
    End Try


  End Sub

  Public Sub SetupUserPermissions()

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub UpdateObjects()
    Try

      With pController.SalesOrderPhaseMilestoneStatus
        .Status = radgrpPUStatusSetting.EditValue
        If .Status = eMilestoneStatus.Complete And clsGeneralA.IsBlankDate(.ActualDate) Then
          dteActualDate.DateTime = Today
        End If
        .TargetDate = dtePlannedDate.DateTime
        .ActualDate = dteActualDate.DateTime
        .StartDate = dteStartDate.DateTime
        .Notes = txtNotes.Text
        .ManReqDays = txtReqManDays.Text
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub frmSalesOrderPhaseMilestoneStatusDetail_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    UpdateObjects()
    RefreshControls()
    pController.SaveObjects()
  End Sub

  Private Sub RadgrpPUStatusSetting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radgrpPUStatusSetting.SelectedIndexChanged
    If pIsActive Then
      UpdateObjects()
      RefreshControls()
    End If
  End Sub

  Private Sub dtePlannedDate_Popup(sender As Object, e As EventArgs) Handles dtePlannedDate.Popup, dteActualDate.Popup
    Dim mIPopupControl As DevExpress.Utils.Win.IPopupControl
    Dim mPopupWindow As Form

    Try

      ''mIPopupControl = TryCast(sender, DevExpress.Utils.Win.IPopupControl)

      ''If mIPopupControl IsNot Nothing Then
      ''  mPopupWindow = TryCast(mIPopupControl.PopupWindow, Form)
      ''End If

      ''If mPopupWindow IsNot Nothing Then
      ''  mPopupWindow.TopMost = True
      ''End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnUpdateInCascade_Click(sender As Object, e As EventArgs) Handles bbtnUpdateInCascade.Click
    Dim mRequiredDate As DateTime

    Try

      If dteActualDate.EditValue = Date.MinValue Then
        mRequiredDate = dtePlannedDate.DateTime
      Else
        mRequiredDate = dteActualDate.EditValue

      End If
      If mRequiredDate <> Date.MinValue Then
        UpdateObjects()

        pController.SetPhaseDateRequired(mRequiredDate)

        pController.UpdateMilesStones(mRequiredDate)
        RefreshControls()
      Else
        MessageBox.Show("Please, enter a valid Date")
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub dtePlannedDate_DateTimeChanged(sender As Object, e As EventArgs) Handles dtePlannedDate.DateTimeChanged


  End Sub



  Private Sub frmSalesOrderPhaseMilestoneStatusDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed

  End Sub
End Class