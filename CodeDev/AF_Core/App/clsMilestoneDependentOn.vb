Public Class clsMilestoneDependentOn
  Private pDependentOnEnum As Integer
  Private pNumberOfDays As Integer
  Private pOverideOnActual As Boolean

  Public Sub New(ByVal vDependentOnEnum As Integer, ByVal vNumberOfDays As Integer, ByVal vOverrideOnActual As Boolean)
    pDependentOnEnum = vDependentOnEnum
    pNumberOfDays = vNumberOfDays
    pOverideOnActual = vOverrideOnActual
  End Sub

  Public Property DependentOnEnum As Integer
    Get
      Return pDependentOnEnum
    End Get
    Set(value As Integer)
      pDependentOnEnum = value
    End Set
  End Property

  Public Property NumberOfDays As Integer
    Get
      Return pNumberOfDays
    End Get
    Set(value As Integer)
      pNumberOfDays = value
    End Set
  End Property

  Public Property OverideOnActual As Boolean
    Get
      Return pOverideOnActual
    End Get
    Set(value As Boolean)
      pOverideOnActual = value
    End Set
  End Property

End Class

Public Class colMilestoneDependentOns : Inherits List(Of clsMilestoneDependentOn)
  Public Function ItemFromEnum(ByVal vEnum As Integer) As clsMilestoneDependentOn
    Dim mRetVal As clsMilestoneDependentOn = Nothing
    For Each mItem As clsMilestoneDependentOn In Me
      If mItem.DependentOnEnum = vEnum Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

End Class