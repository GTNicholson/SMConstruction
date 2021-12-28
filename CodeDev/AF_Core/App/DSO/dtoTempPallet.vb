''DTO Definition - TempPallet (to TempPallet)'Generated from Table:TempPallet

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoTempPallet : Inherits dtoBase
  Private pTempPallet As dmTempPallet

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "TempPallet"
    pKeyFieldName = "TempPalletID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pTempPallet.TempPalletID
    End Get
    Set(ByVal value As Integer)
      pTempPallet.TempPalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pTempPallet.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pTempPallet.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "TempPalletID", pTempPallet.TempPalletID)
    End If
    With pTempPallet
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpeciesID", .SpeciesID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Bulto", StringToDBValue(.Bulto))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Grosor", .Grosor)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Ancho", .Ancho)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Largo", .Largo)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemTypeID", .ItemTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Cantidad", .Cantidad)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LocationID", .LocationID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pTempPallet Is Nothing Then SetObjectToNew()
      With pTempPallet
        .TempPalletID = DBReadInt32(rDataReader, "TempPalletID")
        .SpeciesID = DBReadInt32(rDataReader, "SpeciesID")
        .Bulto = DBReadString(rDataReader, "Bulto")
        .Grosor = DBReadDecimal(rDataReader, "Grosor")
        .Ancho = DBReadDecimal(rDataReader, "Ancho")
        .Largo = DBReadDecimal(rDataReader, "Largo")
        .ItemTypeID = DBReadInt32(rDataReader, "ItemTypeID")
        .Cantidad = DBReadInt32(rDataReader, "Cantidad")
        .LocationID = DBReadInt32(rDataReader, "LocationID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        pTempPallet.IsDirty = False
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
    pTempPallet = New dmTempPallet ' Or .NewBlankTempPallet
    Return pTempPallet

  End Function


  Public Function LoadTempPallet(ByRef rTempPallet As dmTempPallet, ByVal vTempPalletID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vTempPalletID)
    If mOK Then
      rTempPallet = pTempPallet
    Else
      rTempPallet = Nothing
    End If
    pTempPallet = Nothing
    Return mOK
  End Function


  Public Function SaveTempPallet(ByRef rTempPallet As dmTempPallet) As Boolean
    Dim mOK As Boolean
    pTempPallet = rTempPallet
    mOK = SaveObject()
    pTempPallet = Nothing
    Return mOK
  End Function


  Public Function LoadTempPalletCollection(ByRef rTempPallets As colTempPallets) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rTempPallets, mParams, "TempPalletID")
    rTempPallets.TrackDeleted = True
    If mOK Then rTempPallets.IsDirty = False
    Return mOK
  End Function


  Public Function SaveTempPalletCollection(ByRef rCollection As colTempPallets) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pTempPallet In rCollection
      ''    If pTempPallet.TempPalletID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pTempPallet.TempPalletID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pTempPallet In rCollection.DeletedItems
          If pTempPallet.TempPalletID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pTempPallet.TempPalletID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pTempPallet In rCollection
        If pTempPallet.IsDirty Or pTempPallet.TempPalletID = 0 Then 'Or pTempPallet.TempPalletID = 0
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

  Public Function LoadTempPalletCollectionByWhere(ByRef rTempPallets As colTempPallets, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rTempPallets, mParams, "TempPalletID", vWhere)
    rTempPallets.TrackDeleted = True
    If mOK Then rTempPallets.IsDirty = False
    Return mOK
  End Function
End Class

