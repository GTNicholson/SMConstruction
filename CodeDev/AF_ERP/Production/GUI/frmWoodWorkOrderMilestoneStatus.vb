Imports System.ComponentModel
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB

Public Class frmWoodWorkOrderMilestoneStatus
  Private pFormController As fccWoodWorkOrderMilestoneStatus

  Public Shared Sub OpenForm(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus)
    Dim mfrm As frmWoodWorkOrderMilestoneStatus

    mfrm = New frmWoodWorkOrderMilestoneStatus
    mfrm.StartPosition = FormStartPosition.CenterParent

    mfrm.pFormController = New fccWoodWorkOrderMilestoneStatus(rDBConn, rWorkOrderMilestoneStatus)
    mfrm.ShowDialog(rParentForm)


  End Sub

  Private Sub frmWoodWorkOrderMilestoneStatus_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try
      UpdateObject()
      pFormController.SaveObject()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmWoodWorkOrderMilestoneStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mMsg As String
    Dim mOK As Boolean
    Dim mErrorDisplayed As Boolean
    Try

      pFormController.LoadDataRef()
      RefreshControls()
      grdWoodMaterialRequirements.DataSource = pFormController.WoodMaterialRequirementInfos
      mOK = True

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))
    End If
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub RefreshControls()
    Try
      With pFormController.WorkOrderMilestoneStatus
        radgrpWOStatusSetting.EditValue = CInt(.Status)


        dtePlannedDate.EditValue = .TargetDate
        dteActualDate.DateTime = .ActualDate
        txtNotes.Text = .Notes
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateObject()
    Try
      With pFormController.WorkOrderMilestoneStatus
        .Status = radgrpWOStatusSetting.EditValue
        .TargetDate = dtePlannedDate.DateTime
        .ActualDate = dteActualDate.DateTime
        .Notes = txtNotes.Text
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvWoodMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWoodMaterialRequirements.CustomUnboundColumnData
    Dim mMR As clsMaterialRequirementInfo
    Dim mStockItem As dmStockItem

    Try

      gvWoodMaterialRequirements.CloseEditor()
      mMR = TryCast(e.Row, clsMaterialRequirementInfo)


      If mMR IsNot Nothing Then
        Select Case e.Column.Name

          Case gcUB_ItemType.Name

            If e.IsGetData Then
              mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMR.StockItem.StockItemID)

              If mStockItem IsNot Nothing Then
                e.Value = eStockItemTypeTimberWood.GetInstance.DisplayValueFromKey(mStockItem.ItemType)

              End If

            End If

          Case gcThicknessInch.Name
            If e.IsGetData Then
              mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMR.StockItem.StockItemID)

              If mStockItem IsNot Nothing Then
                e.Value = mStockItem.Thickness.ToString("n3")

              End If

            End If

          Case gcQtyBoardFeet.Name
            Dim mValue As Decimal
            Dim mQty As Integer


            If e.IsGetData Then



              mQty = mMR.UnitPiece
              mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMR.NetLenght, mMR.NetWidth, mMR.NetThickness)
              mValue = mValue
              e.Value = mValue


            End If

        End Select
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub grpWoodMaterialRequirement_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWoodMaterialRequirement.CustomButtonClick


    Dim mFilePath As String = String.Empty
    Dim mOK As Boolean = True
    Dim mWorkOrder As New dmWorkOrder
    Try
      pFormController.LoadWorkOrder(mWorkOrder)

      If mWorkOrder IsNot Nothing Then

        ViewWorkOrderDocument(mWorkOrder)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Public Sub ViewWorkOrderDocument(ByRef rWorkOrder As dmWorkOrder)
    Dim mFilePath As String
    mFilePath = rWorkOrder.OutputDocuments.GetFilePath(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

    If IO.File.Exists(mFilePath) Then
      frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
    Else
      MessageBox.Show("No se ha generado un documento de impresión para esta O.T.")
    End If

  End Sub


End Class