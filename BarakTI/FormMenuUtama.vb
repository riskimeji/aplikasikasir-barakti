Imports System.Data.Odbc

Public Class FormMenuUtama
    Dim currentForm As System.Windows.Forms.Form
    Dim totalkaryawan As Integer
    Sub Terkunci()
        'PictureBox16.Visible = False
        Panel3.Visible = False
        Panel2.Visible = True
        'Button3.Visible = False

        'Panel3.Visible = False

    End Sub
    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2Button4.FillColor = Color.Brown
        Timer1.Enabled = True
        'Call Terkunci()
        'Call Koneksi()
        'Dim nama As String
        'nama = "Select * from users where nama ='Ahmad Rizki Akbar'"
        'CMd = New OdbcCommand(nama, Conn)
        'Rd = CMd.ExecuteReader
        'Rd.Read()
        'If Rd.HasRows = True Then
        '    Guna2HtmlLabel2.Text = Rd(1)
        'End If
        Guna2HtmlLabel2.Text = Users.Username
        Guna2HtmlLabel3.Text = Users.Level
        Call totalUsers()
        Call totalTransaksi()
        Call drevenue()
        Call totalMenu()
        Call TodayTrx()
        Call totalmingguan()
        Call weekTrx()
        Call totalbulanan()
        Call topmenu()
        Panel1.Visible = False
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLogin.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Terkunci()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddTransaksi.ShowDialog()

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RiwayatTransaksi.ShowDialog()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuMakanan.ShowDialog()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuMinuman.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SetActiveForm(New TransaksiMinuman(), sender)
    End Sub

    Private Sub SetActiveForm(ByVal form As System.Windows.Forms.Form, ByVal btnSender As System.Object)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        Panel2.BackColor = Color.Maroon
        currentForm = form
        form.TopLevel = False
        form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Panel3.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Call SetActiveForm(New AddTransaksi(), sender)
        Guna2Button1.FillColor = Color.Brown
        Guna2Button2.FillColor = Color.Maroon
        Guna2Button4.FillColor = Color.Maroon
        Guna2Button5.FillColor = Color.Maroon

    End Sub

    Friend Shared Function Guna2Button() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Call SetActiveForm(New MenuMakanan(), sender)
        Guna2Button2.FillColor = Color.Brown
        Guna2Button1.FillColor = Color.Maroon
        Guna2Button4.FillColor = Color.Maroon
        Guna2Button5.FillColor = Color.Maroon
        'Call btnActive()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button5.Click
        Call SetActiveForm(New RiwayatTransaksi(), sender)
        Guna2Button5.FillColor = Color.Brown
        Guna2Button2.FillColor = Color.Maroon
        Guna2Button1.FillColor = Color.Maroon
        Guna2Button4.FillColor = Color.Maroon
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SetActiveForm(New MenuMakanan(), sender)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Call FormExit.ShowDialog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Guna2Button2.FillColor = Color.Maroon
        Guna2Button1.FillColor = Color.Maroon
        Guna2Button4.FillColor = Color.Brown
        Guna2Button5.FillColor = Color.Maroon
        Call SetActiveForm(New FormMenuUtama(), sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2HtmlLabel5.Text = Format(Now, "dd-MM-yyyy")
        Guna2HtmlLabel6.Text = Format(Now, "hh:mm:ss")
    End Sub
    Sub totalUsers()

        Da = New OdbcDataAdapter("Select * from users", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        totalkaryawan = Dt.Rows.Count
        Label2.Text = totalkaryawan
    End Sub
    Sub totalTransaksi()
        Dim totaltransaksi As Integer
        Da = New OdbcDataAdapter("Select * from transaksi", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        totaltransaksi = Dt.Rows.Count
        Label6.Text = totaltransaksi
    End Sub
    'Sub totalPendapatan()
    '    Dim totalpendapatan As Integer
    '    Da = New OdbcDataAdapter("Select sum(total_harga) from transaksi", Conn)
    '    Dt = New DataTable
    '    Da.Fill(Dt)
    '    totalpendapatan = Dt.Rows.Count
    '    Label3.Text = totalpendapatan
    '    Console.WriteLine(totalpendapatan)
    'End Sub

    Sub drevenue()
        CMd = New OdbcCommand("select ifnull(sum(total_harga),0) from transaksi", Conn)
        Dim revtotal As Double = CMd.ExecuteScalar()
        Label3.Text = revtotal.ToString("C")
    End Sub
    'trasanski hari ini
    Sub TodayTrx()
        ''Dim tanggal As Date = Format(Now, "yyyy-MM-dd")
        'tanggal = Guna2HtmlLabel11.Text
        ''Dim strDate As Date = tanggal.ToString("yyyy-MM-dd")


        CMd = New OdbcCommand("select count(*) from transaksi where tanggal = curdate()", Conn)
        Dim totaltrx As Integer = CMd.ExecuteScalar()
        Console.WriteLine(totaltrx)
        Label9.Text = totaltrx

        'Dim tanggals As String = Format(Now, "yyyy-MM-dd")
        'Console.WriteLine(tanggals)
        'Da = New OdbcDataAdapter("SELECT COUNT(*) from transaksi where tanggal =" & tanggals & "", Conn)
        'Dt = New DataTable
        'Da.Fill(Dt)

        'tanggals = Dt.Rows.Count
        'Console.WriteLine(tanggals)
        'Label9.Text = tanggals
    End Sub
    Sub totalMenu()

        CMd = New OdbcCommand("SELECT total_makanan + total_minuman total_menu FROM 
(SELECT COUNT(*) total_makanan FROM makanan) makan,
(SELECT COUNT(*) total_minuman FROM minuman) minum", Conn)
        Dim totalmenu As Integer = CMd.ExecuteScalar()
        Label8.Text = totalmenu.ToString
    End Sub
    Sub totalmingguan()
        CMd = New OdbcCommand("select ifnull(sum(total_harga),0) from transaksi where tanggal = curdate()", Conn)
        Rd = CMd.ExecuteReader
        Dim revtotals As Integer
        If Rd.Read Then
            revtotals = Rd.GetValue(0)
            Label10.Text = revtotals.ToString("C")
        End If

    End Sub
    Sub weekTrx()
        ''Dim tanggal As Date = Format(Now, "yyyy-MM-dd")
        'tanggal = Guna2HtmlLabel11.Text
        ''Dim strDate As Date = tanggal.ToString("yyyy-MM-dd")


        CMd = New OdbcCommand("select count(*) from transaksi where week(tanggal) = week(now())", Conn)
        Dim weekstrx As Integer = CMd.ExecuteScalar()
        Console.WriteLine(weekstrx)
        Label11.Text = weekstrx

        'Dim tanggals As String = Format(Now, "yyyy-MM-dd")
        'Console.WriteLine(tanggals)
        'Da = New OdbcDataAdapter("SELECT COUNT(*) from transaksi where tanggal =" & tanggals & "", Conn)
        'Dt = New DataTable
        'Da.Fill(Dt)

        'tanggals = Dt.Rows.Count
        'Console.WriteLine(tanggals)
        'Label9.Text = tanggals
    End Sub
    Sub totalbulanan()
        CMd = New OdbcCommand("select ifnull(sum(total_harga),0) from transaksi where year(tanggal) = year(now()) and month(tanggal) = month(now())", Conn)
        Rd = CMd.ExecuteReader
        Dim revtotalss As Integer
        If Rd.Read Then
            revtotalss = Rd.GetValue(0)
            Label12.Text = revtotalss.ToString("C")
        End If

    End Sub
    Sub topmenu()
        CMd = New OdbcCommand("select nama_menu, count(*) total from transaksi where year(tanggal) = year(now()) and month(tanggal) = month(now()) group by nama_menu order by total desc limit 10", Conn)
        Rd = CMd.ExecuteReader
        Dim topsmenu As String = ""
        Dim i As Integer = 1
        While (Rd.Read)
            topsmenu += i & ". " & Rd.GetValue(0) & "<br/>"
            i += 1
        End While
        Guna2HtmlLabel15.Text = topsmenu
    End Sub

End Class
