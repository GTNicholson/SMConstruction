Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPCore

Public Class brwCurrentUserLocks : Inherits brwBrowserListBase

  Public Enum eListOption
    CurrentLocksNoSelect = 1
    CurrentLocksWithSelect = 2
  End Enum

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal, ByVal vBrowseID As Integer, Optional ByVal vListOption As Integer = eListOption.CurrentLocksNoSelect)
    MyBase.New(rDBConn, rRTISGlobal, vBrowseID, vListOption)

  End Sub

  Public Overrides Function AddButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.AddButtonClicked
    'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, 0, BrowseRefreshTracker,eFormMode.eFMFormModeAdd)
    'frmCustomerDetail.OpenFormAsModal((rForm, Me.DBConn, Me.RTISGlobal)
  End Function

  Public Overrides Function EditButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.EditButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("No row selected")
    Else

      'MsgBox(CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag)
      'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("CustomerID")), BrowseRefreshTracker,eFormMode.eFMFormModeEdit)
    End If

  End Function

  Public Overrides Sub ViewButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) ''Implements intBrowseList.ViewButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
    If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      MsgBox("No row selected")
    Else
      'frmCustomerDetail.OpenFormAsMDIChild(rForm.ParentForm, Me.DBConn.RTISUser, Me.RTISGlobal, mGridView.GetFocusedRowCellValue(mGridView.Columns("CustomerID")), BrowseRefreshTracker,eFormMode.eFMFormModeView)
    End If

  End Sub

  Public Overrides Function DeleteButtonClicked(ByVal sender As Object, ByVal e As System.EventArgs, ByRef rForm As Windows.Forms.Form) As Boolean ''Implements intBrowseList.DeleteButtonClicked
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    ''Dim mLockID As Integer
    ''Dim mLockTime As Date
    Dim mLock As RTIS.DataLayer.clsDBLockExtendedInfo
    Dim mRow As DataRow
    Try
      ''If mGridView.IsDataRow(GridView1.FocusedRowHandle) Then
      If mGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        MsgBox("No row selected")
      Else
        mRow = mGridView.GetFocusedDataRow()
        mLock = Me.DBConn.dsoUserLogin.ReadLockDetailsFromDataRow(mRow)

        '' TODO - ?? Add a method to message user to come out of locked item ??
        'Check with user
        If MsgBox("Delete the user lock on table: " & mLock.TableName & " Record: " & mLock.PrimaryID & " " & mLock.LockRefDetails & vbCrLf _
                & "Locked at: " & Format(mLock.TimeLocked, "dd/MM/yyyy hh:mm") & " by: " & mLock.UserName & " on PC:" & mLock.HostPC, MsgBoxStyle.OkCancel, "Force Lock Removal") = MsgBoxResult.Ok Then

          If Me.DBConn.dsoUserLogin.ForceRemoveLockFromDB(mLock, mLock.ConcurrentUserID) Then
            MsgBox("Lock removed")
            'Inform user (network command ?? or something built into our application)

          Else
            MsgBox("Problem removing lock")
          End If

          'In either case refresh grid
          LoadData()

        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Function

  ''Private Function RemoveALock()

  ''End Function

  Public Overrides Function ListChangeLoadData() As Boolean
    Static sDataOption As Integer = -1
    Dim mNewGroup As Integer = 0
    Dim mOK As Boolean
    Select Case Me.ListOptionID
      Case eListOption.CurrentLocksNoSelect, eListOption.CurrentLocksWithSelect
        mNewGroup = 1
      Case Else
        mNewGroup = 0
    End Select
    If mNewGroup <> sDataOption Then
      sDataOption = mNewGroup
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


    'Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Try
      'gridBrowseList.BeginUpdate()
      mDataTable = Me.DBConn.dsoUserLogin.CurrentUserLocksTable(appLockEntitys.GetInstance) 'appLockEntitys.GetInstance)
      Select Case Me.ListOptionID
        Case eListOption.CurrentLocksNoSelect

        Case eListOption.CurrentLocksWithSelect
          mDataTable.Columns.Add("IncludeRow", Type.GetType("System.Boolean"))
      End Select

      ''Dim mdso As New dsoLockItemDetails(DBConn)
      ''mdso.AddLockDetails(mDataTable, MyAppLockEntitys.GetInstance)
      ''mdso = Nothing

      gridBrowseList.DataSource = mDataTable
      ''Set lookup columns
      '' mGridView = gridBrowseList.MainView

      ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(libProductDefinition.PartType)))
      ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")

      'gridBrowseList.Update()
      ''gridBrowseList.Refresh()
      mOK = True
    Catch ex As Exception
      mOK = False

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw


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
    'ListTitle = "Current User Locks"

    'Me.XtraGridPrintExport = New appXtraGridPrintExport()
    'Me.XtraGridPrintExport = New clsAppBrowsePrinting
    BrowseRefreshTracker = New clsBasicBrowseRefreshTracker(1, clsUpdateNotification.GetInstance)

    CType(Me.BrowseForm, frmBrowseList).AddListOption("CurrentLocksNoSelect", eListOption.CurrentLocksNoSelect)
    CType(Me.BrowseForm, frmBrowseList).AddListOption("CurrentLocksWithSelect", eListOption.CurrentLocksWithSelect)

    'CType(Me.BrowseForm, frmBrowseList).AddEditOption("Edit Option2", 2)

    PrepareList()
    Return True
  End Function

  Public Overrides Function PrepareList() As Boolean
    Static sLayoutOption As Integer = -1
    Dim mNewLayoutOption As Integer = 0
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mOK As Boolean = True
    Try
      Select Case Me.ListOptionID
        Case eListOption.CurrentLocksNoSelect
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlCurrentUserLocks.xml")
          Me.SelectColumnActive = False
          ListTitle = "Current User Locks (No Select)"
          ' CType(Me.BrowseForm, frmBrowseList).AddEditOption("Edxit 2", 2)
          mNewLayoutOption = 1
        Case eListOption.CurrentLocksWithSelect
          LayoutFile = System.IO.Path.Combine(RTISGlobal.AuxFilePath, "gvlCurrentUserLocksSelect.xml")
          Me.SelectColumnActive = True
          ListTitle = "Current User Locks (With Select)"
          mNewLayoutOption = 2
          ' CType(Me.BrowseForm, frmBrowseList).RemoveEditOption(2)
      End Select

      'or


      GridEditable = False
      'PrimaryKeyColumnName = "PrimaryID"

      'gridBrowseList.BeginUpdate()
      If sLayoutOption <> mNewLayoutOption Then
        sLayoutOption = mNewLayoutOption
        gridBrowseList.RepositoryItems.Clear()
        gridBrowseList.MainView.RestoreLayoutFromXml(Me.LayoutFile, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
        gridBrowseList.Refresh()

        mGridView = gridBrowseList.MainView
        ''Set lookup columns


        ''clsDEControlLoading.LoadGridLookUpEdit(Me.gridBrowseList, mGridView.Columns("PartDefType"), clsEnumsConstants.EnumToVIs(GetType(ePartType)))
        ''clsDEControlLoading.LoadGridLookUpEditIList(Me.gridBrowseList, mGridView.Columns("ComponentType"), colWindowComponentType.GetInstance, "ComponentType", "Description")
        'gridBrowseList.Update()
        ' gridBrowseList.Refresh()
      End If

      Me.AddButton = eActiveVisibleState.Invisible
      Me.ViewButton = eActiveVisibleState.Invisible
      Me.EditButton = eActiveVisibleState.Invisible
      If My.Application.RTISUserSession.ActivityPermission(eActivityCode.ForceLockRemoval) >= ePermissionCode.ePC_Full Then
        Me.DeleteButton = eActiveVisibleState.Active
      Else
        Me.DeleteButton = eActiveVisibleState.VisibleInactive

      End If
      Me.PrintAndExportAvailable = True


      If Me.SelectColumnActive And Me.DeleteButton = eActiveVisibleState.Active Then
        With CType(Me.BrowseForm, frmBrowseList)
          .AddProcessOption("Example Process", AddressOf BatchProcessRemoveLock)
        End With

      Else
        CType(Me.BrowseForm, frmBrowseList).ClearProcessOption("Example Process")
      End If
      mOK = True
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

  Private Sub BatchProcessRemoveLock(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    'Check to see if have filtered the list at all

    Dim mRow As DataRow
    Dim mLock As RTIS.DataLayer.clsDBLockExtendedInfo
    Dim mNumRemoved As Integer = 0
    Dim mNumNotRemoved As Integer = 0

    ''Dim mMainView As DevExpress.XtraGrid.Views.Grid.GridView = gridBrowseList.MainView
    ''Dim mActiveFilter As DevExpress.XtraGrid.Views.Base.ViewFilter = mMainView.ActiveFilter
    ' Dim mOK As Boolean = True
    ''If mActiveFilter.IsEmpty And mMainView.FindFilterText.Length = 0 Then
    ''  mOK = MsgBox("You have not applied a filter, are you sure you want to batch process all entries?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok
    ''ElseIf gridBrowseList.MainView.RowCount = 0 Then
    ''  mOK = False
    ''  MsgBox("There are no rows selected/visible, therefore nothing to process")
    ''ElseIf mMainView.ActiveFilterEnabled = False And mMainView.FindFilterText.Length = 0 Then
    ''  mOK = MsgBox("The filter is not enabled, are you sure you want to process all entries?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok
    ''End If
    ''If mOK Then

    ''  For mItemCount As Integer = 0 To mMainView.RowCount - 1
    ''    mRow = mMainView.GetDataRow(mItemCount)
    ''    ''mAnID = mMainView.GetRowCellValue(mItemCount, "AnID")
    ''    mLock = Me.DBConn.dsoUserLogin.ReadLockDetailsFromDataRow(mRow)

    ''    If Me.DBConn.dsoUserLogin.ForceRemoveLockFromDB(mLock, mLock.ConcurrentUserID) Then
    ''      mNumRemoved += 1
    ''    Else
    ''      mNumNotRemoved += 1
    ''    End If
    ''  Next
    ''  MsgBox(mNumRemoved & " Locks removed. " & mNumNotRemoved & " Locks not removed.")
    ''  LoadData()
    ''End If

    Dim mRows() As DataRow = CType(gridBrowseList.DataSource, DataTable).Select("IncludeRow = 1")
    If mRows.Length = 0 Then
      MsgBox("There are no rows selected/visible, therefore nothing to process")
    Else
      If MsgBox("Clear " & mRows.Length & " selected locks?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        For Each mRow In mRows
          mLock = Me.DBConn.dsoUserLogin.ReadLockDetailsFromDataRow(mRow)

          If Me.DBConn.dsoUserLogin.ForceRemoveLockFromDB(mLock, mLock.ConcurrentUserID) Then
            mNumRemoved += 1
          Else
            mNumNotRemoved += 1
          End If
        Next
        MsgBox(mNumRemoved & " Locks removed. " & mNumNotRemoved & " Locks not removed.")
        LoadData()
      End If
    End If

  End Sub


End Class
