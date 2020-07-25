#Region "Form Controller"
#Region "Imports"
Imports System.IO
Imports System.Management
Imports DevComponents.DotNetBar
Imports System.Drawing.Drawing2D
#End Region

Public Class FormController

#Region "Declaration"

#Region "Main Components"
    Dim CurrentMode As FormMode
    Dim i, i2, i3, j, k, l, m As Integer
    Dim bc As Boolean = False
    Dim blnYes, blnNo As Boolean
    Dim n As Boolean = False
    Private CanContinue As Boolean = False
    Dim IsfrmSecret As Boolean = True
    Dim hotkeyY As Boolean = False
    Dim hotkeyN As Boolean = False
    Dim kEnd As Boolean = False
    Dim kWindow As Boolean = False
    Dim IsMatrix As Boolean = False
    Private EntryRespond As Respond = Respond.Unresponded
    Private Confirmation As Confirmed = Confirmed.Unknown
    Private rtfSecret As New RichTextBox
    Private pnlSecret As New Panel
    Dim CircularProgressBars(17) As CustomCircularProgress

    Dim voice = CreateObject("sapi.spvoice")
    Dim h As Boolean = True
    Dim h1 As Boolean = True
    Dim h2 As Boolean = True
    Dim blnMsgConfirm As Boolean = False
    Dim msgVoice As Boolean = True
    Dim CreatedPath = False
    Dim CanDrawLoginBox As Boolean = True
    Dim identity As String = My.Settings.Identiy
    Dim password As String = My.Settings.IdentificationCode
#End Region

