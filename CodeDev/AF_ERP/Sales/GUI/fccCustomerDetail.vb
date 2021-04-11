Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccCustomerDetail
  Private pPrimaryKeyID As Integer

  Private pCustomer As dmCustomer
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pHaveLock As Boolean

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property
  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
  End Property

  Public ReadOnly Property HaveLock As Boolean
    Get
      Return pHaveLock
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSalesOrder

    pCustomer = New dmCustomer

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSalesOrder(pDBConn)

      pHaveLock = mdso.LockCustomerDisconnected(pPrimaryKeyID)

      mdso.LoadCustomerDown(pCustomer, pPrimaryKeyID)
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoSalesOrder
    mdso = New dsoSalesOrder(pDBConn)

    mdso.SaveCustomerDown(pCustomer)

    If pPrimaryKeyID = 0 Then
      pPrimaryKeyID = pCustomer.CustomerID
      pHaveLock = mdso.LockCustomerDisconnected(Me.PrimaryKeyID)
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
    mIsDirty = pCustomer.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()
    ClearLocks()

    'Me.MainObject = Nothing

  End Sub

  Private Function ClearLocks() As Boolean
    Dim mdso As dsoSalesOrder = Nothing

    Dim mOK As Boolean = True

    Try
      If pHaveLock Then
        mdso = New dsoSalesOrder(pDBConn)
        mOK = mdso.UnlockCustomerDisconnected(Me.PrimaryKeyID)
      Else
        mOK = True
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdso = Nothing
    End Try

    Return mOK
  End Function
End Class
