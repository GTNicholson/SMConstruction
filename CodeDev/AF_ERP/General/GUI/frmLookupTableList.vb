Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmLookupTableList

  Private pFormController As fccLookupTableList

  Public Shared Sub OpenForm(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)

    Dim mfrm As New frmLookupTableList
    mfrm.pFormController = New fccLookupTableList(rDBConn, rRTISGlobal)
    mfrm.ShowDialog()
  End Sub

  Private Sub frmLookupTableList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pFormController.LoadObjects()
    grdLookUpList.DataSource = pFormController.LookUpListDT
    LoadCombos()

  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.LoadGridLookUpEditiVI(grdLookUpList, gcLookupSectionCode, clsEnumsConstants.EnumToVIs(GetType(fccLookupTableList.eSelectionCode)))
  End Sub

  Private Sub RepItemButtonEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepItemButtonEdit.ButtonClick
    Dim mDataRow As DataRow
    Dim mID As Integer
    mDataRow = gvLookUpTable.GetDataRow(gvLookUpTable.FocusedRowHandle)
    mID = mDataRow.Item("LookUpTableID")

    Select Case mID
      ''Case 31 '// TimberProfiles
      ''  frmTimberProfile.OpenFormAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, eFormMode.eFMFormModeEdit)
      ''Case 33
      ''  frmIntStripDefault.OpenFormAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, eFormMode.eFMFormModeEdit)
      ''Case 39
      ''  frmSubItemTypeIron.OpenFormAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, eFormMode.eFMFormModeEdit)
      Case Else
          RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(mID, Me, pFormController.DBConn, pFormController.RTISGlobal, New clsGetLookUpExtension)
 End Select
  End Sub
End Class