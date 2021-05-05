''DTO Definition - ThicknessValue (to ThicknessValue)'Generated from Table:ThicknessValue

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoThicknessValue : Inherits dtoBase
  Private pThicknessValue As dmThicknessValue

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ThicknessValue"
    pKeyFieldName = "ThicknessValueID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pThicknessValue.ThicknessValueID
    End Get
    Set(ByVal value As Integer)
      pThicknessValue.ThicknessValueID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pThicknessValue.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pThicknessValue.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ThicknessValueID", pThicknessValue.ThicknessValueID)
    End If
    With pThicknessValue
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Thickness", .Thickness)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pThicknessValue Is Nothing Then SetObjectToNew()
      With pThicknessValue
        .ThicknessValueID = DBReadInt32(rDataReader, "ThicknessValueID")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        pThicknessValue.IsDirty = False
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
    pThicknessValue = New dmThicknessValue ' Or .NewBlankThicknessValue
    Return pThicknessValue

  End Function


  Public Function LoadThicknessValue(ByRef rThicknessValue As dmThicknessValue, ByVal vThicknessValueID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vThicknessValueID)
    If mOK Then
      rThicknessValue = pThicknessValue
    Else
      rThicknessValue = Nothing
    End If
    pThicknessValue = Nothing
    Return mOK
  End Function


  Public Function SaveThicknessValue(ByRef rThicknessValue As dmThicknessValue) As Boolean
    Dim mOK As Boolean
    pThicknessValue = rThicknessValue
    mOK = SaveObject()
    pThicknessValue = Nothing
    Return mOK
  End Function


  Public Function LoadThicknessValueCollection(ByRef rThicknessValues As colThicknessValues) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rThicknessValues, mParams, "ThicknessValueID")
    rThicknessValues.TrackDeleted = True
    If mOK Then rThicknessValues.IsDirty = False
    Return mOK
  End Function


  Public Function SaveThicknessValueCollection(ByRef rCollection As colThicknessValues) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      'mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pThicknessValue In rCollection
      ''    If pThicknessValue.ThicknessValueID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pThicknessValue.ThicknessValueID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pThicknessValue In rCollection.DeletedItems
          If pThicknessValue.ThicknessValueID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pThicknessValue.ThicknessValueID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pThicknessValue In rCollection
        If pThicknessValue.IsDirty Or pThicknessValue.ThicknessValueID = 0 Then 'Or pThicknessValue.ThicknessValueID = 0
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
