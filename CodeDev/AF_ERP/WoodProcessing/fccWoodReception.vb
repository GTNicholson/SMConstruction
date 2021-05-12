Imports DevExpress.CodeParser
Imports DevExpress.Pdf
Imports DevExpress.XtraPrinting.Drawing
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPCore

Public Class fccWoodReception
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPrimaryKeyID As Integer
  Private pWoodReception As dmReception
  Private pBrowseRefreshTracker As clsBasicBrowseRefreshTracker
  Private pCurrentSourceWoodPallet As dmWoodPallet
  Private pSourceWoodPalletItemEditors As colWoodPalletItemEditors
  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vReceptionID As Integer)
    pDBConn = rDBConn
    pWoodReception = New dmReception
    pRTISGlobal = rRTISGlobal
    pPrimaryKeyID = vReceptionID
    ' pCurrentSourceWoodPallet = New dmWoodPallet
  End Sub

  Public Property CurrentSourceWoodPallet As dmWoodPallet
    Get
      Return pCurrentSourceWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentSourceWoodPallet = value
    End Set
  End Property

  Public Property RTISGlobal() As AppRTISGlobal
    Get
      RTISGlobal = pRTISGlobal
    End Get
    Set(ByVal value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property
  Public Property SourceWoodPalletItemEditors As colWoodPalletItemEditors
    Get
      Return pSourceWoodPalletItemEditors
    End Get
    Set(value As colWoodPalletItemEditors)
      pSourceWoodPalletItemEditors = value
    End Set
  End Property
  Public Property PrimaryKeyID() As Integer
    Get
      PrimaryKeyID = pPrimaryKeyID
    End Get
    Set(ByVal value As Integer)
      pPrimaryKeyID = value

    End Set
  End Property


  Public Property CurrentReception As dmReception
    Get
      Return pWoodReception
    End Get
    Set(value As dmReception)
      pWoodReception = value
    End Set
  End Property


  Public Property BrowseRefreshTracker As clsBasicBrowseRefreshTracker
    Get
      Return pBrowseRefreshTracker
    End Get
    Set(value As clsBasicBrowseRefreshTracker)
      pBrowseRefreshTracker = value
    End Set
  End Property


  Public Function LoadObject() As Boolean

    Dim mdsoReception As New dsoReception(DBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mOK As Boolean
    Dim mWhere As String = ""
    Try

      mOK = True
      pWoodReception = New dmReception

      If pPrimaryKeyID > 0 Then

        mOK = mdsoReception.LoadReceptionDown(pWoodReception, PrimaryKeyID)


      Else
        pWoodReception.ReceptionDate = Today
        pWoodReception.ReceptionNo = GetNextOrderNo()
        pWoodReception.ItemType = eStockItemTypeTimberWood.Rollo
        SaveObjects()
        mOK = True
      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoReception = Nothing
    End Try
    Return mOK

  End Function

  Private Function GetNextOrderNo() As String
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mRetVal As String = ""

    mRetVal = "IM-" & mdsoGeneral.GetNextTallyReceptionNo().ToString("00000")

    Return mRetVal


  End Function

  Public Function LoadWoodPalletByWoodPalletID(mWoodPalletID As Integer) As dmWoodPallet
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallets As New colWoodPallets
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWhere As String
    mWhere = "WoodPalletID = " & mWoodPalletID
    mdso.LoadWoodPalletsDownByWhere(mWoodPallets, mWhere)

    If mWoodPallets IsNot Nothing And mWoodPallets.Count > 0 Then
      mRetVal = mWoodPallets(0)
    End If
    Return mRetVal
  End Function


  Public Sub RefreshSourceWoodPalletItemEditors(ByVal vCurrentSourceWoodPallet As dmWoodPallet)
    Dim mWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mStockItem As dmStockItem
    pSourceWoodPalletItemEditors = New colWoodPalletItemEditors

    For Each mWPI As dmWoodPalletItem In vCurrentSourceWoodPallet.WoodPalletItems
      mWoodPalletItemEditor = New clsWoodPalletItemEditor
      mWoodPalletItemEditor.WoodPalletItem = mWPI
      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)
      mWoodPalletItemEditor.StockItem = mStockItem
      pSourceWoodPalletItemEditors.Add(mWoodPalletItemEditor)
    Next
  End Sub

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    If CurrentReception IsNot Nothing Then
      mIsDirty = CurrentReception.IsAnyDirty


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
      mValidate.AddMsgLine("Falló la verificación de detalles")
    End If
    Return mValidate
  End Function

  Public Function SaveObjects() As Boolean
    Dim mOK As Boolean = False
    Dim mdsoReception As New dsoReception(DBConn)


    Try
      If pWoodReception.ItemType > 0 Then
        mOK = mdsoReception.SaveReceptionDown(Me.CurrentReception)
      End If

      If pPrimaryKeyID = 0 Then
        pPrimaryKeyID = CurrentReception.ReceptionID
      End If
      If pBrowseRefreshTracker IsNot Nothing Then pBrowseRefreshTracker.RefreshAll = True

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoReception = Nothing
    End Try

    Return mOK
  End Function

  Public Function AddWoodPalletItem(ByRef rWoodPallet As dmWoodPallet) As dmWoodPalletItem
    Dim mRetVal As New dmWoodPalletItem

    With mRetVal
      .WoodPalletID = rWoodPallet.WoodPalletID

    End With

    rWoodPallet.WoodPalletItems.Add(mRetVal)
    Return mRetVal
  End Function

  Public Sub ClearObjects()

    Me.CurrentReception = Nothing

  End Sub


  Public Sub SetCurrentSourceWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    If rWoodPallet Is Nothing Then
      pCurrentSourceWoodPallet = New dmWoodPallet
    Else

      pCurrentSourceWoodPallet = rWoodPallet
      RefreshSourceWoodPalletItemEditors(rWoodPallet)
    End If

  End Sub



  Public Function CreateNewPallet(ByVal vPalletType As Integer, ByVal vFarm As Integer, ByVal vCardNumber As String) As dmWoodPallet
    Dim mWoodPallet As New dmWoodPallet



    mWoodPallet.PalletType = vPalletType
    mWoodPallet.Farm = vFarm
    mWoodPallet.CreatedDate = Now
    mWoodPallet.LocationID = eLocations.AgroForestal
    mWoodPallet.ReceptionID = CurrentReception.ReceptionID
    mWoodPallet.Archive = 0
    mWoodPallet.CardNumber = vCardNumber
    clsWoodPalletSharedFuncs.GetNextWoodPalletRef(mWoodPallet, pDBConn)
    SaveWoodPalletDown(mWoodPallet)
    CurrentReception.WoodPallets.Add(mWoodPallet)

    Return mWoodPallet
  End Function

  Public Sub SaveWoodPalletDown(ByRef rWoodPallet As dmWoodPallet)
    Dim mdso As New dsoStock(pDBConn)

    mdso.SaveWoodPalletDown(rWoodPallet)

  End Sub

  Public Function GetWoodPalletSource() As colWoodPallets
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallets As New colWoodPallets

    For Each mSourcePallet As dmWoodPallet In pWoodReception.WoodPallets

      If mSourcePallet IsNot Nothing Then
        mWoodPallets.Add(mSourcePallet)
      End If
    Next

    Return mWoodPallets
  End Function

  Public Sub ReceiveWoodPallets(ByVal vWithDifferenceValue As Boolean)
    Dim mCurrentQty As Decimal
    Dim mTempWoodPallet As dmWoodPallet
    Dim mTempWoodPalletItems As New colWoodPalletItems
    Dim mTempWoodPalletItem As dmWoodPalletItem
    Dim mToProcQtyBoardFeet As Decimal
    Dim mWP As dmWoodPallet
    Try
      mTempWoodPallet = New dmWoodPallet


      mTempWoodPallet.WoodPalletID = pCurrentSourceWoodPallet.WoodPalletID
      mTempWoodPallet.PalletRef = pCurrentSourceWoodPallet.PalletRef

      For Each mWPIE As clsWoodPalletItemEditor In pSourceWoodPalletItemEditors

        If mWPIE.ToProcessQty <> 0 Then
          mTempWoodPalletItem = New dmWoodPalletItem

          Select Case mWPIE.StockItem.ItemType
            Case eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.Arbol
              mToProcQtyBoardFeet = mWPIE.ToProcessQty 'clsWoodPalletSharedFuncs.GetTrunkVolume(mWPIE.WoodPalletItem.Length, mWPIE.StockItem.Thickness) * mWPIE.ToProcessQty
            Case Else
              mToProcQtyBoardFeet = mWPIE.ToProcessQty
          End Select
          mWP = pWoodReception.WoodPallets.ItemFromKey(pCurrentSourceWoodPallet.WoodPalletID)
          mWP.WoodPalletItems = pCurrentSourceWoodPallet.WoodPalletItems.Clone
          If mWP IsNot Nothing Then

            mCurrentQty = pCurrentSourceWoodPallet.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity
            mTempWoodPalletItem.DifferenceTranQty = mWPIE.ToProcessQty - mCurrentQty
            mTempWoodPalletItem.Quantity = mToProcQtyBoardFeet
            mWP.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity = mToProcQtyBoardFeet ' mCurrentQty + mToProcQtyBoardFeet
            mWP.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).OutstandingQty = mWP.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity - mWP.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).QuantityUsed
            mWPIE.QuantityUI = mToProcQtyBoardFeet 'mCurrentQty + mToProcQtyBoardFeet
            mTempWoodPalletItem.StockItemID = mWPIE.StockItem.StockItemID
            mTempWoodPalletItem.Thickness = mWPIE.WoodPalletItem.Thickness
            mTempWoodPalletItem.Width = mWPIE.WoodPalletItem.Width
            mTempWoodPalletItem.Length = mWPIE.WoodPalletItem.Length

            mTempWoodPallet.WoodPalletItems.Add(mTempWoodPalletItem)
          End If
        End If
        mWPIE.ToProcessQty = 0

      Next

      SaveObjects()


      If mTempWoodPallet IsNot Nothing Then
        If mTempWoodPallet.WoodPalletItems.Count > 0 Then
          CreateReceptionTransaction(pCurrentSourceWoodPallet.LocationID, mTempWoodPallet, vWithDifferenceValue)
        End If
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub
  Public Sub CreateReceptionTransaction(ByVal vSourceLocationID As Integer, ByVal vWoodPallet As dmWoodPallet, ByVal vWithDifferenceValue As Boolean)
    Dim mSIL As New dmStockItemLocation
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions

    Dim mdsoCostBook As dsoCostBook


    mdsoTran = New dsoStockTransactions(pDBConn)
    mdsoCostBook = New dsoCostBook(pDBConn)


    mdsoStock = New dsoStock(pDBConn)

    mdsoTran.CreatePositiveTransaction(eTransactionType.WoodReception, vWoodPallet, vSourceLocationID, Now, eCurrency.Dollar, 1, vWithDifferenceValue)




  End Sub
End Class
