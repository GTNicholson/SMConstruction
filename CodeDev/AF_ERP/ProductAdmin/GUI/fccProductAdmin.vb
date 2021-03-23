Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class fccProductAdmin


  Private pCurrentProductType As eProductType
  Private pIsLocked As Boolean
  Private pProductTypes As List(Of eProductType)
  Private pIsCostingOnly As Boolean
  Private pIsGeneric As Boolean
  Private pSelectedItems As colProductBaseInfos
  Private pDBConn As clsDBConnBase
  Private pCurrentProductInfo As clsProductBaseInfo
  Private pCurrentProductBase As dmProductBase
  Private pProductBaseInfos As colProductBaseInfos
  Private pRTISGlobal As AppRTISGlobal

  Public ReadOnly Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property IsGeneric As Boolean
    Get
      Return pIsGeneric
    End Get
    Set(value As Boolean)
      pIsGeneric = value
    End Set
  End Property
  Public Property IsCostingOnly As Boolean
    Get
      Return pIsCostingOnly
    End Get
    Set(value As Boolean)
      pIsCostingOnly = value
    End Set
  End Property

  Public Property IsLocked As Boolean
    Get
      IsLocked = pIsLocked
    End Get
    Set(value As Boolean)
      pIsLocked = value
    End Set
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property


  Public Property CurrentEmodeProductType As eProductType
    Get
      Return pCurrentProductType
    End Get
    Set(value As eProductType)
      pCurrentProductType = value
    End Set
  End Property

  Public Property ProductTypes As List(Of eProductType)
    Get
      Return pProductTypes
    End Get
    Set(value As List(Of eProductType))
      pProductTypes = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pProductBaseInfos = New colProductBaseInfos

    pSelectedItems = New colProductBaseInfos
  End Sub
  Public ReadOnly Property CurrentProductInfo() As clsProductBaseInfo
    Get
      Return pCurrentProductInfo
    End Get
  End Property

  Public Property CurrentProductBase As dmProductBase
    Get
      Return pCurrentProductBase
    End Get
    Set(value As dmProductBase)
      pCurrentProductBase = value
    End Set
  End Property

  Public ReadOnly Property ProductBaseInfos As colProductBaseInfos
    Get
      Return pProductBaseInfos
    End Get
  End Property

  Public Sub LoadObject()
    pCurrentProductType = 0 '// All
    LoadMainCollection()
  End Sub
  Public Function IsAnyDirty() As Boolean


    Dim mIsDirty As Boolean = True

    If CurrentProductBase IsNot Nothing Then
      mIsDirty = CurrentProductBase.IsDirty
    Else
      mIsDirty = False
    End If
    Return mIsDirty

  End Function

  Public Function ValidateObject() As clsValidate
    Dim mValidate As New clsValidate
    mValidate.ValOk = True
    If False Then '' Change to perform validation checks
      mValidate.ValOk = False
      mValidate.AddMsgLine("Check failed details")
    End If
    Return mValidate
  End Function

  Public Sub LoadMainCollection()
    Dim mdsoProductAdmin As New dsoProductAdmin(pDBConn)
    Try
      pProductBaseInfos.Clear()

      mdsoProductAdmin.LoadProductInfosByWhere(pProductBaseInfos, "")

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoProductAdmin = Nothing
    End Try

  End Sub


  Public Sub LoadMainCollectionByStockOptionFilter(ByVal vWhere As String)
    Dim mdsoProductAdmin As New dsoProductAdmin(pDBConn)
    Try
      pProductBaseInfos.Clear()

      mdsoProductAdmin.LoadProductInfosByWhere(pProductBaseInfos, vWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoProductAdmin = Nothing
    End Try

  End Sub

  Public Sub SaveObject()
    Try

      If pCurrentProductInfo IsNot Nothing Then

        If pCurrentProductInfo.Product IsNot Nothing Then
          Dim mdsoProductAdmin As New dsoProductAdmin(pDBConn)


          mdsoProductAdmin.SaveProductStructureDown(pCurrentProductInfo.Product)



          mdsoProductAdmin = Nothing
        End If

      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Public Sub AddProductItem_SetToCurrent(ByVal vProductType As eProductType)
    Try
      Dim mProductBaseInfo As New clsProductBaseInfo
      Dim mProvisional As Boolean = False
      mProductBaseInfo.Product = clsProductSharedFuncs.NewProductInstance(vProductType)

      mProductBaseInfo.Product.ItemType = vProductType
      pProductBaseInfos.Add(mProductBaseInfo)

      pCurrentProductBase = mProductBaseInfo.Product
      pCurrentProductInfo = mProductBaseInfo
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub GotoGridRowByRowObject(ByVal vGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal vRowObject As Object)
    Dim rowHandle As Integer = GetRowHandleByRowObject(vGridView, vRowObject)
    If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      vGridView.FocusedColumn = vGridView.Columns(0)
      vGridView.FocusedRowHandle = rowHandle
      vGridView.ShowEditor()
    Else
      'MessageBox.Show("Not found!")
    End If
  End Sub

  Private Function GetRowHandleByRowObject(ByVal vGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal vRowObject As Object) As Integer
    Dim result As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim i As Integer
    For i = 0 To vGridView.RowCount - 1
      If Object.ReferenceEquals(vGridView.GetRow(i), vRowObject) Then
        Return i
      End If
    Next
    Return result
  End Function

  Public Function GetVisibleRowHandleByRowObject(ByVal vGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal vRowObject As Object) As Integer
    Dim result As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim i As Integer
    For i = 0 To vGridView.DataRowCount - 1
      If Object.ReferenceEquals(vGridView.GetRow(i), vRowObject) Then
        Return i
      End If
    Next
    Return result
  End Function


  Public Sub SetCurrentStockItemInfo(ByRef rProductBaseInfo As clsProductBaseInfo)
    pCurrentProductInfo = rProductBaseInfo
    pCurrentProductBase = rProductBaseInfo.Product

  End Sub






  Public Property SelectedItems As colProductBaseInfos
    Get
      Return pSelectedItems
    End Get
    Set(value As colProductBaseInfos)
      pSelectedItems = value
    End Set
  End Property

  Public Sub LoadProductConstructionSubTypes(ByRef rProductConstructionSubTypes As colProductConstructionSubTypes, ByVal vProductItemType As Integer)
    Dim mdso As New dsoProductAdmin(pDBConn)
    Dim mWhere As String = "ProductConstructionTypeID = " & vProductItemType
    Try
      mdso.LoadProductConstructionSubTypesByTypeID(rProductConstructionSubTypes, vProductItemType)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub





End Class
