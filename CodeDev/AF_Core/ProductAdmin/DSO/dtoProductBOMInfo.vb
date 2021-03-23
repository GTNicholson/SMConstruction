
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB



Public Class dtoProductBOMInfo : Inherits dtoBase
  Private pProductBOMInfo As clsProductBOMInfo

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwProductBOMInfo"
    pKeyFieldName = "ProductBOMID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductBOMInfo.ProductBOM.ProductBOMID
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
      If pProductBOMInfo Is Nothing Then SetObjectToNew()

      With pProductBOMInfo.ProductBOM
        .ProductBOMID = DBReadInteger(rDataReader, "ProductBOMID")
        .ParentID = DBReadInt32(rDataReader, "ParentID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
      End With
      With pProductBOMInfo.ProductStructure
        .Description = DBReadString(rDataReader, "Description")
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
    pProductBOMInfo = New clsProductBOMInfo
    Return pProductBOMInfo

  End Function



  Public Function LoadProductBOMInfoCollectionByWhere(ByRef rProductBOMInfos As colProductBOMInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rProductBOMInfos, mParams, "ProductBOMID", vWhere)
    Return mOK
  End Function



End Class
