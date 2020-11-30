Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPickWoodMaterialRequirement : Inherits dtoBase
  Private pPickWoodMaterialRequirement As dmPickWoodMaterialRequirement

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PickWoodMaterialRequirement"
    pKeyFieldName = "PickWoodMaterialRequirementID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPickWoodMaterialRequirement.PickWoodMaterialRequirementID
    End Get
    Set(ByVal value As Integer)
      pPickWoodMaterialRequirement.PickWoodMaterialRequirementID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPickWoodMaterialRequirement.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPickWoodMaterialRequirement.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PickWoodMaterialRequirementID", pPickWoodMaterialRequirement.PickWoodMaterialRequirementID)
    End If
    With pPickWoodMaterialRequirement
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletID", .WoodPalletID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickNumber", StringToDBValue(.PickNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickedDate", DateToDBValue(.PickedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comment", StringToDBValue(.Comment))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsProductionReturn", .IsProductionReturn)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCreated", DateToDBValue(.DateCreated))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReturnReasonID", .ReturnReasonID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ActionRequiredID", .ActionRequiredID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileExport", StringToDBValue(.FileExport))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FullyDespatched", .FullyDespatched)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPickValue", .WoodPickValue)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPickWoodMaterialRequirement Is Nothing Then SetObjectToNew()
      With pPickWoodMaterialRequirement
        .PickWoodMaterialRequirementID = DBReadInt32(rDataReader, "PickWoodMaterialRequirementID")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        .PickNumber = DBReadString(rDataReader, "PickNumber")
        .PickedDate = DBReadDateTime(rDataReader, "PickedDate")
        .Comment = DBReadString(rDataReader, "Comment")
        .IsProductionReturn = DBReadBoolean(rDataReader, "IsProductionReturn")
        .DateCreated = DBReadDateTime(rDataReader, "DateCreated")
        .Status = DBReadByte(rDataReader, "Status")
        .ReturnReasonID = DBReadByte(rDataReader, "ReturnReasonID")
        .ActionRequiredID = DBReadByte(rDataReader, "ActionRequiredID")
        .FileExport = DBReadString(rDataReader, "FileExport")
        .FullyDespatched = DBReadBoolean(rDataReader, "FullyDespatched")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .WoodPickValue = DBReadDecimal(rDataReader, "WoodPickValue")
        pPickWoodMaterialRequirement.IsDirty = False
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
    pPickWoodMaterialRequirement = New dmPickWoodMaterialRequirement ' Or .NewBlankPickWoodMaterialRequirement
    Return pPickWoodMaterialRequirement

  End Function


  Public Function LoadPickWoodMaterialRequirement(ByRef rPickWoodMaterialRequirement As dmPickWoodMaterialRequirement, ByVal vPickWoodMaterialRequirementID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPickWoodMaterialRequirementID)
    If mOK Then
      rPickWoodMaterialRequirement = pPickWoodMaterialRequirement
    Else
      rPickWoodMaterialRequirement = Nothing
    End If
    pPickWoodMaterialRequirement = Nothing
    Return mOK
  End Function


  Public Function SavePickWoodMaterialRequirement(ByRef rPickWoodMaterialRequirement As dmPickWoodMaterialRequirement) As Boolean
    Dim mOK As Boolean
    pPickWoodMaterialRequirement = rPickWoodMaterialRequirement
    mOK = SaveObject()
    pPickWoodMaterialRequirement = Nothing
    Return mOK
  End Function





  Public Function SavePickWoodMaterialRequirementCollection(ByRef rCollection As colPickWoodMaterialRequirements) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPickWoodMaterialRequirement In rCollection
      ''    If pPickWoodMaterialRequirement.PickWoodMaterialRequirementID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPickWoodMaterialRequirement.PickWoodMaterialRequirementID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPickWoodMaterialRequirement In rCollection.DeletedItems
          If pPickWoodMaterialRequirement.PickWoodMaterialRequirementID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPickWoodMaterialRequirement.PickWoodMaterialRequirementID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPickWoodMaterialRequirement In rCollection
        If pPickWoodMaterialRequirement.IsDirty Or pPickWoodMaterialRequirement.PickWoodMaterialRequirementID = 0 Then 'Or pPickWoodMaterialRequirement.PickWoodMaterialRequirementID = 0
          'pPickWoodMaterialRequirement.ParentID = vParentID
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

