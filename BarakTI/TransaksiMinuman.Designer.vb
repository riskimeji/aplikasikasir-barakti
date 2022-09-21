<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiMinuman
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.KirimBox = New Guna.UI2.WinForms.Guna2Button()
        Me.TotalHargaBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.JumlahBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.HargaBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MenuBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1407, 769)
        Me.Panel1.TabIndex = 2
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.KirimBox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TotalHargaBox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2ShadowPanel1.Controls.Add(Me.JumlahBox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.HargaBox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.MenuBox)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(361, 173)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 15
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(799, 519)
        Me.Guna2ShadowPanel1.TabIndex = 47
        '
        'KirimBox
        '
        Me.KirimBox.BorderRadius = 15
        Me.KirimBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.KirimBox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.KirimBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.KirimBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KirimBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KirimBox.ForeColor = System.Drawing.Color.White
        Me.KirimBox.Location = New System.Drawing.Point(309, 391)
        Me.KirimBox.Name = "KirimBox"
        Me.KirimBox.Size = New System.Drawing.Size(180, 45)
        Me.KirimBox.TabIndex = 47
        Me.KirimBox.Text = "Tambahkan"
        '
        'TotalHargaBox
        '
        Me.TotalHargaBox.BorderRadius = 5
        Me.TotalHargaBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalHargaBox.DefaultText = ""
        Me.TotalHargaBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalHargaBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TotalHargaBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalHargaBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalHargaBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalHargaBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TotalHargaBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalHargaBox.Location = New System.Drawing.Point(206, 304)
        Me.TotalHargaBox.Name = "TotalHargaBox"
        Me.TotalHargaBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalHargaBox.PlaceholderText = ""
        Me.TotalHargaBox.SelectedText = ""
        Me.TotalHargaBox.Size = New System.Drawing.Size(387, 36)
        Me.TotalHargaBox.TabIndex = 45
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(209, 271)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(108, 27)
        Me.Guna2HtmlLabel9.TabIndex = 44
        Me.Guna2HtmlLabel9.Text = "Total Harga"
        '
        'JumlahBox
        '
        Me.JumlahBox.BorderRadius = 5
        Me.JumlahBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.JumlahBox.DefaultText = ""
        Me.JumlahBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.JumlahBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.JumlahBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.JumlahBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.JumlahBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JumlahBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.JumlahBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JumlahBox.Location = New System.Drawing.Point(393, 215)
        Me.JumlahBox.Name = "JumlahBox"
        Me.JumlahBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.JumlahBox.PlaceholderText = ""
        Me.JumlahBox.SelectedText = ""
        Me.JumlahBox.Size = New System.Drawing.Size(200, 36)
        Me.JumlahBox.TabIndex = 42
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(393, 182)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(66, 27)
        Me.Guna2HtmlLabel8.TabIndex = 41
        Me.Guna2HtmlLabel8.Text = "Jumlah"
        '
        'HargaBox
        '
        Me.HargaBox.BorderRadius = 5
        Me.HargaBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HargaBox.DefaultText = ""
        Me.HargaBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.HargaBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.HargaBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.HargaBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.HargaBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HargaBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HargaBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HargaBox.Location = New System.Drawing.Point(205, 215)
        Me.HargaBox.Name = "HargaBox"
        Me.HargaBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HargaBox.PlaceholderText = ""
        Me.HargaBox.SelectedText = ""
        Me.HargaBox.Size = New System.Drawing.Size(182, 36)
        Me.HargaBox.TabIndex = 40
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(209, 182)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(58, 27)
        Me.Guna2HtmlLabel7.TabIndex = 39
        Me.Guna2HtmlLabel7.Text = "Harga"
        '
        'MenuBox
        '
        Me.MenuBox.BackColor = System.Drawing.Color.Transparent
        Me.MenuBox.BorderRadius = 5
        Me.MenuBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MenuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MenuBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.MenuBox.ItemHeight = 30
        Me.MenuBox.Location = New System.Drawing.Point(205, 128)
        Me.MenuBox.Name = "MenuBox"
        Me.MenuBox.Size = New System.Drawing.Size(388, 36)
        Me.MenuBox.TabIndex = 38
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(209, 95)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(112, 27)
        Me.Guna2HtmlLabel6.TabIndex = 37
        Me.Guna2HtmlLabel6.Text = "Nama Menu"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(290, 76)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(247, 10)
        Me.Guna2Separator2.TabIndex = 19
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(290, 38)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(195, 32)
        Me.Guna2HtmlLabel4.TabIndex = 18
        Me.Guna2HtmlLabel4.Text = "Transaksi Minuman"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 808)
        Me.Panel2.TabIndex = 17
        '
        'TransaksiMinuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 769)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TransaksiMinuman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransaksiMinuman"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents KirimBox As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TotalHargaBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents JumlahBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents HargaBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MenuBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
