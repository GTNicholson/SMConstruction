Imports RTIS.CommonVB

Public Class fccSupplierDetail
  Private pPrimaryKeyID As Integer

  Private pSupplier As dmSupplier
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pPurchaseOrders As colPurchaseOrders


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pPurchaseOrders = New colPurchaseOrders
  End Sub

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property


  Public Property PurchaseOrders As colPurchaseOrders
    Get
      Return pPurchaseOrders
    End Get
    Set(value As colPurchaseOrders)
      pPurchaseOrders = value
    End Set
  End Property

  Public ReadOnly Property Supplier As dmSupplier
    Get
      Return pSupplier
    End Get
  End Property


  Public Sub LoadObjects()

    Dim mdso As dsoPurchasing
    Dim mWhere As String = ""
    Dim mSubmissionDate As Date = Today
    pSupplier = New dmSupplier

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoPurchasing(pDBConn)
      mdso.LoadSupplierDown(pSupplier, pPrimaryKeyID)

      ''//Load POs active and live
      mSubmissionDate = mSubmissionDate.AddMonths(-3) ''Last 3 months of PO actives

      mWhere = "SupplierID = " & pSupplier.SupplierID & " and (Status <> 6 and Status <>4) and SubmissionDate between '" & mSubmissionDate.ToShortDateString & "' and '" & Today.ToShortDateString & "'"

      mdso.LoadPurchaseOrderCollectionDown(pPurchaseOrders, mWhere)

    Else
      pSupplier.PrintAccountOption = eSupplirPrintOption.MainAccount
      pSupplier.SupplierStatusID = eSupplierStatus.Active
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoPurchasing
    mdso = New dsoPurchasing(pDBConn)
    If pSupplier.CompanyName <> "" Then
      mdso.SaveSupplierDown(pSupplier)
    End If
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
