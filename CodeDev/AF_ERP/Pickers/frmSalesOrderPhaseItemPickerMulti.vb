Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock



Public Class frmSalesOrderPhaseItemPickerMulti
  Private pRTISGlobal As AppRTISGlobal

  Private pPickerProductBase As clsPickerSalesOrderPhaseItem
  Private pRemainOpen As Boolean
  Private pSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
  Private pActive As Boolean
  Private pMode As ePickerMode

  Public Enum ePickerMode
    SinglePick = 1
    MultiPick = 2
  End Enum

  Public Property ProductBase As clsSalesOrderPhaseItemInfo
    Get
      Return pSalesOrderPhaseItemInfo
    End Get
    Set(value As clsSalesOrderPhaseItemInfo)
      pSalesOrderPhaseItemInfo = value
    End Set
  End Property


  Public Shared Function PickSalesOrderPhaseItemInfo(ByRef rPickerSOPI As clsPickerSalesOrderPhaseItem, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPickMode As ePickerMode) As Boolean
    Dim mfrm As frmSalesOrderPhaseItemPickerMulti
    Dim mCreated As Boolean = False
    mfrm = New frmSalesOrderPhaseItemPickerMulti
    mfrm.pPickerProductBase = rPickerSOPI
    mfrm.pRTISGlobal = rRTISGlobal
    mfrm.pRemainOpen = True
    mfrm.pMode = vPickMode



    mfrm.ShowDialog()
    Return True
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerSOPI As clsPickerSalesOrderPhaseItem) As clsSalesOrderPhaseItemInfo
    Dim mfrm As New frmSalesOrderPhaseItemPickerMulti
    Dim mRetVal As clsSalesOrderPhaseItemInfo

    mfrm.pMode = ePickerMode.SinglePick
    mfrm.pPickerProductBase = vPickerSOPI
    mfrm.ShowDialog()

    If mfrm.pPickerProductBase.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerProductBase.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerProductBase.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vPickerSOPI As clsPickerSalesOrderPhaseItem, ByVal vRemainOpen As Boolean, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As List(Of clsSalesOrderPhaseItemInfo)
    Dim mfrm As New frmSalesOrderPhaseItemPickerMulti
    Dim mRetVal As New List(Of clsSalesOrderPhaseItemInfo)

    mfrm.pMode = ePickerMode.MultiPick
    mfrm.pPickerProductBase = vPickerSOPI
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerProductBase.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerProductBase.SelectedObjects.Count > 0 Then
      For Each mItem As clsSalesOrderPhaseItemInfo In mfrm.pPickerProductBase.SelectedObjects
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
      grdSalesOrderPhaseItemInfo.DataSource = pPickerProductBase.DataSource
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
      Dim mSOPIInfo As clsSalesOrderPhaseItemInfo

      Select Case pMode
        Case ePickerMode.SinglePick

          mSOPIInfo = TryCast(gvSalesOrderPhaseItem.GetFocusedRow, clsSalesOrderPhaseItemInfo)
          If mSOPIInfo IsNot Nothing Then
            pPickerProductBase.SelectedObjects.Add(mSOPIInfo)
            Me.Close()
          End If

        Case ePickerMode.MultiPick
          mSOPIInfo = TryCast(gvSalesOrderPhaseItem.GetFocusedRow, clsSalesOrderPhaseItemInfo)
          If mSOPIInfo IsNot Nothing Then
            pPickerProductBase.SelectedObjects.Add(mSOPIInfo)
            If pRemainOpen = False Then Me.Close()
          End If
      End Select


      gvSalesOrderPhaseItem.CloseEditor()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repbtnUnSelect.ButtonClick
    Try
      Dim mSOPIInfo As clsSalesOrderPhaseItemInfo
      mSOPIInfo = TryCast(gvSalesOrderPhaseItem.GetFocusedRow, clsSalesOrderPhaseItemInfo)

      If mSOPIInfo IsNot Nothing Then
        pPickerProductBase.SelectedObjects.Remove(mSOPIInfo)
        If pRemainOpen = False Then Me.Close()
      End If
      gvSalesOrderPhaseItem.CloseEditor()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvSalesOrderPhaseItem.CustomRowCellEdit
    Dim mRow As clsSalesOrderPhaseItemInfo
    mRow = TryCast(gvSalesOrderPhaseItem.GetRow(e.RowHandle), clsSalesOrderPhaseItemInfo)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcOrderNo.Name Then

        If pPickerProductBase.SelectedObjects.Contains(mRow) Then
          e.RepositoryItem = repbtnUnSelect
        Else
          e.RepositoryItem = RepbtnSelect
        End If

      End If

    End If
  End Sub

End Class