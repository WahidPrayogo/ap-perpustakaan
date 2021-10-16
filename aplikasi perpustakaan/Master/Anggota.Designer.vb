<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anggota))
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BTNTutup = New System.Windows.Forms.Button
        Me.BTNBatal = New System.Windows.Forms.Button
        Me.BTNHapus = New System.Windows.Forms.Button
        Me.BTNSimpan = New System.Windows.Forms.Button
        Me.TTelepon = New System.Windows.Forms.TextBox
        Me.TAlamat = New System.Windows.Forms.TextBox
        Me.TNama = New System.Windows.Forms.TextBox
        Me.TNomor = New System.Windows.Forms.TextBox
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
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(498, 265)
        Me.DGV.TabIndex = 38
        '
        'BTNTutup
        '
        Me.BTNTutup.BackgroundImage = Global.aplikasi_perpustakaan.My.Resources.Resources._022
        Me.BTNTutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNTutup.Location = New System.Drawing.Point(218, 308)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(50, 44)
        Me.BTNTutup.TabIndex = 37
        Me.BTNTutup.UseVisualStyleBackColor = True
        '
        'BTNBatal
        '
        Me.BTNBatal.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._198
        Me.BTNBatal.Location = New System.Drawing.Point(162, 308)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(50, 44)
        Me.BTNBatal.TabIndex = 36
        Me.BTNBatal.UseVisualStyleBackColor = True
        '
        'BTNHapus
        '
        Me.BTNHapus.BackgroundImage = Global.aplikasi_perpustakaan.My.Resources.Resources._041
        Me.BTNHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNHapus.Location = New System.Drawing.Point(106, 308)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(50, 44)
        Me.BTNHapus.TabIndex = 35
        Me.BTNHapus.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackgroundImage = Global.aplikasi_perpustakaan.My.Resources.Resources._075
        Me.BTNSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNSimpan.Location = New System.Drawing.Point(50, 308)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(50, 44)
        Me.BTNSimpan.TabIndex = 34
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'TTelepon
        '
        Me.TTelepon.Location = New System.Drawing.Point(115, 148)
        Me.TTelepon.Name = "TTelepon"
        Me.TTelepon.Size = New System.Drawing.Size(207, 22)
        Me.TTelepon.TabIndex = 33
        '
        'TAlamat
        '
        Me.TAlamat.Location = New System.Drawing.Point(115, 76)
        Me.TAlamat.Multiline = True
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Size = New System.Drawing.Size(207, 66)
        Me.TAlamat.TabIndex = 32
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(115, 50)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(207, 22)
        Me.TNama.TabIndex = 31
        '
        'TNomor
        '
        Me.TNomor.Location = New System.Drawing.Point(115, 24)
        Me.TNomor.Name = "TNomor"
        Me.TNomor.Size = New System.Drawing.Size(100, 22)
        Me.TNomor.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Anggota"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nomor Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(616, 53)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "DATA ANGGOTA PERPUSTAKAAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.TTelepon)
        Me.GroupBox1.Controls.Add(Me.TAlamat)
        Me.GroupBox1.Controls.Add(Me.TNama)
        Me.GroupBox1.Controls.Add(Me.TNomor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 191)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 284)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 87)
        Me.Panel1.TabIndex = 42
        '
        'Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Anggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Anggota Perpustakaan"
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
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNHapus As System.Windows.Forms.Button
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents TTelepon As System.Windows.Forms.TextBox
    Friend WithEvents TAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
