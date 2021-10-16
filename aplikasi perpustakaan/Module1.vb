Imports System.Data.oledb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module Module1
    Public CONN As oledbConnection
    Public DA As oledbDataAdapter
    Public DS As New DataSet
    Public CMD As oledbCommand
    Public DR As oledbDataReader

    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table

    Public Sub Module_Konfigurasi_laporan()
        With crConnectionInfo
            .ServerName = (Application.StartupPath.ToString & "\DBperpustakaan.accdb")
            .DatabaseName = (Application.StartupPath.ToString & "\DBperpustakaan.accdb")
            .UserID = ""
            .Password = ""
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
    End Sub

    Sub Koneksi()
        CONN = New OleDbConnection("provider=microsoft.ACE.oledb.12.0;data source=dbperpustakaan.accdb")
        CONN.Open()
    End Sub
End Module
