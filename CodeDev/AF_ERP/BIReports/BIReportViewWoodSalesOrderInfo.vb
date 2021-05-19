Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewWoodSalesOrderInfo

  Private Enum eBIWoodSalesOrderID
    WoodSalesOrderList = 1
    WoodSalesOrderSummary = 2
  End Enum

  Public Enum eBIReportDefs
    General = 1
  End Enum

  Private Enum eParameters
    StartDate = 1
    EndDate = 2
  End Enum

  Public Shared Function CreateBIReportViewWoodSalesOrder(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = WoodSalesOrderReportSource()
    mBIReportView.DataSourceLoader = New dsoWoodSalesOrderItemReportSource(rDBConn, rRTISGlobal, mBIReportView)

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

  Public Shared Function WoodSalesOrderReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource
    Dim mRepDef As dmBIReportDef
    Dim mThreeMonthsAgo As DateTime = DateTime.Today.AddMonths(-3)

    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.StockItemTransactions
    mRepSource.Name = "Ventas de Madera"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?


    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "General"
    mRepDef.Description = "Ventas de Madera"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eBIWoodSalesOrderID.WoodSalesOrderList
    mRepSource.BIReportDefs.Add(mRepDef)

    AddLayouts(mRepSource)
    AddParams(mRepSource)

    Return mRepSource
  End Function

  Private Shared Sub AddLayouts(ByVal vReportSource As dmBIReportSource)
    Dim mRepDDLayout As New dmBIGridLayout
    Dim mRepLayout As New dmBIGridLayout

    mRepDDLayout = New dmBIGridLayout
    mRepDDLayout.BIGridLayoutID = eBIWoodSalesOrderID.WoodSalesOrderList
    mRepDDLayout.InterfaceType = 1
    mRepDDLayout.ParentLayoutID = 0
    mRepDDLayout.LayoutFileName = "BIWoodSalesOrderList.xml"
    mRepDDLayout.LayoutName = "Lista Ventas de Madera"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)

    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWoodSalesOrderID.WoodSalesOrderSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIWoodSalesOrderSummary.xml"
    mRepLayout.LayoutName = "Resumen de Ventas de Madera"
    ''mRepLayout.DrillDownLayoutID = eBIWoodSalesOrderID.StockTransList
    mRepLayout.DrillDownLayout = mRepDDLayout
    vReportSource.BIGridLayouts.Add(mRepLayout)

    'mRepDDLayout = New dmBIGridLayout
    'mRepDDLayout.BIGridLayoutID = eBIWoodSalesOrderID.PickingList
    'mRepDDLayout.InterfaceType = 1
    'mRepDDLayout.ParentLayoutID = 0
    'mRepDDLayout.LayoutFileName = "BIStockTransactionItemList.xml"
    'mRepDDLayout.LayoutName = "Lista de Salidas de Productos"
    'vReportSource.BIGridLayouts.Add(mRepDDLayout)


  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter

    mParam = New clsManRepParameter
    mParam.FieldName = "FinishDate"
    mParam.ParamOperator = ">="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Fecha desde"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.StartDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = New Date(Year(Now), Month(Now), 1)
    vReportSource.ColManRepParameter.Add(mParam)

    mParam = New clsManRepParameter
    mParam.FieldName = "FinishDate"
    mParam.ParamOperator = "<="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftDate
    mParam.ParamLabel = "Fecha Hasta"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.EndDate
    mParam.DefaultType = MRConstENUM.eDefaultType.AsEntered
    mParam.DefaultValue = Now.Date
    vReportSource.ColManRepParameter.Add(mParam)


  End Sub


End Class
