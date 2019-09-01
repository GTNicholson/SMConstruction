Imports RTIS.CommonVB

Public Class fccWorkOrderDetail
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pTimeSheetEntrys As colTimeSheetEntrys

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pTimeSheetEntrys = New colTimeSheetEntrys
  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property

  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales
    Dim mdsoHR As dsoHR

    pWorkOrder = New dmWorkOrder
    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSales(pDBConn)
      mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)

      pSalesOrder = New dmSalesOrder
      mdso.LoadSalesOrderAndCustomer(pSalesOrder, pWorkOrder.SalesOrderID)

      mdsoHR = New dsoHR(pDBConn)
      pTimeSheetEntrys = New colTimeSheetEntrys
      mdsoHR.LoadTimeSheetEntrysWorkOrder(pTimeSheetEntrys, pWorkOrder.WorkOrderID)

    End If
  End Sub

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoSales

    mdso = New dsoSales(pDBConn)
    mdso.SaveWorkOrderDown(pWorkOrder)

    mRetVal = True
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder.IsAnyDirty Then mRetVal = True
    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Sub RaiseWorkOrderNo()
    Dim mdso As dsoGeneral
    Dim mWONo As Integer

    mdso = New dsoGeneral(pDBConn)
    mWONo = mdso.GetNextTallyWorkOrderNo()

    pWorkOrder.WorkOrderNo = clsConstants.WorkOrderNoPrefix & mWONo.ToString("00000")

  End Sub

  Public Sub SetProductType(ByVal vNewProductType As Integer)
    Try
      If vNewProductType <> pWorkOrder.ProductTypeID Then
        pWorkOrder.ProductTypeID = vNewProductType
        pWorkOrder.Product = clsProductSharedFuncs.NewProductInstance(vNewProductType)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
