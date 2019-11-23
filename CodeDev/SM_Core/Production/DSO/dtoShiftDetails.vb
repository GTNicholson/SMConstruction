'DTO Definition - ShiftDetails (to ShiftDetails)'Generated from Table:ShiftDetails

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoShiftDetails : Inherits dtoBase
  Private pShiftDetails As dmShiftDetails

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ShiftDetails"
    pKeyFieldName = "ShiftDetailID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pShiftDetails.ShiftDetailID
    End Get
    Set(ByVal value As Integer)
      pShiftDetails.ShiftDetailID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pShiftDetails.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pShiftDetails.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ShiftDetailID", pShiftDetails.ShiftDetailID)
    End If
    With pShiftDetails
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ShiftID", .ShiftID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DayOfWeek", .DayOfWeek)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StartTime", DateToDBValue(.StartTime))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EndTime", DateToDBValue(.EndTime))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pShiftDetails Is Nothing Then SetObjectToNew()
      With pShiftDetails
        .ShiftDetailID = DBReadInt32(rDataReader, "ShiftDetailID")
        .ShiftID = DBReadInt32(rDataReader, "ShiftID")
        .DayOfWeek = DBReadByte(rDataReader, "DayOfWeek")
        .StartTime = DBReadDateTime(rDataReader, "StartTime")
        .EndTime = DBReadDateTime(rDataReader, "EndTime")
        pShiftDetails.IsDirty = False
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
    pShiftDetails = New dmShiftDetails ' Or .NewBlankShiftDetails
    Return pShiftDetails

  End Function


  Public Function LoadShiftDetails(ByRef rShiftDetails As dmShiftDetails, ByVal vShiftDetailID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vShiftDetailID)
    If mOK Then
      rShiftDetails = pShiftDetails
    Else
      rShiftDetails = Nothing
    End If
    pShiftDetails = Nothing
    Return mOK
  End Function


  Public Function SaveShiftDetails(ByRef rShiftDetails As dmShiftDetails) As Boolean
    Dim mOK As Boolean
    pShiftDetails = rShiftDetails
    mOK = SaveObject()
    pShiftDetails = Nothing
    Return mOK
  End Function


  Public Function LoadShiftDetailsCollection(ByRef rShiftDetailss As colShiftDetailss, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rShiftDetailss, mParams, "ShiftDetailID")
    rShiftDetailss.TrackDeleted = True
    If mOK Then rShiftDetailss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveShiftDetailsCollection(ByRef rCollection As colShiftDetailss, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pShiftDetails In rCollection
      ''    If pShiftDetails.ShiftDetailID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pShiftDetails.ShiftDetailID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pShiftDetails In rCollection.DeletedItems
          If pShiftDetails.ShiftDetailID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pShiftDetails.ShiftDetailID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pShiftDetails In rCollection
        If pShiftDetails.IsDirty Or pShiftDetails.ShiftDetailID = 0 Then 'Or pShiftDetails.ShiftDetailID = 0
          ''pShiftDetails.ParentID = vParentID
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

