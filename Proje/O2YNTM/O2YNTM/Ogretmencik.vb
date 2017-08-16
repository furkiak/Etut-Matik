Public Class Ogretmencik

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "Kaydet" Then
            If TextBox12.Text <> "" And TextBox13.Text <> "" And TextBox14.Text <> "" And TextBox16.Text <> "" Then
                cmd.CommandText = "insert into ogretmen values('" & TextBox16.Text & "','" & TextBox14.Text & "','','','" & TextBox13.Text & "','" & TextBox12.Text & "','','','','" & ComboBox1.Text & "','','','','','','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "')"

                cmd.ExecuteNonQuery()
                MessageBox.Show("Ekleme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox16.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                ComboBox4.Text = ""
                If MessageBox.Show("Ekleme İşlemi Başarılı.Başka Bir Öğretmen Eklemek İstiyormusunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Else
                    Me.Hide()

                End If
            End If
        Else
            If TextBox12.Text <> "" And TextBox13.Text <> "" And TextBox14.Text <> "" And TextBox16.Text <> "" Then
                cmd.CommandText = "update ogretmen set sifre='" & TextBox14.Text & "', brans='" & ComboBox1.Text & "', b2='" & ComboBox2.Text & "', b3='" & ComboBox3.Text & "', b4='" & ComboBox4.Text & "' where nom='" & TextBox16.Text & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Düzeltme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox16.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                ComboBox4.Text = ""
                Me.Hide()

            End If
        

        End If
       
    End Sub

    Private Sub Ogretmencik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from ders"
        adp.Fill(ds, "d")
        For rex = 0 To ds.Tables("d").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("d").Rows(rex).Item(0))
            ComboBox2.Items.Add(ds.Tables("d").Rows(rex).Item(0))
            ComboBox3.Items.Add(ds.Tables("d").Rows(rex).Item(0))
            ComboBox4.Items.Add(ds.Tables("d").Rows(rex).Item(0))
        Next
    End Sub
End Class