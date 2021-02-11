Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock



Public Class frmWoodPalletPicker
  Private pRTISGlobal As AppRTISGlobal

  Private pPickerWoodPalletBase As clsPickerWoodPallet
  Private pRemainOpen As Boolean
  Private pWoodPalletType As Integer
  Private pActive As Boolean
  Private pMode As ePickerMode

  Public Enum ePickerMode
    SinglePick = 1
    MultiPick = 2
  End Enum

  Public Property WoodPalletType As Integer
    Get
      Return pWoodPalletType
    End Get
    Set(value As Integer)
      pWoodPalletType = value
    End Set
  End Property

  Public Shared Function PickWoodPallet(ByRef rPickerWoodPallet As clsPickerWoodPallet, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPickMode As ePickerMode) As Boolean
    Dim mfrm As frmWoodPalletPicker
    Dim mCreated As Boolean = False
    mfrm = New frmWoodPalletPicker
    mfrm.pPickerWoodPalletBase = rPickerWoodPallet
    mfrm.pRTISGlobal = rRTISGlobal
    mfrm.pRemainOpen = True
    mfrm.pMode = vPickMode



    mfrm.ShowDialog()
    Return True
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerWoodPallet As clsPickerWoodPallet) As dmWoodPallet
    Dim mfrm As New frmWoodPalletPicker
    Dim mRetVal As dmWoodPallet

    mfrm.pMode = ePickerMode.SinglePick
    mfrm.pPickerWoodPalletBase = vPickerWoodPallet
    mfrm.ShowDialog()

    If mfrm.pPickerWoodPalletBase.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerWoodPalletBase.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerWoodPalletBase.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vWoodPallet As clsPickerWoodPallet, ByVal vRemainOpen As Boolean, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWoodPalletType As Integer) As List(Of dmWoodPallet)
    Dim mfrm As New frmWoodPalletPicker
    Dim mRetVal As New List(Of dmWoodPallet)

    mfrm.pMode = ePickerMode.MultiPick
    mfrm.pWoodPalletType = vWoodPalletType
    mfrm.pPickerWoodPalletBase = vWoodPallet
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerWoodPalletBase.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerWoodPalletBase.SelectedObjects.Count > 0 Then
      For Each mItem As dmWoodPallet In mfrm.pPickerWoodPalletBase.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function

  Private Sub frmPickerProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try
      pActive = False
      LoadCombo()
      If pWoodPalletType = eStockItemTypeTimberWood.Rollo Then
        gcFarm.Visible = True
      Else
        gcFarm.Visible = False
      End If
      grdWoodPallet.DataSource = pPickerWoodPalletBase.DataSource
      pActive = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema en cargar el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombo()


  End Sub


  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepbtnSelect.ButtonClick
    Try
      Dim mWoodPallet As dmWoodPallet

      Select Case pMode
        Case ePickerMode.SinglePick

          mWoodPallet = TryCast(gvWoodPallets.GetFocusedRow, dmWoodPallet)
          If mWoodPallet IsNot Nothing Then
            pPickerWoodPalletBase.SelectedObjects.Add(mWoodPallet)
            Me.Close()
          End If

        Case ePickerMode.MultiPick
          mWoodPallet = TryCast(gvWoodPallets.GetFocusedRow, dmWoodPallet)
          If mWoodPallet IsNot Nothing Then
            pPickerWoodPalletBase.SelectedObjects.Add(mWoodPallet)
            If pRemainOpen = False Then Me.Close()
          End If
      End Select

      If pPickerWoodPalletBase.SelectedObjects.Count = 1 Then
        pPickerWoodPalletBase.PalletType = pPickerWoodPalletBase.SelectedObjects(0).PalletType
        pPickerWoodPalletBase.RefreshDataSource()
        grdWoodPallet.DataSource = pPickerWoodPalletBase.DataSource
      End If
      gvWoodPallets.CloseEditor()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repbtnUnSelect.ButtonClick
    Try
      Dim mWoodPallet As dmWoodPallet
      mWoodPallet = TryCast(gvWoodPallets.GetFocusedRow, dmWoodPallet)

      If mWoodPallet IsNot Nothing Then
        pPickerWoodPalletBase.SelectedObjects.Remove(mWoodPallet)
        If pRemainOpen = False Then Me.Close()
      End If

      If pPickerWoodPalletBase.SelectedObjects.Count = 0 And pPickerWoodPalletBase.PalletType = 0 Then
        pPickerWoodPalletBase.PalletType = 0
        pPickerWoodPalletBase.RefreshDataSource()
        grdWoodPallet.DataSource = pPickerWoodPalletBase.DataSource
      End If

      gvWoodPallets.CloseEditor()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvWoodPallets.CustomRowCellEdit
    Dim mRow As dmWoodPallet
    mRow = TryCast(gvWoodPallets.GetRow(e.RowHandle), dmWoodPallet)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcWoodPalletRef.Name Then

        If pPickerWoodPalletBase.SelectedObjects.Contains(mRow) Then
          e.RepositoryItem = repbtnUnSelect
        Else
          e.RepositoryItem = RepbtnSelect
        End If

      End If

    End If
  End Sub

  Private Sub btnConfirmSelection_Click(sender As Object, e As EventArgs) Handles btnConfirmSelection.Click

    Me.Close()
  End Sub

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    Me.Close()
  End Sub
End Class