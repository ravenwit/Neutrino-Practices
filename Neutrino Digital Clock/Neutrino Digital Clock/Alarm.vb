Public Class Alarm

    Private Sub Alarm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpAlarmTime.Value = My.Settings.AlarmTime
        If My.Settings.Alarm = True Then
            pnlAlarm.Enabled = True
            chkAlarm.Checked = True
            If My.Settings.AlarmCustom = True Then
                Panel2.Enabled = True
                If My.Settings.AlarmTone = True Then
                    radAlarmTone.Checked = True
                    txtAlarmTone.Enabled = True
                    txtAlarmTone.Text = My.Computer.FileSystem.GetName(My.Settings.AlarmPath)
                    btnBrowse.Enabled = True
                Else
                    radAlarmText.Checked = False
                    txtAlarmTone.Enabled = False
                    btnBrowse.Enabled = False
                End If
                If My.Settings.AlarmText = True Then
                    radAlarmText.Checked = True
                    txtAlarmText.Enabled = True
                    txtAlarmText.Text = My.Settings.AlarmPathText.ToString
                Else
                    radAlarmText.Checked = False
                    txtAlarmText.Enabled = False
                End If
            Else
                Panel2.Enabled = False
            End If
        Else
            pnlAlarm.Enabled = False
            chkAlarm.Checked = False
        End If
        Me.cmbAlarmTheme.SelectedIndex = My.Settings.AlarmTheme
        If My.Settings.AlarmTheme = 1 Or My.Settings.AlarmTheme = 2 Then
            pnlAlarmAppearence.Enabled = False
        ElseIf My.Settings.AlarmTheme = 0 Then
            pnlAlarmAppearence.Enabled = True
        End If
        If My.Settings.AlarmIsColor = True Then radAlarmBcolor.Checked = True Else radAlarmBImage.Checked = True
        txtAlarmBcolor.Text = My.Settings.AlarmColor.ToString
        txtAlarmBimage.Text = My.Computer.FileSystem.GetFileInfo(My.Settings.AlarmImage).Name
        txtAlarmTextDisplay.Text = My.Settings.AlarmAlertText
    End Sub
    Private Sub dtpAlarmTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpAlarmTime.ValueChanged
        My.Settings.AlarmTime = dtpAlarmTime.Value
        My.Settings.Save()
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCustom.CheckedChanged
        If chkCustom.Checked = True Then
            My.Settings.AlarmCustom = True
            Panel2.Enabled = True
        Else
            My.Settings.AlarmCustom = False
            Panel2.Enabled = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub chkTone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAlarmTone.CheckedChanged
        If radAlarmTone.Checked = True Then
            txtAlarmTone.Enabled = True
            txtAlarmTone.Text = My.Computer.FileSystem.GetName(My.Settings.AlarmPath)
            btnBrowse.Enabled = True
            My.Settings.AlarmTone = True
            My.Settings.AlarmText = False
        Else
            txtAlarmTone.Enabled = False
            btnBrowse.Enabled = False
            My.Settings.AlarmTone = False
            My.Settings.AlarmText = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub chkText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAlarmText.CheckedChanged
        If radAlarmText.Checked = True Then
            txtAlarmText.Enabled = True
            txtAlarmText.Text = My.Settings.AlarmPathText
            My.Settings.AlarmText = True
            My.Settings.AlarmTone = False
        Else
            txtAlarmText.Enabled = False
            My.Settings.AlarmText = False
            My.Settings.AlarmTone = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim ToneOpen As New OpenFileDialog
        ToneOpen.Title = "Choose an alarm tone"
        ToneOpen.Filter = "Sound Files (*.mp3, *.mid, *.wav, *wma|*.mp3; *.mid; *.wav; *wma"
        ToneOpen.RestoreDirectory = True
        ToneOpen.Multiselect = False
        Try
            If ToneOpen.ShowDialog = DialogResult.OK Then
                My.Settings.AlarmPath = ToneOpen.FileName
                txtAlarmTone.Text = ToneOpen.SafeFileName
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtAlarmText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlarmText.TextChanged
        On Error Resume Next
        My.Settings.AlarmPathText = txtAlarmText.Text.ToString
        My.Settings.Save()
    End Sub

    Private Sub chkAlarm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlarm.CheckedChanged
        If chkAlarm.Checked = True Then
            pnlAlarm.Enabled = True
            My.Settings.Alarm = True
        ElseIf chkAlarm.Checked = False Then
            pnlAlarm.Enabled = False
            My.Settings.Alarm = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        stopSound()
    End Sub

    Private Sub cmbAlarmTone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlarmTone.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlarmTheme.SelectedIndexChanged
        My.Settings.AlarmTheme = cmbAlarmTheme.SelectedIndex
        If cmbAlarmTheme.SelectedIndex = 1 Or cmbAlarmTheme.SelectedIndex = 2 Then
            pnlAlarmAppearence.Enabled = False
        ElseIf cmbAlarmTheme.SelectedIndex = 0 Then
            pnlAlarmAppearence.Enabled = True
        End If
        My.Settings.Save()
        AlarmAlert.Activate()
    End Sub

    Private Sub radAlarmBcolor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAlarmBcolor.CheckedChanged
        If radAlarmBcolor.Checked = True Then
            My.Settings.AlarmIsColor = True
            radAlarmBImage.Checked = False
            cmbAlarmBLayout.Enabled = False
            btnAlarmBimage.Enabled = False
        Else
            My.Settings.AlarmIsColor = False
            radAlarmBImage.Checked = True
            cmbAlarmBLayout.Enabled = True
            btnAlarmBimage.Enabled = True
        End If
        My.Settings.Save()
        AlarmAlert.Activate()
    End Sub

    Private Sub btnAlarmBcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarmBcolor.Click
        Dim alarmBackgroundColor As New ColorDialog
        alarmBackgroundColor.AllowFullOpen = True
        Try
            If alarmBackgroundColor.ShowDialog = DialogResult.OK Then
                My.Settings.AlarmColor = alarmBackgroundColor.Color
                txtAlarmBcolor.Text = alarmBackgroundColor.Color.ToString
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        AlarmAlert.Activate()
    End Sub

    Private Sub radAlarmBImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAlarmBImage.CheckedChanged
        If radAlarmBImage.Checked = True Then
            My.Settings.AlarmIsColor = False
            cmbAlarmBLayout.Enabled = True
            btnAlarmBimage.Enabled = True
        Else
            My.Settings.AlarmIsColor = True
            cmbAlarmBLayout.Enabled = False
            btnAlarmBimage.Enabled = False
        End If
        My.Settings.Save()
        AlarmAlert.Activate()
    End Sub

    Private Sub btnAlarmBimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarmBimage.Click
        Dim alarmBackgroundImage As New OpenFileDialog
        alarmBackgroundImage.Title = "Choose an image..."
        alarmBackgroundImage.Multiselect = False
        alarmBackgroundImage.Filter = "Image Files (*.jpg, *.jpeg, *.png, *bmp, *.gif, *.tiff, *.wmf)|*.jpg; *.jpeg; *.png; *bmp; *.gif, *.tiff, *.wmf"
        Try
            If alarmBackgroundImage.ShowDialog = DialogResult.OK Then
                My.Settings.AlarmImage = alarmBackgroundImage.FileName
                txtAlarmBimage.Text = alarmBackgroundImage.SafeFileName
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        AlarmAlert.Activate()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlarmBLayout.SelectedIndexChanged
        Select Case cmbAlarmBLayout.SelectedIndex
            Case 0
                AlarmAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Case 1
                AlarmAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
            Case 2
                AlarmAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Case 3
                AlarmAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Case 4
                AlarmAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        End Select
        My.Settings.Save()
        AlarmAlert.Activate()

    End Sub

    Private Sub txtAlarmTextDisplay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlarmTextDisplay.TextChanged
        My.Settings.AlarmAlertText = txtAlarmTextDisplay.Text
        My.Settings.Save()
        AlarmAlert.Activate()
    End Sub

 
    Private Sub lnkPreview_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPreview.LinkClicked
        AlarmAlert.Show()

    End Sub

End Class