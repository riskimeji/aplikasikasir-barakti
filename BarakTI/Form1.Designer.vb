<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nama2 = New System.Windows.Forms.Label()
        Me.harga2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.nama = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.harga = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nama2
        '
        Me.nama2.AutoSize = True
        Me.nama2.Location = New System.Drawing.Point(367, 72)
        Me.nama2.Name = "nama2"
        Me.nama2.Size = New System.Drawing.Size(39, 13)
        Me.nama2.TabIndex = 5
        Me.nama2.Text = "Label1"
        '
        'harga2
        '
        Me.harga2.AutoSize = True
        Me.harga2.Location = New System.Drawing.Point(370, 183)
        Me.harga2.Name = "harga2"
        Me.harga2.Size = New System.Drawing.Size(39, 13)
        Me.harga2.TabIndex = 6
        Me.harga2.Text = "Label2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(537, 136)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "TESTT"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(537, 163)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "TEST"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Location = New System.Drawing.Point(65, 12)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(39, 13)
        Me.nama.TabIndex = 0
        Me.nama.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BarakTI.My.Resources.Resources._708dce2b183ecceeb9076d07d88a45bc
        Me.PictureBox1.Location = New System.Drawing.Point(40, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'harga
        '
        Me.harga.AutoSize = True
        Me.harga.Location = New System.Drawing.Point(90, 122)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(39, 13)
        Me.harga.TabIndex = 2
        Me.harga.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.harga)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Location = New System.Drawing.Point(57, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 151)
        Me.Panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 468)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.harga2)
        Me.Controls.Add(Me.nama2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nama2 As System.Windows.Forms.Label
    Friend WithEvents harga2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents harga As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
