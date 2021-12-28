Imports RTIS.CommonVB

Public Class fccSalesOrderPhaseMilestoneStatusDetail
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pSalesOrderPhaseID As Integer
  Private pSalesOrderPhaseMilestone As Integer
  Private pSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus

  Private pSalesOrderPhase As dmSalesOrderPhase

  Private pPurchaseOrders As colPurchaseOrders
  Private pMaterialRequirementInfos As colMaterialRequirementInfos
  Private pSuppliers As colSuppliers
  Private pHolidays As colHolidays

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus, ByVal vSalesOrderPhaseID As Integer, ByVal vMaterialCategory As Integer)
    pDBConn = rDBConn
    pSalesOrderPhaseID = vSalesOrderPhaseID
    pSalesOrderPhaseMilestone = vMaterialCategory
    pSalesOrderPhaseMilestoneStatus = rSalesOrderPhaseMilestoneStatus
    pHolidays = New colHolidays
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property SalesOrderPhaseID As Integer
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(value As Integer)
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
    End Set
  End Property

  Public Property SalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus
    Get
      Return pSalesOrderPhaseMilestoneStatus
    End Get
    Set(value As dmSalesOrderPhaseMilestoneStatus)
      pSalesOrderPhaseMilestoneStatus = value
    End Set
  End Property

  Public ReadOnly Property SalesOrderPhaseMilestone As Integer
    Get
      Return pSalesOrderPhaseMilestone
    End Get
  End Property



  Public Sub LoadObjects()
    Try
      Dim mdso As New dsoGeneral(pDBConn)
      LoadSalesOrderPhase()

      mdso.LoadHolidays(pHolidays)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub LoadSalesOrderPhase()
    Dim mdso As dsoSalesOrder
    pSalesOrderPhase = New dmSalesOrderPhase
    mdso = New dsoSalesOrder(pDBConn)
    mdso.LoadSalesOrderPhase(pSalesOrderPhase, pSalesOrderPhaseID)
  End Sub



  Public Sub SaveObjects()
    Try
      Dim mdso As dsoSalesOrder
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveSalesOrderPhaseMilestoneStatus(pSalesOrderPhaseMilestoneStatus)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub SetPhaseDateRequired(ByVal vRequiredDate As DateTime)

    pSalesOrderPhase.DateRequired = vRequiredDate

    'If RTIS.CommonVB.clsGeneralA.IsBlankDate(vRequiredDate) = False Then
    '  pSalesOrderPhase.DespatchDate = pHolidays.CalcDate(vRequiredDate, 2, True)
    '  pSalesOrderPhase.TargetProductionDate = pHolidays.CalcDate(vRequiredDate, 3, True)

    'End If

    SaveSalesOrderPhase()
  End Sub

  Private Sub SaveSalesOrderPhase()
    Dim mdso As New dsoSalesOrder(pDBConn)

    Try
      mdso.UpdateDateRequiredSOPSQL(pSalesOrderPhase.DateRequired, pSalesOrderPhase.SalesOrderPhaseID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Sub UpdateMilesStones(ByVal vDateRequired As DateTime)
    SaveObjects()
    'clsMilestoneHandler.UpdateSalesOrderPhaseMileStones(DBConn, pSalesOrderPhase.SalesOrderPhaseID, eSalesOrderPhaseMileStone.DeliveryToSiteDate, vDateRequired, pSalesOrderPhase.ManReqDays)
    'clsMilestoneHandler.UpdateSalesOrderPhaseMileStones(DBConn, pSalesOrderPhase.SalesOrderPhaseID, vDateRequired, pSalesOrderPhase.ConfirmationApprovedDays)
  End Sub


End Class
