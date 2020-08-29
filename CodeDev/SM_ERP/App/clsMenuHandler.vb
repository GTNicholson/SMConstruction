Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports RTIS.Elements

''In MDI InitmenuOptions call PopulateNavBarMenu(MenuFactory.BuildMenu)

Public Class clsMenuHandler
  Dim pMenuForm As Form
  Dim pNavBarControl As DevExpress.XtraNavBar.NavBarControl
  Dim pImageCollection As DevExpress.Utils.ImageCollection
  Dim pTemplateTreeList As DevExpress.XtraTreeList.TreeList
  Dim pRTISGLobal As RTIS.Elements.clsRTISGlobal

  Shared sHotTrackNode As TreeListNode = Nothing

  Shared Property HotTrackNode() As TreeListNode
    Get
      Return sHotTrackNode
    End Get
    Set(ByVal value As TreeListNode)
      If sHotTrackNode IsNot value Then
        Dim prevHotTrackNode As TreeListNode = sHotTrackNode
        sHotTrackNode = value
        ''If treeList1.ActiveEditor IsNot Nothing Then
        ''  treeList1.PostEditor()
        ''End If
        ''treeList1.RefreshNode(prevHotTrackNode)
        ''treeList1.RefreshNode(sHotTrackNode)
        If prevHotTrackNode IsNot Nothing Then prevHotTrackNode.TreeList.RefreshNode(prevHotTrackNode)
        If sHotTrackNode IsNot Nothing Then sHotTrackNode.TreeList.RefreshNode(sHotTrackNode)
      End If
    End Set
  End Property

  ''Public Sub GetSkinColours()
  ''  Dim currentSkin As DevExpress.Skins.Skin
  ''  Dim element As DevExpress.Skins.SkinElement
  ''  Dim elementName As String
  ''  Dim mColour As Color

  ''  currentSkin = DevExpress.Skins.CommonSkins.GetSkin(frmTabbedMDINEW.DefaultLookAndFeelMDI.LookAndFeel)
  ''  elementName = DevExpress.Skins.CommonSkins.SkinTextBorder
  ''  element = currentSkin(elementName)
  ''  mColour = element.Color.BackColor


  ''  DevExpress.Skins.NavBarSkins.GetSkin(frmTabbedMDINEW.DefaultLookAndFeelMDI.LookAndFeel)
  ''  elementName = DevExpress.Skins.NavBarSkins.SkinGroupOpenButton
  ''  element = currentSkin(elementName)
  ''  mColour = element.Color.BackColor
  ''End Sub

  Public Sub New(ByRef rMenuForm As Form, ByRef rNavBarControl As DevExpress.XtraNavBar.NavBarControl, ByRef rImageCollection As DevExpress.Utils.ImageCollection, ByRef rTemplateTreeList As DevExpress.XtraTreeList.TreeList, ByRef rRTISGLobal As RTIS.Elements.clsRTISGlobal)
    MyBase.New()
    pNavBarControl = rNavBarControl
    pImageCollection = rImageCollection
    pTemplateTreeList = rTemplateTreeList
    pMenuForm = rMenuForm
    pRTISGLobal = rRTISGLobal
  End Sub

  Public Sub PopulateNavBarMenu(rMenuOptions As clsMenuEntries)

    Dim mMenuItemGroup As DevExpress.XtraNavBar.NavBarGroup
    Dim mTreeList As DevExpress.XtraTreeList.TreeList
    Dim mHeight As Integer
    Dim mStream As New System.IO.MemoryStream
    pTemplateTreeList.SaveLayoutToStream(mStream, DevExpress.Utils.OptionsLayoutBase.FullLayout)

    For Each mME As clsMenuEntry In rMenuOptions
      If mME.MenuType = 0 Then
        'OfficeNavigationBar1.

        mMenuItemGroup = pNavBarControl.Groups(mME.MenuGroup)
        If mMenuItemGroup Is Nothing Then
          mMenuItemGroup = pNavBarControl.Groups.Add()
          mMenuItemGroup.Name = mME.MenuGroup
          mMenuItemGroup.Caption = mME.MenuGroup
          mMenuItemGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
          mMenuItemGroup.GroupClientHeight = 120
          mMenuItemGroup.Expanded = mME.StartExpaned

          '' mMenuItemGroup.ControlContainer.MinimumSize = 40

          mTreeList = New DevExpress.XtraTreeList.TreeList
          mTreeList.Tag = mMenuItemGroup


          'mTreeList.Nodes.Add()
          mStream.Seek(0, IO.SeekOrigin.Begin)
          mTreeList.RestoreLayoutFromStream(mStream, DevExpress.Utils.OptionsLayoutBase.FullLayout)

          mTreeList.StateImageList = pImageCollection
          'mTreeList.SelectImageList = Me.ImageCollection1
          ''mTreeList.OptionsView.ShowColumns = False
          ''mTreeList.OptionsView.ShowIndicator = False
          Dim mCont As New Panel
          mTreeList.Visible = False
          mMenuItemGroup.ControlContainer.Controls.Add(mTreeList)
          mTreeList.Dock = DockStyle.Fill

          AddHandler mTreeList.MouseDown, AddressOf TreeList1_MouseDown
          AddHandler mTreeList.AfterCollapse, AddressOf TreeList1_AfterCollapse
          AddHandler mTreeList.AfterExpand, AddressOf TreeList1_AfterExpand
          AddHandler mTreeList.NodeCellStyle, AddressOf treeList1_NodeCellStyle

          AddHandler mTreeList.MouseMove, AddressOf TreeList1_MouseMove
          AddHandler mTreeList.MouseLeave, AddressOf TreeList1_MouseLeave

          AddItemsToTree(mME, mTreeList.Nodes)

          ''mMenuItemGroup.GroupClientHeight = Screen.FromControl(Me).Bounds.Height
          ''Dim mMin As Integer
          ''mTreeList.Height = mMenuItemGroup.GroupClientHeight
          ''mTreeList.ViewInfo.CalcRowsInfo()
          ''mMin = mTreeList.ViewInfo.ViewRects.RowsTotalHeight _
          ''+ mTreeList.ViewInfo.ColumnPanelHeight _
          ''+ mTreeList.ViewInfo.FooterPanelHeight _
          ''+ mTreeList.ViewInfo.ViewRects.EmptyBehindColumn.Height _
          ''+ mTreeList.Margin.Top _
          ''+ mTreeList.Margin.Bottom
          ''mTreeList.Height = mMin + 50

          ''mMenuItemGroup.GroupClientHeight = 6 + mTreeList.VisibleNodesCount * 20
          ''If mMenuItemGroup.GroupClientHeight > Screen.FromControl(Me).Bounds.Height / 2 Then
          ''  mMenuItemGroup.GroupClientHeight = Screen.FromControl(Me).Bounds.Height / 2
          ''End If
          mHeight = 6 + mTreeList.VisibleNodesCount * 18
          If mHeight > Screen.FromControl(pMenuForm).Bounds.Height * 0.8 Then mHeight = Screen.FromControl(pMenuForm).Bounds.Height * 0.8 ' Or check form height
          mMenuItemGroup.GroupClientHeight = mHeight
          ''= New DevExpress.XtraNavBar.NavBarGroupControlContainer
          mTreeList.Visible = True

          If My.Application.RTISUserSession.ActivityPermission(mME.ActivityCode) = ePermissionCode.ePC_None Then
            mMenuItemGroup.Visible = False
          End If
        Else

        End If


      Else
        '' Check groups ??

      End If
    Next
    mStream.Dispose()
    mStream = Nothing
  End Sub

  Private Sub AddItemsToTree(ByRef mMenuEntry As clsMenuEntry, ByRef mNodes As DevExpress.XtraTreeList.Nodes.TreeListNodes)
    Dim mNode As DevExpress.XtraTreeList.Nodes.TreeListNode

    For Each mEntry As clsMenuEntry In mMenuEntry.ChildGroupMenuEntries
      mNode = mNodes.Add({0, -1, mEntry.MenuCaption})
      mNode.Item(0) = mEntry.MenuCaption

      mNode.StateImageIndex = mEntry.IconType
      'mNode.SelectImageIndex = eMenuIconType.Selected
      'mNode.ImageIndex = mEntry.IconType
      mNode.Tag = mEntry

      AddItemsToTree(mEntry, mNode.Nodes)

    Next


  End Sub

  ''treeList1_NodeCellStyle needed to change a specific row to bold
  Private Sub treeList1_NodeCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs)
    Dim tree As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
    Dim mEntry As clsMenuEntry = e.Node.Tag
    If mEntry.IconType = RTIS.ImageLibrary.eMenuIcons.FolderClosed Then
      e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
    End If
    If e.Node Is HotTrackNode Then
      e.Appearance.BackColor = Color.LightBlue
    End If

  End Sub


  Private Sub TreeList1_AfterCollapse(sender As Object, e As DevExpress.XtraTreeList.NodeEventArgs) ''Handles TreeList1.AfterCollapse
    '' Check sizes
    Dim mMenuItemGroup As DevExpress.XtraNavBar.NavBarGroup
    Dim mTreeList As DevExpress.XtraTreeList.TreeList
    Dim mHeight As Integer
    mTreeList = CType(sender, DevExpress.XtraTreeList.TreeList)
    mMenuItemGroup = mTreeList.Tag

    mHeight = 6 + mTreeList.VisibleNodesCount * 18
    If mHeight > Screen.FromControl(pMenuForm).Bounds.Height * 0.8 Then mHeight = Screen.FromControl(pMenuForm).Bounds.Height * 0.8 ' Or check form height
    mTreeList.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never
    mMenuItemGroup.GroupClientHeight = mHeight
    mTreeList.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto

  End Sub

  Private Sub TreeList1_AfterExpand(sender As Object, e As DevExpress.XtraTreeList.NodeEventArgs) ''Handles TreeList1.AfterExpand
    '' Check sizes
    Dim mMenuItemGroup As DevExpress.XtraNavBar.NavBarGroup
    Dim mTreeList As DevExpress.XtraTreeList.TreeList
    Dim mHeight As Integer
    mTreeList = CType(sender, DevExpress.XtraTreeList.TreeList)
    mMenuItemGroup = mTreeList.Tag
    mHeight = 6 + mTreeList.VisibleNodesCount * 18
    If mHeight > Screen.FromControl(pMenuForm).Bounds.Height * 0.8 Then mHeight = Screen.FromControl(pMenuForm).Bounds.Height * 0.8 ' Or check form height
    mTreeList.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never
    mMenuItemGroup.GroupClientHeight = mHeight
    mTreeList.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto
  End Sub

  Private Sub TreeList1_MouseDown(sender As Object, e As MouseEventArgs) ''Handles TreeList1.MouseDown
    Dim tree As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
    Dim hitInfo As DevExpress.XtraTreeList.TreeListHitInfo = tree.CalcHitInfo(e.Location)
    If hitInfo.HitInfoType = DevExpress.XtraTreeList.HitInfoType.Cell Then
      ''If (Not hitInfo.Node.Expanded) Then
      ''  hitInfo.Node.Expanded = True
      ''End If
      ''hitInfo.Node.Tag
      tree.FocusedNode = hitInfo.Node
      tree.Refresh()
      Dim mEntry As clsMenuEntry = TryCast(hitInfo.Node.Tag, clsMenuEntry)

      If mEntry IsNot Nothing Then
        mEntry.MenuDelegate().Invoke(mEntry, pMenuForm, My.Application.RTISUserSession, pRTISGLobal)
      End If
    End If
  End Sub

  Private Sub TreeList1_MouseMove(sender As Object, e As MouseEventArgs) ''Handles TreeList1MouseMove
    Dim treelist As TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
    Dim info As TreeListHitInfo = treelist.CalcHitInfo(New Point(e.X, e.Y))
    HotTrackNode = If(info.HitInfoType = HitInfoType.Cell, info.Node, Nothing)


  End Sub

  Private Sub TreeList1_MouseLeave(sender As Object, e As EventArgs) ''Handles TreeList1.MouseLeave
    HotTrackNode = Nothing

  End Sub
End Class
