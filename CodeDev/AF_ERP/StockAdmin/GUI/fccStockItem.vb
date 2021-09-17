Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.IO

Public Class fccStocktem
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPrimaryKeyID As Integer
  Private pStockItems As colStockItems
  ''  Private pStockItemsPicker As colStockItems
  Private pCurrentStockItem As dmStockItem
  ''  Private pCurrentAlternateCodes As colStockItemAlternateCodes
  Private pCategorys As List(Of eStockItemCategory)
  Private pCurrentCategory As eStockItemCategory
  Private pCurrentStockItemOpposite As dmStockItem
  Private pInterdenStockItem As dmStockItem
  Private ptmpIsFullyLoadedDown As Boolean
  Private pShowItemsMode As Integer
  Private pStockItem As dmStockItem

  Private pSIGlobalRegistry As clsStockItemRegistryBase

  Public Enum eShowItems
    ShowAll = 0
    ShowLive = 1
    ShowObsolete = 2
  End Enum

  Public ReadOnly Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Function GetSupplierList() As colSuppliers
    Dim mRetVal As New colSuppliers
    Dim mdso As dsoPurchasing
    Try
      mdso = New dsoPurchasing(pDBConn)
      mdso.LoadSuppliersByWhere(mRetVal, "SupplierName is not null")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub ReloadSupplier()
    Dim mdso As dsoPurchasing
    Try
      mdso = New dsoPurchasing(pDBConn)
      mdso.LoadSupplierDown(pCurrentStockItem.Supplier, pCurrentStockItem.DefaultSupplier)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public ReadOnly Property StockItems As colStockItems
    Get
      Return pStockItems
    End Get
  End Property

  Public ReadOnly Property SIGlobalRegistry As clsStockItemRegistryBase
    Get
      Return pSIGlobalRegistry
    End Get
  End Property

  Public Property CurrentStockItem As dmStockItem
    Get
      Return pCurrentStockItem
    End Get
    Set(value As dmStockItem)
      pCurrentStockItem = value
    End Set
  End Property

  Public ReadOnly Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
  End Property


  Public Property tmpIsFullyLoadedDown() As Boolean
    Get
      tmpIsFullyLoadedDown = ptmpIsFullyLoadedDown
    End Get
    Set(ByVal value As Boolean)
      ptmpIsFullyLoadedDown = value
    End Set
  End Property

  Public Property CurrentStockItemOpposite As dmStockItem
    Get
      Return pCurrentStockItemOpposite
    End Get
    Set(value As dmStockItem)
      pCurrentStockItemOpposite = value
    End Set
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public Property InterdenStockItem As dmStockItem
    Get
      Return pInterdenStockItem
    End Get
    Set(value As dmStockItem)
      pInterdenStockItem = value
    End Set
  End Property


  Public Property Categorys As List(Of eStockItemCategory)
    Get
      Return pCategorys
    End Get
    Set(value As List(Of eStockItemCategory))
      pCategorys = value
    End Set
  End Property

  Public Property CurrentCategory As eStockItemCategory
    Get
      Return pCurrentCategory
    End Get
    Set(value As eStockItemCategory)
      pCurrentCategory = value
    End Set
  End Property

  Public Property ShowItemsMode As eShowItems
    Get
      Return pShowItemsMode
    End Get
    Set(value As eShowItems)
      pShowItemsMode = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rRegistry As clsStockItemRegistryBase)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pStockItems = New colStockItems
    pSIGlobalRegistry = rRegistry
    pShowItemsMode = eShowItems.ShowLive
    pStockItem = New dmStockItem

  End Sub


  Public Sub LoadObject()
    pCurrentCategory = 0 '// All
    LoadStockItems()

    ''pStockItemRegistry = AppRTISGlobal.GetInstance.StockItemRegistry.CreateClone

  End Sub

  Public Sub LoadStockItems()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Dim mCatString As String = ""
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemLocationFound As dmStockItemLocation
    Try
      pStockItems = New colStockItems
      mWhere = "(ProjectID is null or ProjectID = 0)"

      For Each mCat As eStockItemCategory In pCategorys
        If mCatString <> "" Then mCatString = mCatString & ", "
        mCatString = mCatString & CInt(mCat).ToString
      Next

      If pCurrentCategory <> 0 Then
        ''If pCurrentCategory = eStockItemCategory.Facing Or pCurrentCategory = eStockItemCategory.Substrate Then
        ''  mWhere = mWhere & " And Category In (2, 11)"
        ''Else
        ''  mWhere = mWhere & " And Category=" & pCurrentCategory
        ''End If
      End If
      mWhere = mWhere & " AND Category in (" & mCatString & ")"
      If pShowItemsMode = eShowItems.ShowLive Then
        mWhere = mWhere & " And (Inactive = 0 Or Inactive Is Null) "
      ElseIf pShowItemsMode = eShowItems.ShowObsolete Then
        mWhere = mWhere & " And (Inactive = 1) "
      End If
      mdsoStock.LoadStockItemsByWhere(pStockItems, mWhere)


      ''//Load stockitemlocations
      mdsoStock.LoadStockItemLocationsByWhere(mStockItemLocations, "")

      For Each mStockItem In pStockItems
        mStockItemLocationFound = mStockItemLocations.ItemsFromStockItemID(mStockItem.StockItemID)

        If mStockItemLocationFound IsNot Nothing Then
          mStockItem.StockQuantity = mStockItemLocationFound.Qty
        End If

      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub
  Public Function CreateSIImageFile(ByVal vSourceFile As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try
      If IO.File.Exists(vSourceFile) Then
        mFileName = "IMG _" & pCurrentStockItem.StockItemID


        mExportDirectory = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.StockItemFileFolderSys, clsGeneralA.GetFileSafeName(pCurrentStockItem.StockItemID.ToString("00000")))

        mFileName &= IO.Path.GetExtension(vSourceFile)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)

        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vSourceFile, mFilePath, True)
        pCurrentStockItem.ImageFile = IO.Path.GetFileName(mFilePath)

        If pCurrentStockItem.ImageFile <> "" Then
          mRetVal = True

        Else

          pCurrentStockItem.ImageFile = ""
          mRetVal = False
        End If
      End If







    Catch ex As Exception


      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal
  End Function
  Public Sub LoadStockItemExtraDetails()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Try
      If pCurrentStockItem IsNot Nothing Then
        Dim mSI As dmStockItem
        mSI = pCurrentStockItem
        'mdsoStock.LoadStockItem(pCurrentStockItem, pCurrentStockItem.StockItemID)
        'mdsoStock.LoadStockItem(pCurrentStockItemOpposite, pCurrentStockItem.OppositeStockItemID)
        'mdsoStock.LoadStockItem(pInterdenStockItem, pCurrentStockItem.InterdenStockItemID)
        pCurrentStockItem.tmpIsFullyLoadedDown = True
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

  Public Sub SaveObject()
    Try

      If pCurrentStockItem IsNot Nothing Then
        Dim mdsoStock As New dsoStock(pDBConn)

        mdsoStock.SaveStockItem(pCurrentStockItem)
        If pSIGlobalRegistry.GetStockItemFromID(pCurrentStockItem.StockItemID) IsNot Nothing Then
          pSIGlobalRegistry.RefreshStockItem(pCurrentStockItem.StockItemID)
        Else
          pSIGlobalRegistry.LoadByID(pCurrentStockItem.StockItemID)
        End If
        mdsoStock = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Function AddStockItem(ByVal vClassType As Integer, ByVal vCategory As eStockItemCategory) As dmStockItem
    Dim mRetVal As dmStockItem = Nothing
    Dim mStockItem As dmStockItem
    Dim mProvisional As Boolean = False
    Try

      Select Case vClassType
        ''Case eStockType.Basic
        Case 1
          mStockItem = New dmStockItem '(mProvisional)
        Case Else
          mStockItem = New dmStockItem '(mProvisional)
      End Select

      ''mStockItem.ClassTypeID = CInt(vClassType)
      mStockItem.Category = vCategory
      ''mStockItem.tmpIsFullyLoadedDown = True
      pStockItems.Add(mStockItem)

      mRetVal = mStockItem
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  ''Public Function GetStockItemFixings() As colStockItems

  ''  pStockItemsPicker = New colStockItems
  ''  Dim mdsoStock As New dsoStock(pDBConn)

  ''  Try
  ''    mdsoStock.LoadStockItems(pStockItemsPicker, String.Format("Category = {0}", CInt(eStockItemCategory.Fixing)))
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  Finally
  ''    mdsoStock = Nothing
  ''  End Try


  ''  Return pStockItemsPicker
  ''End Function

  ''  Public Function GetStockItems() As colStockItems

  ''    pStockItemsPicker = New colStockItems
  ''    Dim mdsoStock As New dsoStock(pDBConn)

  ''      Try
  ''      mdsoStock.LoadStockItems(pStockItemsPicker, String.Format("Category = {0}", CInt(eStockItemCategory.Ironmongery)))
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''    Finally
  ''        mdsoStock = Nothing
  ''      End Try


  ''    Return pStockItemsPicker
  ''  End Function

  ''  Public Function MergeStockItems(ByVal vObsoleteItemID As Int32, ByVal vMergeItemID As Int32) As Boolean
  ''    Dim mOK As Boolean = True
  ''    Dim mParams As New Hashtable

  ''    If pDBConn.Connect Then
  ''      mParams.Add("@ObsoleteItemID", vObsoleteItemID)
  ''      mParams.Add("@MergeIntoID", vMergeItemID)

  ''      Dim mDR As IDataReader = pDBConn.LoadReaderSP("spMergeStockItem", mParams)

  ''      mDR.Close()
  ''      mDR = Nothing
  ''    End If

  ''    Return mOK
  ''  End Function

  ''  Public Function GetReleventCategories() As colValueItems
  ''    Dim mRetval As colValueItems
  ''    Dim mVI As clsValueItem
  ''    mRetval = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))

  ''    '// Change the None description to All for the drop down
  ''    mVI = mRetval.ItemValueToObject(eStockItemCategory.None)
  ''    mVI.DisplayValue = "All"

  ''    '// Remove the items that are not relevent
  ''    For mLoop As Integer = mRetval.Count - 1 To 0 Step -1
  ''      ''Select Case mRetval(mLoop).ItemValue
  ''      ''  Case eStockItemCategory.DoorLeaf, eStockItemCategory.FrameCompSet, eStockItemCategory.KittedItem, eStockItemCategory.LeafSetBespoke, eStockItemCategory.LeafSetProduct
  ''      ''    mRetval.RemoveAt(mLoop)
  ''      ''  Case Else
  ''      ''    Select Case pFormController.FormView
  ''      ''      Case eFormView.Ironmongery
  ''      ''        Select Case mRetval(mLoop).ItemValue
  ''      ''          Case eStockItemCategory.None, eStockItemCategory.Ironmongery, eStockItemCategory.IntumescentStripSeals
  ''      ''          Case Else
  ''      ''            mRetval.RemoveAt(mLoop)
  ''      ''        End Select
  ''      ''      Case eFormView.Other
  ''      ''      Case eFormView.Ironmongery
  ''      ''        Select Case mRetval(mLoop).ItemValue
  ''      ''          Case eStockItemCategory.Ironmongery, eStockItemCategory.IntumescentStripSeals
  ''      ''            mRetval.RemoveAt(mLoop)
  ''      ''        End Select
  ''      ''    End Select
  ''      ''End Select
  ''    Next

  ''    Return mRetval
  ''  End Function

  Public Function GetProposedCode()
    Dim mDSO As dsoStock
    Dim mStem As String
    Dim mThicknessDecimal As Decimal
    Dim mRetVal As String = ""
    Dim mThicknessInteger As Integer

    mStem = clsStockItemSharedFuncs.GetStockCodeStem_New(pCurrentStockItem, pDBConn)
    mDSO = New dsoStock(pDBConn)
    'If mStem <> "" Then

    '  If pCurrentStockItem.Category = eStockItemCategory.Timber Then
    '    mThicknessDecimal = pCurrentStockItem.Thickness ' mDSO.GetNextStockCodeSuffixNo(mStem)
    '    pCurrentStockItem.StockCode = mStem
    '    If mThicknessDecimal <> 0 Then
    '      mThicknessInteger = CInt(mThicknessDecimal)

    '      mThicknessDecimal = mThicknessDecimal - mThicknessInteger

    '      If mThicknessDecimal > 0 Then
    '        mThicknessDecimal = mThicknessDecimal * 10
    '        pCurrentStockItem.StockCode = mStem & "_" & mThicknessInteger.ToString() & "." & mThicknessDecimal.ToString("n0")

    '      Else
    '        pCurrentStockItem.StockCode = mStem & "_" & mThicknessInteger.ToString("n1")

    '      End If

    '    End If
    '  End If
    'End If
    Return mStem
  End Function

  Public Sub GenerateDescription()
    Dim mSIDM As StockItemDefManagerBase = Nothing
    SaveObject()

    Select Case pCurrentStockItem.Category
      Case eStockItemCategory.Fixings
        mSIDM = New clsStockItemDefManagerFixings(pCurrentStockItem)
    End Select
    If mSIDM IsNot Nothing Then
      pCurrentStockItem.Description = mSIDM.GenerateDescription()
    End If
  End Sub

End Class

