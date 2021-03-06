﻿''DTO Definition - CostBook (to CostBook)'Generated from Table:CostBook

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoCostBook : Inherits dtoBase
  Private pCostBook As dmCostBook

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "CostBook"
    pKeyFieldName = "CostBookID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pCostBook.CostBookID
    End Get
    Set(ByVal value As Integer)
      pCostBook.CostBookID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pCostBook.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pCostBook.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "CostBookID", pCostBook.CostBookID)
    End If
    With pCostBook
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookName", StringToDBValue(.CostBookName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookDate", DateToDBValue(.CostBookDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsDefault", .IsDefault)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DirectLabourCost", .DirectLabourCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DirectLabourMarkUp", .DirectLabourMarkUp)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OverheadperItem", .OverheadperItem)



    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pCostBook Is Nothing Then SetObjectToNew()
      With pCostBook
        .CostBookID = DBReadInt32(rDataReader, "CostBookID")
        .CostBookName = DBReadString(rDataReader, "CostBookName")
        .CostBookDate = DBReadDateTime(rDataReader, "CostBookDate")
        .IsDefault = DBReadBoolean(rDataReader, "IsDefault")
        .DirectLabourCost = DBReadDecimal(rDataReader, "DirectLabourCost")
        .DirectLabourMarkUp = DBReadDecimal(rDataReader, "DirectLabourMarkUp")
        .OverheadperItem = DBReadDecimal(rDataReader, "OverheadperItem")

        pCostBook.IsDirty = False
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
    pCostBook = New dmCostBook ' Or .NewBlankCostBook
    Return pCostBook

  End Function


  Public Function LoadCostBook(ByRef rCostBook As dmCostBook, ByVal vCostBookID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vCostBookID)
    If mOK Then
      rCostBook = pCostBook
    Else
      rCostBook = Nothing
    End If
    pCostBook = Nothing
    Return mOK
  End Function


  Public Function SaveCostBook(ByRef rCostBook As dmCostBook) As Boolean
    Dim mOK As Boolean
    pCostBook = rCostBook
    mOK = SaveObject()
    pCostBook = Nothing
    Return mOK
  End Function


  Public Function LoadCostBookCollection(ByRef rCostBooks As colCostBooks) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rCostBooks, mParams, "CostBookID")
    rCostBooks.TrackDeleted = True
    If mOK Then rCostBooks.IsDirty = False
    Return mOK
  End Function


  Public Function SaveCostBookCollection(ByRef rCollection As colCostBooks, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pCostBook In rCollection
      ''    If pCostBook.CostBookID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pCostBook.CostBookID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pCostBook In rCollection.DeletedItems
          If pCostBook.CostBookID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pCostBook.CostBookID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pCostBook In rCollection
        If pCostBook.IsDirty Or pCostBook.CostBookID = 0 Then 'Or pCostBook.CostBookID = 0
          'pCostBook.ParentID = vParentID
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


