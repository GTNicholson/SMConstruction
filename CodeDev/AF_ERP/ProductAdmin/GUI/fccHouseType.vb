Imports RTIS.CommonVB

Public Class fccHouseType
  Private pPrimaryKeyID As Integer

  Private pHouseType As dmHouseType
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pHaveLock As Boolean
  Private pCurrentHouseTypeAssembly As dmSalesItemAssembly
  Private pHouseTypeManager As clsHouseTypeManager

  Private pProducts As colProductBases

  Private pCurrentHTSalesItemInfos As colHouseTypeSalesItemInfos
  Private pPrevtHTSalesItemInfos As colHouseTypeSalesItemInfos

  Private pProductCostBook As dmProductCostBook

  Private pProductCostBookID As Integer

  Private pProductCostSummaryInfos As colProductCostSummaryInfos
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pProducts = New colProductBases
    pPrevtHTSalesItemInfos = New colHouseTypeSalesItemInfos
    pProductCostBook = New dmProductCostBook
    pProductCostSummaryInfos = New colProductCostSummaryInfos
  End Sub


  Public Property ProductCostBookID As Integer
    Get
      Return pProductCostBookID
    End Get
    Set(value As Integer)
      pProductCostBookID = value
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

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
  End Property

  Public Property ProductCostBook As dmProductCostBook
    Get
      Return pProductCostBook
    End Get
    Set(value As dmProductCostBook)
      pProductCostBook = value
    End Set
  End Property


  Public ReadOnly Property HaveLock As Boolean
    Get
      Return pHaveLock
    End Get
  End Property

  Public Property ProductCostSummaryInfo As colProductCostSummaryInfos
    Get
      Return pProductCostSummaryInfos
    End Get
    Set(value As colProductCostSummaryInfos)
      pProductCostSummaryInfos = value
    End Set
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoProductAdmin


    pHouseType = New dmHouseType

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoProductAdmin(pDBConn)

      pHaveLock = mdso.LockHouseTypeDisconnected(pPrimaryKeyID)

      mdso.LoadHouseTypeDown(pHouseType, pPrimaryKeyID)

    End If
    pHouseTypeManager = New clsHouseTypeManager(pHouseType, DBConn)


  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoProductAdmin
    mdso = New dsoProductAdmin(pDBConn)

    mdso.SaveHouseTypeDown(pHouseType)

    If pPrimaryKeyID = 0 Then
      pPrimaryKeyID = pHouseType.HouseTypeID
      pHaveLock = mdso.LockHouseTypeDisconnected(Me.PrimaryKeyID)
    End If

  End Sub
  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pHouseType.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()
    ClearLocks()

    'Me.MainObject = Nothing

  End Sub

  Private Function ClearLocks() As Boolean
    Dim mdso As dsoSalesOrder = Nothing

    Dim mOK As Boolean = True

    Try
      If pHaveLock Then
        mdso = New dsoSalesOrder(pDBConn)
        mOK = mdso.UnlockCustomerDisconnected(Me.PrimaryKeyID)
      Else
        mOK = True
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdso = Nothing
    End Try

    Return mOK
  End Function

  Public ReadOnly Property Products As colProductBases
    Get
      Return pProducts
    End Get
  End Property

  Public ReadOnly Property CurrentHTSalesItemInfos As colHouseTypeSalesItemInfos
    Get
      Return pCurrentHTSalesItemInfos
    End Get
  End Property

  Public Property PrevtHTSalesItemInfos As colHouseTypeSalesItemInfos
    Get
      Return pPrevtHTSalesItemInfos
    End Get
    Set(value As colHouseTypeSalesItemInfos)
      pPrevtHTSalesItemInfos = value
    End Set
  End Property

  Public ReadOnly Property CurrentHouseTypeAssembly As dmSalesItemAssembly
    Get
      Return pCurrentHouseTypeAssembly
    End Get
  End Property

  Public Sub SetCurrentHouseTypeAssembly(ByRef rHouseTypeAssembly As dmSalesItemAssembly)
    pCurrentHouseTypeAssembly = rHouseTypeAssembly
    pCurrentHTSalesItemInfos = pHouseTypeManager.GetHTItemInfosForAssembly(rHouseTypeAssembly, pProducts)
  End Sub

  Public Sub AddAssembly()
    pHouseTypeManager.AddSalesItemAssembly()
    SetCurrentHouseTypeAssembly(pHouseType.SalesItemAssemblys.Last)

  End Sub

  Public Sub DeleteAssembly(ByRef rHouseTypeAssembly As dmSalesItemAssembly)
    Dim mPos As Integer
    Dim mNewPos As Integer = -1
    If rHouseTypeAssembly IsNot Nothing Then
      'Find the position of the item we are going to delete
      mPos = 0
      For Each mHTA As dmSalesItemAssembly In pHouseType.SalesItemAssemblys
        If mHTA Is rHouseTypeAssembly Then
          mNewPos = mPos 'This will be the next one in the list a we will take out this position
          Exit For
        End If
        mPos += 1
      Next

      pHouseTypeManager.DeleteSalesItemAssembly(rHouseTypeAssembly)

      If pHouseType.SalesItemAssemblys.Count = 0 Then
        SetCurrentHouseTypeAssembly(Nothing)
      ElseIf mNewPos <= pHouseType.SalesItemAssemblys.Count - 1 Then
        SetCurrentHouseTypeAssembly(pHouseType.SalesItemAssemblys(mNewPos))
      Else
        SetCurrentHouseTypeAssembly(pHouseType.SalesItemAssemblys.Last)
      End If
    End If
  End Sub

  Public Sub LoadProducts()
    Dim mdso As New dsoSalesOrder(DBConn)
    pProducts = New colProductBases
    mdso.LoadStandardProducts(pProducts)

  End Sub

  Public Sub AddProducts(ByRef rProducts As List(Of clsProductBaseInfo))

    pHouseTypeManager.AddProducts(pCurrentHouseTypeAssembly, rProducts, pProductCostBook)
    pCurrentHTSalesItemInfos = pHouseTypeManager.GetHTItemInfosForAssembly(pCurrentHouseTypeAssembly, pProducts)

  End Sub

  Public Sub SetPrevHTSalesItemInfos(ByVal vProductCostBookID As Integer)
    Dim mRetVal As New colHouseTypeSalesItemInfos
    Dim mProductCost As New dmProductCostBook
    Dim mdso As New dsoProductAdmin(DBConn)

    mdso.LoadProductCostDown(mProductCost, vProductCostBookID)

    If mProductCost IsNot Nothing Then
      pPrevtHTSalesItemInfos = pHouseTypeManager.GetTotalHTSalesItemInfos(pProducts, mProductCost.ProductCostBookEntrys)

    End If
  End Sub

  Public Function GetProductInfos() As colProductBaseInfos
    Dim mRetVal As New colProductBaseInfos
    Dim mdso As New dsoProductAdmin(DBConn)
    Dim mWhere As String

    mWhere = "Status <> " & CInt(eProductStatus.Obsolete)
    mdso.LoadProductInfosByWhere(mRetVal, "")
    Return mRetVal
  End Function

  Friend Sub DeleteHTSalesItemInfo(ByRef rHTSalesItemInfo As clsHouseTypeSalesItemInfo)
    Try
      If pHouseType.HTSalesItems IsNot Nothing And pHouseType.HTSalesItems.Count > 0 Then
        pHouseTypeManager.RemoveHTSalesOrderItem(rHTSalesItemInfo)
        pHouseType.HTSalesItems.Remove(rHTSalesItemInfo.HouseTypeSalesItem)
        pPrevtHTSalesItemInfos.Remove(rHTSalesItemInfo)
        pCurrentHTSalesItemInfos = pHouseTypeManager.GetHTItemInfosForAssembly(pCurrentHouseTypeAssembly, pProducts)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub RefreshHTSalesItems()

  End Sub

  Public Sub LoadProductCostBookDown(ByVal vProductCostBookID As Integer)
    Dim mdso As New dsoProductAdmin(DBConn)

    mdso.LoadProductCostDown(pProductCostBook, vProductCostBookID)


  End Sub

  Public Sub RefreshProductCostSummaryInfo(ByRef rPrevtHTSalesItemInfos As colHouseTypeSalesItemInfos)
    pProductCostSummaryInfos.Clear()
    Dim mProductCostSummaryInfo = New clsProductCostSummaryInfo(rPrevtHTSalesItemInfos)
    mProductCostSummaryInfo.UpdateTotalLabourCost()

    pProductCostSummaryInfos.Add(mProductCostSummaryInfo)
  End Sub

  Public Sub OrderPrevHTSalesItemInfos()
    Dim mProductTypes As New colProductConstructionTypes
    Dim mProductSubTypes As New colProductConstructionSubTypes

    mProductTypes = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes)
    mProductSubTypes = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.ProductConstructionSubType), colProductConstructionSubTypes)


    For Each mPrevHTSalesItemInfo As clsHouseTypeSalesItemInfo In PrevtHTSalesItemInfos
      Dim mstring As String = mProductTypes.ItemFromKey(mPrevHTSalesItemInfo.ItemType).SequenceNo & "." & mProductSubTypes.ItemFromKey(mPrevHTSalesItemInfo.SubItemType).SequenceNo
      mPrevHTSalesItemInfo.ItemNumber = mstring

    Next

  End Sub
End Class
