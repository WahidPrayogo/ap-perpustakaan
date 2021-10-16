Public Class LaporanMaster

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        cryRpt.Load("lap anggota.rpt")
        Call Module_Konfigurasi_laporan()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        cryRpt.Load("lap buku.rpt")
        Call Module_Konfigurasi_laporan()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class