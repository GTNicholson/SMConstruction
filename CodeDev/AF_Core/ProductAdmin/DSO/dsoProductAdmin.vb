Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoProductAdmin : Inherits dsoBase

  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Function LoadHouseTypeDown(ByRef rHouseType As dmHouseType, ByVal vHouseTypeID As Integer) As Boolean

  End Function

  Public Function SaveHouseTypeDown(ByRef rHouseType As dmHouseType) As Boolean

  End Function

  Public Function LoadHouseTypeInfos(ByRef rHouseTypeInfos As colHouseTypeInfos) As Boolean
    Dim mdto As dtoHouseTypeInfo
    Dim mRetval As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoHouseTypeInfo(pDBConn)
      mdto.LoadHouseTypeInfoCollectionByWhere(rHouseTypeInfos, "")

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetval
  End Function


  Public Function LockHouseTypeDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.LockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function UnlockHouseTypeDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.UnlockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

End Class
