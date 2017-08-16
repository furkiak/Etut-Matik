Public Class Anket

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If ComboBox14.Text = "Öğretmen" Then
            Dim lili As String
            lili = InputBox("Bir Anket Adı Giriniz.", "Bilgi")
            If lili <> "" Then
                cmd.CommandText = "insert into ankets values('" & lili & "','" & ComboBox14.Text & "','')"
                cmd.ExecuteNonQuery()
                ds.Clear()
                ds.Reset()
                ListBox2.Items.Clear()

                cmd.CommandText = "select * from ankets"
                adp.Fill(ds, "f")
                For rex = 0 To ds.Tables("f").Rows.Count - 1

                    ListBox2.Items.Add(ds.Tables("f").Rows(rex).Item(0))
                Next
            Else
                MessageBox.Show("Lütfen Anket ismini boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        ElseIf ComboBox14.Text = "Öğrenci" Then
            If ComboBox13.Text <> "" Then
                Dim lili As String
                lili = InputBox("Bir Anket Adı Giriniz.", "Bilgi")
                If lili <> "" Then
                    cmd.CommandText = "insert into ankets values('" & lili & "','" & ComboBox14.Text & "','" & ComboBox13.Text & "')"
                    cmd.ExecuteNonQuery()
                    ds.Clear()
                    ds.Reset()
                    ListBox2.Items.Clear()
                    cmd.CommandText = "select * from ankets"
                    adp.Fill(ds, "f")
                    For rex = 0 To ds.Tables("f").Rows.Count - 1
                        ListBox2.Items.Add(ds.Tables("f").Rows(rex).Item(0))
                    Next
                Else
                    MessageBox.Show("Lütfen Anket ismini boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Else
            MessageBox.Show("Lütfen Önce Seçim Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If ListBox2.SelectedIndex <> -1 Then
            If MessageBox.Show(ListBox2.SelectedItem & " Bu Anketi Silmek İstiyormusunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from anket where adı='" & ListBox2.SelectedItem & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "delete from ankets where ankets='" & ListBox2.SelectedItem & "'"
                cmd.ExecuteNonQuery()
                ds.Clear()
                ds.Reset()
                ListBox2.Items.Clear()

                cmd.CommandText = "select * from ankets"
                adp.Fill(ds, "f")
                For rex = 0 To ds.Tables("f").Rows.Count - 1
                    ListBox2.Items.Add(ds.Tables("f").Rows(rex).Item(0))
                Next

            End If

        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex <> -1 Then
            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select * from anket where adı='" & ListBox2.SelectedItem & "'"
            adp.Fill(ds, "gg")
            DataGridView12.DataSource = ds.Tables("gg")

        End If
    End Sub
    Dim soru As Integer = -1

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If TextBox30.Text <> "" And TextBox29.Text <> "" And TextBox28.Text <> "" And TextBox26.Text <> "" And TextBox25.Text <> "" And TextBox24.Text <> "" Then
            If MessageBox.Show("Soruyu Eklemek İstiyormusunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "insert into anket values('" & ListBox2.SelectedItem & "','" & TextBox30.Text & "','" & TextBox29.Text & "','" & TextBox28.Text & "','" & TextBox26.Text & "','" & TextBox25.Text & "','" & TextBox24.Text & "','','')"
                cmd.ExecuteNonQuery()
                ds.Clear()
                ds.Reset()

                cmd.CommandText = "select * from anket where adı='" & ListBox2.SelectedItem & "'"
                adp.Fill(ds, "gg")
                DataGridView12.DataSource = ds.Tables("gg")
            End If
        End If
    End Sub

    Private Sub DataGridView12_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView12.CellClick
        soru = e.RowIndex

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If soru <> -1 Then
            cmd.CommandText = "delete  from anket where soru='" & DataGridView12.Item(1, soru).Value & "' and adı='" & ListBox2.SelectedItem & "'"

            cmd.ExecuteNonQuery()

            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select * from anket where adı='" & ListBox2.SelectedItem & "'"
            adp.Fill(ds, "gg")
            DataGridView12.DataSource = ds.Tables("gg")
        End If
    End Sub

    Private Sub Anket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()
        ComboBox13.Items.Clear()

        cmd.CommandText = "select * from ankets"
        adp.Fill(ds, "Ders")
        ListBox2.Items.Clear()

        For rex = 0 To ds.Tables("Ders").Rows.Count - 1
            ListBox2.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))

        Next
        ds.Clear()
        ds.Reset()
        ComboBox13.Items.Clear()

        cmd.CommandText = "select * from puanturu"
        adp.Fill(ds, "Ders")


        For rex = 0 To ds.Tables("Ders").Rows.Count - 1
            ComboBox13.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))

        Next

    End Sub
End Class