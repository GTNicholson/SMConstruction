Imports RTIS.DataLayer

Public Class uccProductBaseDetail
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentProductInfo As clsProductBaseInfo
  Private pProductBOMInfos As colProductBOMInfos

  Public Sub New()
    pCurrentProductInfo = New clsProductBaseInfo
    pProductBOMInfos = New colProductBOMInfos
  End Sub
  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
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

  Public Property CurrentProductInfo() As clsProductBaseInfo
    Get
      Return pCurrentProductInfo
    End Get
    Set(value As clsProductBaseInfo)
      pCurrentProductInfo = value
    End Set
  End Property

  Public Property ProductBOMInfos As colProductBOMInfos
    Get
      Return pProductBOMInfos
    End Get
    Set(value As colProductBOMInfos)
      pProductBOMInfos = value
    End Set
  End Property
  Public Sub RefreshStockItemBOMs(ByRef rStockItems As List(Of dmStockItem))
    Dim mStockItemBOM As dmStockItemBOM
    Dim mProduct As dmProductBase
    Dim mFound As Boolean

    mProduct = pCurrentProductInfo.Product

    For Each mSI As dmStockItem In rStockItems
      If mProduct.StockItemBOMs.IndexFromStockItemID(mSI.StockItemID) = -1 Then
        mStockItemBOM = New dmStockItemBOM

        mStockItemBOM.ProductID = pCurrentProductInfo.Product.ID
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

  Public Function SetProductBase(ByRef rProductBase) As Boolean

    Dim mRetVal As Boolean = False
    rProductBase = pCurrentProductInfo.Product

    If rProductBase IsNot Nothing Then

      mRetVal = True
    End If

    Return mRetVal
  End Function

  Public Function CheckCreateStockCodeSave() As Boolean
    Dim mRetval As Boolean
    Dim mProposedCode As String
    If pCurrentProductInfo.Product.Code = "" Then
      mProposedCode = GetProposedCode()

      If mProposedCode <> "" Then
        If MsgBox("¿Crear el código de producto : " & mProposedCode & "?", vbYesNo) = vbYes Then
          pCurrentProductInfo.Product.Code = mProposedCode
        End If
      End If
    End If
    Return mRetval
  End Function

  Public Function GetProposedCode()
    Dim mDSO As dsoProductAdmin
    Dim mStem As String
    Dim mSuffix As Integer
    Dim mRetVal As String = ""

    mStem = clsProductSharedFuncs.GetProductCode(pCurrentProductInfo.Product)
    mDSO = New dsoProductAdmin(pDBConn)
    If mStem <> "" Then
      mSuffix = mDSO.GetNextProductConstructionCodeNo(mStem, pCurrentProductInfo.Product.ProductTypeID)

      mRetVal = mStem & mSuffix.ToString("000")
    End If
    Return mRetVal
  End Function

  Public Sub LoadProductBOMInfos(ByRef rProductBOMInfos As colProductBOMInfos, ByVal vParentID As Integer)
    Dim mdso As New dsoProductAdmin(pDBConn)
    Dim mWhere As String
    mWhere = "ParentID =" & vParentID
    rProductBOMInfos.Clear()
    mdso.LoadProductBOMS(rProductBOMInfos, mWhere)

  End Sub
End Class
