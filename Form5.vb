Public Class Form5
    Private Sub btnBookMarket_Click(sender As Object, e As EventArgs) Handles btnBookMarket.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnGoToProfile_Click(sender As Object, e As EventArgs) Handles btnGoToProfile.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class