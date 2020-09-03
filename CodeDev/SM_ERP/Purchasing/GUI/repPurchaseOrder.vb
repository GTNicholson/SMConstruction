Imports System.Drawing.Printing

Public Class repPurchaseOrder
  Private i As Integer = 0
  Private pPurchaseOrder As dmPurchaseOrder
  Private pImageList As List(Of Image)
  Private pHandler As clsPurchaseHandler

  Public Sub New()

    InitializeComponent()
    pImageList = New List(Of Image)

  End Sub

  Public Sub ClearImages()
    For Each mImage As Image In pImageList
      mImage.Dispose()
    Next
  End Sub

  Public Shared Function GenerateReport(ByRef rPurchaseOrder As dmPurchaseOrder) As repPurchaseOrder
    Dim mRep As New repPurchaseOrder
    mRep.pPurchaseOrder = rPurchaseOrder
    mRep.pHandler = New clsPurchaseHandler()
    mRep.DataSource = mRep.pPurchaseOrder.PurchaseOrderItems

    mRep.CreateDocument()

    Return mRep
  End Function

  Protected Overrides Sub Finalize()
    ClearImages()
    MyBase.Finalize()
  End Sub

  Private Sub SetUpDataBindings()

    xrOrderDate.DataBindings.Add("Text", pPurchaseOrder.SubmissionDate, "SubmissionDate")
    xrPurchaseOrderNo.DataBindings.Add("Text", pPurchaseOrder.PONum, "PONum")
    xrRequiredDate.DataBindings.Add("Text", pPurchaseOrder.RequiredDate, "RequiredDate")
    xrSupplierOrderRef.DataBindings.Add("Text", pPurchaseOrder.SupplierRef, "SupplierRef")
    xrCarriage.DataBindings.Add("Text", pPurchaseOrder.Carriage, "Carriage")

  End Sub
  Private Sub repPurchaseOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpDataBindings()


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint

    Dim mPOI As dmPurchaseOrderItem

    mPOI = Me.GetCurrentRow
    xrQuantity.Text = mPOI.QtyRequired

    xrtcStockCode.Text = mPOI.SupplierCode
    xrtcRefCodes.Text = mPOI.PartNo
    xrDescription.Text = mPOI.Description
    xrUnitPrice.Text = mPOI.UnitPrice
    xrNetTotal.Text = mPOI.NetAmount
  End Sub
End Class