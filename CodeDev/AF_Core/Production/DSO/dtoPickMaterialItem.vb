''DTO Definition - PickWoodMaterialItem (to PickWoodMaterialItem)'Generated from Table:PickWoodMaterialItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoPickWoodMaterialItem : Inherits dtoBase
  Private pPickWoodMaterialItem As dmPickWoodMaterialItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "PickWoodMaterialItem"
    pKeyFieldName = "PickWoodMaterialItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pPickWoodMaterialItem.PickWoodMaterialItemID
    End Get
    Set(ByVal value As Integer)
      pPickWoodMaterialItem.PickWoodMaterialItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pPickWoodMaterialItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pPickWoodMaterialItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "PickWoodMaterialItemID", pPickWoodMaterialItem.PickWoodMaterialItemID)
    End If
    With pPickWoodMaterialItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PickWoodMaterialID", .PickWoodMaterialID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QtyPicked", .QtyPicked)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletItemID", .WoodPalletItemID)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pPickWoodMaterialItem Is Nothing Then SetObjectToNew()
      With pPickWoodMaterialItem
        .PickWoodMaterialItemID = DBReadInt32(rDataReader, "PickWoodMaterialItemID")
        .PickWoodMaterialID = DBReadInt32(rDataReader, "PickWoodMaterialID")
        .QtyPicked = DBReadDecimal(rDataReader, "QtyPicked")
        .WoodPalletItemID = DBReadInt32(rDataReader, "WoodPalletItemID")
        pPickWoodMaterialItem.IsDirty = False
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
    pPickWoodMaterialItem = New dmPickWoodMaterialItem ' Or .NewBlankPickWoodMaterialItem
    Return pPickWoodMaterialItem

  End Function


  Public Function LoadPickWoodMaterialItem(ByRef rPickWoodMaterialItem As dmPickWoodMaterialItem, ByVal vPickWoodMaterialItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vPickWoodMaterialItemID)
    If mOK Then
      rPickWoodMaterialItem = pPickWoodMaterialItem
    Else
      rPickWoodMaterialItem = Nothing
    End If
    pPickWoodMaterialItem = Nothing
    Return mOK
  End Function


  Public Function SavePickWoodMaterialItem(ByRef rPickWoodMaterialItem As dmPickWoodMaterialItem) As Boolean
    Dim mOK As Boolean
    pPickWoodMaterialItem = rPickWoodMaterialItem
    mOK = SaveObject()
    pPickWoodMaterialItem = Nothing
    Return mOK
  End Function


  Public Function LoadPickWoodMaterialItemCollection(ByRef rPickWoodMaterialItems As colPickWoodMaterialItems, ByVal vPickWoodMaterialID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PickWoodMaterialID", vPickWoodMaterialID)
    mOK = MyBase.LoadCollection(rPickWoodMaterialItems, mParams, "PickWoodMaterialItemID")
    rPickWoodMaterialItems.TrackDeleted = True
    If mOK Then rPickWoodMaterialItems.IsDirty = False
    Return mOK
  End Function


  Public Function SavePickWoodMaterialItemCollection(ByRef rCollection As colPickWoodMaterialItems, ByVal vPickWoodMaterialID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PickWoodMaterialID", vPickWoodMaterialID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pPickWoodMaterialItem In rCollection
      ''    If pPickWoodMaterialItem.PickWoodMaterialItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pPickWoodMaterialItem.PickWoodMaterialItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pPickWoodMaterialItem In rCollection.DeletedItems
          If pPickWoodMaterialItem.PickWoodMaterialItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pPickWoodMaterialItem.PickWoodMaterialItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pPickWoodMaterialItem In rCollection
        If pPickWoodMaterialItem.IsDirty Or pPickWoodMaterialItem.PickWoodMaterialID <> vPickWoodMaterialID Or pPickWoodMaterialItem.PickWoodMaterialItemID = 0 Then 'Or pPickWoodMaterialItem.PickWoodMaterialItemID = 0
          pPickWoodMaterialItem.PickWoodMaterialID = vPickWoodMaterialID
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


