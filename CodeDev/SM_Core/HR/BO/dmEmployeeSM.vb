Public Class dmEmployeeSM : Inherits RTIS.ERPCore.dmEmployee
  Private pEmployeeRateOfPays As colEmployeeRateOfPays

  Public Sub New()
    MyBase.New
  End Sub

  Protected Overrides Sub NewSetup()
    MyBase.NewSetup()
    pEmployeeRateOfPays = New colEmployeeRateOfPays
  End Sub

  Public Property EmployeeRateOfPays As colEmployeeRateOfPays
    Get
      Return pEmployeeRateOfPays
    End Get
    Set(value As colEmployeeRateOfPays)
      pEmployeeRateOfPays = value
    End Set
  End Property

End Class
