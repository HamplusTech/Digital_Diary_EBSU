Imports System.Data.SqlClient
Public Class LoginForm1
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "jp" And PasswordTextBox.Text = "jpsoft" Then
            Main.Show()
            Me.Hide()
        Else
            Dim uju, jp As New DBops
            uju.DiaryConnect()
            jp.DiaryDT()
            Dim friends As SqlCommand
            friends = New SqlCommand("Select * from tblRegistration where username=@us and password=@pass", uju.cn)
            friends.Parameters.AddWithValue("@us", UsernameTextBox.Text)
            friends.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
            friends.ExecuteNonQuery()
            Dim rd As SqlDataReader
            rd = friends.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Main.PasswordLabel.Text = rd.Item("name")
                Main.Label2.Text = rd.Item("diary_ID")
                Main.Show()
                Me.Hide()
            Else
                MsgBox("Username and Password are Invalid", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim a As Integer = MsgBox("Do You Desire to Close Application?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
        If a = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now
        'Label2.Text = Date.Today.ToLongDateString
        Dim starttime As Date
        starttime = DateAndTime.TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label2.Text = Date.Today.ToLongDateString
            Dim uju, jp As New DBops
            uju.DiaryConnect()
            jp.DiaryDT()
            Dim friends As SqlCommand
            friends = New SqlCommand("Select * from tblSATA where date=@us", uju.cn)
            friends.Parameters.AddWithValue("@us", SplashScreen1.Label2.Text)
            friends.ExecuteNonQuery()
            Dim rd As SqlDataReader
            rd = friends.ExecuteReader
            If rd.HasRows = True Then
                Do While rd.Read
                    ListBox1.Items.Add(rd.Item("sub") & " (" & rd.Item("SATAtype") & ")")
                Loop
            Else
                ListBox1.Items.Add("No To-Do list For today.")
                ListBox1.Items.Add("No Schedule today.")
                ListBox1.Items.Add("No Alarm For today.")
                ListBox1.Items.Add("No Anniversary today.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim b = InputBox("Please Enter Your Diary ID", "Blinks Digital Diary", "Diary ID")
        Dim a = MsgBox("Are You Sure of the Diary ID?", MsgBoxStyle.YesNo, Title:="Samtech Digital Diary")
        If a = MsgBoxResult.Yes Then
            Dim uju, jp As New DBops
            uju.DiaryConnect()
            jp.DiaryDT()
            Dim friends As SqlCommand
            friends = New SqlCommand("Select * from tblRegistration where diary_ID=@us", uju.cn)
            friends.Parameters.AddWithValue("@us", b.ToString)
            friends.ExecuteNonQuery()
            Dim rd As SqlDataReader
            rd = friends.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Here are you login info are " & rd.Item("username") & " (as user name) and " & rd.Item("password") & " (as password)", Title:="Blinks Digital Diary")
            Else
                Dim aa = MsgBox("Wrong Diary ID", MsgBoxStyle.OkOnly, Title:="Samtech Digital Diary")
                InputBox("Please Enter Your Diary ID", "Blinks Digital Diary", "Diary ID")
            End If
        Else
            InputBox("Please Enter Your Diary ID. Please check and retype your Diary ID", "Samtech Digital Diary", "Diary ID")
        End If
    End Sub

    Private Sub GroupBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.Click
        Dim uju, jp As New DBops
        uju.DiaryConnect()
        jp.DiaryDT()
        Dim friends As SqlCommand
        friends = New SqlCommand("Select * from tblSATA where DT=@us", uju.cn)
        friends.Parameters.AddWithValue("@us", Label2.Text)
        friends.ExecuteNonQuery()
        Dim rd As SqlDataReader
        rd = friends.ExecuteReader
        Do While rd.Read
            ListBox1.Items.Add(rd.Item("sub"))
        Loop
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Dim uju, jp As New DBops
        uju.DiaryConnect()
        jp.DiaryDT()
        Dim friends As SqlCommand
        friends = New SqlCommand("Select * from tblSATA where DT=@us", uju.cn)
        friends.Parameters.AddWithValue("@us", Label2.Text)
        friends.ExecuteNonQuery()
        Dim rd As SqlDataReader
        rd = friends.ExecuteReader
        Do While rd.Read
            ListBox1.Items.Add(rd.Item("sub"))
        Loop
    End Sub
End Class
