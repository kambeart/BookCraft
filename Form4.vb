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

    Private Sub llbl_ChangeEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_ChangeEmail.LinkClicked
        txtEmail.Text = lblEmail.Text
        txtEmail.Location = lblEmail.Location
        txtEmail.Size = lblEmail.Size
        txtEmail.Visible = True
        lblEmail.Visible = False
        txtEmail.Focus()
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblEmail.Text = txtEmail.Text
            txtEmail.Visible = False
            lblEmail.Visible = True
        End If
    End Sub

    Private Sub btnBackToLoginPage_Click(sender As Object, e As EventArgs) Handles btnBackToLoginPage.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class