
''DTO Definition - ProductRequirement (to ProductRequirement)'Generated from Table:ProductRequirement

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductRequirement : Inherits dtoBase
  Private pProductRequirement As dmProductRequirement

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductRequirement"
    pKeyFieldName = "ProductRequirementID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductRequirement.ProductRequirementID
    End Get
    Set(ByVal value As Integer)
      pProductRequirement.ProductRequirementID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductRequirement.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductRequirement.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductRequirementID", pProductRequirement.ProductRequirementID)
    End If
    With pProductRequirement
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseItemID", .SalesOrderPhaseItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AllocatedQty", .AllocatedQty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductRequirement Is Nothing Then SetObjectToNew()
      With pProductRequirement
        .ProductRequirementID = DBReadInt32(rDataReader, "ProductRequirementID")
        .SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .AllocatedQty = DBReadDecimal(rDataReader, "AllocatedQty")
        pProductRequirement.IsDirty = False
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
    pProductRequirement = New dmProductRequirement ' Or .NewBlankProductRequirement
    Return pProductRequirement

  End Function


  Public Function LoadProductRequirement(ByRef rProductRequirement As dmProductRequirement, ByVal vProductRequirementID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductRequirementID)
    If mOK Then
      rProductRequirement = pProductRequirement
    Else
      rProductRequirement = Nothing
    End If
    pProductRequirement = Nothing
    Return mOK
  End Function


  Public Function SaveProductRequirement(ByRef rProductRequirement As dmProductRequirement) As Boolean
    Dim mOK As Boolean
    pProductRequirement = rProductRequirement
    mOK = SaveObject()
    pProductRequirement = Nothing
    Return mOK
  End Function


  Public Function LoadProductRequirementCollection(ByRef rProductRequirements As colProductRequirements, ByVal vSalesOrderPhaseItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderPhaseItemID", vSalesOrderPhaseItemID)
    mOK = MyBase.LoadCollection(rProductRequirements, mParams, "ProductRequirementID")
    rProductRequirements.TrackDeleted = True
    If mOK Then rProductRequirements.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductRequirementCollection(ByRef rCollection As colProductRequirements, ByVal vSalesOrderPhaseItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderPhaseItemID", vSalesOrderPhaseItemID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductRequirement In rCollection
      ''    If pProductRequirement.ProductRequirementID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductRequirement.ProductRequirementID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductRequirement In rCollection.DeletedItems
          If pProductRequirement.ProductRequirementID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductRequirement.ProductRequirementID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductRequirement In rCollection
        If pProductRequirement.IsDirty Or pProductRequirement.SalesOrderPhaseItemID <> vSalesOrderPhaseItemID Or pProductRequirement.ProductRequirementID = 0 Then 'Or pProductRequirement.ProductRequirementID = 0
          pProductRequirement.SalesOrderPhaseItemID = vSalesOrderPhaseItemID
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