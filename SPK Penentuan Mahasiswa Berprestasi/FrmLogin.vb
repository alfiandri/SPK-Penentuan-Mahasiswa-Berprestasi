Imports System.Data.OleDb

Public Class FrmLogin
    Dim id, msg As String
    Dim i As Integer

    'Prosedur untuk menyeleksi data Username dan Password
    Sub Cari()
        CMD = New OleDbCommand("select username,passwoDR from tbluser " & _
                               "where username='" & Trim(TxtID.Text) & "'" & _
                               " and password='" & _
                               Trim(TxtPassword.Text) & "'", koneksi)
        DR = CMD.ExecuteReader
    End Sub

    Private Sub FrmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BukaKoneksi()
        i = 0
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        i = i + 1
        'Jika 3 kali gagal percobaan login maka form akan ditutup
        If i = 3 Then
            MsgBox("Anda telah 3 kali melakukan kesalahan. Program akan ditutup.", _
                       MsgBoxStyle.Critical, "Konfirmasi")
            End
        Else
            CMD = New OleDbCommand("SELECT * FROM tbluser WHERE username = '" & TxtID.Text & "'", koneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then 'jika username inputan terdapat dalam database
                If TxtPassword.Text = DR.Item("Password") Then 'jika password cocok dengan username
                    If DR.Item("hak_akses") = "Admin" Then 'jika jenis user admin maka di beri nilai var user = admin
                        user = "Admin"
                        MsgBox("Selamat Datang " & DR.Item("Nama"), MsgBoxStyle.MsgBoxSetForeground)
                        FrmMenu.Show()
                        Me.Hide()
                    ElseIf DR.Item("hak_akses") = "Operator" Then 'jika jenis user operator maka di beri nilai var user = operator
                        user = "Operator"
                        MsgBox("Selamat Datang " & DR.Item("Nama"), MsgBoxStyle.MsgBoxSetForeground)
                        FrmMenu.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Username dan Password Tidak Cocok", MsgBoxStyle.Critical) 'jika password tidak cocok dengan username
                    TxtID.Text = ""
                    TxtPassword.Text = ""
                    TxtID.Focus()
                End If
            Else
                MsgBox("Username Tidak Ada", MsgBoxStyle.Critical) 'jika username inputan tidak ada dalam database
                TxtID.Text = ""
                TxtPassword.Text = ""
                TxtID.Focus()
            End If
        End If

    End Sub

    Private Sub TxtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtID.Text = "" Then
                ErrorProvider1.SetError(TxtID, "ID Harus Dimasukkan!")
                TxtID.Focus()
            Else
                ErrorProvider1.Clear()
                TxtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPasswoDR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnOK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub
End Class