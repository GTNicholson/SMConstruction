Imports RTIS.DataLayer
Imports RTIS.ProductCore

Public Class clsStockItemPropertyHandler
  Implements RTIS.ProductCore.intObjectProperties

  Private pStockItem As dmStockItem
  Private pRTISGlobal As AppRTISGlobal

  Shared pPropertyList As RTIS.ProductCore.colPropertyDef

  Public Enum ePropertyDefENUM
    None = 0
    Category = 1
    ItemType = 2
    SubItemType = 3
    Species = 4
    Finish = 6
    Length = 7
    Width = 8
    Thickness = 9
  End Enum


  Public Sub New()

  End Sub

  Public Sub New(ByRef rStockItem As dmStockItem, ByRef rRTISGlobal As AppRTISGlobal)

    pStockItem = rStockItem
    pRTISGlobal = rRTISGlobal

  End Sub

  Public Property RTISGlobal() As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(ByVal value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property


  Public Property IntPropDescription() As String Implements RTIS.ProductCore.intObjectProperties.Description
    Get
      IntPropDescription = "StockItem"
    End Get
    Set(ByVal value As String)

    End Set
  End Property

  Public ReadOnly Property MultiplierList() As RTIS.ProductCore.colPropertyDef Implements RTIS.ProductCore.intObjectProperties.MultiplierList
    Get
      MultiplierList = PropertyList.MultiplierList()
    End Get
  End Property

  Public ReadOnly Property ObjectType() As Integer Implements RTIS.ProductCore.intObjectProperties.ObjectType
    Get

    End Get
  End Property

  Public ReadOnly Property PropertyList() As RTIS.ProductCore.colPropertyDef Implements RTIS.ProductCore.intObjectProperties.PropertyList
    Get
      If pPropertyList Is Nothing Then
        pPropertyList = New RTIS.ProductCore.colPropertyDef '? make this a class in it's on right, use singleton, then can se constants like an ENUM ?
        pPropertyList.AddPropertyDef(ePropertyDefENUM.None, "None", GetType(Integer), appRefLists.None, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Category, "Category", GetType(Integer), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.ItemType, "ItemType", GetType(Integer), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.SubItemType, "SubItemType", GetType(Integer), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Species, "Species", GetType(Integer), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Finish, "Finish", GetType(Integer), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Length, "Length", GetType(Decimal), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Width, "Width", GetType(Decimal), appRefLists.None, False)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.Thickness, "Thickness", GetType(Decimal), appRefLists.None, False)
        pPropertyList.Sort(clsPropertyDefSort.SortPropertyDefItems)
      End If

      PropertyList = pPropertyList
    End Get
  End Property

  Public Function PropertyValue(ByVal rPropertyIndex As Integer) As Object Implements RTIS.ProductCore.intObjectProperties.PropertyValue
    Dim mRetValue As Object = Nothing
    Dim mPropDef As clsPropertyDef
    Dim mType As System.Type

    mPropDef = PropertyList.ItemFromRef(rPropertyIndex)

    mType = mPropDef.PropertyType

    Select Case rPropertyIndex
      Case ePropertyDefENUM.None
        mRetValue = 0
      Case ePropertyDefENUM.Category
        mRetValue = pStockItem.Category
      Case ePropertyDefENUM.ItemType
        mRetValue = pStockItem.ItemType
      Case ePropertyDefENUM.SubItemType
        mRetValue = pStockItem.SubItemType
      Case ePropertyDefENUM.Species
        mRetValue = pStockItem.Species
      Case ePropertyDefENUM.Finish
        mRetValue = pStockItem.Finish
      Case ePropertyDefENUM.Length
        mRetValue = pStockItem.Length
      Case ePropertyDefENUM.Width
        mRetValue = pStockItem.Width
      Case ePropertyDefENUM.Thickness
        mRetValue = pStockItem.Thickness
      Case Else
        mRetValue = 0
    End Select

    PropertyValue = mRetValue 'CType(mRetValue, mType
  End Function
End Class
