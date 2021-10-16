Public Class MenuUtama

    Private Sub AnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnggotaToolStripMenuItem.Click
        Anggota.Show()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukuToolStripMenuItem.Click
        Buku.Show()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetugasToolStripMenuItem.Click
        Petugas.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Peminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianToolStripMenuItem.Click
        Pengembalian.Show()
    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMasterToolStripMenuItem.Click
        Laporan.Show()
    End Sub

    Private Sub DataPeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPeminjamanToolStripMenuItem.Click
        LaporanPeminjaman.Show()
    End Sub

    Private Sub DataPengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPengembalianToolStripMenuItem.Click
        LaporanPengembalian.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin anda ingin menutup aplikasi ini..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub MenuUtama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            If MessageBox.Show("Yakin anda ingin menutup aplikasi ini..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                End
            End If
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Anggota.ShowDialog()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Buku.ShowDialog()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Petugas.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Peminjaman.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pengembalian.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        LaporanMaster.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        LaporanPeminjaman.Show()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        LaporanPengembalian.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Yakin anda ingin menutup aplikasi ini..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Peminjaman.Show()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Pengembalian.Show()
    End Sub
End Class