Public Class clsPickerMachinery : Inherits clsPickerBase(Of dmMachinery)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByVal vDataSource As colMachinerys, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
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