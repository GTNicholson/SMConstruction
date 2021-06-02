Imports DevExpress.XtraGauges.Core.Model
Imports RTIS.CommonVB

Public Class fccPickWoodMaterial

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWoodPallet As dmWoodPallet
  Private pWoodPalletItemEditors As colWoodPalletItemEditors
  Private pCurrentWorkOrderInfo As clsWorkOrderInfo
  Private pWoodPallets As colWoodPallets
  Private pIsMultiSelected As Boolean
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pWoodPallet = New dmWoodPallet
    pWoodPalletItemEditors = New colWoodPalletItemEditors
    pWoodPallets = New colWoodPallets
  End Sub

  Public Property IsMultiSelected As Boolean
    Get
      Return pIsMultiSelected
    End Get
    Set(value As Boolean)
      pIsMultiSelected = value
    End Set
  End Property

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Property WoodPallet() As dmWoodPallet
    Get
      Return pWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pWoodPallet = value
    End Set
  End Property
  Public Property WoodPallets As colWoodPallets
    Get
      Return pWoodPallets
    End Get
    Set(value As colWoodPallets)
      pWoodPallets = value
    End Set
  End Property
  Public Property WoodPalletItemEditors() As colWoodPalletItemEditors
    Get
      Return pWoodPalletItemEditors
    End Get
    Set(ByVal value As colWoodPalletItemEditors)
      pWoodPalletItemEditors = value
    End Set
  End Property

  Public Property CurrentWorkOrderInfo() As clsWorkOrderInfo
    Get
      CurrentWorkOrderInfo = pCurrentWorkOrderInfo
    End Get
    Set(ByVal value As clsWorkOrderInfo)
      pCurrentWorkOrderInfo = value
    End Set
  End Property

  Public Sub LoadObjects()

    Try


      RefreshWoodPalletItemProcessor()



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub RefreshWoodPalletItemProcessor()
    Dim mWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mTempStockItem As dmStockItem
    Dim mdso As New dsoStock(pDBConn)
    pWoodPalletItemEditors.Clear()

    If pIsMultiSelected Then

      If pWoodPallets IsNot Nothing Then

        For Each mWP As dmWoodPallet In pWoodPallets

          If mWP.IsSelected Then

            For Each mWoodPalletItem As dmWoodPalletItem In mWP.WoodPalletItems
              mWoodPalletItemEditor = New clsWoodPalletItemEditor
              mTempStockItem = mdso.GetStockItemByStockItemID(mWoodPalletItem.StockItemID)

              mWoodPalletItemEditor.WoodPalletItem = mWoodPalletItem
              mWoodPalletItemEditor.StockItem = mTempStockItem

              pWoodPalletItemEditors.Add(mWoodPalletItemEditor)

            Next

          End If
        Next
      End If

    Else
      If pWoodPallet IsNot Nothing Then

        If pWoodPallet.WoodPalletItems IsNot Nothing Then

          For Each mWoodPalletItem As dmWoodPalletItem In pWoodPallet.WoodPalletItems
            mWoodPalletItemEditor = New clsWoodPalletItemEditor
            mTempStockItem = mdso.GetStockItemByStockItemID(mWoodPalletItem.StockItemID)

            mWoodPalletItemEditor.WoodPalletItem = mWoodPalletItem
            mWoodPalletItemEditor.StockItem = mTempStockItem

            pWoodPalletItemEditors.Add(mWoodPalletItemEditor)

          Next
        End If
      End If

    End If



  End Sub




  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    If Not pWoodPallet.WoodPalletItems Is Nothing Then
      mIsDirty = pWoodPallet.WoodPalletItems.IsDirty
    Else
      mIsDirty = False
    End If
    Return mIsDirty
  End Function

  Public Function ValidateObject() As clsValidate
    Dim mValidate As New clsValidate
    mValidate.ValOk = True
    If False Then '' Change to perform validation checks
      mValidate.ValOk = False
      mValidate.AddMsgLine("Check failed details")
    End If
    Return mValidate
  End Function

  Public Function ProcessPickingQtys() As Boolean
    Dim mRetVal As Boolean = True
    Dim mdsoTran As dsoStockTransactions
    Dim mWoodPalletItem As dmWoodPalletItem


    Dim mdsoStock As dsoStock

    Dim mSIL As dmStockItemLocation
    Dim mDialogResult As DialogResult
    Dim mMaterialRequirement As clsMaterialRequirementInfo


    Try

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)

      For Each mWoodPalletItemEditor As clsWoodPalletItemEditor In pWoodPalletItemEditors


        If mWoodPalletItemEditor.ToProcessQty <> 0 Then

          If (mWoodPalletItemEditor.QuantityUI - mWoodPalletItemEditor.QuantityUsed) <= 0 Or mWoodPalletItemEditor.ToProcessQty > mWoodPalletItemEditor.WoodPalletItem.Quantity Then

            mDialogResult = MessageBox.Show("La cantidad a procesar es mayor a la cantidad pedida, ¿Desea continuar?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If mDialogResult = DialogResult.No Then
              mRetVal = False
              Return mRetVal
            End If
          End If


          If mWoodPalletItemEditor.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mWoodPalletItemEditor.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If

          For Each mWoodPalletItem In pWoodPallet.WoodPalletItems

            If mWoodPalletItemEditor.WoodPalletItem.WoodPalletItemID = mWoodPalletItem.WoodPalletItemID Then
              mWoodPalletItem.QuantityUsed += mWoodPalletItemEditor.ToProcessQty
            End If

          Next


          If pCurrentWorkOrderInfo IsNot Nothing Then
            mMaterialRequirement = mdsoStock.GetPickedMaterialRequirementByWorkOrderAndStockItemID(pCurrentWorkOrderInfo.WorkOrderID, mWoodPalletItemEditor.StockItem.StockItemID)

            If mMaterialRequirement IsNot Nothing Then
              If mMaterialRequirement.PickedQty = 0 Then
                mMaterialRequirement = CreateAdditionalMatReqs(mWoodPalletItemEditor.StockItem, mWoodPalletItemEditor)

              Else
                UpdateMatReqs(mMaterialRequirement.MaterialRequirementID, mWoodPalletItemEditor.ToProcessBoardFeet, mMaterialRequirement.PickedQty)
              End If
            Else
              mMaterialRequirement = CreateAdditionalMatReqs(mWoodPalletItemEditor.StockItem, mWoodPalletItemEditor)

            End If


            mRetVal = mdsoTran.UpdateWoodPalletItemTransactionQty(mWoodPalletItemEditor.StockItem.StockItemID, 1, mWoodPalletItemEditor.ToProcessBoardFeet, 1, mWoodPalletItemEditor.WoodPalletItem, Now, mWoodPalletItemEditor.StockItem.AverageCost, 0, mMaterialRequirement, mWoodPalletItemEditor.ToProcessQty)
            ''End If
            mWoodPalletItemEditor.ToProcessQty = 0
          End If
        End If
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Private Sub UpdateMatReqs(ByVal vMaterialRequirementID As Integer, ByVal vToProcessQty As Decimal, ByVal vLastPickedQty As Decimal)
    Try
      Dim mNewPickedQty As Decimal
      mNewPickedQty = vToProcessQty + vLastPickedQty
      Dim mSql As String = ""
      mSql = String.Format("Update MaterialRequirement set PickedQty = {0} where MaterialRequirementID = {1}", mNewPickedQty, vMaterialRequirementID)


      DBConn.Connect()

      DBConn.ExecuteNonQuery(mSql)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function CreateAdditionalMatReqs(ByRef rStockItem As RTIS.ERPStock.intStockItemDef, ByRef rWoodPalletItemEditor As clsWoodPalletItemEditor) As clsMaterialRequirementInfo
    Dim mMatReqs As New colMaterialRequirements
    Dim mMatReq As dmMaterialRequirement
    Dim mdso As dsoSalesOrder
    Dim mRetVal As New clsMaterialRequirementInfo
    Try

      mdso = New dsoSalesOrder(pDBConn)

      mMatReq = New dmMaterialRequirement
      mMatReq.ObjectType = eObjectType.WorkOrder
      mMatReq.ObjectID = pCurrentWorkOrderInfo.WorkOrderID
      mMatReq.StockItemID = rStockItem.StockItemID
      mMatReq.MaterialRequirementType = eMaterialRequirementType.Wood
      mMatReq.Description = rWoodPalletItemEditor.StockItem.Description
      mMatReq.NetLenght = rWoodPalletItemEditor.WoodPalletItem.Length
      mMatReq.NetThickness = rWoodPalletItemEditor.StockItem.Thickness
      mMatReq.NetWidth = rWoodPalletItemEditor.WoodPalletItem.Width

      ''mMatReq.SetPickedQty(vPickedQty)
      mMatReq.StockCode = rWoodPalletItemEditor.StockItem.StockCode
      mMatReq.WoodSpecie = rWoodPalletItemEditor.StockItem.Species

      mMatReqs.Add(mMatReq)
      mRetVal.MaterialRequirement = mMatReq

      mdso.SaveMaterialRequirementsCollection(mMatReqs, eObjectType.WorkOrder, pCurrentWorkOrderInfo.WorkOrderID, eMaterialRequirementType.Wood)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub CreateNegativeTransaction()
    Dim mdso As New dsoStockTransactions(pDBConn)

    Try
      mdso.CreateNegativeTransaction(eTransactionType.IntoWIP, pWoodPallet, pWoodPallet.LocationID, Now, eCurrency.Dollar, 1, eObjectType.WoodPallet, False)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub


  Public Sub CreateNegativeTransactionWoodPallets()
    Dim mdso As New dsoStockTransactions(pDBConn)

    Try
      For Each mWP As dmWoodPallet In pWoodPallets
        If mWP.IsSelected Then
          mdso.CreateNegativeTransaction(eTransactionType.IntoWIP, mWP, mWP.LocationID, Now, eCurrency.Dollar, 1, eObjectType.WoodPallet, False)
        End If
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub
  Public Sub SaveWoodPallet()
    Dim mdso As New dsoStock(pDBConn)

    Try
      mdso.SaveWoodPalletDown(pWoodPallet)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub

  Public Sub SaveWoodPalletCollection()
    Dim mdso As New dsoStock(pDBConn)

    Try
      mdso.SaveWoodPalletCollectionDown(pWoodPallets)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub

  Public Function GetPickWoodMaterialByWorkOrderID(ByVal vPurchaseOrderID As Integer) As Integer
    'Dim mdso As New dsoPurchasing(pDBConn)
    'Dim mRetVal As Integer

    'mRetVal = mdso.getPODeliverysByPurchaseOrderID(vPurchaseOrderID)

    'Return mRetVal

  End Function

  Friend Function GetReceivedValue() As Decimal

    'Dim mdso As New dsoPurchasing(Me.DBConn)
    'Dim mTotalPOValue As Decimal = 0

    'If PODelivery.PODeliveryID > 0 Then
    '  mTotalPOValue = mdso.GetTotalPODeliveryValueByID(Me.PODelivery.PODeliveryID)

    'End If

    'Return mTotalPOValue
  End Function


  Public Sub RaisePickingNumber()
    'Dim mdso As dsoPurchasing
    'Dim mdsoGeneral As New dsoGeneral(pDBConn)


    'pPickWoodMaterialRequirement = New dmPODelivery

    'pPickWoodMaterialRequirement.GRNumber = mdsoGeneral.getNextTally(eTallyIDs.GRNNumber)
    'If pWoodPallet IsNot Nothing Then
    '  PODelivery.PurchaseOrderID = pWoodPallet.PurchaseOrderID
    'End If
    'mdso = New dsoPurchasing(pDBConn)
    'mdso.SavePODelivery(pPickWoodMaterialRequirement)
  End Sub

  Public Function SavePickeWoodPalletItem() As Boolean
    Dim mdso As dsoStock
    Dim mOK As Boolean = False
    Try
      mdso = New dsoStock(pDBConn)



      mOK = mdso.SaveWoodPalletDown(pWoodPallet)

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdso = Nothing
    End Try
    Return mOK
  End Function

  Public Sub CreatePurchaseOrderPDF(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery, ByVal vReprintOption As Boolean)
    'Dim mReportPath As String
    'pReprintOption = vReprintOption
    'mReportPath = CreateWoodMatPickingReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery)
    'pPickWoodMaterialRequirement.FileExport = mReportPath
  End Sub

  Public Function CreateWoodMatPickingReport(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery) As String
    'Dim mFileName As String
    'Dim mDirectory As String
    'Dim mExportFilename As String
    'Dim mRep As repPODelivery

    'Try
    '  mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PODeliveryFileFolderSys)
    '  If System.IO.Directory.Exists(mDirectory) = False Then
    '    System.IO.Directory.CreateDirectory(mDirectory)
    '  End If
    '  mFileName = String.Format("PODelivery_{0}_{1}_{2}.pdf", rPODelivery.PODeliveryID, rPODelivery.GRNumber, Today.ToString("yyyyMMdd_HHmm"))
    '  mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

    '  mRep = repPODelivery.CreatePODeliveryReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery, pReprintOption)

    '  mRep.ExportToPdf(mExportFilename)

    '  Return mExportFilename
    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    'End Try
  End Function

  Public Sub LoadWorkOrderInfos(ByRef rcolWorkOrderInfos As colWorkOrderInfos)

    Dim mdto As dtoWorkOrderInfo
    Dim mwhere As String
    mwhere = "WorkOrderID Not In (select Distinct WorkOrderID from WorkOrderMilestoneStatus Where MilestoneENUM = 10 and Status = 3)"
    mwhere += " and ( WorkOrderID in (select WorkOrderID from vwWorkOrderInfo)"
    '' mwhere = "  WorkOrderID In (Select WorkOrderID from vwWorkOrderInfo)" ''borrar todo esto, solo sirve para que se ingrese los datos
    mwhere += " Or WorkOrderId In (Select WorkOrderID from vwWorkOrderInternalInfo))"
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(DBConn, 3)
      mdto.LoadWorkOrderInfoCollectionByWhere(rcolWorkOrderInfos, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub


End Class
