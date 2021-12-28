Imports RTIS.CommonVB
Imports RTIS.DataLayer
Public Class dsoReception
  Private pDBConn As clsDBConnBase

  Public Sub New(ByVal vDBConn As clsDBConnBase)
    pDBConn = vDBConn
  End Sub

  Public Function LoadReceptionDown(ByRef rReception As dmReception, ByVal vReceptionID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoReception As dtoReception
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWhere As String = ""

    Try

      pDBConn.Connect()
      mdtoReception = New dtoReception(pDBConn)
      mRetVal = mdtoReception.LoadReception(rReception, vReceptionID)

      If rReception IsNot Nothing Then
        mWhere = "ReceptionID = " & vReceptionID
        mRetVal = mdsoStock.LoadWoodPalletsDownByWhere(rReception.WoodPallets, mWhere)

        For Each mWP As dmWoodPallet In rReception.WoodPallets
          mRetVal = mdsoStock.LoadWoodPalletGuideItems(mWP.WoodPalletGuideItems, mWP.WoodPalletID)

        Next

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal

  End Function

  Public Function LoadReceptionCollections(ByRef rReceptions As colReceptions) As Boolean
    Dim mdtoReception As New dtoReception(pDBConn)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoReception.LoadReceptionCollection(rReceptions)

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadReceptionCollectionDownByWhere(ByRef rReceptions As colReceptions, ByVal vWhere As String) As Boolean
    Dim mdtoReception As New dtoReception(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mWoodPalletWhere As String = ""
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoReception.LoadReceptionCollectionByWhere(rReceptions, vWhere)

      If rReceptions IsNot Nothing Then

        For Each mReception As dmReception In rReceptions
          mWoodPalletWhere = "ReceptionID =" & mReception.ReceptionID
          mdsoStock.LoadWoodPalletsDownByWhere(mReception.WoodPallets, mWoodPalletWhere)

        Next

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function




  Public Function SaveReceptionDown(ByRef rReception As dmReception) As Boolean
    Dim mdtoReception As New dtoReception(pDBConn)
    Dim mdtoWoodPallet As New dtoWoodPallet(pDBConn)
    Dim mdtoWoodPalletItem As New dtoWoodPalletItem(pDBConn)
    Dim mdtoWoodPalletGuideItem As New dtoWoodPalletGuideItem(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        Try
          pDBConn.ConnectionBeginTrans()

          mOK = mdtoReception.SaveReception(rReception)

          If mOK Then mOK = mdtoWoodPallet.SaveWoodPalletCollectionByReceptionID(rReception.WoodPallets, rReception.ReceptionID)

          If mOK Then

            For Each mWP As dmWoodPallet In rReception.WoodPallets

              mdtoWoodPalletItem.SaveWoodPalletItemCollection(mWP.WoodPalletItems, mWP.WoodPalletID)
            Next
          End If

        Catch ex As Exception
          mOK = False
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
        Finally

          If mOK Then
            pDBConn.ConnectionCommitTrans()
          Else
            pDBConn.ConnectionRollBackTrans()
          End If
        End Try
      Else
        mOK = False
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdtoReception = Nothing
      mdtoWoodPallet = Nothing
    End Try

    Return mOK
  End Function



End Class
