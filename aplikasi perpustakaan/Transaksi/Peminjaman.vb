Imports System.Data.oledb
Public Class Peminjaman

    Private Sub NomorPjm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Koneksi()
        Call Otomatis()
        LblTanggal.Text = Today
    End Sub


    Sub TampilKodeAnggota()
        cmd = New oledbCommand("select * FROM ANGGOTA", Conn)
        DR = cmd.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub

    Sub TampilGrid1()
        DGV1.Columns.Add("Kode", "Kode")
        DGV1.Columns.Add("Judul", "Judul Buku")
        DGV1.Columns.Add("Stok", "Stok")
        DGV1.Columns.Add("Jumlah", "Jumlah")
        Call AturKolomGrid1()
    End Sub

    Sub AturKolomGrid1()
        DGV1.Columns(0).Width = 75
        DGV1.Columns(1).Width = 200
        DGV1.Columns(2).Width = 80
        DGV1.Columns(3).Width = 75
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
        CMD = New OleDbCommand("Select * from Pinjam where NomorPjm in (select max(NomorPjm) from Pinjam) order by NomorPjm desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        DR = cmd.ExecuteReader
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
        LblNomorPjm.Text = urutan
    End Sub

    Sub TotalPinjam()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DGV1.Rows.Count - 1
            subtot += Val(DGV1.Rows(I).Cells(3).Value)
            LblTotalPjm.Text = subtot
        Next
    End Sub

    Private Sub DGV1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellEndEdit
        If e.ColumnIndex = 0 Then
            Call Koneksi()
            CMD = New oledbCommand("select NomorBK from anggota,pinjam,detailpjm where NomorBK ='" & DGV1.Rows(e.RowIndex).Cells(0).Value & "' and pinjam.nomorpjm=detailpjm.nomorpjm and anggota.nomoragt=PINJAM.nomoragt and anggota.nomoragt='" & ComboBox1.Text & "' AND detailpjm.JUMLAHBK>0", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("Buku sedang dipinjam dan belum dikembalikan")
                'DGV1.ReadOnly = True
                Call HapusBaris()
                Exit Sub
            End If
            Call Koneksi()
            CMD = New oledbCommand("Select * from Buku where NomorBK='" & DGV1.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                If DR.Item(5) <= 0 Then
                    MsgBox("Stok Buku kosong")
                Else

                    DGV1.Rows(e.RowIndex).Cells(1).Value = DR.Item("Judul")
                    DGV1.Rows(e.RowIndex).Cells(2).Value = DR.Item("Stok")

                    DGV1.Rows(e.RowIndex).Cells(3).Value = 1
                    Call TotalPinjam()

                    Call BatasPinjaman()
                    Exit Sub
                End If
            Else
                MsgBox("Kode Buku tidak terdaftar")
                Exit Sub
            End If

        End If

        If e.ColumnIndex = 3 Then
            If DGV1.Rows(e.RowIndex).Cells(3).Value = DGV1.Rows(e.RowIndex).Cells(3).Value Then
                MsgBox("Stok hanya ada & DGV1.Rows(e.RowIndex).Cells(2).Value  & """)
                Exit Sub
            Else
                Call TotalPinjam()
            End If

            If Val(LblTotalPjm.Text) + Val(LblTelahPjm.Text) >= 3 Then
                MsgBox("pinjaman sudah maksimal")
                DGV1.ReadOnly = True
                BTNSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click

        If ComboBox1.Text = "" Or LblTotalPjm.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        End If

        'simpan ke tabel Pinjam
        Call Koneksi()
        Dim oledbInput1 As String = "Insert Into Pinjam(NomorPjm,TanggalPjm,TotalPjm,Nomoragt,kodeptg)" & _
        "values('" & LblNomorPjm.Text & "','" & LblTanggal.Text & "','" & LblTotalPjm.Text & "','" & ComboBox1.Text & "','" & MenuUtama.Panel1.Text & "')"
        CMD = New oledbCommand(oledbInput1, CONN)
        CMD.ExecuteNonQuery()

        For baris As Integer = 0 To DGV1.Rows.Count - 2
            'simpan ke tabel detail
            Call Koneksi()
            Dim oledbsimpan As String = "Insert Into DetailPjm(Nomorpjm,NomorBK,JumlahBK) values " & _
            "('" & LblNomorPjm.Text & "','" & DGV1.Rows(baris).Cells(0).Value & "','" & DGV1.Rows(baris).Cells(3).Value & "')"
            CMD = New oledbCommand(oledbsimpan, CONN)
            CMD.ExecuteNonQuery()

            'kurangi stok Buku
            Call Koneksi()
            Dim kurangistok As String = "update Buku set Stok= '" & DGV1.Rows(baris).Cells(2).Value - DGV1.Rows(baris).Cells(3).Value & "' where NomorBK='" & DGV1.Rows(baris).Cells(0).Value & "'"
            CMD = New oledbCommand(kurangistok, CONN)
            CMD.ExecuteNonQuery()
        Next baris

        DGV1.Columns.Clear()
        DGV2.Columns.Clear()
        Call TampilGrid1()
        Call Otomatis()
        Call HapusMaster()
        ComboBox1.Focus()
    End Sub

    Sub HapusMaster()
        LblTelahPjm.Text = ""
        LblTotalPjm.Text = ""
        LblNamaAgt.Text = ""
        ComboBox1.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        DGV1.Columns.Clear()
        DGV2.Columns.Clear()
        'DGV2.Rows.Clear()
        Call HapusMaster()
        Call TampilGrid1()
        Call TampilGrid2()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Sub HapusBaris()
        Dim baris As Integer
        Dim kolom As Integer
        baris = DGV1.CurrentCell.RowIndex
        kolom = DGV1.CurrentCell.ColumnIndex

        DGV1.Rows.RemoveAt(baris)
        Call TotalPinjam()
        'Call TotalHarga()
        DGV1.ReadOnly = False
    End Sub

    Private Sub DGV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV1.KeyPress
        Dim baris As Integer
        Dim kolom As Integer
        baris = DGV1.CurrentCell.RowIndex
        kolom = DGV1.CurrentCell.ColumnIndex

        If e.KeyChar = Chr(27) Then
            Try
                DGV1.Rows.RemoveAt(baris)
                Call TotalPinjam()
                'Call TotalHarga()
                DGV1.ReadOnly = False
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
            DGV1.Focus()
        End If

    End Sub

    Sub CariData()
        ComboBox1.MaxLength = 4
        Call Koneksi()
        CMD = New OleDbCommand("Select * from anggota where nomoragt='" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            LblNamaAgt.Text = DR.Item("namaagt")
            Call Pinjaman()
            If Val(LblTotalPjm.Text) + Val(LblTelahPjm.Text) >= 3 Then
                MsgBox("pinjaman sudah maksimal")
                DGV1.ReadOnly = True
                BTNSimpan.Focus()
            Else
                DGV1.ReadOnly = False
                DGV1.Focus()
            End If
        Else
            MsgBox("Nomor anggota tidak teDRaftar")
            Call HapusMaster()
            ComboBox1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.MaxLength = 4
        Call CariData()

    End Sub

    Sub Pinjaman()
        Call Koneksi()
        DA = New OleDbDataAdapter("Select Buku.NomorBK,Judul,JumlahBK From Anggota,Pinjam,Buku,Detailpjm Where Buku.NomorBK=Detailpjm.NomorBK And Pinjam.Nomorpjm=Detailpjm.Nomorpjm And Anggota.Nomoragt=Pinjam.Nomoragt And Anggota.Nomoragt='" & ComboBox1.Text & "' AND detailpjm.jumlahBK>0", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Detail")
        DGV2.DataSource = DS.Tables("Detail")
        LblTelahPjm.Text = DGV2.Rows.Count - 1
        Call AturKolomGrid2()
        DGV2.ReadOnly = True
    End Sub

    Sub BatasPinjaman()
        If Val(LblTotalPjm.Text) + Val(LblTelahPjm.Text) >= 3 Then
            MsgBox("pinjaman sudah maksimal")
            DGV1.ReadOnly = True
            BTNSimpan.Enabled = False
        Else
            DGV1.ReadOnly = False
            DGV1.Focus()
            BTNSimpan.Enabled = True
        End If
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Pengembalian.Show()
    End Sub

    Private Sub Peminjaman1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilKodeAnggota()
        Call TampilGrid1()
        Call HapusMaster()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Anggota.Show()
    End Sub
End Class