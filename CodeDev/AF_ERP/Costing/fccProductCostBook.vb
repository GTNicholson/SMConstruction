Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccProductCostBook
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pCostBookID As Integer
  Private pProductCostBook As dmProductCostBook
  Private pProductInstallationCostBookEntryEditors As colProductCostBookEntryEditors
  Private pProductStructureCostBookEntryEditors As colProductCostBookEntryEditors
  Private pInstallationProductCostBookEntrys As colProductCostBookEntrys
  Private pStructureProductCostBookEntrys As colProductCostBookEntrys
  Protected pIsLocked As Boolean
  Protected pFormMode As eFormMode

  Public Sub New(ByVal vDBConn As clsDBConnBase)

    pDBConn = vDBConn
    pRTISGlobal = AppRTISGlobal.GetInstance
    pProductCostBook = New dmProductCostBook
    pProductInstallationCostBookEntryEditors = New colProductCostBookEntryEditors
    pProductStructureCostBookEntryEditors = New colProductCostBookEntryEditors
    pInstallationProductCostBookEntrys = New colProductCostBookEntrys
    pStructureProductCostBookEntrys = New colProductCostBookEntrys
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


  Public Property ProductCostBookID As Integer
    Get
      Return pCostBookID
    End Get
    Set(value As Integer)
      pCostBookID = value
    End Set
  End Property

  Public Property ProductInstallationCostBookEntryEditors As colProductCostBookEntryEditors
    Get
      Return pProductInstallationCostBookEntryEditors
    End Get
    Set(value As colProductCostBookEntryEditors)
      pProductInstallationCostBookEntryEditors = value
    End Set
  End Property
  Public Property ProductStructureCostBookEntryEditors As colProductCostBookEntryEditors
    Get
      Return pProductStructureCostBookEntryEditors
    End Get
    Set(value As colProductCostBookEntryEditors)
      pProductStructureCostBookEntryEditors = value
    End Set
  End Property


  Public Property InstallationProductCostBookEntrys As colProductCostBookEntrys
    Get
      Return pInstallationProductCostBookEntrys
    End Get
    Set(value As colProductCostBookEntrys)
      pInstallationProductCostBookEntrys = value
    End Set
  End Property

  Public Property StructureProductCostBookEntrys As colProductCostBookEntrys
    Get
      Return pStructureProductCostBookEntrys
    End Get
    Set(value As colProductCostBookEntrys)
      pStructureProductCostBookEntrys = value
    End Set
  End Property

  Public Function LockOrder() As Boolean

    Try


      Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)

      pIsLocked = mdsoSalesOrder.LockFromTableRecord("ProductCostBook", pCostBookID)

      mdsoSalesOrder = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return pIsLocked
  End Function

  Public Property ProductCostBook As dmProductCostBook
    Get
      Return pProductCostBook
    End Get
    Set(value As dmProductCostBook)
      pProductCostBook = value
    End Set
  End Property



  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean

    If mIsDirty = False Then mIsDirty = pInstallationProductCostBookEntrys.IsDirty
    If mIsDirty = False Then mIsDirty = pStructureProductCostBookEntrys.IsDirty
    If pProductCostBook IsNot Nothing Then
      If mIsDirty = False Then mIsDirty = pProductCostBook.IsDirty

    End If


    Return mIsDirty
  End Function


  Public Function LoadObject() As Boolean

    Dim mOK As Boolean = True
    Dim mdso As dsoSalesOrder

    If pDBConn.Connect Then

      If pCostBookID = 0 Then

        SaveProductCostBook()
        pCostBookID = pProductCostBook.ProductCostBookID
      Else
        mdso = New dsoSalesOrder(pDBConn)
        pIsLocked = mdso.LockTableRecord("ProductCostBook", pCostBookID)
      End If
      LoadCostBookAndCostBookEntry()
      RefreshProductColecctions()
    End If

    Return mOK
  End Function



  Public Sub LoadCostBookAndCostBookEntry()
    Dim mDSO As New dsoSalesOrder(pDBConn)
    mDSO.LoadProductCostBook(pProductCostBook, pCostBookID)
    mDSO.LoadProductCostBookEntry(pInstallationProductCostBookEntrys, pCostBookID)
    mDSO.LoadProductCostBookEntry(pStructureProductCostBookEntrys, pCostBookID)
  End Sub

  Public Function SaveObject() As Boolean
    Dim mdso As New dsoSalesOrder(pDBConn)
    Dim mOK As Boolean = False

    Dim mdsoSalesOrder As New dsoSalesOrder(DBConn)


    Try

      If pProductCostBook IsNot Nothing Then

        If pDBConn.Connect Then

          mOK = SaveProductCostBook()

          mOK = SaveProductCostBookEntry()

        End If


        If pCostBookID = 0 Then
          pCostBookID = pProductCostBook.ProductCostBookID

          If Not pIsLocked Then
            pIsLocked = mdsoSalesOrder.LockTableRecord("ProductCostBook", pCostBookID)
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

  Public Function SaveProductCostBookEntry() As Boolean

    Dim mOK As Boolean = False
    Dim mdso As New dsoSalesOrder(pDBConn)

    If pInstallationProductCostBookEntrys IsNot Nothing Then
      mOK = mdso.SaveProductCostBookEntryCollection(pInstallationProductCostBookEntrys, pCostBookID)

    End If

    If pStructureProductCostBookEntrys IsNot Nothing Then
      mOK = mdso.SaveProductCostBookEntryCollection(pStructureProductCostBookEntrys, pCostBookID)

    End If

    Return mOK
  End Function

  Public Function SaveProductCostBook() As Boolean
    Dim mOK As Boolean = False
    Dim mdso As New dsoSalesOrder(pDBConn)

    If pProductCostBook IsNot Nothing Then
      mOK = mdso.SaveProductCostBook(pProductCostBook)
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


    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Public Sub ClearObjects()
    If pIsLocked And pCostBookID > 0 Then
      Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
      mdsoSalesOrder.UnlockProductCostBook("ProductCostBook", pCostBookID)
    End If
    pProductCostBook = Nothing
  End Sub


  Public Sub LoadProductInstallations(ByRef rProductBases As colProductBases)

    Dim dso As New dsoProductAdmin(pDBConn)

    dso.LoadProductInstallations(rProductBases)


  End Sub

  Public Sub LoadProductStructures(ByRef rProductBases As colProductBases)

    Dim dso As New dsoProductAdmin(pDBConn)

    dso.LoadProductStructures(rProductBases)


  End Sub


  Public Sub RefreshProductColecctions()

    Dim mProductInstallations As New colProductBases
    Dim mProductStructures As New colProductBases

    Dim mProductCostBookEntry As dmProductCostBookEntry
    Dim mProductBase As dmProductBase
    Dim mCBEditor As clsProductCostBookEntryEditor
    Dim mCBEIndex As Integer

    LoadProductInstallations(mProductInstallations)
    LoadProductStructures(mProductStructures)

    pProductInstallationCostBookEntryEditors.Clear()
    pProductStructureCostBookEntryEditors.Clear()


    For Each mProductBase In mProductInstallations

      mCBEIndex = pInstallationProductCostBookEntrys.IndexFromProductID_ItemTypeID(mProductBase.ID, mProductBase.ProductTypeID)
      If mCBEIndex = -1 Then
        '// If this stock item is not part of the Cost Book Entry collection create it
        mProductCostBookEntry = New dmProductCostBookEntry
        mProductCostBookEntry.ProductID = mProductBase.ID
        mProductCostBookEntry.CostBookID = ProductCostBookID
        mProductCostBookEntry.ProductTypeID = mProductBase.ProductTypeID

        pInstallationProductCostBookEntrys.Add(mProductCostBookEntry)
      Else
        mProductCostBookEntry = pInstallationProductCostBookEntrys(mCBEIndex)
      End If

      '// Create a new editor for each of the current stock items
      mCBEditor = New clsProductCostBookEntryEditor
      mCBEditor.ProductCostBookEntry = mProductCostBookEntry

      mCBEditor.ProductBase = mProductBase
      pProductInstallationCostBookEntryEditors.Add(mCBEditor)

    Next

    mProductBase = Nothing
    For Each mProductBase In mProductStructures

      mCBEIndex = pStructureProductCostBookEntrys.IndexFromProductID_ItemTypeID(mProductBase.ID, mProductBase.ProductTypeID)
      If mCBEIndex = -1 Then
        '// If this stock item is not part of the Cost Book Entry collection create it
        mProductCostBookEntry = New dmProductCostBookEntry
        mProductCostBookEntry.ProductID = mProductBase.ID
        mProductCostBookEntry.CostBookID = ProductCostBookID
        mProductCostBookEntry.ProductTypeID = mProductBase.ProductTypeID
        pStructureProductCostBookEntrys.Add(mProductCostBookEntry)
      Else
        mProductCostBookEntry = pStructureProductCostBookEntrys(mCBEIndex)
      End If

      '// Create a new editor for each of the current stock items
      mCBEditor = New clsProductCostBookEntryEditor
      mCBEditor.ProductCostBookEntry = mProductCostBookEntry

      mCBEditor.ProductBase = mProductBase
      pProductStructureCostBookEntryEditors.Add(mCBEditor)

    Next

  End Sub




End Class
