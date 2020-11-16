Imports RTIS.CommonVB

Public Class clsProductBOMInfo
  Private pProductBOM As dmProductBOM
  Private pProductStructure As dmProductStructure



  Public Sub New()
    pProductBOM = New dmProductBOM
    pProductStructure = New dmProductStructure

  End Sub

  Public Property ProductBOM As dmProductBOM
    Get
      Return pProductBOM
    End Get
    Set(value As dmProductBOM)
      pProductBOM = value
    End Set
  End Property


  Public Property ProductStructure As dmProductStructure
    Get
      Return pProductStructure
    End Get
    Set(value As dmProductStructure)
      pProductStructure = value
    End Set
  End Property

  Public Property ProductBOMID As Int32
    Get
      Return pProductBOM.ProductBOMID
    End Get
    Set(value As Int32)
      pProductBOM.ProductBOMID = value
    End Set
  End Property

  Public Property ParentID As Int32
    Get
      Return pProductBOM.ParentID
    End Get
    Set(value As Int32)
      pProductBOM.ParentID = value
    End Set
  End Property

  Public Property ProductID As Int32
    Get
      Return pProductBOM.ProductID
    End Get
    Set(value As Int32)
      pProductBOM.ProductID = value
    End Set
  End Property
  Public Property Quantity As Int32
    Get
      Return pProductBOM.Quantity
    End Get
    Set(value As Int32)
      pProductBOM.Quantity = value
    End Set
  End Property


  Public Property Description As String
    Get
      Return pProductStructure.Description
    End Get
    Set(value As String)

      pProductStructure.Description = value
    End Set
  End Property


End Class

Public Class colProductBOMInfos : Inherits List(Of clsProductBOMInfo)

  Public Function ItemFromKey(ByVal vProductBOMID As Integer) As clsProductBOMInfo
    Dim mRetVal As clsProductBOMInfo = Nothing
    Dim mIndex As Integer

    mIndex = IndexFromProductBOMID(vProductBOMID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromProductBOMID(ByVal vProductBOMID As Integer) As Integer
    Dim mItem As clsProductBOMInfo
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.ProductBOM IsNot Nothing Then
        If mItem.ProductBOM.ProductBOMID = vProductBOMID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

End Class