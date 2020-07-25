Public Class CountDown
    Public midif As Integer
    Public sdif As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim curr As Date
        Dim des As Date
        Dim tddif As Integer
        Dim hdif As Integer

        'curr = My.Computer.Clock.LocalTime.Date
        curr = My.Computer.Clock.LocalTime.Date
        'des = DateSerial(2012, 12, 21)
        des = My.Settings.DesDate
        tddif = DateDiff(DateInterval.Day, curr, des)
        If des < curr Then
            MsgBox("Please Enter a valid date. ")
        Else
            DateCalc(curr, des)
        End If
        '''''''''''' Hour, Minute and Second Calculation '''''''''''''''''''
        hdif = (TimeSerial(23, 0, 0).Hour - My.Computer.Clock.LocalTime.Hour)
        midif = (TimeSerial(23, 59, 59).Minute - My.Computer.Clock.LocalTime.Minute) + 1
        sdif = (TimeSerial(23, 59, 59).Second - My.Computer.Clock.LocalTime.Second) + 1
        '''''''''''''''''' Voice Alert '''''''''''''''''''''
        'Dim voice, msg
        'msg = tddif & " days remaining ."
        'voice = CreateObject("sapi.spvoice")
        'While hdif = 11 And midif = 60 And sdif = 60
        'voice.Speak(msg)
        'End While
        '''''''''''''''' Print Labels ''''''''''''''''''''''''''''''''''
        lbltDay.Text = tddif
        lblYear.Text = years
        lblMonth.Text = months
        lblDay.Text = days
        lblHour.Text = hdif & " : "
        lblMinute.Text = midif & " : "
        lblSecond.Text = sdif
        If hdif = 23 And midif = 60 And sdif = 60 Then
            Dim msg, voice
            msg = "Another day passed. You are getting closer to your desired date."
            NotifyIcon1.BalloonTipTitle = "Count Down"
            NotifyIcon1.BalloonTipText = msg
            NotifyIcon1.ShowBalloonTip(7000)
            voice = CreateObject("sapi.spvoice")
            voice.Speak(msg)
        End If
        
    End Sub

    Private Sub CountDown_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Options.CheckBox1.Checked = False
        Options.chkMiniSys.Checked = False
        Me.ShowInTaskbar = True
        If My.Settings.BeepSound = True Then
            Options.chkbeep.Checked = False
            Timer2.Enabled = True
        ElseIf My.Settings.BeepSound = False Then
            Options.chkbeep.Checked = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Options.Show()
    End Sub

    Private Sub lblSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSecond.Click

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()

    End Sub

    Private Sub SetDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDateToolStripMenuItem.Click
        Options.Show()
        Options.dcount.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Options.Show()
        Options.TabControl1.TabPages.Item(1).Focus()

    End Sub

    Private Sub AgeCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgeCalculatorToolStripMenuItem.Click
        Options.Show()
        Options.TabPage3.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub MonthViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthViewerToolStripMenuItem.Click
        MonthCalendar.Show()

    End Sub

   
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If midif = 60 And sdif = 60 Then
            My.Computer.Audio.Play(Application.StartupPath + "\beep.wav")
        End If

    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        Me.Show()
    End Sub


    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub


    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Options.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Options.Show()
        Options.dcount.Focus()

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Options.Show()
        Options.TabControl1.TabPages.Item(1).Focus()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        MonthCalendar.Show()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        End

    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If midif = 60 And sdif = 60 Then
            My.Computer.Audio.Play(Application.StartupPath + "\beep.wav")
        End If
    End Sub
End Class
