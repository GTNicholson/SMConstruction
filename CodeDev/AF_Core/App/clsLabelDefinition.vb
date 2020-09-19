''Class Definition - LabelDefinition (to LabelDefinition)'Generated from Table:LabelDefinition
Imports System.ComponentModel

Public Class clsLabelDefinition
  Implements ICloneable
  Implements RTIS.CommonVB.iValueItem

  Private pIsDirty As Boolean
  Private pLabelDefinitionID As Int32
  Private pLabelDefName As String
  Private pReportLabelType As Integer
  Private pTopMargin As Decimal
  Private pLeftMargin As Decimal
  Private pLabelHeight As Decimal
  Private pLabelWidth As Decimal
  Private pPrintHeight As Decimal
  Private pPrintWidth As Decimal
  Private pNoOfColumns As Decimal
  Private pNoOfRows As Decimal
  Private pPageHeight As Decimal
  Private pPageWidth As Decimal
  Private pPrinterName As String

  Public Sub New()
    MyBase.new()
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Property IsDirty() As Boolean
    Get
      IsDirty = pIsDirty
    End Get
    Set(ByVal value As Boolean)
      pIsDirty = value
    End Set
  End Property

  Public Sub ClearKeys()
    'Set Key Values = 0
  End Sub

  Public Function Clone() As Object Implements System.ICloneable.Clone
    Dim mItem As New clsLabelDefinition
    CloneTo(mItem)
    Return mItem
  End Function

  Protected Sub CloneTo(ByRef rNewItem As clsLabelDefinition)
    With rNewItem
      .LabelDefinitionID = LabelDefinitionID
      .LabelDefName = LabelDefName
      .ReportLabelType = ReportLabelType
      .TopMargin = TopMargin
      .LeftMargin = LeftMargin
      .LabelHeight = LabelHeight
      .LabelWidth = LabelWidth
      .PrintHeight = PrintHeight
      .PrintWidth = PrintWidth
      .PageHeight = PageHeight
      .PageWidth = PageWidth
      .NoOfColumns = NoOfColumns
      .NoOfRows = NoOfRows
      .PrinterName = PrinterName
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property LabelDefinitionID() As Int32
    Get
      LabelDefinitionID = pLabelDefinitionID
    End Get
    Set(ByVal value As Int32)
      If pLabelDefinitionID <> value Then IsDirty = True
      pLabelDefinitionID = value
    End Set
  End Property

  Public Property LabelDefName() As String
    Get
      LabelDefName = pLabelDefName
    End Get
    Set(ByVal value As String)
      If pLabelDefName <> value Then IsDirty = True
      pLabelDefName = value
    End Set
  End Property

  Public Property PrinterName() As String
    Get
      Return pPrinterName
    End Get
    Set(ByVal value As String)
      If pPrinterName <> value Then IsDirty = True
      pPrinterName = value
    End Set
  End Property

  Public Property ReportLabelType() As Integer
    Get
      Return pReportLabelType
    End Get
    Set(ByVal value As Integer)
      If pReportLabelType <> value Then IsDirty = True
      pReportLabelType = value
    End Set
  End Property

  Public Property TopMargin() As Decimal
    Get
      TopMargin = pTopMargin
    End Get
    Set(ByVal value As Decimal)
      If pTopMargin <> value Then IsDirty = True
      pTopMargin = value
    End Set
  End Property

  Public Property LeftMargin() As Decimal
    Get
      LeftMargin = pLeftMargin
    End Get
    Set(ByVal value As Decimal)
      If pLeftMargin <> value Then IsDirty = True
      pLeftMargin = value
    End Set
  End Property

  Public Property LabelHeight() As Decimal
    Get
      LabelHeight = pLabelHeight
    End Get
    Set(ByVal value As Decimal)
      If pLabelHeight <> value Then IsDirty = True
      pLabelHeight = value
    End Set
  End Property

  Public Property LabelWidth() As Decimal
    Get
      LabelWidth = pLabelWidth
    End Get
    Set(ByVal value As Decimal)
      If pLabelWidth <> value Then IsDirty = True
      pLabelWidth = value
    End Set
  End Property

  Public Property PrintHeight() As Decimal
    Get
      PrintHeight = pPrintHeight
    End Get
    Set(ByVal value As Decimal)
      If pPrintHeight <> value Then IsDirty = True
      pPrintHeight = value
    End Set
  End Property

  Public Property PrintWidth() As Decimal
    Get
      PrintWidth = pPrintWidth
    End Get
    Set(ByVal value As Decimal)
      If pPrintWidth <> value Then IsDirty = True
      pPrintWidth = value
    End Set
  End Property

  Public Property PageHeight() As Decimal
    Get
      Return pPageHeight
    End Get
    Set(ByVal value As Decimal)
      If pPageHeight <> value Then IsDirty = True
      pPageHeight = value
    End Set
  End Property

  Public Property PageWidth() As Decimal
    Get
      Return pPageWidth
    End Get
    Set(ByVal value As Decimal)
      If pPageWidth <> value Then IsDirty = True
      pPageWidth = value
    End Set
  End Property

  Public Property NoOfColumns() As Decimal
    Get
      NoOfColumns = pNoOfColumns
    End Get
    Set(ByVal value As Decimal)
      If pNoOfColumns <> value Then IsDirty = True
      pNoOfColumns = value
    End Set
  End Property

  Public Property NoOfRows() As Decimal
    Get
      NoOfRows = pNoOfRows
    End Get
    Set(ByVal value As Decimal)
      If pNoOfRows <> value Then IsDirty = True
      pNoOfRows = value
    End Set
  End Property


  Public Property ArchiveOnly() As Boolean Implements RTIS.CommonVB.iValueItem.ArchiveOnly
    Get

    End Get
    Set(ByVal value As Boolean)

    End Set
  End Property

  Public Property DisplayValue() As String Implements RTIS.CommonVB.iValueItem.DisplayValue
    Get
      Return pLabelDefName
    End Get
    Set(ByVal value As String)

    End Set
  End Property

  Public Property ItemValue() As Integer Implements RTIS.CommonVB.iValueItem.ItemValue
    Get
      Return pLabelDefinitionID
    End Get
    Set(ByVal value As Integer)

    End Set
  End Property
