Imports System.Drawing.Printing

Public Class repOtherMaterials
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private POtherMaterial As dmMaterialRequirement
  Private pOtherMaterialChanges As colMaterialRequirementInfos


  Private Sub repOtherMaterials_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim msrepOtherMaterialChanges As srepOtherMaterialsChange

    xrlCustomerName.Text = (pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName).ToUpper
    xrtProductDescription.Text = (pWorkOrder.Description).ToUpper
    xrtQuantity.Text = pWorkOrder.Quantity
    xrtStockCode.Text = pWorkOrder.ParentSalesOrderItem.ItemNumber

    SetUpBindings()

    msrepOtherMaterialChanges = New srepOtherMaterialsChange
    msrepOtherMaterialChanges.DataSource = pOtherMaterialChanges
    subrepOtherMaterialsChange.ReportSource = msrepOtherMaterialChanges

  End Sub



  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder, ByRef rMatReqs As colMaterialRequirementInfos, ByRef rMatReqChanges As colMaterialRequirementInfos) As repOtherMaterials
    Dim mRetVal As repOtherMaterials

    mRetVal = New repOtherMaterials
    mRetVal.pSalesOrder = rSalesOrder
    mRetVal.pWorkOrder = rWorkOrder
    mRetVal.DataSource = rMatReqs

    mRetVal.pOtherMaterialChanges = rMatReqChanges

    mRetVal.CreateDocument()

    'Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool
    'mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRetVal)
    'mTool.ShowPreviewDialog()

    Return mRetVal
  End Function
  Private Sub SetUpBindings()
    xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrlWorkOrderNo2.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
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

      xrlWorkOrderNo.Text = xrlWorkOrderNo.Text.ToUpper
      xrlWorkOrderNo2.Text = xrlWorkOrderNo2.Text.ToUpper

      xrtMaterialDescription.Text = xrtMaterialDescription.Text.ToUpper

      xrtUoM.Text = xrtUoM.Text.ToUpper
      xrtComments.Text = xrtComments.Text.ToUpper
    End If
  End Sub


End Class