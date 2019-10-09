Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.Elements
Imports RTIS.DataLayer

Public Class clsGetLookUpExtension : Inherits clsGetLookUpExtensionBase
  Public Overrides Sub CreateLookUpRowValdation(ByRef vLookupTable As clsLookUpTable)
    '' Inherit this in project for loading validation classes
    Dim mRetVal As clsLookUpRowValidation

    Select Case vLookupTable.ValidationCode
      Case 4 'User List
        mRetVal = New clsLookUpRowValidation_UserList
      Case 1 'LookUpTable
        mRetVal = New clsLookUpRowValidation_LookUpTable
      Case 2 'LookupField
        mRetVal = New clsLookUpRowValidation_LookUpField
      Case 3 'LookUpLink
        mRetVal = New clsLookUpRowValidation_LookUpLink
        ''Case 5
        ''  mRetVal = New clsLookUpRowValidation_Supplier()
      Case Else
        ''mRetVal = MyBase.CreateLookUpRowValdation(vLookupTable)
        mRetVal = Nothing
    End Select
    vLookupTable.LookUpRowValidation = mRetVal


  End Sub

  Public Overrides Function TriggerActivity(ByRef rDBConn As clsDBConnBase, ByRef vLookupTable As clsLookUpTable, ByVal vActivityCode As Long, ByVal vLinkID As Integer) As Boolean
    'Dim mAppActivityCode as eApplicationActivity
    'mAppActivityCode = ctype(vActivityCode,eApplicationActivity)
    If rDBConn.RTISUser.ActivityPermission(vActivityCode) > ePermissionCode.ePC_None Then
      Select Case vActivityCode
        Case eActivityCode.OverideUserPassword

          'MsgBox("AmendPassword")
          OverrideUserPassword(rDBConn, vLinkID)
      End Select
    Else
      MsgBox("No tienes suficientes permisos de usuario para esta función", MsgBoxStyle.Exclamation)
    End If
  End Function

  Private Function OverrideUserPassword(ByRef rDBConn As clsDBConnBase, ByVal vUserID As Integer) As Boolean

    Dim mAUser As New clsRTISUser
    Dim mDBConnectedByForm As Boolean = False
    Dim mOK As Boolean
    Dim mInstByFunc As Boolean = False
    ''If My.Application.MainDB.Connect(mDBConnectedByForm) Then
    If rDBConn.Connect(mDBConnectedByForm) Then
      If rDBConn.dsoUserLogin Is Nothing Then
        rDBConn.dsoUserLogin = New dsoRTISUserSQL(rDBConn)
        mInstByFunc = True
      End If
      If rDBConn.dsoUserLogin.LoadUserDetailsByID(vUserID, mAUser) Then
        ''mAUser.dsoUserLogin.DBSource = rDBConn
        mAUser.Contact = rDBConn.RTISUser.Contact
        mOK = frmChangePassword.DisplayChangePassword(rDBConn, mAUser, True)
        mAUser = Nothing
      End If
      If mInstByFunc Then
        rDBConn.dsoUserLogin = Nothing
      End If
      If mDBConnectedByForm Then
        rDBConn.Disconnect()
      End If
    End If
    Return mOK
  End Function

End Class


Public Class clsLookUpRowValidation_UserList : Inherits clsLookUpRowValidation

  Public Overrides Function ValidateRow(ByVal vCheckType As eLookupValidationType, ByRef vLookupTable As clsLookUpTable, ByVal vRowHandle As Integer, ByRef GridView As Object, ByRef rValidationMsg As String) As Boolean
    Dim mOK As Boolean = True
    Dim mGridView As GridView = CType(GridView, GridView)
    Dim mOrigDataRow As DataRow

    If mGridView.IsNewItemRow(vRowHandle) Then
      'No original row details available
    Else
      mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
    End If
    Select Case vCheckType
      ''Case eLookupValidationType.eLUV_Delete
      ''  mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
      ''  mInt = CType(mOrigDataRow.Item("LookUpTableID"), Integer)
      ''  If mInt = 0 Then
      ''    mOK = True
      ''  Else
      ''    mOK = False
      ''  End If
      Case eLookupValidationType.eLUV_Edit, eLookupValidationType.eLUV_Add
        If mGridView.GetRowCellValue(vRowHandle, "Nombre de Usuario").ToString.Length = 0 Then
          mOK = False
          rValidationMsg = rValidationMsg & "El Nombre de Usuario no debe estar vacío" & vbCrLf
        End If
        'If mGridView.GetRowCellValue(vRowHandle, "FullName").ToString.Length = 0 Then
        '  mOK = False
        '  rValidationMsg = rValidationMsg & "Full Name must not be blank" & vbCrLf
        'End If
      Case eLookupValidationType.eLUV_Delete
        mOK = False
        rValidationMsg = "Elimación no disponible"
    End Select

    Return mOK
  End Function
End Class

