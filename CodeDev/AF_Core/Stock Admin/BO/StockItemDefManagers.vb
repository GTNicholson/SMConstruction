Imports RTIS.CommonVB

Public MustInherit Class clsStockItemDefManagerBspk : Inherits StockItemDefManagerBase
  Public Property pStockItemBspk As dmStockItem

  Public Sub New(ByRef rStockItem As dmStockItem)
    MyBase.New(rStockItem)
    pStockItemBspk = rStockItem
  End Sub

  Public Function GetDimsStr() As String
    Dim mRetVal As String = ""
    If pStockItemBspk.Length <> 0 Then
      If mRetVal <> "" Then mRetVal = mRetVal & " x "
      mRetVal = mRetVal & pStockItemBspk.Length.ToString("#.#")
    End If
    If pStockItemBspk.Width <> 0 Then
      If mRetVal <> "" Then mRetVal = mRetVal & " x "
      mRetVal = mRetVal & pStockItemBspk.Width.ToString("#.#")
    End If
    If pStockItemBspk.Thickness <> 0 Then
      If mRetVal <> "" Then mRetVal = mRetVal & " x "
      mRetVal = mRetVal & pStockItemBspk.Thickness.ToString("#.#")
    End If
    Return mRetVal
  End Function

End Class

Public Class clsStockItemDefManagerGeneral : Inherits clsStockItemDefManagerBspk

  Public Sub New(ByRef rStockItem As dmStockItem)
      MyBase.New(rStockItem)
    End Sub

    Public Overrides Function GenerateDescription() As String
      Dim mRetVal As String = ""
      Return mRetVal
    End Function

    Public Overrides Function GenerateStockCode() As String
      Dim mRetVal As String = ""
      Return mRetVal
    End Function

    Public Overrides Function ValidateStockItem() As clsValidate
      Dim mRetVal As New clsValidate
      mRetVal.ValOk = True
      Return mRetVal
    End Function
  End Class

Public Class clsStockItemDefManagerFixings : Inherits clsStockItemDefManagerBspk
  Public Sub New(ByRef rStockItem As dmStockItem)
    MyBase.New(rStockItem)
  End Sub

  Public Overrides Function GenerateDescription() As String
    Dim mRetVal As String = ""
    Dim mType As clsStockItemTypeNailsAndBolts
    Dim mSubType As clsStockSubItemTypeNailsAndBolts = Nothing

    mType = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(pStockItemBspk.ItemType)
    mSubType = mType.StockSubItemTypeNailsAndBolts.ItemFromKey(pStockItemBspk.SubItemType)

    mRetVal = eStockItemTypeNailsAndBolts.GetInstance.DisplayValueFromKey(pStockItem.StockItemType)
    If pStockItem.MaterialID <> 0 Then
      mRetVal = mRetVal & " de " & AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies).ItemValueToDisplayValue(pStockItem.MaterialID)
    End If
    If mSubType IsNot Nothing Then
      mRetVal = mRetVal & " " & mSubType.Description
    End If
    If GetDimsStr() <> "" Then
      mRetVal = mRetVal & " " & GetDimsStr()
    End If
    If pStockItemBspk.AuxCode <> "" Then
      mRetVal = mRetVal & " (" & pStockItemBspk.AuxCode & ")"
    End If
    Return mRetVal
  End Function

  Public Overrides Function GenerateStockCode() As String
    Dim mRetVal As String = ""
    Return mRetVal
  End Function

  Public Overrides Function ValidateStockItem() As clsValidate
    Dim mRetVal As New clsValidate
    mRetVal.ValOk = True
    Return mRetVal
  End Function
End Class


