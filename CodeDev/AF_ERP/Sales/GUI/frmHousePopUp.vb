Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmHousePopUp
  Private pSalesItems As colSalesOrderItems
  Private pDBConn As clsDBConnBase
  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssemblyID As Int32
  Private pHouseType As dmHouseType
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
    Set(value As dmHouseType)
      pHouseType = value
    End Set
  End Property


  Public Shared Function GetConfiguredHouseType(ByRef rDBConn As clsDBConnBase) As dmHouseType
    Dim mfrm As New frmHousePopUp


    Dim mRetVal As colSalesOrderItems = Nothing
    mfrm.DBConn = rDBConn
    mfrm.pHouseType = New dmHouseType

    mfrm.ShowDialog()


    Return mfrm.pHouseType
  End Function


  Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
    Dim mHouseTypeSalesItems As New colHouseTypeSalesItems
    Dim mHouseTypeID As Integer = -1
    Dim mConfiguredHouseType As New dmHouseType
    Dim mProducts As New colProductBases
    Dim mdsoSales As dsoSales
    Dim mHTSIIs As New colHouseTypeSalesItemInfos

    mdsoSales = New dsoSales(pDBConn)
    mdsoSales.LoadStandardProducts(mProducts)

    If UctHouseTypeOptions1.cboModel.SelectedIndex <> -1 Then
      UctHouseTypeOptions1.HouseType = mConfiguredHouseType
      UctHouseTypeOptions1.UpdateObjects()
      mHouseTypeID = UctHouseTypeOptions1.HouseType.ModelID
      LoadHouseTypeSalesItemsByHouseTypeID(mConfiguredHouseType, mHouseTypeID)
      pHouseType = mConfiguredHouseType
    End If


    Me.Close()
  End Sub

  Private Sub LoadHouseTypeSalesItemsByHouseTypeID(ByRef rConfiguredHouseType As dmHouseType, ByVal vHouseTypeID As Integer)
    Dim mdso As dsoProductAdmin
    Dim mdto As New dtoHouseTypeSalesItem(pDBConn)
    Dim mwhere As String = ""
    Try

      mdso = New dsoProductAdmin(pDBConn)
      mdso.LoadHouseTypeDown(rConfiguredHouseType, vHouseTypeID)

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