Public Class clsLookUpRowValidation_LookUpTable : Inherits clsLookUpRowValidation

  Public Overrides Function ValidateRow(ByVal vCheckType As eLookupValidationType, ByRef vLookupTable As clsLookUpTable, ByVal vRowHandle As Integer, ByRef GridView As Object, ByRef rValidationMsg As String) As Boolean
    Dim mOK As Boolean = True
    Dim mGridView As GridView = CType(GridView, GridView)
    Dim mOrigDataRow As DataRow ''= vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
    Dim mInt As Integer
    If mGridView.IsNewItemRow(vRowHandle) Then
      'No original row details available
    Else
      mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
    End If

    Select Case vCheckType
      Case eLookupValidationType.eLUV_Delete
        mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
        mInt = CType(mOrigDataRow.Item("LookUpTableID"), Integer)
        If mInt = 0 Then
          mOK = True
        Else
          mOK = False
        End If
      Case eLookupValidationType.eLUV_Edit, eLookupValidationType.eLUV_Add
        If mGridView.GetRowCellValue(vRowHandle, "TableName").ToString.Length = 0 Then
          mOK = False
          rValidationMsg = rValidationMsg & "TableName no debe de estar vacío" & vbCrLf
        End If
        If mGridView.GetRowCellValue(vRowHandle, "KeyIDFieldName").ToString.Length = 0 Then
          mOK = False
          rValidationMsg = rValidationMsg & "KeyIDFieldName no debe de estar vacío" & vbCrLf
        End If
    End Select

    Return mOK
  End Function
End Class

Public Class clsLookUpRowValidation_LookUpField : Inherits clsLookUpRowValidation

  Public Overrides Function ValidateRow(ByVal vCheckType As eLookupValidationType, ByRef vLookupTable As clsLookUpTable, ByVal vRowHandle As Integer, ByRef GridView As Object, ByRef rValidationMsg As String) As Boolean
    Dim mOK As Boolean = True
    Return mOK
  End Function
End Class

Public Class clsLookUpRowValidation_LookUpLink : Inherits clsLookUpRowValidation

  Public Overrides Function ValidateRow(ByVal vCheckType As eLookupValidationType, ByRef vLookupTable As clsLookUpTable, ByVal vRowHandle As Integer, ByRef GridView As Object, ByRef rValidationMsg As String) As Boolean
    'Dim mDataRow As DataRow

    'mDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
    Dim mOK As Boolean = True
    Return mOK
  End Function
End Class


''Public Class clsLookUpRowValidation_Supplier : Inherits clsLookUpRowValidation

''  Public Overrides Function ValidateRow(ByVal vCheckType As eLookupValidationType, ByRef vLookupTable As clsLookUpTable, ByVal vRowHandle As Integer, ByRef GridView As Object, ByRef rValidationMsg As String) As Boolean
''    Dim mOK As Boolean = True
''    Dim mGridView As GridView = CType(GridView, GridView)
''    Dim mOrigDataRow As DataRow '= vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)

''    'DataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
''    If mGridView.IsNewItemRow(vRowHandle) Then
''      'No original row details available
''    Else
''      mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
''    End If

''    Select Case vCheckType
''      ''Case eLookupValidationType.eLUV_Delete
''      ''  mOrigDataRow = vLookupTable.LUTDataset.Tables(0).Rows(vRowHandle)
''      ''  mInt = CType(mOrigDataRow.Item("LookUpTableID"), Integer)
''      ''  If mInt = 0 Then
''      ''    mOK = True
''      ''  Else
''      ''    mOK = False
''      ''  End If
''      Case eLookupValidationType.eLUV_Edit, eLookupValidationType.eLUV_Add
''        If mGridView.GetRowCellValue(vRowHandle, "SupplierName").ToString.Length = 0 Then
''          mOK = False
''          rValidationMsg = rValidationMsg & "Supplier Name must not be blank" & vbCrLf
''        End If
''        If mGridView.GetRowCellValue(vRowHandle, "SupplierNo").ToString.Length = 0 Then
''          mOK = False
''          rValidationMsg = rValidationMsg & "Supplier No must not be blank" & vbCrLf
''        End If
''        If mGridView.GetRowCellValue(vRowHandle, "Phone").ToString.Length = 0 Then
''          mOK = False
''          rValidationMsg = rValidationMsg & "Phone must not be blank" & vbCrLf
''        End If
''        If mGridView.GetRowCellValue(vRowHandle, "Fax").ToString.Length = 0 Then
''          mOK = False
''          rValidationMsg = rValidationMsg & "Fax must not be blank" & vbCrLf
''        End If
''        If mGridView.GetRowCellValue(vRowHandle, "ContactName").ToString.Length = 0 Then
''          mOK = False
''          rValidationMsg = rValidationMsg & "Contact Name must not be blank" & vbCrLf
''        End If
''      Case eLookupValidationType.eLUV_Delete
''        mOK = False
''        rValidationMsg = "Delete not available"
''    End Select

''    Return mOK
''  End Function
''End Class