Public Class Sınıf

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmd.CommandText = "delete from sınıf"
        cmd.ExecuteNonQuery()

        For rex = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Item(0, rex).Value <> "" Then
                cmd.CommandText = "insert into sınıf values('" & DataGridView1.Item(0, rex).Value & "','" & DataGridView1.Item(1, rex).Value & "','" & DataGridView1.Item(2, rex).Value & "','" & DataGridView1.Item(3, rex).Value & "','" & DataGridView1.Item(4, rex).Value & "','" & DataGridView1.Item(5, rex).Value & "')"
                cmd.ExecuteNonQuery()

            End If
          
        Next
        MessageBox.Show("Ekleme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Sınıf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from sınıf"
        adp.Fill(ds, "r")

        DataGridView1.DataSource = ds.Tables("r")
    End Sub
End Class