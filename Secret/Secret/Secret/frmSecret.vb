Imports System
Imports System.IO
Imports System.Management
Public Class frmSecret
    Dim i, i2, i3, j, k, l, m As Integer
    Dim bc As Boolean = False
    Dim blnYes, blnNo As Boolean
    Dim n As Boolean = False
    Private isLoad As Boolean = False
    Dim IsfrmSecret As Boolean = True
    Dim hotkeyY As Boolean = False
    Dim hotkeyN As Boolean = False
    Dim kEnd As Boolean = False
    Dim kWindow As Boolean = False
    Dim IsMatrix As Boolean = False
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
    Dim LoadMsg() As String = {LoadMsg2 & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "checking") & vbCrLf & vbCrLf, LoadMsg2.Replace("loading", "verifying") & vbCrLf & vbCrLf}
    Dim strLoadMsg As String = Replace(Join(LoadMsg, ","), ",", vbNullString)
    Dim clcLoadMsg() As String = Split(strLoadMsg, vbCrLf, , CompareMethod.Binary)
    Private rtfSecret As New RichTextBox

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

    Private Sub CreateLoad()
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
            .ScrollToCaret()
            .Text = Nothing
            .RightToLeft = False
            .CreateControl()
        End With
        With Me
            .lblSecret.Hide()
            .lblPlatinum.Hide()
            .pnlSecret.Padding = New Padding(40, 40, 10, 30)
        End With
        Me.pnlSecret.Controls.Add(rtfSecret)
    End Sub

    Private Sub Secret_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseReason.UserClosing Or CloseReason.TaskManagerClosing Or CloseReason.WindowsShutDown Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmSecret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Keys.LWin)) Or e.KeyChar = CChar(ChrW(Keys.RWin)) Or e.KeyChar = CChar(ChrW(Keys.Escape)) Or e.KeyChar = CChar(ChrW(Keys.ControlKey + Keys.Escape)) Then
            Me.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Secret_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Activate()
    End Sub

    Private Sub Secret_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CommandNir(2)
        System.Windows.Forms.Cursor.Hide()
        i = 1
        i2 = 1
        i3 = 1
        j = 0
        k = 0
        l = 0
        m = 0
        With Me
            .blnYes = False
            .blnNo = False
            .Activate()
            .ControlBox = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = False
            .BackColor = Color.Black
            .ForeColor = My.Settings.MainForecolor
            .lblSecret.TextAlign = ContentAlignment.MiddleCenter
            .lblSecret.Font = My.Settings.MainFont
            .lblSecret.ForeColor = My.Settings.MainForecolor
            .lblSecret.Text = Nothing

            .tmrSecret.Enabled = True
            .tmrSecret.Interval = 10
            .tmrMsg.Enabled = True
            .tmrMsg.Start()
            .tmrMsg.Interval = 80
        End With
    End Sub

    Private Sub Secret_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.Activate()
    End Sub

    Private Sub tmrSecret_Tick(sender As Object, e As EventArgs) Handles tmrSecret.Tick
        Me.Focus()
        KillProcess("Taskmgr")
        hotkeyY = GetAsyncKeyState(Keys.Y)
        hotkeyN = GetAsyncKeyState(Keys.N)
        kEnd = GetAsyncKeyState(Keys.ControlKey) And GetAsyncKeyState(Keys.ShiftKey) And GetAsyncKeyState(Keys.Q)
        IsMe = GetAsyncKeyState(Keys.S)
        kWindow = GetAsyncKeyState(Keys.LWin) Or GetAsyncKeyState(Keys.RWin)
        IsMatrix = GetAsyncKeyState(Keys.M)
        If hotkeyY Then
            Me.lblSecret.Text = msg1 & vbCrLf & "Y"
            j = 0
            blnYes = True
            blnNo = False
            Me.tmrMsg.Enabled = True
        ElseIf hotkeyN Then
            Me.lblSecret.Text = msg1 & vbCrLf & "N"
            i = 1
            i2 = 1
            j = 0
            k = 0
            l = 0
            blnNo = True
            bc = False
            Me.tmrMsg.Enabled = True
        ElseIf kEnd Then
            CommandNir(3)
            End
        ElseIf kWindow Then
            Me.Focus()
            frmConfirm.Focus()
            Focus()
        ElseIf IsMatrix Then
            matrix_effect = True
        ElseIf IsMe Then
            'If isLoad = True Then
            'frmConfirm.Show()
            'me.hide()
            'isLoad = False
            ' ElseIf frmConfirm.Confirmed = True Then
            'frmConfirm.Close()
            'frmMain.Show()
            'frmConfirm.Confirmed = False
            'End If
            frmConfirm.Close()
            frmMain.Show()
        End If
        Me.Focus()
    End Sub

    Private Sub tmrMsg_Tick(sender As Object, e As EventArgs) Handles tmrMsg.Tick
        Select Case IsfrmSecret
            Case True
                If blnYes Then
                    Select Case j
                        Case Is < 5
                            j += 1
                        Case 5
                            IsfrmSecret = False
                            lblSecret.Text = Nothing
                            i = 0
                    End Select
                ElseIf blnNo Then
                    Select Case j
                        Case Is < 4
                            j += 1
                        Case 4
                            Select Case i
                                Case Is < Len(Msg2)
                                    Me.lblSecret.Text = Mid(Msg2, 1, i) & "_"
                                    i += 1
                                Case Len(Msg2)
                                    Select Case k
                                        Case Is < 14
                                            k += 1
                                            If bc Then
                                                Me.lblSecret.Text = Msg2 & vbCrLf & "_"
                                                bc = False
                                            Else
                                                Me.lblSecret.Text = Msg2 & vbCrLf
                                                bc = True
                                            End If
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
                                                            If bc Then
                                                                Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & "_"
                                                                bc = False
                                                            Else
                                                                Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf
                                                                bc = True
                                                            End If

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
                                                                            If bc Then
                                                                                Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf & "_"
                                                                                bc = False
                                                                            Else
                                                                                Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf
                                                                                bc = True
                                                                            End If
                                                                        Case 14
                                                                            Me.lblSecret.Text = Msg2 & vbCrLf & Msg3 & vbCrLf & Msg4 & vbCrLf
                                                                    End Select
                                                            End Select
                                                    End Select
                                            End Select
                                    End Select
                            End Select
                    End Select
                Else
                    Select Case i
                        Case Is < Len(Msg1)
                            bc = False
                            lblSecret.Text = Mid(Msg1, 1, i) & "_"
                            i += 1
                        Case Len(Msg1)
                            lblSecret.Text = Mid(Msg1, 1, i) & "_"
                            If bc Then
                                lblSecret.Text = Mid(Msg1, 1, i) & vbCrLf & "_"
                                bc = False
                            Else
                                lblSecret.Text = Mid(Msg1, 1, i) & vbCrLf
                                bc = True
                            End If
                    End Select
                End If
            Case False
                If n Then
                    If matrix_effect Then
                        Select Case i
                            Case Is < Len(strLoadMsg)
                                Me.rtfSecret.AppendText(Mid(strLoadMsg, i, 1) & "_& $_+=^&*_ #$%^ &*()41_@! ^%_4%$_+#")
                                i += 1
                            Case Len(strLoadMsg)
                                matrix_effect = True
                                i = 1
                        End Select
                    Else
                        Select Case i
                            Case Is < clcLoadMsg.Count - 1
                                Me.rtfSecret.AppendText(clcLoadMsg(i) & vbCrLf)
                                i += 1
                            Case clcLoadMsg.Count - 1
                                Me.rtfSecret.ForeColor = My.Settings.MainForecolor
                                Me.pnlSecret.Padding = New Padding(0, 0, 0, 0)
                                matrix_effect = True
                                isLoad = True
                                i = 1
                                tmrMsg.Interval = 1
                        End Select
                    End If
                Else
                    tmrMsg.Interval = 1000
                    If Not Me.lblSecret.Text = LoadMsg1.ToString & strload Then
                        Me.lblSecret.Text = LoadMsg1.ToString & Mid(strload, 1, i)
                        i += 1
                    Else
                        CreateLoad()
                        n = True
                        i = 1
                        tmrMsg.Interval = 10
                    End If
                End If
        End Select
    End Sub

End Class
