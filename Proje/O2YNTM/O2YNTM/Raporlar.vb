
Imports mexcel = Microsoft.Office.Interop.Excel

Public Class Raporlar



    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        ToolStripComboBox2.Text = ""

        If ToolStripComboBox1.Text = "Öğrenci Numarası" Then
            ToolStripComboBox2.Items.Clear()
            ToolStripLabel2.Visible = True

            ToolStripComboBox2.Items.Add("Ders Programı")
            ToolStripComboBox2.Items.Add("Etütleri")
            ToolStripComboBox2.Items.Add("Devamsızlıkları")
            ToolStripComboBox2.Items.Add("Sınavları")
            ToolStripComboBox2.Items.Add("Öğretmen Görüşleri")
            ToolStripComboBox2.Items.Add("Anket Sonuçları")
            ToolStripComboBox2.Visible = True
        ElseIf ToolStripComboBox1.Text = "Sınıf Adı" Then
            ToolStripComboBox2.Items.Clear()
            ToolStripComboBox2.Items.Add("Ders Programı")
            ToolStripComboBox2.Items.Add("Ödevleri")
            ToolStripComboBox2.Visible = True
            ToolStripLabel2.Visible = True
        ElseIf ToolStripComboBox1.Text = "Öğretmen Adı Soyadı" Then
            ToolStripComboBox2.Items.Clear()
            ToolStripComboBox2.Items.Add("Ders Programı")
            ToolStripComboBox2.Items.Add("Etütleri")
            '    ToolStripComboBox2.Items.Add("Anket Sonuçları")
            ToolStripComboBox2.Visible = True
            ToolStripLabel2.Visible = True
        ElseIf ToolStripComboBox1.Text = "Anket Adı" Then
            ToolStripComboBox2.Visible = False
            ToolStripLabel2.Visible = False

        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ToolStripComboBox1.Text = "Öğrenci Numarası" Then
            If ToolStripComboBox2.Text = "Ders Programı" Then
                ds.Reset()
                cmd.CommandText = "select * from dersprogramı where adı in (select sınıf from ogrenci where ogrencino= '" & ToolStripTextBox1.Text & "')"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Etütleri" Then
                ds.Reset()
                cmd.CommandText = "select * from etut where num ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Devamsızlıkları" Then
                ds.Reset()
                cmd.CommandText = "select * from devamsızlık where ogrno ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Öğretmen Görüşleri" Then
                ds.Reset()
                cmd.CommandText = "select * from gorus where ogrenci like  '" & ToolStripTextBox1.Text & "%'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Anket Sonuçları" Then
                ds.Reset()
                cmd.CommandText = "select * from anketcevap where numara='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If

        End If

        If ToolStripComboBox1.Text = "Sınıf Adı" Then
            If ToolStripComboBox2.Text = "Ders Programı" Then
                ds.Reset()
                cmd.CommandText = "select * from dersprogramı where adı ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Ödevleri" Then
                ds.Reset()
                cmd.CommandText = "select * from odev where sınıf ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
        End If
        If ToolStripComboBox1.Text = "Öğretmen Adı Soyadı" Then
            If ToolStripComboBox2.Text = "Ders Programı" Then
                ds.Reset()
                cmd.CommandText = "select * from dersprogramı where ogretmen ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If
            If ToolStripComboBox2.Text = "Etütleri" Then
                ds.Reset()
                cmd.CommandText = "select * from etut where ogretmen ='" & ToolStripTextBox1.Text & "'"
                adp.Fill(ds, "a")
                DataGridView1.DataSource = ds.Tables("a")
            End If

        End If
        If ToolStripComboBox1.Text = "Anket Adı" Then
            ds.Reset()
            cmd.CommandText = "select * from anket where adı ='" & ToolStripTextBox1.Text & "'"
            adp.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim exceluygulama As New mexcel.Application()
            Dim excelkitap As mexcel.Workbook
            excelkitap = exceluygulama.Workbooks.Add(True)
            Dim excelsayfa As mexcel.Worksheet
            excelsayfa = CType(exceluygulama.ActiveSheet, mexcel.Worksheet)
            exceluygulama.Visible = True
            Dim satirnumarasi As Integer = 1
            Dim sutunnumarasi As Integer
            For Each sutun As DataColumn In ds.Tables("a").Columns
                sutunnumarasi += 1
                excelsayfa.Cells(1, sutunnumarasi) = sutun.ColumnName
            Next
            For Each satir As DataRow In ds.Tables("a").Rows
                satirnumarasi += 1
                sutunnumarasi = 0
                For Each sutun As DataColumn In ds.Tables("a").Columns
                    sutunnumarasi += 1
                    excelsayfa.Cells(satirnumarasi, sutunnumarasi) = satir(sutun.ColumnName).ToString()
                Next
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class