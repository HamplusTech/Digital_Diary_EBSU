Imports System.Data.SqlClient
Public Class frmregistration
    Private Sub frmregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtn.ReadOnly = True
                ComboBox1.Enabled = False
                DateTimePicker1.Enabled = False
                txtbg.ReadOnly = True
                txtgt.ReadOnly = True
                txtadd.ReadOnly = True
                txtpn.ReadOnly = True
                txtemail.ReadOnly = True
                txtwebsite.ReadOnly = True
                txtus.ReadOnly = True
                txtpass.ReadOnly = True
                GroupBox1.Enabled = False
                txtn.Text = val.Item("name")
                ComboBox1.Text = val.Item("sex")
                DateTimePicker1.Text = val.Item("dob")
                txtbg.Text = val.Item("bg")
                txtgt.Text = val.Item("gt")
                txtadd.Text = val.Item("address")
                txtpn.Text = val.Item("pn")
                txtemail.Text = val.Item("email")
                txtwebsite.Text = val.Item("website")
                txtus.Text = val.Item("username")
                txtpass.Text = val.Item("password")
                PictureBox1.ImageLocation = val.Item("picture")
            Else
                txtn.Text = val.Item("name")
                ComboBox1.Text = val.Item("sex")
                DateTimePicker1.Text = val.Item("dob")
                txtbg.Text = val.Item("bg")
                txtgt.Text = val.Item("gt")
                txtadd.Text = val.Item("address")
                txtpn.Text = val.Item("pn")
                txtemail.Text = val.Item("email")
                txtwebsite.Text = val.Item("website")
                txtus.Text = val.Item("username")
                txtpass.PasswordChar = ""
                txtpass.Text = val.Item("password")
                PictureBox1.ImageLocation = val.Item("picture")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            If frmmyprofile.TextBox1.Text = "Delete" Then
                frmmyprofile.Hide()
                Dim eneja, opara As New DBops
                eneja.DiaryDT()
                opara.DiaryConnect()
                Dim udechukwu As New SqlCommand
                udechukwu = New SqlCommand("delete from tblRegistration where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
                udechukwu.Parameters.AddWithValue("@ms", txtn.Text)
                udechukwu.Parameters.AddWithValue("@nat", ComboBox1.Text)
                udechukwu.Parameters.AddWithValue("@sl", DateTimePicker1.Text)
                udechukwu.Parameters.AddWithValue("@noc", txtbg.Text)
                udechukwu.Parameters.AddWithValue("@nok", txtgt.Text)
                udechukwu.Parameters.AddWithValue("@pn", txtadd.Text)
                udechukwu.Parameters.AddWithValue("@pa", txtpn.Text)
                udechukwu.Parameters.AddWithValue("@lhv", txtemail.Text)
                udechukwu.Parameters.AddWithValue("@dis", txtwebsite.Text)
                udechukwu.Parameters.AddWithValue("@gg", txtus.Text)
                udechukwu.Parameters.AddWithValue("@ggg", txtpass.Text)
                udechukwu.Parameters.AddWithValue("@pic", OpenFileDialog1.FileName)
                udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

                Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8 As New SqlCommand
                cmd1.Connection = opara.cn
                cmd1.CommandText = "delete from tblBiodata where diary_ID=@id"
                cmd1.Parameters.AddWithValue("@id", Main.Label2.Text)

                cmd2.Connection = opara.cn
                cmd2.CommandText = "delete from tblContactInfo where diary_ID=@id"
                cmd2.Parameters.AddWithValue("@id", Main.Label2.Text)

                'cmd3.Connection = opara.cn
                'cmd3.CommandText = "delete from tblContacts where diary_ID=@id"
                'cmd3.Parameters.AddWithValue("@id", Main.Label2.Text)

                cmd4.Connection = opara.cn
                cmd4.CommandText = "delete from tblEdu where diary_ID=@id"
                cmd4.Parameters.AddWithValue("@id", Main.Label2.Text)

                cmd5.Connection = opara.cn
                cmd5.CommandText = "delete from tblHealth where diary_ID=@id"
                cmd5.Parameters.AddWithValue("@id", Main.Label2.Text)

                'cmd6.Connection = opara.cn
                'cmd6.CommandText = "delete from tblMemoLetter where diary_ID=@id"
                'cmd6.Parameters.AddWithValue("@id", Main.Label2.Text)

                cmd7.Connection = opara.cn
                cmd7.CommandText = "delete from tblMobility where diary_ID=@id"
                cmd7.Parameters.AddWithValue("@id", Main.Label2.Text)

                'cmd8.Connection = opara.cn
                'cmd8.CommandText = "delete from ToDO where diary_ID=@id"
                'cmd8.Parameters.AddWithValue("@id", Main.Label2.Text)


                frmmyprofile.Close()
                Dim a As Integer = MsgBox("Your account will be permenantly  and totally deleted. You will no longer have access to this diary. Do you wish to continue?", MsgBoxStyle.YesNo, Title:="Blinks Digital Diary")
                If a = MsgBoxResult.Yes Then
                    udechukwu.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    'cmd3.ExecuteNonQuery()
                    cmd4.ExecuteNonQuery()
                    cmd5.ExecuteNonQuery()
                    'cmd6.ExecuteNonQuery()
                    cmd7.ExecuteNonQuery()
                    '  cmd8.ExecuteNonQuery()

                    Dim aa As Integer = MsgBox("Your account/registration has been deleted.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                    Application.Restart()
                Else
                    Me.Close()
                    frmmyprofile.Show()

                End If
            ElseIf frmmyprofile.TextBox1.Text = "Modify" Then
                frmmyprofile.Hide()
                Dim eneja, opara As New DBops
                eneja.DiaryDT()
                opara.DiaryConnect()
                Dim udechukwu As New SqlCommand
                udechukwu = New SqlCommand("update tblRegistration set name=@ms, sex=@nat, dob=@sl, bg=@noc, gt=@nok, address=@pn, pn=@pa, email=@lhv, website=@dis, username=@gg, password=@ggg, picture=@pic, DT=@dt where diary_ID= '" & Main.Label2.Text & "'", opara.cn)
                udechukwu.Parameters.AddWithValue("@ms", txtn.Text)
                udechukwu.Parameters.AddWithValue("@nat", ComboBox1.Text)
                udechukwu.Parameters.AddWithValue("@sl", DateTimePicker1.Text)
                udechukwu.Parameters.AddWithValue("@noc", txtbg.Text)
                udechukwu.Parameters.AddWithValue("@nok", txtgt.Text)
                udechukwu.Parameters.AddWithValue("@pn", txtadd.Text)
                udechukwu.Parameters.AddWithValue("@pa", txtpn.Text)
                udechukwu.Parameters.AddWithValue("@lhv", txtemail.Text)
                udechukwu.Parameters.AddWithValue("@dis", txtwebsite.Text)
                udechukwu.Parameters.AddWithValue("@gg", txtus.Text)
                udechukwu.Parameters.AddWithValue("@ggg", txtpass.Text)
                udechukwu.Parameters.AddWithValue("@pic", PictureBox1.ImageLocation)
                udechukwu.Parameters.AddWithValue("@dt", eneja.ServerDate)

                udechukwu.ExecuteNonQuery()
                Me.Close()
                frmmyprofile.Close()
                Dim a As Integer = MsgBox("Your mobility info has been modified", MsgBoxStyle.OkOnly, Title:="Blinks Digital Diary")
            Else
                Me.Close()
                frmmyprofile.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click
        With OpenFileDialog1
            .Filter = "All Images |*.jpg;*.gif;*.bmp;*.png"
            .FileName = ""
            .Title = "Samtech Digital Diary | Select Picture"
        End With
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString <> "" Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class