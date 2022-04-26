''DTO Definition - Machinery (to Machinery)'Generated from Table:Machinery

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMachinery : Inherits dtoBase
   Private pMachinery As dmMachinery

   Public Sub New(ByRef rDBSource As clsDBConnBase)
      MyBase.New(rDBSource)
   End Sub

   Protected Overrides Sub SetTableDetails()
      pTableName = "Machinery"
      pKeyFieldName = "MachineryID"
      pUseSoftDelete = False
      pRowVersionColName = "rowversion"
      pConcurrencyType = eConcurrencyType.OverwriteChanges
   End Sub

   Overrides Property ObjectKeyFieldValue() As Integer
      Get
         ObjectKeyFieldValue = pMachinery.MachineryID
      End Get
      Set(ByVal value As Integer)
         pMachinery.MachineryID = value
      End Set
   End Property

   Overrides Property IsDirtyValue() As Boolean
      Get
         IsDirtyValue = pMachinery.IsDirty
      End Get
      Set(ByVal value As Boolean)
         pMachinery.IsDirty = value
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
         DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "MachineryID", pMachinery.MachineryID)
      End If
      With pMachinery
         DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Code", StringToDBValue(.Code))
         DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      End With

   End Sub


   Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
      Dim mOK As Boolean
      Try
         If pMachinery Is Nothing Then SetObjectToNew()
         With pMachinery
            .MachineryID = DBReadInt32(rDataReader, "MachineryID")
            .Code = DBReadString(rDataReader, "Code")
            .Description = DBReadString(rDataReader, "Description")
            pMachinery.IsDirty = False
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
      pMachinery = New dmMachinery ' Or .NewBlankMachinery
      Return pMachinery

   End Function


   Public Function LoadMachinery(ByRef rMachinery As dmMachinery, ByVal vMachineryID As Integer) As Boolean
      Dim mOK As Boolean
      mOK = LoadObject(vMachineryID)
      If mOK Then
         rMachinery = pMachinery
      Else
         rMachinery = Nothing
      End If
      pMachinery = Nothing
      Return mOK
   End Function


   Public Function SaveMachinery(ByRef rMachinery As dmMachinery) As Boolean
      Dim mOK As Boolean
      pMachinery = rMachinery
      mOK = SaveObject()
      pMachinery = Nothing
      Return mOK
   End Function


   Public Function LoadMachineryCollection(ByRef rMachinerys As colMachinerys) As Boolean
      Dim mParams As New Hashtable
      Dim mOK As Boolean
      mOK = MyBase.LoadCollection(rMachinerys, mParams, "MachineryID")
      rMachinerys.TrackDeleted = True
      If mOK Then rMachinerys.IsDirty = False
      Return mOK
   End Function


   Public Function SaveMachineryCollection(ByRef rCollection As colMachinerys) As Boolean
      Dim mParams As New Hashtable
      Dim mAllOK As Boolean
      Dim mCount As Integer
      Dim mIDs As String = ""
      If rCollection.IsDirty Then
         ''Approach where delete items not found in the collection
         ''If rCollection.SomeRemoved Then
         ''  For Each Me.pMachinery In rCollection
         ''    If pMachinery.MachineryID <> 0 Then
         ''      mCount = mCount + 1
         ''      If mCount > 1 Then mIDs = mIDs & ", "
         ''       mIDs = mIDs & pMachinery.MachineryID.ToString
         ''    End If
         ''  Next
         ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
         ''Else
         ''   mAllOK = True
         ''End If

         ''Alternative Approach - where maintain collection of deleted items
         If rCollection.SomeDeleted Then
            mAllOK = True
            For Each Me.pMachinery In rCollection.DeletedItems
               If pMachinery.MachineryID <> 0 Then
                  If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pMachinery.MachineryID)
               End If
            Next
         Else
            mAllOK = True
         End If

         For Each Me.pMachinery In rCollection
            If pMachinery.IsDirty Or pMachinery.MachineryID = 0 Then 'Or pMachinery.MachineryID = 0

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


