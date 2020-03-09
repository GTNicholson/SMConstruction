
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB



Public Class dtoTimeSheetEntryInfo : Inherits dtoBase
  Private pTimeSheetEntryInfo As clsTimeSheetEntryInfo

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwTimeSheetEntryInfo"
    pKeyFieldName = "TimeSheetEntryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pTimeSheetEntryInfo.TimeSheetEntry.TimeSheetEntryID
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
      If pTimeSheetEntryInfo Is Nothing Then SetObjectToNew()

      With pTimeSheetEntryInfo.TimeSheetEntry
        .TimeSheetEntryID = DBReadInteger(rDataReader, "TimeSheetEntryID")
        .TimeSheetEntryTypeID = DBReadInt32(rDataReader, "TimeSheetEntryTypeID")
        .EmployeeID = DBReadInt32(rDataReader, "EmployeeID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .WorkCentreID = DBReadInt32(rDataReader, "WorkCentreID")
        .StartTime = DBReadDateTime(rDataReader, "StartTime")
        .EndTime = DBReadDateTime(rDataReader, "EndTime")
        .Note = DBReadString(rDataReader, "Note")
        .OverTimeMinutes = DBReadInt32(rDataReader, "OverTimeMinutes")
      End With

      With pTimeSheetEntryInfo.WorkOrder
        .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
        .Description = DBReadString(rDataReader, "Description")
      End With

      With pTimeSheetEntryInfo.SalesOrder
        .ProjectName = DBReadString(rDataReader, "ProjectName")
      End With

      With pTimeSheetEntryInfo.Customer
        .CompanyName = DBReadString(rDataReader, "CompanyName")
      End With


      With pTimeSheetEntryInfo.EmployeeRateOfPay
        .StandardRate = DBReadDecimal(rDataReader, "StandardRate")
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
    pTimeSheetEntryInfo = New clsTimeSheetEntryInfo ' Or .NewBlankPurchaseInvoice
    Return pTimeSheetEntryInfo

  End Function



  Public Function LoadTimeSheetEntryInfoCollectionByWhere(ByRef rTimeSheetEntryInfos As colTimeSheetEntryInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '    mParams.Add("@SupplierID", vWhere)
    mOK = MyBase.LoadCollection(rTimeSheetEntryInfos, mParams, "TimeSheetEntryID", vWhere)
    '  If mOK Then rPurchaseInvoiceTranCodeInfos.IsDirty = False
    Return mOK
  End Function



End Class
