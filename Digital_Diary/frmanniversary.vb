Imports System.Data.SqlClient
Public Class frmanniversary

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "insert into tblSATA (diary_ID,sub,date,time," _
 & "fd,DT,SATAtype)" _
            & "values (@did,@n,@dob,@dcid,@fd,@num,@em)"
            jp.Parameters.AddWithValue("@did", Main.Label2.Text)
            jp.Parameters.AddWithValue("@n", txtsub.Text)
            jp.Parameters.AddWithValue("@dob", DateTimePicker1.Text)
            jp.Parameters.AddWithValue("@dcid", DateTimePicker2.Text)
            jp.Parameters.AddWithValue("fd", txtdes.Text)
            jp.Parameters.AddWithValue("@num", antho.ServerDate)
            jp.Parameters.AddWithValue("@em", "Anniversary")
            jp.ExecuteNonQuery()
            Me.Close()
            Dim a = MsgBox("Anniversary is saved successfully", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmanniversary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "select * from tblSATA where diary_ID='" & Main.Label2.Text & "' and SATAtype=@ty"
            jp.Parameters.AddWithValue("@ty", "Anniversary")
            jp.ExecuteNonQuery()
            Dim udih As SqlDataReader
            udih = jp.ExecuteReader
            Do While udih.Read
                ListBox1.Items.Add(udih.Item("sub") & "  " & udih.Item("fd") & "  " & udih.Item("time") & "  " & udih.Item("date"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class