''DTO Definition - ProductFurnitureOperation (to ProductFurnitureOperation)'Generated from Table:ProductFurnitureOperation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductFurnitureOperation : Inherits dtoBase
  Private pProductFurnitureOperation As dmProductFurnitureOperation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductFurnitureOperation"
    pKeyFieldName = "ProductFurnitureOperationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductFurnitureOperation.ProductFurnitureOperationID
    End Get
    Set(ByVal value As Integer)
      pProductFurnitureOperation.ProductFurnitureOperationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductFurnitureOperation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductFurnitureOperation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductFurnitureOperationID", pProductFurnitureOperation.ProductFurnitureOperationID)
    End If
    With pProductFurnitureOperation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductfurnitureID", .ProductfurnitureID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkCenterID", .WorkCenterID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EstimatedHours", .EstimatedHours)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyOfOperators", .QtyOfOperators)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductFurnitureOperation Is Nothing Then SetObjectToNew()
      With pProductFurnitureOperation
        .ProductFurnitureOperationID = DBReadInt32(rDataReader, "ProductFurnitureOperationID")
        .ProductfurnitureID = DBReadInt32(rDataReader, "ProductfurnitureID")
        .WorkCenterID = DBReadInt32(rDataReader, "WorkCenterID")
        .Description = DBReadString(rDataReader, "Description")
        .EstimatedHours = DBReadDouble(rDataReader, "EstimatedHours")
        .QtyOfOperators = DBReadInt32(rDataReader, "QtyOfOperators")
        pProductFurnitureOperation.IsDirty = False
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
    pProductFurnitureOperation = New dmProductFurnitureOperation ' Or .NewBlankProductFurnitureOperation
    Return pProductFurnitureOperation

  End Function


  Public Function LoadProductFurnitureOperation(ByRef rProductFurnitureOperation As dmProductFurnitureOperation, ByVal vProductFurnitureOperationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductFurnitureOperationID)
    If mOK Then
      rProductFurnitureOperation = pProductFurnitureOperation
    Else
      rProductFurnitureOperation = Nothing
    End If
    pProductFurnitureOperation = Nothing
    Return mOK
  End Function


  Public Function SaveProductFurnitureOperation(ByRef rProductFurnitureOperation As dmProductFurnitureOperation) As Boolean
    Dim mOK As Boolean
    pProductFurnitureOperation = rProductFurnitureOperation
    mOK = SaveObject()
    pProductFurnitureOperation = Nothing
    Return mOK
  End Function


  Public Function LoadProductFurnitureOperationCollection(ByRef rProductFurnitureOperations As colProductFurnitureOperations, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductFurnitureOperations, mParams, "ProductFurnitureOperationID")
    rProductFurnitureOperations.TrackDeleted = True
    If mOK Then rProductFurnitureOperations.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductFurnitureOperationCollection(ByRef rCollection As colProductFurnitureOperations, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductFurnitureOperation In rCollection
      ''    If pProductFurnitureOperation.ProductFurnitureOperationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductFurnitureOperation.ProductFurnitureOperationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductFurnitureOperation In rCollection.DeletedItems
          If pProductFurnitureOperation.ProductFurnitureOperationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductFurnitureOperation.ProductFurnitureOperationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductFurnitureOperation In rCollection
        If pProductFurnitureOperation.IsDirty Or pProductFurnitureOperation.ProductfurnitureID <> vParentID Or pProductFurnitureOperation.ProductFurnitureOperationID = 0 Then 'Or pProductFurnitureOperation.ProductFurnitureOperationID = 0
          pProductFurnitureOperation.ProductfurnitureID = vParentID
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