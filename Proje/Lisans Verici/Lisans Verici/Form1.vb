Public Class Form1
    Dim kods As String

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
        TextBox2.Text = kods

    End Sub
End Class
