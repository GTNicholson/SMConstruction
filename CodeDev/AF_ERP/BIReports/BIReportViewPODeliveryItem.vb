
Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewPODeliveryItem
  Private Enum eBIPODeliveryItemLayoutItem
    PODItemList = 1
    PODItemSummary = 2
    PODItemCategorySummary = 3
  End Enum

  Private Enum eBIReportDefs
    General = 1
    GoodsReceivedThisMonth = 2
  End Enum

  Public Enum eParameters
    StartDate = 1
    EndDate = 2
    Status = 3
  End Enum

  Public Shared Function CreateBIReportViewFactoryPODeliveryItemInfo(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = PODeliveryItemReportSource()
    mBIReportView.DataSourceLoader = New dsoBIPODeliveryItemInfo(rDBConn, rRTISGlobal, mBIReportView)

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

  Public Shared Function PODeliveryItemReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource


    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.PODeliveryItem
    mRepSource.Name = "Recepciones de Compras por Artículo"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?


    mRepSource.BIReportDefs.Add(CreateRepDefGeneral)
    mRepSource.BIReportDefs.Add(CreateRepDefGoodsReceivedThisMonth)

    AddLayouts(mRepSource)
    AddParams(mRepSource)

    Return mRepSource
  End Function

  Private Shared Sub AddLayouts(ByVal vReportSource As dmBIReportSource)
    Dim mRepDDLayout As New dmBIGridLayout
    Dim mRepLayout As New dmBIGridLayout

    mRepDDLayout = New dmBIGridLayout
    mRepDDLayout.BIGridLayoutID = eBIPODeliveryItemLayoutItem.PODItemList
    mRepDDLayout.InterfaceType = 1
    mRepDDLayout.ParentLayoutID = 0
    mRepDDLayout.LayoutFileName = "BIPODeliveryItemList.xml"
    mRepDDLayout.LayoutName = "Lista de Recepciones por Artículos"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIPODeliveryItemLayoutItem.PODItemSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIPODeliveryItemSummary.xml"
    mRepLayout.LayoutName = "Resumen de Recepciones por Artículo"
    mRepLayout.DrillDownLayout = mRepDDLayout
    mRepLayout.DrillDownLayoutID = mRepDDLayout.DrillDownLayoutID
    vReportSource.BIGridLayouts.Add(mRepLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIPODeliveryItemLayoutItem.PODItemCategorySummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIPODeliveryItemCategorySummary.xml"
    mRepLayout.LayoutName = "Resumen de Recepciones por Categoría de Artículo"
    mRepLayout.DrillDownLayout = mRepDDLayout
    mRepLayout.DrillDownLayoutID = mRepDDLayout.DrillDownLayoutID
    vReportSource.BIGridLayouts.Add(mRepLayout)
  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter

    mParam = New clsManRepParameter
    mParam.FieldName = "DateCreated"
    mParam.ParamOperator = ">="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Fecha de Recepción"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.StartDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    vReportSource.ColManRepParameter.Add(mParam)

    mParam = New clsManRepParameter
    mParam.FieldName = "DateCreated"
    mParam.ParamOperator = "<="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Fecha de Recepción"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.EndDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = Now.Date
    vReportSource.ColManRepParameter.Add(mParam)

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
  Private Shared Function CreateRepDefGoodsReceivedThisMonth() As dmBIReportDef
    Dim mRepDef As dmBIReportDef
    Dim mParam As dmBIReportDefParamValue

    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "Recepcions este Mes"
    mRepDef.Description = "Recepcions este Mes"
    mRepDef.BIReportDefID = eBIReportDefs.GoodsReceivedThisMonth
    mRepDef.BIGridLayoutID = eBIPODeliveryItemLayoutItem.PODItemSummary 'Axel to do a new layout with Categoria de Contabilidad

    'Add any default parameter settings
    mRepDef.BIReportDefParamValues = New colBIReportDefParamValues
    mParam = New dmBIReportDefParamValue
    mParam.ManReportParameterID = eParameters.StartDate
    mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    mParam.ParamEntryType = MRConstENUM.eParamEntryType.PresetVisible
    mRepDef.BIReportDefParamValues.Add(mParam)

    mParam = New dmBIReportDefParamValue
    mParam.ManReportParameterID = eParameters.EndDate
    mParam.DefaultValue = Now
    mParam.ParamEntryType = MRConstENUM.eParamEntryType.PresetVisible
    mRepDef.BIReportDefParamValues.Add(mParam)


    Return mRepDef
  End Function
  Private Shared Function CreateRepDefGeneral() As dmBIReportDef
    Dim mRepDef As dmBIReportDef

    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "General"
    mRepDef.Description = "Recepciones de Compras por Artículo"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eBIPODeliveryItemLayoutItem.PODItemList
    Return mRepDef
  End Function

  Private Shared Sub AddPublishOptions(ByVal vReportView As clsBIReportView)
    ''Dim mPublishPDF As RTIS.BIReport.clsBIReportPublishOptionPDF

    ''mPublishPDF = New clsPDFExportSalesInvoiceTranCodes(vReportView)
    ''mPublishPDF.Name = "Sales Order Invoice Nominal Lines"
    ''vReportView.BIReportSource.BIReportPublishOptions.Add(mPublishPDF)

  End Sub


End Class
