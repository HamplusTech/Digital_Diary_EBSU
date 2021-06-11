Imports System.Data.SqlClient
Public Class frmlogininfo

    Private Sub frmlogininfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblRegistration where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtpassword.ReadOnly = True
                txtus.ReadOnly = True
                txtpassword.Text = val.Item("password")
                txtus.Text = val.Item("username")
            ElseIf frmmyprofile.TextBox1.Text = "Delete" Then
                Dim a As Integer = MsgBox("You can not delete your login info", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                If a = MsgBoxResult.Ok Then
                    Me.Close()
                    frmmyprofile.Close()
                End If
            Else
            txtpassword.Text = val.Item("password")
            txtus.Text = val.Item("username")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
       If frmmyprofile.TextBox1.Text = "Modify" Then
            frmmyprofile.Hide()
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu = New SqlCommand("update tblMobility set password=@ms, username=@nat, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtpassword.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtus.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your login info has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub
End Class