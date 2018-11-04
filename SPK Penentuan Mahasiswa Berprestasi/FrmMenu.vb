Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class FrmMenu
    Private Sub tsKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Apakah Anda Ingin Menutup Program Ini?", MsgBoxStyle.YesNo + 32, "Konfirmasi")
        If pesan = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub FrmMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pesan As String
        pesan = MsgBox("Apakah Anda Ingin Menutup Program Ini?", MsgBoxStyle.YesNo + 32, "Konfirmasi")
        If pesan = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsAnalisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAnalisa.Click
        Dim anak As New FrmPenilaian
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub tsDataAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDataAdmin.Click
        Dim anak As New FrmAdmin
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If user = "Operator" Then
            tsDataAdmin.Visible = False
        End If
    End Sub

    Private Sub tsDataMahasiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDataMahasiswa.Click
        Dim anak As New FrmDataMahasiswa
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub tsKriteria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsKriteria.Click
        Dim anak As New FrmKriteria
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem.Click
        Dim anak As New FrmAboutMe
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub tsLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLaporan.Click
        FrmFilterLaporan.Show()
    End Sub
End Class
