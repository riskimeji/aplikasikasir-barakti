Imports System.Data.Odbc
Public Class FormLogin
    Private Sub FormLogin_FormClosed(ByVal sender As System.Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub
    Sub Terbuka()
        'FormMenuUtama.PictureBox4.Visible = False
        'FormMenuUtama.PictureBox5.Visible = True
        'FormMenuUtama.PictureBox8.Visible = True
        'FormMenuUtama.PictureBox1.Visible = False
        'FormMenuUtama.PictureBox16.Visible = True
        'FormMenuUtama.Panel3.Visible = True
        'FormMenuUtama.Button2.Visible = True
        'FormMenuUtama.Button3.Visible = True
        'FormMenuUtama.Button4.Visible = True
        'FormMenuUtama.Button5.Visible = True
        'FormMenuUtama.Panel3.Visible = False
        Dim test As FormMenuUtama = New FormMenuUtama
        AddHandler test.FormClosed, AddressOf FormLogin_FormClosed
        test.Show()
        Me.Hide()
        'Call FormMenuUtama.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Call FormErrorLogin.ShowDialog()
        Else
            Call Koneksi()
            CMd = New OdbcCommand("Select * From users where id='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", Conn)
            Rd = CMd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then

                'If TextBox1.Text = "AA" And TextBox2.Text = "BB" Then
                'Me.Close()
                Users.Username = Rd.GetString(1)
                Users.Level = Rd.GetString(3)
                Call Terbuka()


            Else
                Call Form2.ShowDialog()

            End If
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.BorderColor = Color.FromArgb(213, 218, 223)
        Else
            TextBox1.BorderColor = Color.Green
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.BorderColor = Color.FromArgb(213, 218, 223)
        Else
            TextBox2.BorderColor = Color.Green

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Guna2Button1.PerformClick()
        End If
    End Sub
End Class