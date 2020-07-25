Module mdlSecret
    Public matrix_effect As Boolean = False
    Public IsMe As Boolean = False
    Public Confirmation As Integer = Confirmed.Unknown
    Private IsNirExists As Boolean = My.Computer.FileSystem.FileExists(Application.StartupPath & "\nircmd.exe")
    Private IsMatrixExists As Boolean = My.Computer.FileSystem.FileExists(Application.StartupPath & "\matrix.gif")
    Private nirCmdPath() As String = {Application.StartupPath & "\Monitor_On.bat", Application.StartupPath & "\Monitor_Off.bat", Application.StartupPath & "\Mute_Volume.bat", Application.StartupPath & "\Unmute_Volume.bat"}

    Public Enum NirCommand As Integer
        MonitorOn = 0
        MonitorOff = 1
        MuteVolume = 2
        UnmuteVolume = 3
    End Enum

    Public Enum Effect As Integer
        Cursor = 0
        Screen = 1
    End Enum

    Public Enum Confirmed As Integer
        Yes = 0
        No = 1
        Unknown = 2
    End Enum

    Public Sub KillProcess(ByVal strProcess As String)
        Try
            Dim All_Process() As Process = Process.GetProcesses
            For Each tarProcess As Process In All_Process
                If tarProcess.ProcessName.ToString.ToLower = strProcess.ToString.ToLower Then
                    tarProcess.Kill()
                End If
            Next
        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Public Sub CommandNir(ByVal NirCommand As NirCommand)
        On Error Resume Next
        If Not IsNirExists Then
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.GetParentPath(Application.StartupPath)) & "\Resources\nircmd.exe", Application.StartupPath & "\nircmd.exe")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Monitor_On.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe monitor on", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Monitor_Off.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe monitor off", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Mute_Volume.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe mutesysvolume 1", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Unmute_Volume.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe mutesysvolume 0", False)
        Shell(nirCmdPath(NirCommand).ToString)
    End Sub


    Public Function MatrixEffect(ByVal sender As Object, Optional ByVal Effect As Effect = mdlSecret.Effect.Cursor) As String
        On Error Resume Next
        Dim outStr As String = Nothing
        Select Case Effect
            Case 0
                outStr = "_& $_+=^&*_ #$%^ &*()41_@! ^%_4%$_+#"
            Case 1
                outStr = Nothing
                If Not IsMatrixExists Then
                    My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.GetParentPath(Application.StartupPath)) & "\Resources\matrix.gif", Application.StartupPath & "\matrix.gif")
                End If
                Dim matrixBrowser As New WebBrowser
                With matrixBrowser
                    .ContextMenuStrip = Nothing
                    .IsWebBrowserContextMenuEnabled = False
                    .DocumentText = "<html><head><style type=""text/css"">body{background-image:url('" & Application.StartupPath & "\matrix.gif');background-repeat:repeat;background-attachment:fixed;}</style></head><body></body></html>"
                    .Dock = DockStyle.Fill
                    .ScrollBarsEnabled = False
                    .BringToFront()
                End With
                sender.WindowState = System.Windows.Forms.FormWindowState.Maximized
                sender.Controls.Add(matrixBrowser)
        End Select
        Return outStr
    End Function
End Module