#Region "Messages"
    Dim strload As String = "......."
    Dim Msg1 As String = "You have entered into the restricted zone of PLATINUM." & vbCrLf & "Do you wish to continue?(Y/N)"
    Dim Msg2 As String = "Then, why have you entered here knowing it's restricted?"
    Dim Msg3 As String = "Now there is no way out for you unless you are smart. " & vbCrLf & "Do whatever you can do to get yourself out of here except restatring the PC. Any fool would do that."
    Dim Msg4 As String = vbCrLf & "I am done with you."
    Dim LoadMsg1 As String = "Gathering information"
    Dim LoadMsg2 As String = "loading ad.dll   " _
                         & vbCrLf & "loading functions.dll             " _
                         & vbCrLf & "loading crime.dll     " _
                         & vbCrLf & "loading profile.vf    " & vbCrLf & "loading properties.ph   " _
                         & vbCrLf & "loading frmSecret.vb    " & vbCrLf & "loading frmPlatinum.vb   " & vbCrLf & "loading Secret.sln   " _
                         & vbCrLf & "loading app.config    " & vbCrLf & "loading Secret.Designer.vb" _
                         & vbCrLf & "loading Secret.resx   " & vbCrLf & "loading Platinum.Designer.vb   " & vbCrLf & "loading Platinum.resx   " & vbCrLf & "loading mdlSecret.vb   " & vbCrLf & "loading Secret.vbproj               " _
                         & vbCrLf & "loading Secret.vbproj.user  " & vbCrLf & "loading Secret.application " & vbCrLf & "loading Secret.exe " & vbCrLf & "loading Secret.exe.config  " _
                         & vbCrLf & "loading Secret.exe.manifest  " _
                          & vbCrLf & "loading Secret.pdb " & vbCrLf & "loading Secret.vshost.application  " & vbCrLf & "loading Secret.vshost.exe  " _
                          & vbCrLf & "loading Secret.vshost.exe.config " & vbCrLf & "loading Secret.vshost.exe.manifest " _
                           & vbCrLf & "loading Platinum.sln " _
                           & vbCrLf & "loading Platinum.vbproj  " & vbCrLf & "loading Platnum.vbproj.user  " & vbCrLf & "loading Platinum.application " & vbCrLf & "loading Platinum.exe " _
                           & vbCrLf & "loading Platinum.exe.config " & vbCrLf & "loading Platinum.exe.manifest  " _
                          & vbCrLf & "loading Platinum.pdb " & vbCrLf & "loading Platinum.vshost.application " & vbCrLf & "loading Platinum.vshost.exe  " _
                          & vbCrLf & "loading Platinum.vshost.exe.config " & vbCrLf & vbCrLf & "loading Platinum.vshost.exe.manifest " _
                          & vbCrLf & "loading app.manifest  " & vbCrLf & "loading Application.Designer.vb  " & vbCrLf & "loading Application.myapp " _
                          & vbCrLf & "loading Assemblyinfo.vb " & vbCrLf & "loading Resources.Designer.vb " & vbCrLf & "loading Resources.resx " & vbCrLf & "loading Settigs.Designer.vb" _
                          & vbCrLf & "loading Settings.settings" & vbCrLf & "loading My Project.Resources.Designer.vb.dll" _
                          & vbCrLf & "loading DesignTimeResolveAssemblyReferences.cache " & vbCrLf & "loading DesignTimeResolveAssemblyReferencesInput.cache" _
                          & vbCrLf & "loading Secret.application " & vbCrLf & "loading Secret.exe " & vbCrLf & "loading Secret.exe.manifest " & vbCrLf & "loading Secret.frmPlatinum.resources" _
                          & vbCrLf & "loading Secret.frmSecret.resources" & vbCrLf & "loading Secret.pdb " & vbCrLf & "loading Secret.Resources.resources " _
                          & vbCrLf & "loading Secret.TrustInfo.xml" & vbCrLf & "loading Secret.vbproj.FileListAbsolute.txt " & vbCrLf & "loading Secret.vbproj.GenerateResource.Cache " _
                          & vbCrLf & "loading Secret.xml " & vbCrLf & "loading EventIV.dll " & vbCrLf & "loading CypherEncryption.dll " & vbCrLf & "loading Monitor_On.bat " & vbCrLf & "loading Monitor_Off.bat " _
                          & vbCrLf & "loading Mute_Volume.bat " & vbCrLf & "loading UnMute_Volume.bat "
    'Dim LoadMsg() As String = {LoadMsg2 & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "checking") & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "verifying") & vbCrLf & vbCrLf}
    'Dim strLoadMsg As String = Replace(Join(LoadMsg, ","), ",", vbNullString)
    Dim clcLoadMsg() As String = Split(Replace(Join(New Object() {LoadMsg2 & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "checking") & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "verifying") & vbCrLf & vbCrLf}, ","), ",", vbNullString), vbCrLf, , CompareMethod.Binary)
    Dim msg() As String = {"Confirm Your Identification First", "Identification Confirmed " & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf, ("Greetings Shakir!" & vbCrLf & vbCrLf & vbCrLf & "Platinum Welcomes You!" & vbCrLf & vbCrLf & vbCrLf & "Platinum wants your permission to procced.").ToString, "Invalid identification data." & vbCrLf}

#Region "Drawing Components"

    Public PathColor As Color = Color.FromArgb(0, 19, 77)
    Dim PathBrush As New SolidBrush(PathColor)
    Dim CheckPathBrush As New SolidBrush(CheckPathColor)
    Public CheckPathColor As Color = Color.LimeGreen
    Dim points As Point() = {New Point(1360, 360), New Point(1040, 360), New Point(1040, 80), New Point(800, 80), _
                             New Point(800, 640), New Point(1080, 640), New Point(1080, 720), New Point(640, 720), New Point(640, 520), _
                             New Point(200, 520), New Point(200, 480), New Point(480, 480), New Point(480, 200), New Point(440, 200), _
                             New Point(440, 400), New Point(240, 400), New Point(240, 240), New Point(0, 240)}

#End Region

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

#Region "Custom Objects"

#Region "Enum"
    Public Enum Confirmed As Integer
        Yes = 0
        No = 1
        Unknown = 2
    End Enum

    Private Enum FormMode As Integer
        Entry = 0
        Load = 1
        Login = 2
    End Enum

    Private Enum Respond As Integer
        Yes = 0
        No = 1
        Unresponded = 2
    End Enum

#End Region

