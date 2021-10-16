Imports System.Data.oledb

Public Class Petugas
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        TPassword.Text = ""
        CBOStatus.Text = ""
        TKode.Focus()
    End Sub

    Sub DataBaru()
        TNama.Text = ""
        TPassword.Text = ""
        CBOStatus.Text = ""
        TNama.Focus()
    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Petugas ORDER BY 1", CONN)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Petugas")
        DGV.DataSource = (ds.Tables("Petugas"))
        DGV.ReadOnly = True
    End Sub

    Sub TampilstatusPTG()
        CBOStatus.Items.Clear()
        CMD = New OleDbCommand("select distinct STATUSPTG from Petugas", CONN)
        DR = cmd.ExecuteReader
        While DR.Read
            CBOStatus.Items.Add(DR.GetString(0))
        End While
    End Sub

    Private Sub Petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Koneksi()
        Call Tampilkan()
        CBOStatus.Items.Add("ADMINISTRATOR")
        CBOStatus.Items.Add("OPERATOR")
    End Sub

    Private Sub TKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKode.KeyPress

        If e.KeyChar = Chr(13) Then
            TKode.Text = UCase(TKode.Text)
            CMD = New OleDbCommand("select * from Petugas where KODEPTG='" & TKode.Text & "'", CONN)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                TNama.Text = DR.GetString(1)
                TPassword.Text = DR.GetString(2)
                CBOStatus.Text = DR.GetString(3)
                TNama.Focus()
            Else
                Call DataBaru()
                TNama.Focus()
            End If
        End If
    End Sub

    Private Sub TNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNama.KeyPress

        If e.KeyChar = Chr(13) Then
            TPassword.Focus()
            TNama.Text = UCase(TNama.Text)
        End If

    End Sub

    Private Sub TPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPassword.KeyPress
        If e.KeyChar = Chr(13) Then CBOStatus.Focus()
    End Sub


    Private Sub CmbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBOStatus.KeyPress
        If e.KeyChar = Chr(13) Then CmdSimpan.Focus()
    End Sub


    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click

        If TKode.Text = "" Or TNama.Text = "" Or TPassword.Text = "" Or CBOStatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            CMD = New OleDbCommand("Select * from Petugas where KODEPTG='" & TKode.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim oledbtambah As String = "Insert into Petugas(KODEPTG,NAMAPTG,PASSWORDPTG,STATUSPTG) values " & _
                "('" & TKode.Text & "','" & TNama.Text & "','" & TPassword.Text & "','" & CBOStatus.Text & "')"
                CMD = New oledbCommand(oledbtambah, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim oledbedit As String = "Update Petugas set " & _
                "NAMAPTG='" & TNama.Text & "', " & _
                "PASSWORDPTG='" & TPassword.Text & "', " & _
                "STATUSPTG='" & CBOStatus.Text & "' where KODEPTG='" & TKode.Text & "'"
                CMD = New OleDbCommand(oledbedit, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
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
        If TKode.Text = "" Then
            MsgBox("Isi kode Petugas terlebih dahulu")
            TKode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New OleDbCommand("Delete * from Petugas where KODEPTG='" & TKode.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub TNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNama.TextChanged

    End Sub
    Private Sub TPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPassword.TextChanged

    End Sub
    Private Sub CBOStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOStatus.SelectedIndexChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class