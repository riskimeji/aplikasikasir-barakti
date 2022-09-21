<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(312, 388)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2Panel2.Location = New System.Drawing.Point(-9, -2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(337, 27)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.BarakTI.My.Resources.Resources.png_transparent_computer_icons_error_closeup_miscellaneous_text_logo_removebg_preview1
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(85, 49)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(143, 128)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(120, 173)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(72, 32)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "ERROR"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(45, 246)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(218, 79)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Make sure your user code and password are entered correctly"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(101, 224)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(110, 10)
        Me.Guna2Separator2.TabIndex = 4
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2Panel3.Location = New System.Drawing.Point(-16, 370)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(337, 27)
        Me.Guna2Panel3.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(110, 322)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(92, 28)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "Close"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 388)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
