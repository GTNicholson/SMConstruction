''DTO Definition - WindowOptions (to WindowOptions)'Generated from Table:WindowOptions

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWindowOptions : Inherits dtoBase
  Private pWindowOptions As dmWindowOptions

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WindowOptions"
    pKeyFieldName = "WindowOptionsID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWindowOptions.WindowOptionsID
    End Get
    Set(ByVal value As Integer)
      pWindowOptions.WindowOptionsID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWindowOptions.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWindowOptions.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WindowOptionsID", pWindowOptions.WindowOptionsID)
    End If
    With pWindowOptions
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWindowOptions Is Nothing Then SetObjectToNew()
      With pWindowOptions
        .WindowOptionsID = DBReadInt32(rDataReader, "WindowOptionsID")
        .Description = DBReadString(rDataReader, "Description")
        pWindowOptions.IsDirty = False
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
    pWindowOptions = New dmWindowOptions ' Or .NewBlankWindowOptions
    Return pWindowOptions

  End Function


  Public Function LoadWindowOptions(ByRef rWindowOptions As dmWindowOptions, ByVal vWindowOptionsID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWindowOptionsID)
    If mOK Then
      rWindowOptions = pWindowOptions
    Else
      rWindowOptions = Nothing
    End If
    pWindowOptions = Nothing
    Return mOK
  End Function


  Public Function SaveWindowOptions(ByRef rWindowOptions As dmWindowOptions) As Boolean
    Dim mOK As Boolean
    pWindowOptions = rWindowOptions
    mOK = SaveObject()
    pWindowOptions = Nothing
    Return mOK
  End Function


  Public Function LoadWindowOptionsCollection(ByRef rWindowOptionss As colWindowOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rWindowOptionss, mParams, "WindowOptionsID")
    rWindowOptionss.TrackDeleted = True
    If mOK Then rWindowOptionss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWindowOptionsCollection(ByRef rCollection As colWindowOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWindowOptions In rCollection
      ''    If pWindowOptions.WindowOptionsID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWindowOptions.WindowOptionsID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWindowOptions In rCollection.DeletedItems
          If pWindowOptions.WindowOptionsID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWindowOptions.WindowOptionsID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWindowOptions In rCollection
        If pWindowOptions.IsDirty Or pWindowOptions.WindowOptionsID = 0 Then 'Or pWindowOptions.WindowOptionsID = 0
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


