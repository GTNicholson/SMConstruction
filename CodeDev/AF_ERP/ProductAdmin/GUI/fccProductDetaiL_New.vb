Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccProductDetaiL_New
  Private pPrimaryKeyID As Integer

  Private pProductStructure As dmProductStructure
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pProductBaseInfo As clsProductBaseInfo

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pProductBaseInfo = New clsProductBaseInfo()
    pProductBaseInfo.Product = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
  End Sub

  Public Property ProductBaseInfo As clsProductBaseInfo
    Get
      Return pProductBaseInfo
    End Get
    Set(value As clsProductBaseInfo)
      pProductBaseInfo = value
    End Set

  End Property

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

  Public Property ProductStructure As dmProductStructure
    Get
      Return pProductStructure
    End Get
    Set(value As dmProductStructure)
      pProductStructure = value
    End Set
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoProductAdmin

    pProductStructure = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoProductAdmin(pDBConn)



      mdso.LoadProductStructureDown(pProductStructure, pPrimaryKeyID)

    Else
      pProductBaseInfo.Product = pProductStructure
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoProductAdmin

    mdso = New dsoProductAdmin(pDBConn)

    mdso.SaveProductStructureDown(pProductStructure)


    If pPrimaryKeyID = 0 Then
      pPrimaryKeyID = pProductStructure.ID
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
    mIsDirty = pProductStructure.IsAnyDirty
    Return mIsDirty
  End Function

End Class
