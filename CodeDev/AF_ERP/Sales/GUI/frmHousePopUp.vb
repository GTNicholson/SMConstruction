Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmHousePopUp
  Private pSalesItems As colSalesOrderItems
  Private pDBConn As clsDBConnBase
  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssemblyID As Int32
  Private pHouseTypeInfo As clsHouseTypeInfo
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

  Public Property HouseTypeInfo As clsHouseTypeInfo
    Get
      Return pHouseTypeInfo
    End Get
    Set(value As clsHouseTypeInfo)
      pHouseTypeInfo = value
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
  Public Shared Function GetGeneratedSalesItems(ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As clsDBConnBase, ByVal vSalesItemAssemblyID As Int32) As clsHouseTypeInfo
    Dim mfrm As New frmHousePopUp


    Dim mRetVal As colSalesOrderItems = Nothing
    mfrm.DBConn = rDBConn
    mfrm.pHouseTypeInfo = New clsHouseTypeInfo

    mfrm.SalesOrder = rSalesOrder
    mfrm.SalesItemAssemblyID = vSalesItemAssemblyID
    mfrm.ShowDialog()

    ''If mfrm.pSalesItems IsNot Nothing AndAlso mfrm.pSalesItems.Count > 0 Then
    ''  mRetVal = mfrm.pSalesItems
    ''End If

    ''Return mRetVal
    Return mfrm.pHouseTypeInfo
  End Function


  Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
    Dim mHouseTypeSalesItems As New colHouseTypeSalesItems
    Dim mSalesItem As dmSalesOrderItem
    Dim mHouseTypeID As Integer = -1

    If UctHouseTypeOptions1.cboModel.SelectedIndex <> -1 Then
      mHouseTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(UctHouseTypeOptions1.cboModel)
    End If

    LoadHouseTypeSalesItemsByHouseTypeID(mHouseTypeSalesItems, mHouseTypeID)
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

      pHouseTypeInfo.SalesOrderItems = pSalesItems
      pHouseTypeInfo.GroupID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(UctHouseTypeOptions1.cboGroup)
      pHouseTypeInfo.HouseTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(UctHouseTypeOptions1.cboModel)
      pHouseTypeInfo.ModelName = UctHouseTypeOptions1.cboModel.Text
    End If
    Me.Close()
  End Sub

  Private Sub LoadHouseTypeSalesItemsByHouseTypeID(ByRef rHTSalesItems As colHouseTypeSalesItems, ByVal vHouseTypeID As Integer)
    Dim mdto As New dtoHouseTypeSalesItem(pDBConn)
    Dim mwhere As String = ""
    Try
      pDBConn.Connect()
      mwhere = "HouseTypeID = " & vHouseTypeID.ToString
      mdto.LoadHouseTypeSalesItemsCollectionByWhere(rHTSalesItems, mwhere)

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
    Dim mHouseTypes As New colHouseTypes
    Dim mdso As New dsoProductAdmin(pDBConn)
    Dim mValueItem As clsValueItem
    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.GroupType)
    clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboGroup, mVIs)


    ''mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.HouseType)
    '' clsDEControlLoading.FillDEComboVI(UctHouseTypeOptions1.cboModel, mVIs)

    mdso.LoadHouseTypes(mHouseTypes)

    If mHouseTypes IsNot Nothing Then
      mVIs.Clear()

      For Each mHT As dmHouseType In mHouseTypes
        mValueItem = New clsValueItem
        mValueItem.ItemValue = mHT.ItemValue
        mValueItem.DisplayValue = mHT.DisplayValue
        mVIs.Add(mValueItem)
      Next
    End If
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