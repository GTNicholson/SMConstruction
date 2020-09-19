Public Class clsPickerSupplier : Inherits clsPickerBase(Of dmSupplier)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByVal vDataSource As colSuppliers, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New
    DataSource = vDataSource
    pDBConn = rDBConn
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

End Class