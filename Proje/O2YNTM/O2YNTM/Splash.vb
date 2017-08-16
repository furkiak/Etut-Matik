Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 200

    End Sub
End Class