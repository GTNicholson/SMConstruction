
''DTO Definition - vwPurchaseOrder (to vwPurchaseOrder)'Generated from Table:vwPurchaseOrder

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodPalletItemContent : Inherits dtoBase
  Private pWoodPalletItemContent As clsWoodPalletItemContent



  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub
  Protected Overrides Sub SetTableDetails()
    pTableName = "vwSUMWoodPalletItemContent"
    pKeyFieldName = "WoodPalletID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodPalletItemContent.WoodPalletID
    End Get
    Set(ByVal value As Integer)
      pWoodPalletItemContent.WoodPalletID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      Return False
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
      If pWoodPalletItemContent Is Nothing Then SetObjectToNew()
      With pWoodPalletItemContent


        '.WoodPalletItemID = DBReadInt32(rDataReader, "WoodPalletItemID")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        '.Description = DBReadString(rDataReader, "Description")
        '.StockCode = DBReadString(rDataReader, "StockCode")
        .PalletRef = DBReadString(rDataReader, "PalletRef")
        .LocationID = DBReadInt32(rDataReader, "LocationID")
        .SUMQuantity = DBReadDecimal(rDataReader, "SUMQuantity")
        .SUMQuantityUsed = DBReadDecimal(rDataReader, "SUMQuantityUsed")
        '.Width = DBReadDecimal(rDataReader, "Width")
        '.Thickness = DBReadDecimal(rDataReader, "Thickness")
        '.Length = DBReadDecimal(rDataReader, "Length")
        .PalletType = DBReadInt32(rDataReader, "PalletType")



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
    pWoodPalletItemContent = New clsWoodPalletItemContent
    Return pWoodPalletItemContent

  End Function




  Public Function LoadWoodPalletContentInfoCollectionByWhere(ByRef rWoodPalletItemInfos As colWoodPalletItemContents, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWoodPalletItemInfos, mParams, "WoodPalletID", vWhere)
    Return mOK
  End Function


End Class


