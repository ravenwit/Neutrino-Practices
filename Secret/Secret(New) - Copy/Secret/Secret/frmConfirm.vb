#Region "Imports"
Imports System.IO
Imports System.Management
Imports DevComponents.DotNetBar
Imports System.Drawing.Drawing2D
#End Region

Public Class frmConfirm

#Region "Declarations"

#Region "Form Control"

    Dim voice = CreateObject("sapi.spvoice")
    Dim i As Integer = 1
    Dim j As Integer = 1
    Public k As Integer = 0
    Dim i2 As Integer = 1
    Dim h As Boolean = True
    Dim h1 As Boolean = True
    Dim blnMsgConfirm As Boolean = False
    Dim msgVoice As Boolean = True
    Dim CreatedPath = False
    Dim bc As Boolean = False
    Dim CanDrawLoginBox As Boolean = True
    Dim identity As String = My.Settings.Identiy
    Dim password As String = My.Settings.IdentificationCode
    Public msg() As String = {"Confirm Your Identification First", "Identification Confirmed " & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf, ("Greetings Shakir!" & vbCrLf & vbCrLf & vbCrLf & "Platinum Welcomes You!" & vbCrLf & vbCrLf & vbCrLf & "Platinum wants your permission to procced.").ToString, "Invalid identification data." & vbCrLf}

#End Region

#Region "From Drawing (Login Confirmation)"

    Dim CircularProgressBars(17) As CustomCircularProgress
    Public PathColor As Color = Color.FromArgb(0, 19, 77)
    Dim PathBrush As New SolidBrush(PathColor)
    Dim CheckPathBrush As New SolidBrush(CheckPathColor)
    Public CheckPathColor As Color = Color.LimeGreen
    Dim points As Point() = {New Point(1360, 360), New Point(1040, 360), New Point(1040, 80), New Point(780, 80), _
                             New Point(780, 640), New Point(1060, 640), New Point(1060, 700), New Point(620, 700), New Point(620, 540), _
                             New Point(180, 540), New Point(180, 500), New Point(480, 500), New Point(480, 180), New Point(440, 180), _
                             New Point(440, 400), New Point(240, 400), New Point(240, 240), New Point(0, 240)}

#End Region

#End Region

#Region "System Essentials"

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Protected Overrides ReadOnly Property Createparams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_INCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_INCLOSE
            Return cp
        End Get
    End Property

#End Region

#Region "Custom Functions"

    Private Sub SetCheckPathColor(ByVal Color As Color)
        CheckPathColor = Color
        CheckPathBrush.Color = Color
    End Sub

    Private Sub PreventDrawingBox()
        If h Then
            CanDrawLoginBox = False
            Me.CreateGraphics.Clear(Color.Black)
            h = False
        End If
    End Sub

    Private Sub HideProgressBar()
        If h1 Then
            For i As Integer = 0 To 17
                CircularProgressBars(i).Hide()
            Next
            lblUser.Hide()
            txtUser.Hide()
            lblPassword.Hide()
            txtPassword.Hide()
            h1 = False
        End If
    End Sub

#End Region

