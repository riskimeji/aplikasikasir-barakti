Imports System.Data.Odbc
Public Class MenuMinuman


    Private Sub MenuMinuman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "DELETE"
        TextBox1.MaxLength = 6
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from minuman", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "minuman")
        DataGridView1.DataSource = Ds.Tables("minuman")
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 410
        DataGridView1.Columns(2).Width = 120
    End Sub

    Sub FieldAktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Call FieldAktif()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan Mengisi Data ")
            Else
                Call Koneksi()
                Dim InputData As String = "Insert into minuman values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                CMd = New OdbcCommand(InputData, Conn)
                CMd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()



            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Call FieldAktif()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan Mengisi Data ")
            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("update minuman set nama_minuman='" & TextBox2.Text & _
                                           "',harga_minuman='" & TextBox3.Text & _
                                           "' where id_minuman ='" & TextBox1.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                MsgBox("Edit Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "HAPUS"
            Button1.Enabled = False
            Button2.Enabled = False
            Call FieldAktif()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan Data Yang Akan Di Hapus Terisi ")
            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("delete from minuman where id_minuman ='" & TextBox1.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                MsgBox("Delete Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        CMd = New OdbcCommand("select * from minuman where id_minuman ='" & TextBox1.Text.ToUpper & "' ", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            TextBox2.Text = Rd(1)
            TextBox3.Text = Rd(2)
        End If
    End Sub
End Class