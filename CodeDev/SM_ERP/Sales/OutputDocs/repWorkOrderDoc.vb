Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pFurniture As dmProductFurniture


  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.pFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
    mRep.pSalesOrder = rSalesOrder
    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    '// Head informatio from pWorkOrder
    xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")
    xrlDescription.DataBindings.Add("Text", pWorkOrder, "Description")
    xrtCantidad.DataBindings.Add("Text", pWorkOrder, "Quantity")


  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mPF As dmProductFurniture
    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)



    SetUpDataBindings()
    xrlCustomerName.Text = pSalesOrder.Customer.CompanyName & " / " & pSalesOrder.ProjectName
    xrSalesOrderID.Text = pSalesOrder.OrderNo
    xrlOT2.Text = pWorkOrder.WorkOrderNo
    xrlDateEntered.Text = pSalesOrder.DateEntered
    xrtDueTime.Text = pSalesOrder.DueTime
    xrtDate.Text = pWorkOrder.DateCreated
    xrtEmployeeID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pWorkOrder.EmployeeID)
    xrtEmployee2.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pWorkOrder.EmployeeID)

    xrSalesOrderID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).ItemValueToDisplayValue(pSalesOrder.OrderTypeID)


    If IsNothing(mPF) Then
      MessageBox.Show("Error, no existe ningún producto / componente ligado a esta Orden de Trabajo", "Error")

      Return

    End If

    xrNotes.Text = mPF.Notes


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mFileName As String
    Dim mImage As Image

    mFileName = clsSMSharedFuncs.GetWOImageFileName(pSalesOrder, pWorkOrder)

    If IO.File.Exists(mFileName) Then
      mImage = Drawing.Image.FromFile(mFileName)
    End If

    xrPic.Image = mImage


  End Sub
End Class