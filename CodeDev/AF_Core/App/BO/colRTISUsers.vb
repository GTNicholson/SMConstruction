Imports RTIS.DataLayer
Imports System.ComponentModel
Imports RTIS.CommonVB

Public Class colRTISUsers : Inherits BindingList(Of clsRTISUser)
  'Implements ICloneable
  Private pIsDirty As Boolean
  Private pSomeDeleted As Boolean
  Private pSomeRemoved As Boolean
  Private pDeletedItems As Collection

  Public Sub New()
    MyBase.AllowNew = True
  End Sub

  Protected Overrides Function AddNewCore() As Object
    Dim mclsNew As New clsRTISUser
    MyBase.Items.Add(mclsNew)
    'IsDirty = True
    Return mclsNew
  End Function

  Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As clsRTISUser)
    MyBase.InsertItem(index, item)
    'IsDirty = True
  End Sub

  Protected Overrides Sub ClearItems()
    If MyBase.Count > 0 Then SomeRemoved = True
    MyBase.ClearItems()
    pDeletedItems.Clear()
  End Sub

  Protected Overrides Sub RemoveItem(ByVal index As Integer)
    MyBase.RemoveItem(index)
    'IsDirty = True
    SomeRemoved = True
  End Sub

  Public Sub DeleteItem(ByVal index As Integer)
    Dim mItem As clsRTISUser
    mItem = MyBase.Items(index)
    If pDeletedItems Is Nothing Then pDeletedItems = New Collection
    pDeletedItems.Add(mItem)
    SomeDeleted = True
    MyBase.RemoveItem(index)
    SomeRemoved = True
  End Sub

  Protected Overrides Sub SetItem(ByVal index As Integer, ByVal item As clsRTISUser)
    MyBase.SetItem(index, item)
    'IsDirty = True
  End Sub

  Public Property DeletedItems() As Collection
    Get
      DeletedItems = pDeletedItems
    End Get
    Set(ByVal value As Collection)
      pDeletedItems = value
    End Set
  End Property

  ''Public Function Clone() As Object Implements System.ICloneable.Clone
  ''  Dim mCol As New colRTISUsers
  ''  Dim mItem As clsRTISUser
  ''  For Each mItem In MyBase.Items
  ''    mCol.Add(CType(mItem.Clone, clsRTISUser))
  ''  Next
  ''  mCol.IsDirty = IsDirty
  ''  mCol.SomeRemoved = SomeRemoved
  ''  mCol.SomeDeleted = SomeDeleted
  ''  mCol.DeletedItems = DeletedItems
  ''  Return mCol
  ''End Function

  ''Public Sub ClearKeys()
  ''  Dim mItem As clsRTISUser
  ''  For Each mItem In MyBase.Items
  ''    mItem.ClearKeys()
  ''  Next
  ''  IsDirty = True
  ''End Sub

  ''Public ReadOnly Property IsAnyDirty() As Boolean
  ''  Get
  ''    Dim mItem As clsRTISUser
  ''    IsAnyDirty = pIsDirty
  ''    If Not IsAnyDirty Then
  ''      For Each mItem In MyBase.Items
  ''        If mItem.IsAnyDirty Then
  ''          IsAnyDirty = True
  ''          Exit For
  ''        End If
  ''      Next
  ''    End If
  ''  End Get
  ''End Property

  ''Public Property IsDirty() As Boolean
  ''  Get
  ''    Dim mItem As clsRTISUser
  ''    IsDirty = pIsDirty
  ''    If Not IsDirty Then
  ''      For Each mItem In MyBase.Items
  ''        If mItem.IsDirty Then
  ''          IsDirty = True
  ''          Exit For
  ''        End If
  ''      Next
  ''    End If
  ''  End Get
  ''  Set(ByVal value As Boolean)
  ''    pIsDirty = value
  ''  End Set
  ''End Property

  Public Property SomeDeleted() As Boolean
    Get
      SomeDeleted = pSomeDeleted
    End Get
    Set(ByVal value As Boolean)
      pSomeDeleted = value
    End Set
  End Property

  Public Property SomeRemoved() As Boolean
    Get
      SomeRemoved = pSomeRemoved
    End Get
    Set(ByVal value As Boolean)
      pSomeRemoved = value
    End Set
  End Property

  Public Property ItemFromKey(ByVal vUserID As Integer) As clsRTISUser
    Get
      Dim mIndex As Integer = IndexFromKey(vUserID)

      If mIndex > -1 Then
        Return MyBase.Items(mIndex)
      End If

      Return Nothing
    End Get
    Set(ByVal value As clsRTISUser)
      MyBase.Items(IndexFromKey(vUserID)) = value
    End Set
  End Property

  Public Function IndexFromKey(ByVal vUserID As Integer) As Integer
    Dim mItem As clsRTISUser
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.UserID = vUserID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function UserFromEmployeeID(ByVal vID As Integer) As clsRTISUser
    Dim mUser As clsRTISUser
    Dim mRetval As clsRTISUser = Nothing
    For Each mUser In MyBase.Items
      If mUser.EmployeeID = vID Then
        mRetval = mUser
        Exit For
      End If
    Next
    Return mRetval
  End Function

  Public Function UsernameFromKey(ByVal vUserID As Integer) As String
    Dim mRetVal As String = String.Empty

    For Each mUser As clsRTISUser In MyBase.Items
      If mUser.UserID = vUserID Then
        mRetVal = mUser.UserName
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function ToVI() As colValueItems
    Dim mValueItems As New colValueItems

    For Each mItem As clsRTISUser In MyBase.Items
      mValueItems.AddNewItem(mItem.UserID, mItem.UserName)
    Next

    Return mValueItems
  End Function

End Class
