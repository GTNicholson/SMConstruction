Public Class clsProductCostBookEntryEditor

  Private pProductBase As dmProductBase
  Private pProductCostBookEntry As dmProductCostBookEntry
  Private Shared sRefLists As appRefLists

  Public Sub New()
    pProductCostBookEntry = New dmProductCostBookEntry


    If sRefLists Is Nothing Then
      sRefLists = AppRTISGlobal.GetInstance.RefLists
    End If

  End Sub


  Public Property ProductBase As dmProductBase
    Get
      Return pProductBase
    End Get
    Set(value As dmProductBase)
      pProductBase = value
    End Set
  End Property

  Public Property ProductCostBookEntry As dmProductCostBookEntry
    Get
      Return pProductCostBookEntry
    End Get
    Set(value As dmProductCostBookEntry)
      pProductCostBookEntry = value
    End Set
  End Property

  Public Property Cost As Decimal
    Get
      pProductCostBookEntry.Cost = pProductCostBookEntry.DirectLabourCost + pProductCostBookEntry.DirectMaterialCost + pProductCostBookEntry.DirectTransportationAndEquipment + pProductCostBookEntry.OutsourcingCost

      Return pProductCostBookEntry.Cost
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.Cost = value
    End Set
  End Property

  Public Property CostUnit As Integer
    Get
      Return pProductCostBookEntry.CostUnit
    End Get
    Set(value As Integer)
      pProductCostBookEntry.CostUnit = value
    End Set
  End Property
  Public Property MinCost As Decimal
    Get
      Return pProductCostBookEntry.MinCost
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.MinCost = value
    End Set
  End Property


  Public Property ProductID As Integer
    Get
      Return pProductBase.ID
    End Get
    Set(value As Integer)
      pProductBase.ID = value
    End Set
  End Property

  Public ReadOnly Property ProductCostBookEntryID As Integer
    Get
      Return pProductCostBookEntry.ProductCostBookEntryID
    End Get

  End Property

  Public ReadOnly Property ProductCostBookID As Integer
    Get
      Return pProductCostBookEntry.CostBookID
    End Get

  End Property



  Public Property ProductItemType As Integer
    Get
      Return pProductBase.ItemType
    End Get
    Set(value As Integer)
      pProductBase.ItemType = value
    End Set
  End Property

  Public Property DirectLabourCost As Decimal
    Get
      Dim mRetVal As Decimal
      If pProductCostBookEntry IsNot Nothing Then
        mRetVal = pProductCostBookEntry.DirectLabourCost
      End If
      Return mRetVal
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.DirectLabourCost = value
    End Set
  End Property
  Public Property DirectMaterialCost As Decimal
    Get
      Dim mRetVal As Decimal
      If pProductCostBookEntry IsNot Nothing Then
        mRetVal = pProductCostBookEntry.DirectMaterialCost
      End If
      Return mRetVal
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.DirectMaterialCost = value
    End Set
  End Property
  Public Property DirectTransportationAndEquipment As Decimal
    Get
      Dim mRetVal As Decimal
      If pProductCostBookEntry IsNot Nothing Then
        mRetVal = pProductCostBookEntry.DirectTransportationAndEquipment
      End If
      Return mRetVal
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.DirectTransportationAndEquipment = value
    End Set
  End Property
  Public Property OutsourcingCost As Decimal
    Get
      Dim mRetVal As Decimal
      If pProductCostBookEntry IsNot Nothing Then
        mRetVal = pProductCostBookEntry.OutsourcingCost
      End If
      Return mRetVal
    End Get
    Set(value As Decimal)
      pProductCostBookEntry.OutsourcingCost = value
    End Set
  End Property
  Public ReadOnly Property ProductDescription As String
    Get
      Dim mRetVal As String = ""
      If pProductBase IsNot Nothing Then
        mRetVal = pProductBase.Description
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ProductCode As String
    Get
      Dim mRetVal As String = ""
      If pProductBase IsNot Nothing Then
        mRetVal = pProductBase.Code
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ProductTypeDesc As String
    Get
      Dim mRetVal As String = ""
      If pProductBase IsNot Nothing Then
        mRetVal = sRefLists.RefListVI(appRefLists.ProductConstructionType).DisplayValueString(pProductBase.ItemType)

      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property CostUnitDes As String
    Get
      Dim mRetVal As String = ""
      If pProductCostBookEntry IsNot Nothing Then
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pProductBase.UoM, eUoM))
      End If
      Return mRetVal
    End Get
  End Property

End Class


Public Class colProductCostBookEntryEditors : Inherits List(Of clsProductCostBookEntryEditor)

  Public Function IndexFromProductID(vProductID As Integer) As Integer
    Dim mItem As clsProductCostBookEntryEditor
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.ProductCostBookEntry IsNot Nothing Then
        If mItem.ProductCostBookEntry.ProductID = vProductID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

  Public Function IndexFromProductCostBookEntryID(vProductCostBookEntryID As Integer) As Integer
      Dim mItem As clsProductCostBookEntryEditor
      Dim mIndex As Integer = -1
      Dim mCount As Integer = -1
      For Each mItem In Me
        mCount += 1
        If mItem.ProductCostBookEntry IsNot Nothing Then
          If mItem.ProductCostBookEntry.ProductCostBookEntryID = vProductCostBookEntryID Then
            mIndex = mCount
            Exit For
          End If
        End If
      Next
      Return mIndex
    End Function

    Public Function ItemFromCostBookEntryID(vProductCostBookEntryID As Integer) As clsProductCostBookEntryEditor
      Dim mRetVal As clsProductCostBookEntryEditor = Nothing
      Dim mIndex As Integer

      mIndex = IndexFromProductCostBookEntryID(vProductCostBookEntryID)
      If mIndex <> -1 Then
        mRetVal = Me.Item(mIndex)
      End If
      Return mRetVal
    End Function

  End Class

