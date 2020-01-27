Imports System.Drawing.Printing

Public Class repFGLabel
  Private pWO As dmWorkOrder
  Private pSO As dmSalesOrder
  Private pFGLabelItems As List(Of clsFGLabelItem)

  Public Shared Sub PrintWorkOrderLabels(ByRef rWo As dmWorkOrder, ByRef rSo As dmSalesOrder, ByRef rLabelDef As clsLabelDefinition)

    Dim mrep As New repFGLabel
    Dim mprintTool As DevExpress.XtraReports.UI.ReportPrintTool
    Dim mPrinterName As String

    If rLabelDef.PrinterName <> "" Then
      mPrinterName = clsSMSharedFuncs.GetPrinterName(rLabelDef.PrinterName)
      If mPrinterName <> "" Then mrep.PrinterName = mPrinterName
    End If


    mrep.pWO = rWo
    mrep.pSO = rSo

    mrep.CreateDocument()

    mprintTool = New DevExpress.XtraReports.UI.ReportPrintTool(mrep)

    mprintTool.PrintDialog()

  End Sub

  Private Sub repFGLabel_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    CreateFGLabelItems()
    Me.DataSource = pFGLabelItems
    SetupBinding()
  End Sub

  Private Sub SetupBinding()
    xrlCustomer.DataBindings.Add("Text", DataSource, "Customer")
    xrlDescription1.DataBindings.Add("Text", DataSource, "Description")
    xrlDescription2.DataBindings.Add("Text", DataSource, "Component")
    xrlDestination.DataBindings.Add("Text", DataSource, "Destination")
    xrlOTNumber.DataBindings.Add("Text", DataSource, "WorkOrderNo")
    XrBarCode1.DataBindings.Add("Text", DataSource, "BarCode")
  End Sub

  Private Sub CreateFGLabelItems()
    Dim mProductFurniture As dmProductFurniture
    Dim mFGLabelItem As clsFGLabelItem

    mProductFurniture = TryCast(pWO.Product, dmProductFurniture)
    pFGLabelItems = New List(Of clsFGLabelItem)

    If mProductFurniture IsNot Nothing Then

      If mProductFurniture.ProductFurnitureComponents.Count = 0 Then
        mFGLabelItem = New clsFGLabelItem
        mFGLabelItem.Customer = pSO.Customer.CompanyName
        mFGLabelItem.Description = pWO.Description
        mFGLabelItem.BarCode = "FG" & pWO.WorkOrderID.ToString("000000")
        mFGLabelItem.Destination = pSO.Customer.MainAddress1
        mFGLabelItem.WorkOrderNo = pWO.WorkOrderNo

        pFGLabelItems.Add(mFGLabelItem)

      Else
        For Each mComp As dmProductFurnitureComponent In mProductFurniture.ProductFurnitureComponents
          mFGLabelItem = New clsFGLabelItem
          mFGLabelItem.Customer = pSO.Customer.CompanyName
          mFGLabelItem.Description = pWO.Description
          mFGLabelItem.Component = mComp.Description
          mFGLabelItem.BarCode = "FG" & pWO.WorkOrderID.ToString("000000")
          mFGLabelItem.Destination = pSO.Customer.MainAddress1
          mFGLabelItem.WorkOrderNo = pWO.WorkOrderNo
          pFGLabelItems.Add(mFGLabelItem)
        Next

      End If



    End If



  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mFileName As String
    Dim mImage As Image

    mFileName = clsSMSharedFuncs.GetWOImageFileName(pSO, pWO)

    If IO.File.Exists(mFileName) Then
      mImage = Drawing.Image.FromFile(mFileName)
    End If

    ''xrpImage.Image = mImage
  End Sub
End Class

Public Class clsFGLabelItem
  Public Property Customer As String
  Public Property Description As String
  Public Property Component As String
  Public Property BarCode As String
  Public Property Destination As String
  Public Property WorkOrderNo As String




End Class