Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class uctHouseTypeOptions

  Private pHouseType As dmHouseType
  Private pRTISGlobal As AppRTISGlobal

  Public Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
    Set(value As dmHouseType)
      pHouseType = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public Sub UpdateObjects()
    pHouseType.ModelID = clsDEControlLoading.GetDEComboValue(cboModel)
    pHouseType.TmpFoundationOption = clsDEControlLoading.GetDEComboValue(cboFoundations)
    pHouseType.TmpFloorOptions = clsDEControlLoading.GetDEComboValue(cboFloor)
    pHouseType.TmpWallOptions = clsDEControlLoading.GetDEComboValue(cboWalls)
    pHouseType.TmpWindowOptions = clsDEControlLoading.GetDEComboValue(cboWindows)
    pHouseType.TmpDeckOption = chkDeck.Checked
  End Sub

  Public Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.GroupType)
    clsDEControlLoading.FillDEComboVI(cboGroup, mVIs)


    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.HouseType)
    clsDEControlLoading.FillDEComboVI(cboModel, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FoundationOptions)
    clsDEControlLoading.FillDEComboVI(cboFoundations, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FloorOptions)
    clsDEControlLoading.FillDEComboVI(cboFloor, mVIs)


    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WallOptions)
    clsDEControlLoading.FillDEComboVI(cboWalls, mVIs)

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WindowOptions)
    clsDEControlLoading.FillDEComboVI(cboWindows, mVIs)


  End Sub

End Class
