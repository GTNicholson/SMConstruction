Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB
Imports RTIS.CommonVB.clsGeneralA

''DTO Definition - LabelDefinition (to LabelDefinition)'Generated from Table:LabelDefinition

Public Class dtoLabelDefinition : Inherits dtoBase
  Private pLabelDefinition As clsLabelDefinition

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "LabelDefinition"
    pKeyFieldName = "LabelDefinitionID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Public Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pLabelDefinition.LabelDefinitionID
    End Get
    Set(ByVal value As Integer)
      pLabelDefinition.LabelDefinitionID = value
    End Set
  End Property

  Public Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pLabelDefinition.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pLabelDefinition.IsDirty = value
    End Set
  End Property

  Public Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Public Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "LabelDefinitionID", pLabelDefinition.LabelDefinitionID)
    End If
    With pLabelDefinition
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LabelDefName", StringToDBValue(.LabelDefName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ReportLabelType", .ReportLabelType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TopMargin", .TopMargin)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LeftMargin", .LeftMargin)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LabelHeight", .LabelHeight)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LabelWidth", .LabelWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrintHeight", .PrintHeight)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrintWidth", .PrintWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrintHeight", .PrintHeight)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrintWidth", .PrintWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NoOfColumns", .NoOfColumns)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NoOfRows", .NoOfRows)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PageWidth", .PageWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PageHeight", .PageHeight)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PrinterName", StringToDBValue(.PrinterName))


    End With

  End Sub


  Public Overloads Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pLabelDefinition Is Nothing Then pLabelDefinition = New clsLabelDefinition
      With pLabelDefinition
        .LabelDefinitionID = DBReadInt32(rDataReader, "LabelDefinitionID")
        .LabelDefName = DBReadString(rDataReader, "LabelDefName")
        .ReportLabelType = DBReadInt32(rDataReader, "ReportLabelType")
        .TopMargin = DBReadDecimal(rDataReader, "TopMargin")
        .LeftMargin = DBReadDecimal(rDataReader, "LeftMargin")
        .LabelHeight = DBReadDecimal(rDataReader, "LabelHeight")
        .LabelWidth = DBReadDecimal(rDataReader, "LabelWidth")
        .PrintHeight = DBReadDecimal(rDataReader, "PrintHeight")
        .PrintWidth = DBReadDecimal(rDataReader, "PrintWidth")
        .NoOfColumns = DBReadDecimal(rDataReader, "NoOfColumns")
        .NoOfRows = DBReadDecimal(rDataReader, "NoOfRows")
        .PageHeight = DBReadDecimal(rDataReader, "PageHeight")
        .PageWidth = DBReadDecimal(rDataReader, "PageWidth")
        .PrinterName = DBReadString(rDataReader, "PrinterName")
        pLabelDefinition.IsDirty = False
      End With
      mOK = True
    Catch Ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      ' or raise an error ?
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pLabelDefinition = New clsLabelDefinition
    Return pLabelDefinition

  End Function


  Public Function LoadLabelDefinition(ByRef rLabelDefinition As clsLabelDefinition, ByVal vLabelDefinitionID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vLabelDefinitionID)
    If mOK Then
      rLabelDefinition = pLabelDefinition
    Else
      rLabelDefinition = Nothing
    End If
    pLabelDefinition = Nothing
    Return mOK
  End Function

  Public Function SaveLabelDefinition(ByRef rLabelDefinition As clsLabelDefinition) As Boolean
    Dim mOK As Boolean
    pLabelDefinition = rLabelDefinition
    mOK = SaveObject()
    pLabelDefinition = Nothing
    Return mOK
  End Function

  Public Function LoadLabelDefinitions(ByRef rCollection As colLabelDefinitions) As Boolean
    Dim mParams As Hashtable
    Dim mOK As Boolean

    mParams = New Hashtable
    rCollection = New colLabelDefinitions
    mOK = MyBase.LoadCollection(rCollection, mParams)
    If mOK Then rCollection.IsDirty = False
    Return mOK
  End Function

  Public Function SaveLabelDefinitions(ByRef rCollection As colLabelDefinitions) As Boolean
    Dim mParams As Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""

    If rCollection.IsDirty Then

      mParams = New Hashtable

      ''Approach where delete items not found in the collection
      If rCollection.SomeRemoved Then

        For Each pLabelDefinition In rCollection
          If pLabelDefinition.LabelDefinitionID <> 0 Then
            mCount = mCount + 1
            If mCount > 1 Then mIDs = mIDs & ", "
            mIDs = mIDs & pLabelDefinition.LabelDefinitionID.ToString
          End If
        Next
        mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      Else
        mAllOK = True
      End If

      For Each pLabelDefinition In rCollection
        If pLabelDefinition.IsDirty Or pLabelDefinition.LabelDefinitionID = 0 Then 'Or pExample.ParentID = 0
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False

    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

End Class



