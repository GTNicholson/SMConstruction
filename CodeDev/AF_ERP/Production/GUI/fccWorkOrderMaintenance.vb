Imports RTIS.CommonVB

Public Class fccWorkOrderMaintenance
  Private pPrimaryKeyID As Integer
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pMaintenanceWorkOrder As dmMaintenanceWorkOrder

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn

  End Sub


  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
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


  Public Property MaintenanceWorkOrder As dmMaintenanceWorkOrder
    Get
      Return pMaintenanceWorkOrder
    End Get
    Set(value As dmMaintenanceWorkOrder)
      pMaintenanceWorkOrder = value
    End Set
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoProduction

    mdso = New dsoProduction(pDBConn)

    If pPrimaryKeyID = 0 Then

      pMaintenanceWorkOrder = New dmMaintenanceWorkOrder
      pMaintenanceWorkOrder.Status = eMaintenanceWorkOrderStatus.InProgress
    Else
      If pMaintenanceWorkOrder Is Nothing Then
        pMaintenanceWorkOrder = New dmMaintenanceWorkOrder

        mdso.LoadMaintenanceWorkOrderDown(pMaintenanceWorkOrder, pPrimaryKeyID)




      End If


    End If
  End Sub


  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoProduction

    mdso = New dsoProduction(pDBConn)
    mdso.SaveMaintenanceWorkOrder(pMaintenanceWorkOrder)

    SaveMaterialRequirement()
    mRetVal = True
    Return mRetVal
  End Function

  Private Sub SaveMaterialRequirement()
    Dim mNewMatReq As dmMaterialRequirement
    Dim mdso As New dsoProduction(pDBConn)

    For Each mItem In MaintenanceWorkOrder.MaitenanceWorkOrderItems

      If mItem.MaterialRequirement.MaterialRequirementID = 0 Then
        mNewMatReq = New dmMaterialRequirement

      Else
        mNewMatReq = mItem.MaterialRequirement
      End If

      mNewMatReq.Description = mItem.StockItem.Description
      mNewMatReq.MaterialRequirementType = eMaterialRequirementType.MaintenanceItem
      mNewMatReq.NetLenght = mItem.StockItem.Length
      mNewMatReq.NetThickness = mItem.StockItem.Thickness
      mNewMatReq.NetWidth = mItem.StockItem.Width
      mNewMatReq.ObjectID = mItem.MaintenanceWorkOrderID
      mNewMatReq.ObjectType = eObjectType.MaintenanceItem
      mNewMatReq.Quantity = mItem.Quantity
      mNewMatReq.StockCode = mItem.StockItem.StockCode
      mNewMatReq.StockItemID = mItem.StockItem.StockItemID
      mNewMatReq.UoM = mItem.StockItem.UoM
      mNewMatReq.Comments = mItem.Comments
      mNewMatReq.GeneratedQty = mItem.Quantity
      mNewMatReq.AreaID = MaintenanceWorkOrder.WorkCentreID
      mNewMatReq.IsAlreadyUsed = True
      mNewMatReq.DateChange = Now
      mItem.MaterialRequirement = mNewMatReq

      mdso.SaveMaterialRequirement(mItem.MaterialRequirement)
    Next


  End Sub



  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pMaintenanceWorkOrder IsNot Nothing Then
      If pMaintenanceWorkOrder.IsAnyDirty Then mRetVal = True

    End If
    Return mRetVal
  End Function



  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function


  Public Sub GetNextWONumber()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pMaintenanceWorkOrder.MaintenanceWorkOrderNo = "MANT-" & mdsoGeneral.GetNextTallyMaintenanceNo().ToString("00000")
  End Sub

  Public Sub ReloadMachinery()
    Dim mdso As dsoProduction
    Try
      mdso = New dsoProduction(pDBConn)
      mdso.LoadMachinery(pMaintenanceWorkOrder.Machinery, pMaintenanceWorkOrder.EquipmentID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub
End Class
