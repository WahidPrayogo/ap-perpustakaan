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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Petugas))
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
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 16)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(441, 223)
        Me.DGV.TabIndex = 79
        '
        'CmdTutup
        '
        Me.CmdTutup.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._022
        Me.CmdTutup.Location = New System.Drawing.Point(233, 266)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(50, 44)
        Me.CmdTutup.TabIndex = 78
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._198
        Me.CmdBatal.Location = New System.Drawing.Point(177, 266)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(50, 44)
        Me.CmdBatal.TabIndex = 77
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._041
        Me.CmdHapus.Location = New System.Drawing.Point(121, 266)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(50, 44)
        Me.CmdHapus.TabIndex = 76
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._075
        Me.CmdSimpan.Location = New System.Drawing.Point(65, 266)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(50, 44)
        Me.CmdSimpan.TabIndex = 75
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(81, 90)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(193, 22)
        Me.TPassword.TabIndex = 73
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(81, 62)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(193, 22)
        Me.TNama.TabIndex = 72
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(81, 34)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(100, 22)
        Me.TKode.TabIndex = 71
        '
        'CBOStatus
        '
        Me.CBOStatus.FormattingEnabled = True
        Me.CBOStatus.Location = New System.Drawing.Point(81, 118)
        Me.CBOStatus.Name = "CBOStatus"
        Me.CBOStatus.Size = New System.Drawing.Size(193, 24)
        Me.CBOStatus.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Kode"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 53)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "DATA PETUGAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.TPassword)
        Me.GroupBox1.Controls.Add(Me.TNama)
        Me.GroupBox1.Controls.Add(Me.TKode)
        Me.GroupBox1.Controls.Add(Me.CBOStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 163)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 242)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 76)
        Me.Panel1.TabIndex = 87
        '
        'Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 339)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Petugas Perpustakaan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
