
''DTO Definition - MaterialRequirement (to MaterialRequirement)'Generated from Table:MaterialRequirement

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaterialRequirement : Inherits dtoBase
  Private pMaterialRequirement As dmMaterialRequirement

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "MaterialRequirement"
    pKeyFieldName = "MaterialRequirementID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaterialRequirement.MaterialRequirementID
    End Get
    Set(ByVal value As Integer)
      pMaterialRequirement.MaterialRequirementID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pMaterialRequirement.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pMaterialRequirement.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "MaterialRequirementID", pMaterialRequirement.MaterialRequirementID)
    End If
    With pMaterialRequirement
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectType", .ObjectType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectID", .ObjectID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pMaterialRequirement Is Nothing Then SetObjectToNew()
      With pMaterialRequirement
        .MaterialRequirementID = DBReadInt32(rDataReader, "MaterialRequirementID")
        .ObjectType = DBReadByte(rDataReader, "ObjectType")
        .ObjectID = DBReadInt32(rDataReader, "ObjectID")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        pMaterialRequirement.IsDirty = False
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
    pMaterialRequirement = New dmMaterialRequirement ' Or .NewBlankMaterialRequirement
    Return pMaterialRequirement

  End Function


  Public Function LoadMaterialRequirement(ByRef rMaterialRequirement As dmMaterialRequirement, ByVal vMaterialRequirementID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vMaterialRequirementID)
    If mOK Then
      rMaterialRequirement = pMaterialRequirement
    Else
      rMaterialRequirement = Nothing
    End If
    pMaterialRequirement = Nothing
    Return mOK
  End Function


  Public Function SaveMaterialRequirement(ByRef rMaterialRequirement As dmMaterialRequirement) As Boolean
    Dim mOK As Boolean
    pMaterialRequirement = rMaterialRequirement
    mOK = SaveObject()
    pMaterialRequirement = Nothing
    Return mOK
  End Function


  Public Function LoadMaterialRequirementCollection(ByRef rMaterialRequirements As colMaterialRequirements, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rMaterialRequirements, mParams, "MaterialRequirementID")
    rMaterialRequirements.TrackDeleted = True
    If mOK Then rMaterialRequirements.IsDirty = False
    Return mOK
  End Function


  Public Function SaveMaterialRequirementCollection(ByRef rCollection As colMaterialRequirements, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pMaterialRequirement In rCollection
      ''    If pMaterialRequirement.MaterialRequirementID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pMaterialRequirement.MaterialRequirementID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pMaterialRequirement In rCollection.DeletedItems
          If pMaterialRequirement.MaterialRequirementID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pMaterialRequirement.MaterialRequirementID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pMaterialRequirement In rCollection
        If pMaterialRequirement.IsDirty Or pMaterialRequirement.MaterialRequirementID = 0 Then 'Or pMaterialRequirement.MaterialRequirementID = 0
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


