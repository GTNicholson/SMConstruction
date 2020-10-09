Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoProductAdmin : Inherits dsoBase

  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Function LoadHouseTypeDown(ByRef rHouseType As dmHouseType, ByVal vHouseTypeID As Integer) As Boolean
    Dim mdto As dtoHouseType
    Dim mdtoSIA As dtoSalesItemAssembly
    Dim mdtoHouseTypeSalesItems As dtoHouseTypeSalesItem

    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoHouseType(pDBConn)
      mdto.LoadHouseType(rHouseType, vHouseTypeID)

      mdtoSIA = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.HouseTypeSalesItemAssembly)
      mdtoSIA.LoadSalesItemAssemblyCollection(rHouseType.SalesItemAssemblys, rHouseType.HouseTypeID)

      mdtoHouseTypeSalesItems = New dtoHouseTypeSalesItem(pDBConn)
      mdtoHouseTypeSalesItems.LoadHouseTypeSalesItemsCollection(rHouseType.HTSalesItems, rHouseType.HouseTypeID)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function

  Public Function SaveHouseTypeDown(ByRef rHouseType As dmHouseType) As Boolean
    Dim mdto As dtoHouseType
    Dim mdtoSIA As dtoSalesItemAssembly
    Dim mdtoHouseTypeSalesItems As dtoHouseTypeSalesItem
    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoHouseType(pDBConn)
      mdto.SaveHouseType(rHouseType)

      mdtoSIA = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.HouseTypeSalesItemAssembly)
      mdtoSIA.SaveSalesItemAssemblyCollection(rHouseType.SalesItemAssemblys, rHouseType.HouseTypeID)

      mdtoHouseTypeSalesItems = New dtoHouseTypeSalesItem(pDBConn)

      mdtoHouseTypeSalesItems.SaveHouseTypeSalesItemsCollection(rHouseType.HTSalesItems, rHouseType.HouseTypeID)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
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
