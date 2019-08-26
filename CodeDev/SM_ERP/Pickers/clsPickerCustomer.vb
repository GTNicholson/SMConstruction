Public Class clsPickerCustomer : Inherits clsPickerBase(Of dmCustomer)

  Public Sub New(ByVal vDataSource As colCustomers)
    MyBase.New
    DataSource = vDataSource
  End Sub

End Class