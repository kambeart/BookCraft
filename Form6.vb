Public Class Form6
    Private Sub btnBackToMainMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMainMenu.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class