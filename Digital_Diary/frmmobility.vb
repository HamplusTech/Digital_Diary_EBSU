Imports System.Data.SqlClient
Public Class frmmobility

    Private Sub frmmobility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblMobility where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtchas.ReadOnly = True
                txtciti.ReadOnly = True
                txtdln.ReadOnly = True
                txteng.ReadOnly = True
                txtppn.ReadOnly = True
                txtssn.ReadOnly = True
                txtveh.ReadOnly = True
                dtpdrdl.Enabled = False
                dtpdrpp.Enabled = False
                dtpeddl.Enabled = False
                dtpedpp.Enabled = False
                txtchas.Text = val.Item("cn")
                txtciti.Text = val.Item("citi")
                txtdln.Text = val.Item("dl")
                txteng.Text = val.Item("en")
                txtppn.Text = val.Item("passno")
                txtssn.Text = val.Item("ssn")
                txtveh.Text = val.Item("vn")
                dtpdrdl.Text = val.Item("dldr")
                dtpdrpp.Text = val.Item("dr")
                dtpeddl.Text = val.Item("dled")
                dtpedpp.Text = val.Item("ed")
            Else
                txtchas.Text = val.Item("cn")
                txtciti.Text = val.Item("citi")
                txtdln.Text = val.Item("dl")
                txteng.Text = val.Item("en")
                txtppn.Text = val.Item("passno")
                txtssn.Text = val.Item("ssn")
                txtveh.Text = val.Item("vn")
                dtpdrdl.Text = val.Item("dldr")
                dtpdrpp.Text = val.Item("dr")
                dtpeddl.Text = val.Item("dled")
                dtpedpp.Text = val.Item("ed")
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
            udechukwu = New SqlCommand("delete from tblMobility where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtchas.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtciti.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtdln.Text)
            udechukwu.Parameters.AddWithValue("@noc", txteng.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtppn.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtssn.Text)
            udechukwu.Parameters.AddWithValue("@pa", txtveh.Text)
            udechukwu.Parameters.AddWithValue("@lhv", dtpdrdl.Text)
            udechukwu.Parameters.AddWithValue("@dis", dtpdrpp.Text)
            udechukwu.Parameters.AddWithValue("@gg", dtpeddl.Text)
            udechukwu.Parameters.AddWithValue("@ggg", dtpedpp.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            Dim reinsert As New SqlCommand
            reinsert.Connection = opara.cn
            reinsert.CommandText = "insert into tblMobility (diary_ID) values (@id)"
            reinsert.Parameters.AddWithValue("@id", Main.Label2.Text)
            Me.Hide()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your mobility Info will be permenantly deleted. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Yes Then
                udechukwu.ExecuteNonQuery()
                reinsert.ExecuteNonQuery()
                Dim aa As Integer = MsgBox("Your mobility info has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
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
            udechukwu = New SqlCommand("update tblMobility set cn=@ms, citi=@nat, dl=@sl, en=@noc, passno=@nok, ssn=@pn, vn=@pa, dldr=@lhv, dr=@dis, dled=@gg, ed=@ggg, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtchas.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtciti.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtdln.Text)
            udechukwu.Parameters.AddWithValue("@noc", txteng.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtppn.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtssn.Text)
            udechukwu.Parameters.AddWithValue("@pa", txtveh.Text)
            udechukwu.Parameters.AddWithValue("@lhv", dtpdrdl.Text)
            udechukwu.Parameters.AddWithValue("@dis", dtpdrpp.Text)
            udechukwu.Parameters.AddWithValue("@gg", dtpeddl.Text)
            udechukwu.Parameters.AddWithValue("@ggg", dtpedpp.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your mobility info has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub
End Class