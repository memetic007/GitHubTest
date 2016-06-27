Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static Dim x, z As Integer
        x = x + 1

        Label1.Text = "Button Pressed " + x.ToString

        z = MyStuff.AddTwo(x, 2)
        Label2.Text = "Plus 2: " + z.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y As Integer
        x = 99999999

        Application.Exit()

    End Sub
End Class
