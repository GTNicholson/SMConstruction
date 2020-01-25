Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewStockItemTransactionLogInfo
  Private Enum eBIStockItemTransactionLogID
    StockTransList = 1
    StockTransSummary = 2
    TransferList = 3
  End Enum

  Public Enum eBIReportDefs
    General = 1
    TransferValue = 2
  End Enum

  Private Enum eParameters
    StartDate = 1
    EndDate = 2
    IsManaged = 3
  End Enum

  Public Shared Function CreateBIReportViewStockTransactionLog(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = StockItemTransactionLogReportSource()
    mBIReportView.DataSourceLoader = New dsoStockTransactionLogItemReportSource(rDBConn, rRTISGlobal, mBIReportView)

    mLayoutLoader.RootFolder = rRTISGlobal.AuxFilePath
    mBIReportView.LayoutLoader = mLayoutLoader

    'Add in the Condition Setters here

    mConditionSetterList = New clsBIConditionSetterList()
    mConditionSetterList.FilterGroup = 0
    mConditionSetterList.Title = "Parámetros de Reporte"
    mConditionSetterList.DBConn = rDBConn
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
    mBIReportView.ConditionSetters.Add(mConditionSetterfilter)

    mBIReportView.CurrentReport = mBIReportView.BIReportSource.BIReportDefs(0)
    mBIReportView.CurrentLayout = mBIReportView.BIReportSource.BIGridLayouts(0)

    Return mBIReportView
  End Function

  Public Shared Function StockItemTransactionLogReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource
    Dim mRepDefGeneral As dmBIReportDef
    Dim mThreeMonthsAgo As DateTime = DateTime.Today.AddMonths(-3)

    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.StockItemTransactions
    mRepSource.Name = "Registro de Transacción de Ítem de Inventario"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?

    mRepDefGeneral = New dmBIReportDef
    mRepDefGeneral.ReportName = "General"
    mRepDefGeneral.Description = "Registro de Transacción de Ítem de Inventario"
    mRepDefGeneral.BIReportDefID = eBIReportDefs.General
    mRepDefGeneral.BIGridLayoutID = eBIStockItemTransactionLogID.StockTransList
    mRepSource.BIReportDefs.Add(mRepDefGeneral)


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
    mRepDDLayout.LayoutName = "Lista de Transacción de Ítem de Inventario"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIStockItemTransactionLogID.StockTransSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIStockTransactionItemSummary.xml"
    mRepLayout.LayoutName = "Resumen de Artículos de Transacción de Inventario"
    ''mRepLayout.DrillDownLayoutID = eBIStockItemTransactionLogID.StockTransList
    mRepLayout.DrillDownLayout = mRepDDLayout
    vReportSource.BIGridLayouts.Add(mRepLayout)

  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter

    mParam = New clsManRepParameter
    mParam.FieldName = "TransactionDate"
    mParam.ParamOperator = ">="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Desde la Fecha"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.StartDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    vReportSource.ColManRepParameter.Add(mParam)

    mParam = New clsManRepParameter
    mParam.FieldName = "TransactionDate"
    mParam.ParamOperator = "<="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Hasta la Fecha"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.EndDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = Now.Date
    vReportSource.ColManRepParameter.Add(mParam)

    mParam = New clsManRepParameter
    mParam.FieldName = "IsManagedStock"
    mParam.ParamOperator = "="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftBoolean
    mParam.ParamLabel = "¿El Inventario es administrado?"
    mParam.FilterGroup = 0
    mParam.ORGroup = -1 ' HACK to exclude from sql filter string
    mParam.DefaultValue = True
    mParam.ManReportParameterID = eParameters.IsManaged
    'mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    vReportSource.ColManRepParameter.Add(mParam)

  End Sub

End Class
