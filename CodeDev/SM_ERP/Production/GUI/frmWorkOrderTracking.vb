Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB

Public Class frmWorkOrderTracking
  Private pController As fccWorkOrderTracking

  Public Shared Sub OpenFormMDI(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmWorkOrderTracking
    mfrm = New frmWorkOrderTracking
    mfrm.pController = New fccWorkOrderTracking(rDBConn)
    mfrm.MdiParent = rMDI
    mfrm.Show()
  End Sub

  Private Sub frmWorkOrderTracking_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mMsg As String
    Dim mOK As Boolean
    Dim mErrorDisplayed As Boolean
    Try

      pController.LoadObjects()
      grdWorksOrders.DataSource = pController.WorkOrderTrackings
      mOK = True

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))
    End If
  End Sub


  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub gvWorksOrders_DoubleClick(sender As Object, e As EventArgs) Handles gvWorksOrders.DoubleClick
    Dim mWorkOrderTracking As clsWorkOrderTracking
    Dim mWorkOrderID As Integer
    Dim mCategory As eWorkCentre
    Dim mWorkOrderMileStoneStatus As dmWorkOrderMilestoneStatus
    Dim mColTag As Object

    Try
      If gvWorksOrders.FocusedRowHandle >= 0 Then
        mColTag = gvWorksOrders.FocusedColumn.Tag
        If IsNumeric(mColTag) Then
          mCategory = CType(mColTag, eWorkCentre)
          mWorkOrderTracking = CType(gvWorksOrders.GetFocusedRow, clsWorkOrderTracking)
          mWorkOrderID = mWorkOrderTracking.WorkOrderID

          mWorkOrderMileStoneStatus = mWorkOrderTracking.MileStones.ItemFromMilestoneENUM(mCategory)
          If mWorkOrderMileStoneStatus Is Nothing Then
            mWorkOrderMileStoneStatus = New dmWorkOrderMilestoneStatus
            mWorkOrderMileStoneStatus.MilestoneENUM = mCategory
            mWorkOrderMileStoneStatus.WorkOrderID = mWorkOrderID
            mWorkOrderMileStoneStatus.Status = eMilestoneStatus.Pending
            mWorkOrderTracking.MileStones.Add(mWorkOrderMileStoneStatus)
          End If

          frmWorkOrderMilestoneStatus.OpenForm(Me, pController.DBConn, mWorkOrderMileStoneStatus)

          gvWorksOrders.RefreshRow(gvWorksOrders.FocusedRowHandle)
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvWorksOrders_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWorksOrders.CustomUnboundColumnData
    Dim mWorkOrderTracking As clsWorkOrderTracking
    Dim mMileStone As eMilestoneStatus
    Dim mWorkOrderMileStoneStatus As dmWorkOrderMilestoneStatus
    Dim mColTag As Object
    Dim mText As String = ""
    Dim mPickText As String = ""

    Try
      If e.IsGetData Then

        mColTag = e.Column.Tag
        If IsNumeric(mColTag) Then
          mMileStone = CType(mColTag, eMilestoneStatus)
          mWorkOrderTracking = CType(e.Row, clsWorkOrderTracking)

          mWorkOrderMileStoneStatus = mWorkOrderTracking.MileStones.ItemFromMilestoneENUM(mMileStone)
          If mWorkOrderMileStoneStatus IsNot Nothing Then
            Select Case mWorkOrderMileStoneStatus.Status
              Case eMilestoneStatus.NotRequired
                mText = "-"
              Case eMilestoneStatus.Pending
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  mText = mWorkOrderMileStoneStatus.TargetDate.ToString("dd-MMM")
                Else
                  mText = ""
                End If
              Case eMilestoneStatus.PartComplete
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  mText = mWorkOrderMileStoneStatus.TargetDate.ToString("dd-MMM")
                Else
                  mText = ""
                End If
              Case eMilestoneStatus.Complete
                mText = mWorkOrderMileStoneStatus.ActualDate.ToString("dd-MMM")
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  mText &= vbCrLf & DateDiff(DateInterval.Day, mWorkOrderMileStoneStatus.TargetDate, mWorkOrderMileStoneStatus.ActualDate).ToString("+0;-#")
                End If
            End Select
            If Not String.IsNullOrWhiteSpace(mWorkOrderMileStoneStatus.Notes) Then
              mText &= " (*)"
            End If
            e.Value = mText
          Else

          End If
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvWorksOrders_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvWorksOrders.RowCellStyle
    Try
      Select Case e.Column.Name
        Case gcDiseno.Name, gcInginiero.Name, gcMachining.Name, gcAssembly.Name, gcMetalWork.Name, gcPainting.Name, gcSanding.Name, gcUpholstery.Name
          Dim mRow As clsWorkOrderTracking = gvWorksOrders.GetRow(e.RowHandle)
          Dim mStatus As dmWorkOrderMilestoneStatus
          Dim mStatusID As Integer
          If mRow IsNot Nothing Then

            mStatus = mRow.MileStones.ItemFromMilestoneENUM(e.Column.Tag)

            If mStatus Is Nothing Then
              mStatusID = eMilestoneStatus.Pending
            Else
              mStatusID = mStatus.Status
            End If
            Select Case mStatusID
              Case eMilestoneStatus.Pending, eMilestoneStatus.PartComplete
                If mStatus Is Nothing Then
                  If RTIS.CommonVB.clsGeneralA.IsBlankDate(mRow.FinishDate) Then
                    e.Appearance.BackColor = Color.White
                  Else
                    If Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.FinishDate).AddDays(-7) Then
                      e.Appearance.BackColor = Color.Tomato
                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.FinishDate) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White
                    End If
                  End If
                Else
                  If Now >= mStatus.TargetDate Then
                    e.Appearance.BackColor = Color.Tomato
                  ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mStatus.TargetDate) Then
                    e.Appearance.BackColor = Color.Gold
                  Else
                    e.Appearance.BackColor = Color.White
                  End If
                End If
              Case eMilestoneStatus.NotRequired
                e.Appearance.BackColor = Color.Lavender
              'Case eMilestoneStatus.PartComplete
              '  e.Appearance.BackColor = Color.Gold
              Case eMilestoneStatus.Complete
                e.Appearance.BackColor = Color.YellowGreen
            End Select

          End If
          e.Appearance.ForeColor = Color.Black
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvWorksOrders_CustomDrawGroupRow(sender As Object, e As RowObjectCustomDrawEventArgs) Handles gvWorksOrders.CustomDrawGroupRow
    Dim mView As DevExpress.XtraGrid.Views.Grid.GridView = sender
    Dim mInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)

    If IsDate(mView.GetGroupRowValue(e.RowHandle, mInfo.Column)) Then
      Dim mVal As DateTime = mView.GetGroupRowValue(e.RowHandle, mInfo.Column)

      If RTIS.CommonVB.clsGeneralA.IsBlankDate(mVal) Then
        mInfo.GroupText = "No Planificado"
      Else
        mInfo.GroupText = "Semana: " & mVal.ToString("dd/MM/yyyy")
      End If
    End If
  End Sub
End Class