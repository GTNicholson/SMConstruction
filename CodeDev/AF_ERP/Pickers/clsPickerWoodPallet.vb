Public Class clsPickerWoodPallet : Inherits clsPickerBase(Of dmWoodPallet)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pOriginalProductID As Integer
  Private pPalletType As Integer
  Private pUnfilteredList As colWoodPallets
  Private pIsWoodSalesOrder As Boolean

  Public Sub New(ByVal vDataSource As colWoodPallets, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vPalletType As Integer, Optional vIsWoodSalesOrder As Boolean = False)
    MyBase.New
    pUnfilteredList = vDataSource
    pOriginalProductID = vPalletType
    pPalletType = vPalletType
    pIsWoodSalesOrder = vIsWoodSalesOrder
    RefreshDataSource()
    pDBConn = rDBConn
  End Sub

  Public Sub RefreshDataSource()
    Dim mFilteredList As New colWoodPallets

    For Each mWoodPallet In pUnfilteredList
      If mWoodPallet.PalletType = pPalletType Then
        mFilteredList.Add(mWoodPallet)
      ElseIf pIsWoodSalesOrder = True Then

        mFilteredList.Add(mWoodPallet)
      End If
    Next
    DataSource = mFilteredList
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property



  Public Property PalletType As Integer
    Get
      Return pPalletType
    End Get
    Set(value As Integer)
      pPalletType = value
    End Set
  End Property


End Class
