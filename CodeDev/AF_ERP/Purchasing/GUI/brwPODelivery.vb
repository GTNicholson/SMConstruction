Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraBars.Commands.Design

Public Class brwPODelivery : Inherits brwBrowserListBase

  Public Enum eListOption
    LivePODelivery = 1
    Received = 2
    Cancelled = 3
    All = 4
  End Enum


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, Optional ByVal vListOption As Integer = eListOption.LivePODelivery)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)
    Me.RTISGlobal = rRTISGlobal
    Me.DBConn = rDBConn
    Me.BrowseID = vBrowseID
    MyBase.BrowseRefreshTracker = New clsBasicBrowseRefreshTracker
  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked
    frmPODelivery.OpenAsModal(rForm, Me.DBConn, Me.RTISGlobal, 0, 0, eFormMode.eFMFormModeAdd)
    'frmCustomerDetail.OpenFormAsModal((rForm, Me.DBConn, Me.RTISGlobal)
    Return False
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      ' MsgBox("No row selected")
    Else
      ' frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("CustomerID")), BrowseRefreshTracker, eFormMode.eFMFormModeEdit)
      frmPODelivery.OpenAsModal(rForm, Me.DBConn, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("PODeliveryID")), 0, eFormMode.eFMFormModeAdd)

    End If

  End Function

  Public Overrides Sub ViewButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) ''Implements intBrowseList.ViewButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    'frmPartConfig.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("PartID")), eFormMode.eFMFormModeEdit)
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("No row selected")
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
      Case eListOption.LivePODelivery
        mNewGroup = 1
      Case eListOption.Received
        mNewGroup = 2
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
    Dim mdsoSalesOrder As New dsoPurchasing(Me.DBConn)
    Dim mDataTable As New DataTable
    Dim mOK As Boolean
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    Dim mWhere As String = ""

    Try
      'Me.gridBrowseList.BeginUpdate()
      Select Case Me.ListOptionID
        Case eListOption.LivePODelivery
          mWhere = String.Format("where GRNumber<>'' and Status not in ({0},{1}) order by DateCreated desc ", CInt(ePODelivery.Cancelled), CInt(ePODelivery.Received))
          mOK = mdsoSalesOrder.LoadPODeliveryDT(mDataTable, mWhere)

        Case eListOption.Received
          mWhere = String.Format("where GRNumber<>'' and Status = {0} order by DateCreated desc ", CInt(ePODelivery.Received))
          mOK = mdsoSalesOrder.LoadPODeliveryDT(mDataTable, mWhere)


        Case eListOption.All
          mWhere = String.Format("where GRNumber<>'' order by DateCreated desc")
          mOK = mdsoSalesOrder.LoadPODeliveryDT(mDataTable, mWhere)


        Case eListOption.Cancelled
          mWhere = String.Format("where GRNumber<>'' and Status = {0} order by DateCreated desc ", CInt(ePODelivery.Cancelled))
          mOK = mdsoSalesOrder.LoadPODeliveryDT(mDataTable, mWhere)

      End Select

      gridBrowseList.DataSource = mDataTable
      ''Set lookup columns
      mGridView = gridBrowseList.MainView

      ''gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)

      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")

      gridBrowseList.Update()
      gridBrowseList.Refresh()

    Catch ex As Exception
      mOK = False

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyAppService) Then Throw


    Finally
      'mdsoSalesQuote = Nothing
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
    ''  End If
    ''  mGridView = CType(Me.gridBrowseList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
    ''  mGridView.FocusedRowHandle = mGridView.LocateByValue("PrimaryKeyID", vPrimaryKey)
    ''End If
  End Sub

  Public Overrides Function PrepareForm() As Boolean 'Implements intBrowseList.PrepareForm
    'Dim mdsoProfile As New dsoProfile(Me.DBConn)
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True
    Dim mRTISGlobal As AppRTISGlobal
    Dim mVIs As colValueItems

    mRTISGlobal = AppRTISGlobal.CreateInstance


    Try

      BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)

      mGridView = gridBrowseList.Views(0)
      mGridView = CType(Me.gridBrowseList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)



      With CType(Me.BrowseForm, frmBrowseList)
        .ReLabelToolBarButtons("Agregar", "Editar", "Ver", "Eliminar", "Actualizar", "Listas", "Seleccionar", "Procesar", "Imprimir", "Exportar", "Opciones")

        .AddListOption("Activas", eListOption.LivePODelivery)
        .AddListOption("Recibidas", eListOption.Received)
        .AddListOption("Todas", eListOption.All)
        .AddListOption("Canceladas", eListOption.Cancelled)

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



  Public Overrides Sub CloseFrom() ' Implements intBrowseList.CloseFrom
    DBConn = Nothing
    BrowseRefreshTracker = Nothing
  End Sub

  Public Overrides Function PrepareList() As Boolean
    Static sLayoutOption As Integer = -1
    Dim mNewLayoutOption As Integer = 0
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True
    Dim mDateRep As New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Dim mPersistentRepository1 As New PersistentRepository

    Dim mRepButton As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Try


      Select Case Me.ListOptionID
        Case eListOption.LivePODelivery
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvPODeliveryList.xml")
          ListTitle = "Recepción de Artículos: Activas"


        Case eListOption.All
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvPODeliveryList.xml")
          ListTitle = "Recepción de Artículos: Todas"


        Case eListOption.Cancelled
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvPODeliveryList.xml")
          ListTitle = "Recepción de Artículos: Canceladas"


        Case eListOption.Received
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvPODeliveryList.xml")
          ListTitle = "Recepción de Artículos: Recibidas"

      End Select

      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      gridBrowseList.RepositoryItems.Clear()
      gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
      mGridView = gridBrowseList.MainView

      If Not gridBrowseList.RepositoryItems.Contains(mDateRep) Then
        gridBrowseList.RepositoryItems.Add(mDateRep)
      End If

      mRepButton.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
      mRepButton.Buttons.Item(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
      mRepButton.Buttons.Item(0).Caption = "Ver"

      mGridView.Columns("FileExport").ColumnEdit = mRepButton


      gridBrowseList.RepositoryItems.Add(mRepButton)

      Me.AddButton = eActiveVisibleState.Active
      Me.ViewButton = eActiveVisibleState.Invisible
      Me.EditButton = eActiveVisibleState.Active
      Me.DeleteButton = eActiveVisibleState.Active

      Me.PrintAndExportAvailable = True
      clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PurchaseCategory"), clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories)))



      mOK = True
      AddHandler mRepButton.ButtonClick, AddressOf Me.OpenPODeliveryDocument
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    'mdsoProfile = Nothing

    Return mOK
  End Function

  Public Sub OpenPODeliveryDocument(ByVal sender As System.Object, ByVal e As EventArgs)
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mDocument As String = ""
    mGridView = gridBrowseList.MainView

    If Not IsDBNull(mGridView.GetFocusedRowCellValue(mGridView.Columns("FileExport"))) Then
      mDocument = mGridView.GetFocusedRowCellValue(mGridView.Columns("FileExport"))

      If mDocument <> "" Then
        Process.Start(mDocument)
      End If
    End If



  End Sub
End Class
