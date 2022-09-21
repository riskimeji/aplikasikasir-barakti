Imports System.Data.Odbc
Public Class Form1
    Sub Product()
        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from makanan", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                nama.Text = Dt.Rows(1)("nama_makanan").ToString()
                harga.Text = Dt.Rows(1)("harga_makanan").ToString()
                nama2.Text = Dt.Rows(1)("nama_makanan").ToString()
                harga2.Text = Dt.Rows(1)("harga_makanan").ToString()
            End If
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Product()

    End Sub
    Sub KondisiAwal()
        CheckBox1.Text = "TESTT"
        CheckBox2.Text = "TEST"
        CheckBox1.Enabled = True
        CheckBox2.Enabled = False
        CheckBox2.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Text = "TESTT" Then
            CheckBox2.Enabled = False
            Call KondisiAwal()

        End If
    End Sub
End Class