Imports System.Data.Odbc
Module database
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public CMd As OdbcCommand
    Public Dt As DataTable


    Public MyDB As String
    Public Sub Koneksi()
        'Try
        '    Conn = New OdbcConnection("DSN=MyDB;")
        '    If Conn.State = ConnectionState.Closed Then

        '        Conn.Open()
        '        MessageBox.Show("Koneksi Sukses")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Koneksi gagal", ex.Message)

        'End Try
        MyDB = "Driver={Mysql odbc 3.51 driver};database=db_barak;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub
End Module
