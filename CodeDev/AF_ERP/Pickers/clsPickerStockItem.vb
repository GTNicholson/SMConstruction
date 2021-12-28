Public Class clsPickerStockItem : Inherits clsPickerBase(Of dmStockItem)
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentCategory As eStockItemCategory

  Public Sub New(ByRef rDataSource As colStockItems, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, rRTISGlobal As AppRTISGlobal)
    MyBase.New
    DataSource = rDataSource
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
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

  Public Property CurrentCategory As eStockItemCategory
    Get
      Return pCurrentCategory
    End Get
    Set(value As eStockItemCategory)
      pCurrentCategory = value
    End Set
  End Property

  Public Function SelectedCount(ByVal vCategory As eStockItemCategory) As Integer
    Dim mRetVal As Integer = 0
    For Each mSI In SelectedObjects
      If mSI IsNot Nothing Then
        If mSI.Category = vCategory Then
          mRetVal += 1
        End If
      End If
    Next
    Return mRetVal
  End Function


End Class
