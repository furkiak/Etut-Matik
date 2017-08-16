Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
    Public value As String = My.Application.Info.DirectoryPath
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next

        Shell(value & "\ADE.EXE", vbNormalFocus)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next

        Shell(value & "\NET.EXE", vbNormalFocus)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next

        Dim xl As Object
        xl = CreateObject("Excel.Application")
        xl.Visible = True
        xl.Workbooks.Open(value & "\Bilgiler.xlsx").Open()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next

        Dim xl As Object

        xl = CreateObject("Word.Application")
        xl.Visible = True
        xl.Documents.Open(value & "\Kullanim.docx").Open()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next

        Shell(value & "\O2Y.exe", vbNormalFocus)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error Resume Next

        Shell(value & "\O2.exe", vbNormalFocus)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
