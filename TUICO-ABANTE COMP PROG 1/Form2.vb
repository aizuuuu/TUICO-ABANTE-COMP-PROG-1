Imports System.Net.Security

Public Class Form2
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub btnHomescreen_Click(sender As Object, e As EventArgs) Handles btnHomescreen.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class