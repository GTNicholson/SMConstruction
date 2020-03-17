Imports RTIS.CommonVB

Public Class fccInvoice
  Private pPrimaryKeyID As Integer

  Private pInvoice As dmInvoice
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

  Public ReadOnly Property Invoice As dmInvoice
    Get
      Return pInvoice
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales

    pInvoice = New dmInvoice

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSales(pDBConn)
      mdso.LoadInvoiceDown(pInvoice, pPrimaryKeyID)
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoSales
    mdso = New dsoSales(pDBConn)
    mdso.SaveInvoiceDown(pInvoice)
  End Sub
  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pInvoice.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

End Class
