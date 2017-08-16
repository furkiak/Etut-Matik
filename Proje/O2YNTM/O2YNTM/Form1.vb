Imports System.Net
Imports System.Management

Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Zamanlar.ShowDialog()
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PuanSistemi.ShowDialog()
    End Sub
    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        UzakNot.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SAAT.Text = "Saat: " & Now
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
        End
    End Sub
    Dim kods, kod As String
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
    Dim ilim As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Width = 768
            Me.Height = 400


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
            con.ConnectionString = baglanti
            con.Open()
            cmd.Connection = con
            adp.SelectCommand = cmd


            If ilim = 0 Then
                Hak.Label44.Text = "Etüt Matik Lisans: " & kods
            Else
                Hak.Label44.Text = "Etüt Matik: Demo"

            End If


            Dim ipDeger As New WebClient
            IP.Text = "IP: " & ipDeger.DownloadString("http://agentgatech.appspot.com/")
            Pcname.Text = "Bilgisayar Adı: " & System.Environment.MachineName

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
       
    End Sub

    Private Sub SAAT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SAAT.LinkClicked
        MessageBox.Show("Ahmaklar zamanı nasıl öldüreceğini, akıllılar ise nasıl kazanacağını düşünür", "Zaman", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        DerslerVeKonuları.ShowDialog()

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Sınıf.ShowDialog()

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dersprogramı.ShowDialog()

    End Sub


    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ogretici = True

        Secim.ShowDialog()


    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        ogretici = False

        Secim.ShowDialog()

    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Duyuru.ShowDialog()

    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        MessageBox.Show("Sınav Şablonu Dershaneniz İçin Henüz Yüklenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Devamsızlık.ShowDialog()

    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Anket.ShowDialog()

    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Hak.ShowDialog()

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Raporlar.ShowDialog()
    End Sub
End Class
