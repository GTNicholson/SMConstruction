

''DTO Definition - SalesOrderItemProductRequirement (to SalesOrderItemProductRequirement)'Generated from Table:SalesOrderItemProductRequirement

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderItemProductRequirement : Inherits dtoBase
  Private pSalesOrderItemProductRequirement As dmSalesOrderItemProductRequirement

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SalesOrderItemProductRequirement"
    pKeyFieldName = "SalesOrderItemProductRequirementID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID
    End Get
    Set(ByVal value As Integer)
      pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSalesOrderItemProductRequirement.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSalesOrderItemProductRequirement.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SalesOrderItemProductRequirementID", pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID)
    End If
    With pSalesOrderItemProductRequirement
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderItemID", .SalesOrderItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AllocatedQty", .AllocatedQty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderItemProductRequirement Is Nothing Then SetObjectToNew()
      With pSalesOrderItemProductRequirement
        .SalesOrderItemProductRequirementID = DBReadInt32(rDataReader, "SalesOrderItemProductRequirementID")
        .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .AllocatedQty = DBReadDecimal(rDataReader, "AllocatedQty")
        pSalesOrderItemProductRequirement.IsDirty = False
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
    pSalesOrderItemProductRequirement = New dmSalesOrderItemProductRequirement ' Or .NewBlankSalesOrderItemProductRequirement
    Return pSalesOrderItemProductRequirement

  End Function


  Public Function LoadSalesOrderItemProductRequirement(ByRef rSalesOrderItemProductRequirement As dmSalesOrderItemProductRequirement, ByVal vSalesOrderItemProductRequirementID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSalesOrderItemProductRequirementID)
    If mOK Then
      rSalesOrderItemProductRequirement = pSalesOrderItemProductRequirement
    Else
      rSalesOrderItemProductRequirement = Nothing
    End If
    pSalesOrderItemProductRequirement = Nothing
    Return mOK
  End Function


  Public Function SaveSalesOrderItemProductRequirement(ByRef rSalesOrderItemProductRequirement As dmSalesOrderItemProductRequirement) As Boolean
    Dim mOK As Boolean
    pSalesOrderItemProductRequirement = rSalesOrderItemProductRequirement
    mOK = SaveObject()
    pSalesOrderItemProductRequirement = Nothing
    Return mOK
  End Function


  Public Function LoadSalesOrderItemProductRequirementCollection(ByRef rSalesOrderItemProductRequirements As colSalesOrderItemProductRequirements, ByVal vSalesOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SalesOrderItemID", vSalesOrderItemID)
    mOK = MyBase.LoadCollection(rSalesOrderItemProductRequirements, mParams, "SalesOrderItemProductRequirementID")
    rSalesOrderItemProductRequirements.TrackDeleted = True
    If mOK Then rSalesOrderItemProductRequirements.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSalesOrderItemProductRequirementCollection(ByRef rCollection As colSalesOrderItemProductRequirements, ByVal vSalesOrderItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SalesOrderItemID", vSalesOrderItemID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSalesOrderItemProductRequirement In rCollection
      ''    If pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSalesOrderItemProductRequirement In rCollection.DeletedItems
          If pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSalesOrderItemProductRequirement In rCollection
        If pSalesOrderItemProductRequirement.IsDirty Or pSalesOrderItemProductRequirement.SalesOrderItemID <> vSalesOrderItemID Or pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID = 0 Then 'Or pSalesOrderItemProductRequirement.SalesOrderItemProductRequirementID = 0
          pSalesOrderItemProductRequirement.SalesOrderItemID = vSalesOrderItemID
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
