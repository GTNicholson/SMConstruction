﻿Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase

Public Class dtoSalesOrderPhaseItemInfo : Inherits dtoBase
  Private pSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo


  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwSalesOrderPhaseItemInfo"

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
      Return pSalesOrderPhaseItemInfo.SalesOrderPhaseItemID
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
      If pSalesOrderPhaseItemInfo Is Nothing Then SetObjectToNew()


      With pSalesOrderPhaseItemInfo.SalesOrderPhaseItem
        .SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
        .Qty = DBReadInt32(rDataReader, "Qty")

      End With

      With pSalesOrderPhaseItemInfo.SalesOrder
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
      End With

      With pSalesOrderPhaseItemInfo.WorkOrderAllocation
        .QuantityDone = DBReadInt32(rDataReader, "QuantityDone")
      End With

      With pSalesOrderPhaseItemInfo.SalesOrderPhase
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .DateRequired = DBReadDate(rDataReader, "DateRequired")

        .PhaseNumber = DBReadInt32(rDataReader, "PhaseNumber")
        .PhaseRef = DBReadString(rDataReader, "PhaseRef")
        .JobNo = DBReadString(rDataReader, "JobNo")

      End With

      With pSalesOrderPhaseItemInfo.SalesOrderItem
        .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
        .Description = DBReadString(rDataReader, "Description")
      End With


      With pSalesOrderPhaseItemInfo.Customer
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
    pSalesOrderPhaseItemInfo = New clsSalesOrderPhaseItemInfo
    Return pSalesOrderPhaseItemInfo
  End Function

  Public Function LoadSOPICollectionByWhere(ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rSalesOrderPhaseItemInfos, mParams, "SalesOrderPhaseItemID", vWhere)

    Return mOK
  End Function



End Class
