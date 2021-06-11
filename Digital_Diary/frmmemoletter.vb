Imports System.Data.SqlClient
Public Class frmmemoletter

    Private Sub frmmemoletter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbCdate.Text = Date.Today
        Dim a, b, c As Integer
        Randomize()
        a = 2012
        b = Rnd(a) * 5112012
        c = b
        c = Mid(b, 2, 3)
        txtref.Text = LoginForm1.UsernameTextBox.Text + "/" + CStr(c) + "/" + Date.Now.ToShortDateString

    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "insert into tblMemoLetter (diary_ID,cdate,ldate,ref,urref," _
 & "recip,sub,cc,sms,DT)" _
            & "values (@did,@n,@dob,@dcid,@num,@em,@add,@bbp,@fd,@dt)"
            jp.Parameters.AddWithValue("@did", Main.Label2.Text)
            jp.Parameters.AddWithValue("@n", lbCdate.Text)
            jp.Parameters.AddWithValue("@dob", txtldate.Text)
            jp.Parameters.AddWithValue("@dcid", txtref.Text)
            jp.Parameters.AddWithValue("@num", txturref.Text)
            jp.Parameters.AddWithValue("@em", txtrecp.Text)
            jp.Parameters.AddWithValue("@add", txtsub.Text)
            jp.Parameters.AddWithValue("@bbp", txtcc.Text)
            jp.Parameters.AddWithValue("@fd", txtsms.Text)
            jp.Parameters.AddWithValue("@dt", antho.ServerDate)
            jp.ExecuteNonQuery()
            Me.Close()
            Dim a = MsgBox("Memo/Letter is saved successfully", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class