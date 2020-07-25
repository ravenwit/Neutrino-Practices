Public Class Calendar
    ' Move
    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False
    ''
    Dim c As Integer = 1
    Dim calocationX As Integer
    Dim calocationY As Integer

    Private Sub Calendar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = My.Settings.calendarLocation
        Me.MonthCalendar1.ShowToday = My.Settings.calendarSToday
        Me.MonthCalendar1.ShowTodayCircle = My.Settings.calendarCircle
        Me.MonthCalendar1.ShowWeekNumbers = My.Settings.calendarWeek
        Me.MonthCalendar1.CalendarDimensions = My.Settings.calendarDS
        Me.MonthCalendar1.MaxSelectionCount = My.Settings.calendarMaxSel
        Me.MonthCalendar1.FirstDayOfWeek = My.Settings.calendarFdayW
    End Sub

    Private Sub Calendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = My.Settings.calendarLocation
        Me.MonthCalendar1.ShowToday = My.Settings.calendarSToday
        Me.MonthCalendar1.ShowTodayCircle = My.Settings.calendarCircle
        Me.MonthCalendar1.ShowWeekNumbers = My.Settings.calendarWeek
        Me.MonthCalendar1.CalendarDimensions = My.Settings.calendarDS
        Me.MonthCalendar1.MaxSelectionCount = My.Settings.calendarMaxSel
        Me.MonthCalendar1.FirstDayOfWeek = My.Settings.calendarFdayW
    End Sub

    Private Sub Calendar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, MonthCalendar1.MouseDown
        Dim OffsetX As Integer
        Dim OffsetY As Integer
        If e.Button = MouseButtons.Left Then
            OffsetX = -e.X - MonthCalendar1.Location.X
            OffsetY = -e.Y - MonthCalendar1.Location.Y
            mouseOffset = New Point(OffsetX, OffsetY)
            isMouseDown = True
        End If
    End Sub

    Private Sub Calendar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, MonthCalendar1.MouseMove
        Dim mousePos As Point = Control.MousePosition
        If isMouseDown Then
            mousePos.Offset(mouseOffset)
            Location = mousePos
        End If
    End Sub

    Private Sub Calendar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, MonthCalendar1.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
            My.Settings.calendarLocation = New Point(Location.X, Location.Y)
            My.Settings.Save()
        End If
    End Sub

    Private Sub MinimizeTosystemTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Options.Show()
        Options.TabControl1.SelectedIndex = 2
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Options.Show()
        Options.TabControl1.SelectedIndex = 2
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Close()
    End Sub

    Private Sub MinimizeToSystemTrayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToSystemTrayToolStripMenuItem1.Click
        Me.Hide()
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem1.Click
        Options.Show()
        Options.TabControl1.SelectedIndex = 2
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()

    End Sub

End Class