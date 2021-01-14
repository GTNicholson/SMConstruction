Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewStockItemTransactionLogInfo

  Private Enum eBIStockItemTransactionLogID
    StockTransList = 1
    StockTransSummary = 2
    TransferList = 3
    PickingList = 4
    PickingSummary = 5
  End Enum

  Public Enum eBIReportDefs
    General = 1
    PickingTransactions = 2
  End Enum

  Private Enum eParameters
    StartDate = 1
    EndDate = 2
    TransactionType = 3
  End Enum

  Public Shared Function CreateBIReportViewStockTransactionLog(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsWoodReport As Boolean) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = StockItemTransactionLogReportSource()
    mBIReportView.DataSourceLoader = New dsoStockTransactionLogItemReportSource(rDBConn, rRTISGlobal, mBIReportView, vIsWoodReport)

    mLayoutLoader.RootFolder = rRTISGlobal.AuxFilePath
    mBIReportView.LayoutLoader = mLayoutLoader

    'Add in the Condition Setters here

    mConditionSetterList = New clsBIConditionSetterList()
    mConditionSetterList.FilterGroup = 0
    mConditionSetterList.Title = "Parámetros del Reporte"
    mConditionSetterList.DBConn = rDBConn
    mConditionSetterList.BIReportParameters = mBIReportView.BIReportSource.ColManRepParameter.GetParameterGroup(mConditionSetterList.FilterGroup)
    mConditionSetterList.ConditionSetterID = 0
    mConditionSetterList.RefLists = rRTISGlobal.RefLists
    mBIReportView.ConditionSetters.Add(mConditionSetterList)

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'filter coding
    mConditionSetterfilter.FilterGroup = 0
    mConditionSetterfilter.Title = "Filtro del Reporte"
    mConditionSetterfilter.DBConn = rDBConn
    mConditionSetterfilter.RefLists = rRTISGlobal.RefLists
    mConditionSetterfilter.BIReportParameters = mBIReportView.BIReportSource.ColManRepParameter.GetParameterGroup(mConditionSetterfilter.FilterGroup)
    mConditionSetterfilter.ConditionSetterID = 1
    mBIReportView.ConditionSetters.Add(mConditionSetterfilter)

    mBIReportView.CurrentReport = mBIReportView.BIReportSource.BIReportDefs(0)
    mBIReportView.CurrentLayout = mBIReportView.BIReportSource.BIGridLayouts(0)

    Return mBIReportView
  End Function

  Public Shared Function StockItemTransactionLogReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource
    Dim mRepDef As dmBIReportDef
    Dim mThreeMonthsAgo As DateTime = DateTime.Today.AddMonths(-3)

    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.StockItemTransactions
    mRepSource.Name = "Kardex del Inventario"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?


    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "General"
    mRepDef.Description = "Kardex del Inventario"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eBIStockItemTransactionLogID.StockTransList
    mRepSource.BIReportDefs.Add(mRepDef)


    mRepDef = CreatePickingReport()
    mRepSource.BIReportDefs.Add(mRepDef)

    AddLayouts(mRepSource)
    AddParams(mRepSource)

    Return mRepSource
  End Function

  Private Shared Sub AddLayouts(ByVal vReportSource As dmBIReportSource)
    Dim mRepDDLayout As New dmBIGridLayout
    Dim mRepLayout As New dmBIGridLayout

    mRepDDLayout = New dmBIGridLayout
    mRepDDLayout.BIGridLayoutID = eBIStockItemTransactionLogID.StockTransList
    mRepDDLayout.InterfaceType = 1
    mRepDDLayout.ParentLayoutID = 0
    mRepDDLayout.LayoutFileName = "BIStockTransactionItemList.xml"
    mRepDDLayout.LayoutName = "Kardex de Inventario"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)

    'mRepLayout = New dmBIGridLayout
    'mRepLayout.BIGridLayoutID = eBIStockItemTransactionLogID.StockTransSummary
    'mRepLayout.InterfaceType = 0
    'mRepLayout.ParentLayoutID = 0
    'mRepLayout.LayoutFileName = "BIStockTransactionItemSummary.xml"
    'mRepLayout.LayoutName = "Stock Transaction Items Summary"
    '''mRepLayout.DrillDownLayoutID = eBIStockItemTransactionLogID.StockTransList
    'mRepLayout.DrillDownLayout = mRepDDLayout
    'vReportSource.BIGridLayouts.Add(mRepLayout)

    'mRepDDLayout = New dmBIGridLayout
    'mRepDDLayout.BIGridLayoutID = eBIStockItemTransactionLogID.PickingList
    'mRepDDLayout.InterfaceType = 1
    'mRepDDLayout.ParentLayoutID = 0
    'mRepDDLayout.LayoutFileName = "BIStockTransactionItemList.xml"
    'mRepDDLayout.LayoutName = "Lista de Salidas de Productos"
    'vReportSource.BIGridLayouts.Add(mRepDDLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIStockItemTransactionLogID.PickingSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIStockTransactionItemByCategoryAndCustomerSummary.xml"
    mRepLayout.LayoutName = "Resumen de Salidas por OT"
    mRepLayout.DrillDownLayout = mRepDDLayout
    vReportSource.BIGridLayouts.Add(mRepLayout)

  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter

    mParam = New clsManRepParameter
    mParam.FieldName = "TransactionDate"
    mParam.ParamOperator = ">="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Trans Date From"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.StartDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    vReportSource.ColManRepParameter.Add(mParam)

    mParam = New clsManRepParameter
    mParam.FieldName = "TransactionDate"
    mParam.ParamOperator = "<="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Trans Date To"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.EndDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = Now.Date
    vReportSource.ColManRepParameter.Add(mParam)


    mParam = New clsManRepParameter
    mParam.FieldName = "TransactionType"
    mParam.AllowMultiple = True
    mParam.ParamOperator = "="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftRefList
    mParam.LookUpTableID = appRefLists.TransactionType
    mParam.ParamLabel = "Tipo de Transacción"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.TransactionType
    mParam.DefaultType = MRConstENUM.eDefaultType.EnteredID
    mParam.DefaultValue = -1
    vReportSource.ColManRepParameter.Add(mParam)



  End Sub

  Private Shared Function CreatePickingReport() As dmBIReportDef
    Dim mRepDef As dmBIReportDef
    Dim mParam As dmBIReportDefParamValue


    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "Detalle de Salidas de Artículos de Inventario"
    mRepDef.Description = "Salida de Inventario"
    mRepDef.BIReportDefID = eBIReportDefs.PickingTransactions
    mRepDef.BIGridLayoutID = eBIStockItemTransactionLogID.PickingSummary
    mRepDef.BIReportDefParamValues = New colBIReportDefParamValues


    mParam = New dmBIReportDefParamValue
    mParam.ManReportParameterID = eParameters.TransactionType
    mParam.ParamEntryType = MRConstENUM.eParamEntryType.UserEntryOptional
    mParam.DefaultValue = "2"
    mRepDef.BIReportDefParamValues.Add(mParam)


    Return mRepDef
  End Function
End Class
