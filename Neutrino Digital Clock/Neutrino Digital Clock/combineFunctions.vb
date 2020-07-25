Module combineFunctions

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
     (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
         Integer, ByVal hwndCallback As Integer) As Integer

    Public Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam _
As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    '____ Sound Options _____'
    Dim soundToPlay As String

    Public Sub loadAndSetSoundFile(ByVal soundPath As String)
        soundToPlay = soundPath
        Dim fileToPlay As String = Chr(34) + (soundPath) + Chr(34)
        mciSendString("close soundFile", Nothing, 0, 0)
        mciSendString("open " & fileToPlay & " alias soundFile", Nothing, 0, 0)
    End Sub

    Public Sub playSoundFile()
        mciSendString("play soundFile", Nothing, 0, 0)
    End Sub

    Public Sub stopSound()
        If mediaIsPlaying() Then
            mciSendString("stop soundFile", Nothing, 0, 0)
        End If
    End Sub

    Public Sub pausePlay()
        If mediaIsPlaying() Then
            mciSendString("pause soundFile", Nothing, 0, 0)
        End If
    End Sub

    Public Sub resumePlay()
        mciSendString("resume soundFile", Nothing, 0, 0)
    End Sub

    Public Function mediaIsPlaying() As Boolean
        Dim stat As String = Space(128)
        mciSendString("status soundFile mode", stat, 128, 0)
        If stat.StartsWith("playing") Then
            Return True
        Else
            Return False
        End If
        stat = Nothing
    End Function
End Module
