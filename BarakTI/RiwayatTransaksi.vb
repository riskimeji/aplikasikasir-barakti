Imports System.Data.Odbc

Public Class RiwayatTransaksi
    Dim maxRecord As Integer = 14
    Dim totalRecord As Integer
    Dim startIndex As Integer = 0
    Dim currentPage As Integer = 1
    Dim totalPage As Integer


    Private Sub RiwayatTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        ' Call KondisiAwal()
        Call testt()
        DataGridView1.Columns(4).DefaultCellStyle.Format = "c"
    End Sub

    'Sub KondisiAwal()
    '    Call Koneksi()
    '    'Conn.Open()


    '    Da = New OdbcDataAdapter("Select * from transaksi", Conn)
    '    Dt = New DataTable
    '    Da.Fill(Dt)
    '    totalRecord = Dt.Rows.Count
    '    totalPage = Math.Ceiling(totalRecord / maxRecord)
    '    startIndex = (currentPage * maxRecord) - maxRecord
    '    Console.WriteLine(totalRecord)
    '    Ds = New DataSet

    '    Da.Fill(Ds, startIndex, maxRecord, "transaksi")

    '    'Conn.Close()
    '    DataGridView1.DataSource = Ds.Tables("transaksi")
    '    DataGridView1.Columns(0).Width = 200
    '    DataGridView1.Columns(1).Width = 250
    '    DataGridView1.Columns(2).Width = 200
    'End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        currentPage += 1
        If currentPage > totalPage Then
            currentPage = totalPage
        End If
        startIndex = (currentPage * maxRecord) - maxRecord
        'scrollVal = scrollVal + 14
        'If (scrollVal >= 20) Then
        '    scrollVal = 10
        'End If
        Ds.Clear()
        Da.Fill(Ds, startIndex, maxRecord, "transaksi")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        currentPage -= 1
        If currentPage < 1 Then
            currentPage = 1
        End If

        startIndex = (currentPage * maxRecord) - maxRecord
        'scrollVal = scrollVal - 14
        'If (scrollVal < 0) Then
        '    scrollVal = 0
        'End If
        Ds.Clear()
        Da.Fill(Ds, startIndex, maxRecord, "transaksi")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2HtmlLabel5.Text = Format(Now, "dd-MM-yyyy")
        Guna2HtmlLabel6.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Call testt(Guna2TextBox1.Text)
        'Call Koneksi()
        'CMd = New OdbcCommand("Select * from transaksi where id_transaksi Like'%" & Guna2TextBox1.Text & "%' OR nama_menu Like'%" & Guna2TextBox1.Text & "%'OR jumlah Like'%" & Guna2TextBox1.Text & "%'", Conn)
        'Rd = CMd.ExecuteReader
        'Rd.Read()
        'If Rd.HasRows Then
        '    Call Koneksi()
        '    Da = New OdbcDataAdapter("Select * from transaksi where id_transaksi Like'%" & Guna2TextBox1.Text & "%' OR nama_menu Like'%" & Guna2TextBox1.Text & "%'OR jumlah Like'%" & Guna2TextBox1.Text & "%'", Conn)
        '    Ds = New DataSet
        '    Da.Fill(Ds, "KetemuData")
        '    DataGridView1.DataSource = Ds.Tables("KetemuData")
        '    DataGridView1.ReadOnly = True
        'ElseIf Guna2TextBox1.Text Is Nothing Then

        'End If

    End Sub
    Sub testt(Optional ByVal filter As String = "")

        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from transaksi where id_transaksi Like'%" & filter & "%' OR nama_menu Like'%" & filter & "%'OR jumlah Like'%" & filter & "%'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        totalRecord = Dt.Rows.Count
        totalPage = Math.Ceiling(totalRecord / maxRecord)
        startIndex = (currentPage * maxRecord) - maxRecord
        Console.WriteLine(totalRecord)
        Ds = New DataSet

        Da.Fill(Ds, startIndex, maxRecord, "transaksi")

        DataGridView1.DataSource = Ds.Tables("transaksi")
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 200
    End Sub

End Class