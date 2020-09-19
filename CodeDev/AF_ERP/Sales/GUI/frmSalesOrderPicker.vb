Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.Data
Imports RTIS.Elements
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB.clsGeneralA
Imports DevExpress.XtraEditors.Controls

Public Class frmSalesOrderPicker


  Private pSelectedID As Integer
  Private pSelectedSOID As Integer
  Private pSelectedIDs As Dictionary(Of Integer, Boolean)
  Private pFormController As fccInvoice


  Private pPickSO As clsPickerSalesOrder

  Public Property FormController As fccInvoice
    Get
      Return pFormController
    End Get
    Set(value As fccInvoice)
      pFormController = value
    End Set
  End Property
  Public Function GetSelectedIDs(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rSelectedIDs As Dictionary(Of Integer, Boolean)) As DialogResult
    Dim mfrm As New frmSalesOrderPicker
    Dim mSelectedIDs As New List(Of Integer)
    Dim mDialogResult As DialogResult = DialogResult.OK
    Dim mSOs As New colSalesOrders

    mfrm.FormController = New fccInvoice(rDBConn)
    mfrm.FormController.DBConn = rDBConn
    mfrm.Owner = rParentForm
    mfrm.SelectedIDs = rSelectedIDs

    If mDialogResult = DialogResult.OK Then
      rSelectedIDs = mfrm.SelectedIDs

      mfrm.FormController.LoadSalesOrders(mSOs)

      mfrm.pPickSO = New clsPickerSalesOrder(mSOs, mfrm.FormController.DBConn)
      mDialogResult = mfrm.ShowDialog()
    End If
    mfrm.Owner = Nothing
    mfrm.Dispose()
    mfrm = Nothing
    Return mDialogResult
  End Function

  Public Shared Function OpenPickerSingle(ByVal vPickerSO As clsPickerSalesOrder) As dmSalesOrder
    Dim mfrm As New frmSalesOrderPicker


    Dim mRetVal As dmSalesOrder = Nothing
    mfrm.pPickSO = vPickerSO
    mfrm.ShowDialog()

    If mfrm.pPickSO.SelectedObjects IsNot Nothing AndAlso mfrm.pPickSO.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickSO.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Property SelectedIDs() As Dictionary(Of Integer, Boolean)
    Get
      SelectedIDs = pSelectedIDs
    End Get
    Set(ByVal value As Dictionary(Of Integer, Boolean))
      pSelectedIDs = value
    End Set
  End Property



  Private Sub frmSalesOrderPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Try
      LoadCombos()
      RefreshControls()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargado el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombos()
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCustomerType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CustomerTypes))
  End Sub

  Private Sub RefreshControls()

    grdSalesOrder.DataSource = pPickSO.DataSource

  End Sub



  Private Sub repbtnSelectOt_Click(sender As Object, e As EventArgs) Handles repbtnSelectOt.Click

  End Sub

  Private Sub repbtnSelectOt_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repbtnSelectOt.ButtonClick
    Try
      Dim mItem As dmSalesOrder
      mItem = TryCast(gvSalesOrder.GetFocusedRow, dmSalesOrder)
      If mItem IsNot Nothing Then
        pPickSO.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub





End Class