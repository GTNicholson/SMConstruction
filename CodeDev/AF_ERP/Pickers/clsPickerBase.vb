Public Class clsPickerBase(Of T)

  Protected pDataSource As Object
  Protected pSelectedObjects As IList(Of T)

  Public Sub New()
    CreateSelectedObjectsCollection()
  End Sub
  '' Private pQtyDictionaries As Object

  '// Add New
  '// Archieve Only
  '// GetItemFromKey 
  '// GetDisplayValueFromKey
  '// Filter Condition
  '// SelectKey
  '// DelSelectKey

  Protected Overridable Sub CreateSelectedObjectsCollection()
    pSelectedObjects = New List(Of T)
  End Sub


  Public Property DataSource As IList(Of T)
    Get
      Return pDataSource
    End Get
    Set(value As IList(Of T))
      pDataSource = value
    End Set
  End Property

  Public Property SelectedObjects As IList(Of T)
    Get
      Return pSelectedObjects
    End Get
    Set(value As IList(Of T))
      pSelectedObjects = value
    End Set
  End Property


End Class


