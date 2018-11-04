Imports System.Data.OleDb
Imports System.IO

Public Class FrmDataMahasiswa
    Private path As String = ""

    'Prosedur untuk menampilkan data dari table tblmahasiswa berdasarkan nirm
    Sub TampilData()
        Try
            CMD = New OleDbCommand("select * from tblmahasiswa order by nirm ASC", koneksi)
            DR = CMD.ExecuteReader
            Dim x As Integer = 0
            LV.Items.Clear()
            While DR.Read
                LV.Items.Add(DR("nirm"))
                LV.Items(x).SubItems.Add(DR("nama"))
                LV.Items(x).SubItems.Add(DR("kelas"))
                LV.Items(x).SubItems.Add(DR("jurusan"))
                x = x + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    'Sub untuk mengatur warna isi textbox pada saat ReadOnly bernilai True
    Sub AturTextBox()
        txtNirm.BackColor = Color.White
        txtNama.BackColor = Color.White
        txtKelas.BackColor = Color.White
        txtJurusan.BackColor = Color.White
    End Sub

    'Sub untuk mengatur textbox hanya bisa dibaca (tidak dapat diedit)
    Sub KunciText()
        txtNirm.ReadOnly = True
        txtNama.ReadOnly = True
        txtKelas.ReadOnly = True
        txtJurusan.ReadOnly = True
    End Sub

    'Sub untuk mengatur textbox agar dapat diedit (diketik)
    Sub BukaText()
        txtNirm.ReadOnly = False
        txtNama.ReadOnly = False
        txtKelas.ReadOnly = False
    End Sub

    'Sub untuk mengosongkan textbox
    Sub BersihText()
        txtNirm.Text = ""
        txtNama.Text = ""
        txtKelas.Text = ""
        txtJurusan.Text = ""
    End Sub

    'Sub untuk menonaktifkan button
    Sub NonAktifButton()
        BtnTambah.Enabled = False
        BtnPerbaiki.Enabled = False
        BtnHapus.Enabled = False
        BtnCari.Enabled = False
        BtnTampilData.Text = "Batal"
    End Sub

    'Sub untuk mengaktifkan button
    Sub AktifButton()
        BtnTambah.Enabled = True
        BtnPerbaiki.Enabled = True
        BtnHapus.Enabled = True
        BtnCari.Enabled = True
        BtnTampilData.Text = "Tampil Data"
    End Sub

    'Set NIRM berdasarkan jurusan (prodi)
    Sub nirm()
        Select Case Microsoft.VisualBasic.Mid(txtNirm.Text, 5, 2)
            Case "01"
                txtJurusan.Text = "Manajemen Informatika"
            Case "02"
                txtJurusan.Text = "Sistem Informasi"
            Case "03"
                txtJurusan.Text = "Sistem Komputer"
            Case "04"
                txtJurusan.Text = "Teknik Komputer"
        End Select
    End Sub
    
    Private Sub FrmDataMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BukaKoneksi()
        Call TampilData()
        Call AturTextBox()
        Call KunciText()
        txtJurusan.ReadOnly = True
    End Sub

    'Prosedur menambah data baru
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            BtnTambah.Text = "Simpan"
            Call BersihText()
            txtNirm.Focus()
            Call BukaText()
            Call NonAktifButton()
            BtnTambah.Enabled = True
        Else
            If txtNirm.Text = "" Then
                ErrorProvider1.SetError(txtNirm, "NIRM Harus Dimasukkan!")
                txtNirm.Focus()
            Else
                ErrorProvider1.Clear()
                Try
                    Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read)
                    Dim gambar(fs.Length) As Byte
                    Dim simpan As String = "insert into tblmahasiswa(nirm,nama,kelas,jurusan,foto)" & _
                    "values('" & txtNirm.Text & "','" & txtNama.Text & "','" & txtKelas.Text & _
                    "','" & txtJurusan.Text & "',@photo)"

                    fs.Read(gambar, 0, CInt(fs.Length))
                    fs.Close()
                    CMD = New OleDbCommand(simpan, koneksi)
                    CMD.Parameters.AddWithValue("@photo", gambar)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil Disimpan.", MsgBoxStyle.Information, "Sukses")
                    Call TampilData()
                Catch ex As Exception
                    MsgBox("Terjadi kesalahan saat menambahkan data.", MsgBoxStyle.Critical, "Salah")
                End Try
                BtnTambah.Text = "Tambah"
                Call BersihText()
                Call KunciText()
                Call AktifButton()
            End If
        End If
    End Sub

    'Prosedur mengedit data
    Private Sub BtnPerbaiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPerbaiki.Click
        If BtnPerbaiki.Text = "Perbaiki" Then
            BtnPerbaiki.Text = "Simpan"
            txtNirm.Focus()
            Call BukaText()
            Call NonAktifButton()
            BtnPerbaiki.Enabled = True
        Else
            If txtNirm.Text = "" Then
                ErrorProvider1.SetError(txtNirm, "NIRM Tidak Boleh Kosong!")
                txtNirm.Focus()
            Else
                ErrorProvider1.Clear()
                Try
                    Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read)
                    Dim gambar(fs.Length) As Byte
                    Dim update As String = ("update tblmahasiswa set nirm='" & txtNirm.Text & _
                                                   "',nama='" & txtNama.Text & _
                                                   "',kelas='" & txtKelas.Text & _
                                                   "',jurusan='" & txtJurusan.Text & _
                                                   "',foto=@photo where nirm='" & txtNirm.Text & _
                                                   "' or nama='" & txtNama.Text & "'")
                    fs.Read(gambar, 0, CInt(fs.Length))
                    fs.Close()
                    CMD = New OleDbCommand(update, koneksi)
                    CMD.Parameters.AddWithValue("@photo", gambar)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil Diperbaiki.", MsgBoxStyle.Information, "Perhatian")
                    Call TampilData()
                Catch ex As Exception
                    MsgBox("Terjadi kesalahan saat memperbaiki data.", MsgBoxStyle.Critical, "Salah")
                End Try
                BtnPerbaiki.Text = "Perbaiki"
                Call BersihText()
                Call KunciText()
                Call AktifButton()
            End If
        End If
    End Sub

    'Prosedur menghapus data
    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim pesan As String
        pesan = MsgBox("Apakah Anda yakin untuk menghapus data " & txtNirm.Text & "?", _
                MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
        If pesan = vbYes Then
            Try
                Dim hapus As String = ("delete from tblmahasiswa where nirm='" & txtNirm.Text & "'")
                CMD = New OleDbCommand(hapus, koneksi)
                CMD.ExecuteNonQuery()
                MsgBox("Data Sudah Berhasil Dihapus.", MsgBoxStyle.Information)
                Call TampilData()
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan Saat Menghapus Data.", MsgBoxStyle.Critical, "Kesalahan")
            End Try
            Call BersihText()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        MsgBox("Fitur belum tersedia.", MsgBoxStyle.Information)
    End Sub

    'Prosedur menampilkan data
    Private Sub BtnTampilData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilData.Click
        If BtnTampilData.Text = "Tampil Data" Then
            Call BersihText()
            Call TampilData()
            Call KunciText()
        Else
            Call BersihText()
            Call TampilData()
            Call KunciText()
            AktifButton()
            BtnTambah.Text = "Tambah"
            BtnPerbaiki.Text = "Perbaiki"
            BtnCari.Text = "Cari"
            BtnTampilData.Text = "Tampil Data"
        End If
    End Sub

    'Prosedur input gambar
    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Try
            With OpenFileDialog1
                .Title = "Browse Gambar"
                .FileName = "Pilih Gambar"
                .Filter = "Type(*.jpg,*.png,*.bmp,*.gif,*.jpeg)|*.jpg;*.png;*.bmp;*.gif;*.jpeg"
                .ShowDialog()
                path = .FileName
                PictureBox1.Image = Image.FromFile(path)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.Click
        txtNirm.Text = LV.SelectedItems(0).Text.ToString
        txtNama.Text = LV.SelectedItems(0).SubItems(1).Text.ToString
        txtKelas.Text = LV.SelectedItems(0).SubItems(2).Text.ToString
        txtJurusan.Text = LV.SelectedItems(0).SubItems(3).Text.ToString

        Try
            Dim carifoto As String = ("select foto from tblmahasiswa where nirm='" & txtNirm.Text & "'")
            CMD = New OleDbCommand(carifoto, koneksi)
            Dim gambar As Object = CMD.ExecuteScalar
            If gambar IsNot DBNull.Value Then
                Dim bytearray As Byte() = CType(gambar, Byte())
                Dim iostream As New IO.MemoryStream(bytearray.Length)

                iostream.Write(bytearray, 0, bytearray.Length - 1)
                PictureBox1.Image = Image.FromStream(iostream)
                iostream.Close()
                iostream.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub txtNirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNirm.TextChanged
        nirm()
    End Sub
End Class