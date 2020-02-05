Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports RTIS.DoorsetCore
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmStockItemPurchasing
  Dim pFormController As fccStockItemPurchasing

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pSpinEnter As Boolean
  Private pViewOnly As Boolean

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsViewOnly As Boolean, ByVal vIsBulkOrdering As Boolean)

  End Sub

  Public ReadOnly Property FormController As fccStockItemPurchasing
    Get
      Return pFormController
    End Get
  End Property


End Class