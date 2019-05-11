﻿
Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewWorkOrder
  Private Enum eBIWorkOrderLayoutID
    WorkOrderList = 1
    WorkOrderSummary = 2
  End Enum

  Private Enum eBIReportDefs
    General = 1
  End Enum

  Public Enum eParameters
    StartDate = 1
    EndDate = 2
    Status = 3
  End Enum

  Public Shared Function CreateBIReportViewFactoryWorkOrder(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = WorkOrderReportSource()
    mBIReportView.DataSourceLoader = New dsoBIWorkOrder(rDBConn, rRTISGlobal, mBIReportView)

    mLayoutLoader.RootFolder = rRTISGlobal.AuxFilePath
    mBIReportView.LayoutLoader = mLayoutLoader

    'Add in the Condition Setters here

    mConditionSetterList = New clsBIConditionSetterList()
    mConditionSetterList.FilterGroup = 0
    mConditionSetterList.Title = "Report Parameters"
    mConditionSetterList.DBConn = rDBConn
    mConditionSetterList.RefLists = rRTISGlobal.RefLists
    mConditionSetterList.BIReportParameters = mBIReportView.BIReportSource.ColManRepParameter.GetParameterGroup(mConditionSetterList.FilterGroup)
    mConditionSetterList.ConditionSetterID = 0
    mBIReportView.ConditionSetters.Add(mConditionSetterList)

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'filter coding
    mConditionSetterfilter.FilterGroup = 1
    mConditionSetterfilter.Title = "Report Filter"
    mConditionSetterfilter.DBConn = rDBConn
    mConditionSetterfilter.RefLists = rRTISGlobal.RefLists
    mConditionSetterfilter.BIReportParameters = mBIReportView.BIReportSource.ColManRepParameter.GetParameterGroup(mConditionSetterfilter.FilterGroup)
    mConditionSetterfilter.ConditionSetterID = 1
    mBIReportView.ConditionSetters.Add(mConditionSetterfilter) 'uncomment when want filter group

    mBIReportView.CurrentReport = mBIReportView.BIReportSource.BIReportDefs(0)
    mBIReportView.CurrentLayout = mBIReportView.BIReportSource.BIGridLayouts(0)

    AddPublishOptions(mBIReportView)

    Return mBIReportView
  End Function

  Public Shared Function WorkOrderReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource
    Dim mThreeMonthsAgo As DateTime = DateTime.Today.AddMonths(-3)

    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.WorkOrder
    mRepSource.Name = "Ordenes de Trabajo"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?


    mRepSource.BIReportDefs.Add(CreateRepDefGeneral)

    AddLayouts(mRepSource)
    AddParams(mRepSource)

    Return mRepSource
  End Function

  Private Shared Sub AddLayouts(ByVal vReportSource As dmBIReportSource)
    Dim mRepDDLayout As New dmBIGridLayout
    Dim mRepLayout As New dmBIGridLayout

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWorkOrderLayoutID.WorkOrderList
    mRepLayout.InterfaceType = 1
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIWorkOrderList.xml"
    mRepLayout.LayoutName = "Orden de Trabajo Lista"
    vReportSource.BIGridLayouts.Add(mRepLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWorkOrderLayoutID.WorkOrderSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIWorkOrderSummary.xml"
    mRepLayout.LayoutName = "Orden de Trabajo Resumen"
    vReportSource.BIGridLayouts.Add(mRepLayout)


  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    ''Dim mParam As clsManRepParameter

    ''mParam = New clsManRepParameter
    ''mParam.FieldName = "DateTransferred"
    ''mParam.ParamOperator = ">="
    ''mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    ''mParam.ParamLabel = "Posted Date From"
    ''mParam.FilterGroup = 0
    ''mParam.ManReportParameterID = eParameters.StartDate
    ''mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    ''mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    ''vReportSource.ColManRepParameter.Add(mParam)

    ''mParam = New clsManRepParameter
    ''mParam.FieldName = "DateTransferred"
    ''mParam.ParamOperator = "<="
    ''mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    ''mParam.ParamLabel = "Posted Date To"
    ''mParam.FilterGroup = 0
    ''mParam.ManReportParameterID = eParameters.EndDate
    ''mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    ''mParam.DefaultValue = Now.Date
    ''vReportSource.ColManRepParameter.Add(mParam)

    ''mParam = New clsManRepParameter
    ''mParam.FieldName = "PIStatusENUM"
    ''mParam.ParamOperator = "="
    ''mParam.FieldType = MRConstENUM.eMRFieldType.emrftRefList
    ''mParam.LookUpTableID = appRefLists.PurchaseInvoiceStatus
    ''mParam.ParamLabel = "Status"
    ''mParam.FilterGroup = 1
    ''mParam.ManReportParameterID = eParameters.Status
    ''mParam.DefaultType = MRConstENUM.eDefaultType.EnteredID
    ''mParam.DefaultValue = ePurchaseInvoiceStatus.Posted
    ''vReportSource.ColManRepParameter.Add(mParam)


  End Sub

  Private Shared Function CreateRepDefGeneral() As dmBIReportDef
    Dim mRepDef As dmBIReportDef

    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "General"
    mRepDef.Description = "Work Orders"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eReportSource.WorkOrder
    Return mRepDef
  End Function

  Private Shared Sub AddPublishOptions(ByVal vReportView As clsBIReportView)
    ''Dim mPublishPDF As RTIS.BIReport.clsBIReportPublishOptionPDF

    ''mPublishPDF = New clsPDFExportSalesInvoiceTranCodes(vReportView)
    ''mPublishPDF.Name = "Sales Order Invoice Nominal Lines"
    ''vReportView.BIReportSource.BIReportPublishOptions.Add(mPublishPDF)

  End Sub


End Class