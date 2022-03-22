Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class dsoExcelMapping
  Private pDBconn As clsDBConnBase

  Public ReadOnly Property DBConn As clsDBConnBase
    Get
      Return pDBconn
    End Get
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBconn = rDBConn
  End Sub

  Public Function LoadExcelMappings(ByRef rExcelMappings As colExcelMappings) As Boolean
    Dim mOk As Boolean

    Try
      If pDBconn.Connect Then
        Dim mdtoExcelMapping As New dtoExcelMapping(pDBconn)

        mOk = mdtoExcelMapping.LoadExcelMappingCollection(rExcelMappings)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBconn.IsConnected Then pDBconn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function LoadExcelMappings(ByRef rExcelMappings As colExcelMappings, ByVal vImportTypeID As Integer) As Boolean
    Dim mOk As Boolean

    Try
      If pDBconn.Connect Then
        Dim mdtoExcelMapping As New dtoExcelMapping(pDBconn)

        mOk = mdtoExcelMapping.LoadExcelMappingCollection(rExcelMappings, vImportTypeID)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBconn.IsConnected Then pDBconn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function SaveExcelMappings(ByRef rExcelMappings As colExcelMappings) As Boolean
    Dim mOk As Boolean

    Try
      If pDBconn.Connect Then
        Dim mdtoExcelMapping As New dtoExcelMapping(pDBconn)

        mOk = mdtoExcelMapping.SaveExcelMappingCollection(rExcelMappings)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBconn.IsConnected Then pDBconn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function SaveExcelMappings(ByRef rExcelMappings As colExcelMappings, ByVal vImportTypeID As Integer) As Boolean
    Dim mOk As Boolean

    Try
      If pDBconn.Connect Then
        Dim mdtoExcelMapping As New dtoExcelMapping(pDBconn)

        mOk = mdtoExcelMapping.SaveExcelMappingCollection(rExcelMappings, vImportTypeID)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBconn.IsConnected Then pDBconn.Disconnect()
    End Try

    Return mOk
  End Function
End Class
