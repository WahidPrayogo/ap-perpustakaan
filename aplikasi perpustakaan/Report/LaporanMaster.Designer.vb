<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 75)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._022
        Me.Button1.Location = New System.Drawing.Point(166, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tutup"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._136
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button15.Location = New System.Drawing.Point(83, 16)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(63, 56)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Buku"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.Image = Global.aplikasi_perpustakaan.My.Resources.Resources._055
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button16.Location = New System.Drawing.Point(3, 16)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(63, 56)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "Anggota"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button16.UseVisualStyleBackColor = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.DisplayGroupTree = False
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 75)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(356, 170)
        Me.CRV.TabIndex = 85
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'LaporanMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 245)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
