Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderItemProductMaterialRequirementInfo : Inherits dtoBase

  Private pStockItem As dmStockItem
  Private pProductRequirementInfo As clsProductlRequirementInfo

  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
  End Enum


  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    pMode = vMode
    SetTableDetails()

  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode

      Case eMode.Info, eMode.Processor
        pTableName = "vwProductRequirementInfo"
        pKeyFieldName = "SalesOrderItemProductRequirementID"
    End Select


    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges


  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductRequirementInfo.ProductRequirement.SalesOrderItemProductRequirementID

    End Get
    Set(ByVal value As Integer)
      'pStockItemTransactionLogInfo.StockCode = value
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
      Return Nothing
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductRequirementInfo Is Nothing Then SetObjectToNew()

      Select Case pMode
        Case eMode.Info, eMode.Processor

          With pProductRequirementInfo
            .Description = DBReadString(rDataReader, "Description")
            .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
            .ItemNumber = DBReadString(rDataReader, "ItemNumber")
            .ProductCode = DBReadString(rDataReader, "Code")
          End With

          With pProductRequirementInfo.ProductRequirement
            .SalesOrderItemProductRequirementID = DBReadInt32(rDataReader, "SalesOrderItemProductRequirementID")
            .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
            .ProductID = DBReadInt32(rDataReader, "ProductID")
            .AllocatedQty = DBReadDecimal(rDataReader, "AllocatedQty")
          End With


      End Select




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
    Select Case pMode
      Case eMode.Info
        pProductRequirementInfo = New clsProductlRequirementInfo
      Case eMode.Processor
        pProductRequirementInfo = New clsProductRequirementProcessor(New dmSalesOrderItemProductRequirement)

    End Select


    Return pProductRequirementInfo

  End Function


  Public Function LoadProductRequirementProcessorsByWhere(ByRef rProductRequirementProcessors As colProductRequirementProcessors, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rProductRequirementProcessors, mParams, "SalesOrderItemProductRequirementID", vWhere)
    Return mOK
  End Function

  Public Function LoadProductRequirementByWhere(ByRef rWoodMatReq As colProductMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rWoodMatReq, mParams, "SalesOrderItemProductRequirementID", vWhere)
    Return mOK
  End Function



End Class

