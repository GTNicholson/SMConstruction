Imports RTIS.CommonVB

Public Class fccWoodWorkOrderMilestoneStatus
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus
  Private pWoodMaterialRequirementInfos As colMaterialRequirementInfos
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus)
    pDBConn = rDBConn
    pWorkOrderMilestoneStatus = rWorkOrderMilestoneStatus
    pWoodMaterialRequirementInfos = New colMaterialRequirementInfos
  End Sub

  Public Property WoodMaterialRequirementInfos As colMaterialRequirementInfos
    Get
      Return pWoodMaterialRequirementInfos
    End Get
    Set(value As colMaterialRequirementInfos)
      pWoodMaterialRequirementInfos = value
    End Set
  End Property
  Public ReadOnly Property WorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus
    Get
      Return pWorkOrderMilestoneStatus
    End Get
  End Property

  Public Sub SaveObject()
    Dim mdso As dsoProduction
    mdso = New dsoProduction(pDBConn)
    mdso.SaveWorkOrderTracking(pWorkOrderMilestoneStatus)
  End Sub

  Public Sub LoadDataRef()
    Dim mWhere As String = ""
    Dim mdso As New dsoStock(pDBConn)
    Try
      mWhere = String.Format("ObjectID = {0}", pWorkOrderMilestoneStatus.WorkOrderID)
      mdso.LoadWoodMaterialRequirementInfosByWhere(pWoodMaterialRequirementInfos, mWhere, dtoMaterialRequirementInfo.eMode.WoodMat)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub

  Public Sub LoadWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      Dim mdso As New dsoSalesOrder(pDBConn)
      mdso.LoadWorkOrderDown(rWorkOrder, pWorkOrderMilestoneStatus.WorkOrderID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub
End Class
