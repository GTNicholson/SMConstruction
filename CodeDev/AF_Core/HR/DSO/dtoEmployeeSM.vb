Imports RTIS.DataLayer.clsDBConnBase

Public Class dtoEmployeeSM : Inherits RTIS.ERPCore.dtoEmployee
  Public Sub New(ByVal vDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New(vDBConn)
  End Sub

  Public Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As IDataParameterCollection, vSetList As Boolean)
    Dim mEmpSD As dmEmployeeSM

    MyBase.ObjectToSQLInfo(rFieldList, rParamList, rParameterValues, vSetList)

    mEmpSD = CType(pEmployee, dmEmployeeSM)
    With mEmpSD
      ''DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PaymentType", .PaymentType)
      ''DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesAreaID", .SalesAreaID)

    End With

  End Sub

  Public Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Dim mEmpSD As dmEmployeeSM
    mOK = MyBase.ReaderToObject(rDataReader)

    mEmpSD = CType(pEmployee, dmEmployeeSM)
    With mEmpSD
      ''.PaymentType = DBReadByte(rDataReader, "PaymentType")
      ''.SalesAreaID = DBReadInteger(rDataReader, "SalesAreaID")
      pEmployee.IsDirty = False
    End With


    Return mOK
  End Function

  Protected Overrides Function SetObjectToNew() As Object
    pEmployee = New dmEmployeeSM ' Or .NewBlankEmployee
    Return pEmployee
  End Function


End Class
