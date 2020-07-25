Public Class Options

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If FontDialog1.ShowDialog = DialogResult.OK Then
            My.Settings.Font = FontDialog1.Font
            NeutrinoDigitalClock.Label1.Font = FontDialog1.Font
            My.Settings.Save()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim fore_color As System.Drawing.Color
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            fore_color = ColorDialog1.Color
            My.Settings.ForeColor = fore_color
            NeutrinoDigitalClock.Label1.ForeColor = fore_color
            My.Settings.Save()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Harry Potter" Then
            NeutrinoDigitalClock.Label1.Font = My.Settings.Harry_PotterF
            NeutrinoDigitalClock.Label1.ForeColor = My.Settings.Harry_PotterC
            My.Settings.Font = My.Settings.Harry_PotterF
            My.Settings.ForeColor = My.Settings.Harry_PotterC
            My.Settings.Save()

        ElseIf ComboBox1.SelectedItem = "Matrix" Then
            NeutrinoDigitalClock.Label1.Font = My.Settings.MatrixF
            NeutrinoDigitalClock.Label1.ForeColor = My.Settings.MatrixC
            My.Settings.Font = My.Settings.MatrixF
            My.Settings.ForeColor = My.Settings.MatrixC
            My.Settings.Save()

        End If
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            NeutrinoDigitalClock.BackColor = Color.Pink
            NeutrinoDigitalClock.Label1.BackColor = Color.Pink
            My.Settings.Transparent = True
            Button3.Enabled = False
            Button4.Enabled = False
            My.Settings.Save()
            NeutrinoDigitalClock.Select()
        ElseIf CheckBox1.Checked = False Then
            'NeutrinoDigitalClock.BackColor = My.Settings.BackColor
            'NeutrinoDigitalClock.Label1.BackColor = My.Settings.BackColor
            Button3.Enabled = True
            Button4.Enabled = True
            My.Settings.Transparent = False
            My.Settings.Save()
            NeutrinoDigitalClock.Select()
        End If


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim backcolor As System.Drawing.Color
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            backcolor = ColorDialog1.Color
            My.Settings.BackgroundBool = False
            My.Settings.BackColorBool = True
            My.Settings.BackColor = backcolor
            My.Settings.Save()
            NeutrinoDigitalClock.BackColor = backcolor
            NeutrinoDigitalClock.Label1.BackColor = backcolor
            NeutrinoDigitalClock.Select()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBeep.CheckedChanged
        If chkBeep.Checked = True Then
            My.Settings.Tick = False
            My.Settings.Save()
            NeutrinoDigitalClock.Timer2.Enabled = False
        ElseIf chkBeep.Checked = False Then
            My.Settings.Tick = True
            My.Settings.Save()
            NeutrinoDigitalClock.Timer2.Enabled = True
            NeutrinoDigitalClock.Timer2.Interval = 1000

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTaskbar.CheckedChanged
        If chkTaskbar.Checked = True Then
            Me.ShowInTaskbar = True
        ElseIf chkTaskbar.Checked = False Then
            Me.ShowInTaskbar = False

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMiniSysTray.CheckedChanged
        If chkMiniSysTray.Checked = True Then
            Me.Close()
        ElseIf chkMiniSysTray.Checked = False Then
            Me.Show()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim background_path As String
        OpenFileDialog1.Title = "Select Image..."
        OpenFileDialog1.Filter = "All Files |*.*"
        Try
                       If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                background_path = OpenFileDialog1.FileName
                My.Settings.Background = background_path
                NeutrinoDigitalClock.BackgroundImage = System.Drawing.Image.FromFile(background_path)
                NeutrinoDigitalClock.BackgroundImageLayout = ImageLayout.Zoom
                NeutrinoDigitalClock.Label1.BackColor = Color.Transparent
                My.Settings.BackgroundBool = True
                My.Settings.BackColorBool = False
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox("Sorry! An error occured to select image." & vbCrLf & ex.Message)
        End Try

        NeutrinoDigitalClock.Select()

    End Sub


    Private Sub chkAlertHour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlertHour.CheckedChanged
        If chkAlertHour.Checked = True Then
            My.Settings.AlertHour = True
        ElseIf chkAlertHour.Checked = False Then
            My.Settings.AlertHour = False
        End If
        My.Settings.Save()
        NeutrinoDigitalClock.Select()

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkday.CheckedChanged
        If chkday.Checked = True Then
            My.Settings.AlertDay = True
        ElseIf chkday.Checked = False Then
            My.Settings.AlertDay = False
        End If
        My.Settings.Save()
        NeutrinoDigitalClock.Select()

    End Sub

    Private Sub chkTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTop.CheckedChanged
        If chkTop.Checked = True Then
            My.Settings.ShowTop = True
        ElseIf chkTop.Checked = False Then
            My.Settings.ShowTop = False
        End If
        My.Settings.Save()
        NeutrinoDigitalClock.Select()
    End Sub

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.ComboBox2.SelectedItem = "Tile"
        If My.Settings.Tick = True Then chkBeep.Checked = False Else chkBeep.Checked = True
        If My.Settings.AlertHour = True Then chkAlertHour.Checked = False Else chkAlertHour.Checked = True
        If My.Settings.AlertDay = True Then chkday.Checked = False Else chkday.Checked = True
        If My.Settings.calendarSToday = True Then chkShowToday.Checked = True Else chkShowToday.Checked = False
        If My.Settings.calendarCircle = True Then chkTodayCircle.Checked = True Else chkTodayCircle.Checked = False
        If My.Settings.calendarWeek = True Then chkShowWeek.Checked = True Else chkShowWeek.Checked = False
        If My.Settings.Transparent = True Then
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            Button3.Enabled = True
            Button4.Enabled = True
        End If
        nmuDimensionWidth.Value = My.Settings.calendarDS.Width
        nmuDimensionHeight.Value = My.Settings.calendarDS.Height
        nmuMaxSelection.Value = My.Settings.calendarMaxSel
        cmbFirstDayWeek.SelectedItem = My.Settings.calendarFdayW.ToString
        cmbTimeFormat.SelectedItem = My.Settings.Time_Format.ToString
        cmbDateFormat.SelectedItem = My.Settings.Date_Format.ToString

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                NeutrinoDigitalClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Case 1
                NeutrinoDigitalClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
            Case 2
                NeutrinoDigitalClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Case 3
                NeutrinoDigitalClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Case 4
                NeutrinoDigitalClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        End Select
        NeutrinoDigitalClock.Refresh()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmuDimensionWidth.ValueChanged
        On Error Resume Next
        Calendar.MonthCalendar1.CalendarDimensions = New Size(nmuDimensionWidth.Value, nmuDimensionHeight.Value)
        My.Settings.calendarDS = New Size(nmuDimensionWidth.Value, nmuDimensionHeight.Value)
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub nmuDimensionHeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmuDimensionHeight.ValueChanged
        On Error Resume Next
        Calendar.MonthCalendar1.CalendarDimensions = New Size(nmuDimensionWidth.Value, nmuDimensionHeight.Value)
        My.Settings.calendarDS = New Size(nmuDimensionWidth.Value, nmuDimensionHeight.Value)
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub dtpTodayDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTodayDate.ValueChanged
        On Error Resume Next
        Calendar.MonthCalendar1.TodayDate = dtpTodayDate.Value

    End Sub

    Private Sub cmbFirstDayWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFirstDayWeek.SelectedIndexChanged
        Select Case cmbFirstDayWeek.SelectedIndex
            Case 0
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Default
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Default
            Case 1
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Saturday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Saturday
            Case 2
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Sunday
            Case 3
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Monday
            Case 4
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Tuesday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Tuesday
            Case 5
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Wednesday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Wednesday
            Case 6
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Thursday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Thursday
            Case 7
                Calendar.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Friday
                My.Settings.calendarFdayW = System.Windows.Forms.Day.Friday
        End Select
        Calendar.Select()
    End Sub

    Private Sub nmuMaxSelection_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmuMaxSelection.ValueChanged
        On Error Resume Next
        Calendar.MonthCalendar1.MaxSelectionCount = nmuMaxSelection.Value
        My.Settings.calendarMaxSel = nmuMaxSelection.Value
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub chkShowToday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowToday.CheckedChanged
        If chkShowToday.Checked = True Then My.Settings.calendarSToday = True Else My.Settings.calendarSToday = False
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub chkTodayCircle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodayCircle.CheckedChanged
        If chkTodayCircle.Checked = True Then My.Settings.calendarCircle = True Else My.Settings.calendarCircle = False
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub chkShowWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowWeek.CheckedChanged
        If chkShowWeek.Checked = True Then My.Settings.calendarWeek = True Else My.Settings.calendarWeek = False
        My.Settings.Save()
        Calendar.Select()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTimeFormat.SelectedIndexChanged
        Select Case cmbTimeFormat.SelectedIndex
            Case 0
                My.Settings.Time_Format = Microsoft.VisualBasic.DateFormat.GeneralDate
            Case 1
                My.Settings.Time_Format = Microsoft.VisualBasic.DateFormat.LongTime
            Case 2
                My.Settings.Time_Format = Microsoft.VisualBasic.DateFormat.ShortTime

        End Select
        My.Settings.Save()
    End Sub

    Private Sub cmbDateFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDateFormat.SelectedIndexChanged
        Select Case cmbDateFormat.SelectedIndex
            Case 0
                My.Settings.Date_Format = Microsoft.VisualBasic.DateFormat.GeneralDate
            Case 1
                My.Settings.Date_Format = Microsoft.VisualBasic.DateFormat.LongDate
            Case 2
                My.Settings.Date_Format = Microsoft.VisualBasic.DateFormat.ShortDate

        End Select
        My.Settings.Save()
    End Sub

End Class