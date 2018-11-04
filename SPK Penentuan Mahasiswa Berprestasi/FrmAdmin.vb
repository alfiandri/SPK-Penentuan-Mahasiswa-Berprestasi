Imports System.Data.OleDb

Public Class FrmAdmin

    'Prosedur untuk menampilkan isi Tabel ke Objek DataGridView
    Sub TampilGrid()
        DA = New OleDbDataAdapter("Select username,password,hak_akses from tbluser order by nama", koneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbluser")
        DGV.DataSource = (DS.Tables("tbluser"))
        DGV.ReadOnly = True
    End Sub

    'Prosedur untuk mengunci seluruh objek TextBox
    Sub KunciText()
        TxtID.ReadOnly = True
        TxtNama.ReadOnly = True
    End Sub

    'Prosedur untuk membuka penguncian seluruh objek TextBox
    Sub BukaKunciText()
        TxtID.ReadOnly = False
        TxtNama.ReadOnly = False
    End Sub

    'Prosedur untuk membersihkan seluruh objek TextBox
    Sub BersihText()
        TxtID.Clear()
        TxtNama.Clear()
        cboLevel.Text = ""
    End Sub

    Private Sub FrmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BukaKoneksi()
        Call TampilGrid()
        Call KunciText()

        'Mengatur header DGV
        DGV.Columns(0).HeaderText = "Username"
        DGV.Columns(1).HeaderText = "Nama"
        DGV.Columns(2).HeaderText = "Level"
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            TxtID.Text = DGV.Item(0, DGV.CurrentRow.Index).Value
            TxtNama.Text = DGV.Item(1, DGV.CurrentRow.Index).Value
            cboLevel.Text = DGV.Item(2, DGV.CurrentRow.Index).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Prosedur menambahkan user baru
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If BtnAdd.Text = "Add" Then
            BtnAdd.Text = "Save"
            Call BersihText()
            Call BukaKunciText()
            TxtID.Focus()
            BtnEdit.Enabled = False
            BtnDelete.Enabled = False
        Else
            Try
                CMD = New OleDbCommand("Insert Into tbluser Values('" & _
                           TxtID.Text & "','" & TxtID.Text & "','" & _
                           TxtNama.Text & "','" & cboLevel.Text & "')", koneksi)
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
    End Sub

    'Prosedur mengedit user
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If TxtID.Text = "" Then
            MsgBox("Tidak ada data yang akan diedit." & Chr(13) & Chr(10) & _
                   "Silahkan pilih terlebih dahulu data yang akan diedit.", _
                  MsgBoxStyle.Information, "Info")
        Else
            If BtnEdit.Text = "Edit" Then
                BtnEdit.Text = "Update"
                Call BukaKunciText()
                TxtID.Focus()
                BtnAdd.Enabled = False
                BtnDelete.Enabled = False
            Else
                Try
                    CMD = New OleDbCommand("Update tbluser Set username='" & TxtID.Text & _
                                    "',nama='" & TxtNama.Text & _
                                    "',hak_akses='" & cboLevel.Text & _
                                    "' Where username='" & TxtID.Text & "'", koneksi)
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
    End Sub

    'Prosedur menghapus user
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim pil As String
        pil = MsgBox("Anda yakin ingin menghapus data record ini?", _
                     MsgBoxStyle.YesNo, "Konfirmasi")
        If pil = vbYes Then
            Try
                CMD = New OleDbCommand("Delete * From tbluser Where username='" & _
                                       TxtID.Text & "'", koneksi)
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
    End Sub

    'Mengembalikan ke pengaturan awal DGV
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

    'Menutup form
    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class