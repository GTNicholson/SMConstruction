Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements


Public Class fccGlobalStockItemChange
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pSelectedStockItemEditors As colStockItems
  Private pCurrentStockItem As dmStockItem



  Public Property CurrentStockItem() As dmStockItem
      Get
        Return pCurrentStockItem
      End Get
      Set(value As dmStockItem)
        pCurrentStockItem = value
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

    Public Property RTISGlobal() As AppRTISGlobal
      Get
        RTISGlobal = pRTISGlobal
      End Get
      Set(ByVal value As AppRTISGlobal)
        pRTISGlobal = value
      End Set
    End Property


  Public Property StockItemEditors As colStockItems
    Get
      Return pSelectedStockItemEditors
    End Get
    Set(value As colStockItems)
      pSelectedStockItemEditors = value
    End Set
  End Property


  Public Function IsDirty() As Boolean
      Dim mIsDirty As Boolean = True
      ''If Not MainObject Is Nothing Then
      ''  mIsDirty = MainObject.IsAnyDirty
      ''Else
      ''  mIsDirty = False
      ''End If
      Return mIsDirty
    End Function

    Public Function ValidateObject() As clsValidate
      Dim mValidate As New clsValidate
      mValidate.ValOk = True
      If False Then '' Change to perform validation checks
        mValidate.ValOk = False
      mValidate.AddMsgLine("Detalles de validación")
    End If
      Return mValidate
    End Function

  Public Sub SetCurrentStockItemInfo(ByRef rStockItemEditor As dmStockItem)
    pCurrentStockItem = rStockItemEditor

  End Sub

  Public Sub SaveObject()
      Try

        If pCurrentStockItem IsNot Nothing Then
          Dim mdsoStock As New dsoStock(pDBConn)
          mdsoStock.SaveStockItem(pCurrentStockItem)
          mdsoStock = Nothing
        End If

      Catch ex As Exception
        If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
      End Try

    End Sub

    Public Sub UpdateStockManagementType(ByVal vStockType As Integer)

      For Each mItem In pSelectedStockItemEditors

      If mItem.IsSelected Then

        'mItem.StockItem.StockManagementType = vStockType

      End If

    Next

    End Sub

  Public Function GetNextStockCodeSuffix(ByVal vStockCodeStem As String) As String
    Dim mdso As New dsoStock(pDBConn)
    Dim mRetVal As String = ""

    mRetVal = mdso.GetNextStockCodeSuffixNo(vStockCodeStem).ToString("0000")

    Return mRetVal
  End Function
End Class
