﻿Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoHR
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function LoadTimeSheetEntrysEmpIDWC(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vEmployeeID As Integer, ByVal vWCDate As Date) As Boolean
    Dim mdto As dtoTimeSheetEntry
    Dim mWhere As String
    Dim mOK As Boolean = False

    Try

      pDBConn.Connect()

      mdto = New dtoTimeSheetEntry(pDBConn)
      mWhere = String.Format("EmployeeID = {0} And StartTime >= '{1}' And StartTime < '{2}'", vEmployeeID, vWCDate.ToString("yyyyMMdd"), vWCDate.AddDays(7).ToString("yyyyMMdd"))
      mdto.LoadTimeSheetEntryCollectionByWhere(rTimeSheetEntrys, mWhere)

      mOK = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadTimeSheetEntrysEmpIDDateRange(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vEmployeeID As Integer, ByVal vStartDate As Date, ByVal vEndDate As Date) As Boolean
    Dim mdto As dtoTimeSheetEntry
    Dim mWhere As String
    Dim mOK As Boolean = False

    Try

      pDBConn.Connect()

      mdto = New dtoTimeSheetEntry(pDBConn)
      mWhere = String.Format("EmployeeID = {0} And StartTime >= '{1}' And StartTime < '{2}'", vEmployeeID, vStartDate.ToString("yyyyMMdd"), vEndDate.AddDays(1).ToString("yyyyMMdd"))
      mdto.LoadTimeSheetEntryCollectionByWhere(rTimeSheetEntrys, mWhere)

      mOK = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadTimeSheetEntrysWorkOrder(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vWorkOrderID As Integer) As Boolean
    Dim mdto As dtoTimeSheetEntry
    Dim mWhere As String
    Dim mOK As Boolean = False

    Try

      pDBConn.Connect()

      mdto = New dtoTimeSheetEntry(pDBConn)
      mWhere = String.Format("WorkOrderID = {0}", vWorkOrderID)
      mdto.LoadTimeSheetEntryCollectionByWhere(rTimeSheetEntrys, mWhere)

      mOK = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadTimeSheetEntrysByWhere(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vWhere As String) As Boolean
    Dim mdto As dtoTimeSheetEntry
    Dim mWhere As String
    Dim mOK As Boolean = False

    Try

      pDBConn.Connect()

      mdto = New dtoTimeSheetEntry(pDBConn)
      mWhere = vWhere
      mdto.LoadTimeSheetEntryCollectionByWhere(rTimeSheetEntrys, mWhere)

      mOK = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function SaveTimeSheetEntrys(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vEmployeeID As Integer) As Boolean
    Dim mdto As dtoTimeSheetEntry
    Dim mOK As Boolean = False

    Try

      pDBConn.Connect()

      mdto = New dtoTimeSheetEntry(pDBConn)
      mdto.SaveTimeSheetEntryCollection(rTimeSheetEntrys, vEmployeeID)

      mOK = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetEmployeeRateOfPay(ByVal rEmployeeID As Int32, ByVal vCurrentDate As Date) As Decimal
    Dim mRateOfPays As colEmployeeRateOfPays
    Dim mSQL As String = ""
    Dim mRetVal As Decimal

    Try
      pDBConn.Connect()
      mSQL = "SELECT TOP 1 StandardRate from EmployeeRateOfPay where EmployeeID=" & rEmployeeID & " and StartDate < " & "'" & vCurrentDate & "'"
      mRateOfPays = New colEmployeeRateOfPays()
      mRetVal = pDBConn.ExecuteScalar(mSQL)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mRetVal
  End Function

End Class
