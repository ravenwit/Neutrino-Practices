Imports System.Runtime.InteropServices
Public Class AlarmAlert

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Dim a = 10
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        stopSound()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim cDown As TimeSpan = My.Settings.AlarmTime - TimeOfDay
        lblAlarmCount.Text = (cDown.Hours & " : " & cDown.Minutes & " : " & cDown.Seconds).ToString
        If TimeOfDay = My.Settings.AlarmTime Or cDown.Hours = 0 And cDown.Minutes = 0 And cDown.Seconds = 0 Then
            btnOff.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub AlarmAlert_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case My.Settings.AlarmTheme
            Case 0
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Me.ShowInTaskbar = True
                Me.ControlBox = True
                Me.MinimizeBox = True
                Me.MaximizeBox = False
                Me.lblClose.Visible = False
                Me.lblMinimize.Visible = False
                If My.Settings.AlarmIsColor = True Then
                    If Not String.IsNullOrEmpty(My.Settings.AlarmColor.ToString) Then
                        Me.BackColor = My.Settings.AlarmColor
                        Me.BackgroundImage = Nothing
                    Else
                        Me.BackColor = Color.Black
                    End If
                ElseIf My.Settings.AlarmIsColor = False Then
                    If Not String.IsNullOrEmpty(My.Settings.AlarmImage) Then
                        Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.AlarmImage)
                    Else
                        Me.BackgroundImage = Nothing
                        If Not String.IsNullOrEmpty(My.Settings.AlarmColor.ToString) Then Me.BackColor = My.Settings.AlarmColor Else Me.BackColor = Color.Black
                    End If
                End If
            Case 1
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.ShowInTaskbar = False
                Me.ControlBox = False
                Me.MinimizeBox = False
                Me.MaximizeBox = False
                Me.lblClose.Visible = True
                Me.lblMinimize.Visible = True
                Me.BackgroundImage = My.Resources.Background
            Case 2
                Me.TransparencyKey = Color.Pink
                Me.BackColor = Color.Pink
                Me.BackgroundImage = Nothing
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Me.ShowInTaskbar = True
                Me.ControlBox = True
                Me.MinimizeBox = True
                Me.MaximizeBox = False
                Me.lblClose.Visible = False
                Me.lblMinimize.Visible = False
                Dim margins As MARGINS = New MARGINS
                margins.Left = -1
                margins.Right = -1
                margins.Top = -1
                margins.Bottom = -1
                Dim hwnd As IntPtr = Handle
                Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        End Select
        Timer1.Enabled = True
        btnOff.Enabled = False
    End Sub

    Private Sub Alarm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NeutrinoDigitalClock.AlarmShow = True
        Select Case My.Settings.AlarmTheme
            Case 0
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Me.ShowInTaskbar = True
                Me.ControlBox = True
                Me.MinimizeBox = True
                Me.MaximizeBox = False
                Me.lblClose.Visible = False
                Me.lblMinimize.Visible = False
                If My.Settings.AlarmIsColor = True Then
                    If Not String.IsNullOrEmpty(My.Settings.AlarmColor.ToString) Then
                        Me.BackColor = My.Settings.AlarmColor
                        Me.BackgroundImage = Nothing
                    Else
                        Me.BackColor = Color.Black
                    End If
                ElseIf My.Settings.AlarmIsColor = False Then
                    If Not String.IsNullOrEmpty(My.Settings.AlarmImage) Then
                        Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.AlarmImage)
                    Else
                        Me.BackgroundImage = Nothing
                        If Not String.IsNullOrEmpty(My.Settings.AlarmColor.ToString) Then Me.BackColor = My.Settings.AlarmColor Else Me.BackColor = Color.Black
                    End If
                End If
            Case 1
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.ShowInTaskbar = False
                Me.ControlBox = False
                Me.MinimizeBox = False
                Me.MaximizeBox = False
                Me.lblClose.Visible = True
                Me.lblMinimize.Visible = True
                Me.BackgroundImage = My.Resources.Background
            Case 2
                Me.TransparencyKey = Color.Pink
                Me.BackColor = Color.Pink
                Me.BackgroundImage = Nothing
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Me.ShowInTaskbar = True
                Me.ControlBox = True
                Me.MinimizeBox = True
                Me.MaximizeBox = False
                Me.lblClose.Visible = False
                Me.lblMinimize.Visible = False
                Dim margins As MARGINS = New MARGINS
                margins.Left = -1
                margins.Right = -1
                margins.Top = -1
                margins.Bottom = -1
                Dim hwnd As IntPtr = Handle
                Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        End Select
        lblAlarmText.Text = My.Settings.AlarmAlertText
        NeutrinoDigitalClock.AlarmShow = True
        Timer1.Enabled = True
        Timer1.Interval = 1
        btnOff.Enabled = False
        NotifyIcon1.Visible = False
    End Sub

    Private Sub AlarmAlert_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lblAlarmText.MouseDown, lblAlarmCount.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer
        If e.Button = MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub

    Private Sub AlarmAlert_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, lblAlarmCount.MouseMove, lblAlarmText.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub AlarmAlert_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, lblAlarmCount.MouseUp, lblAlarmText.MouseUp
        ' not move unless the user is pressing the left mouse button.
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub lblMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinimize.Click
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ShowAlarmInterfaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAlarmInterfaceToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

 
End Class