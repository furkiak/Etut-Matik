Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "yonetim" And PasswordTextBox.Text = "1234" Then
            Form1.Show()
            Me.Hide()
        ElseIf UsernameTextBox.Text = "sekreterlik" And PasswordTextBox.Text = "1234" Then
            DevamSek.Show()
            Me.Hide()

        ElseIf UsernameTextBox.Text = "rehberlik" And PasswordTextBox.Text = "1234" Then

            Form1.Show()
            Form1.LinkLabel1.Enabled = False
            Form1.LinkLabel2.Enabled = False
            Form1.LinkLabel3.Enabled = False
            Form1.LinkLabel4.Enabled = False
            Form1.LinkLabel5.Enabled = False
            Form1.LinkLabel6.Enabled = False
            Form1.LinkLabel11.Enabled = False
            Form1.LinkLabel7.Enabled = False
            Form1.LinkLabel12.Enabled = False
            Me.Hide()

        Else
            MessageBox.Show("Yanlış Bilgi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
       
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()

        End
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 429
        Me.Height = 236

    End Sub
End Class
