﻿
''DTO Definition - Shift (to Shift)'Generated from Table:Shift

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoShift : Inherits dtoBase
  Private pShift As dmShift

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Shift"
    pKeyFieldName = "ShiftID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pShift.ShiftID
    End Get
    Set(ByVal value As Integer)
      pShift.ShiftID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pShift.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pShift.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ShiftID", pShift.ShiftID)
    End If
    With pShift
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pShift Is Nothing Then SetObjectToNew()
      With pShift
        .ShiftID = DBReadInt32(rDataReader, "ShiftID")
        .Description = DBReadString(rDataReader, "Description")
        pShift.IsDirty = False
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
    pShift = New dmShift ' Or .NewBlankShift
    Return pShift

  End Function


  Public Function LoadShift(ByRef rShift As dmShift, ByVal vShiftID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vShiftID)
    If mOK Then
      rShift = pShift
    Else
      rShift = Nothing
    End If
    pShift = Nothing
    Return mOK
  End Function


  Public Function SaveShift(ByRef rShift As dmShift) As Boolean
    Dim mOK As Boolean
    pShift = rShift
    mOK = SaveObject()
    pShift = Nothing
    Return mOK
  End Function


  Public Function LoadShiftCollection(ByRef rShifts As colShifts) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rShifts, mParams, "ShiftID")
    rShifts.TrackDeleted = True
    If mOK Then rShifts.IsDirty = False
    Return mOK
  End Function


  Public Function SaveShiftCollection(ByRef rCollection As colShifts, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pShift In rCollection
      ''    If pShift.ShiftID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pShift.ShiftID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pShift In rCollection.DeletedItems
          If pShift.ShiftID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pShift.ShiftID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pShift In rCollection
        If pShift.IsDirty Or pShift.ShiftID = 0 Then 'Or pShift.ShiftID = 0

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


