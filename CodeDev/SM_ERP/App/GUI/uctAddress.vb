Imports RTIS.ERPCore
Imports RTIS.CommonVB

Public Class uctAddress

  Private pAddress As intAddress
  Private pControlsReadOnly As Boolean
  Private pThirdAddressLine As Boolean
  Private pMainLabel As String

  Public Property Address() As intAddress
    Get
      Address = pAddress
    End Get
    Set(ByVal value As intAddress)
      pAddress = value
    End Set
  End Property

  Public Property ControlsReadOnly() As Boolean
    Get
      ControlsReadOnly = pControlsReadOnly
    End Get
    Set(ByVal value As Boolean)
      pControlsReadOnly = value
      Me.txtAdd1.Properties.ReadOnly = pControlsReadOnly
      Me.txtAdd2.Properties.ReadOnly = pControlsReadOnly
      '' Me.txtAdd3.Properties.ReadOnly = pControlsReadOnly
      Me.txtTown.Properties.ReadOnly = pControlsReadOnly
      Me.cboCountry.Properties.ReadOnly = pControlsReadOnly
      ''  Me.txtPostCode.Properties.ReadOnly = pControlsReadOnly
      ' ''Me.btedCountry.Properties.ReadOnly = pControlsReadOnly
    End Set
  End Property

  Public Property ThirdAddressLine() As Boolean
    Get
      ThirdAddressLine = pThirdAddressLine
    End Get
    Set(ByVal value As Boolean)
      pThirdAddressLine = value
      '' Me.txtAdd3.Visible = pThirdAddressLine
      If pThirdAddressLine Then
        '' Me.txtTown.Top = Me.txtAdd3.Top + Me.txtAdd3.Height
      Else
        ''Me.txtTown.Top = Me.txtAdd3.Top
      End If
      Me.cboCountry.Top = Me.txtTown.Top + Me.txtTown.Height
      ''  Me.txtPostCode.Top = Me.cboCountry.Top
      ' ''Me.btedCountry.Top = Me.txtPostCode.Top + Me.txtPostCode.Height
      Me.lblTown.Top = Me.txtTown.Top
      Me.lblCounty.Top = Me.cboCountry.Top
      '' Me.lblPostCode.Top = Me.txtPostCode.Top
      ' ''Me.lblCountry.Top = Me.btedCountry.Top
    End Set
  End Property

  Public Property MainLabel() As String
    Get
      MainLabel = pMainLabel
    End Get
    Set(ByVal value As String)
      pMainLabel = value
      If clsGeneralA.StringLength(pMainLabel) > 0 Then
        lblMainLabel.Text = pMainLabel
      Else
        lblMainLabel.Text = "Dirección"
      End If
    End Set
  End Property

  Public Sub RefreshControls()
    With pAddress
      Me.txtAdd1.Text = .Address1
      Me.txtAdd2.Text = .Address2
      ''  Me.txtAdd3.Text = .Address3
      Me.txtTown.Text = .Town
      cboCountry.Text = .Country
      '' Me.txtPostCode.Text = .PostCode
      ' ''Me.btedCountry.Text = .Country


    End With
  End Sub

  Public Sub UpdateObject()
    With pAddress
      .Address1 = Me.txtAdd1.Text
      .Address2 = Me.txtAdd2.Text
      '' .Address3 = Me.txtAdd3.Text
      .Town = Me.txtTown.Text
      .Country = Me.cboCountry.Text
      '' .PostCode = Me.txtPostCode.Text
      ' ''.Country = Me.btedCountry.Text
    End With
  End Sub

  Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

  End Sub

  Private Sub lblCounty_Click(sender As Object, e As EventArgs) Handles lblCounty.Click

  End Sub

  Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged

  End Sub
End Class
