Public Class Zamanlar

    Private Sub Zamanlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dhs = -1
        dhi = -1
        ds.Clear()

        ds.Reset()

        cmd.CommandText = "select * from gunler"
        adp.Fill(ds, "TB1")
        cmd.CommandText = "select * from hi"
        adp.Fill(ds, "TB2")
        cmd.CommandText = "select * from hs"
        adp.Fill(ds, "TB3")


        DataGridView5.DataSource = ds.Tables("TB1")
        DataGridView4.DataSource = ds.Tables("TB2")
        DataGridView6.DataSource = ds.Tables("TB3")

    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        dhi = e.RowIndex
    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick
        dhs = e.RowIndex
    End Sub

    Dim dhs As Integer = -1
    Dim dhi As Integer = -1


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "delete from gunler"
            cmd.ExecuteNonQuery()

            For rex = 0 To DataGridView5.Rows.Count - 1
                cmd.CommandText = "insert into gunler values('" & DataGridView5.Item(0, rex).Value & "','" & DataGridView5.Item(1, rex).Value & "')"
                cmd.ExecuteNonQuery()

            Next


            ds.Tables("TB1").Clear()

            cmd.CommandText = "select * from gunler"
            adp.Fill(ds, "TB1")

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox17.Text <> "" Then
            If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "insert into hi values('" & TextBox17.Text & "')"
                cmd.ExecuteNonQuery()



                ds.Tables("TB2").Clear()
                cmd.CommandText = "select * from hi"
                adp.Fill(ds, "TB2")
                TextBox17.Text = ""
            End If

        Else
            MessageBox.Show("Lütfen Saat Aralığını Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If dhi <> -1 Then
            If MessageBox.Show(DataGridView4.Item(0, dhi).Value & " Öğesini Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "delete from hi where saat = '" & DataGridView4.Item(0, dhi).Value & "'"
                cmd.ExecuteNonQuery()


                ds.Tables("TB2").Clear()

                cmd.CommandText = "select * from hi"
                adp.Fill(ds, "TB2")
                dhi = -1
            End If
        Else
            MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox38.Text <> "" Then
            If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "insert into hs values('" & TextBox38.Text & "')"
                cmd.ExecuteNonQuery()



                ds.Tables("TB3").Clear()

                cmd.CommandText = "select * from hs"
                adp.Fill(ds, "TB3")
                TextBox38.Text = ""
            End If

        Else
            MessageBox.Show("Lütfen Saat Aralığını Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If dhs <> -1 Then
            If MessageBox.Show(DataGridView6.Item(0, dhs).Value & " Öğesini Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "delete from hs where saat = '" & DataGridView6.Item(0, dhs).Value & "'"
                cmd.ExecuteNonQuery()



                ds.Tables("TB3").Clear()

                cmd.CommandText = "select * from hs"
                adp.Fill(ds, "TB3")
                dhs = -1
            End If

        Else
            MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class