Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase

Public Class dsoLabelDefinition
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    Me.DBConn = rDBConn
  End Sub

  Public Property DBConn() As clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Function LoadLabelDefinition(ByRef rLabelDefinition As clsLabelDefinition) As Boolean
    Dim mdto As dtoLabelDefinition
    Try
      pDBConn.Connect()
      mdto = New dtoLabelDefinition(pDBConn)
      mdto.LoadLabelDefinition(rLabelDefinition, rLabelDefinition.LabelDefinitionID)
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      Return True
    Catch ex As Exception
      Return False
    End Try

  End Function

  Public Function SaveLabelDefinition(ByRef rLabelDefinition As clsLabelDefinition) As Boolean
    Dim mdto As dtoLabelDefinition
    Try
      pDBConn.Connect()
      mdto = New dtoLabelDefinition(pDBConn)
      mdto.SaveLabelDefinition(rLabelDefinition)
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Function LoadLabelDefinitions(ByRef rcolLabelDefinitions As colLabelDefinitions) As Boolean
    Dim mdto As dtoLabelDefinition
    Try
      pDBConn.Connect()
      mdto = New dtoLabelDefinition(pDBConn)
      mdto.LoadLabelDefinitions(rcolLabelDefinitions)
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      Return True
    Catch ex As Exception
      Return False
    End Try

  End Function

  Public Function SaveLabelDefinitions(ByRef rcolLabelDefinitions As colLabelDefinitions) As Boolean
    Dim mdto As dtoLabelDefinition
    Try
      pDBConn.Connect()
      mdto = New dtoLabelDefinition(pDBConn)
      mdto.SaveLabelDefinitions(rcolLabelDefinitions)
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function
End Class
