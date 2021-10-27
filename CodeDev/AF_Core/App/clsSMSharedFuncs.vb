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
      mRetVal = CMToQuaterInches(vCM) + 0.25
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

  Public Shared Function CMToHalfInches(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal
    Dim mTempVal As Decimal

    mTempVal = (vCM / 2.54) + 0.5
    mRetVal = Math.Truncate(mTempVal * 2) / 2
    If mRetVal <> (mTempVal * 2) / 2 Then
      mRetVal += 0.5
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



    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, rWorkOrder.DateCreated.Year, clsGeneralA.GetFileSafeName(rWorkOrder.WorkOrderID.ToString("00000")))

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

  Public Shared Function GetStockItemImageFileName(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String
    Dim mExportDirectory As String = String.Empty

    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.StockItemFileFolderSys, clsGeneralA.GetFileSafeName(rStockItem.StockItemID.ToString("00000")))
    mRetVal = IO.Path.Combine(mExportDirectory, rStockItem.ImageFile)

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

  Public Shared Function CMToInches_AFNew(ByVal vNetLenght As Decimal) As Decimal

    Dim mRetVal As Decimal = 0

    mRetVal = Math.Round(vNetLenght / clsConstants.CMToInches, 0, MidpointRounding.AwayFromZero)

    Return mRetVal

  End Function

  Public Shared Function InchesToCM_AFNew(ByVal vInch As Decimal) As Decimal
    Dim mRetVal As Decimal


    mRetVal = Math.Truncate((vInch * clsConstants.CMToInches) - 0.5)

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

  Public Shared Function GetOverTimeCutOffDate(ByVal vDate As DateTime) As DateTime
    Dim mRetVal As Date
    If vDate.Day < 15 Then
      '// find 3 days before the end of the previous month
      mRetVal = New Date(vDate.Year, vDate.Month, 1).AddDays(-1).AddDays(-3)
    Else
      '// Find the 12th of the month
      mRetVal = New Date(vDate.Year, vDate.Month, 15).AddDays(-3)
    End If
    Return mRetVal
  End Function

  Public Shared Function FractStrFromDec(ByVal vNum As Decimal) As String
    Dim mRetVal As String = ""
    Dim mWholeNumber As Integer
    Dim mRemainder As Decimal
    Dim mQty64ths As Decimal
    Dim mDenom As Integer
    Dim mNumerator As Integer
    Dim mOK As Boolean

    Try




      mWholeNumber = Math.Truncate(vNum)
      mRemainder = vNum - mWholeNumber

      If mWholeNumber <> 0 Then
        mRetVal = mRetVal & mWholeNumber.ToString("#")
      End If

      mQty64ths = mRemainder * 64
      mQty64ths = CInt(mQty64ths)

      mNumerator = mQty64ths
      If mNumerator Mod 2 = 0 Then
        mNumerator = mNumerator / 2
        mDenom = 32
        mOK = True

      Else
        mOK = False
      End If

      If mOK Then
        If mNumerator Mod 2 = 0 Then
          mNumerator = mNumerator / 2
          mOK = True
          mDenom = 16

        Else
          mOK = False
        End If
      End If

      If mOK Then
        If mNumerator Mod 2 = 0 Then
          mNumerator = mNumerator / 2
          mOK = True
          mDenom = 8

        Else
          mOK = False
        End If
      End If

      If mOK Then
        If mNumerator Mod 2 = 0 Then
          mNumerator = mNumerator / 2
          mOK = True
          mDenom = 4

        Else
          mOK = False
        End If
      End If

      If mOK Then
        If mNumerator Mod 2 = 0 Then
          mNumerator = mNumerator / 2
          mOK = True
          mDenom = 2

        Else
          mOK = False
        End If
      End If

      If mNumerator <> 0 Then
        If mRetVal <> "" Then mRetVal &= " "
        mRetVal = mRetVal & mNumerator & "/" & mDenom
      End If

    Catch ex As Exception
      mRetVal = ""
    End Try

    Return mRetVal
  End Function

  Public Shared Function DecFromFractString(ByVal vStringFract As String) As Decimal
    Dim mRetVal As Decimal
    Dim mWholeNumberString As String = ""
    Dim mFractNumberString As String = ""
    Dim mNumeratorString As String = ""
    Dim mDenominatorStrig As String = ""
    Dim mIndex As Integer
    Dim mWholeNumber As Integer
    Dim mWholeNumerator As Integer
    Dim mWholeDonominator As Integer
    Dim mMoreSignalsString As String

    Try

      mIndex = vStringFract.IndexOf(" ")
      If mIndex > 0 Then
        vStringFract = vStringFract.Trim
        mWholeNumberString = vStringFract.Substring(0, mIndex)


        If mWholeNumberString <> "" Then
          mWholeNumber = Math.Truncate(Val(mWholeNumberString))
        End If

        mFractNumberString = Right(vStringFract, vStringFract.Length - mIndex - 1)
        mIndex = mFractNumberString.IndexOf("/")

        If mIndex > 0 Then

          mNumeratorString = Left(mFractNumberString, mFractNumberString.Length - mIndex - 1)
          mDenominatorStrig = Right(mFractNumberString, mFractNumberString.Length - mIndex - 1)
        End If

        If mNumeratorString <> "" And mDenominatorStrig <> "" Then


          mWholeNumerator = Val(mNumeratorString)
          mWholeDonominator = Val(mDenominatorStrig)

          mRetVal = mWholeNumber + (mWholeNumerator / mWholeDonominator)
        End If

      ElseIf vStringFract.IndexOf("/") > 0 Then ''It doesnt have space
        mIndex = vStringFract.IndexOf("/")

        If mIndex > 0 Then

          mNumeratorString = Left(vStringFract, vStringFract.Length - mIndex - 1)
          mDenominatorStrig = Right(vStringFract, vStringFract.Length - mIndex - 1)
        End If

        If mNumeratorString <> "" And mDenominatorStrig <> "" Then


          mWholeNumerator = Val(mNumeratorString)
          mWholeDonominator = Val(mDenominatorStrig)

          mRetVal = Math.Round(mWholeNumerator / mWholeDonominator, 4, MidpointRounding.AwayFromZero)
        End If

      Else
        mRetVal = Val(vStringFract)
      End If


    Catch ex As Exception
      mRetVal = 0
    End Try

    Return mRetVal
  End Function

End Class
