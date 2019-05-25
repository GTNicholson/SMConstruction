Imports RTIS.CommonVB
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
      mWhere = String.Format("EmployeeID = {0} And StartTime >= '{1}' And StartTime < '{2}'", vEmployeeID, vWCDate.ToString("yyyy/MM/dd"), vWCDate.AddDays(7).ToString("yyyy/MM/dd"))
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


End Class
