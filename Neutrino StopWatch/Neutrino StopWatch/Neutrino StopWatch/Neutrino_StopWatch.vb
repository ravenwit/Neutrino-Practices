Public Class Neutrino_StopWatch
    Dim mode As Integer = 0
    Dim start As Boolean = False
    Dim h As Integer = 0
    Dim m As Integer = 0
    Dim s As Integer = 0
    Dim ms As Integer = 0
    Dim TrickyTime As New DateTime
    Dim DiffSave As TimeSpan
    Dim Diff As TimeSpan
    Private Function ZeroSymmetry(ByVal Text As String, Optional ByVal ZeroQuan As Integer = 2) As String
        Select Case Text.Length
            Case 0
                If ZeroQuan = 2 Then Return "00" Else Return "000"
            Case 1
                If ZeroQuan = 2 Then Return ("0" & Text) Else Return ("00" & Text)
            Case 2
                If ZeroQuan = 2 Then Return Text Else Return ("0" & Text)
            Case 3
                If ZeroQuan = 3 Then Return Text
            Case Else
                Return Text
        End Select
        Return CDbl(True)
    End Function

    Private Sub Neutrino_StopWatch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblHour.Text = "00"
        lblMinute.Text = "00"
        lblSecond.Text = "00"
        lblMillisecond.Text = "00"
        Select Case My.Settings.IsBgColor
            Case True
                Me.BackColor = My.Settings.BgColor
                Me.BackgroundImage = Nothing
            Case False
                Select Case My.Settings.IsBgImage
                    Case True
                        Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.BgImage)
                        Me.BackgroundImageLayout = ImageLayout.Stretch
                    Case False
                        Me.BackgroundImage = Nothing
                        Me.BackColor = Color.Black
                End Select
        End Select
        For font_index As Integer = 0 To 6
            Panel1.Controls.Item(font_index).Font = My.Settings.Font
            Panel1.Controls.Item(font_index).ForeColor = My.Settings.Forecolor
        Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        DiffSave = TimeSpan.Zero
        ResetToolStripMenuItem.Enabled = False
        Panel1.Top = Me.Height / 4 + 100
        Panel1.Left = Me.Width / 4
    End Sub

    Private Sub Neutrino_StopWatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblHour.Text = "00"
        lblMinute.Text = "00"
        lblSecond.Text = "00"
        lblMillisecond.Text = "00"
        Select Case My.Settings.IsBgColor
            Case True
                Me.BackColor = My.Settings.BgColor
                Me.BackgroundImage = Nothing
            Case False
                Select Case My.Settings.IsBgImage
                    Case True
                        Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.BgImage)
                        Me.BackgroundImageLayout = ImageLayout.Stretch
                    Case False
                        Me.BackgroundImage = Nothing
                        Me.BackColor = Color.Black
                End Select
        End Select
        For font_index As Integer = 0 To 6
            Panel1.Controls.Item(font_index).Font = My.Settings.Font
            Panel1.Controls.Item(font_index).ForeColor = My.Settings.Forecolor
        Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        DiffSave = TimeSpan.Zero
        ResetToolStripMenuItem.Enabled = False
        Panel1.Top = Me.Height / 4 + 100
        Panel1.Left = Me.Width / 4


    End Sub

    Private Sub Neutrino_StopWatch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick, Panel1.Click, lbld1.Click, lbld2.Click, lbld3.Click, lblHour.Click, lblMillisecond.Click, lblMinute.Click, lblSecond.Click

        If start = False Then
            start = True
            StartToolStripMenuItem.Image = My.Resources._1333566219_stopwatch_pause
            StartToolStripMenuItem.Text = "Stop"
            ResetToolStripMenuItem.Enabled = False
            TrickyTime = DateTime.Now
            Timer1.Interval = 1
            Timer1.Enabled = True
        ElseIf start = True Then
            start = False
            StartToolStripMenuItem.Image = My.Resources._1333566198_stopwatch_start
            StartToolStripMenuItem.Text = "Start"
            DiffSave = Diff
            ResetToolStripMenuItem.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Neutrino_StopWatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then

            If start = False Then
                start = True
                StartToolStripMenuItem.Image = My.Resources._1333566219_stopwatch_pause
                StartToolStripMenuItem.Text = "Stop"
                ResetToolStripMenuItem.Enabled = False
                TrickyTime = DateTime.Now
                Timer1.Interval = 1
                Timer1.Enabled = True
            ElseIf start = True Then
                start = False
                StartToolStripMenuItem.Image = My.Resources._1333566198_stopwatch_start
                StartToolStripMenuItem.Text = "Start"
                DiffSave = Diff
                ResetToolStripMenuItem.Enabled = True
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        If start = False Then
            start = True
            StartToolStripMenuItem.Image = My.Resources._1333566219_stopwatch_pause
            StartToolStripMenuItem.Text = "Stop"
            ResetToolStripMenuItem.Enabled = False
            TrickyTime = DateTime.Now
            Timer1.Interval = 1
            Timer1.Enabled = True
        ElseIf start = True Then
            start = False
            StartToolStripMenuItem.Image = My.Resources._1333566198_stopwatch_start
            StartToolStripMenuItem.Text = "Start"
            DiffSave = Diff
            ResetToolStripMenuItem.Enabled = True
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        lblHour.Text = "00"
        lblMinute.Text = "00"
        lblSecond.Text = "00"
        lblMillisecond.Text = "00"
        DiffSave = TimeSpan.Zero
        ResetToolStripMenuItem.Enabled = False
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Dif As TimeSpan = DateTime.Now.Subtract(TrickyTime)
        Diff = Dif + DiffSave
        lblHour.Text = ZeroSymmetry(Diff.Hours.ToString, 2)
        lblMinute.Text = ZeroSymmetry(Diff.Minutes.ToString, 2)
        lblSecond.Text = ZeroSymmetry(Diff.Seconds.ToString, 2)
        lblMillisecond.Text = ZeroSymmetry(Math.Round(Diff.Milliseconds / 10))
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Neutrino_StopWatch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub SplitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitToolStripMenuItem.Click
        If LapToolStripMenuItem.Checked = True Then
            LapToolStripMenuItem.Checked = False
        End If
        mode = 1
    End Sub

    Private Sub LapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapToolStripMenuItem.Click
        If SplitToolStripMenuItem.Checked = True Then
            SplitToolStripMenuItem.Checked = False
        End If
        mode = 2
    End Sub

    Private Sub KryptonContextMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem1.Click
        If Not krpLstBox.SelectedItems.Count = 0 Then
            Dim selectedDatas = (From i In krpLstBox.SelectedItems).ToArray
            For Each selectedData In selectedDatas
                krpLstBox.Items.Remove(selectedData)
            Next
        Else
            MsgBox("Please first select at least one data from the list box.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub KryptonContextMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem2.Click
        Dim msg As MsgBoxResult = MsgBox("Are you sure you want to clear all data.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Clear")
        If msg = MsgBoxResult.Yes Then krpLstBox.Items.Clear() Else Exit Sub
    End Sub
End Class
