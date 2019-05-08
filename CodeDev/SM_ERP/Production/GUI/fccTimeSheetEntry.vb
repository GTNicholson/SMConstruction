Public Class fccTimeSheetEntry
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Private pWCDate As DateTime
  Private pStartTime As DateTime
  Private pEndTime As DateTime
  Private pEmployee As dmEmployeeSM

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Property WCDate As DateTime
    Get
      Return pWCDate
    End Get
    Set(value As DateTime)
      pWCDate = value
    End Set
  End Property

  Public Property StartTime As DateTime
    Get
      Return pStartTime
    End Get
    Set(value As DateTime)
      pStartTime = value
    End Set
  End Property

  Public Property EndTime As DateTime
    Get
      Return pEndTime
    End Get
    Set(value As DateTime)
      pEndTime = value
    End Set
  End Property

  Public Property Employee As dmEmployeeSM
    Get
      Return pEmployee
    End Get
    Set(value As dmEmployeeSM)
      pEmployee = value
    End Set
  End Property


  Public Sub SetInitialDefaultValues()
    pWCDate = RTIS.CommonVB.libDateTime.MondayOfWeek(Now.Date)
    pStartTime = (New Date).AddHours(6)
    pEndTime = (New Date).AddHours(18)
  End Sub

  Public Sub LoadTimeSheetEntrys()
    Dim mTime As DateTime

    mTime = pStartTime
    Do While mTime <= pEndTime
      mTime = mTime.AddHours(1)
    Loop
  End Sub

End Class
