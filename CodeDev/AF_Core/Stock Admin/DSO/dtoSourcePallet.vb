
''DTO Definition - SourcePallet (to SourcePallet)'Generated from Table:SourcePallet

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSourcePallet : Inherits dtoBase
  Private pSourcePallet As dmSourcePallet

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "SourcePallet"
    pKeyFieldName = "SourcePalletID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSourcePallet.SourcePalletID
    End Get
    Set(ByVal value As Integer)
      pSourcePallet.SourcePalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pSourcePallet.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pSourcePallet.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "SourcePalletID", pSourcePallet.SourcePalletID)
    End If
    With pSourcePallet
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletID", .WoodPalletID)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSourcePallet Is Nothing Then SetObjectToNew()
      With pSourcePallet
        .SourcePalletID = DBReadInt32(rDataReader, "SourcePalletID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        pSourcePallet.IsDirty = False
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
    pSourcePallet = New dmSourcePallet ' Or .NewBlankSourcePallet
    Return pSourcePallet

  End Function


  Public Function LoadSourcePallet(ByRef rSourcePallet As dmSourcePallet, ByVal vSourcePalletID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vSourcePalletID)
    If mOK Then
      rSourcePallet = pSourcePallet
    Else
      rSourcePallet = Nothing
    End If
    pSourcePallet = Nothing
    Return mOK
  End Function


  Public Function SaveSourcePallet(ByRef rSourcePallet As dmSourcePallet) As Boolean
    Dim mOK As Boolean
    pSourcePallet = rSourcePallet
    mOK = SaveObject()
    pSourcePallet = Nothing
    Return mOK
  End Function


  Public Function LoadSourcePalletCollection(ByRef rSourcePallets As colSourcePallets, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rSourcePallets, mParams, "SourcePalletID")
    rSourcePallets.TrackDeleted = True
    If mOK Then rSourcePallets.IsDirty = False
    Return mOK
  End Function


  Public Function SaveSourcePalletCollection(ByRef rCollection As colSourcePallets, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pSourcePallet In rCollection
      ''    If pSourcePallet.SourcePalletID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pSourcePallet.SourcePalletID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pSourcePallet In rCollection.DeletedItems
          If pSourcePallet.SourcePalletID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pSourcePallet.SourcePalletID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pSourcePallet In rCollection
        If pSourcePallet.IsDirty Or pSourcePallet.WorkOrderID <> vWorkOrderID Or pSourcePallet.SourcePalletID = 0 Then 'Or pSourcePallet.SourcePalletID = 0
          pSourcePallet.WorkOrderID = vWorkOrderID
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


