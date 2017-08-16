<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dersprogramı
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dersprogramı))
        Me.Button32 = New System.Windows.Forms.Button()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button32
        '
        Me.Button32.Location = New System.Drawing.Point(777, 438)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(225, 30)
        Me.Button32.TabIndex = 8
        Me.Button32.Text = "Günü Doldur"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'ComboBox12
        '
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(5, 440)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(165, 24)
        Me.ComboBox12.TabIndex = 7
        Me.ComboBox12.Text = "Genel"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(176, 438)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(599, 30)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Kaydet"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(996, 429)
        Me.DataGridView2.TabIndex = 5
        '
        'Dersprogramı
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1006, 471)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.ComboBox12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dersprogramı"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dersprogramı"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
