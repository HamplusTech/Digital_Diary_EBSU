Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic
Public Class DBops
    Public cn As New SqlConnection
    Public ServerDate As DateTime
    Public Sub DiaryConnect()
        Try
            cn = New SqlConnection("server=localhost;uid=sa;pwd=hamplustech; database=Digital_Diary_EBSU")
            If cn.State = Data.ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub DiaryDT()
        Try
            DiaryConnect()
            Dim cmd = New SqlCommand("select GetDate()", cn)
            ServerDate = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
