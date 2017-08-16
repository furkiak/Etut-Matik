Public Class UzakNot

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If TextBox20.Text <> "" Then
            cmd.CommandText = "delete from notes"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "insert into notes values('" & TextBox20.Text & "')"

            cmd.ExecuteNonQuery()
            MessageBox.Show("İşlem Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub UzakNot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()

        cmd.CommandText = "select * from notes"
        adp.Fill(ds, "f")
        TextBox20.Text = ds.Tables("f").Rows(0).Item(0)
    End Sub
End Class