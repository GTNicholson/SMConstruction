Imports RTIS.WorkflowCore

Public Class clsContextConverterFactory : Inherits clsContextConverterFactoryBase
  Public Overrides Function CreateContextConverter(ByRef rEventObject As Object) As clsContextConverterBase 'intWorkflowEventObject) As clsContextConverterBase

    If TypeOf (rEventObject) Is dmSalesOrder Then
      'CreateContextConverter = New clsContextConverterQuote(rEventObject)
      'ElseIf TypeOf (rEventObject) Is clsAnother Then

    Else
      CreateContextConverter = New clsContextConverterBase(rEventObject)
    End If
  End Function

End Class
