Public Class ogrenci

    Private Sub ogrenci_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub ogrenci_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub ogrenci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        grp1.Location = New Point((Me.Width - grp1.Width) - ((Me.Width - grp1.Width) / 2), (Me.Height - grp1.Height) - ((Me.Height - grp1.Height) / 2))
        Duyurularım.Location = New Point((Me.Width - Duyurularım.Width) - ((Me.Width - Duyurularım.Width) / 2), (Me.Height - Duyurularım.Height) - ((Me.Height - Duyurularım.Height) / 2))
        etutlerim.Location = New Point((Me.Width - etutlerim.Width) - ((Me.Width - etutlerim.Width) / 2), (Me.Height - etutlerim.Height) - ((Me.Height - etutlerim.Height) / 2))
        anket.Location = New Point((Me.Width - anket.Width) - ((Me.Width - anket.Width) / 2), (Me.Height - anket.Height) - ((Me.Height - anket.Height) / 2))
        Label7.Text = "Öğrenci: " & ADsoyad & " Sınıf: " & sınıf & ""

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Duyurularım.Visible = False

        grp1.Visible = True

    End Sub

    Private Sub endcik_Click(sender As Object, e As EventArgs) Handles endcik.Click

        Me.Hide()
        form1.Show()

    End Sub

    Private Sub Duyuru_Click(sender As Object, e As EventArgs) Handles Duyuru.Click
        On Error Resume Next

        Duyurularım.Text = "Duyurularım"
        Duyurularım.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from duyuru where sınıf='" & sınıf & "'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")


        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Duyuru Notu"
        DataGridView1.Columns(2).HeaderText = "Duyuru Yapan"
    End Sub

    Private Sub Odev_Click(sender As Object, e As EventArgs) Handles Odev.Click
        On Error Resume Next

        Duyurularım.Text = "Ödevlerim"
        Duyurularım.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from odev where sınıf='" & sınıf & "'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")
        DataGridView1.Columns(1).Width = 500


        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Ödev İçeriği"
        DataGridView1.Columns(2).HeaderText = "Ödev Öğretmeni"
    End Sub

    Private Sub Gprus_Click(sender As Object, e As EventArgs) Handles Gprus.Click
        On Error Resume Next
        Duyurularım.Text = "Görüşler"
        Duyurularım.Visible = True
        grp1.Visible = False

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from gorus where Ogrenci='" & num & " " & ADsoyad & "'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")


        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Görüş Notu"
        DataGridView1.Columns(2).HeaderText = "Görüş Öğretmeni"
    End Sub

    Private Sub devamsızlık_Click(sender As Object, e As EventArgs) Handles devamsızlık.Click
        On Error Resume Next

        Duyurularım.Text = "Devamsızlıklarım"
        Duyurularım.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from devamsızlık where ogrno='" & num & "'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Devamsızlık Tarihi"
        DataGridView1.Columns(2).HeaderText = "Devamsızlık Saati"
    End Sub

    Private Sub Sınavlarım_Click(sender As Object, e As EventArgs) Handles Sınavlarım.Click
        Duyurularım.Text = "Sınavlarım"
        Duyurularım.Visible = True
        grp1.Visible = False
    End Sub

    Private Sub program_Click(sender As Object, e As EventArgs) Handles program.Click
        On Error Resume Next

        Duyurularım.Text = "Ders Programı"
        Duyurularım.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from sınıf where sınıfadı='" & sınıf & "'"
        adpa.Fill(dsa, "h")
        Dim lilili As String
        lilili = dsa.Tables("h").Rows(0).Item(3)

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from dersprogramı where adı='" & lilili & "'"
        adpa.Fill(dsa, "h")
        DataGridView1.DataSource = dsa.Tables("h")


        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Dersin Günü"
        DataGridView1.Columns(2).HeaderText = "Dersin Saati"
        DataGridView1.Columns(3).HeaderText = "Ders"
        DataGridView1.Columns(4).HeaderText = "Dersin Öğretmeni"
        DataGridView1.Columns(5).HeaderText = "Derslik"
    End Sub

    Dim d_tarih, gun
    Private Sub etut_Click(sender As Object, e As EventArgs) Handles etut.Click
        On Error Resume Next

        etutlerim.Visible = True
        grp1.Visible = False
        ComboBox3.Items.Clear()

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from ders where Tur='" & tur & "'"
        adpa.Fill(dsa, "h")
        For rex = 0 To dsa.Tables("h").Rows.Count - 1
            ComboBox3.Items.Add(dsa.Tables("h").Rows(rex).Item(0))

        Next
      

        Do
            d_tarih = combobox4.Value

        Loop While Not IsDate(d_tarih)
        Select Case Weekday(d_tarih)
            Case 1 : gun = "Pazar"
            Case 2 : gun = "Pazartesi"
            Case 3 : gun = "Salı"
            Case 4 : gun = "Çarşamba"
            Case 5 : gun = "Perşembe"
            Case 6 : gun = "Cuma"
            Case 7 : gun = "Cumartesi"
        End Select

        dsa.Clear()
        dsa.Reset()

        cmda.CommandText = "select * from gunler where gun='" & gun & "'"
        adpa.Fill(dsa, "gg")
        If dsa.Tables("gg").Rows(0).Item(1) = "E" Then
            MessageBox.Show("Bu Gün Dershane Tatil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox5.Text = ""
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox5.Enabled = False

            Exit Sub
        Else
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox5.Text = ""
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox5.Enabled = True

        End If
        If gun <> "Pazar" And gun <> "Cumartesi" Then
            ComboBox5.Items.Clear()

            dsa.Clear()
            dsa.Reset()
            cmda.CommandText = "select * from hs"
            adpa.Fill(dsa, "h")
            For rex = 0 To dsa.Tables("h").Rows.Count - 1
                ComboBox5.Items.Add(dsa.Tables("h").Rows(rex).Item(0))

            Next
        Else
            ComboBox5.Items.Clear()

            dsa.Clear()
            dsa.Reset()
            cmda.CommandText = "select * from hi"
            adpa.Fill(dsa, "h")
            For rex = 0 To dsa.Tables("h").Rows.Count - 1
                ComboBox5.Items.Add(dsa.Tables("h").Rows(rex).Item(0))

            Next
        End If
        ComboBox5.Text = ""
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from etut where num='" & num & "'"
        adpa.Fill(dsa, "h")
        DataGridView2.DataSource = dsa.Tables("h")
    End Sub

    Private Sub Karnem_Click(sender As Object, e As EventArgs) Handles Karnem.Click
        anket.Visible = True
        grp1.Visible = False
        dsa.Clear()
        dsa.Reset()
        ListBox1.Items.Clear()

        cmda.CommandText = "select * from ankets where kitle='Öğrenci' and tur='" & tur & "'"

        adpa.Fill(dsa, "h")
        For rex = 0 To dsa.Tables("h").Rows.Count - 1
            ListBox1.Items.Add(dsa.Tables("h").Rows(rex).Item(0))


        Next



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        grp1.Visible = True
        etutlerim.Visible = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        grp1.Visible = True

        anket.Visible = False
     
       
    End Sub
    Dim listsecim As Integer = -1

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        listsecim = e.RowIndex
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


 

    Private Sub ComboBox3_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedValueChanged
        ComboBox2.Items.Clear()

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from ogretmen where brans='" & ComboBox3.Text & "' or b2='" & ComboBox3.Text & "' or b3='" & ComboBox3.Text & "' or b4='" & ComboBox3.Text & "'"

        adpa.Fill(dsa, "h")
        For rex = 0 To dsa.Tables("h").Rows.Count - 1
            ComboBox2.Items.Add(dsa.Tables("h").Rows(rex).Item(4) & " " & dsa.Tables("h").Rows(rex).Item(5))

        Next

        ComboBox1.Items.Clear()

        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from dersvekonu where tur='" & tur & "' and dersadi='" & ComboBox3.Text & "'"

        adpa.Fill(dsa, "h")
        For rex = 0 To dsa.Tables("h").Rows.Count - 1
            ComboBox1.Items.Add(dsa.Tables("h").Rows(rex).Item(1))

        Next

        ComboBox2.Text = ""
        ComboBox1.Text = ""
    End Sub

   

    Private Sub combobox4_ValueChanged(sender As Object, e As EventArgs) Handles combobox4.ValueChanged
        


        Do
            d_tarih = combobox4.Value

        Loop While Not IsDate(d_tarih)
        Select Case Weekday(d_tarih)
            Case 1 : gun = "Pazar"
            Case 2 : gun = "Pazartesi"
            Case 3 : gun = "Salı"
            Case 4 : gun = "Çarşamba"
            Case 5 : gun = "Perşembe"
            Case 6 : gun = "Cuma"
            Case 7 : gun = "Cumartesi"
        End Select

        dsa.Clear()
        dsa.Reset()

        cmda.CommandText = "select * from gunler where gun='" & gun & "'"
        adpa.Fill(dsa, "gg")
        If dsa.Tables("gg").Rows(0).Item(1) = "E" Then
            MessageBox.Show("Bu Gün Dershane Tatil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox5.Text = ""
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox5.Enabled = False

            Exit Sub
        Else
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox5.Text = ""
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox5.Enabled = True

        End If
        If gun <> "Pazar" And gun <> "Cumartesi" Then
            ComboBox5.Items.Clear()

            dsa.Clear()
            dsa.Reset()
            cmda.CommandText = "select * from hs"
            adpa.Fill(dsa, "h")
            For rex = 0 To dsa.Tables("h").Rows.Count - 1
                ComboBox5.Items.Add(dsa.Tables("h").Rows(rex).Item(0))

            Next
        Else
            ComboBox5.Items.Clear()

            dsa.Clear()
            dsa.Reset()
            cmda.CommandText = "select * from hi"
            adpa.Fill(dsa, "h")
            For rex = 0 To dsa.Tables("h").Rows.Count - 1
                ComboBox5.Items.Add(dsa.Tables("h").Rows(rex).Item(0))

            Next
        End If
        ComboBox5.Text = ""
        dsa.Clear()
        dsa.Reset()
        cmda.CommandText = "select * from etut where num='" & num & "' and tarih='" & combobox4.Text & "'"
        adpa.Fill(dsa, "h")
        DataGridView2.DataSource = dsa.Tables("h")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox5.Text <> "" Then
            dsa.Reset()
            dsa.Clear()

            cmda.CommandText = "select * from etut where tarih='" & Mid(combobox4.Value, 1, 10) & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & ComboBox5.Text & "'"
            adpa.Fill(dsa, "tt")
            If dsa.Tables("tt").Rows.Count = 1 Then
                MessageBox.Show("Bu Saatte Bir Etüt Var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                dsa.Reset()
                dsa.Clear()

                cmda.CommandText = "select * from dersprogramı where Gun='" & gun & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & ComboBox5.Text & "'"
                adpa.Fill(dsa, "tt")
                If dsa.Tables("tt").Rows.Count >= 1 Then
                    MessageBox.Show("Bu Saatde Öğretmenin Dersi Vardır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    dsa.Reset()
                    dsa.Clear()

                    cmda.CommandText = "select * from etut where num='" & num & "' and ders='" & ComboBox3.Text & "' and (Durum='Etüt Bekleniyor' or Durum='Onaylandı')"
                    adpa.Fill(dsa, "tt")
                    If dsa.Tables("tt").Rows.Count >= 1 Then
                        MessageBox.Show("Bekleyen Etütünüz Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        dsa.Reset()
                        dsa.Clear()

                        cmda.CommandText = "select * from etut where num='" & num & "' and ogretmen='" & ComboBox2.Text & "' and Durum='Gelmedi'"

                        adpa.Fill(dsa, "tt")



                        Dim sal As Boolean
                        sal = False
                        For rex = 0 To dsa.Tables("tt").Rows.Count - 1
                            If DateDiff(DateInterval.Day, Convert.ToDateTime(Mid(Now, 1, 10)), Convert.ToDateTime(dsa.Tables("tt").Rows(0).Item(1))) < 8 Then
                                sal = True
                            End If
                        Next
                        If sal = True Then
                            MessageBox.Show("Cezalı Etütünüz Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If


                        If Mid(combobox4.Value, 1, 10) = Mid(Now, 1, 10) Then
                            MessageBox.Show("Aynı Güne Etüt Alınamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            cmda.CommandText = "insert into etut values('" & num & "','" & Mid(combobox4.Value, 1, 10) & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "','" & ComboBox5.Text & "','" & ComboBox1.Text & "','Etüt Bekleniyor','" & ADsoyad & "')"
                            cmda.ExecuteNonQuery()
                            ComboBox1.Text = ""
                            ComboBox2.Text = ""
                            ComboBox3.Text = ""

                            ComboBox5.Text = ""
                            MessageBox.Show("Etütünüz Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            dsa.Clear()
                            dsa.Reset()
                            cmda.CommandText = "select * from etut where num='" & num & "'"
                            adpa.Fill(dsa, "h")
                            DataGridView2.DataSource = dsa.Tables("h")


                        End If
                    End If
                End If


            End If

        Else
            MessageBox.Show("Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Dim liluli As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If liluli <> -1 Then
            If DataGridView2.Item(6, liluli).Value = "Etüt Bekleniyor" Then
                If MessageBox.Show("Etütü Silmek İstiyormusunuz?", "Sorucuk", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    cmda.CommandText = "delete from etut where num='" & DataGridView2.Item(0, liluli).Value & "' and tarih='" & DataGridView2.Item(1, liluli).Value & "' and ders='" & DataGridView2.Item(2, liluli).Value & "' and ogretmen='" & DataGridView2.Item(3, liluli).Value & "' and saat='" & DataGridView2.Item(4, liluli).Value & "'"
                    cmda.ExecuteNonQuery()
                    dsa.Clear()
                    dsa.Reset()
                    cmda.CommandText = "select * from etut where num='" & num & "'"
                    adpa.Fill(dsa, "h")
                    DataGridView2.DataSource = dsa.Tables("h")
                    liluli = -1

                End If
            End If
           
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        liluli = e.RowIndex

    End Sub

    Private Sub etutlerim_Enter(sender As Object, e As EventArgs) Handles etutlerim.Enter

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If ComboBox2.Text <> "" Then
                Dim hopis As New DataSet
                If gun <> "Pazar" And gun <> "Cumartesi" Then
                    ComboBox5.Items.Clear()

                    hopis.Clear()
                    hopis.Reset()
                    cmda.CommandText = "select * from hs"
                    adpa.Fill(hopis, "h")
                    For rex = 0 To hopis.Tables("h").Rows.Count - 1
                        dsa.Reset()
                        dsa.Clear()

                        cmda.CommandText = "select * from etut where tarih='" & Mid(combobox4.Value, 1, 10) & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & hopis.Tables("h").Rows(rex).Item(0) & "'"
                        adpa.Fill(dsa, "tt")
                        If dsa.Tables("tt").Rows.Count = 1 Then
                        Else
                            dsa.Reset()
                            dsa.Clear()

                            cmda.CommandText = "select * from dersprogramı where Gun='" & gun & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & hopis.Tables("h").Rows(rex).Item(0) & "'"
                            adpa.Fill(dsa, "tt")
                            If dsa.Tables("tt").Rows.Count >= 1 Then
                            Else
                                ComboBox5.Items.Add(hopis.Tables("h").Rows(rex).Item(0))
                            End If
                        End If
                    Next
                Else
                    ComboBox5.Items.Clear()

                    hopis.Clear()
                    hopis.Reset()
                    cmda.CommandText = "select * from hi"
                    adpa.Fill(hopis, "h")
                    For rex = 0 To hopis.Tables("h").Rows.Count - 1
                        dsa.Reset()
                        dsa.Clear()

                        cmda.CommandText = "select * from etut where tarih='" & Mid(combobox4.Value, 1, 10) & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & hopis.Tables("h").Rows(rex).Item(0) & "'"
                        adpa.Fill(dsa, "tt")
                        If dsa.Tables("tt").Rows.Count = 1 Then
                        Else
                            dsa.Reset()
                            dsa.Clear()

                            cmda.CommandText = "select * from dersprogramı where Gun='" & gun & "' and ogretmen='" & ComboBox2.Text & "' and saat='" & hopis.Tables("h").Rows(rex).Item(0) & "'"
                            adpa.Fill(dsa, "tt")
                            If dsa.Tables("tt").Rows.Count >= 1 Then
                            Else
                                ComboBox5.Items.Add(hopis.Tables("h").Rows(rex).Item(0))
                            End If
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & ex.Source)
        End Try
        
    End Sub

End Class