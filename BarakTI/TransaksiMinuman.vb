Imports System.Data.Odbc

Public Class TransaksiMinuman

    Private Sub KirimBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KirimBox.Click
        If MenuBox.Text = "" Or JumlahBox.Text = "" Or TotalHargaBox.Text = "" Then
            Call FormErrorTransaksi.ShowDialog()
        Else
            Call Koneksi()
            Dim InputData As String = "Insert into transaksi values ('" & "','" & MenuBox.Text & "','" & JumlahBox.Text & "','" & TotalHargaBox.Text & "')"
            CMd = New OdbcCommand(InputData, Conn)
            CMd.ExecuteNonQuery()
            Call FormSuccesTransaksi.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub AddTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub
    Sub tampil()
        Koneksi()
        CMd = New OdbcCommand("select nama_minuman from minuman", Conn)
        Da = New OdbcDataAdapter(CMd)
        Dt = New DataTable
        Da.Fill(Dt)

        MenuBox.DataSource = Dt
        MenuBox.DisplayMember = "nama_minuman"
        MenuBox.ValueMember = "nama_minuman"
        MenuBox.AutoCompleteSource = AutoCompleteSource.ListItems
        MenuBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub


    Private Sub MenuBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBox.SelectedIndexChanged
        Call Koneksi()
        Dim harga As String
        harga = "Select * from minuman where nama_minuman =  '" & MenuBox.Text & "'"
        CMd = New OdbcCommand(harga, Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            HargaBox.Text = Rd(2)
        End If
    End Sub
    Sub cekHarga()
        TotalHargaBox.Text = Val(JumlahBox.Text) * Val(HargaBox.Text)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If JumlahBox.Text = "" Then
            MsgBox("Pastikan Mengisi Jumlah")
        Else
            Call cekHarga()
        End If

    End Sub

    Private Sub JumlahBox_TextChanged(sender As Object, e As EventArgs) Handles JumlahBox.TextChanged
        Call cekHarga()
    End Sub
End Class