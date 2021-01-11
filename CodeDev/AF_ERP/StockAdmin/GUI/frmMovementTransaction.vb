Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmMovementTransaction
  Private Shared sActiveForms As Collection
  Private pFormcontroller As fccMovementTransaction

  Public Property Formcontroller As fccMovementTransaction
    Get
      Return pFormcontroller
    End Get
    Set(value As fccMovementTransaction)
      pFormcontroller = value
    End Set
  End Property

  Public Shared Sub OpenFormI(ByRef rDBConn As clsDBConnBase, ByRef rWoodPallet As dmWoodPallet)
    Dim mfrm As frmMovementTransaction = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmMovementTransaction

      mfrm.pFormcontroller = New fccMovementTransaction
      mfrm.pFormcontroller.DBConn = rDBConn
      mfrm.pFormcontroller.WoodPallet = rWoodPallet
      mfrm.ShowDialog()
    Else
      mfrm.Focus()
    End If

  End Sub
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
    Dim mOK As Boolean = False

    mLocation = clsDEControlLoading.GetDEComboValue(cboLocations)

    mOK = pFormcontroller.ApplyWoodPalletMovement(mLocation, Now)

    If mOK Then
      MessageBox.Show("Éxito al trasladar el Pack")
    Else
      MessageBox.Show("Error al trasladar el Pack")

    End If

    Me.Close()
  End Sub

  Private Sub frmMovementTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LoadCombos()
  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboLocations, clsEnumsConstants.EnumToVIs(GetType(eLocations)))

  End Sub
End Class