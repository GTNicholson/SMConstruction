Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class brwProductCostBook : Inherits brwBrowserListBase

  Public Enum eListOption
    DefaultListOption = 1

  End Enum

  Public Enum eAddEditDeleteView
    GeneralProductCostBook = 0
  End Enum

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, Optional ByVal vListOption As Integer = eListOption.DefaultListOption)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)

  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked
    Dim mReloadData As Boolean = False
    frmProductCostBook.OpenAsMDIChild(rForm.ParentForm, DBConn, Nothing)

    Return mReloadData
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mReloadData As Boolean = False

    Select Case CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag
      Case eAddEditDeleteView.GeneralProductCostBook
        If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
          MsgBox("Ninguna fila seleccionada")
        Else
          frmProductCostBook.OpenAsMDIChild(rForm.ParentForm, DBConn, mGridView.GetFocusedRowCellValue(mGridView.Columns("ProductCostBookID")))

        End If

    End Select


    Return mReloadData
  End Function

  Public Overrides Sub ViewButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) ''Implements intBrowseList.ViewButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView

    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("Ninguna fila seleccionada")
    Else
      frmProductCostBook.OpenAsMDIChild(rForm.ParentForm, DBConn, mGridView.GetFocusedRowCellValue(mGridView.Columns("ProductCostBookID")))
    End If

  End Sub

  Public Overrides Function DeleteButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.DeleteButtonClicked

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
    Dim mdto As New dtoProductCostBook(Me.DBConn)
    Dim mProductCostBooks As New colProductCostBooks
    'Dim mDataTable As DataTable
    Dim mOK As Boolean
    '' Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    gridBrowseList.MainView.BeginDataUpdate()
    Try
      '
      DBConn.Connect()
      mOK = mdto.LoadProductCostBookCollection(mProductCostBooks)
      'mOK = mdsoSalesQuote.LoadCustomerTable(mDataTable) 'TODO - Restrict to Live quotes etc.
      gridBrowseList.DataSource = mProductCostBooks

      gridBrowseList.Refresh()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    Finally
      mdto = Nothing
      gridBrowseList.MainView.EndDataUpdate()
      DBConn.Disconnect()
    End Try


    Return mOK
  End Function

  Public Overrides Sub RefreshSingleRecord(ByVal vPrimaryKey As Integer)

  End Sub

  Public Overrides Function PrepareForm() As Boolean 'Implements intBrowseList.PrepareForm
    Dim mOK As Boolean = True
    Try


      BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)



      With CType(Me.BrowseForm, frmBrowseList)


        With CType(Me.BrowseForm, frmBrowseList)

          .ReLabelToolBarButtons("Agregar Nueva Lista de Costos", "Editar Lista de Costos", "Ver", "Eliminar", "Actualizar", "Listas", "Seleccionar", "Procesar", "Imprimir", "Exportar", "Opciones")

          ''.AddListOption("List Caption", eListOption.DefaultListOption)
          ''.AddEditOption("Edit Option2", eAddEditDeleteView.AlternateForm)
          ''.AddEditOption("Edit Pricing Rule", eAddEditDeleteView.PricingRules)
          ''.AddEditOption("Edit Process Minute Rules", eAddEditDeleteView.ProcessMinuteRules)
          ''.AddDeleteOption("Delete Option2", eAddEditDeleteView.AlternateForm)
          ''.AddViewOption("View Option2", eAddEditDeleteView.AlternateForm)

          ''.AddProcessOption("Example Process", AddressOf BatchProcessExecute)
          ''.AddPrintOption("Print Option2", AddressOf PrintOptionExecute)
          ''.AddExportOption("Export Option From Code", AddressOf AddOptionExecute)


        End With

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
    Dim mRepDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

    Try
      LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlProductCostBook.xml")
      ListTitle = "Lista de Costos"
      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      gridBrowseList.RepositoryItems.Clear()
      gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      mGridView = gridBrowseList.MainView
      ''Set lookup columns

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(ePartType)))
      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")

      ' gridBrowseList.Refresh()

      ' Me.SaveButton = eActiveVisibleState.Invisible

      Me.AddButton = eActiveVisibleState.Active
      Me.ViewButton = eActiveVisibleState.Invisible
      Me.EditButton = eActiveVisibleState.Active
      Me.DeleteButton = eActiveVisibleState.Invisible
      '  If My.Application.RTISUserSession.ActivityPermission(eActivityCode.ForceLockRemoval) >= ePermissionCode.ePC_Full Then
      '  Me.DeleteButton = eActiveVisibleState.Active
      '  Else
      '    Me.DeleteButton = eActiveVisibleState.VisibleInactive
      '  End If

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
    DBConn = Nothing
    BrowseRefreshTracker = Nothing
  End Sub



  Private Sub BatchProcessExecute(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)


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
    LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlProductCostBook.xml")
    ListTitle = "Lista de Costos"
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
