Public Class clsClipBoard
  Private pClipObjects As List(Of Object)

  Public Sub New()
    pClipObjects = New List(Of Object)
  End Sub

  Public ReadOnly Property ClipObjects As List(Of Object)
    Get
      Return pClipObjects
    End Get
  End Property

  Public Sub AddObjectToClipBoard(ByRef rObject As Object)
    pClipObjects.Clear()
    pClipObjects.Add(rObject)
  End Sub

  Public Sub AddObjectsToClipBoard(ByRef rObjectList As IList)
    pClipObjects.Clear()
    For Each mItem As Object In rObjectList
      pClipObjects.Add(mItem)
    Next
  End Sub

  Public Sub Clear()
    pClipObjects.Clear()
  End Sub

  Public Function ClipObjectType() As Type
    Dim mRetVal As Type
    If pClipObjects.Count <> 0 Then
      mRetVal = pClipObjects(0).GetType
    Else
      mRetVal = Nothing
    End If
    Return mRetVal
  End Function

End Class
