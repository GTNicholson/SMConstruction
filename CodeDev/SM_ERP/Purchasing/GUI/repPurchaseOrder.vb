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

End Class