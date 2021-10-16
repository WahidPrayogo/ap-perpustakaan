<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TStok = New System.Windows.Forms.TextBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.CmdTutup = New System.Windows.Forms.Button
        Me.CmdBatal = New System.Windows.Forms.Button
        Me.CmdHapus = New System.Windows.Forms.Button
        Me.CmdSimpan = New System.Windows.Forms.Button
        Me.TTahun = New System.Windows.Forms.TextBox
        Me.TPengarang = New System.Windows.Forms.TextBox
        Me.TJudul = New System.Windows.Forms.TextBox
        Me.TPenerbit = New System.Windows.Forms.TextBox
        Me.TNomor = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TStok
        '
        Me.TStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStok.Location = New System.Drawing.Point(77, 177)
        Me.TStok.Name = "TStok"
        Me.TStok.Size = New System.Drawing.Size(146, 20)
        Me.TStok.TabIndex = 68
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 16)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(518, 320)
        Me.DGV.TabIndex = 67
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(108, 369)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(75, 23)
        Me.CmdTutup.TabIndex = 66
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(27, 369)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.CmdBatal.TabIndex = 65
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(108, 340)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.CmdHapus.TabIndex = 64
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(27, 340)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimpan.TabIndex = 63
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'TTahun
        '
        Me.TTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTahun.Location = New System.Drawing.Point(77, 151)
        Me.TTahun.Name = "TTahun"
        Me.TTahun.Size = New System.Drawing.Size(146, 20)
        Me.TTahun.TabIndex = 62
        '
        'TPengarang
        '
        Me.TPengarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPengarang.Location = New System.Drawing.Point(77, 99)
        Me.TPengarang.Name = "TPengarang"
        Me.TPengarang.Size = New System.Drawing.Size(146, 20)
        Me.TPengarang.TabIndex = 61
        '
        'TJudul
        '
        Me.TJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TJudul.Location = New System.Drawing.Point(77, 73)
        Me.TJudul.Name = "TJudul"
        Me.TJudul.Size = New System.Drawing.Size(146, 20)
        Me.TJudul.TabIndex = 60
        '
        'TPenerbit
        '
        Me.TPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPenerbit.Location = New System.Drawing.Point(77, 125)
        Me.TPenerbit.Name = "TPenerbit"
        Me.TPenerbit.Size = New System.Drawing.Size(146, 20)
        Me.TPenerbit.TabIndex = 59
        '
        'TNomor
        '
        Me.TNomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomor.Location = New System.Drawing.Point(77, 47)
        Me.TNomor.Name = "TNomor"
        Me.TNomor.Size = New System.Drawing.Size(146, 20)
        Me.TNomor.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Jumlah Stok"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Pengarang"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Judul"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Penerbit"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nomor Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(231, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "DATA BUKU PERPUSTAKAAN"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TStok)
        Me.GroupBox1.Controls.Add(Me.TNomor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TTahun)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TPengarang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TJudul)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TPenerbit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 206)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 339)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        '
        'Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Name = "Buku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TStok As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents TTahun As System.Windows.Forms.TextBox
    Friend WithEvents TPengarang As System.Windows.Forms.TextBox
    Friend WithEvents TJudul As System.Windows.Forms.TextBox
    Friend WithEvents TPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents TNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
