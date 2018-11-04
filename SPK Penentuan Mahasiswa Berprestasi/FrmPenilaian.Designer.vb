<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenilaian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnProses = New System.Windows.Forms.Button
        Me.uIP = New System.Windows.Forms.TextBox
        Me.txtJumlah = New System.Windows.Forms.TextBox
        Me.uPenghasilan = New System.Windows.Forms.TextBox
        Me.uTanggungan = New System.Windows.Forms.TextBox
        Me.uStatus = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnBersih = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.kTanggungan = New System.Windows.Forms.TextBox
        Me.kStatus = New System.Windows.Forms.ComboBox
        Me.kPenghasilan = New System.Windows.Forms.TextBox
        Me.kIP = New System.Windows.Forms.TextBox
        Me.txtNamaMahasiswa = New System.Windows.Forms.TextBox
        Me.cboNirm = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnHapus = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(667, 154)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 45
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'uIP
        '
        Me.uIP.Location = New System.Drawing.Point(6, 37)
        Me.uIP.Name = "uIP"
        Me.uIP.ReadOnly = True
        Me.uIP.Size = New System.Drawing.Size(50, 21)
        Me.uIP.TabIndex = 10
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(328, 336)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.ReadOnly = True
        Me.txtJumlah.Size = New System.Drawing.Size(50, 22)
        Me.txtJumlah.TabIndex = 36
        '
        'uPenghasilan
        '
        Me.uPenghasilan.Location = New System.Drawing.Point(6, 64)
        Me.uPenghasilan.Name = "uPenghasilan"
        Me.uPenghasilan.ReadOnly = True
        Me.uPenghasilan.Size = New System.Drawing.Size(50, 21)
        Me.uPenghasilan.TabIndex = 11
        '
        'uTanggungan
        '
        Me.uTanggungan.Location = New System.Drawing.Point(6, 118)
        Me.uTanggungan.Name = "uTanggungan"
        Me.uTanggungan.ReadOnly = True
        Me.uTanggungan.Size = New System.Drawing.Size(50, 21)
        Me.uTanggungan.TabIndex = 13
        '
        'uStatus
        '
        Me.uStatus.Location = New System.Drawing.Point(6, 91)
        Me.uStatus.Name = "uStatus"
        Me.uStatus.ReadOnly = True
        Me.uStatus.Size = New System.Drawing.Size(50, 21)
        Me.uStatus.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Jumlah"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(748, 154)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 44
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(829, 154)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 43
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBersih
        '
        Me.btnBersih.Location = New System.Drawing.Point(586, 155)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(75, 23)
        Me.btnBersih.TabIndex = 42
        Me.btnBersih.Text = "Bersih"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(505, 154)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 41
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uTanggungan)
        Me.GroupBox2.Controls.Add(Me.uStatus)
        Me.GroupBox2.Controls.Add(Me.uPenghasilan)
        Me.GroupBox2.Controls.Add(Me.uIP)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(322, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(62, 146)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nilai Utility"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Tanggungan Orangtua (C4)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Status Keuangan (C3)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Penghasilan Orangtua (C2)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "IP (C1)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kTanggungan)
        Me.GroupBox1.Controls.Add(Me.kStatus)
        Me.GroupBox1.Controls.Add(Me.kPenghasilan)
        Me.GroupBox1.Controls.Add(Me.kIP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(196, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 146)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nilai Kriteria"
        '
        'kTanggungan
        '
        Me.kTanggungan.Location = New System.Drawing.Point(6, 118)
        Me.kTanggungan.Name = "kTanggungan"
        Me.kTanggungan.Size = New System.Drawing.Size(108, 21)
        Me.kTanggungan.TabIndex = 15
        '
        'kStatus
        '
        Me.kStatus.FormattingEnabled = True
        Me.kStatus.Items.AddRange(New Object() {"Mampu", "Tidak Mampu"})
        Me.kStatus.Location = New System.Drawing.Point(6, 86)
        Me.kStatus.Name = "kStatus"
        Me.kStatus.Size = New System.Drawing.Size(110, 23)
        Me.kStatus.TabIndex = 14
        '
        'kPenghasilan
        '
        Me.kPenghasilan.Location = New System.Drawing.Point(6, 59)
        Me.kPenghasilan.Name = "kPenghasilan"
        Me.kPenghasilan.Size = New System.Drawing.Size(108, 21)
        Me.kPenghasilan.TabIndex = 11
        '
        'kIP
        '
        Me.kIP.Location = New System.Drawing.Point(6, 32)
        Me.kIP.Name = "kIP"
        Me.kIP.Size = New System.Drawing.Size(108, 21)
        Me.kIP.TabIndex = 10
        '
        'txtNamaMahasiswa
        '
        Me.txtNamaMahasiswa.Location = New System.Drawing.Point(411, 118)
        Me.txtNamaMahasiswa.Name = "txtNamaMahasiswa"
        Me.txtNamaMahasiswa.ReadOnly = True
        Me.txtNamaMahasiswa.Size = New System.Drawing.Size(181, 22)
        Me.txtNamaMahasiswa.TabIndex = 28
        '
        'cboNirm
        '
        Me.cboNirm.FormattingEnabled = True
        Me.cboNirm.Location = New System.Drawing.Point(411, 87)
        Me.cboNirm.Name = "cboNirm"
        Me.cboNirm.Size = New System.Drawing.Size(130, 24)
        Me.cboNirm.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nama Mahasiswa :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "NIRM :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "FORM PENILAIAN DAN HASIL"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(424, 155)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 46
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(390, 184)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(567, 258)
        Me.DGV.TabIndex = 39
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmPenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 494)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBersih)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNamaMahasiswa)
        Me.Controls.Add(Me.cboNirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPenilaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPenilaian"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents uIP As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents uPenghasilan As System.Windows.Forms.TextBox
    Friend WithEvents uTanggungan As System.Windows.Forms.TextBox
    Friend WithEvents uStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBersih As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kPenghasilan As System.Windows.Forms.TextBox
    Friend WithEvents kIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMahasiswa As System.Windows.Forms.TextBox
    Friend WithEvents cboNirm As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents kTanggungan As System.Windows.Forms.TextBox
End Class
