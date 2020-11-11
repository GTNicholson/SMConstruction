Public Class clsPickerSalesOrderPhaseItem : Inherits clsPickerBase(Of clsSalesOrderPhaseItemInfo)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pOriginalProductID As Integer
  Private pCurrentProductID As Integer
  Private pUnfilteredList As colSalesOrderPhaseItemInfos

  Public Sub New(ByVal vDataSource As colSalesOrderPhaseItemInfos, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vProductID As Integer)
    MyBase.New
    pUnfilteredList = vDataSource
    pOriginalProductID = vProductID
    pCurrentProductID = vProductID
    RefreshDataSource()
    pDBConn = rDBConn
  End Sub

  Public Sub RefreshDataSource()
    Dim mFilteredList As New colSalesOrderPhaseItemInfos

    For Each mSOPII In pUnfilteredList
      If pCurrentProductID = 0 Or mSOPII.Product.ID = pCurrentProductID Then
        mFilteredList.Add(mSOPII)
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

  Public Property OriginalProductID As Integer
    Get
      Return pOriginalProductID
    End Get
    Set(value As Integer)
      pOriginalProductID = value
    End Set
  End Property

  Public Property CurrentProductID As Integer
    Get
      Return pCurrentProductID
    End Get
    Set(value As Integer)
      pCurrentProductID = value
    End Set
  End Property


End Class
