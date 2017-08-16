<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuanSistemi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuanSistemi))
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.z4 = New System.Windows.Forms.TextBox()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(516, 8)
        Me.Button29.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(155, 28)
        Me.Button29.TabIndex = 85
        Me.Button29.Text = "Çıkar"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(362, 8)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(147, 28)
        Me.Button10.TabIndex = 84
        Me.Button10.Text = "Ekle"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(7, 12)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(84, 17)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Puan Türü"
        '
        'z4
        '
        Me.z4.Location = New System.Drawing.Point(94, 12)
        Me.z4.Margin = New System.Windows.Forms.Padding(4)
        Me.z4.Name = "z4"
        Me.z4.Size = New System.Drawing.Size(259, 22)
        Me.z4.TabIndex = 82
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Location = New System.Drawing.Point(4, 41)
        Me.DataGridView8.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView8.Size = New System.Drawing.Size(996, 421)
        Me.DataGridView8.TabIndex = 81
        '
        'PuanSistemi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1006, 471)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.z4)
        Me.Controls.Add(Me.DataGridView8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PuanSistemi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PuanSistemi"
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents z4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
End Class
