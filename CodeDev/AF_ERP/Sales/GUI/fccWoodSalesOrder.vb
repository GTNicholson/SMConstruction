Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccWoodSalesOrder
  Private pPrimaryKeyID As Integer
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pWoodPallets As colWoodPallets
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderHandler As clsSalesOrderHandler
  Private pCurrentWoodPallet As dmWoodPallet

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Me.pDBConn = rDBConn
    Me.pRTISGlobal = rRTISGlobal
    pWoodPallets = New colWoodPallets
    CurrentWooodPallet = New dmWoodPallet
  End Sub

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
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

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
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

  Public Property CurrentWooodPallet As dmWoodPallet
    Get
      Return pCurrentWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentWoodPallet = value
    End Set
  End Property

  Public Sub LoadDataRef()
    Dim mdso As New dsoStock(pDBConn)
    Dim mWhereWoodPallet As String = ""

    mWhereWoodPallet = "SoldDate is  null and IntoWIPDate is null "
    mdso.LoadWoodPalletsDownByWhere(pWoodPallets, mWhereWoodPallet)



  End Sub

  Public Sub LoadObjects()
    Dim mdso As dsoSalesOrder

    If pPrimaryKeyID = 0 Then
      pSalesOrder = clsSalesOrderHandler.CreateNewSalesOrder
      pSalesOrder.OrderTypeID = eOrderType.WoodSales
      pSalesOrder.OrderStatusENUM = eSalesOrderstatus.Abierto
      SaveObjects()

    Else
      pSalesOrder = New dmSalesOrder
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadSalesOrderDown(pSalesOrder, pPrimaryKeyID)

    End If
    If pSalesOrder.ProductCostBookID = 0 Then
      pSalesOrder.ProductCostBookID = GetDefaultCostBook()

    End If

    pSalesOrderHandler = New clsSalesOrderHandler(pSalesOrder)
  End Sub

  Public Sub SaveObjects()
    Try
      Dim mdso As dsoSalesOrder
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function GetDefaultCostBook() As Integer
    Dim mdso As dsoSalesOrder

    mdso = New dsoSalesOrder(pDBConn)
    Return mdso.GetDefaultCostBook()
  End Function

  Public Sub CreateSalesItems(ByRef rWoodPallets As List(Of dmWoodPallet))
    Dim mdso As dsoSalesOrder

    Try
      SaveObjects()
      pSalesOrderHandler.AddSalesOrderItemFromWoodPalletItems(rWoodPallets)

      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
      CreateSalesOrderPhaseItem(pSalesOrder.SalesOrderPhases(0), SalesOrder.SalesOrderID) ''//Because for the moment AF is using just one phase always
      SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try


  End Sub

  Public Sub CreateSalesOrderPhaseItem(ByRef rSalesOrderPhase As dmSalesOrderPhase, ByVal vSalesOrderID As Integer)
    Dim SOPI As dmSalesOrderPhaseItem
    Dim mFoundSOPI As dmSalesOrderPhaseItem

    ''rSalesOrderPhase.SalesOrderPhaseItems.Clear()

    If rSalesOrderPhase IsNot Nothing And rSalesOrderPhase.SalesOrderPhaseID > 0 Then



      For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems

          mFoundSOPI = rSalesOrderPhase.SalesOrderPhaseItems.ItemFromSalesItemKey(mSOI.SalesOrderItemID)
          If mFoundSOPI Is Nothing Then
            SOPI = New dmSalesOrderPhaseItem
            SOPI.SalesOrderID = vSalesOrderID
            SOPI.SalesOrderPhaseID = rSalesOrderPhase.SalesOrderPhaseID
            SOPI.SalesItemID = mSOI.SalesOrderItemID

            SOPI.Qty = mSOI.Quantity

            rSalesOrderPhase.SalesOrderPhaseItems.Add(SOPI)

          Else
            ''//Only update qty and ref
            Dim mIndex As Integer = -1

            mIndex = rSalesOrderPhase.SalesOrderPhaseItems.IndexFromKey(mFoundSOPI.SalesOrderPhaseItemID)

            If mIndex > -1 Then
              rSalesOrderPhase.SalesOrderPhaseItems(mIndex).Qty = mSOI.Quantity
              rSalesOrderPhase.SalesOrderPhaseItems(mIndex).SalesItemID = mSOI.SalesOrderItemID
            End If

          End If


        Next
        SaveObjects()
      End If



  End Sub

  Public Sub SaveWPIUsed()
    Dim mdso As New dsoStock(pDBConn)

    mdso.SaveWoodPalletDown(pCurrentWoodPallet)
  End Sub

  Public Function GetCustomerList() As colCustomers
    Dim mRetVal As New colCustomers
    Dim mdso As dsoSalesOrder
    Try
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadCustomers(mRetVal)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub ReloadCustomer()
    Dim mdso As dsoSalesOrder
    Try
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadCustomerDown(pSalesOrder.Customer, pSalesOrder.CustomerID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub
  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pSalesOrder.IsAnyDirty

    Return mIsDirty
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function
End Class
