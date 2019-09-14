''DTO Definition - ProductFurnitureComponent (to ProductFurnitureComponent)'Generated from Table:ProductFurnitureComponent

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductFurnitureComponent : Inherits dtoBase
  Private pProductFurnitureComponent As dmProductFurnitureComponent

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductFurnitureComponent"
    pKeyFieldName = "ProductFurnitureComponentID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductFurnitureComponent.ProductFurnitureComponentID
    End Get
    Set(ByVal value As Integer)
      pProductFurnitureComponent.ProductFurnitureComponentID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductFurnitureComponent.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductFurnitureComponent.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductFurnitureComponentID", pProductFurnitureComponent.ProductFurnitureComponentID)
    End If
    With pProductFurnitureComponent
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductFurnitureID", .ProductFurnitureID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Species", .Species)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Qty", .Qty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Dimensions", StringToDBValue(.Dimensions))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductFurnitureComponent Is Nothing Then SetObjectToNew()
      With pProductFurnitureComponent
        .ProductFurnitureComponentID = DBReadInt32(rDataReader, "ProductFurnitureComponentID")
        .ProductFurnitureID = DBReadInt32(rDataReader, "ProductFurnitureID")
        .Description = DBReadString(rDataReader, "Description")
        .Species = DBReadInt32(rDataReader, "Species")
        .Qty = DBReadDouble(rDataReader, "Qty")
        .Dimensions = DBReadString(rDataReader, "Dimensions")
        pProductFurnitureComponent.IsDirty = False
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
    pProductFurnitureComponent = New dmProductFurnitureComponent ' Or .NewBlankProductFurnitureComponent
    Return pProductFurnitureComponent

  End Function


  Public Function LoadProductFurnitureComponent(ByRef rProductFurnitureComponent As dmProductFurnitureComponent, ByVal vProductFurnitureComponentID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductFurnitureComponentID)
    If mOK Then
      rProductFurnitureComponent = pProductFurnitureComponent
    Else
      rProductFurnitureComponent = Nothing
    End If
    pProductFurnitureComponent = Nothing
    Return mOK
  End Function


  Public Function SaveProductFurnitureComponent(ByRef rProductFurnitureComponent As dmProductFurnitureComponent) As Boolean
    Dim mOK As Boolean
    pProductFurnitureComponent = rProductFurnitureComponent
    mOK = SaveObject()
    pProductFurnitureComponent = Nothing
    Return mOK
  End Function


  Public Function LoadProductFurnitureComponentCollection(ByRef rProductFurnitureComponents As colProductFurnitureComponents, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductFurnitureComponents, mParams, "ProductFurnitureComponentID")
    rProductFurnitureComponents.TrackDeleted = True
    If mOK Then rProductFurnitureComponents.IsDirty = False
    Return mOK
  End Function

  Public Function SaveProductFurnitureComponentCollection(ByRef rCollection As colProductFurnitureComponents, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductFurnitureComponent In rCollection
      ''    If pProductFurnitureComponent.ProductFurnitureComponentID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductFurnitureComponent.ProductFurnitureComponentID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductFurnitureComponent In rCollection.DeletedItems
          If pProductFurnitureComponent.ProductFurnitureComponentID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductFurnitureComponent.ProductFurnitureComponentID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductFurnitureComponent In rCollection
        If pProductFurnitureComponent.IsDirty Or pProductFurnitureComponent.ProductFurnitureID <> vParentID Or pProductFurnitureComponent.ProductFurnitureComponentID = 0 Then 'Or pProductFurnitureComponent.ProductFurnitureComponentID = 0
          pProductFurnitureComponent.ProductFurnitureID = vParentID
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
