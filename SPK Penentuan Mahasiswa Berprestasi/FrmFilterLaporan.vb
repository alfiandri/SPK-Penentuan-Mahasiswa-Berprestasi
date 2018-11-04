Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class FrmFilterLaporan

    'Menampilkan laporan berdasarkan jurusan
    Private Sub btnJurusan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJurusan.Click
        If cboJurusan.Text = "" Then
            MsgBox("Masukkan Jurusan")
        Else
            FrmLaporan.CrystalReportViewer1.ReportSource = "D:\SPK Penentuan Mahasiswa Berprestasi\SPK Penentuan Mahasiswa Berprestasi\CrystalReport1.rpt"
            FrmLaporan.CrystalReportViewer1.SelectionFormula = "{tblmahasiswa.jurusan}= '" & cboJurusan.Text & "'"
            FrmLaporan.CrystalReportViewer1.Refresh()
            FrmLaporan.CrystalReportViewer1.RefreshReport()
            FrmLaporan.Show()
        End If
    End Sub

    'Menampilkan laporan berdasarkan kelayakan mahasiswa
    Private Sub btnKelayakan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKelayakan.Click
        If cboKelayakan.Text = "" Then
            MsgBox("Masukkan Nilai Kelayakan")
        Else
            FrmLaporan.CrystalReportViewer1.ReportSource = "D:\SPK Penentuan Mahasiswa Berprestasi\SPK Penentuan Mahasiswa Berprestasi\CrystalReport1.rpt"
            FrmLaporan.CrystalReportViewer1.SelectionFormula = "{tblpenilaian.kelayakan}= '" & cboKelayakan.Text & "'"
            FrmLaporan.CrystalReportViewer1.Refresh()
            FrmLaporan.CrystalReportViewer1.RefreshReport()
            FrmLaporan.Show()
        End If
    End Sub

    'Menampilkan semua laporan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmLaporan.CrystalReportViewer1.ReportSource = "D:\SPK Penentuan Mahasiswa Berprestasi\SPK Penentuan Mahasiswa Berprestasi\CrystalReport1.rpt"
        FrmLaporan.CrystalReportViewer1.Refresh()
        FrmLaporan.CrystalReportViewer1.RefreshReport()
        FrmLaporan.Show()
    End Sub
End Class