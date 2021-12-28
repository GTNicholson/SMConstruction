Imports RTIS.CommonVB
Imports RTIS.CommonVB.libDateTime

Public Class fccPhaseManagement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pSalesOrderPhaseInfos As colSalesOrderPhaseInfos

  Public ReadOnly Property SalesOrderPhaseInfos As colSalesOrderPhaseInfos
    Get
      Return pSalesOrderPhaseInfos
    End Get
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pSalesOrderPhaseInfos = New colSalesOrderPhaseInfos
  End Sub


  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Sub LoadObject()
    Dim mdso As dsoSalesOrder
    Dim mDateString As String
    Dim mWhere As String
    Try

      mdso = New dsoSalesOrder(pDBConn)
      pSalesOrderPhaseInfos = New colSalesOrderPhaseInfos

      ''mDateString = Format(DateAdd(DateInterval.Month, -3, Date.Now), "yyyyMMdd")

      mWhere = String.Format("IsNull(ProjectName,'') <>'' and OrderStatusENUM not in ({0},{1}) and OrderTypeID in ({2},{3},{4},{5})", CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed), CInt(eOrderType.Sales), CInt(eOrderType.Furnitures), CInt(eOrderType.Interno), CInt(eOrderType.InternalFurniture))

      'String.Format("SpecStatus <> {0} AND DespatchStatus < {1}", CInt(eSpecificationStatus.Cancelled), CInt(eDespatchStatus.All))

      mdso.LoadSalesOrderPhaseInfoWithMilestones(pSalesOrderPhaseInfos, mWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub



  Public Sub ReloadMilestonesForSalesOrderPhase(ByRef rSalesOrderPhaseInfo As clsSalesOrderPhaseInfo)
    Dim mdso As dsoSalesOrder
    Try

      mdso = New dsoSalesOrder(pDBConn)

      rSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.Clear()
      mdso.LoadSalesOrderPhaseInfoMilestones(rSalesOrderPhaseInfo)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub


  Public Sub UpdateOrderReceivedDate(ByVal vOrderReceivedDate As Date, ByVal vSalesOrderPhaseID As Integer)
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    mdsoSalesOrder.UpdateOrderReceivedDate(vSalesOrderPhaseID, vOrderReceivedDate)
  End Sub




  Public Function GetCurrentTargetScheduleApprovedColumnInfo(ByVal vSalesOrderPhaseID As Integer) As String
    Dim mTargetDate As Date
    Dim mSOPMSs As colSalesOrderPhaseMilestoneStatuss
    Dim mScheduleApproved As dmSalesOrderPhaseMilestoneStatus
    Dim mRetval As String


    mSOPMSs = pSalesOrderPhaseInfos.ItemBySalesOrderPhaseID(vSalesOrderPhaseID).SalesOrderPhaseMilestoneStatuss

    If mSOPMSs IsNot Nothing Then

      mScheduleApproved = mSOPMSs.ItemFromMilestoneENUM(eSalesOrderPhaseMileStone.Metales)



      If mScheduleApproved IsNot Nothing Then

        If mScheduleApproved.ActualDate = Date.MinValue Then
          mTargetDate = mScheduleApproved.TargetDate
          mRetval = mTargetDate.ToString("dd-MMM")

        ElseIf mScheduleApproved.ActualDate <> Date.MinValue And mScheduleApproved.TargetDate = Date.MinValue Then
          mTargetDate = mScheduleApproved.ActualDate
          mRetval = mTargetDate.ToString("dd-MMM")

        ElseIf mScheduleApproved.ActualDate <> Date.MinValue And mScheduleApproved.TargetDate <> Date.MinValue Then
          mTargetDate = mScheduleApproved.ActualDate
          mRetval = mTargetDate.ToString("dd-MMM")

        End If




      End If
    End If


    Return mRetval
  End Function







  Public Sub SaveSalesOrderPhaseMileStone(ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus)
    Dim mdso As New dsoSalesOrder(pDBConn)
    Try
      mdso.SaveSalesOrderPhaseMilestoneStatus(rSalesOrderPhaseMilestoneStatus)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
