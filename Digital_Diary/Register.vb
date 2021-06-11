Imports System.Data.SqlClient
Public Class Register

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click
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

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        Try
            Dim hamplus, Dt As New DBops
            hamplus.DiaryConnect()
            Dt.DiaryDT()
            Dim jpsoft As New SqlCommand
            jpsoft.Connection = hamplus.cn
            jpsoft.CommandText = "insert into tblRegistration (name,sex,dob,bg,gt,address,pn,email,website,username,password,picture,diary_ID,DT)" _
        & "values(@n,@un,@uid,@p,@s,@dob,@em,@pn,@ca,@pa,@c,@st,@zc,@ct)"
            jpsoft.Parameters.AddWithValue("@n", txtn.Text)
            jpsoft.Parameters.AddWithValue("@un", ComboBox1.Text)
            jpsoft.Parameters.AddWithValue("@uid", DateTimePicker1.Text)
            jpsoft.Parameters.AddWithValue("@p", txtbg.Text)
            jpsoft.Parameters.AddWithValue("@s", txtgt.Text)
            jpsoft.Parameters.AddWithValue("@dob", txtadd.Text)
            jpsoft.Parameters.AddWithValue("@em", txtpn.Text)
            jpsoft.Parameters.AddWithValue("@pn", txtemail.Text)
            jpsoft.Parameters.AddWithValue("@ca", txtwebsite.Text)
            jpsoft.Parameters.AddWithValue("@pa", txtus.Text)
            jpsoft.Parameters.AddWithValue("@c", txtpass.Text)
            jpsoft.Parameters.AddWithValue("@st", OpenFileDialog1.FileName)

            jpsoft.Parameters.AddWithValue("@ct", Dt.ServerDate)
            Dim aa, b, c As Integer
            aa = 11211
            Randomize()
            b = Rnd(aa) * 22122
            c = b
            c = Mid(b, 2, 2)
            Me.Hide()
            Dim a As Integer = MsgBox("Your Diary ID is " & " " & txtus.Text & " " & c & " .Please take note of your ID and keep it Secret", MsgBoxStyle.OkCancel, Title:="Samtech Digital Diary")
            If a = MsgBoxResult.Ok Then
                jpsoft.Parameters.AddWithValue("@zc", txtus.Text & " " & c)
                jpsoft.ExecuteScalar()
                jpsoft.Parameters.Clear()
                Dim aaa As Integer = MsgBox("You have successfully registered as a user", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8 As New SqlCommand
                cmd1.Connection = hamplus.cn
                cmd1.CommandText = "insert into tblBiodata (diary_ID) values (@id)"
                cmd1.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                cmd1.ExecuteNonQuery()

                cmd2.Connection = hamplus.cn
                cmd2.CommandText = "insert into tblContactInfo (diary_ID) values (@id)"
                cmd2.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                cmd2.ExecuteNonQuery()

                'cmd3.Connection = hamplus.cn
                'cmd3.CommandText = "insert into tblContacts (diary_ID) values (@id)"
                'cmd3.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                'cmd3.ExecuteNonQuery()

                cmd4.Connection = hamplus.cn
                cmd4.CommandText = "insert into tblEdu (diary_ID) values (@id)"
                cmd4.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                cmd4.ExecuteNonQuery()

                cmd5.Connection = hamplus.cn
                cmd5.CommandText = "insert into tblHealth (diary_ID) values (@id)"
                cmd5.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                cmd5.ExecuteNonQuery()

                'cmd6.Connection = hamplus.cn
                'cmd6.CommandText = "insert into tblMemoLetter (diary_ID) values (@id)"
                'cmd6.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                'cmd6.ExecuteNonQuery()

                cmd7.Connection = hamplus.cn
                cmd7.CommandText = "insert into tblMobility (diary_ID) values (@id)"
                cmd7.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                cmd7.ExecuteNonQuery()

                'cmd8.Connection = hamplus.cn
                'cmd8.CommandText = "insert into c (diary_ID) values (@id)"
                'cmd8.Parameters.AddWithValue("@id", txtus.Text & " " & c)
                'cmd8.ExecuteNonQuery()


                Me.Close()
                LoginForm1.Show()
            Else
                Dim aaa As Integer = MsgBox("Your Registration is canceled. Please Start all over", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                Me.Close()
                LoginForm1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        Me.Hide()
        Dim aaa As Integer = MsgBox("Are you sure before clearing?", MsgBoxStyle.YesNo, Title:="Blinks Digital Diary")
        If aaa = MsgBoxResult.Yes Then
            txtadd.Text = ""
            txtbg.Text = ""
            txtemail.Text = Nothing
            txtgt.Text = ""
            txtn.Text = ""
            txtpass.Text = ""
            txtpn.Text = Nothing
            txtus.Text = Nothing
            txtwebsite.Text = ""
            ComboBox1.SelectedItem = ""
            PictureBox1.Image = Nothing
            DateTimePicker1.Text = Date.Now
        Else
            Me.Show()
        End If

    End Sub
End Class