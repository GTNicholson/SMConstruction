Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class repWorkOrderMaintenanceDoc

  Private pMaintenanceWorkOrder As dmMaintenanceWorkOrder
  Private pHandler As clsPurchaseHandler

  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateReport(ByVal vMaintenanceWorkOrder As dmMaintenanceWorkOrder) As XtraReport
    Dim mRep As New repWorkOrderMaintenanceDoc(vMaintenanceWorkOrder)
    Dim mPrintTool As ReportPrintTool
    mRep.DataSource = vMaintenanceWorkOrder.MaitenanceWorkOrderItems
    mRep.CreateDocument()
    mPrintTool = New ReportPrintTool(mRep)
    mPrintTool.ShowPreviewDialog()
    mPrintTool.Dispose()
    mPrintTool = Nothing
    Return mRep
  End Function

  Public Sub New(ByRef vMaintenanceWorkOrder As dmMaintenanceWorkOrder)
    pMaintenanceWorkOrder = vMaintenanceWorkOrder
    ' This call is required by the designer.
    InitializeComponent()

  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repWorkOrderMaintenanceDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mEmployee As dmEmployee
    Dim mMachinery As dmMachinery

    xtcMaintenanceWorkOrderNo.Text = pMaintenanceWorkOrder.MaintenanceWorkOrderNo
    xtcWorkCenterID.Text = clsEnumsConstants.GetEnumDescription(GetType(eWorkCentre), CType(pMaintenanceWorkOrder.WorkCentreID, eWorkCentre))
    xtcPriority.Text = clsEnumsConstants.GetEnumDescription(GetType(eMaintenancePriority), CType(pMaintenanceWorkOrder.Priority, eMaintenancePriority))
    xtcNotes.Text = pMaintenanceWorkOrder.Notes
    xtcDescription.Text = pMaintenanceWorkOrder.Description


    xtcMaintenanceType.Text = clsEnumsConstants.GetEnumDescription(GetType(eMaintenanceType), CType(pMaintenanceWorkOrder.MaintenanceType, eMaintenanceType))
    xctDuration.Text = pMaintenanceWorkOrder.Duration.ToString("n1")

    If pMaintenanceWorkOrder.PlannedDate <> Date.MinValue Then
      xtcEstimatedDate.Text = pMaintenanceWorkOrder.PlannedDate
    End If

    xtcStatus.Text = clsEnumsConstants.GetEnumDescription(GetType(eMaintenanceWorkOrderStatus), CType(pMaintenanceWorkOrder.Status, eMaintenanceWorkOrderStatus))

    mMachinery = TryCast(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Machinery), colMachinerys).ItemFromKey(pMaintenanceWorkOrder.EquipmentID)


    If mMachinery IsNot Nothing Then
      xtcEquipmentID.Text = mMachinery.Description

    End If


    mEmployee = TryCast(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Employees), colEmployees).ItemFromKey(pMaintenanceWorkOrder.EmployeeID)

    If mEmployee IsNot Nothing Then
      xtcEmployeeID.Text = mEmployee.FullName

    End If


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    xtcEstQty.DataBindings.Add("Text", DataSource, "Quantity", "{0:0.###}")
    xtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xtcMatReqOtherDescription.DataBindings.Add("Text", DataSource, "StockDescription")
    xtcStockItemUoM.DataBindings.Add("Text", DataSource, "UoMDesc")
    xtcCost.DataBindings.Add("Text", DataSource, "UnitCost", "{0:C$#,##0.00;;#}")
    xtcTotalCost.DataBindings.Add("Text", DataSource, "TotalCost", "{0:C$#,##0.00;;#}")
    xtcComments.DataBindings.Add("Text", DataSource, "Comments")


  End Sub
End Class