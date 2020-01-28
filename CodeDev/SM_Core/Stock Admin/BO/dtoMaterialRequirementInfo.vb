Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaterialRequirementInfo : Inherits dtoBase

  Private pStockItem As dmStockItem
  Private pMaterialRequirment As clsMaterialRequirementInfo

  Private pMode As eMode

  Public Enum eMode
    Info = 1
    Processor = 2
  End Enum


  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    SetTableDetails()
    pMode = vMode
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwMaterialRequirementPicking"
    pKeyFieldName = "MaterialRequirementID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaterialRequirment.MaterialRequirement.MaterialRequirementID

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
      If pMaterialRequirment Is Nothing Then SetObjectToNew()



      With pMaterialRequirment.MaterialRequirement

        .MaterialRequirementID = DBReadInt32(rDataReader, "MaterialRequirementID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .UoM = DBReadString(rDataReader, "UoM")
        .AreaID = DBReadInt32(rDataReader, "AreaID")
        .Comments = DBReadString(rDataReader, "Comments")
        .MaterialRequirementType = DBReadByte(rDataReader, "MaterialRequirementType")
        .SetPickedQty(DBReadDecimal(rDataReader, "PickedQty"))
        .SupplierStockCode = DBReadString(rDataReader, "SupplierStockCode")


      End With
      With pMaterialRequirment.StockItem
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Category = DBReadByte(rDataReader, "Category")
        .PartNo = DBReadString(rDataReader, "PartNo")
        .Description = DBReadString(rDataReader, "SIDESCRIPTION")

      End With


      With pMaterialRequirment.WorkOrder
        .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
        .Description = DBReadString(rDataReader, "WODESCRIPTION")

      End With

      ''With pMaterialRequirment.c
      ''  .CompanyName = DBReadString(rDataReader, "CompanyName")

      ''End With

      ''With pSalesOrder
      ''  .OrderNo = DBReadString(rDataReader, "OrderNo")

      ''End With

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
        pMaterialRequirment = New clsMaterialRequirementInfo
      Case eMode.Processor
        pMaterialRequirment = New clsMaterialRequirementProcessor(New dmMaterialRequirement)
    End Select


    Return pMaterialRequirment

  End Function


  Public Function LoadMaterialRequirementProcessorsByWhere(ByRef rMaterialRequirementProcessors As colMaterialRequirementProcessors, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rMaterialRequirementProcessors, mParams, "MaterialRequirementID", vWhere)
    Return mOK
  End Function

  Public Function LoadMaterialRequirementCollection(ByRef rMaterialRequirementInfos As colMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    ''mParams.Add("@ParentID", vParentID)
    If vWhere <> "" Then
      mOK = MyBase.LoadCollection(rMaterialRequirementInfos, mParams, "MaterialRequirementID", vWhere)
    Else
      mOK = MyBase.LoadCollection(rMaterialRequirementInfos, mParams, "MaterialRequirementID")
    End If

    Return mOK


  End Function

End Class

