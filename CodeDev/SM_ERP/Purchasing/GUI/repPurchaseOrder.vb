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

    xrtSupplierCompanyName.DataBindings.Add("Text", pPurchaseOrder.Supplier, "CompanyName")


  End Sub
  Private Sub repPurchaseOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpDataBindings()


  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint

    Dim mPOI As dmPurchaseOrderItem

    mPOI = Me.GetCurrentRow
    xrtStockCode.Text = mPOI.Description

  End Sub
End Class