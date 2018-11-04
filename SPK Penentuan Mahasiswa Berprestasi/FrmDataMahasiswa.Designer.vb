<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMahasiswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataMahasiswa))
        Me.txtKelas = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label4 = New System.Windows.Forms.Label
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNirm = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.txtJurusan = New System.Windows.Forms.TextBox
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnBrowse = New System.Windows.Forms.Button
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnTampilData = New System.Windows.Forms.Button
        Me.BtnCari = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnPerbaiki = New System.Windows.Forms.Button
        Me.BtnTambah = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKelas
        '
        Me.txtKelas.Location = New System.Drawing.Point(175, 176)
        Me.txtKelas.Name = "txtKelas"
        Me.txtKelas.Size = New System.Drawing.Size(79, 22)
        Me.txtKelas.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Jurusan :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Kelas :"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kelas"
        Me.ColumnHeader3.Width = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "NIRM :"
        '
        'txtNirm
        '
        Me.txtNirm.Location = New System.Drawing.Point(175, 120)
        Me.txtNirm.Name = "txtNirm"
        Me.txtNirm.Size = New System.Drawing.Size(164, 22)
        Me.txtNirm.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Nama Mahasiswa :"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jurusan"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Mahasiswa"
        Me.ColumnHeader2.Width = 215
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(175, 148)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(164, 22)
        Me.txtNama.TabIndex = 65
        '
        'txtJurusan
        '
        Me.txtJurusan.Location = New System.Drawing.Point(175, 204)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(117, 22)
        Me.txtJurusan.TabIndex = 80
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(488, 610)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(100, 28)
        Me.BtnTutup.TabIndex = 76
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(472, 248)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 75
        Me.BtnBrowse.Text = "Browse..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIRM"
        Me.ColumnHeader1.Width = 110
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(433, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'BtnTampilData
        '
        Me.BtnTampilData.Image = CType(resources.GetObject("BtnTampilData.Image"), System.Drawing.Image)
        Me.BtnTampilData.Location = New System.Drawing.Point(493, 285)
        Me.BtnTampilData.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTampilData.Name = "BtnTampilData"
        Me.BtnTampilData.Size = New System.Drawing.Size(100, 76)
        Me.BtnTampilData.TabIndex = 72
        Me.BtnTampilData.Text = "Tampil Data"
        Me.BtnTampilData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnTampilData.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.Location = New System.Drawing.Point(371, 285)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 76)
        Me.BtnCari.TabIndex = 71
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.Location = New System.Drawing.Point(257, 285)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 76)
        Me.BtnHapus.TabIndex = 70
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnPerbaiki
        '
        Me.BtnPerbaiki.Image = CType(resources.GetObject("BtnPerbaiki.Image"), System.Drawing.Image)
        Me.BtnPerbaiki.Location = New System.Drawing.Point(151, 285)
        Me.BtnPerbaiki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPerbaiki.Name = "BtnPerbaiki"
        Me.BtnPerbaiki.Size = New System.Drawing.Size(75, 76)
        Me.BtnPerbaiki.TabIndex = 69
        Me.BtnPerbaiki.Text = "Perbaiki"
        Me.BtnPerbaiki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPerbaiki.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTambah.Location = New System.Drawing.Point(44, 285)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(80, 76)
        Me.BtnTambah.TabIndex = 68
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(44, 392)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(549, 194)
        Me.LV.TabIndex = 73
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 26)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "DATABASE MAHASISWA"
        '
        'FrmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 651)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKelas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTampilData)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnPerbaiki)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDataMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiswa"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKelas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNirm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtJurusan As System.Windows.Forms.TextBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnTampilData As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnPerbaiki As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
