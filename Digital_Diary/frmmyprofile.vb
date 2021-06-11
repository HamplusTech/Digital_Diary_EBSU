Imports System.Data.SqlClient
Public Class frmmyprofile

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        frmhealth.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        TextBox1.Text = "View"
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        TextBox1.Text = "Modify"
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        TextBox1.Text = "Delete"
    End Sub

    Private Sub btnref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnref.Click
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmbio.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        frmcontactinfo.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmedudata.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        frmmobility.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        frmlogininfo.Show()
    End Sub

    Private Sub frmmyprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim benson, rose As New DBops
        benson.DiaryConnect()
        rose.DiaryDT()
        Dim nkechi As New SqlCommand
        nkechi.Connection = benson.cn
        nkechi.CommandText = "select * from tblRegistration where name= '" & Main.PasswordLabel.Text & "'"
        nkechi.ExecuteNonQuery()
        Dim eva As SqlDataReader
        eva = nkechi.ExecuteReader
        eva.Read()
        If eva.HasRows = True Then
            PictureBox1.ImageLocation = eva.Item("picture")
            UsernameLabel.Text = eva.Item("diary_ID")
        ElseIf Main.PasswordLabel.Text = "HamplusTech" Then
            UsernameLabel.Text = "Hamplus"
            PictureBox1.ImageLocation = Nothing
        Else
            Application.Restart()
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Me.Hide()
        frmregistration.Show()
    End Sub
End Class