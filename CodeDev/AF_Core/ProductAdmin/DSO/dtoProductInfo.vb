

''DTO Definition - ProductInstallation (to ProductInstallation)'Generated from Table:ProductInstallation

Imports RTIS.DataLayer
  Imports RTIS.DataLayer.clsDBConnBase
  Imports RTIS.CommonVB.clsGeneralA
  Imports RTIS.CommonVB

Public Class dtoProductInfo : Inherits dtoBase

  Public Enum eMode
    Installation = 1
    AFStructure = 2
  End Enum

  Private pProductInfo As clsProductBaseInfo
  Private pMode As eMode

  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vMode As eMode)
    MyBase.New(rDBSource)
    pMode = vMode
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()

    Select Case pMode
      Case eMode.Installation
        pTableName = "ProductInstallation"
        pKeyFieldName = "ProductInstallationID"
      Case eMode.AFStructure
        pTableName = "ProductStructure"
        pKeyFieldName = "ProductStructureID"
    End Select

    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
    End Get
    Set(ByVal value As Integer)
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)


  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductInfo Is Nothing Then SetObjectToNew()
      With pProductInfo

        Select Case pMode
          Case eMode.AFStructure
            .Product.ID = DBReadInt32(rDataReader, "ProductStructureID")

          Case eMode.Installation
            .Product.ID = DBReadInt32(rDataReader, "ProductInstallationID")

        End Select
        .Product.Description = DBReadString(rDataReader, "Description")
        .Product.Code = DBReadString(rDataReader, "Code")
        .Product.ItemType = DBReadInt32(rDataReader, "ItemType")
        .Product.SubItemType = DBReadInt32(rDataReader, "SubItemType")
        ''pProductInfo.is = False
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
    Select Case pMode
      Case eMode.Installation
        pProductInfo = New clsProductBaseInfo
        pProductInfo.Product = New dmProductInstallation

      Case eMode.AFStructure
        pProductInfo = New clsProductBaseInfo
        pProductInfo.Product = New dmProductStructure
    End Select

    Return pProductInfo

  End Function


  Public Function LoadProductInstallation(ByRef rProductInstallation As dmProductInstallation, ByVal vProductInstallationID As Integer) As Boolean

  End Function


  Public Function SaveProductInstallation(ByRef rProductInstallation As dmProductInstallation) As Boolean

  End Function


  Public Function LoadProductInfosCollection(ByRef rProductInfos As colProductBaseInfos) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)

    Select Case pMode
      Case eMode.Installation
        mOK = MyBase.LoadCollection(rProductInfos, mParams, "ProductInstallationID")

      Case eMode.AFStructure
        mOK = MyBase.LoadCollection(rProductInfos, mParams, "ProductStructureID")
    End Select


    Return mOK
  End Function

End Class
