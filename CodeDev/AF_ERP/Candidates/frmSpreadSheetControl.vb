Imports RTIS.CommonVB

Public Class frmSpreadSheetControl


  Public Delegate Sub dlgSpreadSheetExtBtn(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rSpreadSheet As DevExpress.Spreadsheet.IWorkbook)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pbtnExtBtn1Delegate As dlgSpreadSheetExtBtn
  Private pbtnExtBtn2Delegate As dlgSpreadSheetExtBtn
  Private pWB As DevExpress.Spreadsheet.Workbook

  Public Shared Sub OpenForm(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rBtn1Sub As dlgSpreadSheetExtBtn, ByVal vDelegate1Label As String, ByRef rBtn2Sub As dlgSpreadSheetExtBtn, ByVal vDelegate2Label As String)
    Dim mfrm As frmSpreadSheetControl
    mfrm = New frmSpreadSheetControl
    mfrm.pDBConn = rDBConn
    mfrm.MdiParent = rMDI
    mfrm.pbtnExtBtn1Delegate = rBtn1Sub
    mfrm.pbtnExtBtn2Delegate = rBtn2Sub
    mfrm.bbtnDelegate1.Caption = vDelegate1Label
    mfrm.bbtnDelegate2.Caption = vDelegate2Label
    mfrm.Show()
  End Sub

  Public Shared Sub OpenFormModal(ByRef rWorkBook As DevExpress.Spreadsheet.Workbook)
    Dim mfrm As frmSpreadSheetControl
    mfrm = New frmSpreadSheetControl
    mfrm.pWB = rWorkBook
    mfrm.ShowDialog()
  End Sub

  Public Shared Sub OpenFormModal(ByVal vFileName As String)
    Dim mWB As DevExpress.Spreadsheet.Workbook
    mWB = New DevExpress.Spreadsheet.Workbook
    mWB.LoadDocument(vFileName)
    OpenFormModal(mWB)
  End Sub

  Private Sub frmSpreadSheetControl_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mStream As IO.MemoryStream
    If pWB IsNot Nothing Then
      mStream = New IO.MemoryStream
      pWB.SaveDocument(mStream, DevExpress.Spreadsheet.DocumentFormat.Xls)
      Me.SpreadsheetBarController1.SpreadsheetControl.LoadDocument(mStream, DevExpress.Spreadsheet.DocumentFormat.Xls)
    End If
  End Sub

  Private Sub bbtnDelegate1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnDelegate1.ItemClick
    Try
      pbtnExtBtn1Delegate(pDBConn, Me.SpreadsheetControl1.Document)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub bbtnDelegate2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnDelegate2.ItemClick
    Try
      pbtnExtBtn2Delegate(pDBConn, Me.SpreadsheetControl1.Document)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


End Class