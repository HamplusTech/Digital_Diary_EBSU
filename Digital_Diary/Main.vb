Public Class Main

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyProfileToolStripMenuItem.Click
        frmmyprofile.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmcontact.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        frmcontact.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Application.Exit()
        Application.Restart()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        frmschedule.btnc.Enabled = False
        frmschedule.btnIg.Enabled = False
        frmschedule.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        frmalarm.btnIg.Enabled = False
        frmalarm.btnc.Enabled = False
        frmalarm.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        frmtodolist.btnc.Enabled = False
        frmtodolist.btnIg.Enabled = False
        frmtodolist.Show()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        AboutBox1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ToDoListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDoListToolStripMenuItem.Click
        frmtodolist.Show()
    End Sub
    Private Sub SchedulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulerToolStripMenuItem.Click
        frmschedule.Show()
    End Sub

    Private Sub AlarmToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlarmToolStripMenuItem1.Click
        frmalarm.Show()
    End Sub

    Private Sub ToDoListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDoListToolStripMenuItem1.Click
        frmtodolist.btnSave.Visible = False
        frmtodolist.Show()
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleToolStripMenuItem.Click
        frmschedule.btnSave.Visible = False
        frmschedule.Show()
    End Sub

    Private Sub AlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlarmToolStripMenuItem.Click
        frmalarm.btnSave.Visible = False
        frmalarm.Show()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        frmanniversary.btnc.Enabled = False
        frmanniversary.btnIg.Enabled = False
        frmanniversary.Show()
    End Sub

    Private Sub AnniversaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnniversaryToolStripMenuItem1.Click
        frmanniversary.Show()
    End Sub

    Private Sub AnniversaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnniversaryToolStripMenuItem.Click
        frmanniversary.btnSave.Visible = False
        frmanniversary.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        frmphonebook.Show()
    End Sub

    Private Sub PhoneBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneBookToolStripMenuItem.Click
        frmphonebook.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        frmweb.Show()
    End Sub

    Private Sub InterneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterneToolStripMenuItem.Click
        frmweb.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        frmmemoletter.Show()
    End Sub

    Private Sub MemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoToolStripMenuItem.Click
        frmmemoletter.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        frmsetting.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now
        Dim starttime As Date
        starttime = DateAndTime.TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Application.Exit()
        Application.Restart()
    End Sub
End Class
