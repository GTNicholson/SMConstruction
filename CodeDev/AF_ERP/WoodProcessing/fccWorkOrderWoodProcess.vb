Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccWorkOrderWoodProcess
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pWorkOrderID As Integer
  Private pWorkOrder As dmWorkOrder
  Private pSourceWoodPalletItem As colWoodPalletItems
  Private pWoodPallets As colWoodPallets
  Private pCurrentWoodPallet As dmWoodPallet
  Private pOutputWoodPalletItem As colWoodPalletItems
  Private pWorkOrderWoodType As Integer
  Public Property CurrentWoodPallet As dmWoodPallet
    Get
      Return pCurrentWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentWoodPallet = value
    End Set
  End Property
  Public Property CurrentWoodWorkOrder As dmWorkOrder
    Get
      Return pWorkOrder

    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property WoodPallets As colWoodPallets
    Get
      Return pWoodPallets
    End Get
    Set(value As colWoodPallets)
      pWoodPallets = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn

    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Property SourceWoodPalletItem() As colWoodPalletItems
    Get
      Return pSourceWoodPalletItem
    End Get
    Set(value As colWoodPalletItems)
      pSourceWoodPalletItem = value
    End Set
  End Property


  Public Property OutputWoodPalletItem() As colWoodPalletItems
    Get
      Return pOutputWoodPalletItem
    End Get
    Set(value As colWoodPalletItems)
      pOutputWoodPalletItem = value
    End Set
  End Property

  Public Property WorkOrderWoodType As Integer
    Get
      Return pWorkOrderWoodType
    End Get
    Set(value As Integer)
      pWorkOrderWoodType = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pWorkOrderID = vWorkOrderID


    pSourceWoodPalletItem = New colWoodPalletItems
    pWoodPallets = New colWoodPallets
    pCurrentWoodPallet = New dmWoodPallet
    pOutputWoodPalletItem = New colWoodPalletItems

  End Sub


  Public Sub LoadObject()
    Dim mdso As dsoSales



    mdso = New dsoSales(pDBConn)

    If pWorkOrderID = 0 Then
      '// if it is new work order it will be internal - Sales Order Work Orders will be created from the salesorder form
      pWorkOrder = clsWorkOrderHandler.CreateInternalWorkOrder(eProductType.WoodWorkOrder)
      pWorkOrder.WorkOrderWoodType = pWorkOrderWoodType
      pWorkOrder.isInternal = True
    Else
      If pWorkOrder Is Nothing Then '//Not already loaded
        pWorkOrder = New dmWorkOrder

        mdso.LoadWorkOrderDown(pWorkOrder, pWorkOrderID)

        LoadSourceWoodPallet()

      End If

    End If
  End Sub

  Private Sub LoadSourceWoodPallet()
    Dim mdsoWodoPalletItem As New dsoStock(pDBConn)
    Dim mWoodPallet As New dmWoodPallet

    For Each mSourceWoodPallet As dmSourcePallet In pWorkOrder.SourcePallets
      mdsoWodoPalletItem.LoadWoodPalletDown(mWoodPallet, mSourceWoodPallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        For Each mWoodPalletItem As dmWoodPalletItem In mWoodPallet.WoodPalletItems
          SourceWoodPalletItem.Add(mWoodPalletItem)

        Next
      End If
    Next
  End Sub

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder.IsAnyDirty Then mRetVal = True
    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoSales
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    mdso = New dsoSales(pDBConn)

    If pWorkOrder.WorkOrderNo = "" Then
      pWorkOrder.WorkOrderWoodType = pWorkOrderWoodType

      Select Case pWorkOrderWoodType
        Case eWorkOrderWoodProcess.RolloAAserrado
        Case eWorkOrderWoodProcess.RolloAMAV
          pWorkOrder.WorkOrderNo = "AAR-" & mdsoGeneral.getNextTally(eTallyIDs.RollWoodOT)

        Case eWorkOrderWoodProcess.ArbolARollo
          pWorkOrder.WorkOrderNo = "AAR-" & mdsoGeneral.getNextTally(eTallyIDs.RollWoodOT)

        Case eWorkOrderWoodProcess.MASClasificado
        Case eWorkOrderWoodProcess.MAVAMAS


      End Select
    End If

    mdso.SaveWorkOrderDown(pWorkOrder)

    mdsoStock.SaveWoodPalletCollectionDown(pWoodPallets)
    mRetVal = True
    Return mRetVal
  End Function

  Public Function LoadWoodPalletByPalletTypeID(mPalletType As Integer) As dmWoodPallet
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallets As New colWoodPallets
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWhere As String
    mWhere = "PalletType = " & mPalletType
    mdso.LoadWoodPalletDownByWhere(mWoodPallets, mWhere)

    If mWoodPallets IsNot Nothing And mWoodPallets.Count > 0 Then
      mRetVal = mWoodPallets(0)
    End If
    Return mRetVal
  End Function

  Public Function LoadWoodPalletByWoodPalletID(mWoodPalletID As Integer) As dmWoodPallet
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallets As New colWoodPallets
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWhere As String
    mWhere = "WoodPalletID = " & mWoodPalletID
    mdso.LoadWoodPalletDownByWhere(mWoodPallets, mWhere)

    If mWoodPallets IsNot Nothing And mWoodPallets.Count > 0 Then
      mRetVal = mWoodPallets(0)
    End If
    Return mRetVal
  End Function

  Public Sub CreateWoodPallet(ByVal vPalletType As Integer)
    Dim mOutputPallet As New dmOutputPallet

    CreateNewWoodPallet(vPalletType)
    SetCurrentWoodPallet(pWoodPallets.Last)

    If pCurrentWoodPallet IsNot Nothing Then

      mOutputPallet.WoodPalletID = pCurrentWoodPallet.WoodPalletID
      mOutputPallet.WorkOrderID = pWorkOrder.WorkOrderID
      pWorkOrder.OutputPallets.Add(mOutputPallet)
    End If
    SaveObjects()
  End Sub
  Public Sub SetCurrentWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    If rWoodPallet Is Nothing Then
      pCurrentWoodPallet = New dmWoodPallet
    Else

      pCurrentWoodPallet = rWoodPallet

    End If
    pOutputWoodPalletItem = GetOutputWoodPalletItems(pCurrentWoodPallet)
  End Sub

  Private Function GetOutputWoodPalletItems(pCurrentWoodPallet As dmWoodPallet) As colWoodPalletItems
    Dim mRetVal As New colWoodPalletItems


    'Return pCurrentWoodPallet.WoodPalletItems
  End Function

  Public Sub CreateNewWoodPallet(ByVal vPalletType As Integer)
    Dim mWoodPallet As New dmWoodPallet

    GetNextWoodPalletRef(mWoodPallet)
    mWoodPallet.Description = ""

    Select Case vPalletType
      Case eWorkOrderWoodProcess.ArbolARollo
        mWoodPallet.PalletType = eStockItemTypeTimberWood.Rollo

      Case eWorkOrderWoodProcess.RolloAMAV
        mWoodPallet.PalletType = eStockItemTypeTimberWood.MAV

      Case eWorkOrderWoodProcess.MAVAMAS

        mWoodPallet.PalletType = eStockItemTypeTimberWood.MAS

      Case eWorkOrderWoodProcess.MASClasificado

        mWoodPallet.PalletType = eStockItemTypeTimberWood.Clasificado

      Case eWorkOrderWoodProcess.RolloAAserrado

        mWoodPallet.PalletType = eStockItemTypeTimberWood.Aserrado

    End Select


    mWoodPallet.CreatedDate = Now
    mWoodPallet.LocationID = 0

    pWoodPallets.Add(mWoodPallet)
    SaveObjects()
  End Sub

  Public Sub GetNextWoodPalletRef(ByRef rWoodPallet As dmWoodPallet)
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    rWoodPallet.PalletRef = "BLT-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("00000")
  End Sub

  Public Sub DeleteWoodPallets(ByRef rWoodPallet As dmWoodPallet)
    Dim mPos As Integer
    Dim mNewPos As Integer = -1
    If rWoodPallet IsNot Nothing Then
      'Find the position of the item we are going to delete
      mPos = 0
      For Each mWoodPallet As dmWoodPallet In pWoodPallets
        If mWoodPallet Is rWoodPallet Then
          mNewPos = mPos 'This will be the next one in the list a we will take out this position
          Exit For
        End If
        mPos += 1
      Next

      DeleteWoodPallet(rWoodPallet)

      If pWoodPallets.Count = 0 Then
        SetCurrentWoodPallet(Nothing)
      ElseIf mNewPos <= pWoodPallets.Count - 1 Then
        SetCurrentWoodPallet(pWoodPallets(mNewPos))
      Else
        SetCurrentWoodPallet(pWoodPallets.Last)
      End If
    End If
  End Sub

  Public Sub DeleteWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    pWoodPallets.Remove(rWoodPallet)
  End Sub
End Class
