Imports RTIS.CommonVB

Public Class fccStockItemInfos
  Private pPrimaryKeyID As Integer

  Private pStockItemInfos As colStockItemInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pCategorys As Int32
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentStockItem As dmStockItem
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pStockItemInfos = New colStockItemInfos
    pRTISGlobal = rRTISGlobal

  End Sub

  Public Property CurrentStockItem As dmStockItem
    Get
      Return pCurrentStockItem
    End Get
    Set(value As dmStockItem)
      pCurrentStockItem = value
    End Set
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property


  Public ReadOnly Property StockItemInfos As colStockItemInfos
    Get
      Return pStockItemInfos
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoStock

    pStockItemInfos.Clear()


    mdso = New dsoStock(pDBConn)
    mdso.LoadStockItemInfos(pStockItemInfos, "")


  End Sub


  Public Sub LoadStockItemExtraDetails()
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""
    Try
      If pCurrentStockItem IsNot Nothing Then
        Dim mSI As dmStockItem
        mSI = pCurrentStockItem
        mdsoStock.LoadStockItem(pCurrentStockItem, pCurrentStockItem.StockItemID)
        pCurrentStockItem.tmpIsFullyLoadedDown = True
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

End Class
