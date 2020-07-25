Imports System.IO
Imports System.Management
Public Class frmConfirm
    Dim voice = CreateObject("sapi.spvoice")
    Dim i As Integer = 1
    Dim j As Integer = 1
    Dim k As Integer = 0
    Dim blnMsgConfirm As Boolean = False
    Public Confirmed As Boolean = False
    Dim msgVoice As Boolean = True
    Dim identity As String = "QuillSeeker3084"
    Dim password As String = "shakir!Platinum=>7777777"
    Dim msg() As String = {"Confirm Your Identification First", "Identification Confirmed " & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf, ("Greetings Shakir!" & vbCrLf & vbCrLf & vbCrLf & "Platinum Welcomes You!" & vbCrLf & vbCrLf & vbCrLf & "Could you please press the confirmation button again for the strict security you set?").ToString}

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

    Private Sub frmConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Keys.LWin)) Or e.KeyChar = CChar(ChrW(Keys.RWin)) Or e.KeyChar = CChar(ChrW(Keys.Escape)) Or e.KeyChar = CChar(ChrW(Keys.ControlKey + Keys.Escape)) Then
            Me.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub frmConfirm_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub frmConfirm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.Activate()
    End Sub

    Private Sub frmConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .ControlBox = False
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = My.Settings.MainForecolor
            With .lblIdentity
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .TextAlign = ContentAlignment.MiddleCenter
            End With
            With .lblUser
                .Text = "Identity :"
                .Font = My.Settings.identityFont
            End With
            With .lblPassword
                .Text = "Identification Code :"
                .Font = My.Settings.identityFont
            End With
            With txtUser
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = My.Settings.MainForecolor
                .ContextMenuStrip = ContextMenuStrip1
                .Focus()
                .TabIndex = 1
            End With
            With txtPassword
                .Text = vbNullString
                .BorderStyle = BorderStyle.None
                .BackColor = Color.Black
                .Cursor = Cursors.Default
                .Font = My.Settings.identityFont
                .ForeColor = My.Settings.MainForecolor
                .ContextMenuStrip = ContextMenuStrip1
                .PasswordChar = "*"
                .TabIndex = 2
            End With
            With pnlUser
                .Location = New Point((Me.Width / 2) - 677, (My.Computer.Screen.WorkingArea.Height / 2) - 50)
            End With
            .tmrConfirm.Enabled = True
            .tmrConfirm.Interval = 70
        End With
    End Sub

    Private Sub tmrConfirm_Tick(sender As Object, e As EventArgs) Handles tmrConfirm.Tick
        If blnMsgConfirm Then
            If txtUser.Text = identity And txtPassword.Text = password Then
                Confirmed = True
                lblIdentity.Dock = DockStyle.Fill
                lblIdentity.AutoSize = False
                lblIdentity.TextAlign = ContentAlignment.MiddleCenter
                pnlUser.Hide()
                If i < Len(msg(1)) Then
                    lblIdentity.Text = Mid(msg(1), 1, i) & "_"
                    i = i + 1
                ElseIf i = Len(msg(1)) Then
                    If k < 30 Then
                        k = k + 1
                        lblIdentity.Text = msg(1)
                    ElseIf k = 30 Then
                        If j < Len(msg(2)) Then
                            lblIdentity.Text = Mid(msg(2), 1, j) & "_"
                            j = j + 1
                        ElseIf j = Len(msg(2)) Then
                            lblIdentity.Text = msg(2)
                        End If
                    End If
                End If
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
        Me.Focus()
    End Sub
End Class