#Region "Procedure"
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

    Private Sub ResetValue()
        i = 1
        i2 = 1
        i3 = 1
        j = 0
        k = 0
        l = 0
        m = 0
    End Sub

    Private Sub ClearLoginForm()
        PreventDrawingBox()
        HideProgressBar()
        lblIdentity.Visible = True
        lblIdentity.Dock = DockStyle.Fill
        lblIdentity.AutoSize = False
        lblIdentity.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub CreateController()
        CommandNir(NirCommand.MuteVolume)
        System.Windows.Forms.Cursor.Hide()
        With Me
            .Activate()
            .ControlBox = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = My.Settings.MainForecolor
            .lblTime.Location = New Point(1170, 32)
            .lblTime.Text = (Now.TimeOfDay).ToString
            .lblDate.Location = New Point(24, 32)
            .lblDate.Text = Now.Date

            .tmrSecret.Enabled = True
            .tmrSecret.Interval = 10
        End With
    End Sub

    Private Sub ChangeForm(ByVal Mode As FormMode)
        Select Case Mode
            Case FormMode.Entry
                CurrentMode = FormMode.Entry
                EntryRespond = Respond.Unresponded
                CanDrawLoginBox = False
                Me.CreateGraphics.Clear(Color.Black)
                ResetValue()
                With Me
                    .blnYes = False
                    .blnNo = False
                    .lblPlatinum.Visible = True
                    .lblSecret.Visible = True
                    .lblSecret.TextAlign = ContentAlignment.MiddleCenter
                    .lblSecret.Font = My.Settings.MainFont
                    .lblSecret.ForeColor = My.Settings.MainForecolor
                    .lblSecret.Text = Nothing
                    .lblTime.Visible = True
                    .lblDate.Visible = True
                    .lblIdentity.Visible = False
                    .lblPassword.Visible = False
                    .lblUser.Visible = False
                    .txtPassword.Visible = False
                    .txtUser.Visible = False

                    .tmrMsg.Interval = 70
                    .tmrMsg.Enabled = True
                    .tmrLogin.Enabled = False
                    .tmrDraw.Enabled = False
                    .tmrMsg.Start()
                End With

            Case FormMode.Load
                CurrentMode = FormMode.Load
                CanDrawLoginBox = False
                Me.CreateGraphics.Clear(Color.Black)
                ResetValue()
                With rtfSecret
                    .Font = My.Settings.MainFont
                    .ForeColor = Color.Gray
                    .Dock = DockStyle.Fill
                    .SelectionAlignment = HorizontalAlignment.Left
                    .BorderStyle = BorderStyle.None
                    .HideSelection = False
                    .ReadOnly = True
                    .BackColor = Color.Black
                    .AutoSize = False
                    .ScrollBars = RichTextBoxScrollBars.None
                    .Text = Nothing
                    .RightToLeft = False
                    .ScrollToCaret()
                    .CreateControl()
                End With
                With pnlSecret
                    .Dock = DockStyle.Fill
                    .Padding = New Windows.Forms.Padding(40, 40, 10, 30)
                    .Controls.Add(rtfSecret)
                End With
                With Me
                    .lblSecret.Hide()
                    .lblPlatinum.Hide()
                    .lblTime.Hide()
                    .lblDate.Hide()
                    .lblIdentity.Hide()
                    .lblPassword.Hide()
                    .lblUser.Hide()
                    .txtUser.Hide()
                    .txtPassword.Hide()
                    .Controls.Add(pnlSecret)
                End With
                tmrLogin.Enabled = False
                tmrDraw.Enabled = False
                tmrMsg.Enabled = True
                tmrMsg.Interval = 1

            Case FormMode.Login
                CurrentMode = FormMode.Login
                CanDrawLoginBox = True
                ResetValue()
                h = True
                h1 = True
                With Me
                    .pnlSecret.Visible = False
                    .Controls.Remove(pnlSecret)
                    With .lblIdentity
                        .Visible = True
                        .Location = New Point(498, 196)
                        .BorderStyle = BorderStyle.None
                        .BackColor = Color.Black
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Text = vbNullString
                    End With
                    With .lblUser
                        .Visible = True
                        .Location = New Point(369, 370)
                        .BorderStyle = BorderStyle.None
                        .BackColor = Color.Black
                        .Font = My.Settings.identityFont
                        .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                        .TextAlign = ContentAlignment.MiddleLeft
                        .Text = "Identity :"
                    End With
                    With .lblPassword
                        .Visible = True
                        .Location = New Point(369, 425)
                        .BorderStyle = BorderStyle.None
                        .BackColor = Color.Black
                        .Font = My.Settings.identityFont
                        .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                        .TextAlign = ContentAlignment.MiddleLeft
                        .Text = "Identification Code :"
                    End With
                    With txtUser
                        .Visible = True
                        .Location = New Point(570, 370)
                        .TabIndex = 1
                        .BorderStyle = BorderStyle.None
                        .BackColor = Color.Black
                        .Cursor = Cursors.IBeam
                        .Font = My.Settings.identityFont
                        .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                        .ContextMenuStrip = ContextMenuStrip1
                        .Text = "User"
                        .Focus()
                        .Select()
                    End With
                    With txtPassword
                        .Visible = True
                        .Location = New Point(570, 425)
                        .TabIndex = 2
                        .BorderStyle = BorderStyle.None
                        .BackColor = Color.Black
                        .Cursor = Cursors.IBeam
                        .Font = My.Settings.identityFont
                        .ForeColor = Drawing.Color.FromArgb(120, 255, 150)
                        .ContextMenuStrip = ContextMenuStrip1
                        .PasswordChar = "*"
                        .Text = "password"
                    End With
                    Confirmation = Confirmed.Unknown
                    blnMsgConfirm = False
                    .lblPlatinum.Visible = True
                    .lblTime.Visible = True
                    .lblDate.Visible = True
                    .lblSecret.Hide()
                    .rtfSecret.Hide()
                    .tmrMsg.Enabled = True
                    .tmrMsg.Interval = 60
                    .tmrLogin.Enabled = True
                    .tmrLogin.Interval = 10
                    .tmrDraw.Enabled = False
                    .tmrDraw.Interval = 1
                End With

                For i As Integer = 0 To 17
                    CircularProgressBars(i) = New CustomCircularProgress
                    CircularProgressBars(i).Location = New Point(points(i).X - 15, points(i).Y - 15)
                    Me.Controls.Add(CircularProgressBars(i))
                    CircularProgressBars(i).Hide()
                Next
                Me.CreateGraphics.Clear(Color.Black)
                Dim brusht As New HatchBrush(HatchStyle.Percent90, Drawing.Color.FromArgb(120, 255, 150), Drawing.Color.Black)
                Dim brufg As New SolidBrush(Drawing.Color.FromArgb(120, 255, 150))
                Me.CreateGraphics.DrawRectangle(New Pen(brusht, 10), New Rectangle(New Point(332, 330), New Size(717, 157)))
        End Select
    End Sub
