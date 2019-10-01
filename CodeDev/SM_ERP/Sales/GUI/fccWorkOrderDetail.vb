Imports RTIS.CommonVB

Public Class fccWorkOrderDetail
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pTimeSheetEntrys As colTimeSheetEntrys

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pTimeSheetEntrys = New colTimeSheetEntrys
  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property

  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales
    Dim mdsoHR As dsoHR

    pWorkOrder = New dmWorkOrder
    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSales(pDBConn)
      mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)

      pSalesOrder = New dmSalesOrder
      mdso.LoadSalesOrderDown(pSalesOrder, pWorkOrder.SalesOrderID)

      mdsoHR = New dsoHR(pDBConn)
      pTimeSheetEntrys = New colTimeSheetEntrys
      mdsoHR.LoadTimeSheetEntrysWorkOrder(pTimeSheetEntrys, pWorkOrder.WorkOrderID)

    End If
  End Sub

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoSales

    mdso = New dsoSales(pDBConn)
    mdso.SaveWorkOrderDown(pWorkOrder)

    mRetVal = True
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder.IsAnyDirty Then mRetVal = True
    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Sub RaiseWorkOrderNo()
    Dim mdso As dsoGeneral
    Dim mWONo As Integer

    mdso = New dsoGeneral(pDBConn)
    mWONo = mdso.GetNextTallyWorkOrderNo()

    pWorkOrder.WorkOrderNo = clsConstants.WorkOrderNoPrefix & mWONo.ToString("00000")

  End Sub

  Public Sub SetProductType(ByVal vNewProductType As Integer)
    Try
      If vNewProductType <> pWorkOrder.ProductTypeID Then
        pWorkOrder.ProductTypeID = vNewProductType
        pWorkOrder.Product = clsProductSharedFuncs.NewProductInstance(vNewProductType)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub CreateWorkOrderPack(ByRef rReport As repWorkOrderDoc, ByVal vFilePath As String)
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal
    Dim mFilePath As String

    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)

    mPDFAmalg.PDFFileName = vFilePath
    mPDFAmalg.CreateNewDocument()

    If IO.File.Exists(vFilePath) Then
      mPDFAmalg.ImportPDFDocument(vFilePath)
    End If

    For Each mFileTracker In pWorkOrder.WOFiles
      If mFileTracker.IncludeInPack Then
        mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderUsr, pSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pWorkOrder.WorkOrderID.ToString("00000")), mFileTracker.FileName)

        If IO.File.Exists(mFilePath) Then
          mPDFAmalg.ImportPDFDocument(mFilePath)
        End If
      End If
    Next

    mPDFAmalg.SavePDFDocument()

  End Sub

  Public Function GetMaterialRequirementInfos() As colMaterialRequirementInfos
    Dim mMatReqInfos As New colMaterialRequirementInfos
    Dim mMRI As clsMaterialRequirementInfo
    Dim mPF As dmProductFurniture

    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    If mPF IsNot Nothing Then
      For Each mMR As dmMaterialRequirement In mPF.MaterialRequirments
        mMRI = New clsMaterialRequirementInfo(mMR)
        mMatReqInfos.Add(mMRI)
      Next
    End If

    Return mMatReqInfos
  End Function




  Public Function CreateWOImageFile(ByVal vSourceFile As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try
      If IO.File.Exists(vSourceFile) Then
        mFileName = "WorkOrderImg" & "_" & WorkOrder.WorkOrderID

        mExportDirectory = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(WorkOrder.WorkOrderID.ToString("00000")))

        mFileName &= IO.Path.GetExtension(vSourceFile)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)
        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vSourceFile, mFilePath, True)

        If IO.File.Exists(mFilePath) = True Then
          pWorkOrder.ImageFile = IO.Path.GetFileName(mFilePath)
          mRetVal = True
        Else
          pWorkOrder.ImageFile = ""
          mRetVal = False
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal
  End Function

End Class
