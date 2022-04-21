
Public Class clsPropertyDefSort

  Public Shared Function SortPropertyDefItems() As IComparer(Of RTIS.ProductCore.clsPropertyDef)
    Return CType(New clsPropertyDefItemSorter, IComparer(Of RTIS.ProductCore.clsPropertyDef))
  End Function

End Class

Public Class clsPropertyDefItemSorter
  Implements System.Collections.Generic.IComparer(Of RTIS.ProductCore.clsPropertyDef)

  'Dim lngCompType As Integer

  'Sub New(ByVal xlngCompType As Integer)
  '  lngCompType = xlngCompType
  'End Sub

  Public Function Compare(ByVal x As RTIS.ProductCore.clsPropertyDef, ByVal y As RTIS.ProductCore.clsPropertyDef) As Integer Implements System.Collections.Generic.IComparer(Of RTIS.ProductCore.clsPropertyDef).Compare

    If x.PropertyName > y.PropertyName Then
      Return 1
    ElseIf x.PropertyName < y.PropertyName Then
      Return -1
    End If

  End Function

End Class

