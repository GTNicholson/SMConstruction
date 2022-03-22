''Class Definition - ExcelMapping (to ExcelMapping)'Generated from Table:ExcelMapping
Imports RTIS.CommonVB

Public Class dmExcelMapping : Inherits dmBase
  Private pExcelMappingID As Int32
  Private pImportTypeID As Int32
  Private pColumnID As Int32
  Private pCellValue As String
  Private pTranslationValue As Integer
  Private pAdditionalText As String
  Private pTranslationText As String
  Private pColumnHeading As String
  Private pRefListID As Int32

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ExcelMappingID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmExcelMapping)
      .ExcelMappingID = ExcelMappingID
      .ImportTypeID = ImportTypeID
      .ColumnID = ColumnID
      .CellValue = CellValue
      .TranslationValue = TranslationValue
      .AdditionalText = AdditionalText
      .TranslationText = TranslationText
      .ColumnHeading = ColumnHeading
      .RefListID = RefListID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ExcelMappingID() As Int32
    Get
      Return pExcelMappingID
    End Get
    Set(ByVal value As Int32)
      If pExcelMappingID <> value Then IsDirty = True
      pExcelMappingID = value
    End Set
  End Property

  Public Property ImportTypeID() As Int32
    Get
      Return pImportTypeID
    End Get
    Set(ByVal value As Int32)
      If pImportTypeID <> value Then IsDirty = True
      pImportTypeID = value
    End Set
  End Property

  Public Property ColumnID() As Int32
    Get
      Return pColumnID
    End Get
    Set(ByVal value As Int32)
      If pColumnID <> value Then IsDirty = True
      pColumnID = value
    End Set
  End Property

  Public Property CellValue() As String
    Get
      Return pCellValue
    End Get
    Set(ByVal value As String)
      If pCellValue <> value Then IsDirty = True
      pCellValue = value
    End Set
  End Property

  Public Property TranslationValue() As Integer
    Get
      Return pTranslationValue
    End Get
    Set(ByVal value As Integer)
      If pTranslationValue <> value Then IsDirty = True
      pTranslationValue = value
    End Set
  End Property

  Public Property AdditionalText() As String
    Get
      Return pAdditionalText
    End Get
    Set(ByVal value As String)
      If pAdditionalText <> value Then IsDirty = True
      pAdditionalText = value
    End Set
  End Property

  Public Property TranslationText() As String
    Get
      Return pTranslationText
    End Get
    Set(ByVal value As String)
      If pTranslationText <> value Then IsDirty = True
      pTranslationText = value
    End Set
  End Property

  Public Property ColumnHeading() As String
    Get
      Return pColumnHeading
    End Get
    Set(ByVal value As String)
      If pColumnHeading <> value Then IsDirty = True
      pColumnHeading = value
    End Set
  End Property

  Public Property RefListID() As Int32
    Get
      Return pRefListID
    End Get
    Set(ByVal value As Int32)
      If pRefListID <> value Then IsDirty = True
      pRefListID = value
    End Set
  End Property

End Class



''Collection Definition - ExcelMapping (to ExcelMapping)'Generated from Table:ExcelMapping

'Private pExcelMappings As colExcelMappings
'Public Property ExcelMappings() As colExcelMappings
'  Get
'    Return pExcelMappings
'  End Get
'  Set(ByVal value As colExcelMappings)
'    pExcelMappings = value
'  End Set
'End Property

'  pExcelMappings = New colExcelMappings 'Add to New
'  pExcelMappings = Nothing 'Add to Finalize
'  .ExcelMappings = ExcelMappings.Clone 'Add to CloneTo
'  ExcelMappings.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ExcelMappings.IsDirty 'Add to IsAnyDirty

Public Class colExcelMappings : Inherits colBase(Of dmExcelMapping)

  Public Overrides Function IndexFromKey(ByVal vExcelMappingID As Integer) As Integer
    Dim mItem As dmExcelMapping
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 10
      If mItem.ExcelMappingID = vExcelMappingID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
    Me.TrackDeleted = True
  End Sub

  Public Sub New(ByVal vList As List(Of dmExcelMapping))
    MyBase.New(vList)
    Me.TrackDeleted = True
  End Sub

  Public Function IndexFromCellValue(ByVal vColumnID As Integer, ByVal vCellValue As String) As Integer


    For mIndex As Integer = 0 To MyBase.Count - 1
      Dim mItem As dmExcelMapping = MyBase.Items(mIndex)

      If mItem.CellValue = vCellValue AndAlso mItem.ColumnID = vColumnID Then Return mIndex
    Next

    Return -1
  End Function


  Public Function Translate(ByVal vRefListID As Integer, ByVal vCellValue As String) As String
    Dim mRetVal As String = ""

    mRetVal = vCellValue
    For mIndex As Integer = 0 To MyBase.Count - 1
      Dim mItem As dmExcelMapping = MyBase.Items(mIndex)

      If mItem.CellValue = vCellValue AndAlso mItem.RefListID = vRefListID Then
        mRetVal = mItem.TranslationText
        Exit For
      End If
    Next

    Return mRetVal
  End Function

End Class