#Region "frmConfirm Components"

    Private Sub frmConfirm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.LWin Or Keys.RWin Or Keys.Escape Or (Keys.ControlKey And Keys.Escape) Then
            e.Handled = True
            Me.Focus()
        End If
    End Sub

    Private Sub frmConfirm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If CanDrawLoginBox Then
            Dim brusht As New HatchBrush(HatchStyle.Percent90, Drawing.Color.FromArgb(120, 255, 150), Drawing.Color.Black)
            Dim brufg As New SolidBrush(Drawing.Color.FromArgb(120, 255, 150))
            e.Graphics.DrawRectangle(New Pen(brusht, 10), New Rectangle(New Point(332, 330), New Size(717, 157)))
        End If
    End Sub

    Private Sub frmConfirm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CanDrawLoginBox = True
        h = True
        h1 = True
        With Me
            .ControlBox = False
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = Color.Lime
            With .lblIdentity
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .TextAlign = ContentAlignment.MiddleCenter
                .Visible = True
            End With
            With .lblUser
                .Text = "Identity :"
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .Location = New Point(369, 370)
                .Visible = True
            End With
            With .lblPassword
                .Text = "Identification Code :"
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .Location = New Point(369, 425)
                .Visible = True
            End With
            With txtUser
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .ContextMenuStrip = ContextMenuStrip1
                .Focus()
                .TabIndex = 1
                .Location = New Point(570, 370)
                .Visible = True
            End With
            With txtPassword
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .ContextMenuStrip = ContextMenuStrip1
                .PasswordChar = "*"
                .TabIndex = 2
                .Location = New Point(570, 425)
                .Visible = True
            End With
            Confirmation = Confirmed.Unknown
            blnMsgConfirm = False
            .tmrConfirm.Enabled = True
            .tmrConfirm.Interval = 70
            .tmrDraw.Interval = 1
            .tmrDraw.Enabled = False
        End With

        For i As Integer = 0 To 17
            CircularProgressBars(i) = New CustomCircularProgress
            CircularProgressBars(i).Location = New Point(points(i).X - 15, points(i).Y - 15)
            Me.Controls.Add(CircularProgressBars(i))
            CircularProgressBars(i).Visible = False
        Next

    End Sub

    Private Sub frmConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CanDrawLoginBox = True
        h = True
        h1 = True
        With Me
            .ControlBox = False
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = Color.Lime
            With .lblIdentity
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .TextAlign = ContentAlignment.MiddleCenter
            End With
            With .lblUser
                .Text = "Identity :"
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .Location = New Point(369, 370)
                .Visible = True
            End With
            With .lblPassword
                .Text = "Identification Code :"
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .Location = New Point(369, 425)
                .Visible = True
            End With
            With txtUser
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .ContextMenuStrip = ContextMenuStrip1
                .Focus()
                .TabIndex = 1
                .Location = New Point(570, 370)
                .Visible = True
            End With
            With txtPassword
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                .ContextMenuStrip = ContextMenuStrip1
                .PasswordChar = "*"
                .TabIndex = 2
                .Location = New Point(570, 425)
                .Visible = True
            End With
            Confirmation = Confirmed.Unknown
            blnMsgConfirm = False
            .tmrConfirm.Enabled = True
            .tmrConfirm.Interval = 70
            .tmrDraw.Interval = 1
            .lblTime.Visible = True
            .lblDate.Visible = True
        End With

        For i As Integer = 0 To 17
            CircularProgressBars(i) = New CustomCircularProgress
            CircularProgressBars(i).Location = New Point(points(i).X - 15, points(i).Y - 15)
            Me.Controls.Add(CircularProgressBars(i))
            CircularProgressBars(i).Visible = False
        Next

    End Sub

    Private Sub frmConfirm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.Activate()
    End Sub

    Private Sub frmConfirm_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Activate()
        Me.Focus()
    End Sub

#End Region

#Region "Timers"

    Private Sub tmrConfirm_Tick(sender As Object, e As EventArgs) Handles tmrConfirm.Tick
        If Confirmation = Confirmed.Yes Then
            PreventDrawingBox()
            HideProgressBar()
            lblIdentity.Visible = True
            lblIdentity.Dock = DockStyle.Fill
            lblIdentity.AutoSize = False
            lblIdentity.TextAlign = ContentAlignment.MiddleCenter

            If i < Len(msg(1)) Then
                lblIdentity.Text = Mid(msg(1), 1, i) & "_"
                i += 1
            ElseIf i = Len(msg(1)) Then
                If k < 30 Then
                    k += 1
                    lblIdentity.Text = msg(1)
                ElseIf k = 30 Then
                    If j < Len(msg(2)) Then
                        lblIdentity.Text = Mid(msg(2), 1, j) & "_"
                        j += 1
                    ElseIf j = Len(msg(2)) Then
                        lblIdentity.Text = msg(2)
                    End If
                End If
            End If
        ElseIf Confirmation = Confirmed.No Then
            PreventDrawingBox()
            HideProgressBar()
            lblIdentity.Visible = True
            lblIdentity.Dock = DockStyle.Fill
            lblIdentity.AutoSize = False
            lblIdentity.TextAlign = ContentAlignment.MiddleCenter
            Select Case i2
                Case Is < Len(msg(3))
                    bc = False
                    lblIdentity.Text = Mid(msg(3), 1, i2) & "_"
                    i2 += 1
                Case Is = Len(msg(3))
                    lblIdentity.Text = Mid(msg(3), 1, i2)
                    lblIdentity.Hide()
                    MatrixEffect(Me, Effect.Screen)
                    tmrConfirm.Enabled = False
            End Select
        ElseIf Confirmation = Confirmed.Unknown Then
            If blnMsgConfirm Then
                If txtUser.Text = identity And txtPassword.Text = password Then
                    SetCheckPathColor(Color.LimeGreen)
                    PreventDrawingBox()
                    tmrDraw.Enabled = True
                End If
            Else
                If i <= Len(msg(0)) Then
                    lblIdentity.Text = Mid(msg(0).ToString, 1, i) & "_"
                    i = i + 1
                ElseIf i > Len(msg(0)) Then
                    lblIdentity.Text = msg(0).ToString
                    blnMsgConfirm = True
                    i = 1
                End If
            End If
        End If
        Me.Focus()
    End Sub

    
