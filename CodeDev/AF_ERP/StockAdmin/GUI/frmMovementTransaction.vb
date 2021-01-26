Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmMovementTransaction
  Private Shared sActiveForms As Collection
  Private pFormcontroller As fccMovementTransaction
  Private pFormMode As eFormMode
  Public Property Formcontroller As fccMovementTransaction
    Get
      Return pFormcontroller
    End Get
    Set(value As fccMovementTransaction)
      pFormcontroller = value
    End Set
  End Property

  Public Enum eFormMode
    Movement = 1
    None = 2
  End Enum

  Public Shared Function OpenFormI(ByRef rDBConn As clsDBConnBase, ByRef rWoodPallet As dmWoodPallet, ByVal vFormMode As eFormMode) As Integer
    Dim mfrm As frmMovementTransaction = Nothing
    Dim mLocationID As Integer

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmMovementTransaction

      mfrm.pFormcontroller = New fccMovementTransaction
      mfrm.pFormcontroller.DBConn = rDBConn
      mfrm.pFormcontroller.WoodPallet = rWoodPallet
      mfrm.pFormMode = vFormMode
      mfrm.ShowDialog()
    Else
      mfrm.Focus()
    End If
    Return mfrm.pFormcontroller.WoodPallet.LocationID
  End Function
  Private Shared Function GetFormIfLoaded() As frmMovementTransaction
    Dim mfrmWanted As frmMovementTransaction = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmMovementTransaction
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmMovementTransaction Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub btnProcessMovement_Click(sender As Object, e As EventArgs) Handles btnProcessMovement.Click
    Dim mLocation As Integer
    Dim mOK As Boolean

    If pFormMode = eFormMode.Movement Then
      mLocation = clsDEControlLoading.GetDEComboValue(cboLocations)

      mOK = pFormcontroller.ApplyWoodPalletMovement(mLocation, Now)

      If mOK Then
        MessageBox.Show("Éxito al trasladar el Pack")
      Else
        MessageBox.Show("Error al trasladar el Pack")

      End If
    End If
    Me.Close()
  End Sub

  Private Sub frmMovementTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    If pFormMode = eFormMode.Movement Then
      btnProcessMovement.Visible = True
      btnAccept.Visible = False
    ElseIf pFormMode = eFormMode.None Then
      btnProcessMovement.Visible = False
      btnAccept.Visible = True

    End If
    LoadCombos()
  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboLocations, clsEnumsConstants.EnumToVIs(GetType(eLocations)))

  End Sub

  Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
    Dim mLocation As Integer

    mLocation = clsDEControlLoading.GetDEComboValue(cboLocations)
    If mLocation > 0 Then
      pFormcontroller.WoodPallet.LocationID = mLocation
      Me.Close()
    End If
  End Sub
End Class