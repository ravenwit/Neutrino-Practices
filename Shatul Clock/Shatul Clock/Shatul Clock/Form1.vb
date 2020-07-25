Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Public Class frmShatul_Clock
    Dim mouseOffset As Point
    Dim mouseOffsetTrouble As Point
    Dim isMouseDown As Boolean = False
    Dim blnStartup As Boolean = True
    Dim voice
    Private Function Potash(ByVal number As Integer)
        If number >= 13 Then
            number = number - 12
        ElseIf number = 0 Then
            number = 12
        ElseIf number <= 12 Then
            number = number
        End If
        Return number
    End Function

    Private Sub frmShatul_Clock_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If blnStartup = True Then
            Dim regkey As Microsoft.Win32.RegistryKey
            Dim keyname As String = "Software\Microsoft\Windows\CurrentVersion\Run"
            Dim valuename As String = "Windows Application"
            Dim value As String = Application.ExecutablePath
            regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyname, True)
            regkey.SetValue(valuename, value, RegistryValueKind.String)
            blnStartup = False
        End If
        Me.ControlBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Location = My.Settings.clLocation
        Me.Size = New Size(150, 140)
        Me.Font = My.Settings.MainFont
        Me.ForeColor = My.Settings.MainForeColor
        Me.lblTime.Font = My.Settings.MainFont
        Me.lblTime.ForeColor = My.Settings.MainForeColor
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 500
        Me.ttpTime.ToolTipIcon = ToolTipIcon.Info
        Me.ttpTime.IsBalloon = True
        Me.tmrAlert.Enabled = True
        Me.tmrAlert.Interval = 1000
        Me.ShowInTaskbar = False
        voice = CreateObject("sapi.spvoice")
    End Sub

    Private Sub frmShatul_Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If blnStartup = True Then
            Dim regkey As Microsoft.Win32.RegistryKey
            Dim keyname As String = "Software\Microsoft\Windows\CurrentVersion\Run"
            Dim valuename As String = "Windows Application"
            Dim value As String = Application.ExecutablePath
            regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyname, True)
            regkey.SetValue(valuename, value, RegistryValueKind.String)
            blnStartup = False
        End If
        Me.ControlBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Location = My.Settings.clLocation
        Me.Size = New Size(150, 140)
        Me.Font = My.Settings.MainFont
        Me.ForeColor = My.Settings.MainForeColor
        Me.lblTime.Font = My.Settings.MainFont
        Me.lblTime.ForeColor = My.Settings.MainForeColor
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 500
        Me.ttpTime.ToolTipIcon = ToolTipIcon.Info
        Me.ttpTime.IsBalloon = True
        Me.tmrAlert.Enabled = True
        Me.tmrAlert.Interval = 1000
        Me.ShowInTaskbar = False
        voice = CreateObject("sapi.spvoice")

    End Sub

    Private Sub frmShatul_Clock_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim Offset_X As Integer
        Dim Offset_Y As Integer
        If e.Button = MouseButtons.Left Then
            Offset_X = -e.X
            Offset_Y = -e.Y
            mouseOffset = New Point(Offset_X, Offset_Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub frmShatul_Clock_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim mousePos As Point = Control.MousePosition
        If isMouseDown Then
            mousePos.Offset(mouseOffset)
            Location = mousePos
        End If
    End Sub

    Private Sub frmShatul_Clock_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
            My.Settings.clLocation = New Point(Me.Location.X, Me.Location.Y)
        End If
        My.Settings.Save()
    End Sub

    Private Sub lblTime_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTime.MouseDown
        Dim Offset_X As Integer
        Dim Offset_Y As Integer
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = True
            Offset_X = -e.X - lblTime.Location.X
            Offset_Y = -e.Y - lblTime.Location.Y
            mouseOffsetTrouble = New Point(Offset_X, Offset_Y)
        End If
    End Sub

    Private Sub lblTime_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTime.MouseMove
        Dim mousePos As Point = Control.MousePosition
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If isMouseDown = True Then
                mousePos.Offset(mouseOffsetTrouble)
                Location = mousePos
            End If
        End If
    End Sub

    Private Sub lblTime_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTime.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
            My.Settings.clLocation = Me.Location
        End If
        My.Settings.Save()
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        Me.lblTime.Text = FormatDateTime(TimeOfDay, DateFormat.LongTime) & vbCrLf & vbCrLf & FormatDateTime(DateAndTime.Now.Date, DateFormat.ShortDate)
    End Sub

    Private Sub tmrAlert_Tick(sender As Object, e As EventArgs) Handles tmrAlert.Tick
        If My.Settings.AlertHour = True Then
            If Val(DateAndTime.Now.Hour.ToString) <> 0 And Val(DateAndTime.Now.Minute.ToString) = 0 And Val(DateAndTime.Now.Second.ToString) = 0 Then
                NotifyIcon1.BalloonTipTitle = "Shatul Clock Hourly Announcement"
                NotifyIcon1.BalloonTipText = vbCrLf & "Now the time is " & DateAndTime.Now.ToLongTimeString & vbCrLf & vbCrLf & "Today is  " & DateAndTime.Now.ToLongDateString
                NotifyIcon1.ShowBalloonTip(3000)
                voice.speak("Now the time is" & Potash(DateAndTime.Now.Hour).ToString & " O' Clock")
            End If
        End If
        If My.Settings.AlertDay = True Then
            If Val(DateAndTime.Now.Hour.ToString) = 0 And Val(DateAndTime.Now.Minute.ToString) = 0 And Val(DateAndTime.Now.Second.ToString) = 0 Then
                NotifyIcon1.BalloonTipTitle = "Shatul Clock Daily Announcement"
                NotifyIcon1.BalloonTipText = vbCrLf & "Now the time is " & DateAndTime.Now.ToLongTimeString & vbCrLf & vbCrLf & "Today is  " & DateAndTime.Now.ToLongDateString
                NotifyIcon1.ShowBalloonTip(3000)
                voice.speak("Today is " & FormatDateTime(DateAndTime.Now.ToLongDateString, DateFormat.LongDate).ToString)
            End If
        End If
        Me.ttpTime.SetToolTip(Me.lblTime, FormatDateTime(DateAndTime.Now.Date, DateFormat.LongDate))
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        End
    End Sub

    Private Sub GhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GhToolStripMenuItem.Click
        Dim gf As New FontDialog
        gf.ShowColor = True
        gf.ShowEffects = True
        gf.Color = Color.Blue
        gf.Font = My.Settings.MainFont
        gf.ShowApply = True
        Try
            If gf.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.MainFont = gf.Font
                Me.lblTime.Font = My.Settings.MainFont
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
    End Sub

    Private Sub ForecolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForecolorToolStripMenuItem.Click
        Dim fore As New ColorDialog
        fore.AllowFullOpen = True
        fore.AnyColor = True
        fore.Color = My.Settings.MainForeColor
        fore.FullOpen = True
        Try
            If fore.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.MainForeColor = fore.Color
                lblTime.ForeColor = My.Settings.MainForeColor
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
    End Sub
End Class
