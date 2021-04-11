
''DTO Definition - ProductStructure (to ProductStructure)'Generated from Table:ProductStructure

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductStructure : Inherits dtoProductBase
  Private pProductStructure As dmProductStructure

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductStructure"
    pKeyFieldName = "ProductStructureID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = CType(pProduct, dmProductStructure).ProductStructureID
    End Get
    Set(ByVal value As Integer)
      CType(pProduct, dmProductStructure).ProductStructureID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = CType(pProduct, dmProductStructure).IsDirty
    End Get
    Set(ByVal value As Boolean)
      CType(pProduct, dmProductStructure).IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductStructureID", CType(pProduct, dmProductStructure).ProductStructureID)
    End If
    With CType(pProduct, dmProductStructure)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Code", StringToDBValue(.Code))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemType", .ItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubItemType", .SubItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", .UoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DrawingFileName", StringToDBValue(.DrawingFileName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsGeneric", .IsGeneric)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Status", .Status)

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If CType(pProduct, dmProductStructure) Is Nothing Then SetObjectToNew()
      With CType(pProduct, dmProductStructure)
        .ProductStructureID = DBReadInt32(rDataReader, "ProductStructureID")
        .Description = DBReadString(rDataReader, "Description")
        .Notes = DBReadString(rDataReader, "Notes")
        .Code = DBReadString(rDataReader, "Code")
        .ItemType = DBReadInt32(rDataReader, "ItemType")
        .SubItemType = DBReadInt32(rDataReader, "SubItemType")
        .UoM = DBReadInt32(rDataReader, "UoM")
        .DrawingFileName = DBReadString(rDataReader, "DrawingFileName")
        .IsGeneric = DBReadBoolean(rDataReader, "IsGeneric")
        .Status = DBReadBoolean(rDataReader, "Status")
        CType(pProduct, dmProductStructure).IsDirty = False
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
    pProduct = New dmProductStructure ' Or .NewBlankProductStructure
    Return pProduct

  End Function


  Public Function LoadProductStructure(ByRef rProductStructure As dmProductStructure, ByVal vProductStructureID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductStructureID)
    If mOK Then
      rProductStructure = pProductStructure
    Else
      rProductStructure = Nothing
    End If
    pProductStructure = Nothing
    Return mOK
  End Function


  Public Function SaveProductStructure(ByRef rProductStructure As dmProductStructure) As Boolean
    Dim mOK As Boolean
    pProductStructure = rProductStructure
    mOK = SaveObject()
    pProductStructure = Nothing
    Return mOK
  End Function


  Public Function LoadProductStructureCollection(ByRef rProductStructures As colProductStructures) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductStructures, mParams, "ProductStructureID")
    rProductStructures.TrackDeleted = True
    If mOK Then rProductStructures.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductStructureCollection(ByRef rCollection As colProductStructures, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductStructure In rCollection
      ''    If pProductStructure.ProductStructureID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductStructure.ProductStructureID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductStructure In rCollection.DeletedItems
          If pProductStructure.ProductStructureID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductStructure.ProductStructureID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductStructure In rCollection
        If pProductStructure.IsDirty Or pProductStructure.ProductStructureID = 0 Then 'Or pProductStructure.ProductStructureID = 0
          '' pProductStructure.ParentID = vParentID
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

