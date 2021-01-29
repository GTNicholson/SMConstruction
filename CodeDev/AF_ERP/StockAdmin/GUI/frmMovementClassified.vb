Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmMovementClassified
  Private Shared sActiveForms As Collection
  Private pDictionary As Tuple(Of Integer, Integer)

  Public Shared Function OpenFormI(ByRef rDBConn As clsDBConnBase) As Tuple(Of Integer, Integer)
    Dim mfrm As frmMovementClassified = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmMovementClassified

      mfrm.ShowDialog()
    Else
      mfrm.Focus()
    End If

    Return mfrm.pDictionary
  End Function
  Private Shared Function GetFormIfLoaded() As frmMovementClassified
    Dim mfrmWanted As frmMovementClassified = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmMovementClassified
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmMovementClassified Then
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
  Private Sub frmMovementClassified_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mValueItem As clsValueItem
    Dim mValueItems As New colValueItems
    Dim mListValueItem As New colValueItems


    mValueItems = eStockItemTypeTimberWood.GetInstance.ValueItems

    If mValueItems IsNot Nothing Then
      For Each mValueItem In mValueItems
        Select Case mValueItem.ItemValue
          Case eStockItemTypeTimberWood.Primera, eStockItemTypeTimberWood.Segunda, eStockItemTypeTimberWood.Tercera, eStockItemTypeTimberWood.ClasificadoZ
            mListValueItem.Add(mValueItem)
        End Select
      Next

    End If

    If mListValueItem IsNot Nothing And mListValueItem.Count > 0 Then

      For Each mValueItem In mListValueItem
        cboLocations.Properties.Items.Add(mValueItem)
      Next
    End If
  End Sub

  Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
    Dim mTimberTypeID As Integer
    Dim mCardNumber As Integer
    mTimberTypeID = TryCast(cboLocations.SelectedItem, clsValueItem).ItemValue

    mCardNumber = Val(txtCardNumber.Text)

    pDictionary = New Tuple(Of Integer, Integer)(mTimberTypeID, mCardNumber)

    Me.Close()
  End Sub

  Private Sub txtCardNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCardNumber.KeyDown

  End Sub
End Class