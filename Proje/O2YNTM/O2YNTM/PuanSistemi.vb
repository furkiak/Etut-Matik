Public Class PuanSistemi

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If z4.Text <> "" Then
            If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "insert into puanturu values('" & z4.Text & "')"
                cmd.ExecuteNonQuery()



                z4.Text = ""

                ds.Clear()
                ds.Reset()
                cmd.CommandText = "select * from puanturu"
                adp.Fill(ds, "puanturu")
                DataGridView8.DataSource = ds.Tables("puanturu")
            End If

        Else
            MessageBox.Show("Lütfen Puan Türünü Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If puansecer <> -1 Then
            If MessageBox.Show(DataGridView8.Item(0, puansecer).Value & " Öğesini Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from puanturu  where puanturu='" & DataGridView8.Item(0, puansecer).Value & "'"
                cmd.ExecuteNonQuery()




                puansecer = -1
                ds.Clear()
                ds.Reset()
                cmd.CommandText = "select * from puanturu"
                adp.Fill(ds, "puanturu")
                DataGridView8.DataSource = ds.Tables("puanturu")
            End If


        Else
            MessageBox.Show("Lütfen Seçim Yapınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Dim puansecer As Integer = -1

    Private Sub DataGridView8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView8.CellClick
        puansecer = e.RowIndex

    End Sub

    Private Sub PuanSistemi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from puanturu"
        adp.Fill(ds, "puanturu")
        DataGridView8.DataSource = ds.Tables("puanturu")
    End Sub
End Class