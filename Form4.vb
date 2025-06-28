Public Class Form4
    Private Sub LinkImageUpload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkImageUpload.LinkClicked
        OpenFileDialog1.ShowDialog()
        picPFP.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub picPFP_Click(sender As Object, e As EventArgs) Handles picPFP.Click

    End Sub
End Class