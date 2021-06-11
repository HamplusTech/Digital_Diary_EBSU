Imports System.Data.SqlClient
Public Class frmphonebook

    Private Sub btnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        Me.Close()
    End Sub

    Private Sub frmphonebook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "select * from tblContacts where diary_ID= '" & Main.Label2.Text & "'"
            jp.ExecuteNonQuery()
            Dim papa As SqlDataReader
            papa = jp.ExecuteReader
            Do While papa.Read
                Dim lvi As ListViewItem
                lvi = ListView1.Items.Add(papa.Item("names"))
                lvi.SubItems.Add(papa.Item("num"))
                lvi.SubItems.Add(papa.Item("email"))
                lvi.SubItems.Add(papa.Item("bbping"))
                lvi.SubItems.Add(papa.Item("address"))
                lvi.SubItems.Add(papa.Item("grp"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            Dim anita, antho As New DBops
            anita.DiaryConnect()
            antho.DiaryDT()
            Dim jp As New SqlCommand
            jp.Connection = anita.cn
            jp.CommandText = "select * from tblContacts where diary_ID= '" & Main.Label2.Text & "' and names=@n or num=@num"
            jp.Parameters.AddWithValue("@n", txtname.Text)
            jp.Parameters.AddWithValue("@num", txtphone.Text)
            jp.ExecuteNonQuery()
            Dim papa As SqlDataReader
            papa = jp.ExecuteReader
            papa.Read()
            If papa.HasRows = True Then
                Dim lvi As ListViewItem
                lvi = ListView1.Items.Add(papa.Item("names"))
                lvi.SubItems.Add(papa.Item("num"))
                lvi.SubItems.Add(papa.Item("email"))
                lvi.SubItems.Add(papa.Item("bbping"))
                lvi.SubItems.Add(papa.Item("address"))
                lvi.SubItems.Add(papa.Item("fd"))
            Else
                Dim a = MsgBox("Invalid Contact.", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsort.Click
        If ComboBox1.Text = "Ascending(A - Z)" Then
            ListView1.Sorting = Windows.Forms.SortOrder.Ascending
        Else
            ListView1.Sorting = Windows.Forms.SortOrder.Descending
        End If
    End Sub

    Private Sub ComboBox1_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles ComboBox1.ChangeUICues
        If ComboBox1.Text = "Ascending(A - Z)" Then
            ListView1.Sorting = Windows.Forms.SortOrder.Ascending
        Else
            ListView1.Sorting = Windows.Forms.SortOrder.Descending
        End If
    End Sub
End Class