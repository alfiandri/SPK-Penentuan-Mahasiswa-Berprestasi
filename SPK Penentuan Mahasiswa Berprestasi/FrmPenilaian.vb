Imports System.Data.OleDb
Imports System.ComponentModel

Public Class FrmPenilaian
    Dim namefield As String

    'Menampilkan nirm dari tabel tblmahasiswa
    Sub kondisiAwal()
        CMD = New OleDbCommand("select nirm from tblmahasiswa", koneksi)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cboNirm.Items.Add(DR.Item("nirm"))
        Loop
    End Sub

    'Menampilkan nama dari tabel tblmahasiswa berdasarkan inputan nirm
    Sub tampilTxtbox()
        CMD = New OleDbCommand("select nama from tblmahasiswa where nirm='" & _
                             cboNirm.Text & "'", koneksi)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtNamaMahasiswa.Text = DR.Item("nama")
        End If
    End Sub

    'Menyimpan nilai di textbox ke dalam DGV
    Sub simpanDataGrid()
        DGV.RowCount = DGV.RowCount + 1
        DGV(0, DGV.RowCount - 2).Value = cboNirm.Text
        DGV(1, DGV.RowCount - 2).Value = txtNamaMahasiswa.Text
        DGV(2, DGV.RowCount - 2).Value = uIP.Text
        DGV(3, DGV.RowCount - 2).Value = uPenghasilan.Text
        DGV(4, DGV.RowCount - 2).Value = uStatus.Text
        DGV(5, DGV.RowCount - 2).Value = uTanggungan.Text
        DGV(6, DGV.RowCount - 2).Value = txtJumlah.Text

        For barisatas As Integer = 0 To DGV.RowCount - 1
            For barisbawah = barisatas + 1 To DGV.RowCount - 1
                If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                    MsgBox("Anda tidak dapat menambahkan data yang sama.")
                    DGV.Rows(barisbawah).DefaultCellStyle.BackColor = Color.Red
                    DGV.Rows(barisbawah).Selected = True
                End If
            Next
        Next
    End Sub

    'Prosedur perhitungan metode SMART
    Sub nilaiAkhir()
        txtJumlah.Text = 0.4 * Val(uIP.Text) + 0.3 * Val(uPenghasilan.Text) + 0.2 * Val(uStatus.Text) + 0.1 * Val(uTanggungan.Text)
    End Sub

    Sub kelayakan()
        If txtJumlah.Text >= 75 Then
            DGV(7, DGV.RowCount - 2).Value = "Layak"
        Else
            DGV(7, DGV.RowCount - 2).Value = "Tidak Layak"
        End If
    End Sub

    'Mengatur header dan lebar DGV
    Sub aturGridView()
        With DGV
            .ColumnCount = 8
            .Columns(0).HeaderText = "NIRM"
            .Columns(1).HeaderText = "Nama Mahasiswa"
            .Columns(2).HeaderText = "C1"
            .Columns(3).HeaderText = "C2"
            .Columns(4).HeaderText = "C3"
            .Columns(5).HeaderText = "C4"
            .Columns(6).HeaderText = "Jumlah"
            .Columns(7).HeaderText = "Kelayakan"

            .Columns(0).Width = 80
            .Columns(1).Width = 140
            .Columns(2).Width = 35
            .Columns(3).Width = 35
            .Columns(4).Width = 35
            .Columns(5).Width = 35
            .Columns(6).Width = 60
            .Columns(7).Width = 100
        End With
    End Sub

    Private Sub FrmPenilaian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BukaKoneksi()
        Call kondisiAwal()
        Call aturGridView()
    End Sub

    Private Sub cboNirm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNirm.SelectedIndexChanged
        Call tampilTxtbox()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call simpanDataGrid()
        Call kelayakan()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If DGV.CurrentRow.Index <> DGV.NewRowIndex Then
            DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
        End If
    End Sub

    
    Private Sub kIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kIP.TextChanged
        If Val(kIP.Text) >= 3.5 Then
            uIP.Text = 100
        ElseIf Val(kIP.Text) >= 3.0 Then
            uIP.Text = 80
        ElseIf Val(kIP.Text) >= 2.75 Then
            uIP.Text = 60
        ElseIf Val(kIP.Text) >= 2.0 Then
            uIP.Text = 40
        Else
            uIP.Text = 0
        End If
    End Sub

    Private Sub kPenghasilan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kPenghasilan.TextChanged
        uPenghasilan.Clear()
        If Val(kPenghasilan.Text) >= 3500000 Then
            uPenghasilan.Text = 40
        ElseIf Val(kPenghasilan.Text) >= 2500000 Then
            uPenghasilan.Text = 60
        ElseIf Val(kPenghasilan.Text) >= 1500000 Then
            uPenghasilan.Text = 80
        ElseIf Val(kPenghasilan.Text) <= 1500000 Then
            uPenghasilan.Text = 100
        End If
    End Sub

    Private Sub kStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kStatus.SelectedIndexChanged
        If kStatus.Text = "Mampu" Then
            uStatus.Text = 50
        Else
            uStatus.Text = 100
        End If
    End Sub

    Private Sub kTanggungan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kTanggungan.TextChanged
        If Val(kTanggungan.Text) = 1 Then
            uTanggungan.Text = 40
        ElseIf Val(kTanggungan.Text) = 2 Then
            uTanggungan.Text = 60
        ElseIf Val(kTanggungan.Text) = 3 Then
            uTanggungan.Text = 80
        ElseIf Val(kTanggungan.Text) >= 4 Then
            uTanggungan.Text = 100
        Else
            uTanggungan.Text = 0
        End If
    End Sub

    Private Sub uTanggungan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uTanggungan.TextChanged
        nilaiAkhir()
    End Sub

    Private Sub btnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        cboNirm.Text = ""
        txtNamaMahasiswa.Clear()
        kIP.Clear()
        kPenghasilan.Clear()
        kStatus.Text = ""
        kTanggungan.Clear()
        uIP.Clear()
        uPenghasilan.Clear()
        uStatus.Clear()
        uTanggungan.Clear()
        txtJumlah.Clear()
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        DGV.Sort(DGV.Columns(6), ListSortDirection.Descending)
    End Sub

    Private Sub DGV_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        DGV.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DGV_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DGV.RowPrePaint
        'If DGV(6, DGV.RowCount - 2).Value IsNot Nothing Then
        'Me.DGV.Rows(e.RowIndex).Cells(7).Value = e.RowIndex + 1
        'End If
    End Sub

    'Prosedur menyimpan data di DGV ke dalam database
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            For baris As Integer = 0 To DGV.RowCount - 2
                CMD = New OleDbCommand("select * from tblpenilaian where nirm = '" & DGV.Rows(baris).Cells(0).Value & "'", koneksi)
                DR = CMD.ExecuteReader
                If Not DR.HasRows Then
                    CMD = New OleDbCommand("Insert Into tblpenilaian Values('" & _
                        DGV.Rows(baris).Cells(0).Value & "','" & _
                        DGV.Rows(baris).Cells(1).Value & "','" & _
                        DGV.Rows(baris).Cells(2).Value & "','" & _
                        DGV.Rows(baris).Cells(3).Value & "','" & _
                        DGV.Rows(baris).Cells(4).Value & "','" & _
                        DGV.Rows(baris).Cells(5).Value & "','" & _
                        DGV.Rows(baris).Cells(6).Value & "','" & _
                        DGV.Rows(baris).Cells(7).Value & "')", koneksi)
                    CMD.CommandType = CommandType.Text
                    CMD.ExecuteNonQuery()
                End If
            Next
            MsgBox("Data berhasil disimpan.")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menyimpan data.")
        End Try
        
    End Sub

    'Tutup form
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class