Public Class Form9
    Private Sub LinkLabel_UploadCover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_UploadCover.LinkClicked
        OpenFileDialog1.ShowDialog()
        picCoverPage.Load(OpenFileDialog1.FileName)
    End Sub
End Class