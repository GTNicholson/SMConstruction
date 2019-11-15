Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI



Public Class srepOtherMaterialsChange
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private pQuantity As Int32
  Private pMatReqChanges As colMaterialRequirementInfos

  Private Sub srepOtherMaterialsChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepMatReqChanges As srepOtherMaterialsChange

    SetUpBindings()


    msrepMatReqChanges = New srepOtherMaterialsChange
    msrepMatReqChanges.DataSource = pMatReqChanges
  End Sub

  Private Sub SetUpBindings()


    xrtMaterialDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtMaterialQuantity.DataBindings.Add("Text", Me.DataSource, "Quantity")

    xrtUoM.DataBindings.Add("Text", Me.DataSource, "UoM")
    'xrtAreaID.DataBindings.Add("Text", Me.DataSource, "AreaID")
    xrtSupplierStockCode.DataBindings.Add("Text", Me.DataSource, "SupplierStockCode")
    xrtComments.DataBindings.Add("Text", Me.DataSource, "Comments")


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mAreaID As String
    Dim mMatReq As clsMaterialRequirementInfo


    mMatReq = TryCast(Me.GetCurrentRow, clsMaterialRequirementInfo)
    If mMatReq IsNot Nothing Then
      mAreaID = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre)).
                                      ItemValueToDisplayValue(mMatReq.AreaID)
      xrtAreaID.Text = mAreaID.ToUpper

      xrtMaterialDescription.Text = xrtMaterialDescription.Text.ToUpper

      xrtUoM.Text = xrtUoM.Text.ToUpper
      xrtComments.Text = xrtComments.Text.ToUpper
    End If
  End Sub
End Class