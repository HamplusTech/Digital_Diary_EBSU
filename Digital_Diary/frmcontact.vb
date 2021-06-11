Imports System.Data.SqlClient
Public Class frmcontact

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "insert into tblContacts (diary_ID,names,dob,diaryCID,num," _
 & "email,address,bbping,fd,grp,picture,DT)" _
            & "values (@did,@n,@dob,@dcid,@num,@em,@add,@bbp,@fd,@grp,@pic,@dt)"
            If Main.Label2.Text = "Name" Then
                jp.Parameters.AddWithValue("@did", Main.PasswordLabel.Text)
            Else
                jp.Parameters.AddWithValue("@did", Main.Label2.Text)
            End If
            jp.Parameters.AddWithValue("@n", txtn.Text)
            jp.Parameters.AddWithValue("@dob", DateTimePicker2.Text)
            jp.Parameters.AddWithValue("@dcid", txtdid.Text)
            jp.Parameters.AddWithValue("@num", txtno.Text)
            jp.Parameters.AddWithValue("@em", txtemail.Text)
            jp.Parameters.AddWithValue("@add", txtadd.Text)
            jp.Parameters.AddWithValue("@bbp", txtbbping.Text)
            jp.Parameters.AddWithValue("@fd", DateTimePicker1.Text)
            jp.Parameters.AddWithValue("@grp", cbogrp.Text)
            jp.Parameters.AddWithValue("@pic", PictureBox1.ImageLocation)
            jp.Parameters.AddWithValue("@dt", antho.ServerDate)
            jp.ExecuteNonQuery()
            Me.Close()
            Dim a = MsgBox("Contact is saved successfully", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnUploadcv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadcv.Click
        With OpenFileDialog1
            .Title = "Samtech Digital Diary | Select Picture File"
            .FileName = ""
            .Filter = "All Images (*.jpg;*.bmp;*.png;*.gif) |*.jpg;*.bmp;*.png;*.gif "
            .ShowDialog()
        End With
        If OpenFileDialog1.FileName.ToString <> "" Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIg.Click
        Me.Close()
    End Sub

    Private Sub frmcontact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b As Integer
        a = 2012
        Randomize()
        b = Rnd(a) * 42676 + 254653
        b = Mid(b, 2, 3)
        txtdid.Text = LoginForm1.UsernameTextBox.Text + CStr(b)
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        txtadd.Text = Nothing
        txtbbping.Text = Nothing
        txtemail.Text = ""
        txtn.Text = ""
        txtno.Text = Nothing
        DateTimePicker1.Text = TimeOfDay
        cbogrp.Text = ""
        DateTimePicker2.Text = DateTime.Today
        PictureBox1.ImageLocation = ""
        PictureBox1.Image = Nothing
    End Sub
End Class