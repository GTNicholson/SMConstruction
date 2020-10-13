Imports RTIS.CommonVB

Public Class fccHouseType
  Private pPrimaryKeyID As Integer

  Private pHouseType As dmHouseType
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pHaveLock As Boolean
  Private pCurrentHouseTypeAssembly As dmSalesItemAssembly
  Private pHouseTypeManager As clsHouseTypeManager

  Private pProducts As colProductBases

  Private pCurrentHTSalesItemInfos As colHouseTypeSalesItemInfos
  Private pPrevtHTSalesItemInfos As colHouseTypeSalesItemInfos
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pProducts = New colProductBases
    pPrevtHTSalesItemInfos = New colHouseTypeSalesItemInfos
  End Sub

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

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
  End Property

  Public ReadOnly Property HaveLock As Boolean
    Get
      Return pHaveLock
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoProductAdmin

    pHouseType = New dmHouseType

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoProductAdmin(pDBConn)

      pHaveLock = mdso.LockHouseTypeDisconnected(pPrimaryKeyID)

      mdso.LoadHouseTypeDown(pHouseType, pPrimaryKeyID)
    End If
    pHouseTypeManager = New clsHouseTypeManager(pHouseType)


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
    Dim mdso As dsoSales = Nothing

    Dim mOK As Boolean = True

    Try
      If pHaveLock Then
        mdso = New dsoSales(pDBConn)
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
    Dim mdso As New dsoSales(DBConn)
    pProducts = New colProductBases
    mdso.LoadStandardProducts(pProducts)

  End Sub

  Public Sub AddProducts(ByRef rProducts As List(Of dmProductBase))

    pHouseTypeManager.AddProducts(pCurrentHouseTypeAssembly, rProducts)
    pCurrentHTSalesItemInfos = pHouseTypeManager.GetHTItemInfosForAssembly(pCurrentHouseTypeAssembly, pProducts)

  End Sub

  Public Sub SetPrevlHTSalesItemInfos()
    Dim mRetVal As New colHouseTypeSalesItemInfos
    pPrevtHTSalesItemInfos = pHouseTypeManager.GetTotalHTSalesItemInfos(pProducts)


  End Sub

End Class
