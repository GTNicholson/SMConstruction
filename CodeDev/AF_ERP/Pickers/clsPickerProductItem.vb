Public Class clsPickerProductItem : Inherits clsPickerBase(Of clsProductBaseInfo)
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentCategory As eProductType

  Public Sub New(ByRef rDataSource As colProductBaseInfos, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, rRTISGlobal As AppRTISGlobal)
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

  Public Property CurrentCategory As eProductType
    Get
      Return pCurrentCategory
    End Get
    Set(value As eProductType)
      pCurrentCategory = value
    End Set
  End Property

  Public Function SelectedCount(ByVal vCategory As eProductType) As Integer
    Dim mRetVal As Integer = 0
    For Each mProduct In SelectedObjects
      If mProduct IsNot Nothing Then
        If mProduct.ProductTypeID = vCategory Then
          mRetVal += 1
        End If
      End If

    Next
    Return mRetVal
  End Function


End Class
