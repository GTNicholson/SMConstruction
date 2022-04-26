''Class Definition - Machinery (to Machinery)'Generated from Table:Machinery
Imports RTIS.CommonVB

Public Class dmMachinery : Inherits dmBase
   Implements iValueItem

   Private pMachineryID As Int32
   Private pCode As String
   Private pDescription As String

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
      MachineryID = 0
   End Sub

   Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
      With CType(rNewItem, dmMachinery)
         .MachineryID = MachineryID
         .Code = Code
         .Description = Description
         'Add entries here for each collection and class property

         'Entries for object management

         .IsDirty = IsDirty
      End With

   End Sub

   Public Property MachineryID() As Int32 Implements iValueItem.ItemValue
      Get
         Return pMachineryID
      End Get
      Set(ByVal value As Int32)
         If pMachineryID <> value Then IsDirty = True
         pMachineryID = value
      End Set
   End Property

   Public Property Code() As String
      Get
         Return pCode
      End Get
      Set(ByVal value As String)
         If pCode <> value Then IsDirty = True
         pCode = value
      End Set
   End Property

   Public Property Description() As String Implements iValueItem.DisplayValue
      Get
         Return pDescription
      End Get
      Set(ByVal value As String)
         If pDescription <> value Then IsDirty = True
         pDescription = value
      End Set
   End Property



   Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
      Get
      End Get
      Set(value As Boolean)
      End Set
   End Property
End Class



''Collection Definition - Machinery (to Machinery)'Generated from Table:Machinery

'Private pMachinerys As colMachinerys
'Public Property Machinerys() As colMachinerys
'  Get
'    Return pMachinerys
'  End Get
'  Set(ByVal value As colMachinerys)
'    pMachinerys = value
'  End Set
'End Property

'  pMachinerys = New colMachinerys 'Add to New
'  pMachinerys = Nothing 'Add to Finalize
'  .Machinerys = Machinerys.Clone 'Add to CloneTo
'  Machinerys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Machinerys.IsDirty 'Add to IsAnyDirty

Public Class colMachinerys : Inherits colBase(Of dmMachinery)

   Public Overrides Function IndexFromKey(ByVal vMachineryID As Integer) As Integer
      Dim mItem As dmMachinery
      Dim mIndex As Integer = -1
      Dim mCount As Integer = -1
      For Each mItem In MyBase.Items
         mCount += 1
         If mItem.MachineryID = vMachineryID Then
            mIndex = mCount
            Exit For
         End If
      Next
      Return mIndex
   End Function

   Public Sub New()
      MyBase.New()
   End Sub

   Public Sub New(ByVal vList As List(Of dmMachinery))
      MyBase.New(vList)
   End Sub

End Class


