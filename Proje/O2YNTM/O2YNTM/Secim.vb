Public Class Secim

    Private Sub Secim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ogretici = True Then
            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select Nom,sifre,ad,soyad,brans,b2,b3,b4 from ogretmen"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False

            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Soyad"
            DataGridView1.Columns(4).HeaderText = "Branş 1"
            DataGridView1.Columns(5).HeaderText = "Branş 2"
            DataGridView1.Columns(6).HeaderText = "Branş 3"
            DataGridView1.Columns(7).HeaderText = "Branş 4"
        Else
            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select ogrencino,sifresi,adsoyad,sınıf from ogrenci"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Sınıf"
        End If
    End Sub

  

    Dim secim As Integer = -1


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
       

        If ogretici = True Then
            If secim <> -1 Then
                cmd.CommandText = "delete from ogretmen where nom='" & DataGridView1.Item(0, secim).Value & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Silme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select Nom,sifre,ad,soyad,brans,b2,b3,b4 from ogretmen"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False

            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Soyad"
            DataGridView1.Columns(4).HeaderText = "Branş 1"
            DataGridView1.Columns(5).HeaderText = "Branş 2"
            DataGridView1.Columns(6).HeaderText = "Branş 3"
            DataGridView1.Columns(7).HeaderText = "Branş 4"
        Else
            If secim <> -1 Then
                cmd.CommandText = "delete from ogrenci where ogrencino='" & DataGridView1.Item(0, secim).Value & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Silme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ds.Clear()
            ds.Reset()



            cmd.CommandText = "select ogrencino,sifresi,adsoyad,sınıf from ogrenci"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Sınıf"
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        secim = e.RowIndex

    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If ogretici = False Then
            Ogrenci.Show()
            Ogrenci.TextBox1.ReadOnly = False

            ToolStripTextBox1.Text = ""
            Ogrenci.Button1.Text = "Kaydet"
            Me.Hide()
        Else
            Ogretmencik.Show()
            Ogretmencik.TextBox16.ReadOnly = False

            ToolStripTextBox1.Text = ""
            Ogretmencik.Button8.Text = "Kaydet"
            Me.Hide()
        End If
    

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error Resume Next
        If e.RowIndex <> -1 Then
            If ogretici = False Then

                Ogrenci.TextBox1.ReadOnly = True
                Ogrenci.TextBox1.Text = DataGridView1.Item(0, e.RowIndex).Value
                Ogrenci.TextBox2.Text = DataGridView1.Item(1, e.RowIndex).Value
                Ogrenci.TextBox3.Text = DataGridView1.Item(2, e.RowIndex).Value
               

                Ogrenci.ComboBox1.Text = DataGridView1.Item(3, e.RowIndex).Value


                Ogrenci.Button1.Text = "Düzenle"
                ToolStripTextBox1.Text = ""
                Ogrenci.Show()
                Me.Hide()
            Else
                Ogretmencik.TextBox13.ReadOnly = True
                Ogretmencik.TextBox12.ReadOnly = True
                Ogretmencik.TextBox16.ReadOnly = True
                Ogretmencik.TextBox16.Text = DataGridView1.Item(0, e.RowIndex).Value
                Ogretmencik.TextBox14.Text = DataGridView1.Item(1, e.RowIndex).Value
                Ogretmencik.TextBox13.Text = DataGridView1.Item(2, e.RowIndex).Value
                Ogretmencik.TextBox12.Text = DataGridView1.Item(3, e.RowIndex).Value



                Ogretmencik.ComboBox1.Text = DataGridView1.Item(4, e.RowIndex).Value
                Ogretmencik.ComboBox2.Text = DataGridView1.Item(5, e.RowIndex).Value
                Ogretmencik.ComboBox3.Text = DataGridView1.Item(6, e.RowIndex).Value
                Ogretmencik.ComboBox4.Text = DataGridView1.Item(7, e.RowIndex).Value



                Ogretmencik.Button8.Text = "Düzenle"
                ToolStripTextBox1.Text = ""
                Ogretmencik.Show()
                Me.Hide()
            End If
        End If
    End Sub

 
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If ogretici = True Then
            ds.Clear()
            ds.Reset()

            cmd.CommandText = "select Nom,sifre,ad,soyad,brans,b2,b3,b4 from ogretmen where ad like '" & ToolStripTextBox1.Text & "%'"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False

            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Soyad"
            DataGridView1.Columns(4).HeaderText = "Branş 1"
            DataGridView1.Columns(5).HeaderText = "Branş 2"
            DataGridView1.Columns(6).HeaderText = "Branş 3"
            DataGridView1.Columns(7).HeaderText = "Branş 4"
        Else
            ds.Clear()
            ds.Reset()



            cmd.CommandText = "select ogrencino,sifresi,adsoyad,sınıf from ogrenci  where adsoyad like '" & ToolStripTextBox1.Text & "%'"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
            DataGridView1.Columns(0).HeaderText = "Numara"
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "Ad"
            DataGridView1.Columns(3).HeaderText = "Sınıf"
        End If
    End Sub
End Class