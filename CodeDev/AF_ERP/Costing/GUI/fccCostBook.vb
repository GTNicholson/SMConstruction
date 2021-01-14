Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccCostBook
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal


  Private pCostBookID As Integer
  Private pCostBook As dmCostBook
  Private pCostBookEntryEditors As colCostBookEntryEditors
  Private pCostBookEntrys As colCostBookEntrys
  Private pCostBookStockItemEntryCategorys As colCostBookEntrys
  Private pCostBookEntryEditorLeafSetProduct As colCostBookEntryEditors
  Private pCostBookDoorRangeEntrys As colCostBookEntrys
  Protected pIsLocked As Boolean
  Protected pFormMode As eFormMode


  Public Sub New(ByVal vDBConn As clsDBConnBase)

    pDBConn = vDBConn
    pRTISGlobal = AppRTISGlobal.GetInstance
    pCostBook = New dmCostBook
    pCostBookEntryEditors = New colCostBookEntryEditors
    pCostBookEntryEditorLeafSetProduct = New colCostBookEntryEditors
    pCostBookEntrys = New colCostBookEntrys
    pCostBookStockItemEntryCategorys = New colCostBookEntrys
    pCostBookDoorRangeEntrys = New colCostBookEntrys
    pIsLocked = False
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public ReadOnly Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property
  Public ReadOnly Property IsEditable As Boolean
    Get
      Return pFormMode <> eFormMode.eFMFormModeView AndAlso pIsLocked OrElse pFormMode = eFormMode.eFMFormModeAdd
    End Get
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


  Public Property CostBookDoorRangeEntrys As colCostBookEntrys
    Get
      Return pCostBookDoorRangeEntrys
    End Get
    Set(value As colCostBookEntrys)
      pCostBookDoorRangeEntrys = value
    End Set
  End Property

  Public Property CostBookID As Integer
    Get
      Return pCostBookID
    End Get
    Set(value As Integer)
      pCostBookID = value
    End Set
  End Property

  Public Property CostBookEntryEditors As colCostBookEntryEditors
    Get
      Return pCostBookEntryEditors
    End Get
    Set(value As colCostBookEntryEditors)
      pCostBookEntryEditors = value
    End Set
  End Property



  Public Property CostBookEntryEditorsLeafCategory As colCostBookEntryEditors
    Get
      Return pCostBookEntryEditorLeafSetProduct
    End Get
    Set(value As colCostBookEntryEditors)
      pCostBookEntryEditorLeafSetProduct = value
    End Set
  End Property

  Public Property CostBookEntrys As colCostBookEntrys
    Get
      Return pCostBookEntrys
    End Get
    Set(value As colCostBookEntrys)
      pCostBookEntrys = value
    End Set
  End Property

  Public Property CostBookStockItemEntryCategorys As colCostBookEntrys
    Get
      Return pCostBookStockItemEntryCategorys
    End Get
    Set(value As colCostBookEntrys)
      pCostBookStockItemEntryCategorys = value
    End Set
  End Property

  Public Function LockOrder() As Boolean

    Try
      Dim mdsoSalesOrder As New dsoSales(pDBConn)

      pIsLocked = mdsoSalesOrder.LockCostBook(pCostBookID)

      mdsoSalesOrder = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return pIsLocked
  End Function

  Public Property CostBook As dmCostBook
    Get
      Return pCostBook
    End Get
    Set(value As dmCostBook)
      pCostBook = value
    End Set
  End Property



  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean


    If mIsDirty = False Then mIsDirty = pCostBookEntrys.IsDirty


    Return mIsDirty
  End Function


  Public Function LoadObject() As Boolean

    Dim mOK As Boolean = True
    Dim mdso As dsoSales

    If pDBConn.Connect Then

      If pCostBookID = 0 Then

        SaveCostBook()
        pCostBookID = pCostBook.CostBookID
      Else
        mdso = New dsoSales(pDBConn)
        pIsLocked = mdso.LockCostBook(pCostBookID)
      End If
      LoadCostBookAndCostBookEntry()

    End If

    Return mOK
  End Function



  Public Sub LoadCostBookAndCostBookEntry()
    Dim mDSO As New dsoCostBook(pDBConn)
    mDSO.LoadCostBook(pCostBook, pCostBookID)
    mDSO.LoadCostBookEntry(pCostBookEntrys, pCostBookID)
  End Sub

  Public Function SaveObject() As Boolean
    Dim mdso As New dsoCostBook(pDBConn)
    Dim mOK As Boolean = False

    Dim mdsoSalesOrder As New dsoSales(DBConn)


    Try

      If pCostBook IsNot Nothing Then

        If pDBConn.Connect Then



          mOK = SaveCostBook()

          mOK = SaveCostBookEntry()


        End If


        If pCostBookID = 0 Then
          pCostBookID = pCostBook.CostBookID

          If Not pIsLocked Then
            pIsLocked = mdsoSalesOrder.LockCostBook(pCostBookID)
          End If

        End If
      Else
        mOK = True
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoSalesOrder = Nothing
    End Try

    Return mOK

    Return mOK


  End Function

  Public Function SaveCostBookEntry() As Boolean

    Dim mOK As Boolean = False
    Dim mdso As New dsoCostBook(pDBConn)

    If pCostBookEntrys IsNot Nothing Then
      mOK = mdso.SaveCostBookEntryCollection(pCostBookEntrys, pCostBookID)

    End If
    Return mOK
  End Function

  Public Function SaveCostBook() As Boolean
    Dim mOK As Boolean = False
    Dim mdso As New dsoCostBook(pDBConn)

    If pCostBook IsNot Nothing Then
      mOK = mdso.saveCostBook(pCostBook)
    End If

    Return mOK
  End Function

  Public Sub ChangeDataValue(ByVal e As DevExpress.XtraPivotGrid.EditValueChangedEventArgs)
    'Dim mRows As Data.DataRow()
    Dim mFilter As String = ""
    Dim mValue As Decimal?
    Dim mDS As DevExpress.XtraPivotGrid.PivotDrillDownDataSource

    Try
      If e.Editor.EditValue = "" Then
        mValue = Nothing
        mDS = e.CreateDrillDownDataSource()
        If mDS.RowCount = 1 Then
          mDS.SetValue(CInt(0), e.DataField, Nothing)
        End If
      Else
        mValue = CType(e.Editor.EditValue, Decimal)
        mDS = e.CreateDrillDownDataSource()
        If mDS.RowCount = 1 Then
          mDS.SetValue(CInt(0), e.DataField, CDbl(mValue))
        End If
      End If


      'ChangeDataValue(mFilter, e.DataField.FieldName, mValue)
      'pgrdMatrix.Update()

    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Public Sub ClearObjects()
    If pIsLocked And pCostBookID > 0 Then
      Dim mdsoSalesOrder As New dsoSales(pDBConn)
      mdsoSalesOrder.UnlockCostBook(pCostBookID)
    End If
    pCostBook = Nothing
  End Sub


  Public Sub LoadStockItems(ByRef rStockItems As colStockItems, ByVal vItemType As Integer)
    Dim dsoStock As New dsoStock(DBConn)

    Dim mstr As String = "category = " & eStockItemCategory.Timber & "and ItemType = " & vItemType.ToString


    dsoStock.LoadstockItemsByCategory(rStockItems, mstr)



  End Sub




  Public Sub RefreshStockItemColecctions(ByVal vItemType As Integer)

    Dim mStockItems As New colStockItems
    Dim mStockItemLeafCategory As New colStockItems
    Dim mCostBookEntry As dmCostBookEntry
    Dim mSI As dmStockItem
    Dim mCBEditor As clsCostBookEntryEditor
    Dim mCBEIndex As Integer
    ''  pCostBookEntrys = New colCostBookEntrys
    LoadStockItems(mStockItems, vItemType)


    pCostBookEntryEditors.Clear()

    For Each mSI In mStockItems

      mCBEIndex = pCostBookEntrys.IndexFromStockItemID(mSI.StockItemID)
      If mCBEIndex = -1 Then
        '// If this stock item is not part of the Cost Book Entry collection create it
        mCostBookEntry = New dmCostBookEntry
        mCostBookEntry.StockItemID = mSI.StockItemID
        mCostBookEntry.CostBookID = CostBookID

        pCostBookEntrys.Add(mCostBookEntry)
      Else
        mCostBookEntry = pCostBookEntrys(mCBEIndex)
      End If

      '// Create a new editor for each of the current stock items
      mCBEditor = New clsCostBookEntryEditor
      mCBEditor.CostBookEntry = mCostBookEntry

      mCBEditor.StockItem = mSI
      pCostBookEntryEditors.Add(mCBEditor)

    Next



  End Sub

  Public Sub RefreshStockItemCategoryColecctions()


    Dim mStockItemLeafCategory As New colStockItems
    Dim mCostBookEntry As dmCostBookEntry

    LoadStockItems(mStockItemLeafCategory, True)

    For Each mSI As dmStockItem In mStockItemLeafCategory


      If CostBookStockItemEntryCategorys.IndexFromStockItemID(mSI.StockItemID) = -1 Then
        mCostBookEntry = New dmCostBookEntry
        mCostBookEntry.StockItemID = mSI.StockItemID
        mCostBookEntry.CostBookID = CostBookID

        CostBookStockItemEntryCategorys.Add(mCostBookEntry)
      End If
    Next

    pCostBookEntryEditorLeafSetProduct.Clear()

    For Each mCBE In pCostBookStockItemEntryCategorys
      Dim mCBEditor As New clsCostBookEntryEditor

      mCBEditor.CostBookEntry = mCBE

      mCBEditor.StockItem = mStockItemLeafCategory.ItemFromKey(mCBE.StockItemID)
      pCostBookEntryEditorLeafSetProduct.Add(mCBEditor)
    Next


  End Sub


End Class
