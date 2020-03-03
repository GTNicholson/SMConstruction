Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class dtoInvoiceInfo : Inherits dtoBase
  Private pInvoiceInfo As clsInvoiceInfo
  Private pMode As clsInvoiceInfo.eInvoicePredictedType

  Public Sub New(ByRef rDBConn As clsDBConnBase, ByVal vMode As clsInvoiceInfo.eInvoicePredictedType)
    MyBase.New(rDBConn)
    pMode = vMode
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    Select Case pMode
      Case clsInvoiceInfo.eInvoicePredictedType.Invoice
        pTableName = "vwInvoiceInfo"
      Case clsInvoiceInfo.eInvoicePredictedType.Packed
        pTableName = "vwInvoiceInfoPredictedPacked"
      Case clsInvoiceInfo.eInvoicePredictedType.Engineered
        pTableName = "vwInvoiceInfoPredictedEngineering"
      Case clsInvoiceInfo.eInvoicePredictedType.Pending
        pTableName = "vwInvoiceInfoPredictedPending"
    End Select
  End Sub

  Public Overrides Property IsDirtyValue As Boolean
    Get
      Return False
    End Get
    Set(value As Boolean)
    End Set
  End Property

  Public Overrides Property ObjectKeyFieldValue As Integer
    Get
      Return pInvoiceInfo.InvoiceID
    End Get
    Set(value As Integer)
    End Set
  End Property

  Public Overrides Property RowVersionValue As ULong
    Get
      Return 0
    End Get
    Set(value As ULong)
    End Set
  End Property

  Public Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As IDataParameterCollection, vSetList As Boolean)
  End Sub


  Public Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pInvoiceInfo Is Nothing Then SetObjectToNew()
      pInvoiceInfo.InvoicePredictedType = pMode

      With pInvoiceInfo.Invoice
        .InvoiceID = DBReadInt32(rDataReader, "InvoiceID")
        .InvoiceNo = DBReadString(rDataReader, "InvoiceNo")
        .InvoiceDate = DBReadDateTime(rDataReader, "InvoiceDate")
        .NetValue = DBReadDecimal(rDataReader, "NetValue")
        ''.InvoiceStatus = DBReadInt16(rDataReader, "InvoiceStatus")
      End With
      With pInvoiceInfo.SalesOrder
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        .FinishDate = DBReadDateTime(rDataReader, "FinishDate")
        .DueTime = DBReadDateTime(rDataReader, "DueTime")
      End With
      With pInvoiceInfo.Customer
        .CompanyName = DBReadString(rDataReader, "CompanyName")
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
    pInvoiceInfo = New clsInvoiceInfo
    Return pInvoiceInfo
  End Function

  Public Function LoadInvoiceCollectionByWhere(ByRef rInvoiceInfos As colInvoiceInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rInvoiceInfos, mParams, "InvoiceID", vWhere)

    Return mOK
  End Function

End Class
