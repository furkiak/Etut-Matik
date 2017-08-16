Public Class Dersprogramı

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox12.Text = "Genel" Then
            cmd.CommandText = "delete from dersprogramı"
            cmd.ExecuteNonQuery()

            For rex = 0 To DataGridView2.RowCount - 1
                If DataGridView2.Item(0, rex).Value <> "" Then
                    cmd.CommandText = "insert into dersprogramı values('" & DataGridView2.Item(0, rex).Value & "','" & DataGridView2.Item(1, rex).Value & "','" & DataGridView2.Item(2, rex).Value & "','" & DataGridView2.Item(3, rex).Value & "','" & DataGridView2.Item(4, rex).Value & "','" & DataGridView2.Item(5, rex).Value & "')"
                    cmd.ExecuteNonQuery()

                End If

            Next
            MessageBox.Show("Ekleme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cmd.CommandText = "delete from dersprogramı where ogretmen='" & ComboBox12.Text & "'"

            cmd.ExecuteNonQuery()

            For rex = 0 To DataGridView2.RowCount - 1
                If DataGridView2.Item(0, rex).Value <> "" Then
                    cmd.CommandText = "insert into dersprogramı values('" & DataGridView2.Item(0, rex).Value & "','" & DataGridView2.Item(1, rex).Value & "','" & DataGridView2.Item(2, rex).Value & "','" & DataGridView2.Item(3, rex).Value & "','" & DataGridView2.Item(4, rex).Value & "','" & DataGridView2.Item(5, rex).Value & "')"
                    cmd.ExecuteNonQuery()

                End If
            Next
            MessageBox.Show("Ekleme İşlemi Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If ComboBox12.Text <> "" Or ComboBox12.Text <> "Genel" Then
            Dim a As String
            a = InputBox("Lütfen Doldurmak İstediğiniz Günü Giriniz.", "Bilgi")

            If a <> "" Then
                a = a.Substring(0, 1).ToUpper() + a.Substring(1)

                If a = "Pazar" Or a = "Cumartesi" Then
                    ds.Clear()
                    ds.Reset()
                    cmd.CommandText = "select * from dersprogramı where ogretmen='" & ComboBox12.Text & "'"

                    adp.Fill(ds, "re")



                    cmd.CommandText = "select * from hi"
                    adp.Fill(ds, "r")
                    For rex = 0 To ds.Tables("r").Rows.Count - 1
                        ds.Tables("re").Rows.Add("1", a, ds.Tables("r").Rows(rex).Item(0), "-", ComboBox12.Text, "-")
                    Next
                    DataGridView2.DataSource = ds.Tables("re")

                    DataGridView2.Columns(0).HeaderText = "Program İsmi"
                    DataGridView2.Columns(1).HeaderText = "Dersin Günü"
                    DataGridView2.Columns(2).HeaderText = "Dersin Saati"
                    DataGridView2.Columns(3).HeaderText = "Ders"
                    DataGridView2.Columns(4).HeaderText = "Dersin Öğretmeni"
                    DataGridView2.Columns(5).HeaderText = "Derslik"
                Else
                    ds.Clear()
                    ds.Reset()
                    cmd.CommandText = "select * from dersprogramı where ogretmen='" & ComboBox12.Text & "'"

                    adp.Fill(ds, "re")



                    cmd.CommandText = "select * from hs"
                    adp.Fill(ds, "r")
                    For rex = 0 To ds.Tables("r").Rows.Count - 1
                        ds.Tables("re").Rows.Add("1", a, ds.Tables("r").Rows(rex).Item(0), "-", ComboBox12.Text, "-")
                    Next
                    DataGridView2.DataSource = ds.Tables("re")

                    DataGridView2.Columns(0).HeaderText = "Program İsmi"
                    DataGridView2.Columns(1).HeaderText = "Dersin Günü"
                    DataGridView2.Columns(2).HeaderText = "Dersin Saati"
                    DataGridView2.Columns(3).HeaderText = "Ders"
                    DataGridView2.Columns(4).HeaderText = "Dersin Öğretmeni"
                    DataGridView2.Columns(5).HeaderText = "Derslik"
                End If


            End If
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.Text = "Genel" Then
            ds.Clear()
            ds.Reset()
            cmd.CommandText = "select * from dersprogramı"

            adp.Fill(ds, "r")

            DataGridView2.DataSource = ds.Tables("r")

            DataGridView2.Columns(0).HeaderText = "Program İsmi"
            DataGridView2.Columns(1).HeaderText = "Dersin Günü"
            DataGridView2.Columns(2).HeaderText = "Dersin Saati"
            DataGridView2.Columns(3).HeaderText = "Ders"
            DataGridView2.Columns(4).HeaderText = "Dersin Öğretmeni"
            DataGridView2.Columns(5).HeaderText = "Derslik"
        Else
            ds.Clear()
            ds.Reset()
            cmd.CommandText = "select * from dersprogramı where ogretmen='" & ComboBox12.Text & "'"

            adp.Fill(ds, "r")

            DataGridView2.DataSource = ds.Tables("r")

            DataGridView2.Columns(0).HeaderText = "Program İsmi"
            DataGridView2.Columns(1).HeaderText = "Dersin Günü"
            DataGridView2.Columns(2).HeaderText = "Dersin Saati"
            DataGridView2.Columns(3).HeaderText = "Ders"
            DataGridView2.Columns(4).HeaderText = "Dersin Öğretmeni"
            DataGridView2.Columns(5).HeaderText = "Derslik"
        End If
    End Sub

    Private Sub Dersprogramı_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        ds.Reset()
        ComboBox12.Items.Clear()
        cmd.CommandText = "select * from ogretmen"
        adp.Fill(ds, "Ders")

        For rex = 0 To ds.Tables("Ders").Rows.Count - 1
            ComboBox12.Items.Add(ds.Tables("Ders").Rows(rex).Item(4) & " " & ds.Tables("Ders").Rows(rex).Item(5))

        Next
        ComboBox12.Items.Add("Genel")

        ds.Clear()
        ds.Reset()
        cmd.CommandText = "select * from dersprogramı"
        adp.Fill(ds, "r")

        DataGridView2.DataSource = ds.Tables("r")

        DataGridView2.Columns(0).HeaderText = "Program İsmi"
        DataGridView2.Columns(1).HeaderText = "Dersin Günü"
        DataGridView2.Columns(2).HeaderText = "Dersin Saati"
        DataGridView2.Columns(3).HeaderText = "Ders"
        DataGridView2.Columns(4).HeaderText = "Dersin Öğretmeni"
        DataGridView2.Columns(5).HeaderText = "Derslik"
    End Sub
End Class