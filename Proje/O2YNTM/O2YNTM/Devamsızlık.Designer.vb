<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devamsızlık
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Devamsızlık))
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button27 = New System.Windows.Forms.Button()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView9
        '
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView9.Location = New System.Drawing.Point(3, 4)
        Me.DataGridView9.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView9.Size = New System.Drawing.Size(995, 431)
        Me.DataGridView9.TabIndex = 5
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
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(3, 439)
        Me.Button27.Margin = New System.Windows.Forms.Padding(4)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(995, 28)
        Me.Button27.TabIndex = 7
        Me.Button27.Text = "Kaydet"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Devamsızlık
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1006, 471)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.DataGridView9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Devamsızlık"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devamsızlık"
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button27 As System.Windows.Forms.Button
End Class
