Public Class Devamsızlık

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If MessageBox.Show("Devamsızlıklar İşlensin mi?", "Sorucuk", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For rex = 0 To DataGridView9.Rows.Count - 1

                cmd.CommandText = "insert into devamsızlık values('" & DataGridView9.Item(0, rex).Value & "','" & DataGridView9.Item(1, rex).Value & "','" & DataGridView9.Item(2, rex).Value & "')"
                cmd.ExecuteNonQuery()
                Me.Hide()

            Next
            MessageBox.Show("Devamsızlıklar İşlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView9.Rows.Clear()

        End If
    End Sub

    Private Sub Devamsızlık_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class