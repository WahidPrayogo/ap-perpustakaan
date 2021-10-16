Imports System.Data.oledb

Public Class LaporanPengembalian

    Sub TampilTanggalKbl()
        Call Koneksi()
        cmd = New oledbCommand("select distinct TanggalKbl from Kembali", Conn)
        DR = cmd.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
            ComboBox2.Items.Add(Format(DR.Item(0), "yyyy, MM, dd"))
            ComboBox3.Items.Add(Format(DR.Item(0), "yyyy, MM, dd"))
        Loop

        CMD = New OleDbCommand("select distinct month(TanggalKbl) as bulan from Kembali", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox4.Items.Add(DR.Item(0))
        Loop

        CMD = New OleDbCommand("select distinct year(TanggalKbl) as tahun from Kembali", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox5.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "totext({Kembali.TanggalKbl})='" & ComboBox1.Text & "'"
        cryRpt.Load("lap kembali harian.rpt")
        Call Module_Konfigurasi_laporan()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "{Kembali.TanggalKbl} in date (" & ComboBox2.Text & ") to date (" & ComboBox3.Text & ")"
        cryRpt.Load("lap kembali mingguan.rpt")
        Call Module_Konfigurasi_laporan()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.SelectionFormula = "Month({Kembali.TanggalKbl})=" & Val(ComboBox4.Text) & " and Year({Kembali.TanggalKbl})=" & Val(ComboBox5.Text)
        cryRpt.Load("lap kembali bulanan.rpt")
        Call Module_Konfigurasi_laporan()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub LaporanPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilTanggalKbl()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class