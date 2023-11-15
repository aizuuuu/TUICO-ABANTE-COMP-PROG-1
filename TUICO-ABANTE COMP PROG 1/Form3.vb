Public Class Form3
    Private Sub btnStartReading_Click(sender As Object, e As EventArgs) Handles btnStartReading.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.Show()
        Me.Hide()
        Form1.txtPass.Text = ""
        Form1.txtUser.Text = ""

    End Sub

End Class