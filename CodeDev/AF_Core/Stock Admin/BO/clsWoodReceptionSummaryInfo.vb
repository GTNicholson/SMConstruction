Public Class clsWoodReceptionSummaryInfo
  Private pReceptionID As Integer
  Private pSpeciesID As Integer
  Private pTotalQty As Integer
  Private pDiameterAverage As Decimal
  Private pLength As Decimal
  Private pTotalM3 As Decimal

  Public Property Reception As Integer
    Get
      Return pReceptionID
    End Get
    Set(value As Integer)
      pReceptionID = value
    End Set
  End Property

  Public Property SpeciesID As Integer
    Get
      Return pSpeciesID
    End Get
    Set(value As Integer)
      pSpeciesID = value
    End Set
  End Property

  Public Property TotalQty As Integer
    Get
      Return pTotalQty
    End Get
    Set(value As Integer)
      pTotalQty = value
    End Set
  End Property

  Public Property DiameterAverage As Decimal
    Get
      Return pDiameterAverage
    End Get
    Set(value As Decimal)
      pDiameterAverage = value
    End Set
  End Property

  Public Property Length As Decimal
    Get
      Return pLength
    End Get
    Set(value As Decimal)
      pLength = value
    End Set
  End Property

  Public Property TotalM3 As Decimal
    Get
      Return pTotalM3
    End Get
    Set(value As Decimal)
      pTotalM3 = value
    End Set
  End Property

  Public ReadOnly Property SpeciesDesc() As String
    Get
      Dim mRetVal As String = ""
      mRetVal = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).DisplayValueString(SpeciesID)
      mRetVal = mRetVal.Trim.ToUpper
      Return mRetVal
    End Get

  End Property

End Class

Public Class colWoodReceptionSummaryInfos : Inherits List(Of clsWoodReceptionSummaryInfo)

End Class

