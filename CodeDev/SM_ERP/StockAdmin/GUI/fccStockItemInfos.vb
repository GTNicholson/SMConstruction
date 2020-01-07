Imports RTIS.CommonVB

Public Class fccStockItemInfos
  Private pPrimaryKeyID As Integer

  Private pStockItem As colStockItemInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pStockItem = New colStockItemInfos

  End Sub

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property StockItemInfos As colStockItemInfos
    Get
      Return pStockItem
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoStock

    pStockItem = New colStockItemInfos

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoStock(pDBConn)
      mdso.LoadStockItemDown(pStockItem, pPrimaryKeyID)
    End If

  End Sub


  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

End Class
