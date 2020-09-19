Public Class clsSMSharedFuncs

  Public Shared Function GrosWoodThickness(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal
    Dim mInches As Decimal
    mInches = CMToQuaterInches(vCM)
    If mInches <= 1 Then
      mRetVal = 1
    ElseIf mInches <= 1.5 Then
      mRetVal = 1.5
    ElseIf mInches <= 2 Then
      mRetVal = 2
    Else
      mRetVal = 0
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

    mRetVal = vCM / 2.54
    mRetVal = Math.Truncate(mRetVal * 4) / 4
    mRetVal += 0.25
    Return mRetVal
  End Function

  Public Shared Function CMToQuaterInchesSMM(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal

    mRetVal = vCM / 2.54
    mRetVal = Math.Truncate(mRetVal * 4) / 4
    mRetVal += 0.5
    Return mRetVal
  End Function

  Public Shared Function CMToQuaterInchesLenght(ByVal vCM As Decimal) As Decimal
    Dim mRetVal As Decimal

    mRetVal = vCM / 2.54
    mRetVal = Math.Truncate(mRetVal * 4) / 4
    mRetVal += 2.25
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


  Public Shared Function WOTotalPieces(ByVal vDecimal As Decimal) As Int32

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



End Class
