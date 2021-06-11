Imports System.Data.SqlClient
Public Class frmcontactinfo

    Private Sub frmcontact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblContactInfo where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtadd1.ReadOnly = True
                txtadd2.ReadOnly = True
                txtbbp.ReadOnly = True
                txtemail.ReadOnly = True
                txtpa.ReadOnly = True
                txtpn.ReadOnly = True
                txtwebsite.ReadOnly = True
                txtadd1.Text = val.Item("add1")
                txtadd2.Text = val.Item("add2")
                txtbbp.Text = val.Item("bbping")
                txtemail.Text = val.Item("email")
                txtpa.Text = val.Item("pa")
                txtpn.Text = val.Item("pn")
                txtwebsite.Text = val.Item("website")
            Else
                txtadd1.Text = val.Item("add1")
                txtadd2.Text = val.Item("add2")
                txtbbp.Text = val.Item("bbping")
                txtemail.Text = val.Item("email")
                txtpa.Text = val.Item("pa")
                txtpn.Text = val.Item("pn")
                txtwebsite.Text = val.Item("website")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If frmmyprofile.TextBox1.Text = "Delete" Then
            frmmyprofile.Hide()
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu = New SqlCommand("delete from tblContactInfo where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtadd1.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtadd2.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtbbp.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtemail.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtpa.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtpn.Text)
            udechukwu.Parameters.AddWithValue("@pa", txtwebsite.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            Dim reinsert As New SqlCommand
            reinsert.Connection = opara.cn
            reinsert.CommandText = "insert into tblContactInfo (diary_ID) values (@id)"
            reinsert.Parameters.AddWithValue("@id", Main.Label2.Text)
            Me.Hide()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your Contact Info will be permenantly deleted. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Yes Then
                udechukwu.ExecuteNonQuery()
                reinsert.ExecuteNonQuery()
                Dim aa As Integer = MsgBox("Your Contact info has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                Me.Close()
            Else
                Me.Show()
            End If
        ElseIf frmmyprofile.TextBox1.Text = "Modify" Then
            frmmyprofile.Hide()
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu = New SqlCommand("update tblContactInfo set add1=@ms, add2=@nat, bbping=@sl, email=@noc, pa=@nok, pn=@pn, website=@pa, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtadd1.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtadd2.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtbbp.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtemail.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtpa.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtpn.Text)
            udechukwu.Parameters.AddWithValue("@pa", txtwebsite.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your contact info has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub
End Class