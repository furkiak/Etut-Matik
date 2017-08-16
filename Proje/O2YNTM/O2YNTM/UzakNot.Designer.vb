<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UzakNot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UzakNot))
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(13, 33)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(506, 63)
        Me.TextBox20.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Location = New System.Drawing.Point(9, 12)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(510, 17)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "Bu Not Evlerinden Bağlanan Öğrenci Ve Öğretmenlere İletilen Nottur:"
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(12, 104)
        Me.Button30.Margin = New System.Windows.Forms.Padding(4)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(507, 60)
        Me.Button30.TabIndex = 5
        Me.Button30.Text = "Kaydet"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'UzakNot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 174)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Button30)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UzakNot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UzakNot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Button30 As System.Windows.Forms.Button
End Class
