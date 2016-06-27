Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static Dim x As Integer = 0
        x = x + 1

        Label1.Text = "Button Pressed " + x.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y, x As Integer
        x = 111111
        y = 454545
        Application.Exit()

    End Sub
End Class
