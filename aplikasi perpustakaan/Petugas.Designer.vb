<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Petugas
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
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.CmdTutup = New System.Windows.Forms.Button
        Me.CmdBatal = New System.Windows.Forms.Button
        Me.CmdHapus = New System.Windows.Forms.Button
        Me.CmdSimpan = New System.Windows.Forms.Button
        Me.TPassword = New System.Windows.Forms.TextBox
        Me.TNama = New System.Windows.Forms.TextBox
        Me.TKode = New System.Windows.Forms.TextBox
        Me.CBOStatus = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 16)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(369, 207)
        Me.DGV.TabIndex = 79
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(274, 254)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(80, 23)
        Me.CmdTutup.TabIndex = 78
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(188, 254)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(80, 23)
        Me.CmdBatal.TabIndex = 77
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(102, 254)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(80, 23)
        Me.CmdHapus.TabIndex = 76
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(16, 254)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(80, 23)
        Me.CmdSimpan.TabIndex = 75
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(87, 102)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(193, 22)
        Me.TPassword.TabIndex = 73
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(87, 74)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(193, 22)
        Me.TNama.TabIndex = 72
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(87, 46)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(100, 22)
        Me.TKode.TabIndex = 71
        '
        'CBOStatus
        '
        Me.CBOStatus.FormattingEnabled = True
        Me.CBOStatus.Location = New System.Drawing.Point(87, 130)
        Me.CBOStatus.Name = "CBOStatus"
        Me.CBOStatus.Size = New System.Drawing.Size(193, 24)
        Me.CBOStatus.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Kode"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 22)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "DATA PETUGAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TPassword)
        Me.GroupBox1.Controls.Add(Me.TNama)
        Me.GroupBox1.Controls.Add(Me.TKode)
        Me.GroupBox1.Controls.Add(Me.CBOStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 163)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 226)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Name = "Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TKode As System.Windows.Forms.TextBox
    Friend WithEvents CBOStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
