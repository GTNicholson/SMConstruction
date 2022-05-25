Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repMaintenanceRequisaPicking

  Private pMaintenanceWorkOrder As dmMaintenanceWorkOrder
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"
  Private pRequisaNo As String
  Private pTranDate As Date
  Public Sub New()

    InitializeComponent()


  End Sub

  Public Shared Function CreateReport(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors, ByVal vRequisaNo As String, ByVal vTranDate As Date) As XtraReport
    Dim mRep As New repMaintenanceRequisaPicking(rMaintenanceWorkOrder, rMaterialRequirementProcessors, vRequisaNo, vTranDate)
    Dim mPrintTool As ReportPrintTool
    mRep.CreateDocument()


    mPrintTool = New ReportPrintTool(mRep)
    mPrintTool.ShowPreviewDialog()
    mPrintTool.Dispose()
    mPrintTool = Nothing


    Return mRep
  End Function

  Public Sub New(ByRef pMiantenanceWorkOrder As dmMaintenanceWorkOrder, ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors, ByVal vRequisaNo As String, ByVal vTranDate As Date)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pRequisaNo = vRequisaNo
    pMaintenanceWorkOrder = pMiantenanceWorkOrder

    If pMaintenanceWorkOrder.Machinery.MachineryID = 0 Then
      Dim mMachinery As dmMachinery = TryCast(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Machinery), colMachinerys).ItemFromKey(pMaintenanceWorkOrder.EquipmentID)

      If mMachinery IsNot Nothing Then
        pMaintenanceWorkOrder.Machinery = mMachinery
      End If

    End If
    pTranDate = vTranDate
    DataSource = rMaterialRequirementProcessors
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repRequisaWorkOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"

    xtcWorkOrderNo.Text = pMaintenanceWorkOrder.MaintenanceWorkOrderNo
    xtcRequisaDate.Text = Format(pTranDate, "dd-MM-yyyy")
    xtcProyectName.Text = pMaintenanceWorkOrder.MachineryDesc & "/" & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eWorkCentre), CType(pMaintenanceWorkOrder.WorkCentreID, eWorkCentre))
    xtcRequisaNumber.Text = pRequisaNo

    xtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xtcDescription.DataBindings.Add("Text", DataSource, "Description")

    xtcPickedQty.DataBindings.Add("Text", DataSource, "PickedQty", "{0:0.###}")


    xtcUoM.DataBindings.Add("Text", DataSource, "UoMDescUI")

    xtcArea.DataBindings.Add("Text", DataSource, "AreaDesc")
  End Sub


End Class