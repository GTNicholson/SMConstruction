Public MustInherit Class clsStockItemCategoryBase : Inherits RTIS.CommonVB.clsPropertyENUM

  Public Enum eStockItemPropertyBehaviour
    Read_Write = 1
    Read_Only = 2
    Hidden = 3
  End Enum

  Public Sub New(vPropertyENUM, vDescription)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

  Public Overridable ReadOnly Property MaterialRefListID As Integer
    Get
      Return 0
    End Get
  End Property

  Public Overridable ReadOnly Property FinishRefListID As Integer
    Get
      Return 0
    End Get
  End Property


  Public MustOverride Function GetStockCode(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

  Public MustOverride Function GetDescription(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

  Public Overridable Function GetSpeciesDesc(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

    Return ""

  End Function

  Public Overridable Function GetItemTypeDesc(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

    Return ""

  End Function
  Public Overridable Function GetSubItemTypeDesc(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

    Return ""

  End Function


  Public Overridable ReadOnly Property SubItemType As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overridable ReadOnly Property ThicknessBehaviour As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overridable ReadOnly Property ItemTypeBehaviour As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overridable ReadOnly Property SpeciesBehaviour As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overridable Function GetThickness(ByVal vStockItem As RTIS.ERPStock.intStockItemDef) As Decimal
    Return vStockItem.Thickness
  End Function

  Public Overridable Function GetDimentionsText(ByVal vStockItem As RTIS.ERPStock.intStockItemDef) As String
    Dim mRetVal As String = String.Empty
    Dim mWidthDesc As String = String.Empty
    Dim mLengthDesc As String = String.Empty

    If vStockItem IsNot Nothing Then



      If vStockItem.Width <> 0 Then mRetVal &= vStockItem.Width.ToString("0.#")
      If vStockItem.Length <> 0 Then
        If vStockItem.Width <> 0 Then mRetVal &= "x"
        mRetVal &= vStockItem.Length.ToString("0.#")
      End If
      If vStockItem.Thickness <> 0 Then
        If mRetVal <> String.Empty Then mRetVal &= "x"
        mRetVal &= vStockItem.Thickness.ToString("0.#")
      End If


    End If
    If mRetVal <> String.Empty Then mRetVal &= "mm"

    Return mRetVal
  End Function
End Class

Public Class eStockItemCategoryEnums : Inherits RTIS.CommonVB.colPropertyENUMOfT(Of clsStockItemCategoryBase)
  Public Const cUndefined = 0
  Public Const PinturaYQuimico = 10


  Private Shared mSharedInstance As eStockItemCategoryEnums


  Public Sub New()

    Me.Add(New clsStockItemCategoryGeneral(cUndefined, ""))
    Me.Add(New clsStockItemCategoryPinturaYQuimico(PinturaYQuimico, "Pinturas y Quimicos"))


  End Sub

  Public Shared Function GetInstance() As eStockItemCategoryEnums
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemCategoryEnums
    End If
    Return mSharedInstance
  End Function

  Public Function ItemFromCategory(ByVal vCategory As Byte) As clsStockItemCategoryBase
    Dim mRetVal As clsStockItemCategoryBase

    For Each mItem In Me.Items

      If mItem.PropertyENUM = vCategory Then
        mRetVal = mItem
        Exit For
      End If

    Next

    Return mRetVal
  End Function
End Class

Public Class clsStockItemCategoryGeneral : Inherits clsStockItemCategoryBase

  Public Sub New(vPropertyENUM, vDescription)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

  Public Overrides Function GetStockCode(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String
    Dim mRetVal As String
    mRetVal = rStockItem.StockCode
    Return mRetVal
  End Function

  Public Overrides Function GetDescription(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String
    Dim mRetVal As String
    mRetVal = rStockItem.SIDescription

    Return mRetVal
  End Function




End Class


'----------------------
Public Class clsStockItemCategoryPinturaYQuimico : Inherits clsStockItemCategoryBase

  Public Sub New(vPropertyENUM, vDescription)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

  Public Overrides Function GetItemTypeDesc(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

    Dim mRetVal As String = ""
    Dim mType As clsStockItemTypePintura
    Dim mStockItem As dmStockItem
    mStockItem = CType(rStockItem, dmStockItem)

    mType = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.StockItemType)

    If mType IsNot Nothing Then
      mRetVal = mType.Description
    End If

    Return mRetVal

  End Function

  Public Overrides Function GetSubItemTypeDesc(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String

    Dim mRetVal As String = ""
    Dim mType As clsStockItemTypePintura
    Dim mStockItem As dmStockItem
    mStockItem = CType(rStockItem, dmStockItem)
    Dim mSubItemType As clsStockSubItemTypePintura


    mType = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.StockItemType)

    If mType IsNot Nothing Then

      mSubItemType = mType.StockSubItemTypePinturas.ItemFromKey(mStockItem.SubItemType)

      If mSubItemType IsNot Nothing Then
        mRetVal = mSubItemType.Description
      End If

    End If

      Return mRetVal

  End Function

  Public Overrides Function GetStockCode(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String
    Dim mRetVal As String = ""
    Dim mStockItem As dmStockItem
    mStockItem = CType(rStockItem, dmStockItem)

    Dim mItemType As clsStockItemTypePintura
    Dim mSubItemType As clsStockSubItemTypePintura

    mItemType = eStockItemTypePintura.GetInstance.ItemFromKey(mStockItem.ItemType)


    mRetVal = "PYQ"


    If mItemType IsNot Nothing Then

      mRetVal = mRetVal & "." & mItemType.StockCodeStr

      mSubItemType = mItemType.StockSubItemTypePinturas.ItemFromKey(mStockItem.SubItemType)

      If mSubItemType IsNot Nothing Then
        mRetVal = mRetVal & "." & mSubItemType.StockCodeStr
      End If

    End If

    If mStockItem.DefaultManufacturerID > 0 Then
      Dim mManufacturer As dmStockItemManufacturer

      mManufacturer = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.StockItemManufacturer), colStockItemManufacturers).ItemFromKey(mStockItem.DefaultManufacturerID)

      If mStockItem.Colour <> "" Then
        mRetVal = mRetVal & "." & mStockItem.Colour.Substring(0, 2).ToUpper
      End If

      If mManufacturer IsNot Nothing Then

        mRetVal = mRetVal & "." & mManufacturer.Abbreviation
      End If
    End If



    If mStockItem.PartNo <> "" Then
      mRetVal = mRetVal & "(" & mStockItem.PartNo & ")"
    End If



    Return mRetVal
  End Function

  Public Overrides Function GetDescription(ByRef rStockItem As RTIS.ERPStock.intStockItemDef) As String
    Dim mRetVal As String = ""
    Dim mStockItem As dmStockItem
    mStockItem = CType(rStockItem, dmStockItem)

    Dim mItemType As clsStockItemTypePintura
    Dim mSubItemType As clsStockSubItemTypePintura

    mItemType = eStockItemTypePintura.GetInstance.ItemFromKey(mStockItem.ItemType)





    If mItemType IsNot Nothing Then

      mRetVal = mItemType.Description

      mSubItemType = mItemType.StockSubItemTypePinturas.ItemFromKey(mStockItem.SubItemType)

      If mSubItemType IsNot Nothing Then
        mRetVal = mRetVal & " " & mSubItemType.Description
      End If

    End If

    If mStockItem.DefaultManufacturerID > 0 Then
      Dim mManufacturer As dmStockItemManufacturer

      mManufacturer = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.StockItemManufacturer), colStockItemManufacturers).ItemFromKey(mStockItem.DefaultManufacturerID)


      If mStockItem.Colour <> "" Then
        mRetVal = mRetVal & " color " & mStockItem.Colour
      End If


      If mManufacturer IsNot Nothing Then

        mRetVal = mRetVal & " de " & mManufacturer.Name
      End If
    End If




    If mStockItem.PartNo <> "" Then
      mRetVal = mRetVal & "(" & mStockItem.PartNo & ")"
    End If


    Return mRetVal

  End Function




  Public Overrides ReadOnly Property SubItemType As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overrides ReadOnly Property ItemTypeBehaviour As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Write
    End Get
  End Property

  Public Overrides ReadOnly Property SpeciesBehaviour As eStockItemPropertyBehaviour
    Get
      Return eStockItemPropertyBehaviour.Read_Only
    End Get
  End Property

End Class

'----------------------