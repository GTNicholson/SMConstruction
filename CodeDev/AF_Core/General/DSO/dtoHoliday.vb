''DTO Definition - Holiday (to Holiday)'Generated from Table:Holiday

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoHoliday : Inherits dtoBase
  Private pHoliday As dmHoliday

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Holiday"
    pKeyFieldName = "HolidayID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pHoliday.HolidayID
    End Get
    Set(ByVal value As Integer)
      pHoliday.HolidayID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pHoliday.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pHoliday.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "HolidayID", pHoliday.HolidayID)
    End If
    With pHoliday
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HolidayDate", DateToDBValue(.HolidayDate))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pHoliday Is Nothing Then SetObjectToNew()
      With pHoliday
        .HolidayID = DBReadInt32(rDataReader, "HolidayID")
        .HolidayDate = DBReadDateTime(rDataReader, "HolidayDate")
        pHoliday.IsDirty = False
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
    pHoliday = New dmHoliday ' Or .NewBlankHoliday
    Return pHoliday

  End Function


  Public Function LoadHoliday(ByRef rHoliday As dmHoliday, ByVal vHolidayID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vHolidayID)
    If mOK Then
      rHoliday = pHoliday
    Else
      rHoliday = Nothing
    End If
    pHoliday = Nothing
    Return mOK
  End Function


  Public Function SaveHoliday(ByRef rHoliday As dmHoliday) As Boolean
    Dim mOK As Boolean
    pHoliday = rHoliday
    mOK = SaveObject()
    pHoliday = Nothing
    Return mOK
  End Function


  Public Function LoadHolidayCollection(ByRef rHolidays As colHolidays) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rHolidays, mParams, "HolidayID")
    rHolidays.TrackDeleted = True
    If mOK Then rHolidays.IsDirty = False
    Return mOK
  End Function


  Public Function SaveHolidayCollection(ByRef rCollection As colHolidays) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pHoliday In rCollection
      ''    If pHoliday.HolidayID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pHoliday.HolidayID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pHoliday In rCollection.DeletedItems
          If pHoliday.HolidayID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pHoliday.HolidayID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pHoliday In rCollection
        If pHoliday.IsDirty Or pHoliday.HolidayID = 0 Then 'Or pHoliday.HolidayID = 0
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
