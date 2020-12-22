''DTO Definition - OutputPallet (to OutputPallet)'Generated from Table:OutputPallet

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoOutputPallet : Inherits dtoBase
  Private pOutputPallet As dmOutputPallet

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "OutputPallet"
    pKeyFieldName = "OutputPalletID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pOutputPallet.OutputPalletID
    End Get
    Set(ByVal value As Integer)
      pOutputPallet.OutputPalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pOutputPallet.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pOutputPallet.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "OutputPalletID", pOutputPallet.OutputPalletID)
    End If
    With pOutputPallet
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletID", .WoodPalletID)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pOutputPallet Is Nothing Then SetObjectToNew()
      With pOutputPallet
        .OutputPalletID = DBReadInt32(rDataReader, "OutputPalletID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        pOutputPallet.IsDirty = False
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
    pOutputPallet = New dmOutputPallet ' Or .NewBlankOutputPallet
    Return pOutputPallet

  End Function


  Public Function LoadOutputPallet(ByRef rOutputPallet As dmOutputPallet, ByVal vOutputPalletID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vOutputPalletID)
    If mOK Then
      rOutputPallet = pOutputPallet
    Else
      rOutputPallet = Nothing
    End If
    pOutputPallet = Nothing
    Return mOK
  End Function


  Public Function SaveOutputPallet(ByRef rOutputPallet As dmOutputPallet) As Boolean
    Dim mOK As Boolean
    pOutputPallet = rOutputPallet
    mOK = SaveObject()
    pOutputPallet = Nothing
    Return mOK
  End Function


  Public Function LoadOutputPalletCollection(ByRef rOutputPallets As colOutputPallets, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WorkOrderID", vWorkOrderID)
    mOK = MyBase.LoadCollection(rOutputPallets, mParams, "OutputPalletID")
    rOutputPallets.TrackDeleted = True
    If mOK Then rOutputPallets.IsDirty = False
    Return mOK
  End Function


  Public Function SaveOutputPalletCollection(ByRef rCollection As colOutputPallets, ByVal vWorkOrderID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WorkOrderID", vWorkOrderID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pOutputPallet In rCollection
      ''    If pOutputPallet.OutputPalletID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pOutputPallet.OutputPalletID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pOutputPallet In rCollection.DeletedItems
          If pOutputPallet.OutputPalletID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pOutputPallet.OutputPalletID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pOutputPallet In rCollection
        If pOutputPallet.IsDirty Or pOutputPallet.WorkOrderID <> vWorkOrderID Or pOutputPallet.OutputPalletID = 0 Then 'Or pOutputPallet.OutputPalletID = 0
          pOutputPallet.WorkOrderID = vWorkOrderID
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


