Imports System.Data.Odbc

Public Class AddTransaksi
    Dim tanggal As DateTime = DateTime.Now
    Dim strDate As String = tanggal.ToString("yyyy-MM-dd")
    Dim HargaMakanan As Integer
    Dim JumlahMakanan As Integer
    Dim HargaMinuman As Integer
    Dim JumlahMinuman As Integer
    Private Sub KirimBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KirimBox.Click
        If MenuBox.Text = "" Or HargaBox.Text = "" Or JumlahBox.Text = "" Then
            Call FormErrorTransaksi.ShowDialog()
        Else
            Call Koneksi()
            Dim InputData As String = "Insert into transaksi values ('" & "','" & MenuBox.Text & "','" & strDate & "','" & JumlahMakanan & "','" & HargaMakanan * JumlahMakanan & "')"
            CMd = New OdbcCommand(InputData, Conn)
            CMd.ExecuteNonQuery()
            Call FormSuccesTransaksi.ShowDialog()
        End If
    End Sub


    Private Sub AddTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        Call Tampil2()
        Timer1.Enabled = True
        'DataGridView1.Columns(4).DefaultCellStyle.Format = "c"

    End Sub
    Sub tampil()
        Koneksi()
        CMd = New OdbcCommand("select nama_makanan from makanan", Conn)
        Da = New OdbcDataAdapter(CMd)
        Dt = New DataTable
        Da.Fill(Dt)

        MenuBox.DataSource = Dt
        MenuBox.DisplayMember = "nama_makanan"
        MenuBox.ValueMember = "nama_makanan"
        MenuBox.AutoCompleteSource = AutoCompleteSource.ListItems
        MenuBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Sub cekHarga()

        TotalHargaBox.Text = String.Format("{0:C}", JumlahMakanan * HargaMakanan)
        Console.WriteLine(String.Format("{0:C}", JumlahMakanan * HargaMakanan))

    End Sub

    Private Sub CekHargaBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If JumlahBox.Text = "" Then
            MsgBox("Pastikan Mengisi Jumlah")
        Else
            Call cekHarga()
        End If

    End Sub


    Private Sub JumlahBox_TextChanged(sender As Object, e As EventArgs) Handles JumlahBox.TextChanged
        Call cekHarga()
    End Sub

    Private Sub MenuBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MenuBox.SelectedIndexChanged
        Call Koneksi()
        Dim hargas As String
        hargas = "Select * from makanan where nama_makanan =  '" & MenuBox.Text & "'"
        CMd = New OdbcCommand(hargas, Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            Console.WriteLine(String.Format("{0:C}", Integer.Parse(Rd(2))))
            HargaBox.Text = String.Format("{0:C}", Integer.Parse(Rd(2)))
            HargaMakanan = Rd(2)

        End If
    End Sub
    'Checked Box


    'Transaksi Minuman
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2ComboBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox1.Text = "" Then
            Call FormErrorTransaksi.ShowDialog()

        Else
            Call Koneksi()
            Dim InputData As String = "Insert into transaksi values ('" & "','" & Guna2ComboBox1.Text & "','" & strDate & "','" & JumlahMinuman & "','" & JumlahMinuman * HargaMinuman & "')"
            CMd = New OdbcCommand(InputData, Conn)
            CMd.ExecuteNonQuery()
            Call FormSuccesTransaksi.ShowDialog()
        End If
    End Sub
    Sub Tampil2()
        Koneksi()
        CMd = New OdbcCommand("select nama_minuman from minuman", Conn)
        Da = New OdbcDataAdapter(CMd)
        Dt = New DataTable
        Da.Fill(Dt)

        Guna2ComboBox1.DataSource = Dt
        Guna2ComboBox1.DisplayMember = "nama_minuman"
        Guna2ComboBox1.ValueMember = "nama_minuman"
        Guna2ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        Guna2ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Dim harga As String
        harga = "Select * from minuman where nama_minuman =  '" & Guna2ComboBox1.Text & "'"
        CMd = New OdbcCommand(harga, Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            Guna2TextBox3.Text = String.Format("{0:C}", Rd(2))
            Console.WriteLine(String.Format("{0:C}", Integer.Parse(Rd(2))))
            'HargaBox.Text = String.Format("{0:C}", Integer.Parse(Rd(2)))
            HargaMinuman = Rd(2)
        End If
    End Sub
    Sub cekHarga2()
        'Guna2TextBox1.Text = Val(Guna2TextBox2.Text) * Val(Guna2TextBox3.Text)
        Guna2TextBox1.Text = String.Format("{0:C}", JumlahMinuman * HargaMinuman)
        Console.WriteLine(String.Format("{0:C}", JumlahMinuman * HargaMinuman))



    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Call cekHarga2()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2HtmlLabel13.Text = Format(Now, "dd-MM-yyyy")
        Guna2HtmlLabel12.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Guna2TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox2.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub JumlahBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JumlahBox.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub JumlahBox_KeyUp(sender As Object, e As KeyEventArgs) Handles JumlahBox.KeyUp
        If JumlahBox.Text = "" Then
            JumlahMakanan = 0
        Else
            JumlahMakanan = Integer.Parse(JumlahBox.Text)
        End If
        Call cekHarga()
    End Sub

    Private Sub Guna2TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyUp
        If Guna2TextBox2.Text = "" Then
            JumlahMinuman = 0
        Else
            JumlahMinuman = Integer.Parse(Guna2TextBox2.Text)
        End If
        Call cekHarga2()
    End Sub

End Class