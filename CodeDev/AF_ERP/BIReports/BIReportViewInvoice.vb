﻿Imports RTIS.BIReport
Imports RTIS.DataLayer
Public Class BIReportViewInvoice
  Private Enum eBIWorkOrderLayoutID
    InvoiceList = 1
    InvoiceSummary = 2
    Chart = 3
  End Enum

  Private Enum eBIReportDefs
    General = 1
  End Enum

  Public Enum eParameters
    StartDate = 1
    EndDate = 2
    IncludePredicted = 3
  End Enum

  Public Shared Function CreateBIReportViewFactorInvoice(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = InvoiceReportSource()
    mBIReportView.DataSourceLoader = New dsoBIInvoice(rDBConn, rRTISGlobal, mBIReportView)

    mLayoutLoader.RootFolder = rRTISGlobal.AuxFilePath
    mBIReportView.LayoutLoader = mLayoutLoader

    'Add in the Condition Setters here

    mConditionSetterList = New clsBIConditionSetterList()
    mConditionSetterList.FilterGroup = 0
    mConditionSetterList.Title = "Parámetros de Reporte"
    mConditionSetterList.DBConn = rDBConn
    mConditionSetterList.RefLists = rRTISGlobal.RefLists
    mConditionSetterList.BIReportParameters = mBIReportView.BIReportSource.ColManRepParameter.GetParameterGroup(mConditionSetterList.FilterGroup)
    mConditionSetterList.ConditionSetterID = 0
    mBIReportView.ConditionSetters.Add(mConditionSetterList)

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'filter coding
    mConditionSetterfilter.FilterGroup = 1
    mConditionSetterfilter.Title = "Filtro de Reporte"
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

  Public Shared Function InvoiceReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource
    Dim mThreeMonthsAgo As DateTime = DateTime.Today.AddMonths(-3)

    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.Invoice
    mRepSource.Name = "Facturas"
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

    mRepDDLayout = New dmBIGridLayout
    mRepDDLayout.BIGridLayoutID = eBIWorkOrderLayoutID.InvoiceList
    mRepDDLayout.InterfaceType = 1
    mRepDDLayout.ParentLayoutID = 0
    mRepDDLayout.LayoutFileName = "BIInvoiceList.xml"
    mRepDDLayout.LayoutName = "Lista de Faturas"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWorkOrderLayoutID.InvoiceSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIInvoiceSummary.xml"
    mRepLayout.LayoutName = "Resumen de Facturas"
    mRepLayout.DrillDownLayoutID = eBIWorkOrderLayoutID.InvoiceList
    mRepLayout.DrillDownLayout = mRepDDLayout
    vReportSource.BIGridLayouts.Add(mRepLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWorkOrderLayoutID.Chart
    mRepLayout.InterfaceType = 3
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIInvoiceChart.xml"
    mRepLayout.LayoutName = "Gráfica de Facturas"
    vReportSource.BIGridLayouts.Add(mRepLayout)

  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter

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

    mParam = New clsManRepParameter
    mParam.FieldName = "IncludePredicted"
    mParam.ParamOperator = "="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftBoolean
    mParam.ParamLabel = "Incluir Metas"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.IncludePredicted
    mParam.DefaultType = MRConstENUM.eDefaultType.EnteredID
    mParam.DefaultValue = False
    mParam.ExcludeFromSQLBuild = True
    vReportSource.ColManRepParameter.Add(mParam)


  End Sub

  Private Shared Function CreateRepDefGeneral() As dmBIReportDef
    Dim mRepDef As dmBIReportDef

    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "General"
    mRepDef.Description = "Facturas"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eBIWorkOrderLayoutID.InvoiceList
    Return mRepDef
  End Function

  Private Shared Sub AddPublishOptions(ByVal vReportView As clsBIReportView)
    ''Dim mPublishPDF As RTIS.BIReport.clsBIReportPublishOptionPDF

    ''mPublishPDF = New clsPDFExportSalesInvoiceTranCodes(vReportView)
    ''mPublishPDF.Name = "Sales Order Invoice Nominal Lines"
    ''vReportView.BIReportSource.BIReportPublishOptions.Add(mPublishPDF)

  End Sub


End Class
