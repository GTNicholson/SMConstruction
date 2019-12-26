Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmStockItem

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean

  Private pFormController As fccStocktem

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub barRGObsoleteItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barRGObsoleteItems.ItemClick

  End Sub

  Private Sub frmStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pIsActive = False
    pFormController.LoadObject()
    ''RefreshAddStockItemOptions()
    grdStockItems.DataSource = pFormController.StockItems
    ''LoadCombos()

    ''RefreshControls()
    pIsActive = True
  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vCategorys As List(Of eStockItemCategory))
    Dim mfrm As frmStockItem = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmStockItem
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStocktem(rDBConn, rRTISGlobal)
      mfrm.pFormController.Categorys = vCategorys

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub
  Private Shared Function GetFormIfLoaded() As frmStockItem
    Dim mfrmWanted As frmStockItem = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockItem
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmStockItem Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub frmStockItem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub
End Class