Imports System.Management

Public Class Form1
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kod = "FE" & HardDiskSerialNumber() & "X4" & SystemSerialNumber() & "TY"
        TextBox1.Text = kod
        TextBox1.Text = TextBox1.Text.Replace(" ", "")
        TextBox1.Text = TextBox1.Text.Replace("O", "G")
        TextBox1.Text = TextBox1.Text.ToUpper

    End Sub
    Dim kods As String
    Dim value As String = My.Application.Info.DirectoryPath


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


        If TextBox2.Text = kods Then


            RichTextBox2.Text = "Lisans1"
            RichTextBox2.SaveFile("c:\Windows\amxreadx.dll")
            RichTextBox2.Text = "Lisans2"
            RichTextBox2.SaveFile("c:\Windows\xffeawq.dll")
            RichTextBox1.Text = "Lisans3"
            RichTextBox1.SaveFile("c:\Windows\sca.dll")
            RichTextBox1.Text = "1"
            RichTextBox1.SaveFile(value & "\amxread.dll")
            RichTextBox1.Text = TextBox2.Text
            RichTextBox1.SaveFile("c:\Windows\scxa.dll")


            RichTextBox2.Text = "Lisans1"
            RichTextBox2.SaveFile("c:\Windows\amxreadx.dll")
            RichTextBox2.Text = "Lisans2"
            RichTextBox2.SaveFile("c:\Windows\xffeawq.dll")
            RichTextBox1.Text = "Lisans3"
            RichTextBox1.SaveFile("c:\Windows\sca.dll")
            RichTextBox1.Text = "1"
            RichTextBox1.SaveFile(value & "\amxread.dll")
            RichTextBox1.Text = TextBox2.Text
            RichTextBox1.SaveFile("c:\Windows\scxa.dll")

            RichTextBox2.Text = "Lisans1"
            RichTextBox2.SaveFile("c:\Windows\amxreadx.dll")
            RichTextBox2.Text = "Lisans2"
            RichTextBox2.SaveFile("c:\Windows\xffeawq.dll")
            RichTextBox1.Text = "Lisans3"
            RichTextBox1.SaveFile("c:\Windows\sca.dll")
            RichTextBox1.Text = "1"
            RichTextBox1.SaveFile(value & "\amxread.dll")
            RichTextBox1.Text = TextBox2.Text
            RichTextBox1.SaveFile("c:\Windows\scxa.dll")
            MessageBox.Show("Lisanslama İşlemi Başarı İle Gerçekleşti İyi Günlerde Kullanın.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell(value & "\O2YNTM.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell(value & "\O2.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell(value & "\net4.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell(value & "\acc86.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell(value & "\acc64.exe", AppWinStyle.NormalFocus)
    End Sub
End Class
