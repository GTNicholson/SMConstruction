
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB



Public Class dtoHouseTypeInfo : Inherits dtoBase
  Private pHouseTypeInfo As clsHouseTypeInfo

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwHouseTypeInfo"
    pKeyFieldName = "HouseTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pHouseTypeInfo.HouseType.HouseTypeID
    End Get
    Set(ByVal value As Integer)
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = False
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub



  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pHouseTypeInfo Is Nothing Then SetObjectToNew()

      With pHouseTypeInfo.HouseType
        .HouseTypeID = DBReadInteger(rDataReader, "HouseTypeID")
        .ModelName = DBReadString(rDataReader, "ModelName")
        .GroupID = DBReadInt32(rDataReader, "GroupID")
        .ModelID = DBReadInt32(rDataReader, "ModelID")
        .Area = DBReadDecimal(rDataReader, "Area")

      End With

      mOK = True
    Catch Ex As Exception
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pHouseTypeInfo = New clsHouseTypeInfo
    Return pHouseTypeInfo

  End Function



  Public Function LoadHouseTypeInfoCollectionByWhere(ByRef rHouseTypeInfos As colHouseTypeInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rHouseTypeInfos, mParams, "HouseTypeID", vWhere)
    Return mOK
  End Function



End Class
