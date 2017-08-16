Public Class ortmen

    Private Sub Duyuru_Click(sender As Object, e As EventArgs) Handles Duyuru.Click
        On Error Resume Next

        Duyurularım.Text = "Duyurularım"
        Duyurularım.Visible = True
        grp1.Visible = False



        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from duyuru where sınıf='Öğretmen'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Duyuru Notu"
        DataGridView1.Columns(2).HeaderText = "Duyuru Yapan"

    End Sub

    Private Sub program_Click(sender As Object, e As EventArgs) Handles program.Click
        On Error Resume Next

        Duyurularım.Text = "Ders Programı"
        Duyurularım.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from dersprogramı where ogretmen='" & ADsoyad & "' and Adı <> '1'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Dersin Günü"
        DataGridView1.Columns(2).HeaderText = "Dersin Saati"
        DataGridView1.Columns(3).HeaderText = "Ders"
        DataGridView1.Columns(4).HeaderText = "Dersin Öğretmeni"
        DataGridView1.Columns(5).HeaderText = "Derslik"
    End Sub

    Private Sub Karnem_Click(sender As Object, e As EventArgs) Handles Karnem.Click
        On Error Resume Next
        anket.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        ListBox1.Items.Clear()

        cmda.CommandText = "select * from ankets where kitle='Öğretmen'"

        adpa.Fill(dsa, "h")
        For rex = 0 To dsa.Tables("h").Rows.Count - 1
            ListBox1.Items.Add(dsa.Tables("h").Rows(rex).Item(0))


        Next

    End Sub

    Dim aww As Byte

    Dim odevgorus As Integer

    Private Sub Odev_Click(sender As Object, e As EventArgs) Handles Odev.Click
        On Error Resume Next
        odevgorus = 1

        odevg.Visible = True

        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        ComboBox1.Items.Clear()

        cmda.CommandText = "select * from sınıf"
        adpa.Fill(dsa, "f")
        For rex = 0 To dsa.Tables("f").Rows.Count - 1
            ComboBox1.Items.Add(dsa.Tables("f").Rows(rex).Item(1))

        Next

        dsa.Clear()
        dsa.Reset()

        cmda.CommandText = "select * from odev where ogretmen='" & ADsoyad & "'"

        adpa.Fill(dsa, "f")
        DataGridView2.DataSource = dsa.Tables("f")
        odevg.Text = "Ödev"
        TextBox1.Text = ""
        Label1.Text = "Sınıf"
    End Sub



    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        odevg.Visible = False

        grp1.Visible = True

    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs)
      
        grp1.Visible = True

    End Sub
    Dim lilıli As Integer

    Private Sub etut_Click(sender As Object, e As EventArgs) Handles etut.Click
        On Error Resume Next

        etutlerim.Visible = True
        grp1.Visible = False

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from etut where ogretmen='" & ADsoyad & "' and tarih='" & Mid(DateTimePicker1.Value, 1, 10) & "'"

        adpa.Fill(dsa, "hff")

        DataGridView5.DataSource = dsa.Tables("hff")

      

   

    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        On Error Resume Next

        etutlerim.Visible = False
        grp1.Visible = True
        For rex = 0 To DataGridView5.Rows.Count - 1
            cmda.CommandText = "update etut set Durum='Onaylandı' where durum ='Etüt Bekleniyor' and num='" & DataGridView5.Item(0, rex).Value & "' and tarih='" & DataGridView5.Item(1, rex).Value & "' and Ders='" & DataGridView5.Item(2, rex).Value & "' and ogretmen='" & DataGridView5.Item(3, rex).Value & "' and saat='" & DataGridView5.Item(4, rex).Value & "'"
            cmda.ExecuteNonQuery()


        Next
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Duyurularım.Visible = False
        grp1.Visible = True

    End Sub

    Private Sub Gprus_Click(sender As Object, e As EventArgs)


        grp1.Visible = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        anket.Visible = False
        grp1.Visible = True

    End Sub

    Private Sub endcik_Click(sender As Object, e As EventArgs) Handles endcik.Click
        Me.Hide()
        form1.Show()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        On Error Resume Next

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from etut where ogretmen='" & ADsoyad & "' and tarih='" & Mid(DateTimePicker1.Value, 1, 10) & "'"

        adpa.Fill(dsa, "hff")

        DataGridView5.DataSource = dsa.Tables("hff")



       
    End Sub
 

   
    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        On Error Resume Next

        For rex = 0 To DataGridView5.Rows.Count - 1
            cmda.CommandText = "update etut set Durum='" & DataGridView5.Item(6, rex).Value & "' where num='" & DataGridView5.Item(0, rex).Value & "' and tarih='" & DataGridView5.Item(1, rex).Value & "' and Ders='" & DataGridView5.Item(2, rex).Value & "' and ogretmen='" & DataGridView5.Item(3, rex).Value & "' and saat='" & DataGridView5.Item(4, rex).Value & "'"
            cmda.ExecuteNonQuery()


        Next
        MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub GroupBox1_MouseUp(sender As Object, e As MouseEventArgs)
        aww = 0
    End Sub


    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        On Error Resume Next

        lilıli = e.RowIndex
        Label6.Text = DataGridView5.Item(0, e.RowIndex).Value & " Nolu Öğrenci"

    End Sub


    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If lilıli <> -1 Then
            If DataGridView5.Rows.Count <> 0 Then
                DataGridView5.Item(6, lilıli).Value = ComboBox5.Text
                lilıli = -1
            End If
           

        End If
    End Sub

    

    Private Sub ortmen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grp1.Location = New Point((Me.Width - grp1.Width) - ((Me.Width - grp1.Width) / 2), (Me.Height - grp1.Height) - ((Me.Height - grp1.Height) / 2))
        Duyurularım.Location = New Point((Me.Width - Duyurularım.Width) - ((Me.Width - Duyurularım.Width) / 2), (Me.Height - Duyurularım.Height) - ((Me.Height - Duyurularım.Height) / 2))
        etutlerim.Location = New Point((Me.Width - etutlerim.Width) - ((Me.Width - etutlerim.Width) / 2), (Me.Height - etutlerim.Height) - ((Me.Height - etutlerim.Height) / 2))
        anket.Location = New Point((Me.Width - anket.Width) - ((Me.Width - anket.Width) / 2), (Me.Height - anket.Height) - ((Me.Height - anket.Height) / 2))
        etutlerim.Location = New Point((Me.Width - etutlerim.Width) - ((Me.Width - etutlerim.Width) / 2), (Me.Height - etutlerim.Height) - ((Me.Height - etutlerim.Height) / 2))
        odevg.Location = New Point((Me.Width - odevg.Width) - ((Me.Width - odevg.Width) / 2), (Me.Height - odevg.Height) - ((Me.Height - odevg.Height) / 2))

    End Sub
    Dim degisirim As New Integer

    Private Sub TextBox3_Click(sender As Object, e As EventArgs)
        degisirim = 0

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs)
        degisirim = 1

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & "A"

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = TextBox1.Text & "B"

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = TextBox1.Text & "C"

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = TextBox1.Text & "D"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & "E"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & "F"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & "G"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & "H"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & "I"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "J"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "K"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "L"

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = TextBox1.Text & "M"

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = TextBox1.Text & "N"

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = TextBox1.Text & "O"

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = TextBox1.Text & "P"

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = TextBox1.Text & "R"

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox1.Text = TextBox1.Text & "S"

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox1.Text = TextBox1.Text & "T"

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox1.Text = TextBox1.Text & "U"

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox1.Text = TextBox1.Text & "V"

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox1.Text = TextBox1.Text & "Y"

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TextBox1.Text = TextBox1.Text & "Z"

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox1.Text = TextBox1.Text & " "

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        TextBox1.Text = TextBox1.Text & "?"

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Len(TextBox1.Text) <> 0 Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)

        End If
    End Sub
    Dim odevdegis As Integer = -1

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        On Error Resume Next

        odevdegis = e.RowIndex

    End Sub


 

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        On Error Resume Next
        If odevgorus = 1 Then
            If odevdegis <> -1 Then
                cmda.CommandText = "delete from odev where sınıf='" & DataGridView2.Item(0, odevdegis).Value & "' and odev='" & DataGridView2.Item(1, odevdegis).Value & "'"
                cmda.ExecuteNonQuery()

                dsa.Clear()
                dsa.Reset()

                cmda.CommandText = "select * from odev where ogretmen='" & ADsoyad & "'"

                adpa.Fill(dsa, "f")
                DataGridView2.DataSource = dsa.Tables("f")
                odevdegis = -1

            End If
        ElseIf odevgorus = 2 Then
            If odevdegis <> -1 Then
                cmda.CommandText = "delete from gorus where ogrenci='" & DataGridView2.Item(0, odevdegis).Value & "' and Gorus='" & DataGridView2.Item(1, odevdegis).Value & "'"
                cmda.ExecuteNonQuery()

                dsa.Clear()
                dsa.Reset()

                cmda.CommandText = "select * from gorus where ogretmen='" & ADsoyad & "'"

                adpa.Fill(dsa, "f")
                DataGridView2.DataSource = dsa.Tables("f")
                odevdegis = -1

            End If
        End If
      
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        On Error Resume Next
        If odevgorus = 1 Then
            If TextBox1.Text <> "" And ComboBox1.Text <> "" Then
                cmda.CommandText = "insert into odev values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & ADsoyad & "')"
                cmda.ExecuteNonQuery()

                dsa.Clear()
                dsa.Reset()

                cmda.CommandText = "select * from odev where ogretmen='" & ADsoyad & "'"

                adpa.Fill(dsa, "f")
                DataGridView2.DataSource = dsa.Tables("f")


            End If
        ElseIf odevgorus = 2 Then
            If TextBox1.Text <> "" And ComboBox1.Text <> "" Then
                cmda.CommandText = "insert into gorus values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & ADsoyad & "')"
                cmda.ExecuteNonQuery()

                dsa.Clear()
                dsa.Reset()

                cmda.CommandText = "select * from gorus where ogretmen='" & ADsoyad & "'"

                adpa.Fill(dsa, "f")
                DataGridView2.DataSource = dsa.Tables("f")


            End If
        End If
     
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        TextBox1.Text = TextBox1.Text & "."

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        TextBox1.Text = TextBox1.Text & ","

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TextBox1.Text = TextBox1.Text & "0"

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox1.Text = TextBox1.Text & "1"

    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        TextBox1.Text = TextBox1.Text & "2"

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        TextBox1.Text = TextBox1.Text & "3"

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        TextBox1.Text = TextBox1.Text & "4"

    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        TextBox1.Text = TextBox1.Text & "5"

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        TextBox1.Text = TextBox1.Text & "6"

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        TextBox1.Text = TextBox1.Text & "7"

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        TextBox1.Text = TextBox1.Text & "8"

    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        TextBox1.Text = TextBox1.Text & "9"

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TextBox1.Text = ""

    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        On Error Resume Next
        odevgorus = 2

        odevg.Visible = True

        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        ComboBox1.Items.Clear()

        cmda.CommandText = "select * from ogrenci"
        adpa.Fill(dsa, "f")
        For rex = 0 To dsa.Tables("f").Rows.Count - 1
        
            ComboBox1.Items.Add(dsa.Tables("f").Rows(rex).Item(0) & " " & dsa.Tables("f").Rows(rex).Item(4))
        Next

        dsa.Clear()
        dsa.Reset()

        cmda.CommandText = "select * from gorus where ogretmen='" & ADsoyad & "'"

        adpa.Fill(dsa, "f")
        DataGridView2.DataSource = dsa.Tables("f")
        odevg.Text = "Görüş"
        TextBox1.Text = ""
        Label1.Text = "Öğrenci"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged



        If ListBox1.SelectedIndex <> -1 Then

            dsa.Clear()
            dsa.Reset()
            cmda.CommandText = "select * from anketcevap where anket='" & ListBox1.SelectedItem & "' and numara='" & num & "'"

            adpa.Fill(dsa, "g")

            If dsa.Tables("g").Rows.Count <> 0 Then

                DataGridView3.DataSource = dsa.Tables("g")
            Else
                dsa.Clear()
                dsa.Reset()
                cmda.CommandText = "select * from anket where adı='" & ListBox1.SelectedItem & "'"
                adpa.Fill(dsa, "g")

                DataGridView3.DataSource = dsa.Tables("g")

            End If
            DataGridView3.Columns(0).Visible = False
            DataGridView3.Columns(1).HeaderText = "Soru"
            DataGridView3.Columns(2).HeaderText = "A Şıkkı"
            DataGridView3.Columns(3).HeaderText = "B Şıkkı"
            DataGridView3.Columns(4).HeaderText = "C Şıkkı"
            DataGridView3.Columns(5).HeaderText = "D Şıkkı"
            DataGridView3.Columns(6).HeaderText = "E Şıkkı"
            DataGridView3.Columns(7).HeaderText = "Cevap"
            DataGridView3.Columns(8).Visible = False
        End If
    End Sub
    Dim listsecim As Integer = -1

   
    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        listsecim = e.RowIndex
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        grp1.Visible = True

        anket.Visible = False

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If listsecim <> -1 Then
            DataGridView3.Item(7, listsecim).Value = "A"

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If listsecim <> -1 Then
            DataGridView3.Item(7, listsecim).Value = "B"

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If listsecim <> -1 Then
            DataGridView3.Item(7, listsecim).Value = "C"

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If listsecim <> -1 Then
            DataGridView3.Item(7, listsecim).Value = "D"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If listsecim <> -1 Then
            DataGridView3.Item(7, listsecim).Value = "E"

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim cimcim As Boolean
        cimcim = False

        For rex = 0 To DataGridView3.Rows.Count - 1
            If DataGridView3.Item(7, listsecim).Value <> "" Then
            Else
                cimcim = True
            End If
        Next

        If cimcim = True Then
            MessageBox.Show("Boş Sorunuz Var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmda.CommandText = "delete from anketcevap where numara='" & num & "' and anket='" & ListBox1.SelectedItem & "'"
            cmda.ExecuteNonQuery()


            For rex = 0 To DataGridView3.Rows.Count - 1
                cmda.CommandText = "insert into anketcevap values('" & num & "','" & DataGridView3.Item(1, rex).Value & "','" & DataGridView3.Item(2, rex).Value & "','" & DataGridView3.Item(3, rex).Value & "','" & DataGridView3.Item(4, rex).Value & "','" & DataGridView3.Item(5, rex).Value & "','" & DataGridView3.Item(6, rex).Value & "','" & DataGridView3.Item(7, rex).Value & "','" & ListBox1.SelectedItem & "')"

                cmda.ExecuteNonQuery()

            Next
            MessageBox.Show("Anket Başarı İle Cevaplandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            grp1.Visible = True

            anket.Visible = False

        End If
    End Sub
End Class