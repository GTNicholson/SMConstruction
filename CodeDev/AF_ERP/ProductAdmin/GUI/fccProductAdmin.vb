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
  Public ReadOnly Property CurrentStockItemInfo() As clsProductBaseInfo
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

  Public Sub LoadStockItemBOM()
    Dim mdsoProductAdmin As New dsoProductAdmin(pDBConn)
    Try
      pCurrentProductBase.StockItemBOMs.Clear()

      mdsoProductAdmin.LoadStockItemBOM(pCurrentProductBase.StockItemBOMs, pCurrentProductBase.ID)

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
          Dim mdsoStock As New dsoStock(pDBConn)


          mdsoStock.SaveProductBase(pCurrentProductInfo)



          mdsoStock = Nothing
        End If

      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Public Function CheckStockCodeExists(ByVal vStockCode As String) As Boolean
    ''Dim mRetval As Boolean
    ''Dim mdsoStock As New dsoStock(pDBConn)

    ''Try

    ''  mRetval = mdsoStock.CheckStockcodeExists(pCurrentProductBase.StockItemID, vStockCode)

    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    ''End Try

    ''Return mRetval

  End Function

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

  ''Public Function CreateStockItemDuplicates(rStockItem As dmStockItem, rThicknessList As List(Of Integer), rWidthList As List(Of Integer), rLengthList As List(Of Integer)) As Int32
  ''  Dim mNewSI As dmStockItem
  ''  Dim mdso As New dsoStock(pDBConn)
  ''  Dim mStockItems As New colStockItems
  ''  Dim mReturn As Integer = 0
  ''  Dim mDescription As clsStockItemDescription

  ''  For Each mThick As Integer In rThicknessList
  ''    For Each mWidth As Integer In rWidthList
  ''      For Each mLength As Integer In rLengthList

  ''        mNewSI = rStockItem.Clone
  ''        mNewSI.ClearKeys()
  ''        mDescription = New clsStockItemDescription(mNewSI)
  ''        mNewSI.Thickness = mThick
  ''        mNewSI.Width = mWidth
  ''        mNewSI.Length = mLength
  ''        mNewSI.Description = clsStockItemSharedFuncs.DeriveDescription(False, mNewSI)
  ''        mNewSI.StockCode = clsStockItemSharedFuncs.GetStockCode(mNewSI) ''mDescription.DeriveStockCode
  ''        'Check in data (in dso function) if this stockitem definition already exists


  ''        mStockItems = mdso.GetStockItemsBySpecs(mThick, mWidth, mLength, rStockItem.Category, rStockItem.ItemType, rStockItem.SubItemType, rStockItem.Colour, rStockItem.Species)


  ''        If mStockItems.Count = 0 Then
  ''          mdso.SaveStockItem(mNewSI)
  ''          mReturn = mReturn + 1
  ''        End If


  ''        'Save the mNewSI
  ''      Next
  ''    Next
  ''  Next
  ''  Return mReturn
  ''End Function

  Public Sub SetCurrentStockItemInfo(ByRef rProductBaseInfo As clsProductBaseInfo)
    pCurrentProductInfo = rProductBaseInfo
    pCurrentProductBase = rProductBaseInfo.Product

  End Sub
  Public Sub LoadStockItemExtraDetails()
    ''Dim mdsoStock As New dsoStock(pDBConn)
    ''Dim mWhere As String = ""
    ''Try
    ''  If pCurrentProductBase IsNot Nothing Then
    ''    mdsoStock.LoadStockItem(pCurrentProductBase, pCurrentProductBase.StockItemID)


    ''    pCurrentProductBase.tmpIsFullyLoadedDown = True



    ''    pCurrentProductInfo.StockItem = pCurrentProductBase ''//It's neccesary due to the behavior of the instance of the dto

    ''  End If
    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    ''Finally
    ''  mdsoStock = Nothing
    ''End Try

  End Sub
  Public Sub ClearObjects()
    ''If pIsLocked And pCurrentProductBase.ID > 0 Then
    ''  Dim mdso As New dsoStock(pDBConn)
    ''  mdso.UnlockStockItem(pCurrentProductBase.StockItemID)
    ''End If
    ''pCurrentProductBase = Nothing
  End Sub

  Public Function LockStockItem(ByVal vStockItemID As Integer) As Boolean
    ''Dim mRetVal As Boolean
    ''Dim mdso As New dsoStock(pDBConn)
    ''Try
    ''  If pDBConn.Connect() Then
    ''    mRetVal = mdso.LockStockItem(vStockItemID)
    ''    pIsLocked = mRetVal
    ''  End If
    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    ''Finally
    ''  If pDBConn.IsConnected Then pDBConn.Disconnect()
    ''End Try
    ''Return mRetVal
  End Function

  Public Function UnLockStockItem(ByVal vStockItemID As Integer) As Boolean
    ''Dim mRetVal As Boolean
    ''Dim mdso As New dsoStock(pDBConn)
    ''Try
    ''  If pDBConn.Connect() Then
    ''    mRetVal = mdso.UnlockStockItem(vStockItemID)
    ''    pIsLocked = mRetVal
    ''  End If
    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    ''Finally
    ''  If pDBConn.IsConnected Then pDBConn.Disconnect()
    ''End Try
    ''Return mRetVal
  End Function

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

  Public Function GetProposedCode()
    Dim mDSO As dsoProductAdmin
    Dim mStem As String
    Dim mSuffix As Integer
    Dim mRetVal As String = ""

    mStem = clsProductSharedFuncs.GetProductCode(pCurrentProductBase)
    mDSO = New dsoProductAdmin(pDBConn)
    If mStem <> "" Then
      mSuffix = mDSO.GetNextProductConstructionCodeNo(mStem, pCurrentProductBase.ProductTypeID)

      mRetVal = mStem & mSuffix.ToString("000")
    End If
    Return mRetVal
  End Function

  Public Function CreateDrawingPDF(ByVal vFileName As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try
      If IO.File.Exists(vFileName) Then
        mFileName = "DRAWING_" & pCurrentProductBase.ID

        mExportDirectory = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.ProductFileFolderSys, clsGeneralA.GetFileSafeName(pCurrentProductBase.ID.ToString("00000")))

        mFileName &= IO.Path.GetExtension(vFileName)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)

        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vFileName, mFilePath, True)
        pCurrentProductBase.DrawingFileName = mFilePath

        If pCurrentProductBase.DrawingFileName <> "" Then
          mRetVal = True

        Else

          pCurrentProductBase.DrawingFileName = ""
          mRetVal = False
        End If
      End If

    Catch ex As Exception


      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal
  End Function

  Public Sub RefreshStockItemBOMs(ByRef rStockItems As List(Of dmStockItem))
    Dim mStockItemBOM As dmStockItemBOM
    Dim mProduct As dmProductBase
    Dim mFound As Boolean

    mProduct = pCurrentProductBase

    For Each mSI As dmStockItem In rStockItems
      If mProduct.StockItemBOMs.IndexFromStockItemID(mSI.StockItemID) = -1 Then
        mStockItemBOM = New dmStockItemBOM

        mStockItemBOM.ProductID = pCurrentProductBase.ID
        mStockItemBOM.StockItemID = mSI.StockItemID
        mStockItemBOM.Description = mSI.Description
        mStockItemBOM.StockCode = mSI.StockCode
        mProduct.StockItemBOMs.Add(mStockItemBOM)
      End If
    Next

    For mLoop As Integer = mProduct.StockItemBOMs.Count - 1 To 0 Step -1
      mFound = False
      mStockItemBOM = mProduct.StockItemBOMs(mLoop)
      If mStockItemBOM.StockItemID <> 0 Then '// this leaves the manual ones alone
        For Each mSI As dmStockItem In rStockItems
          If mStockItemBOM.StockItemID = mSI.StockItemID Then
            mFound = True
            Exit For
          End If
        Next
        If mFound = False Then
          mProduct.StockItemBOMs.RemoveAt(mLoop)
        End If
      End If
    Next


  End Sub
End Class
