Imports System.Data.SqlClient
Public Class frmbio

    Private Sub frmbio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblBiodata where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtC.ReadOnly = True
                txtms.ReadOnly = True
                txtNation.ReadOnly = True
                txtnk.ReadOnly = True
                txtpn.ReadOnly = True
                txtSL.ReadOnly = True

                txtC.Text = val.Item("noc")
                txtms.Text = val.Item("ms")
                txtNation.Text = val.Item("nation")
                txtnk.Text = val.Item("nok")
                txtpn.Text = val.Item("pn")
                txtSL.Text = val.Item("sl")
            Else
                txtC.Text = val.Item("noc")
                txtms.Text = val.Item("ms")
                txtNation.Text = val.Item("nation")
                txtnk.Text = val.Item("nok")
                txtpn.Text = val.Item("pn")
                txtSL.Text = val.Item("sl")
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
            udechukwu = New SqlCommand("delete from tblBiodata where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtms.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtNation.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtSL.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtC.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtnk.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtpn.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            Dim reinsert As New SqlCommand
            reinsert.Connection = opara.cn
            reinsert.CommandText = "insert into tblBiodata (diary_ID) values (@id)"
            reinsert.Parameters.AddWithValue("@id", Main.Label2.Text)
            Me.Hide()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your biodata will be permenantly deleted. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Yes Then
                udechukwu.ExecuteNonQuery()
                reinsert.ExecuteNonQuery()
                Dim aa As Integer = MsgBox("Your biodata has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
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
            udechukwu = New SqlCommand("update tblBiodata set ms=@ms, nation=@nat, sl=@sl, noc=@noc, nok=@nok, pn=@pn, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtms.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtNation.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtSL.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtC.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtnk.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtpn.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your biodata has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub
End Class