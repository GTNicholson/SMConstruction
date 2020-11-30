''DTO Definition - WoodPallet (to WoodPallet)'Generated from Table:WoodPallet

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodPallet : Inherits dtoBase
  Private pWoodPallet As dmWoodPallet

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodPallet"
    pKeyFieldName = "WoodPalletID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodPallet.WoodPalletID
    End Get
    Set(ByVal value As Integer)
      pWoodPallet.WoodPalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodPallet.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodPallet.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodPalletID", pWoodPallet.WoodPalletID)
    End If
    With pWoodPallet
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PalletRef", StringToDBValue(.PalletRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CreatedDate", DateToDBValue(.CreatedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LocationID", .LocationID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Archive", .Archive)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodPallet Is Nothing Then SetObjectToNew()
      With pWoodPallet
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        .PalletRef = DBReadString(rDataReader, "PalletRef")
        .CreatedDate = DBReadDateTime(rDataReader, "CreatedDate")
        .LocationID = DBReadInt32(rDataReader, "LocationID")
        .Archive = DBReadBoolean(rDataReader, "Archive")

        pWoodPallet.IsDirty = False
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
    pWoodPallet = New dmWoodPallet ' Or .NewBlankWoodPallet
    Return pWoodPallet

  End Function


  Public Function LoadWoodPallet(ByRef rWoodPallet As dmWoodPallet, ByVal vWoodPalletID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodPalletID)
    If mOK Then
      rWoodPallet = pWoodPallet
    Else
      rWoodPallet = Nothing
    End If
    pWoodPallet = Nothing
    Return mOK
  End Function
  Public Function LoadWoodPalletByWhere(ByRef rWoodPallets As colWoodPallets, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWoodPallets, mParams, "WoodPalletID", vWhere)
    Return mOK
  End Function

  Public Function SaveWoodPallet(ByRef rWoodPallet As dmWoodPallet) As Boolean
    Dim mOK As Boolean
    pWoodPallet = rWoodPallet
    mOK = SaveObject()
    pWoodPallet = Nothing
    Return mOK
  End Function


  Public Function LoadWoodPalletCollection(ByRef rWoodPallets As colWoodPallets) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rWoodPallets, mParams, "WoodPalletID")
    rWoodPallets.TrackDeleted = True
    If mOK Then rWoodPallets.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodPalletCollection(ByRef rCollection As colWoodPallets) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodPallet In rCollection
      ''    If pWoodPallet.WoodPalletID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodPallet.WoodPalletID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodPallet In rCollection.DeletedItems
          If pWoodPallet.WoodPalletID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodPallet.WoodPalletID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodPallet In rCollection
        If pWoodPallet.IsDirty Or pWoodPallet.WoodPalletID = 0 Then 'Or pWoodPallet.WoodPalletID = 0
          ''pWoodPallet.ParentID = vParentID
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