End Class



''Collection Definition - LabelDefinition (to LabelDefinition)'Generated from Table:LabelDefinition

'Private pLabelDefinitions As colLabelDefinitions
'Public Property LabelDefinitions() As colLabelDefinitions
'  Get
'    LabelDefinitions = pLabelDefinitions
'  End Get
'  Set(ByVal value As colLabelDefinitions)
'    pLabelDefinitions = value
'  End Set
'End Property

'  pLabelDefinitions = New colLabelDefinitions 'Add to New
'  pLabelDefinitions = Nothing 'Add to Finalize
'  .LabelDefinitions = LabelDefinitions.Clone 'Add to Clone
'  LabelDefinitions.ClearKeys 'Add to ClearKeys
'Public ReadOnly Property IsAnyDirty() As Boolean
'  Get
'    Dim mAnyDirty = IsDirty
'    If Not mAnyDirty Then mAnyDirty = LabelDefinitions.IsDirty
'    IsAnyDirty = mAnyDirty
'  End Get
'End Property

Public Class colLabelDefinitions : Inherits BindingList(Of clsLabelDefinition)

  Implements ICloneable
  Private pIsDirty As Boolean
  Private pSomeDeleted As Boolean
  Private pSomeRemoved As Boolean
  Private pDeletedItems As Collection

  Public Sub New()
    MyBase.AllowNew = True
  End Sub

  Protected Overrides Function AddNewCore() As Object
    Dim mclsNew As New clsLabelDefinition
    MyBase.Items.Add(mclsNew)
    IsDirty = True
    Return mclsNew
  End Function

  Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As clsLabelDefinition)
    MyBase.InsertItem(index, item)
    IsDirty = True
  End Sub

  Protected Overrides Sub ClearItems()
    If MyBase.Count > 0 Then SomeRemoved = True
    MyBase.ClearItems()
    If Not pDeletedItems Is Nothing Then pDeletedItems.Clear()
  End Sub

  Protected Overrides Sub RemoveItem(ByVal index As Integer)
    MyBase.RemoveItem(index)
    IsDirty = True
    SomeRemoved = True
  End Sub

  Public Sub DeleteItem(ByVal index As Integer)
    Dim mItem As clsLabelDefinition
    mItem = MyBase.Items(index)
    If pDeletedItems Is Nothing Then pDeletedItems = New Collection
    pDeletedItems.Add(mItem)
    SomeDeleted = True
    MyBase.RemoveItem(index)
    SomeRemoved = True
  End Sub

  Protected Overrides Sub SetItem(ByVal index As Integer, ByVal item As clsLabelDefinition)
    MyBase.SetItem(index, item)
    IsDirty = True
  End Sub

  Public Property DeletedItems() As Collection
    Get
      DeletedItems = pDeletedItems
    End Get
    Set(ByVal value As Collection)
      pDeletedItems = value
    End Set
  End Property

  Public Function Clone() As Object Implements System.ICloneable.Clone
    Dim mCol As New colLabelDefinitions
    Dim mItem As clsLabelDefinition
    For Each mItem In MyBase.Items
      mCol.Add(CType(mItem.Clone, clsLabelDefinition))
    Next
    mCol.IsDirty = IsDirty
    mCol.SomeRemoved = SomeRemoved
    mCol.SomeDeleted = SomeDeleted
    mCol.DeletedItems = DeletedItems
    Return mCol
  End Function

  Public Sub ClearKeys()
    Dim mItem As clsLabelDefinition
    For Each mItem In MyBase.Items
      mItem.ClearKeys()
    Next
    IsDirty = True
  End Sub

  Public Property IsDirty() As Boolean
    Get
      Dim mItem As clsLabelDefinition
      IsDirty = pIsDirty
      If Not IsDirty Then
        For Each mItem In MyBase.Items
          If mItem.IsDirty Then
            IsDirty = True
            Exit For
          End If
        Next
      End If
    End Get
    Set(ByVal value As Boolean)
      pIsDirty = value
    End Set
  End Property

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

  Public Property ItemFromKey(ByVal vLabelDefinitionID As Integer) As clsLabelDefinition
    Get
      Return MyBase.Items(IndexFromKey(vLabelDefinitionID))
    End Get
    Set(ByVal value As clsLabelDefinition)
      MyBase.Items(IndexFromKey(vLabelDefinitionID)) = value
    End Set
  End Property

  Public Function IndexFromKey(ByVal vLabelDefinitionID As Integer) As Integer
    Dim mItem As clsLabelDefinition
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.LabelDefinitionID = vLabelDefinitionID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function IndexFromReportLabelType(ByVal vReportLabelType As Integer) As Integer
    Dim mItem As clsLabelDefinition
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ReportLabelType = vReportLabelType Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function
End Class
