''DTO Definition - EmployeeRateOfPay (to EmployeeRateOfPay)'Generated from Table:EmployeeRateOfPay

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoEmployeeRateOfPay : Inherits dtoBase
  Private pEmployeeRateOfPay As dmEmployeeRateOfPay

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "EmployeeRateOfPay"
    pKeyFieldName = "EmployeeRateOfPayID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pEmployeeRateOfPay.EmployeeRateOfPayID
    End Get
    Set(ByVal value As Integer)
      pEmployeeRateOfPay.EmployeeRateOfPayID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pEmployeeRateOfPay.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pEmployeeRateOfPay.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "EmployeeRateOfPayID", pEmployeeRateOfPay.EmployeeRateOfPayID)
    End If
    With pEmployeeRateOfPay
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmployeeID", .EmployeeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PayType", .PayType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StartDate", DateToDBValue(.StartDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StandardRate", .StandardRate)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pEmployeeRateOfPay Is Nothing Then SetObjectToNew()
      With pEmployeeRateOfPay
        .EmployeeRateOfPayID = DBReadInt32(rDataReader, "EmployeeRateOfPayID")
        .EmployeeID = DBReadInt32(rDataReader, "EmployeeID")
        .PayType = DBReadByte(rDataReader, "PayType")
        .StartDate = DBReadDateTime(rDataReader, "StartDate")
        .StandardRate = DBReadDecimal(rDataReader, "StandardRate")
        pEmployeeRateOfPay.IsDirty = False
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
    pEmployeeRateOfPay = New dmEmployeeRateOfPay ' Or .NewBlankEmployeeRateOfPay
    Return pEmployeeRateOfPay

  End Function


  Public Function LoadEmployeeRateOfPay(ByRef rEmployeeRateOfPay As dmEmployeeRateOfPay, ByVal vEmployeeRateOfPayID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vEmployeeRateOfPayID)
    If mOK Then
      rEmployeeRateOfPay = pEmployeeRateOfPay
    Else
      rEmployeeRateOfPay = Nothing
    End If
    pEmployeeRateOfPay = Nothing
    Return mOK
  End Function


  Public Function SaveEmployeeRateOfPay(ByRef rEmployeeRateOfPay As dmEmployeeRateOfPay) As Boolean
    Dim mOK As Boolean
    pEmployeeRateOfPay = rEmployeeRateOfPay
    mOK = SaveObject()
    pEmployeeRateOfPay = Nothing
    Return mOK
  End Function


  Public Function LoadEmployeeRateOfPayCollection(ByRef rEmployeeRateOfPays As colEmployeeRateOfPays, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@EmployeeID", vParentID)
    mOK = MyBase.LoadCollection(rEmployeeRateOfPays, mParams, "EmployeeRateOfPayID")
    rEmployeeRateOfPays.TrackDeleted = True
    If mOK Then rEmployeeRateOfPays.IsDirty = False
    Return mOK
  End Function


  Public Function SaveEmployeeRateOfPayCollection(ByRef rCollection As colEmployeeRateOfPays, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@EmployeeID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pEmployeeRateOfPay In rCollection
      ''    If pEmployeeRateOfPay.EmployeeRateOfPayID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pEmployeeRateOfPay.EmployeeRateOfPayID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pEmployeeRateOfPay In rCollection.DeletedItems
          If pEmployeeRateOfPay.EmployeeRateOfPayID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pEmployeeRateOfPay.EmployeeRateOfPayID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pEmployeeRateOfPay In rCollection
        If pEmployeeRateOfPay.IsDirty Or pEmployeeRateOfPay.EmployeeID <> vParentID Or pEmployeeRateOfPay.EmployeeRateOfPayID = 0 Then 'Or pEmployeeRateOfPay.EmployeeRateOfPayID = 0
          pEmployeeRateOfPay.EmployeeID = vParentID
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


