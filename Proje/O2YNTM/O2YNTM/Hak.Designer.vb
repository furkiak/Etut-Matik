<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hak))
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label45.Location = New System.Drawing.Point(249, 145)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(106, 14)
        Me.Label45.TabIndex = 27
        Me.Label45.Text = "www.furkiak.com"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Location = New System.Drawing.Point(10, 9)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(93, 13)
        Me.Label44.TabIndex = 26
        Me.Label44.Text = "Furkiak Lisans:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(10, 176)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(151, 39)
        Me.Label42.TabIndex = 25
        Me.Label42.Text = "İletişim:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telefon: 0541 43 43 43 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mail: info@furkiak.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Hak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(370, 249)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Hak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hakkımızda"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
