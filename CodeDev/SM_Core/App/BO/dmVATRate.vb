''Class Definition - VATRate (to VATRate)'Generated from Table:VATRate
Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class dmVATRate : Inherits dmBase
  Implements iValueItem

  Private pVATRateRecordID As Int32
  Private pVATRateCode As Int32
  Private pVATRate As Decimal
  Private pProtected As Boolean
  Private prowversion As ULong
  Private pDateStart As DateTime
  Private pDateEnd As DateTime

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    VATRateRecordID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmVATRate)
      .VATRateRecordID = VATRateRecordID
      .VATRateCode = VATRateCode
      .VATRate = VATRate
      .ProtectedVAT = ProtectedVAT
      .rowversion = rowversion
      .DateStart = DateStart
      .DateEnd = DateEnd
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property VATRateRecordID() As Int32
    Get
      Return pVATRateRecordID
    End Get
    Set(ByVal value As Int32)
      If pVATRateRecordID <> value Then IsDirty = True
      pVATRateRecordID = value
    End Set
  End Property

  Public Property VATRateCode() As Int32 Implements iValueItem.ItemValue
    Get
      Return pVATRateCode
    End Get
    Set(ByVal value As Int32)
      If pVATRateCode <> value Then IsDirty = True
      pVATRateCode = value
    End Set
  End Property

  Public Property VATRate() As Decimal
    Get
      Return pVATRate
    End Get
    Set(ByVal value As Decimal)
      If pVATRate <> value Then IsDirty = True
      pVATRate = value
    End Set
  End Property

  Public Property ProtectedVAT() As Boolean
    Get
      Return pProtected
    End Get
    Set(ByVal value As Boolean)
      If pProtected <> value Then IsDirty = True
      pProtected = value
    End Set
  End Property

  Public Property rowversion() As ULong
    Get
      Return prowversion
    End Get
    Set(ByVal value As ULong)
      If prowversion <> value Then IsDirty = True
      prowversion = value
    End Set
  End Property

  Public Property DateStart() As DateTime
    Get
      Return pDateStart
    End Get
    Set(ByVal value As DateTime)
      If pDateStart <> value Then IsDirty = True
      pDateStart = value
    End Set
  End Property

  Public Property DateEnd() As DateTime
    Get
      Return pDateEnd
    End Get
    Set(ByVal value As DateTime)
      If pDateEnd <> value Then IsDirty = True
      pDateEnd = value
    End Set
  End Property

  Public Property ItemValue As Integer
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property Description As String Implements iValueItem.DisplayValue
    Get

      If pVATRateCode = eTaxRate.IVA Then
        Return "I.V.A. " & pVATRate.ToString("N2") & "%"

      Else
        Return "Ninguno"
      End If




    End Get
    Set(value As String)

    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - VATRate (to VATRate)'Generated from Table:VATRate

'Private pVATRates As colVATRates
'Public Property VATRates() As colVATRates
'  Get
'    Return pVATRates
'  End Get
'  Set(ByVal value As colVATRates)
'    pVATRates = value
'  End Set
'End Property

'  pVATRates = New colVATRates 'Add to New
'  pVATRates = Nothing 'Add to Finalize
'  .VATRates = VATRates.Clone 'Add to CloneTo
'  VATRates.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = VATRates.IsDirty 'Add to IsAnyDirty

Public Class colVATRates : Inherits colBase(Of dmVATRate)

  Public Overrides Function IndexFromKey(ByVal vVATRateRecordID As Integer) As Integer
    Dim mItem As dmVATRate
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.VATRateRecordID = vVATRateRecordID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmVATRate))
    MyBase.New(vList)
  End Sub

  Public Function GetVATRateAtDate(ByVal vVATRateCode As Byte, ByVal vPOCORaisedDate As Date) As Decimal

    Dim mItem As dmVATRate

    Dim mVatRate As Decimal = 0
    For Each mItem In MyBase.Items

      If mItem.VATRateCode = vVATRateCode Then
        If mItem.DateStart >= vPOCORaisedDate Or mItem.DateEnd >= vPOCORaisedDate Then
          mVatRate = mItem.VATRate
          Exit For
        End If


      End If
    Next
    Return mVatRate


  End Function
End Class





