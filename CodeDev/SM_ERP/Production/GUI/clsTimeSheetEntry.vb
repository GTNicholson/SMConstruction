Imports System.ComponentModel

Public Class clsTimeSheetEntry
  Private pStartTime As DateTime
  Private pTimeSheetEntryStringMonday As String

  Public Property StartTime As DateTime
    Get
      Return pStartTime
    End Get
    Set(value As DateTime)
      pStartTime = value
    End Set
  End Property

  Public Property Monday As String
    Get
      GetTimeSheetEntry(0)
    End Get
    Set(value As String)
      SetTimeSheetEntry(0)
    End Set
  End Property

  Public Property Tuesday As String
    Get
      GetTimeSheetEntry(1)
    End Get
    Set(value As String)
      SetTimeSheetEntry(1)
    End Set
  End Property

  Public Property Wednesday As String
    Get
      GetTimeSheetEntry(2)
    End Get
    Set(value As String)
      SetTimeSheetEntry(2)
    End Set
  End Property

  Public Property Thursday As String
    Get
      GetTimeSheetEntry(3)
    End Get
    Set(value As String)
      SetTimeSheetEntry(3)
    End Set
  End Property

  Public Property Friday As String
    Get
      GetTimeSheetEntry(4)
    End Get
    Set(value As String)
      SetTimeSheetEntry(4)
    End Set
  End Property

  Public Property Saturday As String
    Get
      GetTimeSheetEntry(5)
    End Get
    Set(value As String)
      SetTimeSheetEntry(5)
    End Set
  End Property

  Public Property Sunday As String
    Get
      GetTimeSheetEntry(6)
    End Get
    Set(value As String)
      SetTimeSheetEntry(6)
    End Set
  End Property

  Private Function GetTimeSheetEntry(ByVal vDaysOffSet As Byte) As String

  End Function

  Private Sub SetTimeSheetEntry(ByVal vDaysOffSet As Byte)

  End Sub

End Class

Public Class colTimeSheetEntrys : Inherits BindingList(Of clsTimeSheetEntry)

  Public Function IndexFromTime(ByVal vTime As DateTime) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1

    For Each mTE As clsTimeSheetEntry In Me.Items
      mIndex += 1
      If mTE.StartTime = vTime Then
        mRetVal = mIndex
        Exit For
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromTime(ByVal vTime As DateTime) As clsTimeSheetEntry
    Dim mRetVal As clsTimeSheetEntry = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromTime(vTime)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

End Class