Imports System.Data.oledb

Public Class Anggota
    Sub Kosongkan()
        TNomor.Text = ""
        TNama.Text = ""
        TAlamat.Text = ""
        TTelepon.Text = ""
        TNomor.Focus()
    End Sub

    Sub DataBaru()
        TNama.Text = ""
        TAlamat.Text = ""
        TTelepon.Text = ""
        TNama.Focus()
    End Sub

    Sub Tampilkan()
        da = New oledbDataAdapter("Select * from Anggota", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Anggota")
        DGV.DataSource = (ds.Tables("Anggota"))
        DGV.ReadOnly = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub TNomor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomor.KeyPress
        TNomor.MaxLength = 4
        If e.KeyChar = Chr(13) Then
            TNomor.Text = UCase(TNomor.Text)
            cmd = New oledbCommand("select * from Anggota where NomorAgt='" & TNomor.Text & "'", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                TNama.Text = DR.Item(1)
                TAlamat.Text = DR.Item(2)
                TTelepon.Text = DR.Item(3)
                TNama.Focus()
            Else
                Call DataBaru()
                TNama.Focus()
            End If
        End If
        'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TNama.Text = UCase(TNama.Text)
            TAlamat.Focus()
        End If

    End Sub

    Private Sub TAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TAlamat.Text = UCase(TAlamat.Text)
            TTelepon.Focus()
        End If

        'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TTelepon.KeyPress
        If e.KeyChar = Chr(13) Then BTNSimpan.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub


    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click

        If TNomor.Text = "" Or TNama.Text = "" Or TAlamat.Text = "" Or TTelepon.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            CMD = New oledbCommand("Select * from Anggota where NomorAgt='" & TNomor.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim oledbtambah As String = "Insert into Anggota(NomorAgt,NamaAgt,AlamatAgt,TeleponAgt) values " & _
                "('" & TNomor.Text & "','" & TNama.Text & "','" & TAlamat.Text & "','" & TTelepon.Text & "')"
                CMD = New oledbCommand(oledbtambah, CONN)
                CMD.ExecuteNonQuery()

                Call Kosongkan()
                Call Tampilkan()

            Else
                Dim oledbedit As String = "Update Anggota set " & _
                "NamaAgt='" & TNama.Text & "', " & _
                "AlamatAgt='" & TAlamat.Text & "', " & _
                "TeleponAgt='" & TTelepon.Text & "' where NomorAgt='" & TNomor.Text & "'"
                CMD = New OleDbCommand(oledbedit, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
    End Sub

    Private Sub BTNTUtup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub BTNHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNHapus.Click
        If TNomor.Text = "" Then
            MsgBox("Isi kode Anggota terlebih dahulu")
            TNomor.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New OleDbCommand("Delete * from Anggota where NomorAgt='" & TNomor.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

End Class
