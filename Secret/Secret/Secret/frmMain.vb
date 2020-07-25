Public Class frmMain
    Protected Overrides ReadOnly Property Createparams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_INCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_INCLOSE
            Return cp
        End Get
    End Property

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Or e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.UserClosing Or e.CloseReason = CloseReason.WindowsShutDown Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Keys.LWin)) Or e.KeyChar = CChar(ChrW(Keys.RWin)) Or e.KeyChar = CChar(ChrW(Keys.Escape)) Or e.KeyChar = CChar(ChrW(Keys.ControlKey + Keys.Escape)) Then
            Me.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .ControlBox = False
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = My.Settings.MainForecolor
            With .btnAI
                .Font = My.Settings.MainFont
                .ForeColor = My.Settings.MainForecolor
                .Text = "&Account Information"
                .Focus()
            End With
            With .btnPD
                .Font = My.Settings.MainFont
                .ForeColor = My.Settings.MainForecolor
                .Text = "&Personal Diary"
            End With
            With .btnPI
                .Font = My.Settings.MainFont
                .ForeColor = My.Settings.MainForecolor
                .Text = "&Personal Information"
            End With
            .pnlBtn.Dock = DockStyle.Fill
        End With

    End Sub

    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click

    End Sub
End Class