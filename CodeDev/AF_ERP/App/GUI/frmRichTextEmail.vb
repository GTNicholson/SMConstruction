Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.IO.FileInfo
Imports System.IO.FileSystemInfo
Imports System.Windows.Forms
Imports RTIS.EmailLib
Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.ERPCore
Imports RTIS.WorkflowCore

Public Class frmRichTextEmail
  Private ReadOnly pDBConn As clsDBConnBase
  Private pEmailManager As clsEmailManager
  Private pLayoutType As eLayoutType
  Private pReceivedEmail As dmReceivedEmail
  Private pRTISGlobal As AppRTISGlobal
  Private pCustomer As dmCustomer
  Private pEmployees As colEmployees

  Public Property InitialAttachmentSaveDirectory As String

  Public Property EmailSettings() As clsEmailSettings
    Get
      Return pEmailManager.EmailSettings
    End Get
    Set(ByVal value As clsEmailSettings)
      pEmailManager.EmailSettings = value
    End Set
  End Property

  Public Property EmailMessage() As clsEmailMessage
    Get
      Return pEmailManager.EmailMessage
    End Get
    Set(ByVal value As clsEmailMessage)
      pEmailManager.EmailMessage = value
    End Set
  End Property

  Public Property Employees As colEmployees
    Get
      Return pEmployees
    End Get
    Set(value As colEmployees)
      pEmployees = value
    End Set
  End Property

  Public Sub PopulateMail()
    Dim mclsRichEditList As RTIS.CommonVB.clsValueItem

    With pEmailManager.EmailMessage
      txtTo.Text = .SendTo
      txtCc.Text = .SendToCC
      txtBcc.Text = .SendToBCC
      txtFrom.Text = .SendFrom
      txtSubject.Text = .Subject

      If pLayoutType = eLayoutType.EmailEditable Then
        recMessageBody.HtmlText = .BodyHtml
      Else
        recMessageBody.Text = .Body
      End If

      imgListAttach.Items.Clear()
      For Each mclsRichEditList In .Attachments

        If Not mclsRichEditList.DisplayValue.ToUpper.StartsWith("IMAGE") Then
          imgListAttach.Items.Add(mclsRichEditList.DisplayValue)
        End If

      Next

      LoadContacts()
    End With
  End Sub

  Public Sub UpdateMail()

    With EmailMessage
      .SendTo = txtTo.Text
      .SendToCC = txtCc.Text
      .SendToBCC = txtBcc.Text
      .SendFrom = txtFrom.Text
      .Subject = txtSubject.Text
      .BodyHtml = recMessageBody.HtmlText
      .Body = recMessageBody.Text
      .Attachments = New RTIS.CommonVB.colValueItems
      For Each mItem As DevExpress.XtraEditors.Controls.ImageListBoxItem In imgListAttach.Items
        .AddAttachment(mItem.Value)
      Next
    End With
  End Sub

  Public Sub New(ByRef rEmailManager As clsEmailManager, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, Optional ByVal vCustomer As dmCustomer = Nothing)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pEmailManager = rEmailManager
    pDBConn = rDBConn
    pLayoutType = eLayoutType.EmailEditable
    pReceivedEmail = Nothing
    pRTISGlobal = rRTISGlobal
    pCustomer = vCustomer
  End Sub

  Public Sub New(ByRef rEmailManager As clsEmailManager, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vLayoutType As eLayoutType, ByRef rReceivedEmail As dmReceivedEmail)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pEmailManager = rEmailManager
    pDBConn = rDBConn
    pLayoutType = vLayoutType
    pReceivedEmail = rReceivedEmail
    pRTISGlobal = rRTISGlobal
  End Sub

  Private Sub SetLayout()

    If (pLayoutType = eLayoutType.EmailReadOnly) Then
      barbtnAttachFile.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      barbtnSend.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      barbtnSpool.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      barbtnProperties.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

      barbtnSaveAttachment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    Else
      barbtnAttachFile.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      barbtnSend.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

      barbtnSpool.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

      'barbtnSpool.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


      barbtnProperties.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

      barbtnSaveAttachment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End If

    txtTo.Properties.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)
    txtSubject.Properties.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)
    txtFrom.Properties.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)
    txtCc.Properties.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)
    txtBcc.Properties.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)

    recMessageBody.ReadOnly = (pLayoutType = eLayoutType.EmailReadOnly)

    If pCustomer IsNot Nothing Or pEmployees IsNot Nothing Then
      txtTo.Properties.Buttons(0).Visible = True
    Else
      txtTo.Properties.Buttons(0).Visible = False
    End If

  End Sub
  Private Sub LoadContacts()

    If pCustomer IsNot Nothing Then

      For Each mContact As dmCustomerContact In pCustomer.CustomerContacts

        If Not String.IsNullOrEmpty(mContact.Email) Then

          If Not String.IsNullOrEmpty(txtTo.Text) Then
            txtTo.Text &= "; "
          End If

          txtTo.Text &= mContact.Email
        End If


      Next

    End If

  End Sub

  Private Sub imgListAttach_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles imgListAttach.KeyDown
    Dim myBox As DevExpress.XtraEditors.ImageListBoxControl
    Dim mAttachName As String

    Try
      myBox = CType(sender, DevExpress.XtraEditors.ImageListBoxControl)

      If e.KeyCode = Keys.Delete AndAlso pLayoutType = eLayoutType.EmailEditable Then
        If myBox.SelectedIndices.Count = 0 Then
          Return
        Else
          mAttachName = myBox.SelectedValue
          UpdateMail()
          pEmailManager.EmailMessage.RemoveAttachment(mAttachName)
          PopulateMail()
        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnAttachFile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAttachFile.ItemClick
    Dim mFileNames As String()
    Dim mLoop As Integer
    Dim mResult As DialogResult

    Try
      OpenFileDialog1.Multiselect = True
      OpenFileDialog1.Title = "Select Files To Attach"
      OpenFileDialog1.ValidateNames = True
      OpenFileDialog1.AddExtension = True
      OpenFileDialog1.Filter = "All files (*.*)|*.*"

      mResult = OpenFileDialog1.ShowDialog()
      If mResult = Windows.Forms.DialogResult.OK Then
        mFileNames = OpenFileDialog1.FileNames
        For mLoop = 0 To mFileNames.GetUpperBound(0)
          imgListAttach.Items.Add(mFileNames(mLoop))
        Next
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnClose.ItemClick
    UpdateMail()
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
    Close()
  End Sub

  Private Sub barbtnSend_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSend.ItemClick
    Try
      Cursor = Cursors.WaitCursor
      UpdateMail()

      Dim mExporter As New clsRichEditMailMessageExporter(recMessageBody, EmailMessage)
      mExporter.Export()

      If pEmailManager.SendMail() Then
        Cursor = Cursors.Default
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Close()
      Else
        Cursor = Cursors.Default
        MsgBox(pEmailManager.EmailMessage.ErrorDesc, MsgBoxStyle.OkOnly, "Email Message Failed")
      End If

    Catch ex As Exception
      Cursor = Cursors.Default
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnSpool_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSpool.ItemClick
    Try
      Cursor = Cursors.WaitCursor
      UpdateMail()

      Dim mExporter As New clsRichEditMailMessageExporter(recMessageBody, EmailMessage)
      mExporter.Export()

      If clsWorkflowEventHandler.ProcessWorkflowEvent(clsWorkflowEventHandler.WFESpoolEmail, EmailMessage, pDBConn) Then
        Cursor = Cursors.Default
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Close()
      Else
        Cursor = Cursors.Default
        MsgBox(pEmailManager.EmailMessage.ErrorDesc, MsgBoxStyle.OkOnly, "Email Message Failed")
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub barbtnProperties_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProperties.ItemClick
    Dim mfrm As frmEmailProps

    Try
      mfrm = New frmEmailProps(pEmailManager)
      mfrm.EmailSettings = EmailSettings

      mfrm.ShowDialog()

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Public Enum eLayoutType
    EmailEditable = 1
    EmailReadOnly = 2
  End Enum

  Private Sub barbtnSaveAttachment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSaveAttachment.ItemClick
    Try
      Dim mAttachmentFile As String = imgListAttach.SelectedValue
      Dim mFileName As String = String.Empty

      Dim mSaveFileDialog As New SaveFileDialog()

      mSaveFileDialog.Title = "Save Attachment"
      mSaveFileDialog.Filter = "All files (*.*)|*.*"
      mSaveFileDialog.InitialDirectory = Me.InitialAttachmentSaveDirectory
      mSaveFileDialog.FileName = mAttachmentFile

      If mSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        mFileName = mSaveFileDialog.FileName

        If Not String.IsNullOrEmpty(mFileName) AndAlso Not String.IsNullOrEmpty(mAttachmentFile) Then
          'clsPopMessageService.SaveAttachment(pReceivedEmail, mFileName, mAttachmentFile)
        End If

        MsgBox("Attachment Saved")
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub txtTo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTo.ButtonClick
    Try

      'If pCustomer IsNot Nothing Then
      '  Dim mContacts As colContacts = frmCustomerContactPicker.SelectCustomerContact(pCustomer.Contacts)

      '  For Each mContact As clsContact In mContacts

      '    If Not String.IsNullOrEmpty(mContact.Email) Then

      '      If Not String.IsNullOrEmpty(txtTo.Text) Then
      '        txtTo.Text &= "; "
      '      End If

      txtTo.Text &= "axelroman1992@gmail.com" 'mContact.Email
      '  End If

      'Next

      'ElseIf pEmployees IsNot Nothing Then

      '  Dim mEmployees As colEmployees = frmEmployeePicker.SelectEmployees(pEmployees)

      '  For Each mEmployee As dmEmployee In mEmployees

      '    If Not String.IsNullOrEmpty(mEmployee.Email) Then

      '      If Not String.IsNullOrEmpty(txtTo.Text) Then
      '        txtTo.Text &= "; "
      '      End If

      '      txtTo.Text &= mEmployee.Email
      '    End If

      '  Next

      'End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmRichTextEmail_Load(sender As Object, e As EventArgs) Handles Me.Load
    SetLayout()
  End Sub
End Class