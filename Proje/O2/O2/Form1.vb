Imports System.Management

Public Class form1
    Dim Rastgele As New Random
    Dim tuttum As New Integer

    Private Sub form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cona.Close()
    End Sub


    Private Sub form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True

    End Sub

    Dim kods As String

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 
            RichTextBox1.LoadFile(value & "\amxread.dll")
            If RichTextBox1.Text = "6b93f0385e98b74a0b3bfc7426de80d5" Then
                ilim = 1
                RichTextBox1.LoadFile(value & "\usbaaplrc.dll")

                b2 = RichTextBox1.Text
                RichTextBox1.LoadFile(value & "\DDORes.dll")
                b1 = RichTextBox1.Text
                baglanti = b1 & value & b2
            ElseIf RichTextBox1.Text = "1" Then

                RichTextBox1.LoadFile("c:\Windows\amxreadx.dll")

            If RichTextBox1.Text = "Lisans1" Then
                RichTextBox1.LoadFile("c:\Windows\xffeawq.dll")

                If RichTextBox1.Text = "Lisans2" Then
                    RichTextBox1.LoadFile("c:\Windows\sca.dll")

                    If RichTextBox1.Text = "Lisans3" Then
                        RichTextBox1.LoadFile("c:\Windows\scxa.dll")

                        kod = "FE" & HardDiskSerialNumber() & "X4" & SystemSerialNumber() & "TY"
                        TextBox1.Text = kod
                        TextBox1.Text = TextBox1.Text.Replace(" ", "")
                        TextBox1.Text = TextBox1.Text.Replace("O", "G")
                        TextBox1.Text = TextBox1.Text.ToUpper
                        For rex = 1 To Len(TextBox1.Text)
                            If Mid(TextBox1.Text, rex, 1) = "Q" Then
                                kods = kods & "U4asV"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "W" Then
                                kods = kods & "N1X42"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "E" Then
                                kods = kods & "UBasd4"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "R" Then
                                kods = kods & "GLaJ"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "T" Then
                                kods = kods & "BD1J"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "Y" Then
                                kods = kods & "IaYR"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "U" Then
                                kods = kods & "12dSD"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "I" Then
                                kods = kods & "qA"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "O" Then
                                kods = kods & "SDe1G1H"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "P" Then
                                kods = kods & "212DdH3S"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "A" Then
                                kods = kods & "gARQaJvr1"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "S" Then
                                kods = kods & "barq12"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "D" Then
                                kods = kods & "gdac12r"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "F" Then
                                kods = kods & "k09-"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "G" Then
                                kods = kods & "h423s"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "H" Then
                                kods = kods & "bh03d"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "J" Then
                                kods = kods & "53,i"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "K" Then
                                kods = kods & "5"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "L" Then
                                kods = kods & "l2"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "Z" Then
                                kods = kods & "fX"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "X" Then
                                kods = kods & "*1"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "C" Then
                                kods = kods & "1sFae"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "V" Then
                                kods = kods & "s31cDS"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "B" Then
                                kods = kods & "AS1S"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "N" Then
                                kods = kods & "CSf1S"
                            ElseIf Mid(TextBox1.Text, rex, 1) = "M" Then
                                kods = kods & "Ac"
                            End If
                        Next
                        If RichTextBox1.Text = kods Then
                            ilim = 0


                            RichTextBox1.LoadFile(value & "\Cone3.dll")
                            baglanti = RichTextBox1.Text

                        End If

                    End If

                End If

            End If

        Else
                End
            End If

            Grp1.Location = New Point((Me.Width - Grp1.Width) - ((Me.Width - Grp1.Width) / 2), (Me.Height - Grp1.Height) - ((Me.Height - Grp1.Height) / 2))



            cona.ConnectionString = baglanti
            cona.Open()
            If cona.State <> ConnectionState.Open Then
                MessageBox.Show("Programda Bir Hata Var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End

            End If


            cmda.Connection = cona
            adpa.SelectCommand = cmda

            dsa.Clear()
            dsa.Reset()
            tuttum = Rastgele.Next(1, 331)
            cmda.CommandText = "Select * from Filo where num=" & tuttum
            adpa.Fill(dsa, "Bilgi")
            lbl_soz.Text = Mid(dsa.Tables("Bilgi").Rows(0).Item(0), 1, Len(dsa.Tables("Bilgi").Rows(0).Item(0)) - 1)
            Exit Sub

3:

            End
    

    End Sub
    Dim kod As String
    Public Function HardDiskSerialNumber() As String
        Dim disk As New ManagementClass("Win32_PhysicalMedia")
        Dim Sonuc As String = ""
        For Each Hdisk As ManagementObject In disk.GetInstances()
            If Hdisk("SerialNumber") <> Nothing Then
                Sonuc = Hdisk("SerialNumber")
            End If
        Next Hdisk
        Return Sonuc
    End Function
    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = _
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = _
            serial_numbers.Substring(2)

        Return serial_numbers
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        cmdass.Connection = cona
        adpass.SelectCommand = cmdass

        asss.Clear()
        asss.Reset()
        tuttum = Rastgele.Next(1, 331)
        cmdass.CommandText = "Select * from Filo where num=" & tuttum
        adpass.Fill(asss, "Bilgi")
        lbl_soz.Text = Mid(asss.Tables("Bilgi").Rows(0).Item(0), 1, Len(asss.Tables("Bilgi").Rows(0).Item(0)) - 1)

    End Sub

    Dim democ, ilim As Integer

    Private Sub Grs_Click(sender As Object, e As EventArgs) Handles Grs.Click
        On Error Resume Next
        ogrenci.label6.Visible = False
        If ilim = 1 Then
            democ += 1
            If democ = 10 Then
                End
            Else

                MessageBox.Show("Etüt Matik Programının Deneme Sürümünü Kullanıyorsunuz Lütfen Programı Satın Alınız.", "Kopya Kullanım Lisans:Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            End If

            If TXTnum.Text <> "" And TxtPass.Text <> "" Then
                If TXTnum.Text = "000" And TxtPass.Text = "90053214" Then
                    cona.Close()

                    End

                End If
                dsa.Clear()
                dsa.Reset()
                cmda.CommandText = "select * from ogrenci where ogrencino='" & TXTnum.Text & "' and sifresi='" & TxtPass.Text & "'"
                adpa.Fill(dsa, "A")
                If dsa.Tables("A").Rows.Count = 1 Then
                    num = dsa.Tables("A").Rows(0).Item(0)
                    ADsoyad = dsa.Tables("A").Rows(0).Item(4)
                    sınıf = dsa.Tables("A").Rows(0).Item(14)

                    dsa.Clear()
                    dsa.Reset()
                    cmda.CommandText = "select * from sınıf where sınıfadı='" & sınıf & "'"
                    adpa.Fill(dsa, "A")
                    tur = dsa.Tables("A").Rows(0).Item(4)

                    dsa.Clear()
                    dsa.Reset()
                    cmda.CommandText = "Select * from kontrol where num='" & num & "'"
                    adpa.Fill(dsa, "g")

                    If dsa.Tables("g").Rows.Count = 0 Then
                        dsa.Clear()
                        dsa.Reset()
                        cmda.CommandText = "Select * from odev where sınıf='" & sınıf & "'"
                        adpa.Fill(dsa, "g")
                        ogrenci.label6.Text = dsa.Tables("g").Rows.Count
                        ogrenci.label6.Visible = True


                        cmda.CommandText = "insert into kontrol values('" & num & "','" & dsa.Tables("g").Rows.Count & "')"
                        cmda.ExecuteNonQuery()
                    Else

                        Dim akontrol As Integer
                        akontrol = dsa.Tables("g").Rows(0).Item(1)


                        dsa.Clear()
                        dsa.Reset()
                        cmda.CommandText = "Select * from odev where sınıf='" & sınıf & "'"
                        adpa.Fill(dsa, "g")
                        ogrenci.label6.Text = dsa.Tables("g").Rows.Count - akontrol
                        ogrenci.label6.Visible = True
                        cmda.CommandText = "update kontrol set  sayi='" & dsa.Tables("g").Rows.Count & "' where num='" & num & "'"
                        cmda.ExecuteNonQuery()

                    End If


                    Me.Hide()
                    ogrenci.Show()
                    TXTnum.Text = ""
                    TxtPass.Text = ""
                    Exit Sub

                Else
                    dsa.Clear()
                    dsa.Reset()
                    cmda.CommandText = "select * from ogretmen where nom='" & TXTnum.Text & "' and sifre='" & TxtPass.Text & "'"
                    adpa.Fill(dsa, "A")
                    If dsa.Tables("A").Rows.Count = 1 Then
                        num = dsa.Tables("A").Rows(0).Item(0)
                        ADsoyad = dsa.Tables("A").Rows(0).Item(4) & " " & dsa.Tables("A").Rows(0).Item(5)



                        tur = "Öğretmen"
                        Me.Hide()
                        ortmen.Show()
                        TXTnum.Text = ""
                        TxtPass.Text = ""
                        Exit Sub
                    End If
                End If

                MessageBox.Show("Böyle Bir Kullanıcı Yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Alanları Boş Bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


    End Sub

    Private Sub Tmz_Click(sender As Object, e As EventArgs) Handles Tmz.Click
        On Error Resume Next

        TXTnum.Text = ""
        TxtPass.Text = ""

    End Sub

    Dim secim As Boolean = True

    Private Sub TXTnum_Click(sender As Object, e As EventArgs)
        secim = True

    End Sub



    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "0"
        Else
            TxtPass.Text = TxtPass.Text & "0"
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "1"
        Else
            TxtPass.Text = TxtPass.Text & "1"
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "2"
        Else
            TxtPass.Text = TxtPass.Text & "2"
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "3"
        Else
            TxtPass.Text = TxtPass.Text & "3"
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "4"
        Else
            TxtPass.Text = TxtPass.Text & "4"
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "5"
        Else
            TxtPass.Text = TxtPass.Text & "5"
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "6"
        Else
            TxtPass.Text = TxtPass.Text & "6"
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "7"
        Else
            TxtPass.Text = TxtPass.Text & "7"
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "8"
        Else
            TxtPass.Text = TxtPass.Text & "8"
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If secim = True Then
            TXTnum.Text = TXTnum.Text & "9"
        Else
            TxtPass.Text = TxtPass.Text & "9"
        End If
    End Sub

    Private Sub TxtPass_Click(sender As Object, e As EventArgs)
        secim = False

    End Sub


    Dim lila As Byte

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lila += 1

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        lila -= 1

    End Sub

    Private Sub lbl_soz_Click(sender As Object, e As EventArgs) Handles lbl_soz.Click
        If lila = 3 Then
            TXTnum.Text = "000"
            TxtPass.Text = "90053214"
        End If
    End Sub


    Private Sub Grp1_Enter(sender As Object, e As EventArgs) Handles Grp1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Tüm Hakları Saklıdır.", "www.furkiak.com", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub TXTnum_Click1(sender As Object, e As EventArgs) Handles TXTnum.Click
        secim = True
    End Sub

    Private Sub TxtPass_Click1(sender As Object, e As EventArgs) Handles TxtPass.Click
        secim = False
    End Sub

    Private Sub Btnsl_Click(sender As Object, e As EventArgs) Handles Btnsl.Click
        If secim = True Then
            If Len(TXTnum.Text) <> 0 Then
                TXTnum.Text = Mid(TXTnum.Text, 1, Len(TXTnum.Text) - 1)
            End If
        Else
            If Len(TxtPass.Text) <> 0 Then
                TxtPass.Text = Mid(TxtPass.Text, 1, Len(TxtPass.Text) - 1)
            End If
        End If

    End Sub
End Class