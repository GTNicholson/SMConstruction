
''DTO Definition - ProductInstallation (to ProductInstallation)'Generated from Table:ProductInstallation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductInstallation : Inherits dtoBase
  Private pProductInstallation As dmProductInstallation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductInstallation"
    pKeyFieldName = "ProductInstallationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductInstallation.ProductInstallationID
    End Get
    Set(ByVal value As Integer)
      pProductInstallation.ProductInstallationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductInstallation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductInstallation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductInstallationID", pProductInstallation.ProductInstallationID)
    End If
    With pProductInstallation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductInstallationTypeID", .ProductInstallationTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Notes", StringToDBValue(.Notes))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductInstallation Is Nothing Then SetObjectToNew()
      With pProductInstallation
        .ProductInstallationID = DBReadInt32(rDataReader, "ProductInstallationID")
        .Description = DBReadString(rDataReader, "Description")
        .ProductInstallationTypeID = DBReadInt32(rDataReader, "ProductInstallationTypeID")
        .Notes = DBReadString(rDataReader, "Notes")
        pProductInstallation.IsDirty = False
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
    pProductInstallation = New dmProductInstallation ' Or .NewBlankProductInstallation
    Return pProductInstallation

  End Function


  Public Function LoadProductInstallation(ByRef rProductInstallation As dmProductInstallation, ByVal vProductInstallationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductInstallationID)
    If mOK Then
      rProductInstallation = pProductInstallation
    Else
      rProductInstallation = Nothing
    End If
    pProductInstallation = Nothing
    Return mOK
  End Function


  Public Function SaveProductInstallation(ByRef rProductInstallation As dmProductInstallation) As Boolean
    Dim mOK As Boolean
    pProductInstallation = rProductInstallation
    mOK = SaveObject()
    pProductInstallation = Nothing
    Return mOK
  End Function


  Public Function LoadProductInstallationCollection(ByRef rProductInstallations As colProductInstallations) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rProductInstallations, mParams, "ProductInstallationID")
    rProductInstallations.TrackDeleted = True
    If mOK Then rProductInstallations.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductInstallationCollection(ByRef rCollection As colProductInstallations) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductInstallation In rCollection
      ''    If pProductInstallation.ProductInstallationID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductInstallation.ProductInstallationID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductInstallation In rCollection.DeletedItems
          If pProductInstallation.ProductInstallationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductInstallation.ProductInstallationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductInstallation In rCollection
        If pProductInstallation.IsDirty Or pProductInstallation.ProductInstallationID = 0 Then 'Or pProductInstallation.ProductInstallationID = 0

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

