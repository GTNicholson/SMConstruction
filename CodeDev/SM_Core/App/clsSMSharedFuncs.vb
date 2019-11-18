Imports RTIS.CommonVB

Public Class clsSMSharedFuncs

  Public Shared Function GrosWoodThickness(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal
    Dim mInches As Decimal
    ''   mInches = CMToQuaterInches(vCM)
    mInches = vCM / 2.54
    If mInches <= 1 Then
      mRetVal = 1
    ElseIf mInches <= 1.5 Then
      mRetVal = 1.5
    ElseIf mInches <= 2 Then
      mRetVal = 2
    Else
      mRetVal = CMToQuaterInches(vCM)
    End If
    Return mRetVal
  End Function

  Public Shared Function WoodLengthFeet(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal

    mRetVal = (vCM / 2.54) + 2
    mRetVal = mRetVal / 12
    mRetVal = Math.Truncate(mRetVal)
    mRetVal += 1
    Return mRetVal
  End Function

  Public Shared Function CMToQuaterInches(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal
    Dim mTempVal As Decimal

    mTempVal = (vCM / 2.54) + 0.25
    mRetVal = Math.Truncate(mTempVal * 4) / 4
    If mRetVal <> (mTempVal * 4) / 4 Then
      mRetVal += 0.25
    End If
    Return mRetVal
  End Function

  Public Shared Function CMToQuaterInchesSMM(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal

    mRetVal = vCM / 2.54
    mRetVal = Math.Truncate(mRetVal * 4) / 4
    mRetVal += 0.5
    Return mRetVal
  End Function

  Public Shared Function CMToHalfInchesLength(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal
    Dim mTempVal As Decimal

    mTempVal = vCM + 5

    mTempVal = mTempVal / 2.54
    mRetVal = Math.Truncate(mTempVal * 2) / 2

    If mRetVal <> (mTempVal * 2) / 2 Then
      mRetVal += 0.5
    End If
    Return mRetVal
  End Function

  Public Shared Function DecToFraction(ByVal vDecimal As Decimal) As String
    Dim mRetVal As String
    Dim mRemainder As Decimal

    mRetVal = Math.Truncate(vDecimal)
    mRemainder = vDecimal - mRetVal
    Select Case mRemainder
      Case 0.25
        mRetVal = mRetVal & " 1/4"
      Case 0.5
        mRetVal = mRetVal & " 1/2"
      Case 0.75
        mRetVal = mRetVal & " 3/4"
    End Select

    Return mRetVal
  End Function


  Public Shared Function WOTotalPieces(ByVal vUnitPiece As Int32, ByVal vQuantity As Int32) As Int32
    Dim mRetVal As Int32

    mRetVal = vUnitPiece * vQuantity

    Return mRetVal
  End Function

  Public Shared Function GetWOImageFileName(ByRef rSalesOrder As dmSalesOrder, ByRef rWorkOrder As dmWorkOrder) As String
    Dim mRetVal As String = ""
    Dim mExportDirectory As String = String.Empty



    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, rSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(rWorkOrder.WorkOrderID.ToString("00000")))

    If rWorkOrder.ImageFile <> "" Then
      mRetVal = IO.Path.Combine(mExportDirectory, rWorkOrder.ImageFile)
    End If



    Return mRetVal
  End Function

  Public Shared Function GetSOItemImageFileName(ByRef rSalesOrder As dmSalesOrder, ByRef rSalesOrderItem As dmSalesOrderItem) As String
    Dim mRetVal As String
    Dim mExportDirectory As String = String.Empty

    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.SalesOrderFileFolderSys, rSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(rSalesOrder.OrderNo))
    mRetVal = IO.Path.Combine(mExportDirectory, rSalesOrderItem.ImageFile)

    Return mRetVal
  End Function

  Public Shared Function TotalAmount(ByVal vUnitPrice As Decimal, ByVal vQuantity As Int32) As Decimal
    Dim mRetVal As Decimal

    mRetVal = vUnitPrice * vQuantity

    Return mRetVal
  End Function

  Public Shared Function BoardFeetFromCMAndQty(ByVal vQty As Integer, ByVal vLength As Decimal, ByVal vWidth As Decimal, ByVal vThickness As Decimal) As Decimal
    Dim mLengthInInches As Decimal
    Dim mWidthInInches As Decimal
    Dim mThicknessInInches As Decimal
    Dim mRetVal As Decimal

    'mLengthInInches = vLength / 12
    mLengthInInches = CMToHalfInchesLength(vLength)
    mWidthInInches = CMToQuaterInches(vWidth)
    'mWidthInInches = vWidth
    mThicknessInInches = GrosWoodThickness(vThickness)

    mRetVal = vQty * (mLengthInInches * mWidthInInches * mThicknessInInches)

    mRetVal = mRetVal / 144

    mRetVal = Math.Round(mRetVal, 4)

    Return mRetVal
  End Function

  Public Shared Function GetDefaultBreakMins(ByVal vStartTime As DateTime, ByVal vEndTime As DateTime) As Integer
    Dim mRetVal As Integer = 0
    If vStartTime.TimeOfDay <= New TimeSpan(9, 0, 0) And vEndTime.TimeOfDay >= New TimeSpan(10, 0, 0) Then
      mRetVal = mRetVal + 15
    End If
    If vStartTime.TimeOfDay <= New TimeSpan(12, 0, 0) And vEndTime.TimeOfDay >= New TimeSpan(13, 0, 0) Then
      mRetVal = mRetVal + 30
    End If
    Return mRetVal
  End Function

  Public Shared Function GetPrinterName(ByVal vPrinterName As String) As String
    Dim mRetVal As String = ""
    If vPrinterName <> "" Then
      For Each mName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
        If mName.Length >= vPrinterName.Length Then
          If mName.Substring(0, Len(vPrinterName)) = vPrinterName Then
            mRetVal = mName
            Exit For
          End If
        End If
      Next
    End If
    Return mRetVal
  End Function

End Class
