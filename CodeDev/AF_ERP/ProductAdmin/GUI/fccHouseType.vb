Imports RTIS.CommonVB

Public Class fccHouseType
  Private pPrimaryKeyID As Integer

  Private pHouseType As dmHouseType
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pHaveLock As Boolean

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

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
  End Property

  Public ReadOnly Property HaveLock As Boolean
    Get
      Return pHaveLock
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoProductAdmin

    pHouseType = New dmHouseType

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoProductAdmin(pDBConn)

      pHaveLock = mdso.LockHouseTypeDisconnected(pPrimaryKeyID)

      mdso.LoadHouseTypeDown(pHouseType, pPrimaryKeyID)
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoProductAdmin
    mdso = New dsoProductAdmin(pDBConn)

    mdso.SaveHouseTypeDown(pHouseType)

    If pPrimaryKeyID = 0 Then
      pPrimaryKeyID = pHouseType.HouseTypeID
      pHaveLock = mdso.LockHouseTypeDisconnected(Me.PrimaryKeyID)
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
    mIsDirty = pHouseType.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()
    ClearLocks()

    'Me.MainObject = Nothing

  End Sub

  Private Function ClearLocks() As Boolean
    Dim mdso As dsoSales = Nothing

    Dim mOK As Boolean = True

    Try
      If pHaveLock Then
        mdso = New dsoSales(pDBConn)
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
