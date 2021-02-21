''DTO Definition - PurchaseOrderItem (to PurchaseOrderItem)'Generated from Table:PurchaseOrderItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPurchaseOrderItem : Inherits dtoBase
  Private pPurchaseOrderItem As dmPurchaseOrderItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PurchaseOrderItem"
    pKeyFieldName = "PurchaseOrderItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPurchaseOrderItem.PurchaseOrderItemID
    End Get
    Set(ByVal value As Integer)
      pPurchaseOrderItem.PurchaseOrderItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPurchaseOrderItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPurchaseOrderItem.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PurchaseOrderItemID", pPurchaseOrderItem.PurchaseOrderItemID)
    End If
    With pPurchaseOrderItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseOrderID", .PurchaseOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PartNo", StringToDBValue(.PartNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPrice", .UnitPrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PricingMethod", .PricingMethod)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PricingUnit", .PricingUnit)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Length", .Length)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Width", .Width)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Thickness", .Thickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LineNumber", .LineNumber)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemPartID", .StockItemPartID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CoCType", .CoCType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyRequired", .QtyRequired)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierCode", StringToDBValue(.SupplierCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NominalAccountCode", StringToDBValue(.NominalAccountCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NominalCostCentre", StringToDBValue(.NominalCostCentre))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatRateCode", .VatRateCode)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VatValue", .VatValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AverageInvoicePrice", .AverageInvoicePrice)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Density", .Density)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickedQty", .PickedQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", .UoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RetentionValue", .RetentionValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Substage", .Substage)

      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPurchaseOrderItem Is Nothing Then SetObjectToNew()
      With pPurchaseOrderItem
        .PurchaseOrderItemID = DBReadInt32(rDataReader, "PurchaseOrderItemID")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Status = DBReadByte(rDataReader, "Status")
        .Description = DBReadString(rDataReader, "Description")
        .PartNo = DBReadString(rDataReader, "PartNo")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .PricingMethod = DBReadByte(rDataReader, "PricingMethod")
        .PricingUnit = DBReadByte(rDataReader, "PricingUnit")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .LineNumber = DBReadInt32(rDataReader, "LineNumber")
        .StockItemPartID = DBReadInt32(rDataReader, "StockItemPartID")
        .CoCType = DBReadByte(rDataReader, "CoCType")
        .QtyRequired = DBReadDecimal(rDataReader, "QtyRequired")
        .SupplierCode = DBReadString(rDataReader, "SupplierCode")
        .NominalAccountCode = DBReadString(rDataReader, "NominalAccountCode")
        .NominalCostCentre = DBReadString(rDataReader, "NominalCostCentre")
        .VatRateCode = DBReadByte(rDataReader, "VatRateCode")
        .VatValue = DBReadDecimal(rDataReader, "VatValue")
        .Notes = DBReadString(rDataReader, "Notes")
        .AverageInvoicePrice = DBReadDecimal(rDataReader, "AverageInvoicePrice")
        .Density = DBReadDecimal(rDataReader, "Density")
        .PickedQty = DBReadDecimal(rDataReader, "PickedQty")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .UoM = DBReadInt32(rDataReader, "UoM")
        .RetentionValue = DBReadDecimal(rDataReader, "RetentionValue")
        .Substage = DBReadInt32(rDataReader, "Substage")
        pPurchaseOrderItem.IsDirty = False
      End With
      mOK = True
    Catch Ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      ' or raise an error ?
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pPurchaseOrderItem = New dmPurchaseOrderItem ' Or .NewBlankPurchaseOrderItem
    Return pPurchaseOrderItem

  End Function


  Public Function LoadPurchaseOrderItem(ByRef rPurchaseOrderItem As dmPurchaseOrderItem, ByVal vPurchaseOrderItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPurchaseOrderItemID)
    If mOK Then
      rPurchaseOrderItem = pPurchaseOrderItem
    Else
      rPurchaseOrderItem = Nothing
    End If
    pPurchaseOrderItem = Nothing
    Return mOK
  End Function


  Public Function SavePurchaseOrderItem(ByRef rPurchaseOrderItem As dmPurchaseOrderItem) As Boolean
    Dim mOK As Boolean
    pPurchaseOrderItem = rPurchaseOrderItem
    mOK = SaveObject()
    pPurchaseOrderItem = Nothing
    Return mOK
  End Function


  Public Function LoadPurchaseOrderItemCollection(ByRef rPurchaseOrderItems As colPurchaseOrderItems, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
    mOK = MyBase.LoadCollection(rPurchaseOrderItems, mParams, "PurchaseOrderItemID")
    rPurchaseOrderItems.TrackDeleted = True
    If mOK Then rPurchaseOrderItems.IsDirty = False
    Return mOK
  End Function


  Public Function SavePurchaseOrderItemCollection(ByRef rCollection As colPurchaseOrderItems, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PurchaseOrderID", vPurchaseOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPurchaseOrderItem In rCollection
      ''    If pPurchaseOrderItem.PurchaseOrderItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPurchaseOrderItem.PurchaseOrderItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPurchaseOrderItem In rCollection.DeletedItems
          If pPurchaseOrderItem.PurchaseOrderItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPurchaseOrderItem.PurchaseOrderItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPurchaseOrderItem In rCollection
        If pPurchaseOrderItem.IsDirty Or pPurchaseOrderItem.PurchaseOrderID <> vPurchaseOrderID Or pPurchaseOrderItem.PurchaseOrderItemID = 0 Then 'Or pPurchaseOrderItem.PurchaseOrderItemID = 0
          pPurchaseOrderItem.PurchaseOrderID = vPurchaseOrderID
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

End Class



