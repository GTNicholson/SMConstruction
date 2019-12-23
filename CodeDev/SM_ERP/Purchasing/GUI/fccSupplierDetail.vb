Imports RTIS.CommonVB

Public Class fccSupplierDetail
  Private pPrimaryKeyID As Integer

  Private pSupplier As dmSupplier
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property Supplier As dmSupplier
    Get
      Return pSupplier
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales

    pSupplier = New dmSupplier

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSales(pDBConn)
      mdso.LoadSupplierDown(pSupplier, pPrimaryKeyID)
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoSales
    mdso = New dsoSales(pDBConn)
    mdso.SaveSupplierDown(pSupplier)
  End Sub
  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pSupplier.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

End Class
