Imports System.ComponentModel
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Public Class fccLookupTableList

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pLookUpListDT As DataTable

  Public Enum eSelectionCode
    <Description("General")> General = 5
    <Description("Especification de Producto")> Specification = 6
    <Description("Finanzas")> Tender = 7
  End Enum

  Public Property LookUpListDT As DataTable
    Get
      Return pLookUpListDT
    End Get
    Set(value As DataTable)
      pLookUpListDT = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property


  Public Sub New(ByVal vDBConn As clsDBConnBase, ByVal vRTISGlobal As AppRTISGlobal)

    pDBConn = vDBConn
    pRTISGlobal = vRTISGlobal

  End Sub

  Public Sub LoadObjects()

    Try
      pDBConn.Connect()
      pLookUpListDT = pDBConn.CreateDataTable("SELECT * FROM dbo.LookUpTable WHERE SelectionCode >4 order by LookUpTableDescription")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub
End Class
