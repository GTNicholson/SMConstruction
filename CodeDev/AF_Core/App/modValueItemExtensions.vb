Imports RTIS.CommonVB
Imports System.Runtime.CompilerServices
Imports System.Linq
Imports System.ComponentModel

Public Module modValueItemExtensions

  <Extension()>
  Public Function OrderByDesc(ByVal vRefLists As colValueItems) As colValueItems
    Dim mValueItems As New colValueItems

    Dim mList As New BindingList(Of clsValueItem)(CType(vRefLists, BindingList(Of clsValueItem)).OrderBy(Function(p) p.DisplayValue).ToList)

    For Each mItem As clsValueItem In mList
      mValueItems.Add(mItem)
    Next

    Return mValueItems
  End Function

  <Extension()>
  Public Function DisplayValueToObjectCaseInsensitive(ByRef rValueItems As colValueItems, ByVal vDisplayValue As String) As clsValueItem
    Dim mItemIndex As Integer = -1
    mItemIndex = DisplayValueIndexCaseInsensitive(rValueItems, vDisplayValue)
    If mItemIndex > -1 Then
      Return rValueItems(mItemIndex)
    Else
      Return Nothing
    End If
  End Function

  <Extension()>
  Public Function DisplayValueIndexCaseInsensitive(ByRef rValueItems As colValueItems, ByVal vDisplayValue As String) As Integer 'V11.5a patch Replaced with ItemValueIndex
    Dim mValueItem As clsValueItem
    Dim mRetVal As Integer = -1
    Dim mCount As Integer = -1

    If Not String.IsNullOrEmpty(vDisplayValue) Then
      For Each mValueItem In rValueItems
        mCount += 1
        If mValueItem.DisplayValue.Trim.ToUpper = vDisplayValue.Trim.ToUpper Then
          mRetVal = mCount
          Exit For
        End If
      Next
    End If

    Return mRetVal

  End Function


  <Extension()>
  Public Function StartsWithDisplayValueIndexCaseInsensitive(ByRef rValueItems As colValueItems, ByVal vDisplayValue As String) As Integer 'V11.5a patch Replaced with ItemValueIndex
    Dim mValueItem As clsValueItem
    Dim mRetVal As Integer = -1
    Dim mCount As Integer = -1

    For Each mValueItem In rValueItems
      mCount += 1
      If vDisplayValue.Trim.ToUpper.StartsWith(mValueItem.DisplayValue.Trim.ToUpper) Then
        mRetVal = mCount
        Exit For
      End If
    Next

    Return mRetVal

  End Function

End Module
