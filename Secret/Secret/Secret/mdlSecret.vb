Module mdlSecret
    Public matrix_effect As Boolean = False
    Public IsMe As Boolean = False
    Private IsNirExists As Boolean = My.Computer.FileSystem.FileExists(Application.StartupPath & "\nircmd.exe")
    Private nirCmdPath() As String = {Application.StartupPath & "\Monitor_On.bat", Application.StartupPath & "\Monitor_Off.bat", Application.StartupPath & "\Mute_Volume.bat", Application.StartupPath & "\UnMute_Volume.bat"}

    Public Sub KillProcess(ByVal strProcess As String)
        Try
            Dim All_Proc() As Process = Process.GetProcesses
            For Each tarProcess As Process In All_Proc
                If tarProcess.ProcessName.ToString.ToLower = strProcess.ToString.ToLower Then
                    tarProcess.Kill()
                End If
            Next
        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Public Sub CommandNir(ByVal strCommand As Integer)
        On Error Resume Next
        If Not IsNirExists Then
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.GetParentPath(Application.StartupPath)) & "\Resources\nircmd.exe", Application.StartupPath & "\nircmd.exe")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Monitor_On.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe monitor on", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Monitor_Off.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe monitor off", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Mute_Volume.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe mutesysvolume 1", False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\UnMute_Volume.bat", "cd " & Application.StartupPath & vbCrLf & "nircmd.exe mutesysvolume 0", False)
        Shell(nirCmdPath(strCommand).ToString)
    End Sub

    Public Function MatrixCursor(Optional ByVal IsOn As Boolean = False) As String
        Dim outStr As String = Nothing
        If IsOn Then
            outStr = "_& $_+=^&*_ #$%^ &*()41_@! ^%_4%$_+#"
        Else
            outStr = Nothing
        End If
        Return outStr
    End Function
End Module
