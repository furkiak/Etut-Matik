<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevamSek
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevamSek))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SAAT = New System.Windows.Forms.LinkLabel()
        Me.Pcname = New System.Windows.Forms.LinkLabel()
        Me.IP = New System.Windows.Forms.LinkLabel()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(584, 277)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(112, 96)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'SAAT
        '
        Me.SAAT.AutoSize = True
        Me.SAAT.BackColor = System.Drawing.Color.Transparent
        Me.SAAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SAAT.LinkColor = System.Drawing.SystemColors.Menu
        Me.SAAT.Location = New System.Drawing.Point(-166, 228)
        Me.SAAT.Name = "SAAT"
        Me.SAAT.Size = New System.Drawing.Size(27, 17)
        Me.SAAT.TabIndex = 21
        Me.SAAT.TabStop = True
        Me.SAAT.Text = "IP:"
        '
        'Pcname
        '
        Me.Pcname.AutoSize = True
        Me.Pcname.BackColor = System.Drawing.Color.Transparent
        Me.Pcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Pcname.LinkColor = System.Drawing.Color.OrangeRed
        Me.Pcname.Location = New System.Drawing.Point(-166, 197)
        Me.Pcname.Name = "Pcname"
        Me.Pcname.Size = New System.Drawing.Size(27, 17)
        Me.Pcname.TabIndex = 22
        Me.Pcname.TabStop = True
        Me.Pcname.Text = "IP:"
        '
        'IP
        '
        Me.IP.AutoSize = True
        Me.IP.BackColor = System.Drawing.Color.Transparent
        Me.IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.IP.LinkColor = System.Drawing.Color.OrangeRed
        Me.IP.Location = New System.Drawing.Point(-166, 168)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(27, 17)
        Me.IP.TabIndex = 23
        Me.IP.TabStop = True
        Me.IP.Text = "IP:"
        '
        'DataGridView9
        '
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView9.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView9.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView9.Size = New System.Drawing.Size(742, 385)
        Me.DataGridView9.TabIndex = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "Öğrenci Numarası"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Devamsızlık Tarihi"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Devamsızlık Saati"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 358)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(742, 27)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.BackColor = System.Drawing.Color.LightGreen
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripButton1.Text = "Kaydet"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'DevamSek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 385)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.SAAT)
        Me.Controls.Add(Me.Pcname)
        Me.Controls.Add(Me.IP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "DevamSek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DevamSek"
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SAAT As System.Windows.Forms.LinkLabel
    Friend WithEvents Pcname As System.Windows.Forms.LinkLabel
    Friend WithEvents IP As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
