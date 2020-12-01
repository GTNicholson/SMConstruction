Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.IO

Public Class fccWoodPallet

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPrimaryKeyID As Integer
  Private pWoodPallets As colWoodPallets
  Private pCurrentWoodPallet As dmWoodPallet
  Private pCurrentWoodPalletOrig As dmWoodPallet
  Private pShowItemsMode As Integer
  Private pCurreStockItemList As colStockItems
  Private pWoodPalletItemEditors As colWoodPalletItemEditors



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

  Public ReadOnly Property WoodPallets As colWoodPallets
    Get
      Return pWoodPallets
    End Get
  End Property

  Public Property CurrentWoodPallet As dmWoodPallet
    Get
      Return pCurrentWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentWoodPallet = value
    End Set
  End Property

  Public Property CurreStockItemList As colStockItems
    Get
      Return pCurreStockItemList
    End Get
    Set(value As colStockItems)
      pCurreStockItemList = value
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

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pWoodPallets = New colWoodPallets
    pCurrentWoodPallet = New dmWoodPallet
    pCurrentWoodPalletOrig = New dmWoodPallet
    pCurreStockItemList = New colStockItems
    pShowItemsMode = eShowItems.ShowLive
  End Sub

  Public Function AddWoodPallet() As dmWoodPallet
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWoodPallet As dmWoodPallet

    Try

      mWoodPallet = New dmWoodPallet
      GetNextWoodPalletRef(mWoodPallet)
      mWoodPallet.CreatedDate = Now
      pWoodPallets.Add(mWoodPallet)

      mRetVal = mWoodPallet
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function
  Public Sub GetNextWoodPalletRef(ByRef rWoodPallet As dmWoodPallet)
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    rWoodPallet.PalletRef = "BLT-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("00000")
  End Sub

  Public Sub LoadWoodPalletDetail()
    Dim mdsoStock As New dsoStock(pDBConn)
    Try
      If pCurrentWoodPallet IsNot Nothing Then
        pCurrentWoodPallet.tmpIsFullyLoadedDown = True
        pCurrentWoodPalletOrig = pCurrentWoodPallet.Clone
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try

  End Sub

  Public Sub SaveObject()
    Dim mAdjustments As Dictionary(Of Integer, Decimal)
    Try

      If pCurrentWoodPallet IsNot Nothing Then
        Dim mdsoStock As New dsoStock(pDBConn)

        mdsoStock.SaveWoodPalletDown(pCurrentWoodPallet)

        '// Create Adjustment transactions
        mAdjustments = GetStockItemLocationChange()

        '// Remember not to create a transaction for the list when the value is 0
        For Each mKVP As KeyValuePair(Of Integer, Decimal) In mAdjustments
          If mKVP.Value <> 0 Then
            ''mStockItemID = mKVP.Key
          End If
        Next

        mdsoStock = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub LoadObject()
    Dim mdsoStock As New dsoStock(pDBConn)

    Dim mCatString As String = ""
    Try
      pWoodPallets = New colWoodPallets

      If pShowItemsMode = eShowItems.ShowLive Then
        ' mWhere = mWhere & " And (Inactive = 0 Or Inactive Is Null) "
      ElseIf pShowItemsMode = eShowItems.ShowObsolete Then
        'mWhere = mWhere & " And (Inactive = 1) "
      End If
      mdsoStock.LoadWoodPalletDownByWhere(pWoodPallets, "")

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      mdsoStock = Nothing
    End Try
  End Sub

  Public Sub SetCurrentStockItemCollection()
    Dim mdso As New dsoStock(pDBConn)

    ' For Each mWoodPalletItem As dmWoodPalletItem In pCurrentWoodPallet.sto


  End Sub

  Public Function AddWoodPalletItem(ByRef rWoodPallet As dmWoodPallet) As dmWoodPalletItem
    Dim mRetVal As New dmWoodPalletItem

    With mRetVal
      .WoodPalletID = rWoodPallet.WoodPalletID

    End With

    rWoodPallet.WoodPalletItems.Add(mRetVal)
    Return mRetVal
  End Function

  Public Property WoodPalletItemEditors As colWoodPalletItemEditors
    Get
      Return pWoodPalletItemEditors
    End Get
    Set(value As colWoodPalletItemEditors)
      pWoodPalletItemEditors = value
    End Set
  End Property

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pCurrentWoodPallet.IsAnyDirty
    Return mIsDirty
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function GetStockItemLocationChange() As Dictionary(Of Integer, Decimal)
    Dim mRetVal As New Dictionary(Of Integer, Decimal)
    Dim mVolume As Decimal

    '// Iterate through originals - create a negative entry for the original qtys
    For Each mPI As dmWoodPalletItem In pCurrentWoodPalletOrig.WoodPalletItems
      mVolume = Math.Round(((mPI.Thickness * mPI.Width * mPI.Length) / 12) * mPI.Quantity, 4)
      mRetVal.Add(mPI.StockItemID, (-1 * mVolume))
    Next

    '// now iterate through the current entries creating positive entries
    For Each mPI As dmWoodPalletItem In pCurrentWoodPallet.WoodPalletItems
      mVolume = Math.Round(((mPI.Thickness * mPI.Width * mPI.Length) / 12) * mPI.Quantity, 4)
      If mRetVal.ContainsKey(mPI.StockItemID) Then
        mRetVal.Item(mPI.StockItemID) = mRetVal.Item(mPI.StockItemID) + mVolume
      Else
        mRetVal.Add(mPI.StockItemID, mVolume)
      End If
    Next


    Return mRetVal

  End Function

End Class
