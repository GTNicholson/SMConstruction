Imports RTIS.BIReport
Imports RTIS.DataLayer

Public Class BIReportViewWoodPalletItemInfo

  Private Enum eBIWoodPalletItemInfoLayout
    WoodPalletItemList = 1
    WoodPalletItemSummary = 2

  End Enum

  Public Enum eBIReportDefs
    General = 1
    WoodPalletItemInfo = 2
  End Enum

  Private Enum eParameters
    ItemType = 3
  End Enum

  Public Shared Function CreateBIReportVieWoodPalletItemInfo(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal) As clsBIReportView
    Dim mBIReportView As New clsBIReportView
    Dim mLayoutLoader As New clsBILayoutLoaderFromFile
    Dim mConditionSetterList As clsBIConditionSetterList
    Dim mConditionSetterfilter As New clsBIConditionSetterFilter

    mBIReportView.BIReportSource = WoodPalletItemLogReportSource()
    mBIReportView.DataSourceLoader = New dsoWoodPalletItemReportSource(rDBConn, rRTISGlobal, mBIReportView)

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

  Public Shared Function WoodPalletItemLogReportSource() As dmBIReportSource
    Dim mRepSource As dmBIReportSource


    mRepSource = New dmBIReportSource
    mRepSource.BIReportSourceID = eReportSource.WoodPalletItemInfo
    mRepSource.Name = "Volumen de Madera por Especie"
    mRepSource.SourceInfo = "Information Only"
    mRepSource.SourceType = 0 'TODO -ENUM ?


    mRepSource.BIReportDefs.Add(CreateWoodPalletItemReport)

    AddLayouts(mRepSource)
    AddParams(mRepSource)

    Return mRepSource
  End Function

  Private Shared Sub AddLayouts(ByVal vReportSource As dmBIReportSource)
    Dim mRepDDLayout As New dmBIGridLayout
    Dim mRepLayout As New dmBIGridLayout

    mRepDDLayout = New dmBIGridLayout
    mRepDDLayout.BIGridLayoutID = eBIWoodPalletItemInfoLayout.WoodPalletItemList
    mRepDDLayout.InterfaceType = 1
    mRepDDLayout.ParentLayoutID = 0
    mRepDDLayout.LayoutFileName = "BIWoodPalletItemList.xml"
    mRepDDLayout.LayoutName = "Lista de artículos de madera"
    vReportSource.BIGridLayouts.Add(mRepDDLayout)


    mRepLayout = New dmBIGridLayout
    mRepLayout.BIGridLayoutID = eBIWoodPalletItemInfoLayout.WoodPalletItemSummary
    mRepLayout.InterfaceType = 0
    mRepLayout.ParentLayoutID = 0
    mRepLayout.LayoutFileName = "BIWoodPalletItemSummary.xml"
    mRepLayout.LayoutName = "Resumen de Volumen de Madera por Especie"
    mRepLayout.DrillDownLayout = mRepDDLayout
    mRepLayout.DrillDownLayoutID = mRepDDLayout.DrillDownLayoutID
    vReportSource.BIGridLayouts.Add(mRepLayout)



  End Sub

  Private Shared Sub AddParams(ByVal vReportSource As dmBIReportSource)
    Dim mParam As clsManRepParameter



    mParam = New clsManRepParameter
    mParam.FieldName = "ItemType"
    mParam.AllowMultiple = True
    mParam.ParamOperator = "="
    mParam.FieldType = MRConstENUM.eMRFieldType.emrftRefList
    mParam.LookUpTableID = appRefLists.StockItemType
    mParam.ParamLabel = "Tipo de Artículo"
    mParam.FilterGroup = 0
    mParam.ManReportParameterID = eParameters.ItemType
    mParam.DefaultType = MRConstENUM.eDefaultType.EnteredID
    mParam.DefaultValue = -1
    vReportSource.ColManRepParameter.Add(mParam)



  End Sub

  Private Shared Function CreateWoodPalletItemReport() As dmBIReportDef
    Dim mRepDef As dmBIReportDef

    mRepDef = New dmBIReportDef
    mRepDef.ReportName = "Detalle de Artículos de Madera por Especie"
    mRepDef.Description = "Volumen de Madera por Especie"
    mRepDef.BIReportDefID = eBIReportDefs.General
    mRepDef.BIGridLayoutID = eBIWoodPalletItemInfoLayout.WoodPalletItemList
    Return mRepDef

  End Function
End Class