#Region "Form Drawing"

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        lblIdentity.Hide()
        lblPassword.Hide()
        lblPlatinum.Hide()
        lblUser.Hide()
        txtUser.Hide()
        txtPassword.Hide()
        Dim g As Graphics = Me.CreateGraphics
        Static progress = 10
        Static index = 0
        Static CurrPos As Point = points(0)
        If CreatedPath Then
            CircularProgressBars(index).ProgressColor = CheckPathColor
            Select Case CurrPos.X
                Case 0
                    CircularProgressBars(CircularProgressBars.Count - 1).ProgressColor = CheckPathColor
                    If CheckPathColor = Color.LimeGreen Then Confirmation = Confirmed.Yes Else Confirmation = Confirmed.No
                    tmrDraw.Enabled = False
                Case Is = points(index + 1).X
                    If Not CurrPos.Y = points(index + 1).Y Then
                        If CurrPos.Y < points(index + 1).Y Then
                            CurrPos.Y += 10
                        ElseIf CurrPos.Y > points(index + 1).Y Then
                            CurrPos.Y -= 10
                        End If
                        g.DrawLine(New Pen(CheckPathBrush, 4), points(index), CurrPos)
                    Else
                        index += 1
                    End If
                Case Else
                    If Not CurrPos.X = points(index + 1).X Then
                        If CurrPos.X < points(index + 1).X Then
                            CurrPos.X += 10
                        ElseIf CurrPos.X > points(index + 1).X Then
                            CurrPos.X -= 10
                        End If
                        g.DrawLine(New Pen(CheckPathBrush, 4), points(index), CurrPos)
                    Else
                        index += 1
                    End If
            End Select
        Else
            If CircularProgressBars(index).Value = CircularProgressBars(index).Maximum Then
                If index = points.Count - 1 Then
                    CreatedPath = True
                    index = 0
                    CurrPos = points(0)
                End If
                Select Case CurrPos.X
                    Case Is = points(index + 1).X
                        If Not CurrPos.Y = points(index + 1).Y Then
                            If CurrPos.Y < points(index + 1).Y Then
                                CurrPos.Y += 20
                            ElseIf CurrPos.Y > points(index + 1).Y Then
                                CurrPos.Y -= 20
                            End If
                            g.DrawLine(New Pen(PathBrush, 3), points(index), CurrPos)
                        Else
                            index += 1
                        End If
                    Case Else
                        If Not CurrPos.X = points(index + 1).X Then
                            If CurrPos.X < points(index + 1).X Then
                                CurrPos.X += 20
                            ElseIf CurrPos.X > points(index + 1).X Then
                                CurrPos.X -= 20
                            End If
                            g.DrawLine(New Pen(PathBrush, 3), points(index), CurrPos)
                        Else
                            index += 1
                        End If
                End Select
            ElseIf CircularProgressBars(index).Value < CircularProgressBars(index).Maximum Then
                CircularProgressBars(index).Visible = True
                CircularProgressBars(index).Value += progress
            End If
        End If

    End Sub

#End Region

#End Region

#Region "Login Check"

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUser.Text = identity And txtPassword.Text = password Then
                SetCheckPathColor(Color.LimeGreen)
            Else
                SetCheckPathColor(Color.Red)
            End If
            PreventDrawingBox()
            Me.CreateGraphics.Clear(Color.Black)
            tmrDraw.Enabled = True
        End If
    End Sub

#End Region
   

End Class


#Region "Custom Contol"

Public Class CustomCircularProgress
    Inherits DevComponents.DotNetBar.Controls.CircularProgress

    Sub New()
        Me.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.ProgressColor = frmConfirm.PathColor
        Me.ProgressTextColor = Color.Green
        Me.Size = New Size(30, 30)
        Me.BackColor = Color.Transparent
        Me.AnimationSpeed = 10
        Me.Maximum = 100
        Me.Minimum = 0
    End Sub

End Class

#End Region
