Public Class Ogrenci

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Kaydet" Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox1.Text <> "" Then
                cmd.CommandText = "insert into ogrenci values('" & TextBox1.Text & "','" & TextBox2.Text & "','','','" & TextBox3.Text & "','','','','','','','','','','" & ComboBox1.Text & "','','','','','','','','')"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Ekleme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Text = ""
                TextBox2.Text = ""

                TextBox3.Text = ""

                ComboBox1.Text = ""
                If MessageBox.Show("Ekleme İşlemi Başarılı.Yeni Öğrenci Eklemek İstiyormusunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Else
                    Me.Hide()

                End If
            End If
        Else
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox1.Text <> "" Then
                cmd.CommandText = "update ogrenci set sifresi='" & TextBox2.Text & "', sınıf='" & ComboBox1.Text & "', adsoyad='" & TextBox3.Text & "' where ogrencino='" & TextBox1.Text & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Düzeltme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Text = ""
                TextBox2.Text = ""

                TextBox3.Text = ""

                ComboBox1.Text = ""
                Me.Hide()

            End If

          
            End If
          

    End Sub

    Private Sub Ogrenci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from sınıf"
        adp.Fill(ds, "d")


        For rex = 0 To ds.Tables("d").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("d").Rows(rex).Item(1))

        Next
    End Sub
End Class