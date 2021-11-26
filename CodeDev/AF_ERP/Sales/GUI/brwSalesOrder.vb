﻿
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class brwSalesOrder : Inherits brwBrowserListBase
  Private pIsWoodSalesOrder As Boolean
  Public Enum eListOption
    LiveAndActive = 1
    Completed = 2
    All = 3
    Cancelled = 4
  End Enum

  Public Enum eAddEditDeleteView
    DefaultForm = 0
    AlternateForm = 1

  End Enum

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, ByVal vIsWoodSalesOrder As Boolean, Optional ByVal vListOption As Integer = eListOption.LiveAndActive)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)
    pIsWoodSalesOrder = vIsWoodSalesOrder
  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked
    Dim mReloadData As Boolean = False
    Dim mUserIDCollection As New List(Of Integer)

    If pIsWoodSalesOrder = False Then


      If AppRTISGlobal.GetInstance.UsersIDWithSmallScreen.Contains(pDBConn.RTISUser.UserID) = True Then ''--Open small screen

        frmSalesOrderDetailHousesSmallScreen.OpenFormMDI(0, pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

      Else
        frmSalesOrderDetailHouses.OpenFormMDI(0, pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

      End If

    Else


      frmWoodSalesOrder.OpenFormMDI(0, pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

      End If


    Return mReloadData
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mReloadData As Boolean = False

    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("Ninguna fila seleccionada")
    Else

      If pIsWoodSalesOrder = False Then

        If AppRTISGlobal.GetInstance.UsersIDWithSmallScreen.Contains(pDBConn.RTISUser.UserID) = True Then
          frmSalesOrderDetailHousesSmallScreen.OpenFormMDI(mGridView.GetFocusedRowCellValue(mGridView.Columns("SalesOrderID")), pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

        Else
          frmSalesOrderDetailHouses.OpenFormMDI(mGridView.GetFocusedRowCellValue(mGridView.Columns("SalesOrderID")), pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

        End If

      Else


        frmWoodSalesOrder.OpenFormMDI(mGridView.GetFocusedRowCellValue(mGridView.Columns("SalesOrderID")), pDBConn, AppRTISGlobal.GetInstance, rForm.ParentForm)

      End If

      'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("CustomerID")), BrowseRefreshTracker,eFormMode.eFMFormModeEdit)

      'Select Case CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag
      '  Case eAddEditDeleteView.DefaultForm

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
      Case eListOption.LiveAndActive
        mNewGroup = 1
      Case eListOption.Completed
        mNewGroup = 2
      Case eListOption.All
        mNewGroup = 3
      Case eListOption.Cancelled
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
    Dim mWhere As String = ""
    '' Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    gridBrowseList.MainView.BeginDataUpdate()
    Try

      DBConn.Connect()


      Select Case Me.ListOptionID
        Case eListOption.LiveAndActive
          mWhere = String.Format("Select * From vwSalesOrderInfo where OrderTypeID in ({0},{1},0) ", CInt(eOrderType.Sales), CInt(eOrderType.Interno))
          mWhere &= String.Format(" and OrderStatusENUM not in ({0},{1}) ", CInt(eSalesOrderstatus.Completed), CInt(eSalesOrderstatus.Cancelada))
          mWhere &= " Order By SalesOrderID desc"
        Case eListOption.Cancelled
          mWhere = String.Format("Select * From vwSalesOrderInfo where  OrderTypeID in ({0},{1},0) ", CInt(eOrderType.Sales), CInt(eOrderType.Interno))
          mWhere &= String.Format(" and OrderStatusENUM in ({0}) ", CInt(eSalesOrderstatus.Cancelada))
          mWhere &= " Order By SalesOrderID desc"

        Case eListOption.All
          mWhere = String.Format("Select * From vwSalesOrderInfo where OrderTypeID in ({0},{1},0) ", CInt(eOrderType.Sales), CInt(eOrderType.Interno))
          mWhere &= " Order By SalesOrderID desc"

        Case eListOption.Completed
          mWhere = String.Format("Select * From vwSalesOrderInfo where OrderTypeID in ({0},{1},0) ", CInt(eOrderType.Sales), CInt(eOrderType.Interno))
          mWhere &= String.Format(" and OrderStatusENUM in ({0}) ", CInt(eSalesOrderstatus.Completed))

          mWhere &= " Order By SalesOrderID desc"
      End Select



      If pIsWoodSalesOrder = False Then

        mDataTable = Me.DBConn.CreateDataTable(mWhere)
      Else
        mDataTable = Me.DBConn.CreateDataTable("Select * From vwSalesOrderInfo where OrderTypeID=" & CInt(eOrderType.WoodSales) & " and OrderStatusENUM not in (2,3) Order By SalesOrderID desc")

      End If

      gridBrowseList.DataSource = mDataTable

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
      DBConn.Disconnect()
      gridBrowseList.MainView.EndDataUpdate()
    End Try


    Return mOK
  End Function

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
    Try
      'XtraGridPrintExport = New appXtraGridPrintExport()

      BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)



      With CType(Me.BrowseForm, frmBrowseList)

        .ReLabelToolBarButtons("Agregar", "Editar", "Ver", "Eliminar", "Actualizar", "Listas", "Seleccionar", "Procesar", "Imprimir", "Exportar", "Opciones")

        .AddListOption("Orden de Venta: Activas", eListOption.LiveAndActive)
        .AddListOption("Orden de Venta: Completadas", eListOption.Completed)
        .AddListOption("Orden de Venta: Todas", eListOption.All)
        .AddListOption("Orden de Venta: Canceladas", eListOption.Cancelled)



        '.AddEditOption("Edit Option2", eAddEditDeleteView.AlternateForm)
        '.AddAddOption("Add Option2", eAddEditDeleteView.AlternateForm)
        '.AddDeleteOption("Delete Option2", eAddEditDeleteView.AlternateForm)
        .AddViewOption("View SalesOrder Enquiries", eAddEditDeleteView.AlternateForm)

        .AddProcessOption("Mail-shot active SalesOrder", AddressOf BatchProcessExecute)
        .AddPrintOption("Print Current Statement", AddressOf PrintOptionExecute)
        .AddExportOption("Export Current Enquiries", AddressOf AddOptionExecute)
        .AddExportOption("Export Current Orders", AddressOf AddOptionExecute)


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
        Case eListOption.LiveAndActive
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlSalesOrder.xml")
          ListTitle = "Orden de Venta: Activas"

        Case eListOption.All
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlSalesOrder.xml")
          ListTitle = "Orden de Venta: Todas"


        Case eListOption.Cancelled
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlSalesOrder.xml")
          ListTitle = "Orden de Venta: Canceladas"

        Case eListOption.Completed
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlSalesOrder.xml")
          ListTitle = "Orden de Venta: Completadas"

      End Select


      If pIsWoodSalesOrder Then
        LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlWoodSalesOrder.xml")
        ListTitle = "Lista de Ventas de Madera"


      End If
      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      gridBrowseList.RepositoryItems.Clear()
      gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      mGridView = gridBrowseList.MainView
      ''Set lookup columns

      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("OrderStatusENUM"), clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus)))
      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("OrderTypeID"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))
      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("SalesAreaID"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))

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

    If pIsWoodSalesOrder Then
      LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlWoodSalesOrder.xml")
      ListTitle = "Lista de Ventas de Madera"
    Else
      LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlSalesOrder.xml")
      ListTitle = "Lista de Ventas"
    End If

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