#End Region

#End Region

#Region "FormControllerComponents"

    Private Sub FormController_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseReason.UserClosing Or CloseReason.TaskManagerClosing Or CloseReason.WindowsShutDown Then
            e.Cancel = True
        End If
        CommandNir(NirCommand.UnmuteVolume)
    End Sub

    Private Sub FormController_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.LWin Or Keys.RWin Or Keys.Escape Or (Keys.ControlKey And Keys.Escape) Then
            e.Handled = True
            Me.Focus()
        End If
    End Sub

    Private Sub FormController_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Activate()
    End Sub

    Private Sub FormController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateController()
        ChangeForm(FormMode.Entry)
    End Sub

    Private Sub FormController_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.Activate()
    End Sub

    Private Sub FormController_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If CanDrawLoginBox Then
            Dim brusht As New HatchBrush(HatchStyle.Percent90, Drawing.Color.FromArgb(120, 255, 150), Drawing.Color.Black)
            Dim brufg As New SolidBrush(Drawing.Color.FromArgb(120, 255, 150))
            e.Graphics.DrawRectangle(New Pen(brusht, 10), New Rectangle(New Point(332, 330), New Size(717, 157)))
        End If
    End Sub

#End Region

#Region "Timers"
    Private Sub tmrSecret_Tick(sender As Object, e As EventArgs) Handles tmrSecret.Tick
        On Error Resume Next
        KillProcess("Taskmgr")
        Me.lblTime.Text = (Now.TimeOfDay).ToString
        Me.lblDate.Text = FormatDateTime(Now, DateFormat.LongDate)
        frmTerminal.lblTime.Text = (Now.TimeOfDay).ToString
        frmTerminal.lblDate.Text = FormatDateTime(Now, DateFormat.LongDate)
        hotkeyY = GetAsyncKeyState(Keys.Y)
        hotkeyN = GetAsyncKeyState(Keys.N)
        kEnd = GetAsyncKeyState(Keys.ControlKey) And GetAsyncKeyState(Keys.ShiftKey) And GetAsyncKeyState(Keys.Q)
        IsMe = GetAsyncKeyState(Keys.S)

        If CurrentMode = FormMode.Entry Then
            If hotkeyY Then
                Me.lblSecret.Text = Msg1 & vbCrLf & "Y"
                ResetValue()
                EntryRespond = Respond.Yes
                Me.tmrMsg.Enabled = True
            ElseIf hotkeyN Then
                Me.lblSecret.Text = Msg1 & vbCrLf & "N"
                ResetValue()
                EntryRespond = Respond.No
                bc = False
                Me.tmrMsg.Enabled = True
            End If
        End If
        If kEnd Then
            CommandNir(NirCommand.UnmuteVolume)
            Me.Close()
            End
        ElseIf IsMe Then
            If Confirmation = Confirmed.Yes Then
                Me.Hide()
                frmTerminal.Show()
            End If
        End If
        Me.Focus()
        'txtUser.Focus()

    End Sub

    Private Sub tmrMsg_Tick(sender As Object, e As EventArgs) Handles tmrMsg.Tick

        Select Case CurrentMode

            Case FormMode.Entry
                If EntryRespond = Respond.Yes Then
                    Select Case j
                        Case Is < 5
                            j += 1
                        Case 5
                            tmrMsg.Interval = 1000
                            If Not Me.lblSecret.Text = LoadMsg1.ToString & strload Then
                                Me.lblSecret.Text = LoadMsg1.ToString & Mid(strload, 1, i)
                                i += 1
                            Else
                                ChangeForm(FormMode.Load)
                            End If
                    End Select
                ElseIf EntryRespond = Respond.No Then
                    Select Case j
                        Case Is < 4
                            j += 1
                        Case 4
                            Select Case i
                                Case Is < Len(Msg2)
                                    bc = False
                                    Me.lblSecret.Text = Mid(Msg2, 1, i) & "_"
                                    i += 1
                                Case Len(Msg2)
                                    Select Case k
                                        Case Is < 14
                                            k += 1
                                            Me.lblSecret.Text = If(bc, Msg2 & vbCrLf & "_", Msg2 & vbCrLf)
                                            bc = Not bc
                                        Case 14
                                            Select Case i2
                                                Case Is < Len(Msg3)
                                                    bc = False
                                                    Me.lblSecret.Text = Msg2 & vbCrLf & Mid(Msg3, 1, i2) & "_"
                                                    i2 += 1
                                                Case Len(Msg3)
                                                    Select Case l
                                                        Case Is < 70
                                                            l += 1
                                                            Me.lblSecret.Text = If(bc, Msg2 & vbCrLf & Msg3 & vbCrLf & "_", Msg2 & vbCrLf & Msg3 & vbCrLf)
                                                            bc = Not bc
                                                        Case 70
                                                            Select Case i3
                                                                Case Is < Len(Msg4)
                                                                    bc = False
                                                                    Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & Mid(Msg4, 1, i3) & "_"
                                                                    i3 += 1
                                                                Case Len(Msg4)
                                                                    Select Case m
                                                                        Case Is < 14
                                                                            m += 1
                                                                            Me.lblSecret.Text = If(bc, Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf & "_", Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf)
                                                                            bc = Not bc
                                                                        Case 14
                                                                            Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf
                                                                    End Select
                                                            End Select
                                                    End Select
                                            End Select
                                    End Select
                            End Select
                    End Select
                ElseIf EntryRespond = Respond.Unresponded Then
                    Select Case i
                        Case Is < Len(Msg1)
                            bc = False
                            lblSecret.Text = Mid(Msg1, 1, i) & "_"
                            i += 1
                        Case Len(Msg1)
                            lblSecret.Text = Mid(Msg1, 1, i) & "_"
                            lblSecret.Text = If(bc, Msg1 & vbCrLf & "_", Msg1 & vbCrLf)
                            bc = Not bc
                    End Select
                End If


            Case FormMode.Load
                Select Case i
                    Case Is < clcLoadMsg.Count - 1
                        Me.rtfSecret.AppendText(clcLoadMsg(i) & vbCrLf)
                        i += 1
                    Case clcLoadMsg.Count - 1
                        ChangeForm(FormMode.Login)
                End Select

            Case FormMode.Login
                Select Case Confirmation
                    Case Confirmed.Yes
                        ClearLoginForm()

                        Select Case i3
                            Case Is < Len(msg(1))
                                lblIdentity.Text = Mid(msg(1), 1, i3) & "_"
                                i3 += 1
                            Case Is = Len(msg(1))
                                Select Case k
                                    Case Is < 30
                                        k += 1
                                        lblIdentity.Text = msg(1)
                                    Case Is = 30
                                        Select Case j
                                            Case Is < Len(msg(2))
                                                lblIdentity.Text = Mid(msg(2), 1, j) & "_"
                                                j += 1
                                            Case Is = Len(msg(2))
                                                lblIdentity.Text = msg(2)
                                        End Select
                                End Select
                        End Select
                    Case Confirmed.No
                        ClearLoginForm()

                        Select Case i2
                            Case Is < Len(msg(3))
                                bc = False
                                lblIdentity.Text = Mid(msg(3), 1, i2) & "_"
                                i2 += 1
                            Case Is = Len(msg(3))
                                lblIdentity.Text = Mid(msg(3), 1, i2)
                                lblIdentity.Hide()
                                lblTime.Hide()
                                lblDate.Hide()
                                MatrixEffect(Me, Effect.Screen)
                                tmrMsg.Enabled = False
                        End Select

                    Case Confirmed.Unknown
                        If Not blnMsgConfirm Then
                            Select Case i
                                Case Is <= Len(msg(0))
                                    lblIdentity.Text = Mid(msg(0).ToString, 1, i) & "_"
                                    i = i + 1
                                Case Is > Len(msg(0))
                                    lblIdentity.Text = msg(0).ToString
                                    blnMsgConfirm = True
                                    i = 1
                            End Select
                        End If
                End Select
        End Select
    End Sub

    Private Sub tmrConfirm_Tick(sender As Object, e As EventArgs) Handles tmrLogin.Tick
        If blnMsgConfirm Then
            If txtUser.Text = identity And txtPassword.Text = password Then
                SetCheckPathColor(Color.LimeGreen)
                PreventDrawingBox()
                tmrDraw.Enabled = True
                tmrLogin.Enabled = False
            End If
        End If
    End Sub


#Region "Form Drawing"

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        lblSecret.Hide()
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
                            CurrPos.Y += 20
                        ElseIf CurrPos.Y > points(index + 1).Y Then
                            CurrPos.Y -= 20
                        End If
                        g.DrawLine(New Pen(CheckPathBrush, 4), points(index), CurrPos)
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
                                CurrPos.Y += 40
                            ElseIf CurrPos.Y > points(index + 1).Y Then
                                CurrPos.Y -= 40
                            End If
                            g.DrawLine(New Pen(PathBrush, 3), points(index), CurrPos)
                        Else
                            index += 1
                        End If
                    Case Else
                        If Not CurrPos.X = points(index + 1).X Then
                            If CurrPos.X < points(index + 1).X Then
                                CurrPos.X += 40
                            ElseIf CurrPos.X > points(index + 1).X Then
                                CurrPos.X -= 40
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
        Me.ProgressColor = FormController.PathColor
        Me.ProgressTextColor = Color.Green
        Me.Size = New Size(30, 30)
        Me.BackColor = Color.Transparent
        Me.AnimationSpeed = 10
        Me.Maximum = 100
        Me.Minimum = 0
    End Sub

End Class

#End Region

#End Region
