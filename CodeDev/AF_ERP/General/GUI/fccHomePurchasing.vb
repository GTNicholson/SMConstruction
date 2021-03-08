Imports RTIS.CommonVB

Public Class fccHomePurchasing
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPurchaseOrderInfoUnpaids As colPurchaseOrderInfos
  Private pPurchaseOrderCategoryMonthlys As colPurchaseOrderInfos
  Private pPODeliveryInfos As colPODeliveryInfos

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public ReadOnly Property PurchaseOrderCategoryMonthlys As colPurchaseOrderInfos
    Get
      Return pPurchaseOrderCategoryMonthlys
    End Get
  End Property

  Public ReadOnly Property PurchaseOrderInfoUnpaids As colPurchaseOrderInfos
    Get
      Return pPurchaseOrderInfoUnpaids
    End Get
  End Property

  Public ReadOnly Property PODeliveryInfos As colPODeliveryInfos
    Get
      Return pPODeliveryInfos
    End Get
  End Property


  Public Sub LoadPurchaseOrderInfosCurrentMonth()
    Dim mdsoPurchasing As dsoPurchasing
    Dim mwhere As String = ""
    Dim mStartDate As Date
    Dim mEndDate As Date

    Try

      mStartDate = New Date(Now.Year, Now.Month, 1)
      mEndDate = Now

      mwhere = String.Format("SubmissionDate between '{0}' and '{1}' and status <> {2}", mStartDate.ToShortDateString, mEndDate.ToShortDateString, CInt(ePurchaseOrderDueDateStatus.Cancelled))

      mdsoPurchasing = New dsoPurchasing(pDBConn)
      pPurchaseOrderCategoryMonthlys = New colPurchaseOrderInfos
      mdsoPurchasing.LoadPurchaseOrderInfosDown(pPurchaseOrderCategoryMonthlys, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub


  Public Sub LoadPurchaseOrderInfosUnpaid()
    Dim mdsoPurchasing As dsoPurchasing
    Dim mwhere As String = ""
    Try

      mwhere += "PaymentDate is null and Status<> " & CInt(ePurchaseOrderDueDateStatus.Cancelled)

      mdsoPurchasing = New dsoPurchasing(pDBConn)
      pPurchaseOrderInfoUnpaids = New colPurchaseOrderInfos
      mdsoPurchasing.LoadPurchaseOrderInfosDown(pPurchaseOrderInfoUnpaids, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub LoadPODeliveryInfosThisWeek()
    Dim mdsoPurchasing As dsoPurchasing
    Dim mwhere As String = ""
    Dim mStartDate As Date
    Dim mEndDate As Date

    Try

      mStartDate = RTIS.CommonVB.libDateTime.MondayOfWeek(Now)
      mEndDate = mStartDate.AddDays(7)

      mwhere = String.Format("DateCreated between '{0}' and '{1}' and GRNumber <> '' and Status = {2}", mStartDate.ToShortDateString, mEndDate.ToShortDateString, CInt(ePODelivery.Received))

      mdsoPurchasing = New dsoPurchasing(pDBConn)
      pPODeliveryInfos = New colPODeliveryInfos
      mdsoPurchasing.LoadPODeliveryInfoByWhere(pPODeliveryInfos, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub
End Class
