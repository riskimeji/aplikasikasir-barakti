Imports System.Data.Odbc
Public Class MenuMakanan

    Private Sub MenuMakanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call KondisiAwalMinuman()
        Timer1.Enabled = True
        dgv1.Columns(2).DefaultCellStyle.Format = "c"
        DataGridView2.Columns(2).DefaultCellStyle.Format = "c"

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
        Guna2Button1.Visible = False
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from makanan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "makanan")
        dgv1.DataSource = Ds.Tables("makanan")
        dgv1.Columns(0).Width = 150
        dgv1.Columns(1).Width = 300
        dgv1.Columns(2).Width = 150
    End Sub
    Sub FieldAktifEdit()
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        Guna2Button1.Visible = True
        TextBox1.Focus()

    End Sub
    Sub FieldAktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        Guna2Button1.Visible = True
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Guna2Button1.Visible = False
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Call FieldAktif()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                'MsgBox("Pastikan Mengisi Data ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button1.Visible = True
            Else
                Call Koneksi()
                Dim InputData As String = "Insert into makanan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                CMd = New OdbcCommand(InputData, Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Input Data Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Call KondisiAwal()



            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Guna2Button1.Visible = True
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False

            Call FieldAktifEdit()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                'MsgBox("Pastikan Mengisi Data ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button1.Visible = True
            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("update makanan set nama_makanan='" & TextBox2.Text &
                                           "',harga_makanan='" & TextBox3.Text &
                                           "' where id_makanan ='" & TextBox1.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Edit Data Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Call KondisiAwal()
            End If
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        CMd = New OdbcCommand("select * from makanan where id_makanan ='" & TextBox1.Text.ToUpper & "' ", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            TextBox2.Text = Rd(1)
            TextBox3.Text = Rd(2)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Guna2Button1.Visible = True
        If Button3.Text = "DELETE" Then
            Button3.Text = "HAPUS"
            Button1.Enabled = False
            Button2.Enabled = False

            Call FieldAktif()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                'MsgBox("Pastikan Data Yang Akan Di Hapus Terisi ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button1.Visible = True

            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("delete from makanan where id_makanan ='" & TextBox1.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Delete Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Guna2Button1.Visible = True
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call KondisiAwal()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2HtmlLabel5.Text = Format(Now, "dd-MM-yyyy")
        Guna2HtmlLabel1.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Call Koneksi()
        CMd = New OdbcCommand("Select * from makanan where id_makanan Like'%" & Guna2TextBox1.Text & "%' OR nama_makanan Like'%" & Guna2TextBox1.Text & "%'OR harga_makanan Like'%" & Guna2TextBox1.Text & "%'", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New OdbcDataAdapter("Select * from makanan where id_makanan Like'%" & Guna2TextBox1.Text & "%' OR nama_makanan Like'%" & Guna2TextBox1.Text & "%'OR harga_makanan Like'%" & Guna2TextBox1.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            dgv1.DataSource = Ds.Tables("KetemuData")
            dgv1.ReadOnly = True
        ElseIf Guna2TextBox1.Text Is Nothing Then

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If (index >= 0) Then
            selectedRow = dgv1.Rows(index)
            TextBox1.Text = selectedRow.Cells(0).Value.ToString()
            TextBox2.Text = selectedRow.Cells(1).Value.ToString()
            TextBox3.Text = selectedRow.Cells(2).Value.ToString()
        End If

        ' DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub RadioMakanan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMakanan.CheckedChanged
        If RadioMakanan.Checked Then
            Guna2ShadowPanel2.Visible = False
            Guna2ShadowPanel1.Visible = True
        End If
    End Sub

    Private Sub RadioMinuman_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMinuman.CheckedChanged
        If RadioMinuman.Checked Then
            Guna2ShadowPanel1.Visible = False
            Guna2ShadowPanel2.Visible = True
        End If
    End Sub
    'Minuman
    Sub KondisiAwalMinuman()
        Guna2TextBox3.Text = ""
        Guna2TextBox4.Text = ""
        Guna2TextBox5.Text = ""
        Guna2TextBox3.Enabled = False
        Guna2TextBox4.Enabled = False
        Guna2TextBox5.Enabled = False
        Guna2Button7.Text = "INPUT"
        EditButton.Text = "EDIT"
        DeleteButton.Text = "DELETE"
        Guna2TextBox3.MaxLength = 6
        Guna2Button7.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Guna2Button4.Visible = False
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from minuman", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "minuman")
        DataGridView2.DataSource = Ds.Tables("minuman")
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 150
    End Sub
    Sub FieldAktifEditMinuman()
        Guna2TextBox3.Enabled = False
        Guna2TextBox4.Enabled = True
        Guna2TextBox5.Enabled = True
        Guna2Button4.Visible = True
        Guna2TextBox3.Focus()

    End Sub
    Sub FieldAktifMinuman()
        Guna2TextBox3.Enabled = True
        Guna2TextBox4.Enabled = True
        Guna2TextBox5.Enabled = True
        Guna2Button4.Visible = True
        Guna2TextBox3.Focus()

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Guna2Button4.Visible = False
        If Guna2Button7.Text = "INPUT" Then
            Guna2Button7.Text = "SIMPAN"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            Call FieldAktifMinuman()

        Else
            If Guna2TextBox3.Text = "" Or Guna2TextBox5.Text = "" Or Guna2TextBox4.Text = "" Then
                'MsgBox("Pastikan Mengisi Data ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button4.Visible = True
            Else
                Call Koneksi()
                Dim InputDatas As String = "Insert into minuman values ('" & Guna2TextBox3.Text & "','" & Guna2TextBox5.Text & "','" & Guna2TextBox4.Text & "')"
                CMd = New OdbcCommand(InputDatas, Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Input Data Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Call KondisiAwalMinuman()
            End If
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Guna2Button4.Visible = True
        If EditButton.Text = "EDIT" Then
            EditButton.Text = "SIMPAN"
            DeleteButton.Enabled = False
            Guna2Button7.Enabled = False

            Call FieldAktifEditMinuman()

        Else
            If Guna2TextBox3.Text = "" Or Guna2TextBox5.Text = "" Or Guna2TextBox4.Text = "" Then
                'MsgBox("Pastikan Mengisi Data ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button4.Visible = True
            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("update minuman set nama_minuman='" & Guna2TextBox5.Text &
                                           "',harga_minuman='" & Guna2TextBox4.Text &
                                           "' where id_minuman ='" & Guna2TextBox3.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Edit Data Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Call KondisiAwalMinuman()
            End If
        End If
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        CMd = New OdbcCommand("select * from minuman where id_minuman ='" & Guna2TextBox3.Text.ToUpper & "' ", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            Guna2TextBox5.Text = Rd(1)
            Guna2TextBox4.Text = Rd(2)
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Guna2Button4.Visible = True
        If DeleteButton.Text = "DELETE" Then
            DeleteButton.Text = "HAPUS"
            EditButton.Enabled = False
            Guna2Button7.Enabled = False

            Call FieldAktifMinuman()

        Else
            If Guna2TextBox3.Text = "" Or Guna2TextBox5.Text = "" Or Guna2TextBox4.Text = "" Then
                'MsgBox("Pastikan Data Yang Akan Di Hapus Terisi ")
                Call FormErrorTransaksi.ShowDialog()
                Guna2Button4.Visible = True

            Else
                Call Koneksi()
                'Dim EditData As String = "Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'"

                'CMd = New OdbcCommand("Update makanan set nama_makanan='" & TextBox2.Text & "',harga_makanan='" & TextBox3.Text & "',where id_makanan='" & TextBox1.Text & "'", Conn)
                CMd = New OdbcCommand("delete from minuman where id_minuman ='" & Guna2TextBox3.Text & "'", Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Delete Berhasil")
                Call FormSuccesTransaksi.ShowDialog()
                Guna2Button4.Visible = True
                Call KondisiAwalMinuman()
            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Call Koneksi()
        CMd = New OdbcCommand("Select * from minuman where id_minuman Like'%" & Guna2TextBox2.Text & "%' OR nama_minuman Like'%" & Guna2TextBox2.Text & "%'OR harga_minuman Like'%" & Guna2TextBox2.Text & "%'", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New OdbcDataAdapter("Select * from minuman where id_minuman Like'%" & Guna2TextBox2.Text & "%' OR nama_minuman Like'%" & Guna2TextBox2.Text & "%'OR harga_minuman Like'%" & Guna2TextBox2.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "KetemuData")
            DataGridView2.DataSource = Ds.Tables("KetemuData")
            DataGridView2.ReadOnly = True
        ElseIf Guna2TextBox1.Text Is Nothing Then

        End If
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim indexs As Integer
        indexs = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If (indexs >= 0) Then
            selectedRow = DataGridView2.Rows(indexs)
            Guna2TextBox3.Text = selectedRow.Cells(0).Value.ToString()
            Guna2TextBox5.Text = selectedRow.Cells(1).Value.ToString()
            Guna2TextBox4.Text = selectedRow.Cells(2).Value.ToString()
        End If

        ' DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Call KondisiAwalMinuman()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class