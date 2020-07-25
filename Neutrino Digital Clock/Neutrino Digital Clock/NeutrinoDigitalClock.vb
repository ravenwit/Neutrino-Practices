Public Class NeutrinoDigitalClock
    'Move Stuff
    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False
    ''
    Public i As Integer = 1
    Public n As Integer = 1
    Dim msgH As String = "One Hour Passed..."
    Dim msgD As String = ("One Day Passed... Today is  " & FormatDateTime(DateAndTime.Now, DateFormat.LongDate)).ToString
    Dim voice
    Public AlarmShow As Boolean = False

    Private Sub NeutrinoDigitalClock_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        voice = CreateObject("sapi.spvoice")
        Timer1.Enabled = True
        Timer1.Interval = 100
        Label1.Font = My.Settings.Font
        Label1.ForeColor = My.Settings.ForeColor
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = My.Settings.clLocation
        If My.Settings.Transparent = True Then
            Me.BackColor = Color.Pink
            Me.Label1.BackColor = Color.Pink
            Me.BackgroundImage = Nothing
            Options.CheckBox1.Checked = True
        ElseIf My.Settings.Transparent = False Then
            Options.CheckBox1.Checked = False
            Select Case My.Settings.BackColorBool
                Case True
                    Me.BackColor = My.Settings.BackColor
                    Me.Label1.BackColor = My.Settings.BackColor
                    Me.BackgroundImage = Nothing
                Case False
                    Select Case My.Settings.BackgroundBool
                        Case True
                            Try
                                Me.BackgroundImageLayout = ImageLayout.Stretch
                                Me.Label1.BackColor = Color.Transparent
                                Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Background)
                            Catch ex As Exception
                                MsgBox("An error occured." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                                Me.BackColor = Color.Pink
                                Me.Label1.BackColor = Color.Pink
                                Me.BackgroundImage = Nothing
                            End Try
                        Case False
                            Me.BackColor = Color.Pink
                            Me.Label1.BackColor = Color.Pink
                            Me.BackgroundImage = Nothing
                    End Select
            End Select
        End If

        If My.Settings.ShowTop = True Then Me.TopMost = True Else Me.TopMost = False
        If My.Settings.AlertHour = True Or My.Settings.AlertDay = True Then BackgroundWorker1.RunWorkerAsync()
        If My.Settings.Tick = True Then
            Timer2.Enabled = True
            Timer2.Interval = 1000
            Options.chkBeep.Checked = False
        ElseIf My.Settings.Tick = False Then
            Timer2.Enabled = False
            Options.chkBeep.Checked = True
        End If

        Me.ShowInTaskbar = False
        Options.chkTaskbar.Checked = False
        Options.chkMiniSysTray.Checked = False

    End Sub

    Private Sub NeutrinoDigitalClock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.AlertDay = False
        My.Settings.AlertHour = False

        Timer1.Enabled = True
        Timer1.Interval = 100
        Label1.Font = My.Settings.Font
        Label1.ForeColor = My.Settings.ForeColor
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = My.Settings.clLocation
        If My.Settings.Transparent = True Then
            Me.BackColor = Color.Pink
            Me.Label1.BackColor = Color.Pink
            Me.BackgroundImage = Nothing
            Options.CheckBox1.Checked = True
        ElseIf My.Settings.Transparent = False Then
            Options.CheckBox1.Checked = False
            Select Case My.Settings.BackColorBool
                Case True
                    Me.BackColor = My.Settings.BackColor
                    Me.Label1.BackColor = My.Settings.BackColor
                    Me.BackgroundImage = Nothing
                Case False
                    Select Case My.Settings.BackgroundBool
                        Case True
                            Try
                                Me.BackgroundImageLayout = ImageLayout.Stretch
                                Me.Label1.BackColor = Color.Transparent
                                Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Background)
                            Catch ex As Exception
                                MsgBox("An error occured." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                                Me.BackColor = Color.Pink
                                Me.Label1.BackColor = Color.Pink
                                Me.BackgroundImage = Nothing
                            End Try
                        Case False
                            Me.BackColor = Color.Pink
                            Me.Label1.BackColor = Color.Pink
                            Me.BackgroundImage = Nothing
                    End Select
            End Select
        End If

        If My.Settings.ShowTop = True Then Me.TopMost = True Else Me.TopMost = False
        If My.Settings.AlertHour = True Or My.Settings.AlertDay = True Then BackgroundWorker1.RunWorkerAsync()

        If My.Settings.Tick = True Then
            Timer2.Enabled = True
            Timer2.Interval = 1000
            Options.chkBeep.Checked = False
        ElseIf My.Settings.Tick = False Then
            Timer2.Enabled = False
            Options.chkBeep.Checked = True
        End If

        Me.ShowInTaskbar = False
        Options.chkTaskbar.Checked = False
        Options.chkMiniSysTray.Checked = False
        voice = CreateObject("sapi.spvoice")

    End Sub

    Private Sub NeutrinoDigitalClock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, Label1.MouseDown
        Dim Offset_X As Integer
        Dim Offset_Y As Integer
        If e.Button = MouseButtons.Left Then
            Offset_X = -e.X - Label1.Location.X
            Offset_Y = -e.Y - Label1.Location.Y
            mouseOffset = New Point(Offset_X, Offset_Y)
            isMouseDown = True
        End If
    End Sub


    Private Sub NeutrinoDigitalClock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, Label1.MouseMove
        Dim mousePos As Point = Control.MousePosition
        If isMouseDown Then
            mousePos.Offset(mouseOffset)
            Location = mousePos
        End If
    End Sub

    Private Sub NeutrinoDigitalClock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, Label1.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
            My.Settings.clLocation = New Point(Me.Location.X, Me.Location.Y)
        End If
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = FormatDateTime(TimeOfDay, My.Settings.Time_Format) & vbCrLf & FormatDateTime(DateAndTime.Now.Date, My.Settings.Date_Format)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        My.Computer.Audio.Play(Application.StartupPath + "\beep.wav")
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

    End Sub


    Private Sub MinimizedToSystemTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizedToSystemTrayToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Calendar.Show()
    End Sub

    Private Sub MinimizedToSystemTrayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizedToSystemTrayToolStripMenuItem1.Click
        MinimizedToSystemTrayToolStripMenuItem.PerformClick()
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem1.Click
        OptionsToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Options.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        End
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        For i = 0 To 100
            Threading.Thread.Sleep(500)
            BackgroundWorker1.ReportProgress(i)
            If i = 100 Then i = 0
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If My.Settings.Alarm = True Then
            If (My.Settings.AlarmTime - TimeOfDay).Hours = 0 And (My.Settings.AlarmTime - TimeOfDay).Minutes = 1 And (My.Settings.AlarmTime - TimeOfDay).Seconds >= 0 And AlarmShow = False Or (My.Settings.AlarmTime - TimeOfDay).Minutes = 0 Then
                AlarmAlert.Show()
            End If
            If TimeOfDay.ToLongTimeString = My.Settings.AlarmTime.ToLongTimeString.ToString Then
                If My.Settings.AlarmCustom = True Then
                    If My.Settings.AlarmTone = True Then
                        If Not String.IsNullOrEmpty(My.Settings.AlarmPath) And My.Computer.FileSystem.FileExists(My.Settings.AlarmPath) Then
                            loadAndSetSoundFile(My.Settings.AlarmPath)
                            playSoundFile()
                        End If
                    ElseIf My.Settings.AlarmText = True Then
                        voice = CreateObject("sapi.spvoice")
                        If Not String.IsNullOrEmpty(My.Settings.AlarmPathText) Then voice.Speak(My.Settings.AlarmPathText)
                    End If
                ElseIf My.Settings.AlarmCustom = False Then
                    Try
                        loadAndSetSoundFile(My.Settings.AlarmPath)
                        playSoundFile()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
        If My.Settings.AlertDay = True And TimeOfDay.ToLongTimeString = "12:00:00 AM" Then
            NotifyIcon1.BalloonTipTitle = "Neutrino Digital Clock"
            NotifyIcon1.BalloonTipText = msgD
            NotifyIcon1.ShowBalloonTip(3000)
            voice.Speak(msgD)
        Else
            If My.Settings.AlertHour = True And TimeOfDay.Minute = 0 And TimeOfDay.Second = 0 Then
                NotifyIcon1.BalloonTipTitle = "Neutrino Digital Clock"
                NotifyIcon1.BalloonTipText = msgH
                NotifyIcon1.ShowBalloonTip(3000)
                voice.Speak(msgH)
            End If
        End If
    End Sub

    Private Sub ShowCalendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCalendarToolStripMenuItem.Click
        Calendar.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub ShowCalendarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCalendarToolStripMenuItem1.Click
        Calendar.Show()
    End Sub

    Private Sub AlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlarmToolStripMenuItem.Click
        Alarm.Show()
    End Sub
End Class
