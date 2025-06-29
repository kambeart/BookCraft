Public Class Form4
    Private Sub LinkImageUpload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkImageUpload.LinkClicked
        OpenFileDialog1.ShowDialog()
        picPFP.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub llblLogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLogOut.LinkClicked
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Log Out")
        If response = vbYes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class