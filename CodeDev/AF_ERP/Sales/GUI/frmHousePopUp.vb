﻿Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmHousePopUp
  Private pSalesItems As colSalesOrderItems
  Private pDBConn As clsDBConnBase
  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssemblyID As Int32
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
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

  Public Property SalesItemAssemblyID As Int32
    Get
      Return pSalesItemAssemblyID
    End Get
    Set(value As Int32)
      pSalesItemAssemblyID = value
    End Set
  End Property
  Public Property SalesItems As colSalesOrderItems
    Get
      Return pSalesItems
    End Get
    Set(value As colSalesOrderItems)
      pSalesItems = value
    End Set
  End Property
  Public Shared Function GetGeneratedSalesItems(ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As clsDBConnBase, ByVal vSalesItemAssemblyID As Int32) As colSalesOrderItems
    Dim mfrm As New frmHousePopUp


    Dim mRetVal As colSalesOrderItems = Nothing
    mfrm.DBConn = rDBConn
    mfrm.SalesOrder = rSalesOrder
    mfrm.SalesItemAssemblyID = vSalesItemAssemblyID
    mfrm.ShowDialog()

    If mfrm.pSalesItems IsNot Nothing AndAlso mfrm.pSalesItems.Count > 0 Then
      mRetVal = mfrm.pSalesItems
    End If

    Return mRetVal

  End Function


  Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
    Dim mHouseTypeSalesItems As New colHouseTypeSalesItems
    Dim mSalesItem As dmSalesOrderItem

    LoadHouseTypeSalesItems(mHouseTypeSalesItems)
    pSalesItems = New colSalesOrderItems

    If mHouseTypeSalesItems IsNot Nothing Then

      For Each mHouseTypeSalesItem In mHouseTypeSalesItems

        mSalesItem = New dmSalesOrderItem
        mSalesItem.Description = mHouseTypeSalesItem.Description
        mSalesItem.HouseTypeID = mHouseTypeSalesItem.HouseTypeID
        mSalesItem.ProductID = mHouseTypeSalesItem.ProductID
        mSalesItem.ProductTypeID = mHouseTypeSalesItem.ProductTypeID
        mSalesItem.Quantity = mHouseTypeSalesItem.Quantity
        mSalesItem.SalesItemAssemblyID = pSalesItemAssemblyID
        mSalesItem.SalesOrderID = pSalesOrder.SalesOrderID
        mSalesItem.UnitPrice = mHouseTypeSalesItem.UnitPrice
        pSalesItems.Add(mSalesItem)
      Next

    End If
    Me.Close()
  End Sub

  Private Sub LoadHouseTypeSalesItems(ByRef rHTSalesItems As colHouseTypeSalesItems)
    Dim mdto As New dtoHouseTypeSalesItem(pDBConn)
    Try
      pDBConn.Connect()
      mdto.LoadHouseTypeSalesItemsCollectionByWhere(rHTSalesItems, "")

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()


    End Try
  End Sub

  Private Sub frmHousePopUp_Load(sender As Object, e As EventArgs) Handles Me.Load
    LoadCombos()
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.GroupType)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboGroup, mVIs)


    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Model)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboModel, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FoundationOptions)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboFoundations, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FloorOptions)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboFloor, mVIs)


    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WallOptions)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboWalls, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WindowOptions)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboWindows, mVIs)

  End Sub
End Class