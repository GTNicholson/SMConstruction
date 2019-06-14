Public Class clsWorkOrderTracking : Inherits clsWorkOrderInfo
  ''Private pWorkOrderInfo As clsWorkOrderInfo
  Private pMileStones As colWorkOrderMilestoneStatuss

  Public Sub New()
    pMileStones = New colWorkOrderMilestoneStatuss
  End Sub

  Public Property MileStones As colWorkOrderMilestoneStatuss
    Get
      Return pMileStones
    End Get
    Set(value As colWorkOrderMilestoneStatuss)
      pMileStones = value
    End Set
  End Property

End Class

''Public Class colWorkOrderTrackings : Inherits List(Of clsWorkOrderTracking)

''End Class
