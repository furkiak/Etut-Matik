Public Class Duyuru

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If ComboBox10.Text <> "" And TextBox19.Text <> "" And TextBox18.Text <> "" Then
            cmd.CommandText = "insert into duyuru values('" & ComboBox10.Text & "','" & TextBox19.Text & "','" & TextBox18.Text & "')"
            cmd.ExecuteNonQuery()

            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select * from duyuru"
            adp.Fill(ds, "f")
            DataGridView10.DataSource = ds.Tables("f")

        End If
    End Sub

    Private Sub Duyuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox10.Items.Clear()
        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from sınıf"
        adp.Fill(ds, "d")


        For rex = 0 To ds.Tables("d").Rows.Count - 1
            ComboBox10.Items.Add(ds.Tables("d").Rows(rex).Item(1))

        Next

        ds.Clear()
        ds.Reset()

        cmd.CommandText = "select * from duyuru"
        adp.Fill(ds, "f")
        DataGridView10.DataSource = ds.Tables("f")
    End Sub
    Dim secim As Integer = -1

    Private Sub DataGridView10_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView10.CellClick
        secim = e.RowIndex

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If secim <> -1 Then
            cmd.CommandText = "delete  from duyuru where duyuru='" & DataGridView10.Item(1, secim).Value & "'"

            cmd.ExecuteNonQuery()

            ds.Clear()
            ds.Reset()


            cmd.CommandText = "select * from duyuru"
            adp.Fill(ds, "f")
            DataGridView10.DataSource = ds.Tables("f")
        End If
    End Sub
End Class