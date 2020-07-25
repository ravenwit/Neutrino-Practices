Imports System.Collections
'
Public Class frmMain

    Dim openDlg As OpenFileDialog = New OpenFileDialog
    Dim slideDelay As Integer = 2000
    Dim filepath As String
    Dim filename As String
    Dim stopSlideShow As Boolean = False
    Dim imageCollection As New SortedList

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
        (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
            Integer, ByVal hwndCallback As Integer) As Integer

    Dim soundToPlay As String

    '
    Private Sub tsBtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnPrevious.Click

        If Not cmbPaths.SelectedIndex <= 0 Then

            cmbPaths.SelectedIndex -= 1

        End If

    End Sub

    Private Sub tsBtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnNext.Click

        If Not cmbPaths.SelectedIndex = cmbPaths.Items.Count - 1 Then

            cmbPaths.SelectedIndex += 1

        End If

    End Sub

    Private Sub tsBtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnStart.Click

        stopSlideShow = False

        If My.Computer.FileSystem.FileExists(soundToPlay) Then

            slideshow(True)

        Else

            slideshow()

        End If

    End Sub

    Private Sub tsBtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnStop.Click

        stopSlideShow = True
        tsBtnStopSound.PerformClick()

    End Sub

    Private Sub tsBtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnAddItem.Click

        openDlg.Multiselect = True

        Dim path As String

        openDlg.Filter = "Image Files (*.jpg, *.jpeg, *.png, *bmp, *.gif|*.jpg; *.jpeg; *.png; *bmp; *.gif"

        If openDlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each path In openDlg.FileNames

                If My.Computer.FileSystem.GetFileInfo(path).Extension.ToLower = ".jpg" Or _
                    My.Computer.FileSystem.GetFileInfo(path).Extension.ToLower = ".jpeg" Or _
                    My.Computer.FileSystem.GetFileInfo(path).Extension.ToLower = ".png" Or _
                        My.Computer.FileSystem.GetFileInfo(path).Extension.ToLower = ".bmp" Or _
                            My.Computer.FileSystem.GetFileInfo(path).Extension.ToLower = ".gif" Then ' Or ".jpeg" Or ".gif" Or ".png" Or ".bmp" Then

                    filename = My.Computer.FileSystem.GetName(path)

                    If Not imageCollection.ContainsKey(filename) Then

                        imageCollection.Add(filename, path)

                        cmbPaths.Items.Add(filename)

                    End If

                End If

            Next

        End If

        lblCount.Text = "Count: " & (cmbPaths.Items.Count.ToString)

    End Sub

    Private Sub tsBtnAddDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnAddDirectory.Click

        Dim openDir As New FolderBrowserDialog

        openDir.Description = "Select the directory whose images you want to add..."

        If openDir.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            For Each filepath In My.Computer.FileSystem.GetFiles(openDir.SelectedPath)

                If My.Computer.FileSystem.GetFileInfo(filepath).Extension.ToLower = ".jpg" Or _
                    My.Computer.FileSystem.GetFileInfo(filepath).Extension.ToLower = ".jpeg" Or _
                    My.Computer.FileSystem.GetFileInfo(filepath).Extension.ToLower = ".png" Or _
                        My.Computer.FileSystem.GetFileInfo(filepath).Extension.ToLower = ".bmp" Or _
                            My.Computer.FileSystem.GetFileInfo(filepath).Extension.ToLower = ".gif" Then

                    filename = My.Computer.FileSystem.GetName(filepath)

                    If Not imageCollection.ContainsKey(filename) Then

                        imageCollection.Add(filename, filepath)
                        cmbPaths.Items.Add(filename)

                    End If

                End If

            Next
            lblCount.Text = "Count: " & (cmbPaths.Items.Count.ToString)
        End If
    End Sub

    Private Sub mnuOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOne.Click

        slideDelay = 1000

        mnuOne.Checked = True
        mnuTwo.Checked = False
        mnuThree.Checked = False
        mnuFour.Checked = False
        mnuFive.Checked = False

    End Sub

    Private Sub mnuTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTwo.Click

        slideDelay = 2000

        mnuOne.Checked = False
        mnuTwo.Checked = True
        mnuThree.Checked = False
        mnuFour.Checked = False
        mnuFive.Checked = False

    End Sub

    Private Sub mnuThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThree.Click

        slideDelay = 3000

        mnuOne.Checked = False
        mnuTwo.Checked = False
        mnuThree.Checked = True
        mnuFour.Checked = False
        mnuFive.Checked = False

    End Sub

    Private Sub mnuFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFour.Click

        slideDelay = 4000

        mnuOne.Checked = False
        mnuTwo.Checked = False
        mnuThree.Checked = False
        mnuFour.Checked = True
        mnuFive.Checked = False

    End Sub

    Private Sub mnuFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFive.Click

        slideDelay = 5000

        mnuOne.Checked = False
        mnuTwo.Checked = False
        mnuThree.Checked = False
        mnuFour.Checked = False
        mnuFive.Checked = True

    End Sub

    Private Sub mnuCustomDelay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomDelay.Click
        Dim ret As String = InputBox("Type in the seconds value for the slideshow delay...", _
            " Type in the SlideShow Delay in Seconds", "6")

        If Not String.IsNullOrEmpty(ret) Then

            slideDelay = Val(ret * 1000)

            mnuOne.Checked = False
            mnuTwo.Checked = False
            mnuThree.Checked = False
            mnuFour.Checked = False
            mnuFive.Checked = False

        End If
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click
        pic.Focus()
    End Sub

    Private Sub frmMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        pic.Focus()
    End Sub

    Private Sub tsMnuNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuNormal.Click

        pic.SizeMode = PictureBoxSizeMode.Normal

        tsMnuNormal.Checked = True
        tsMnuStretch.Checked = False
        tsMnuAutosize.Checked = False
        tsMnuCenter.Checked = False
        tsMnuZoom.Checked = False

    End Sub

    Private Sub tsMnuStretch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuStretch.Click

        pic.SizeMode = PictureBoxSizeMode.StretchImage

        tsMnuNormal.Checked = False
        tsMnuStretch.Checked = True
        tsMnuAutosize.Checked = False
        tsMnuCenter.Checked = False
        tsMnuZoom.Checked = False

    End Sub

    Private Sub tsMnuAutosize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuAutosize.Click

        pic.SizeMode = PictureBoxSizeMode.AutoSize

        tsMnuNormal.Checked = False
        tsMnuStretch.Checked = False
        tsMnuAutosize.Checked = True
        tsMnuCenter.Checked = False
        tsMnuZoom.Checked = False

    End Sub

    Private Sub tsMnuCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuCenter.Click

        pic.SizeMode = PictureBoxSizeMode.CenterImage

        tsMnuNormal.Checked = False
        tsMnuStretch.Checked = False
        tsMnuAutosize.Checked = False
        tsMnuCenter.Checked = True
        tsMnuZoom.Checked = False

    End Sub

    Private Sub tsMnuZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuZoom.Click

        pic.SizeMode = PictureBoxSizeMode.Zoom

        tsMnuNormal.Checked = False
        tsMnuStretch.Checked = False
        tsMnuAutosize.Checked = False
        tsMnuCenter.Checked = False
        tsMnuZoom.Checked = True

    End Sub

    Private Sub cmbPaths_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPaths.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmbPaths.Items.Remove(cmbPaths.SelectedItem)
        End If
    End Sub

    Private Sub cmbPaths_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPaths.SelectedIndexChanged

        Dim index As Integer
        index = imageCollection.IndexOfKey(cmbPaths.SelectedItem)
        If Not index = -1 Then
            pic.Image = Image.FromFile(imageCollection.Item(cmbPaths.SelectedItem))
            pnl.AutoScrollPosition = New Point(0, 0)
            lblWidth.Text = "Width: " & pic.Image.Width.ToString
            lblHeight.Text = "Height: " & pic.Image.Height.ToString

        End If

    End Sub

    Sub loadAndSetSoundFile(ByVal soundPath As String)

        soundToPlay = soundPath

        Dim fileToPlay As String = Chr(34) + (soundPath) + Chr(34)

        mciSendString("close soundFile", Nothing, 0, 0)

        mciSendString("open " & fileToPlay & " alias soundFile", Nothing, 0, 0)

    End Sub

    Sub playSoundFile()

        mciSendString("play soundFile", Nothing, 0, 0)

    End Sub

    Sub stopSound()

        If mediaIsPlaying() Then

            mciSendString("stop soundFile", Nothing, 0, 0)

        End If

    End Sub

    Sub pausePlay()

        If mediaIsPlaying() Then

            mciSendString("pause soundFile", Nothing, 0, 0)

        End If

    End Sub

    Sub resumePlay()

        mciSendString("resume soundFile", Nothing, 0, 0)

    End Sub

    Function mediaIsPlaying() As Boolean

        Dim stat As String = Space(128)

        mciSendString("status soundFile mode", stat, 128, 0)

        If stat.StartsWith("playing") Then

            Return True

        Else

            Return False

        End If

        stat = Nothing

    End Function

    Sub slideshow(Optional ByVal playSound As Boolean = True)

        Dim count As Integer = cmbPaths.Items.Count

        If count <= 0 Then Exit Sub

        If playSound AndAlso My.Computer.FileSystem.FileExists(soundToPlay) Then

            tsBtnPlaySound.PerformClick()

        ElseIf playSound AndAlso Not My.Computer.FileSystem.FileExists(soundToPlay) Then
            tsBtnOpenSound.PerformClick()

            If My.Computer.FileSystem.FileExists(soundToPlay) Then
                tsBtnPlaySound.PerformClick()

            End If

        End If

        Dim start As Integer = cmbPaths.SelectedIndex

        Do ' : My.Application.DoEvents()

            cmbPaths.SelectedIndex = start
            pause(slideDelay)

            start += 1

            If start >= count Then

                start = 0

            End If

        Loop Until stopSlideShow

    End Sub

    Private Sub pause(ByVal delay As Integer)

        Dim s As Integer = Environment.TickCount
        Dim e As Integer = 0

        Do : My.Application.DoEvents()

            Threading.Thread.Sleep(1)
            e = Environment.TickCount

        Loop Until (e - s) >= delay

    End Sub

    Private Sub tsBtnOpenSound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnOpenSound.Click

        Dim openSound As New OpenFileDialog

        openSound.Filter = "Sound Files (*.mp3, *.mid, *.wav, *wma|*.mp3; *.mid; *.wav; *wma"

        If openSound.ShowDialog = Windows.Forms.DialogResult.OK Then

            loadAndSetSoundFile(openSound.FileName)

            tsBtnPlaySound.Enabled = True
            tsBtnStopSound.Enabled = False

        End If
    End Sub

    Private Sub tsBtnStopSound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnStopSound.Click
        stopSound()
        tsBtnPlaySound.Enabled = True
        tsBtnStopSound.Enabled = False
    End Sub

    Private Sub tsBtnPlaySound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnPlaySound.Click
        playSoundFile()
        tsBtnPlaySound.Enabled = False
        tsBtnStopSound.Enabled = True
    End Sub

    Private Sub tsBtnRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnRotateLeft.Click
        pic.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        pic.Refresh()
    End Sub

    Private Sub tsBtnRotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnRotateRight.Click
        pic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pic.Refresh()
    End Sub

    Private Sub pnl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl.Click
        pic.Focus()
    End Sub

    Private Sub tsMnuSizeToView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMnuSizeToView.Click
        pic.Size = pnl.Size
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mciSendString("close all", 0, 0, 0)
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class