Imports System.Data.OleDb

Public Class FrmKriteria
    'Prosedur untuk menampilkan isi Tabel tblkriteria ke Objek DataGridView
    Sub TampilGrid()
        DA = New OleDbDataAdapter("Select * from tblkriteria order by nilaikriteria DESC", koneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblkriteria")
        DGV.DataSource = (DS.Tables("tblkriteria"))
        DGV.ReadOnly = True
    End Sub

    'Prosedur untuk mengunci seluruh objek TextBox
    Sub KunciText()
        txtKodeKriteria.ReadOnly = True
        txtNamaKriteria.ReadOnly = True
        txtNilaiKriteria.ReadOnly = True
    End Sub

    'Prosedur untuk membuka penguncian seluruh objek TextBox
    Sub BukaKunciText()
        txtKodeKriteria.ReadOnly = False
        txtNamaKriteria.ReadOnly = False
        txtNilaiKriteria.ReadOnly = False
    End Sub

    'Prosedur untuk membersihkan seluruh objek TextBox
    Sub BersihText()
        txtKodeKriteria.Clear()
        txtNamaKriteria.Clear()
        txtNilaiKriteria.Clear()
    End Sub

    Private Sub FrmKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BukaKoneksi()
        Call TampilGrid()
        Call KunciText()

        'Setting awal DGV
        DGV.Columns(0).HeaderText = "Kode Kriteria"
        DGV.Columns(1).HeaderText = "Nama Kriteria"
        DGV.Columns(2).HeaderText = "Nilai Kriteria (%)"

        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 235
        DGV.Columns(2).Width = 110
    End Sub

    'Jika DGV diklik maka akan muncul di Txtbox
    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            txtKodeKriteria.Text = DGV.Item(0, DGV.CurrentRow.Index).Value
            txtNamaKriteria.Text = DGV.Item(1, DGV.CurrentRow.Index).Value
            txtNilaiKriteria.Text = DGV.Item(2, DGV.CurrentRow.Index).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Prosedur menambah data
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If user = "Operator" Then
            MsgBox("Anda Tidak Memiliki Izin Untuk Melakukan Operasi Ini", MsgBoxStyle.Critical)
            BtnAdd.Enabled = False
        Else

            If BtnAdd.Text = "Add" Then
                BtnAdd.Text = "Save"
                Call BersihText()
                Call BukaKunciText()
                txtKodeKriteria.Focus()
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
            Else
                Try
                    CMD = New OleDbCommand("Insert Into tblkriteria Values('" & _
                               txtKodeKriteria.Text & "','" & txtNamaKriteria.Text & "','" & _
                               txtNilaiKriteria.Text & "')", koneksi)
                    CMD.CommandType = CommandType.Text
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil ditambahkan.")
                    Call TampilGrid()
                    Call BersihText()
                    BtnAdd.Text = "Add"
                    Call KunciText()
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.Message())
                End Try
            End If
        End If
    End Sub

    'Prosedur edit data
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If user = "Operator" Then
            MsgBox("Anda Tidak Memiliki Izin Untuk Melakukan Operasi Ini", MsgBoxStyle.Critical)
            BtnEdit.Enabled = False
        Else
            If txtKodeKriteria.Text = "" Then
                MsgBox("Tidak ada data yang akan diedit." & Chr(13) & Chr(10) & _
                       "Silahkan pilih terlebih dahulu data yang akan diedit.", _
                      MsgBoxStyle.Information, "Info")
            Else
                If BtnEdit.Text = "Edit" Then
                    BtnEdit.Text = "Update"
                    Call BukaKunciText()
                    txtKodeKriteria.Focus()
                    BtnAdd.Enabled = False
                    BtnDelete.Enabled = False
                Else
                    Try
                        CMD = New OleDbCommand("Update tblkriteria Set kodekriteria='" & txtKodeKriteria.Text & _
                                        "',namakriteria='" & txtNamaKriteria.Text & _
                                        "',nilaikriteria='" & txtNilaiKriteria.Text & _
                                        "' Where kodekriteria='" & txtKodeKriteria.Text & "'", koneksi)
                        CMD.CommandType = CommandType.Text
                        CMD.ExecuteNonQuery()
                        MsgBox("Data berhasil diperbarui.")
                        Call TampilGrid()
                        Call KunciText()
                        BtnEdit.Text = "Edit"
                        BtnAdd.Enabled = True
                        BtnDelete.Enabled = True
                    Catch ex As Exception
                        MsgBox(ex.Message())
                    End Try
                End If
            End If
        End If
    End Sub

    'Prosedur hapus data
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If user = "Operator" Then
            MsgBox("Anda Tidak Memiliki Izin Untuk Melakukan Operasi Ini", MsgBoxStyle.Critical)
            BtnDelete.Enabled = False
        Else
            Dim pil As String
            pil = MsgBox("Anda yakin ingin menghapus data record ini?", _
                         MsgBoxStyle.YesNo, "Konfirmasi")
            If pil = vbYes Then
                Try
                    CMD = New OleDbCommand("Delete * From tblkriteria Where kodekriteria='" & _
                                           txtKodeKriteria.Text & "'", koneksi)
                    CMD.CommandType = CommandType.Text
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil dihapus.")
                    Call TampilGrid()
                    Call BersihText()
                Catch ex As Exception
                    MsgBox(ex.Message())
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    'Mengembalikan ke default
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call KunciText()
        Call BersihText()
        Call TampilGrid()
        BtnAdd.Text = "Add"
        BtnEdit.Text = "Edit"
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub

    'Tutup form
    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class