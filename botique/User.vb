Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class User

    'Public Shared Function getPass()
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\testdb.accdb"
    '    Dim cmd As New OleDb.OleDbCommand

    '    Try
    '        conn.ConnectionString = connStr
    '        conn.Open()
    '        cmd.Connection = conn

    '        cmd.CommandText = "SELECT password FROM botique WHERE username = 'admin'"

    '        Return
    '        cmd.ExecuteNonQuery()
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Function
    Public Shared Function Hash(ByVal password As String) As String
        Using md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Dim utf8 As UTF8Encoding = New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(password))
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Public Shared Function correctpass(ByVal username As String, password As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Desktop\botiqueDB.accdb"
        Dim cmd As New OleDb.OleDbCommand
        Dim r As Boolean = False
        Try
            conn.ConnectionString = connStr
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "SELECT password FROM users WHERE username = @username and password = @password"

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", Hash(password))

            Using reader = cmd.ExecuteReader
                If reader.Read() Then
                    r = True
                Else
                    r = False
                End If
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return r
    End Function


End Class
