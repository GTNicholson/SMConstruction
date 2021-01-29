Imports System.ComponentModel.Design
Imports DevExpress.XtraReports.UserDesigner

Public Class frmReportDesigner
  Private pFileName As String
  Private pObject As Object
  Private pSetFileName As Boolean
  Private pDisplayName As String

  Public Shared Function OpenAsDialog(ByVal vFileName As String, ByRef rObject As Object) As DialogResult
    Dim mfrm As New frmReportDesigner

    mfrm.pFileName = vFileName
    mfrm.pObject = rObject
    mfrm.pSetFileName = False
    mfrm.pDisplayName = String.Empty
    Return mfrm.ShowDialog()
  End Function


  Private Sub frmReportDesigner_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      If String.IsNullOrEmpty(Me.pFileName) Then
        ' ReportDesigner1.CreateNewReport()
      ElseIf IO.File.Exists(pFileName) Then
        ReportDesigner1.OpenReport(pFileName)
      Else
        pSetFileName = True
        Dim mRep As New DevExpress.XtraReports.UI.XtraReport

        Dim info As Reflection.MethodInfo = ReportDesigner1.GetType().GetMethod("CreateNewReportWizard", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        Dim Result = info.Invoke(ReportDesigner1, Nothing)

        ReportDesigner1.ActiveDesignPanel.Report.SaveLayoutToXml(pFileName)

        ReportDesigner1.ActiveDesignPanel.SaveReport(pFileName)

        ReportDesigner1.ActiveDesignPanel.OpenReport(pFileName)

      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub


  Private Sub ReportDesigner1_DesignPanelLoaded(sender As Object, e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs) Handles ReportDesigner1.DesignPanelLoaded
    If (sender IsNot Nothing) Then
      sender.Report.DataSource = pObject
      Dim mHost As IDesignerHost = sender.GetService(GetType(IDesignerHost))

      If Not String.IsNullOrEmpty(pDisplayName) Then
        CType(sender, XRDesignPanel).Report.Site.Name = "CurrentReportDesign" 'pDisplayName
        CType(sender, XRDesignPanel).Report.DisplayName = pDisplayName
      End If

      FieldListDockPanel1.UpdateDataSource(mHost)
      'If pSetFileName Then CType(sender.Report, DevExpress.XtraReports.UI.XtraReport).SaveLayoutToXml(pFileName)
    End If
  End Sub


End Class