Imports System.Data.SqlClient

Module Module1

    Dim cmd As SqlCommand = New SqlCommand

    Public SERVERCONNECTION As String = ""
    Public con As String = getconnection()
    Public Qconn As New SqlConnection(con)

    Public Function READLOCATION()
        If System.IO.File.Exists("C:\SYS.CONFIG\convserum.txt") Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\SYS.CONFIG\convserum.txt")
            SERVERCONNECTION = fileReader.ReadLine()
            fileReader.Close()
        End If
    End Function

    Public Function getconnection()
        READLOCATION()
        con = My.MySettings.Default.convserumConnectionString
        Return con
    End Function

    Public Sub OpenCon()
        If Qconn.State = ConnectionState.Closed Then
            Qconn.Open()
        End If
    End Sub

    Public Sub CloseCon()
        If Qconn.State = ConnectionState.Open Then
            Qconn.Close()
        End If
    End Sub

    Public Sub FillMyGrid(ByVal gridName As DataGridView, ByVal sql As String)
        OpenCon()
        Try
            Dim grdDA As New SqlDataAdapter(sql, Qconn)
            Dim grdDT As New DataTable
            grdDA.Fill(grdDT)
            gridName.DataSource = grdDT
            gridName.Refresh()
        Catch ex As Exception
            MsgBox("ERROR Description: " & ex.Message)
            Exit Sub
        End Try
        With gridName
            .RowsDefaultCellStyle.BackColor = Color.Snow
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    'Public Sub FillMyGrid(ByVal gridName As DataGridView, ByVal sql As String)

    '    'cmd = Qconn.CreateCommand()
    '    'cmd.CommandType = CommandType.Text
    '    'cmd.CommandText = ""
    '    'cmd.ExecuteNonQuery()

    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter(sql, Qconn)
    '    da.Fill(dt)
    '    gridName.DataSource = dt

    '    With gridName
    '        .RowsDefaultCellStyle.BackColor = Color.Snow
    '        .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    '    End With

    'End Sub

End Module
