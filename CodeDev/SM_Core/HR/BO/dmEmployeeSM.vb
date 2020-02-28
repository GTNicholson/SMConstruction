Public Class dmEmployeeSM : Inherits RTIS.ERPCore.dmEmployee
  Private pEmployeeRateOfPays As colEmployeeRateOfPays
  Private pEmployeeRateOfPay As dmEmployeeRateOfPay

  Public Sub New()
    MyBase.New
  End Sub

  Protected Overrides Sub NewSetup()
    MyBase.NewSetup()
    pEmployeeRateOfPays = New colEmployeeRateOfPays
    pEmployeeRateOfPay = New dmEmployeeRateOfPay
  End Sub

  Public Property EmployeeRateOfPays As colEmployeeRateOfPays
    Get
      Return pEmployeeRateOfPays
    End Get
    Set(value As colEmployeeRateOfPays)
      pEmployeeRateOfPays = value
    End Set
  End Property

  Public Property EmployeeRateOfPay As dmEmployeeRateOfPay
    Get
      pEmployeeRateOfPay.EmployeeID = EmployeeID
      Return pEmployeeRateOfPay
    End Get
    Set(value As dmEmployeeRateOfPay)
      pEmployeeRateOfPay = value
    End Set
  End Property

End Class
