Imports System.Data.oledb

Public Class Pengembalian

    Sub TampilKodeAnggota()
        cmd = New oledbCommand("select distinct nomoragt from pinjam", Conn)
        DR = cmd.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub

    Sub TampilGrid1()
        DGV1.Columns.Add("Kode", "Nomor Buku")
        DGV1.Columns.Add("Nomor", "Nomor Pinjam")
        DGV1.Columns.Add("Judul", "Judul Buku")
        DGV1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DGV1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DGV1.Columns.Add("Lama", "Lama Pinjam")
        DGV1.Columns.Add("Denda", "Denda")
        Call AturKolomGrid1()
    End Sub

    Sub AturKolomGrid1()
        DGV1.Columns(0).Width = 50
        DGV1.Columns(1).Width = 75
        DGV1.Columns(2).Width = 150
        DGV1.Columns(3).Width = 50
        DGV1.Columns(4).Width = 75
        DGV1.Columns(5).Width = 50
        DGV1.Columns(6).Width = 75
    End Sub

    Sub TampilGrid2()
        DGV2.Columns.Add("Kode", "Kode")
        DGV2.Columns.Add("Judul", "Judul Buku")
        DGV2.Columns.Add("Jumlah", "Jumlah")
        Call AturKolomGrid2()
        DGV2.ReadOnly = True
    End Sub

    Sub AturKolomGrid2()
        DGV2.Columns(0).Width = 75
        DGV2.Columns(1).Width = 200
        DGV2.Columns(2).Width = 100
    End Sub

    Private Sub Otomatis()
        Call Koneksi()
        CMD = New oledbCommand("Select * from Kembali where Nomorkbl in (select max(Nomorkbl) from Kembali) order by Nomorkbl desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutan = Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Left(DR.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "01"
            Else
                hitung = DR.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LblNomorKbl.Text = urutan
    End Sub

    Sub TotalKEMBALI()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DGV1.Rows.Count - 1
            subtot += Val(DGV1.Rows(I).Cells(3).Value)
            LblTotalKbl.Text = subtot
        Next
    End Sub

    Sub TotalDENDA()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DGV1.Rows.Count - 1
            subtot += Val(DGV1.Rows(I).Cells(6).Value)
            LblDenda.Text = subtot
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        'Try
        If ComboBox1.Text = "" Or LblTotalKbl.Text = 0 Or LblDenda.Text = "" Or TxtDibayar.Text = "" Or LblKembali.Text = "" Then
            MsgBox("Tidak ada transaksi pengembalian Buku")
            Exit Sub
        End If

        'simpan ke tabel kembali
        Dim Simpan As String = "Insert Into kembali(Nomorkbl,Tanggalkbl,Totalkbl,Nomoragt,denda,dibayar,kembali,kodeptg) values('" & LblNomorKbl.Text & "','" & CDate(LblTanggalKbl.Text) & "','" & LblTotalKbl.Text & "','" & ComboBox1.Text & "','" & LblDenda.Text & "','" & TxtDibayar.Text & "','" & LblKembali.Text & "','" & MenuUtama.Panel1.Text & "')"
        cmd = New oledbCommand(Simpan, Conn)
        cmd.ExecuteNonQuery()

        'simpan data ke tabel Detail berulang-ulang sesuai banyaknya data
        For baris As Integer = 0 To DGV1.Rows.Count - 2
            'simpan ke tabel detail
            Dim oledbsimpan As String = "Insert Into DetailKbl(NomorKbl,NomorBK,JumlahBK) values ('" & LblNomorKbl.Text & "','" & DGV1.Rows(baris).Cells(0).Value & "','" & DGV1.Rows(baris).Cells(3).Value & "')"
            cmd = New oledbCommand(oledbsimpan, Conn)
            cmd.ExecuteNonQuery()

            'tambahstok Buku
            cmd = New oledbCommand("select * from Buku where NomorBK='" & DGV1.Rows(baris).Cells(0).Value & "'", Conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim TambahStok As String = "update Buku set Stok= '" & DR.Item(5) + DGV1.Rows(baris).Cells(3).Value & "' where NomorBK='" & DGV1.Rows(baris).Cells(0).Value & "'"
                cmd = New oledbCommand(TambahStok, Conn)
                cmd.ExecuteNonQuery()
            End If

            cmd = New oledbCommand("select JumlahBK from detailpjm where NomorBK='" & DGV1.Rows(baris).Cells(0).Value & "' and nomorpjm='" & DGV1.Rows(baris).Cells(1).Value & "'", Conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim updatedetailpinjam As String = "update detailpjm set JumlahBK='" & DR.Item(0) - DGV1.Rows(baris).Cells(3).Value & "' where NomorBK='" & DGV1.Rows(baris).Cells(0).Value & "' and nomorpjm='" & DGV1.Rows(baris).Cells(1).Value & "'"
                cmd = New oledbCommand(updatedetailpinjam, Conn)
                cmd.ExecuteNonQuery()
            End If

            cmd = New oledbCommand("select totalpjm from pinjam where nomorpjm='" & DGV1.Rows(baris).Cells(1).Value & "'", Conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim oledbeditpjm As String = "update pinjam set totalpjm= '" & DR.Item(0) - DGV1.Rows(baris).Cells(3).Value & "' where nomorpjm='" & DGV1.Rows(baris).Cells(1).Value & "'" ' and nomorBK='" & DGV1.Rows(baris).Cells(0).Value & "'"
                cmd = New oledbCommand(oledbeditpjm, Conn)
                cmd.ExecuteNonQuery()

            End If

        Next baris
        Call Otomatis()
        DGV1.Columns.Clear()
        DGV2.Columns.Clear()
        Call TampilGrid1()
        Call Otomatis()
        Call HapusMaster()
    End Sub

    Sub HapusMaster()
        LblTelahPjm.Text = ""
        LblTotalKbl.Text = ""
        LblNamaAgt.Text = ""
        ComboBox1.Text = ""
        LblDenda.Text = ""
        TxtDibayar.Text = ""
        LblKembali.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        DGV1.Columns.Clear()
        DGV2.Columns.Clear()
        Call HapusMaster()
        Call TampilGrid1()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
            DGV1.Focus()
        End If
    End Sub

    Sub CariData()
        cmd = New oledbCommand("Select * from anggota where nomoragt='" & ComboBox1.Text & "'", Conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            LblNamaAgt.Text = DR.Item("namaagt")
            cmd = New oledbCommand("Select SUM(TOTALPJM) AS KETEMU FROM PINJAM WHERE NOMORAGT='" & ComboBox1.Text & "'", Conn)
            DR = cmd.ExecuteReader
            DR.Read()
            LblTelahPjm.Text = DR.Item(0)
            If LblTelahPjm.Text = 0 Then
                MsgBox("" & LblNamaAgt.Text & " tidak punya pinjaman")
            End If
        Else
            MsgBox("Nomor anggota tidak teDRaftar")
            ComboBox1.Focus()
            Exit Sub
        End If
        Call Pinjaman()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.MaxLength = 4
        Call CariData()
    End Sub

    Sub Pinjaman()
        da = New oledbDataAdapter("Select Buku.NomorBK,Judul,JumlahBK From Anggota,Pinjam,Buku,Detailpjm Where Buku.NomorBK=Detailpjm.NomorBK And Pinjam.Nomorpjm=Detailpjm.Nomorpjm And Anggota.Nomoragt=Pinjam.Nomoragt And Anggota.Nomoragt='" & ComboBox1.Text & "' AND detailpjm.jumlahBK>0", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Detail")
        DGV2.DataSource = ds.Tables("Detail")
        LblTelahPjm.Text = DGV2.Rows.Count - 1
        Call AturKolomGrid2()
        DGV2.ReadOnly = True
    End Sub

    Private Sub DGV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim baris As Integer
        Dim kolom As Integer
        baris = DGV1.CurrentCell.RowIndex
        kolom = DGV1.CurrentCell.ColumnIndex
        If e.KeyChar = Chr(27) Then
            DGV1.Rows.RemoveAt(baris)
            Call TotalKEMBALI()
            Call TotalDENDA()
        End If
    End Sub

    Private Sub TxtDibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtDibayar.Text) < Val(LblDenda.Text) Then
                MsgBox("Pembayaran kurang")
                LblKembali.Text = ""
                TxtDibayar.Focus()
                Exit Sub
            ElseIf Val(TxtDibayar.Text) = Val(LblDenda.Text) Then
                LblKembali.Text = 0
                BTNSimpan.Focus()
            Else
                LblKembali.Text = Val(TxtDibayar.Text) - Val(LblDenda.Text)
                BTNSimpan.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Sub pembayaran()
        If Val(LblDenda.Text) = 0 Then
            TxtDibayar.Text = 0
            LblKembali.Text = 0
        Else
            TxtDibayar.Text = ""
            LblKembali.Text = ""
        End If
    End Sub

    Sub HapusBaris()
        Dim baris As Integer
        Dim kolom As Integer
        baris = DGV1.CurrentCell.RowIndex
        kolom = DGV1.CurrentCell.ColumnIndex

        DGV1.Rows.RemoveAt(baris)
        Call TotalKEMBALI()
        Call TotalDENDA()
    End Sub

    Private Sub DGV1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellEndEdit
        If e.ColumnIndex = 0 Then
            'cmd = New oledbCommand("select NomorBK from anggota,pinjam,detailpjm where NomorBK ='" & DGV1.Rows(e.RowIndex).Cells(0).Value & "' and pinjam.nomorpjm=detailpjm.nomorpjm and anggota.nomoragt=PINJAM.nomoragt and anggota.nomoragt='" & ComboBox1.Text & "' AND detailpjm.JUMLAHBK>0", Conn)
            'DR = cmd.ExecuteReader
            'DR.Read()
            'If Not DR.HasRows Then
            '    MsgBox(" " & LblNamaAgt.Text & " tidak meminjam kode Buku " & DGV1.Rows(e.RowIndex).Cells(0).Value & "")
            '    Call HapusBaris()
            '    Exit Sub
            'End If

            CMD = New OleDbCommand("Select distinct Buku.NomorBK,detailpjm.Nomorpjm,Judul,JumlahBK,tanggalpjm, (Date()-Tanggalpjm)+1 As Lmpinjam, IIF(LMPINJAM>5,(LMPINJAM-5)*500,0) AS DENDA From Anggota,Pinjam,Buku,Detailpjm Where Buku.NomorBK=Detailpjm.NomorBK And Pinjam.Nomorpjm=Detailpjm.Nomorpjm And Anggota.Nomoragt=Pinjam.Nomoragt And Anggota.Nomoragt='" & ComboBox1.Text & "' AND DETAILPJM.NomorBK='" & DGV1.Rows(e.RowIndex).Cells(0).Value & "' AND DETAILPJM.JUMLAHBK>0", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                DGV1.Rows(e.RowIndex).Cells(1).Value = DR.Item(1)
                DGV1.Rows(e.RowIndex).Cells(2).Value = DR.Item(2)
                DGV1.Rows(e.RowIndex).Cells(3).Value = DR.Item(3)
                DGV1.Rows(e.RowIndex).Cells(4).Value = DR.Item(4)
                DGV1.Rows(e.RowIndex).Cells(5).Value = DR.Item(5)
                DGV1.Rows(e.RowIndex).Cells(6).Value = DR.Item(6)
                DGV1.CurrentCell = DGV1.Rows(e.RowIndex).Cells(0)
                Call TotalKEMBALI()
                Call TotalDENDA()
                Call pembayaran()
            Else
                MsgBox(" " & LblNamaAgt.Text & "  tidak meminjam kode Buku " & DGV1.Rows(e.RowIndex).Cells(0).Value & "")
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Peminjaman.Show()
    End Sub

    Private Sub DGV1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV1.KeyPress
        If e.KeyChar = Chr(27) Then
            Call HapusBaris()
        End If
    End Sub

    Private Sub Pengembalian1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Koneksi()
        Call Otomatis()
        LblTanggalKbl.Text = Today
    End Sub

    Private Sub Pengembalian1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilKodeAnggota()
        Call TampilGrid1()
        Call HapusMaster()
    End Sub

    Private Sub DGV2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV2.CellContentClick

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class