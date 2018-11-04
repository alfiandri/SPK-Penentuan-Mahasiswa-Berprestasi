Imports System.Data.OleDb

Module Module1
    Public koneksi As OleDbConnection
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public perintah As String
    Public user As String
    Public laporan As String
    Dim alamat As String

    'Prosedur untuk melakukan koneksi terhadap database access
    Public Sub BukaKoneksi()
        alamat = "Provider=microsoft.Jet.oledb.4.0;Data Source=db_penentuanbeasiswa.mdb"
        koneksi = New OleDbConnection(alamat)
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub
End Module
