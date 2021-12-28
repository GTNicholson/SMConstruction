Public Class frmViewImage
  Public Shared Sub ShowImage(ByVal vImage As Image)
    Dim mfrm As New frmViewImage

    mfrm.pcImage.Image = vImage

    mfrm.Show()

  End Sub
End Class