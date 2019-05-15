Imports RTIS.CommonVB

Public Class fccWorkOrderDetail
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoWorkOrder

    pWorkOrder = New dmWorkOrder

    mdso = New dsoWorkOrder(pDBConn)
    mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)
  End Sub

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    mRetVal = True
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder.IsAnyDirty Then mRetVal = True
    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function




End Class
