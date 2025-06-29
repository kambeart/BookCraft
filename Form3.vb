Public Class Form3
    Private Sub btnGoToProfile_Click(sender As Object, e As EventArgs) Handles btnGoToProfile.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnEbook_Click(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnBackToShoppingCart_Click(sender As Object, e As EventArgs) Handles btnBackToShoppingCart.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class