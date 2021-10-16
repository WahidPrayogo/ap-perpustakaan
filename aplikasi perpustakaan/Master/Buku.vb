Imports System.Data.oledb

Public Class Buku
    Sub Kosongkan()
        TNomor.Text = ""
        TJudul.Text = ""
        TPengarang.Text = ""
        TPenerbit.Text = ""
        TTahun.Text = ""
        TStok.Text = ""
        TNomor.Focus()
    End Sub

    Sub DataBaru()
        TJudul.Text = ""
        TPengarang.Text = ""
        TPenerbit.Text = ""
        TTahun.Text = ""
        TStok.Text = ""
        TJudul.Focus()
    End Sub

    Sub TampilGrid()
        da = New oledbDataAdapter("Select * from Buku", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Buku")
        DGV.DataSource = (ds.Tables("Buku"))
        DGV.ReadOnly = True
    End Sub

    Sub TampilData()
        TJudul.Text = dr.Item("Judul")
        TPengarang.Text = dr.Item("Pengarang")
        TPenerbit.Text = dr.Item("Penerbit")
        TTahun.Text = dr.Item("Tahun")
        TStok.Text = dr.Item("Stok")
    End Sub

    Private Sub Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
    End Sub

    Private Sub TNomor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomor.KeyPress
        TNomor.MaxLength = 4
        If e.KeyChar = Chr(13) Then
            TNomor.Text = UCase(TNomor.Text)
            cmd = New oledbCommand("select * from Buku where NomorBK='" & TNomor.Text & "'", Conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Call TampilData()
                TJudul.Focus()
            Else
                Call DataBaru()
                TJudul.Focus()
            End If
        End If
    End Sub

    Private Sub TJudul_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TJudul.KeyPress
        If e.KeyChar = Chr(13) Then
            TJudul.Text = UCase(TJudul.Text)
            TPengarang.Focus()
        End If
    End Sub

    Private Sub TPengarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPengarang.KeyPress
        If e.KeyChar = Chr(13) Then
            TPengarang.Text = UCase(TPengarang.Text)
            TPenerbit.Focus()
        End If
    End Sub

    Private Sub TPenerbit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPenerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            TPenerbit.Text = UCase(TPenerbit.Text)
            TTahun.Focus()
        End If
    End Sub

    Private Sub TTahun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TTahun.KeyPress
        If e.KeyChar = Chr(13) Then TStok.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TStok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TStok.KeyPress
        If e.KeyChar = Chr(13) Then CmdSimpan.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TNomor.Text = "" Or TJudul.Text = "" Or TPengarang.Text = "" Or TPenerbit.Text = "" Or TTahun.Text = "" Or TStok.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            CMD = New oledbCommand("Select * from Buku where NomorBK='" & TNomor.Text & "'", CONN)
            dr = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim oledbtambah As String = "Insert into Buku(NomorBK,Judul,Pengarang,Penerbit,Tahun,Stok) values " & _
                "('" & TNomor.Text & "','" & TJudul.Text & "','" & TPengarang.Text & "','" & TPenerbit.Text & "','" & TTahun.Text & "','" & TStok.Text & "')"
                CMD = New oledbCommand(oledbtambah, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call TampilGrid()
            Else
                Dim oledbedit As String = "Update Buku set " & _
                "Judul='" & TJudul.Text & "', " & _
                "Pengarang='" & TPengarang.Text & "', " & _
                "Penerbit='" & TPenerbit.Text & "', " & _
                "Tahun='" & TTahun.Text & "', " & _
                "Stok='" & TStok.Text & "' where NomorBK='" & TNomor.Text & "'"
                CMD = New OleDbCommand(oledbedit, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Call Kosongkan()
    End Sub

    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        Me.Close()
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If TNomor.Text = "" Then
            MsgBox("Isi kode Buku terlebih dahulu")
            TNomor.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New OleDbCommand("Delete * from Buku where NomorBK='" & TNomor.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call TampilGrid()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

End Class