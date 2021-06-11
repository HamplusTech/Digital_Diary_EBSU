Imports System.Data.SqlClient
Public Class frmhealth
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If frmmyprofile.TextBox1.Text = "Delete" Then
            frmmyprofile.Hide()
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu = New SqlCommand("delete from tblHealth where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtbg.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtcov.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtdis.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtgt.Text)
            udechukwu.Parameters.AddWithValue("@nok", txth.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtw.Text)
            udechukwu.Parameters.AddWithValue("@pa", ComboBox1.Text)
            udechukwu.Parameters.AddWithValue("@lhv", DateTimePicker1.Text)
            If RadioButton1.Checked = True Then
                udechukwu.Parameters.AddWithValue("@dis", RadioButton1.Text)
            Else
                udechukwu.Parameters.AddWithValue("@dis", RadioButton2.Text)
            End If

            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            Dim reinsert As New SqlCommand
            reinsert.Connection = opara.cn
            reinsert.CommandText = "insert into tblHealth (diary_ID) values (@id)"
            reinsert.Parameters.AddWithValue("@id", Main.Label2.Text)
            Me.Hide()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your health Info will be permenantly deleted. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Yes Then
                udechukwu.ExecuteNonQuery()
                reinsert.ExecuteNonQuery()
                Dim aa As Integer = MsgBox("Your health info has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
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
            udechukwu = New SqlCommand("update tblHealth set bg=@ms, cov=@nat, td=@sl, gt=@noc, height=@nok, weight=@pn, hiv=@pa, lhv=@lhv, dis=@dis, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtbg.Text)
            udechukwu.Parameters.AddWithValue("@nat", txtcov.Text)
            udechukwu.Parameters.AddWithValue("@sl", txtdis.Text)
            udechukwu.Parameters.AddWithValue("@noc", txtgt.Text)
            udechukwu.Parameters.AddWithValue("@nok", txth.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtw.Text)
            udechukwu.Parameters.AddWithValue("@pa", ComboBox1.Text)
            udechukwu.Parameters.AddWithValue("@lhv", DateTimePicker1.Text)
            If RadioButton1.Checked = True Then
                udechukwu.Parameters.AddWithValue("@dis", RadioButton1.Text)
            Else
                udechukwu.Parameters.AddWithValue("@dis", RadioButton2.Text)
            End If

            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your health info has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton1.Checked = False
        Else
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub frmhealth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblHealth where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtbg.ReadOnly = True
                txtcov.ReadOnly = True
                txtdis.ReadOnly = True
                txtgt.ReadOnly = True
                txth.ReadOnly = True
                txtw.ReadOnly = True
                ComboBox1.Enabled = False
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                DateTimePicker1.Enabled = False
                txtbg.Text = val.Item("bg")
                txtcov.Text = val.Item("cov")
                txtdis.Text = val.Item("td")
                txtgt.Text = val.Item("gt")
                txth.Text = val.Item("height")
                txtw.Text = val.Item("weight")
                ComboBox1.Text = val.Item("hiv")
                DateTimePicker1.Text = val.Item("lhv")
                If val.Item("dis") = "Yes" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If
            Else
                txtbg.Text = val.Item("bg")
                txtcov.Text = val.Item("cov")
                txtdis.Text = val.Item("td")
                txtgt.Text = val.Item("gt")
                txth.Text = val.Item("height")
                txtw.Text = val.Item("weight")
                ComboBox1.Text = val.Item("hiv")
                DateTimePicker1.Text = val.Item("lhv")
                If val.Item("dis") = "Yes" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtdis.Enabled = True
        Else
            txtdis.Enabled = False
        End If
    End Sub
End Class