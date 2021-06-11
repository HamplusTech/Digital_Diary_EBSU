Imports System.Data.SqlClient
Public Class frmedudata

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadcv.Click
        With OpenFileDialog1
            .FileName = ""
            .Title = "Samtech Digital Diary | Select Picture/Image File"
            .Filter = "All Images (*.jpg;*.bmp;*.png;*.gif) |*.jpg;*.bmp;*.png;*.gif |" _
            & "All Text Files (*.txt;*.*.rtf;*.doc;*.docx;*.pdf)|*.txt;*.*.rtf;*.doc;*.docx;*.pdf"
            .ShowDialog()
        End With
        If OpenFileDialog1.FileName.ToString <> "" Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            TextBox1.Text = PictureBox1.ImageLocation
        End If
    End Sub

    Private Sub frmedudata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmyprofile.Hide()
        Try
            Dim eneja, opara As New DBops
            eneja.DiaryDT()
            opara.DiaryConnect()
            Dim udechukwu As New SqlCommand
            udechukwu.Connection = opara.cn
            udechukwu.CommandText = "select * from tblEdu where diary_ID=@id"
            udechukwu.Parameters.AddWithValue("@id", Main.Label2.Text)
            udechukwu.ExecuteNonQuery()
            Dim val As SqlDataReader
            val = udechukwu.ExecuteReader
            val.Read()

            If frmmyprofile.TextBox1.Text = "View" Then
                txtbs.ReadOnly = True
                txths1.ReadOnly = True
                txths2.ReadOnly = True
                txths3.ReadOnly = True
                txtjs.ReadOnly = True
                txtms.ReadOnly = True
                TextBox1.ReadOnly = True
                TextBox1.Visible = True
                btnUploadcv.Enabled = False
                txtbs.Text = val.Item("bs")
                txths1.Text = val.Item("hs1")
                txths2.Text = val.Item("hs2")
                txths3.Text = val.Item("hs3")
                txtjs.Text = val.Item("js")
                txtms.Text = val.Item("ms")
                TextBox1.Text = val.Item("cv")
            Else
                txtbs.Text = val.Item("bs")
                txths1.Text = val.Item("hs1")
                txths2.Text = val.Item("hs2")
                txths3.Text = val.Item("hs3")
                txtjs.Text = val.Item("js")
                txtms.Text = val.Item("ms")
                TextBox1.Text = val.Item("cv")
                TextBox1.Visible = True
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
            udechukwu = New SqlCommand("delete from tblEdu where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtbs.Text)
            udechukwu.Parameters.AddWithValue("@nat", txths1.Text)
            udechukwu.Parameters.AddWithValue("@sl", txths2.Text)
            udechukwu.Parameters.AddWithValue("@noc", txths3.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtjs.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtms.Text)
            udechukwu.Parameters.AddWithValue("@pa", TextBox1.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            Dim reinsert As New SqlCommand
            reinsert.Connection = opara.cn
            reinsert.CommandText = "insert into tblEdu (diary_ID) values (@id)"
            reinsert.Parameters.AddWithValue("@id", Main.Label2.Text)
            Me.Hide()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your education Info will be permenantly deleted. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Yes Then
                udechukwu.ExecuteNonQuery()
                reinsert.ExecuteNonQuery()
                Dim aa As Integer = MsgBox("Your education info has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
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
            udechukwu = New SqlCommand("update tblEdu set bs=@ms, hs1=@nat, hs2=@sl, hs3=@noc, js=@nok, ms=@pn, cv=@pa, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
            udechukwu.Parameters.AddWithValue("@ms", txtbs.Text)
            udechukwu.Parameters.AddWithValue("@nat", txths1.Text)
            udechukwu.Parameters.AddWithValue("@sl", txths2.Text)
            udechukwu.Parameters.AddWithValue("@noc", txths3.Text)
            udechukwu.Parameters.AddWithValue("@nok", txtjs.Text)
            udechukwu.Parameters.AddWithValue("@pn", txtms.Text)
            udechukwu.Parameters.AddWithValue("@pa", TextBox1.Text)
            udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

            udechukwu.ExecuteNonQuery()
            Me.Close()
            frmmyprofile.Close()
            Dim a As Integer = MsgBox("Your education info has been modified", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Else
            Me.Close()
            frmmyprofile.Close()
        End If
    End Sub
End Class