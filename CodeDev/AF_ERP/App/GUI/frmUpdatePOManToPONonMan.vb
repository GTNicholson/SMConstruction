Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmUpdatePOManToPONonMan
  Private pFormController As fccUpdatePOManToPONonMan


  Public Property FormController As fccUpdatePOManToPONonMan
    Get
      Return pFormController
    End Get
    Set(value As fccUpdatePOManToPONonMan)
      pFormController = value
    End Set
  End Property

  Public Shared Sub OpenModal(ByVal vDBConn As clsDBConnBase, ByVal vOptionString As String)
    Dim mfrm As New frmUpdatePOManToPONonMan
    mfrm.pFormController = New fccUpdatePOManToPONonMan

    mfrm.pFormController.DBConn = vDBConn
    mfrm.pFormController.OptionString = vOptionString
    mfrm.ShowDialog()

  End Sub

  Private Sub frmUpdatePOManToPONonMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    RefreshOptions()
  End Sub

  Private Sub RefreshOptions()
    Select Case pFormController.OptionString
      Case "ToNonMan"
        btnUpdate.Visible = True
        btnUpdateNonManToMan.Visible = False
        lblItem.Text = "SOP Item"
      Case "ToMan"
        btnUpdate.Visible = False
        btnUpdateNonManToMan.Visible = True
        lblItem.Text = "Pick OT"

    End Select
  End Sub

  Private Sub btnSOPItemPicker_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnSOPItemPicker.ButtonClick
    Dim mSalesOrderPhaseItemInfos As New colSalesOrderPhaseItemInfos
    Dim mPicker As clsPickerSalesOrderPhaseItem
    Dim mSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo

    Dim mWOPicker As clsPickerWorkOrder
    Dim mWOIs As New colWorkOrderInfos
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Try


      Select Case pFormController.OptionString
        Case "ToNonMan"
          pFormController.LoadSalesOrderPhaseItemInfo(mSalesOrderPhaseItemInfos, String.Format("DateRequired is not null AND OrderStatusENUM not in ({0})", CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed)))


          mPicker = New clsPickerSalesOrderPhaseItem(mSalesOrderPhaseItemInfos, pFormController.DBConn)

          mSalesOrderPhaseItemInfo = frmSalesOrderPhaseItemPickerMulti.OpenPickerSingle(mPicker)

          If mSalesOrderPhaseItemInfo IsNot Nothing Then

            pFormController.SalesOrderPhaseItemID = mSalesOrderPhaseItemInfo.SalesOrderPhaseItem.SalesOrderPhaseItemID
            pFormController.ItemRef = mSalesOrderPhaseItemInfo.ItemNumberRef
            pFormController.ItemRef2 = mSalesOrderPhaseItemInfo.Description
            pFormController.ProjectRef = mSalesOrderPhaseItemInfo.ProjectName

            btnSOPItemPicker.Text = mSalesOrderPhaseItemInfo.ItemNumberRef & mSalesOrderPhaseItemInfo.Description
          End If

        Case "ToMan"

          pFormController.LoadWorkOrderInfos(mWOIs)
          mWOPicker = New clsPickerWorkOrder(mWOIs, pFormController.DBConn)

          mWorkOrderInfo = frmWorkOrderPicker.OpenPickerSingle(mWOPicker)

          If mWorkOrderInfo IsNot Nothing Then
            pFormController.WorkOrderID = mWorkOrderInfo.WorkOrder.WorkOrderID
            pFormController.ItemRef = mWorkOrderInfo.WorkOrder.WorkOrderNo
            pFormController.ItemRef2 = mWorkOrderInfo.Description
            pFormController.ProjectRef = mWorkOrderInfo.ProjectName

            btnSOPItemPicker.Text = mWorkOrderInfo.WorkOrderNo & mWorkOrderInfo.Description


          End If

      End Select



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try



  End Sub

  Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
    Dim mPONum As String = ""

    ''Get the PurchaseOrderID

    mPONum = txtPONum.Text
    pFormController.PurchaseOrderID = pFormController.GetPurchaseOrderIDByPONum(mPONum)

    If pFormController.PurchaseOrderID > 0 Then

      If pFormController.SalesOrderPhaseItemID > 0 Then
        pFormController.UpdatePurchaseOrderAllocationManToNonMan()
        pFormController.UpdatePurchaseOrderItemAllocationManToNonMan()


      Else
        MessageBox.Show("Seleccione el artículo del proyecto para actualizar")

      End If

    Else
      MessageBox.Show("O.C. No encontrada")

    End If

  End Sub

  Private Sub btnUpdateNonManToMan_Click(sender As Object, e As EventArgs) Handles btnUpdateNonManToMan.Click
    Dim mPONum As String = ""

    ''Get the PurchaseOrderID

    mPONum = txtPONum.Text
    pFormController.PurchaseOrderID = pFormController.GetPurchaseOrderIDByPONum(mPONum)

    If pFormController.PurchaseOrderID > 0 Then

      If pFormController.WorkOrderID > 0 Then
        pFormController.UpdatePurchaseOrderAllocationNonManToMan()
        pFormController.UpdatePurchaseOrderItemAllocationNonManToMan()


      Else
        MessageBox.Show("Seleccione la OT para actualizar")

      End If

    Else
      MessageBox.Show("O.C. No encontrada")

    End If
  End Sub
End Class