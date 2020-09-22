''DTO Definition - PODelivery (to PODelivery)'Generated from Table:PODelivery

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPODelivery : Inherits dtoBase
  Private pPODelivery As dmPODelivery

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PODelivery"
    pKeyFieldName = "PODeliveryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPODelivery.PODeliveryID
    End Get
    Set(ByVal value As Integer)
      pPODelivery.PODeliveryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPODelivery.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPODelivery.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PODeliveryID", pPODelivery.PODeliveryID)
    End If
    If pPODelivery.PODeliveryID = 0 Then
      pPODelivery.DateCreated = Now
    End If
    With pPODelivery
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PurchaseOrderID", .PurchaseOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "GRNumber", StringToDBValue(.GRNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReceivedDate", DateToDBValue(.ReceivedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comment", StringToDBValue(.Comment))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsSupplierReturn", .IsSupplierReturn)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCreated", DateToDBValue(.DateCreated))
      ''DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReturnReasonID", .ReturnReasonID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ActionRequiredID", .ActionRequiredID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileExport", StringToDBValue(.FileExport))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FullyInvoiced", .FullyInvoiced)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PODeliveryValue", .PODeliveryValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentStatus", .PaymentStatus)
      '' DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierDelNo", StringToDBValue(.SupplierDelNo))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPODelivery Is Nothing Then SetObjectToNew()
      With pPODelivery
        .PODeliveryID = DBReadInt32(rDataReader, "PODeliveryID")
        .PurchaseOrderID = DBReadInt32(rDataReader, "PurchaseOrderID")
        .GRNumber = DBReadString(rDataReader, "GRNumber")
        .ReceivedDate = DBReadDateTime(rDataReader, "ReceivedDate")
        .Comment = DBReadString(rDataReader, "Comment")
        .IsSupplierReturn = DBReadBoolean(rDataReader, "IsSupplierReturn")
        .DateCreated = DBReadDateTime(rDataReader, "DateCreated")
        ''.Status = DBReadByte(rDataReader, "Status")
        .ReturnReasonID = DBReadByte(rDataReader, "ReturnReasonID")
        .ActionRequiredID = DBReadByte(rDataReader, "ActionRequiredID")
        .FileExport = DBReadString(rDataReader, "FileExport")
        .FullyInvoiced = DBReadBoolean(rDataReader, "FullyInvoiced")
        .PODeliveryValue = DBReadDecimal(rDataReader, "PODeliveryValue")
        .PaymentStatus = DBReadInt32(rDataReader, "PaymentStatus")
        '' .SupplierDelNo = DBReadString(rDataReader, "SupplierDelNo")
        ''.MKReference = DBReadString(rDataReader, "MKReference")
        pPODelivery.IsDirty = False
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
    pPODelivery = New dmPODelivery ' Or .NewBlankPODelivery
    Return pPODelivery

  End Function


  Public Function LoadPODelivery(ByRef rPODelivery As dmPODelivery, ByVal vPODeliveryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPODeliveryID)
    If mOK Then
      rPODelivery = pPODelivery
    Else
      rPODelivery = Nothing
    End If
    pPODelivery = Nothing
    Return mOK
  End Function


  Public Function SavePODelivery(ByRef rPODelivery As dmPODelivery) As Boolean
    Dim mOK As Boolean
    pPODelivery = rPODelivery
    mOK = SaveObject()
    pPODelivery = Nothing
    Return mOK
  End Function


  Public Function LoadPODeliveryCollection(ByRef rPODeliverys As colPODeliverys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@POCallOffID", vParentID)
    mOK = MyBase.LoadCollection(rPODeliverys, mParams, "PODeliveryID")
    rPODeliverys.TrackDeleted = True
    If mOK Then rPODeliverys.IsDirty = False
    Return mOK
  End Function


  Public Function SavePODeliveryCollection(ByRef rCollection As colPODeliverys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@POCallOffID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPODelivery In rCollection
      ''    If pPODelivery.PODeliveryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPODelivery.PODeliveryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPODelivery In rCollection.DeletedItems
          If pPODelivery.PODeliveryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPODelivery.PODeliveryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPODelivery In rCollection
        If pPODelivery.IsDirty Or pPODelivery.PurchaseOrderID <> vParentID Or pPODelivery.PODeliveryID = 0 Then 'Or pPODelivery.PODeliveryID = 0
          pPODelivery.PurchaseOrderID = vParentID
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



