Public Class Form2
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Cursor = Cursors.Hand
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox1.BackColor = Color.LightGray
    End Sub
End Class