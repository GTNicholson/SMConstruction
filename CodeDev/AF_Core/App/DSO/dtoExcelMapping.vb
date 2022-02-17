''DTO Definition - ExcelMapping (to ExcelMapping)'Generated from Table:ExcelMapping

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoExcelMapping : Inherits dtoBase
  Private pExcelMapping As dmExcelMapping

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ExcelMapping"
    pKeyFieldName = "ExcelMappingID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pExcelMapping.ExcelMappingID
    End Get
    Set(ByVal value As Integer)
      pExcelMapping.ExcelMappingID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pExcelMapping.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pExcelMapping.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ExcelMappingID", pExcelMapping.ExcelMappingID)
    End If
    With pExcelMapping
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ImportTypeID", .ImportTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ColumnID", .ColumnID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CellValue", StringToDBValue(.CellValue))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TranslationValue", .TranslationValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AdditionalText", StringToDBValue(.AdditionalText))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TranslationText", StringToDBValue(.TranslationText))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ColumnHeading", StringToDBValue(.ColumnHeading))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RefListID", .RefListID)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pExcelMapping Is Nothing Then SetObjectToNew()
      With pExcelMapping
        .ExcelMappingID = DBReadInt32(rDataReader, "ExcelMappingID")
        .ImportTypeID = DBReadInt32(rDataReader, "ImportTypeID")
        .ColumnID = DBReadInt32(rDataReader, "ColumnID")
        .CellValue = DBReadString(rDataReader, "CellValue")
        .TranslationValue = DBReadInt32(rDataReader, "TranslationValue")
        .AdditionalText = DBReadString(rDataReader, "AdditionalText")
        .TranslationText = DBReadString(rDataReader, "TranslationText")
        .ColumnHeading = DBReadString(rDataReader, "ColumnHeading")
        .RefListID = DBReadInt32(rDataReader, "RefListID")

        pExcelMapping.IsDirty = False
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
    pExcelMapping = New dmExcelMapping ' Or .NewBlankExcelMapping
    Return pExcelMapping

  End Function


  Public Function LoadExcelMapping(ByRef rExcelMapping As dmExcelMapping, ByVal vExcelMappingID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vExcelMappingID)
    If mOK Then
      rExcelMapping = pExcelMapping
    Else
      rExcelMapping = Nothing
    End If
    pExcelMapping = Nothing
    Return mOK
  End Function


  Public Function SaveExcelMapping(ByRef rExcelMapping As dmExcelMapping) As Boolean
    Dim mOK As Boolean
    pExcelMapping = rExcelMapping
    mOK = SaveObject()
    pExcelMapping = Nothing
    Return mOK
  End Function

  Public Function LoadExcelMappingCollection(ByRef rExcelMappings As colExcelMappings) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ImportTypeID", vImportTypeID)
    mOK = MyBase.LoadCollection(rExcelMappings, mParams, "ExcelMappingID")
    If mOK Then rExcelMappings.IsDirty = False
    Return mOK
  End Function
  Public Function LoadExcelMappingCollection(ByRef rExcelMappings As colExcelMappings, ByVal vImportTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ImportTypeID", vImportTypeID)
    mOK = MyBase.LoadCollection(rExcelMappings, mParams, "ExcelMappingID")
    If mOK Then rExcelMappings.IsDirty = False
    Return mOK
  End Function

  Public Function SaveExcelMappingCollection(ByRef rCollection As colExcelMappings) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ImportTypeID", vImportTypeID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pExcelMapping In rCollection
      ''    If pExcelMapping.ExcelMappingID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pExcelMapping.ExcelMappingID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pExcelMapping In rCollection.DeletedItems
          If pExcelMapping.ExcelMappingID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pExcelMapping.ExcelMappingID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pExcelMapping In rCollection
        If pExcelMapping.IsDirty Or pExcelMapping.ExcelMappingID = 0 Then 'Or pExcelMapping.ExcelMappingID = 0
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

  Public Function SaveExcelMappingCollection(ByRef rCollection As colExcelMappings, ByVal vImportTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ImportTypeID", vImportTypeID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pExcelMapping In rCollection
      ''    If pExcelMapping.ExcelMappingID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pExcelMapping.ExcelMappingID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pExcelMapping In rCollection.DeletedItems
          If pExcelMapping.ExcelMappingID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pExcelMapping.ExcelMappingID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pExcelMapping In rCollection
        If pExcelMapping.IsDirty Or pExcelMapping.ImportTypeID <> vImportTypeID Or pExcelMapping.ExcelMappingID = 0 Then 'Or pExcelMapping.ExcelMappingID = 0
          pExcelMapping.ImportTypeID = vImportTypeID
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