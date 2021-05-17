
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class brwWorkOrderWoodProcess : Inherits brwBrowserListBase

  Public Enum eListOption
    DefaultListOption = 1

  End Enum

  Public Enum eAddEditDeleteView
    ByDefault = 0
    Aserrio = 1
    Horno = 2
    Clasificar = 3
    Cepillado = 4
    Devolucion = 5
    Rechazo = 6

  End Enum


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, Optional ByVal vListOption As Integer = eListOption.DefaultListOption)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)

  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked


    Select Case CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag
      Case eAddEditDeleteView.Aserrio
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.MAV, eWorkOrderWoodProcess.Aserrio)

      Case eAddEditDeleteView.Horno
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, eStockItemTypeTimberWood.MAV, eStockItemTypeTimberWood.MAS, eWorkOrderWoodProcess.Horno)

      Case eAddEditDeleteView.Clasificar
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, eStockItemTypeTimberWood.MAS, eStockItemTypeTimberWood.Primera, eWorkOrderWoodProcess.Clasificar)

      Case eAddEditDeleteView.Cepillado
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, eStockItemTypeTimberWood.Primera, eStockItemTypeTimberWood.CepilladoPrimera, eWorkOrderWoodProcess.Cepillado)


      Case eAddEditDeleteView.Devolucion
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, 0, 0, eWorkOrderWoodProcess.Devolucion)

      Case eAddEditDeleteView.Rechazo
        frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, 0, 0, 0, eWorkOrderWoodProcess.Rechazo)
    End Select



    Return False
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mReloadData As Boolean = False
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("Ninguna fila seleccionada")
    Else
      frmWorkOrderWoodProcess.OpenForm(rForm.ParentForm, pDBConn, pRTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("WorkOrderID")), mGridView.GetFocusedRowCellValue(mGridView.Columns("WorkOrderWoodType")), mGridView.GetFocusedRowCellValue(mGridView.Columns("WorkOrderTargetWoodType")), mGridView.GetFocusedRowCellValue(mGridView.Columns("WorkOrderProcessOption")))
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

  ''Public Overrides Function ListChangeLoadData() As Boolean
  ''  Static sDataOption As Integer = -1
  ''  Dim mNewGroup As Integer = 0
  ''  Dim mOK As Boolean
  ''  Select Case Me.ListOptionID
  ''    Case eListOption.DefaultListOption
  ''      mNewGroup = 1
  ''    Case Else
  ''      mNewGroup = 0
  ''  End Select
  ''  If mNewGroup <> sDataOption Then
  ''    mNewGroup = sDataOption
  ''    mOK = LoadData()
  ''  Else
  ''    mOK = True
  ''  End If
  ''  Return mOK
  ''End Function

  Public Overrides Function LoadData() As Boolean 'Implements intBrowseList.LoadData
    'Dim mdsoSalesQuote As New dsoSalesQuote(Me.DBConn)
    Dim mWOIs As New colWorkOrderInfos
    Dim mDSO As New dsoSalesOrder(pDBConn)
    Dim mWhere As String
    mWhere = "WorkOrderWoodType > 0 and (Status<>" & CInt(eWorkOrderStatus.Complete) & " and Status<>" & CInt(eWorkOrderStatus.Cancelled) & ")"

    Dim mOK As Boolean
    '' Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    gridBrowseList.MainView.BeginDataUpdate()
    Try

      mDSO.LoadWorkOrderInfos(mWOIs, mWhere, dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)

      gridBrowseList.DataSource = mWOIs


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

  Public Overrides Sub RefreshSingleRecord(ByVal vPrimaryKey As Integer)

  End Sub

  Public Overrides Function PrepareForm() As Boolean 'Implements intBrowseList.PrepareForm
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True

    Try

      BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)

      mGridView = gridBrowseList.Views(0)
      mGridView = CType(Me.gridBrowseList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)



      With CType(Me.BrowseForm, frmBrowseList)
        .ReLabelToolBarButtons("Agregar", "Editar", "Ver", "Eliminar", "Actualizar", "Listas", "Seleccionar", "Procesar", "Imprimir", "Exportar", "Opciones")

        .AddListOption("Activas", eListOption.DefaultListOption)

        '.AddListOption("Recibidas", eListOption.Received)
        '.AddListOption("Todas", eListOption.All)
        '.AddListOption("Canceladas", eListOption.Cancelled)
        .AddAddOption("A Aserrío", eAddEditDeleteView.Aserrio, True)
        .AddAddOption("A Horno", eAddEditDeleteView.Horno)
        .AddAddOption("A Clasificar", eAddEditDeleteView.Clasificar)
        .AddAddOption("A Cepillar", eAddEditDeleteView.Cepillado)

        .AddAddOption("A Devolución", eAddEditDeleteView.Devolucion)

        .AddAddOption("A Rechazo", eAddEditDeleteView.Rechazo)
        .RemoveAddOption(eAddEditDeleteView.ByDefault)
      End With

      ''gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      ''mGridView = gridBrowseList.MainView
      ''Set lookup columns

      ''Set lookup columns




      PrepareList()

    Catch ex As Exception
      mOK = False
    End Try

    'mdsoProfile = Nothing

    Return mOK
  End Function

  Public Overrides Function PrepareList() As Boolean
    'Dim mdsoProfile As New dsoProfile(Me.DBConn)
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True
    Try
      LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlWoodWorkOrder.xml")
      ListTitle = "Ordenes de Trabajo de Madera"
      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      gridBrowseList.RepositoryItems.Clear()
      gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      mGridView = gridBrowseList.MainView

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("ProductTypeID"), AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WorkOrderType))

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("ProductTypeID"), clsEnumsConstants.EnumToVIs(GetType(eProductType)))

      ''Set lookup columns

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(ePartType)))
      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")

      ' gridBrowseList.Refresh()

      Me.SaveButton = eActiveVisibleState.Invisible

      Me.AddButton = eActiveVisibleState.Active
      ''Me.AddButton = eActiveVisibleState.Active

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
    LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlWoodWorkOrder.xml")
    ListTitle = "Lista de Órdenes de Trabajo"
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
