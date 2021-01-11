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
  Private pPreviousLocationID As Integer

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

  Public Property PreviousLocationID As Integer
    Get
      Return pPreviousLocationID
    End Get
    Set(value As Integer)
      pPreviousLocationID = value
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
    pWoodPalletItemEditors = New colWoodPalletItemEditors()
  End Sub

  Public Function AddWoodPallet() As dmWoodPallet
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWoodPallet As dmWoodPallet

    Try

      mWoodPallet = New dmWoodPallet

      mWoodPallet.CreatedDate = Now
      pWoodPallets.Add(mWoodPallet)

      mRetVal = mWoodPallet
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function


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

    Dim mStockItem As New dmStockItem
    Dim mWoodPalletDescription As String = ""

    Dim mQty As Integer = 0
    Try

      If pCurrentWoodPallet IsNot Nothing Then
        Dim mdsoStock As New dsoStock(pDBConn)


        ''  mWoodItemcols = pCurrentWoodPallet.WoodPalletItems.Clone

        ''  mWoodItemcols.OrderBy(Function(mwooditem) mwooditem.StockItemID)


        ''  For Each mVI In pRTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie)

        ''    mTempWoodPalletItem = New dmWoodPalletItem
        ''    mQty = 0
        ''    For Each mwoodpalletitem As dmWoodPalletItem In mWoodItemcols

        ''      mStockItemElement = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mwoodpalletitem.StockItemID)

        ''      If mStockItemElement IsNot Nothing Then

        ''        If mStockItemElement.Species = mVI.ItemValue Then

        ''          If mStockItemElement.Thickness = mwoodpalletitem.Thickness Then
        ''            mQty = mQty + 1
        ''            mTempWoodPalletItem = mwoodpalletitem
        ''          End If


        ''        End If

        ''      End If


        ''    Next
        ''    If mQty > 0 Then
        ''      mWoodPalletDescription &= mQty & " de Elementos de " & mVI.DisplayValue.Trim & " con grosor de " & mTempWoodPalletItem.Thickness.ToString("N1") & vbCrLf

        ''    End If

        ''  Next


        mdsoStock.SaveWoodPalletDown(pCurrentWoodPallet)

        '// Create Adjustment transactions
        ' mAdjustments = GetStockItemLocationChange()

        '// Remember not to create a transaction for the list when the value is 0
        'For Each mKVP As KeyValuePair(Of Integer, Decimal) In mAdjustments
        '  If mKVP.Value <> 0 Then
        '    mdsoStock.LoadStockItemByStockItemID(mStockItem, mKVP.Key)
        '    If mStockItem IsNot Nothing Then
        '      ' ApplyStockAdjust(mStockItem, pPreviousLocationID, eTransactionType.Adjustment, mKVP.Value, Now, "")

        '    End If

        '  End If
        'Next


        mdsoStock = Nothing
      End If



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub ApplyStockAdjust(ByVal vStockItem As dmStockItem, ByVal vLocationID As Byte, ByVal vTransactionType As eTransactionType, ByVal vTranQty As Decimal, ByVal vAdjustDate As DateTime, ByVal vNotes As String)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mStockItemLocation As dmStockItemLocation

    Try

      mStockItemLocation = mdsoStock.GetOrCreateStockItemLocation(vStockItem.StockItemID, vLocationID)

      If mStockItemLocation IsNot Nothing Then
        Dim mLocationAmendment As New dmStockItemLocationAmendmentLog

        With mLocationAmendment
          .SystemDate = DateTime.Now
          .AmendmentDate = vAdjustDate
          .ChangeDetails = vNotes
          .UserID = pDBConn.RTISUser.UserID
          .StockItemLocationID = mStockItemLocation.StockItemLocationID
        End With

        ''If mdsoStock.SaveStockItemLocationAmendmentLog(mLocationAmendment) Then
        Select Case vTransactionType
          Case eTransactionType.Adjustment
            mdsoStockTran.AdjustmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Dollar, vStockItem.StdCost, 1)
          Case eTransactionType.Amendment
            mdsoStockTran.AmendmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Dollar, vStockItem.StdCost, 1)
        End Select

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
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

  Public Sub SetCurrentWoodPalletInfo()
    Dim mStockItem As dmStockItem

    Try

    Catch ex As Exception

    End Try





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
      If mRetVal.ContainsKey(mPI.StockItemID) Then
        mRetVal.Item(mPI.StockItemID) = mRetVal.Item(mPI.StockItemID) + mVolume
      Else
        mRetVal.Add(mPI.StockItemID, (-1 * mVolume))
      End If


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

  Public Sub RefreshWoodPalletItemEditor(ByVal vCurrentWoodPallet As dmWoodPallet)
    Dim mWPItemEditor As clsWoodPalletItemEditor
    Dim mSI As dmStockItem

    pWoodPalletItemEditors.Clear()

    If vCurrentWoodPallet IsNot Nothing Then
      For Each mWPI As dmWoodPalletItem In vCurrentWoodPallet.WoodPalletItems
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)

        If mWPI IsNot Nothing Then
          mWPItemEditor = New clsWoodPalletItemEditor(mWPI, mSI)
          pWoodPalletItemEditors.Add(mWPItemEditor)
        End If

      Next

    End If
  End Sub

  Public Sub ToProcessQty()
    Dim mCurrentQty As Decimal
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mSI As dmStockItem
    Dim mTempWoodPallet As dmWoodPallet
    Dim mTempWoodPalletItems As New colWoodPalletItems
    Dim mTempWoodPalletItem As dmWoodPalletItem
    Try
      mTempWoodPallet = New dmWoodPallet



      For Each mWPIE As clsWoodPalletItemEditor In pWoodPalletItemEditors

        If mWPIE.ToProcessQty <> 0 Then
          mTempWoodPalletItem = New dmWoodPalletItem


          mCurrentQty = pCurrentWoodPallet.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity
          mTempWoodPalletItem.Quantity = mWPIE.ToProcessQty
          pCurrentWoodPallet.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity = mCurrentQty + mWPIE.ToProcessQty

          mTempWoodPalletItem.Quantity = mWPIE.ToProcessQty
          mTempWoodPalletItem.StockItemID = mWPIE.StockItem.StockItemID
          mTempWoodPalletItem.Thickness = mWPIE.StockItem.Thickness
          mTempWoodPalletItem.Width = mWPIE.WoodPalletItem.Width
          mTempWoodPalletItem.Length = mWPIE.WoodPalletItem.Length
          mTempWoodPallet.WoodPalletItems.Add(mTempWoodPalletItem)
        End If
        mWPIE.ToProcessQty = 0

      Next

      SaveObject()


      If mTempWoodPallet IsNot Nothing Then
        If mTempWoodPallet.WoodPalletItems.Count > 0 Then
          CreateAmendmentWoodPalletTransaction(pCurrentWoodPallet.LocationID, mTempWoodPallet)
        End If
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub CreateAmendmentWoodPalletTransaction(ByVal vSourceLocationID As Integer, ByVal vWoodPallet As dmWoodPallet)
    Dim mSIL As New dmStockItemLocation
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions

    Dim mdsoCostBook As dsoCostBook


    mdsoTran = New dsoStockTransactions(pDBConn)
    mdsoCostBook = New dsoCostBook(pDBConn)


    mdsoStock = New dsoStock(pDBConn)

    mdsoTran.CreateOutputTransaction(eTransactionType.WoodAmendment, vWoodPallet, vSourceLocationID, New dmSalesOrder, Now, eCurrency.Dollar, 1)




  End Sub



End Class
