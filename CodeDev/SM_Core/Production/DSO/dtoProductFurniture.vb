
''DTO Definition - ProductFurniture (to ProductFurniture)'Generated from Table:ProductFurniture

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductFurniture : Inherits dtoBase
  Private pProductFurniture As dmProductFurniture

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
      ObjectKeyFieldValue = pProductFurniture.ProductFurnitureID
    End Get
    Set(ByVal value As Integer)
      pProductFurniture.ProductFurnitureID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductFurniture.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductFurniture.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductFurnitureID", pProductFurniture.ProductFurnitureID)
    End If
    With pProductFurniture
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FurnitureType", .FurnitureType)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductFurniture Is Nothing Then SetObjectToNew()
      With pProductFurniture
        .ProductFurnitureID = DBReadInt32(rDataReader, "ProductFurnitureID")
        .Description = DBReadString(rDataReader, "Description")
        .FurnitureType = DBReadInt32(rDataReader, "FurnitureType")
        pProductFurniture.IsDirty = False
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
    pProductFurniture = New dmProductFurniture ' Or .NewBlankProductFurniture
    Return pProductFurniture

  End Function


  Public Function LoadProductFurniture(ByRef rProductFurniture As dmProductFurniture, ByVal vProductFurnitureID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductFurnitureID)
    If mOK Then
      rProductFurniture = pProductFurniture
    Else
      rProductFurniture = Nothing
    End If
    pProductFurniture = Nothing
    Return mOK
  End Function


  Public Function SaveProductFurniture(ByRef rProductFurniture As dmProductFurniture) As Boolean
    Dim mOK As Boolean
    pProductFurniture = rProductFurniture
    mOK = SaveObject()
    pProductFurniture = Nothing
    Return mOK
  End Function


  Public Function LoadProductFurnitureCollection(ByRef rProductFurnitures As colProductFurnitures) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductFurnitures, mParams, "ProductFurnitureID")
    rProductFurnitures.TrackDeleted = True
    If mOK Then rProductFurnitures.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductFurnitureCollection(ByRef rCollection As colProductFurnitures) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    ''Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductFurniture In rCollection.DeletedItems
          If pProductFurniture.ProductFurnitureID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductFurniture.ProductFurnitureID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductFurniture In rCollection
        If pProductFurniture.IsDirty Or pProductFurniture.ProductFurnitureID = 0 Then 'Or pProductFurniture.ProductFurnitureID = 0
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


