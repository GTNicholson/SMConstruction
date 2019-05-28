
''DTO Definition - ProductFurniture (to ProductFurniture)'Generated from Table:ProductFurniture

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductFurniture : Inherits dtoProductBase

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductFurniture"
    pKeyFieldName = "ProductFurnitureID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = CType(pProduct, dmProductFurniture).ProductFurnitureID
    End Get
    Set(ByVal value As Integer)
      CType(pProduct, dmProductFurniture).ProductFurnitureID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = CType(pProduct, dmProductFurniture).IsDirty
    End Get
    Set(ByVal value As Boolean)
      CType(pProduct, dmProductFurniture).IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductFurnitureID", CType(pProduct, dmProductFurniture).ProductFurnitureID)
    End If
    With CType(pProduct, dmProductFurniture)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FurnitureType", .FurnitureType)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If CType(pProduct, dmProductFurniture) Is Nothing Then SetObjectToNew()
      With CType(pProduct, dmProductFurniture)
        .ProductFurnitureID = DBReadInt32(rDataReader, "ProductFurnitureID")
        .Description = DBReadString(rDataReader, "Description")
        .Notes = DBReadString(rDataReader, "notes")
        .FurnitureType = DBReadInt32(rDataReader, "FurnitureType")
        CType(pProduct, dmProductFurniture).IsDirty = False
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


  ''Public Function LoadProductFurnitureCollection(ByRef rProductFurnitures As colProductFurnitures) As Boolean
  ''  Dim mParams As New Hashtable
  ''  Dim mOK As Boolean
  ''  ''mParams.Add("@ParentID", vParentID)
  ''  mOK = MyBase.LoadCollection(rProductFurnitures, mParams, "ProductFurnitureID")
  ''  rProductFurnitures.TrackDeleted = True
  ''  If mOK Then rProductFurnitures.IsDirty = False
  ''  Return mOK
  ''End Function


  ''Public Function SaveProductFurnitureCollection(ByRef rCollection As colProductFurnitures) As Boolean
  ''  Dim mParams As New Hashtable
  ''  Dim mAllOK As Boolean
  ''  ''Dim mCount As Integer
  ''  Dim mIDs As String = ""
  ''  If rCollection.IsDirty Then
  ''    ''mParams.Add("@ParentID", vParentID)

  ''    ''Alternative Approach - where maintain collection of deleted items
  ''    If rCollection.SomeDeleted Then
  ''      mAllOK = True
  ''      For Each Me.pProduct In rCollection.DeletedItems
  ''        If CType(pProduct, dmProductFurniture).ProductFurnitureID <> 0 Then
  ''          If mAllOK Then mAllOK = MyBase.DeleteDBRecord(CType(pProduct, dmProductFurniture).ProductFurnitureID)
  ''        End If
  ''      Next
  ''    Else
  ''      mAllOK = True
  ''    End If

  ''    For Each Me.pProduct In rCollection
  ''      If CType(pProduct, dmProductFurniture).IsDirty Or CType(pProduct, dmProductFurniture).ProductFurnitureID = 0 Then 'Or pProductFurniture.ProductFurnitureID = 0
  ''        If mAllOK Then mAllOK = SaveObject()
  ''      End If
  ''    Next
  ''    If mAllOK Then rCollection.IsDirty = False
  ''  Else
  ''    mAllOK = True
  ''  End If

  ''  Return mAllOK
  ''End Function

End Class


