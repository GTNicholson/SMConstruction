
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class brwPurchaseOrder : Inherits brwBrowserListBase

  Public Enum eListOption
    LivePO = 1
    '' Paid = 2
    Cancelled = 3
    All = 4
  End Enum

  Public Enum eAddEditDeleteView
    DefaultForm = 0
    AlternateForm = 1

  End Enum

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, Optional ByVal vListOption As Integer = eListOption.LivePO)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)

  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked
    Dim mReloadData As Boolean = False

    frmPurchaseOrder.OpenFormMDI(0, pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

    'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, 0, BrowseRefreshTracker,eFormMode.eFMFormModeAdd)
    'frmCustomerDetail.OpenFormAsModal((rForm, Me.DBConn, Me.RTISGlobal)
    Return mReloadData
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mReloadData As Boolean = False
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("Ninguna fila seleccionada")
    Else
      frmPurchaseOrder.OpenFormMDI(mGridView.GetFocusedRowCellValue(mGridView.Columns("PurchaseOrderID")), pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

      'End Select
    End If
    Return mReloadData
  End Function

  Public Overrides Sub ViewButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) ''Implements intBrowseList.ViewButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    'frmPartConfig.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("PartID")), eFormMode.eFMFormModeEdit)
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("Ninguna fila seleccionada")
    Else
      'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("CustomerID")), BrowseRefreshTracker,eFormMode.eFMFormModeView)
    End If

  End Sub

  Public Overrides Function DeleteButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.DeleteButtonClicked
    'frmCustomerDetail.OpenFormAsModal(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, BrowseRefreshTracker,eFormMode.eFMFormModeDelete)
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
  End Function

  Public Overrides Function ListChangeLoadData() As Boolean
    Static sDataOption As Integer = -1
    Dim mNewGroup As Integer = 0
    Dim mOK As Boolean
    Select Case Me.ListOptionID
      Case eListOption.LivePO
        mNewGroup = 1
      ''Case eListOption.Paid
      ''  mNewGroup = 2
      Case eListOption.Cancelled
        mNewGroup = 3
      Case eListOption.All
        mNewGroup = 4
      Case Else
        mNewGroup = 0
    End Select
    If mNewGroup <> sDataOption Then
      mNewGroup = sDataOption
      mOK = LoadData()
    Else
      mOK = True
    End If
    Return mOK
  End Function

  Public Overrides Function LoadData() As Boolean 'Implements intBrowseList.LoadData
    'Dim mdsoSalesQuote As New dsoSalesQuote(Me.DBConn)
    Dim mDataTable As DataTable
    Dim mOK As Boolean
    Dim mPOInfos As New colPurchaseOrderInfos
    Dim mdoPurchasing As New dsoPurchasing(pDBConn)
    Dim mWhere As String = ""
    '' Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    gridBrowseList.MainView.BeginDataUpdate()
    Try

      Select Case Me.ListOptionID
        Case eListOption.LivePO
          mWhere = String.Format("Status not in ({0},{1})", CInt(ePurchaseOrderDueDateStatus.Cancelled), CInt(ePurchaseOrderDueDateStatus.Received))
          '' mWhere &= " and"
          '' mWhere &= String.Format(" PaymentStatus <> {0}", CInt(ePaymentStatus.Paid))
          mdoPurchasing.LoadPurchaseOrderInfosDown(mPOInfos, mWhere)

        Case eListOption.Cancelled
          mWhere = String.Format("Status = {0}", CInt(ePurchaseOrderDueDateStatus.Cancelled))
          mdoPurchasing.LoadPurchaseOrderInfosDown(mPOInfos, mWhere)

        ''Case eListOption.Paid

        ''  mWhere &= String.Format(" PaymentStatus = {0}", CInt(ePaymentStatus.Paid))
        ''  mdoPurchasing.LoadPurchaseOrderInfos(mPOInfos, mWhere)

        Case eListOption.All
          mdoPurchasing.LoadPurchaseOrderInfosOnly(mPOInfos, "")
      End Select


      ''DBConn.Connect()
      ''mDataTable = Me.DBConn.CreateDataTable("Select * From vwPurchaseOrder")

      '' gridBrowseList.DataSource = mDataTable

      gridBrowseList.DataSource = mPOInfos
      '
      'mOK = mdsoSalesQuote.LoadCustomerTable(mDataTable) 'TODO - Restrict to Live quotes etc.
      'gridBrowseList.DataSource = mDataTable
      ''Set lookup columns
      ''mGridView = gridBrowseList.MainView

      ''gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(libProductDefinition.PartType)))
      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")




      'gridBrowseList.Update()
      gridBrowseList.Refresh()
      mOK = True
    Catch ex As Exception
      mOK = False

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw


    Finally
      'mdsoSalesQuote = Nothing
      ''DBConn.Disconnect()
      gridBrowseList.MainView.EndDataUpdate()
    End Try


    Return mOK
  End Function

  Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
    Dim mGView As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
    Dim mCurrentRow As clsPurchaseOrderInfo



    mCurrentRow = TryCast(mGView.GetRow(e.RowHandle), clsPurchaseOrderInfo)
    If mCurrentRow IsNot Nothing Then

      If mCurrentRow.Status <> ePurchaseOrderDueDateStatus.Received Then
        Select Case e.Column.FieldName
          Case "Status"
            e.Appearance.BackColor = Color.Red
            e.Appearance.ForeColor = Color.White
          Case Else
            e.Appearance.BackColor = Color.Transparent
            e.Appearance.ForeColor = Color.Black
        End Select



      Else


      End If



    End If




  End Sub
  Public Overrides Sub RefreshSingleRecord(ByVal vPrimaryKey As Integer)
    ''Dim mOrigRow As Data.DataRow
    ''Dim mNewRow As Data.DataRow = Nothing
    ''Dim mRows As Data.DataRow()
    ''Dim mDT As Data.DataTable
    ''Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    ''Dim mRowIndex As Integer = -1
    ''Dim mdso As New dsoExample(MyBase.DBConn)

    ''mDT = CType(Me.gridBrowseList.DataSource, Data.DataTable)
    ''mRows = mDT.Select("PrimaryKeyID = " & vPrimaryKey)

    ''If mRows.Length = 1 Then
    ''  mOrigRow = mRows(0)
    ''  mRowIndex = mDT.Rows.IndexOf(mOrigRow)
    ''''''  mDT.Rows.Remove(mOrigRow)
    ''End If

    ''mNewRow = mdso.LoadExampleSingleRow(vPrimaryKey)

    ''If Not mNewRow Is Nothing Then
    ''  If mRowIndex = -1 Then
    ''    Dim mRow As DataRow = mDT.NewRow
    ''    mRow.ItemArray = mNewRow.ItemArray
    ''    mDT.Rows.Add(mRow)
    ''  Else
    ''    mOrigRow.ItemArray = mNewRow.ItemArray
    ''    mOrigRow.AcceptChanges()
    ''  End If
    ''  mGridView = CType(Me.gridBrowseList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
    ''  mGridView.FocusedRowHandle = mGridView.LocateByValue("PrimaryKeyID", vPrimaryKey)
    ''End If
  End Sub

  Public Overrides Function PrepareForm() As Boolean 'Implements intBrowseList.PrepareForm
    Dim mOK As Boolean = True
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView


    Try
      'XtraGridPrintExport = New appXtraGridPrintExport()

      BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)

      mGridView = gridBrowseList.Views(0)
      mGridView = CType(Me.gridBrowseList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)


      With CType(Me.BrowseForm, frmBrowseList)

        .ReLabelToolBarButtons("Agregar", "Editar", "Ver", "Eliminar", "Actualizar", "Listas", "Seleccionar", "Procesar", "Imprimir", "Exportar", "Opciones")

        .AddListOption("�rden de Compras: Activas", eListOption.LivePO)
        ''.AddListOption("�rden de Compras: Pagadas", eListOption.Paid)
        .AddListOption("�rden de Compras: Canceladas", eListOption.Cancelled)
        .AddListOption("�rden de Compras: Todas", eListOption.All)


        '.AddEditOption("Edit Option2", eAddEditDeleteView.AlternateForm)
        '.AddAddOption("Add Option2", eAddEditDeleteView.AlternateForm)
        '.AddDeleteOption("Delete Option2", eAddEditDeleteView.AlternateForm)
        ''.AddViewOption("Ver Consultas de Orden de Compra", eAddEditDeleteView.AlternateForm)

        ''.AddProcessOption("Mail-shot active Orden de Compra", AddressOf BatchProcessExecute)
        ''.AddPrintOption("Print Current Statement", AddressOf PrintOptionExecute)
        ''.AddExportOption("Export Current Enquiries", AddressOf AddOptionExecute)
        ''.AddExportOption("Export Current Orders", AddressOf AddOptionExecute)


        '' If Don't want the first button to be the default
        ''Dim mBar As DevExpress.XtraBars.Bar = .GetMainToolBar()
        ''Dim mBtn As DevExpress.XtraBars.BarButtonItem
        ''Dim mButtonLink As DevExpress.XtraBars.BarItemLink
        ''Dim mPopUP As DevExpress.XtraBars.PopupMenu
        ''For Each mButtonLink In mBar.ItemLinks
        ''  If mButtonLink.Item.Name = "barbtnEdit" Then
        ''    mBtn = mButtonLink.Item
        ''    mBtn.ActAsDropDown = True
        ''    mBtn.AllowDrawArrow = True
        ''    mPopUP = mBtn.DropDownControl
        ''    mPopUP.RemoveLink(mPopUP.ItemLinks(0))
        ''    Exit For
        ''  End If
        ''Next

      End With
      AddHandler mGridView.RowCellStyle, AddressOf GridRowCellStyle

      PrepareList()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    'mdsoProfile = Nothing

    Return mOK
  End Function

  Public Overrides Function PrepareList() As Boolean
    'Dim mdsoProfile As New dsoProfile(Me.DBConn)
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True

    Try
      Select Case Me.ListOptionID
        Case eListOption.LivePO
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlPurchaseOrder.xml")
          ListTitle = "�rden de Compra: Activas y en Proceso"


        Case eListOption.All
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlPurchaseOrder.xml")
          ListTitle = "�rden de Compra: Todas las �rdenes de Compras"


        Case eListOption.Cancelled
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlPurchaseOrder.xml")
          ListTitle = "�rden de Compra: �rdenes de Compras Canceladas"


          ''Case eListOption.Paid
          ''  LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlPurchaseOrder.xml")
          ''  ListTitle = "�rden de Compra: �rdenes de Compras Pagadas"

      End Select


      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      gridBrowseList.RepositoryItems.Clear()
      gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      mGridView = gridBrowseList.MainView
      ''Set lookup columns
      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PaymentStatus"), clsEnumsConstants.EnumToVIs(GetType(ePaymentStatus)))
      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("Category"), clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories)))

      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("Status"), clsEnumsConstants.EnumToVIs(GetType(ePurchaseOrderDueDateStatus)))

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("OrderStatusENUM"), clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus)))
      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("OrderTypeID"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))
      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("SalesAreaID"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))

      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")

      ' gridBrowseList.Refresh()

      Me.SaveButton = eActiveVisibleState.Invisible

      Me.AddButton = eActiveVisibleState.Active
      Me.ViewButton = eActiveVisibleState.Active
      Me.EditButton = eActiveVisibleState.Active
      If My.Application.RTISUserSession.ActivityPermission(eActivityCode.ForceLockRemoval) >= ePermissionCode.ePC_Full Then
        Me.DeleteButton = eActiveVisibleState.Active
      Else
        Me.DeleteButton = eActiveVisibleState.VisibleInactive
      End If

      Me.SelectColumnActive = False
      ''Me.SelectColumnActive = True
      ''Me.SelectColumnName = "IncludeRow"

      Me.PrintAndExportAvailable = True

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    'mdsoProfile = Nothing

    Return mOK
  End Function


  Public Overrides Sub CloseFrom() ' Implements intBrowseList.CloseFrom
    MyBase.CloseFrom()
    DBConn = Nothing
    BrowseRefreshTracker = Nothing
  End Sub



  Private Sub BatchProcessExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    'Check to see if have filtered the list at all
    Dim mMainView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mActiveFilter As DevExpress.XtraGrid.Views.Base.ViewFilter = mMainView.ActiveFilter
    Dim mOK As Boolean = True


    ''Dim mRows() As DataRow = CType(gridBrowseList.DataSource, DataTable).Select("IncludeRow = 1")
    ''If mRows.Length = 0 Then
    ''  MsgBox("There are no rows selected/visible, therefore nothing to process")
    ''Else
    ''  If MsgBox("Clear " & mRows.Length & " selected locks?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    ''    For Each mRow As DataRow In mRows



    ''    Next
    ''  End If
    ''End If

    ''If mActiveFilter.IsEmpty And mMainView.FindFilterText.Length = 0 Then
    ''  mOK = MsgBox("You have not applied a filter, are you sure you want to batch process all entries?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok
    ''ElseIf gridBrowseList.MainView.DataRowCount = 0 Then
    ''  mOK = False
    ''  MsgBox("There are no rows selected/visible, therefore nothing to process")
    ''ElseIf mMainView.ActiveFilterEnabled = False And mMainView.FindFilterText.Length = 0 Then
    ''  mOK = MsgBox("The filter is not enabled, are you sure you want to process all entries?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok
    ''End If
    ''If mOK Then

    ''  For mItemCount As Integer = 0 To mMainView.DataRowCount - 1
    ''    ''Check if selected
    ''    ''mAnID = mMainView.GetRowCellValue(mItemCount, "AnID")

    ''  Next

    ''End If

    'Select Case e.Item.Tag 'Tag added to bar sub-menu button

    'End Select

  End Sub


  Private Sub AddOptionExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    ''Dim mButtonLink As DevExpress.XtraBars.BarItemLink = e.Link
    ''Dim mBtn As DevExpress.XtraBars.BarButtonItem = e.Item
    ''Dim mForm As Form = CType(sender, DevExpress.XtraBars.BarManager).Form
    ''Select Case mBtn.Tag 'Tag added to bar sub-menu button - alternativey use a separate sub procedure for each button added

    ''End Select
    ''LoadData
  End Sub

  Private Sub EditOptionExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    ''RefreshSingleRecord
  End Sub

  Private Sub DeleteOptionExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    ''LoadData
  End Sub

  Private Sub ViewOptionExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

  End Sub


  Private Sub PrintOptionExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlPurchaseOrder.xml")
    ListTitle = "Lista de Compras"
    GridEditable = False
    'PrimaryKeyColumnName = "PrimaryID"

    'gridBrowseList.BeginUpdate()

    gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
    mGridView = gridBrowseList.MainView
    gridBrowseList.BeginUpdate()


    gridBrowseList.RepositoryItems.Clear()

    ''Set lookup columns

    ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(ePartType)))
    ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")
    gridBrowseList.EndUpdate()

    'gridBrowseList.Update()
    ' gridBrowseList.Refresh()
  End Sub



End Class
