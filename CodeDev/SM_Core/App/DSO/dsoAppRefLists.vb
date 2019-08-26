Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB


Public Class dsoAppRefLists
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New()
    pDBConn = rDBConn
  End Sub

  Public Property DBConn() As clsDBConnBase
    Get
      DBConn = pDBConn

    End Get
    Set(ByVal value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Function LoadAllLists(ByRef rRefLists As appRefLists) As Boolean
    Dim mAllOK As Boolean = True
    Dim mItem As clsRefListItem
    Dim mIsNewConnection As Boolean
    Try
      If pDBConn.Connect(mIsNewConnection) Then
        For Each mItem In rRefLists
          mAllOK = LoadAList(rRefLists, mItem.RefListType)
        Next
      Else
        mAllOK = False
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mIsNewConnection Then
        pDBConn.Disconnect()
      End If
    End Try
    Return rRefLists.AllListsLoaded

  End Function

  Public Function LoadAList(ByRef rRefLists As appRefLists, ByVal vRefListType As Integer) As Boolean
    Dim mItem As clsRefListItem
    Dim mOK As Boolean = False
    Dim mValueItems As colValueItems
    ''Dim mRefListItem As clsRefListItem
    mItem = rRefLists.ItemFromKey(vRefListType)
    If Not mItem Is Nothing Then
      Select Case vRefListType
        Case appRefLists.None
          mItem.IList = Nothing
        Case appRefLists.RefList
          mItem.IList = rRefLists
          ''or
          ''mValueItems = New colValueItems
          ''For Each mRefListItem In rRefLists
          ''  mValueItems.AddNewItem(mRefListItem.RefListType, mRefListItem.Description)
          ''Next
          ''mItem.IList = mValueItems
          ''mValueItems = Nothing
        Case appRefLists.YesNo
          mValueItems = New colValueItems
          mValueItems.AddNewItem(0, "No")
          mValueItems.AddNewItem(1, "Yes")
          mItem.IList = mValueItems
          mValueItems = Nothing
          mOK = True

        Case appRefLists.VATRateCodes
          ''mItem.IList = LoadVATList()
          mOK = True

        Case appRefLists.Employees
          mItem.IList = LoadEmployees()
          mOK = True

        Case appRefLists.Roles
          mValueItems = New colValueItems
          'mOK = pDBConn.LoadValueItems(mValueItems, "SELECT RoleID,Role FROM Role ORDER BY Role", "RoleID", "Role")
          mOK = True
        Case appRefLists.Country
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 1", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.OrderType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 2", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.Tenders
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 4", "Value", "Description")
          mItem.IList = mValueItems

      End Select
      mItem = Nothing
    Else
      mOK = False
    End If
  End Function

  Public Function LoadEmployees() As IList
    Dim mdtoEmployees As New dtoEmployeeSM(pDBConn)
    Dim mEmployees As New RTIS.ERPCore.colEmployees
    ''Dim mdtoEmployeeSERoles As New dtoEmployeeSERole(pDBConn)

    mdtoEmployees.LoadEmployeeCollection(mEmployees)

    ''For Each mEmployee As RTIS.ERPCore.dmEmployee In mEmployees
    ''  mdtoEmployeeSERoles.LoadEmployeeSERoles(mEmployee.Roles, mEmployee.EmployeeID)
    ''Next

    Return mEmployees
  End Function

  Private Function LoadVATList() As IList
    Dim mcolVATCodes As New RTIS.ERPCore.colVATRateCodes
    Dim mdsoVATRate As New RTIS.ERPCore.dtoVATRate(pDBConn)
    Dim mdtoVATRateCode As New RTIS.ERPCore.dtoVATRateCode(pDBConn)
    Dim mVATRateCode As RTIS.ERPCore.clsVATRateCode
    Try
      mdtoVATRateCode.LoadVATRateCodeCollection(mcolVATCodes)
      For Each mVATRateCode In mcolVATCodes
        mVATRateCode.VATRates = New RTIS.ERPCore.colVATRates
        mdsoVATRate.LoadVATCodeCollection(mVATRateCode.VATRates, mVATRateCode.VATRateCode)
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      mdsoVATRate = Nothing
      mdtoVATRateCode = Nothing
    End Try
    Return mcolVATCodes
  End Function


End Class


