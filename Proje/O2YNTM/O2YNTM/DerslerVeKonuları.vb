Public Class DerslerVeKonuları

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If ComboBox9.Text <> "" Then
            Dim bilgi As String
            bilgi = InputBox("Lütfen Ders Adını Giriniz.", "Ders Adı")

            If bilgi <> "" Then
                If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "insert into ders values('" & bilgi & "','" & ComboBox9.Text & "')"
                    cmd.ExecuteNonQuery()



                    ds.Clear()
                    ds.Reset()
                    ListBox1.Items.Clear()
                    ListBox5.Items.Clear()
                    cmd.CommandText = "select * from ders"
                    adp.Fill(ds, "Ders")

                    For rex = 0 To ds.Tables("Ders").Rows.Count - 1
                        ListBox1.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))
                        ListBox5.Items.Add(ds.Tables("Ders").Rows(rex).Item(1))
                    Next


                    ComboBox9.Text = ""

                End If


            Else
                MessageBox.Show("Lütfen Ders Adını Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Lütfen Ders Puan Türünü Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ComboBox9.Text <> "" Then
            If ListBox1.SelectedIndex <> -1 Then
                If MessageBox.Show(ListBox1.SelectedItem & " " & ListBox5.SelectedItem & " Öğesini Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    ListBox5.SelectedIndex = ListBox1.SelectedIndex
                    cmd.CommandText = "delete from ders where ders = '" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "delete from dersvekonu where dersadi = '" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"
                    cmd.ExecuteNonQuery()



                    ds.Clear()
                    ds.Reset()
                    ListBox1.Items.Clear()
                    ListBox5.Items.Clear()
                    cmd.CommandText = "select * from ders"
                    adp.Fill(ds, "Ders")

                    For rex = 0 To ds.Tables("Ders").Rows.Count - 1
                        ListBox1.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))
                        ListBox5.Items.Add(ds.Tables("Ders").Rows(rex).Item(1))
                    Next

                End If
            Else
                MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


        ds.Clear()
        ds.Reset()
        DataGridView7.Columns.Clear()
        ListBox5.SelectedIndex = ListBox1.SelectedIndex
        DataGridView7.DataSource = ""

        cmd.CommandText = "select * from dersvekonu where dersadi='" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"

        adp.Fill(ds, "DersVeKonu")
        DataGridView7.DataSource = ds.Tables("DersVeKonu")
        ComboBox9.Text = ListBox5.SelectedItem

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox27.Text <> "" Then
            If MessageBox.Show("Kayıt İşlemini Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "insert into dersvekonu values('" & ListBox1.SelectedItem & "','" & TextBox27.Text & "','" & ListBox5.SelectedItem & "')"
                cmd.ExecuteNonQuery()



                ds.Clear()
                ds.Reset()


                cmd.CommandText = "select * from dersvekonu where dersadi='" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"

                adp.Fill(ds, "DersVeKonu")
                DataGridView7.DataSource = ds.Tables("DersVeKonu")
                TextBox27.Text = ""

            End If



        Else
            MessageBox.Show("Lütfen Ders Adını Hatasız Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If secilen7 <> -1 Then
            If MessageBox.Show(DataGridView7.Item(1, secilen7).Value & " Öğesini Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "delete from dersvekonu where konu = '" & DataGridView7.Item(1, secilen7).Value & "' and dersadi='" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"

                cmd.ExecuteNonQuery()



                ds.Clear()
                ds.Reset()


                cmd.CommandText = "select * from dersvekonu where dersadi='" & ListBox1.SelectedItem & "' and tur='" & ListBox5.SelectedItem & "'"

                adp.Fill(ds, "DersVeKonu")
                DataGridView7.DataSource = ds.Tables("DersVeKonu")

                secilen7 = -1


            End If
        Else
            MessageBox.Show("Lütfen Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim secilen7 As Integer = -1

    Private Sub DataGridView7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellClick
        secilen7 = e.RowIndex

    End Sub

    Private Sub DerslerVeKonuları_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()
        ListBox1.Items.Clear()
        ListBox5.Items.Clear()
        cmd.CommandText = "select * from ders"
        adp.Fill(ds, "Ders")

        For rex = 0 To ds.Tables("Ders").Rows.Count - 1
            ListBox1.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))
            ListBox5.Items.Add(ds.Tables("Ders").Rows(rex).Item(1))
        Next

        ds.Clear()
        ds.Reset()
        ComboBox9.Items.Clear()

        cmd.CommandText = "select * from puanturu"
        adp.Fill(ds, "Ders")

        For rex = 0 To ds.Tables("Ders").Rows.Count - 1
            ComboBox9.Items.Add(ds.Tables("Ders").Rows(rex).Item(0))
        Next
    End Sub
End Class