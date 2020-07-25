Public Class Settings
    Dim BgColor As Color
    Dim BgImage As String
    Dim stpFont As Font
    Dim stpForecolor As Color

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.IsBgColor = True Then radBgColor.Checked = True
        If My.Settings.IsBgImage = True Then radBgImage.Checked = True
        txtBgColor.Text = My.Settings.BgColor.ToString
        txtBgImage.Text = My.Computer.FileSystem.GetName(My.Settings.BgImage.ToString).ToString
        txtFont.Text = My.Settings.Font.ToString
        txtForecolor.Text = My.Settings.Forecolor.ToString
    End Sub

    Private Sub radBgColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBgColor.CheckedChanged
        If radBgColor.Checked = True Then
            txtBgColor.Enabled = True
            txtBgImage.Enabled = False
            btnBgColor.Enabled = True
            btnBgImage.Enabled = False
            My.Settings.IsBgColor = True
            My.Settings.IsBgImage = False
        End If
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub
    Private Sub radBgImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBgImage.CheckedChanged
        If radBgImage.Checked = True Then
            txtBgImage.Enabled = True
            txtBgColor.Enabled = False
            btnBgImage.Enabled = True
            btnBgColor.Enabled = False
            My.Settings.IsBgImage = True
            My.Settings.IsBgColor = False
        End If
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub

    Private Sub btnBgColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBgColor.Click
        Dim dlBgColor As New ColorDialog
        Try
            If dlBgColor.ShowDialog = DialogResult.OK Then
                BgColor = dlBgColor.Color
                txtBgColor.Text = dlBgColor.Color.ToString
                My.Settings.BgColor = dlBgColor.Color
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub

    Private Sub btnBgImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBgImage.Click
        Dim dlBgImage As New OpenFileDialog
        dlBgImage.Title = "Choose an image..."
        dlBgImage.Multiselect = False
        dlBgImage.Filter = "Image Files (*.jpg, *.jpeg, *.png, *bmp, *.gif, *.tiff, *.wmf)|*.jpg; *.jpeg; *.png; *bmp; *.gif, *.tiff, *.wmf"
        Try
            If dlBgImage.ShowDialog = DialogResult.OK Then
                BgImage = dlBgImage.FileName
                txtBgImage.Text = dlBgImage.SafeFileName
                My.Settings.BgImage = dlBgImage.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        Dim dlFont As New FontDialog
        Try
            If dlFont.ShowDialog = DialogResult.OK Then
                txtFont.Text = dlFont.Font.ToString
                stpFont = dlFont.Font
                My.Settings.Font = dlFont.Font
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub

    Private Sub btnForecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForecolor.Click
        Dim dlForecolor As New ColorDialog
        Try
            If dlForecolor.ShowDialog = DialogResult.OK Then
                txtForecolor.Text = dlForecolor.Color.ToString
                stpForecolor = dlForecolor.Color
                My.Settings.Forecolor = dlForecolor.Color
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        My.Settings.Save()
        Neutrino_StopWatch.Activate()
        Me.Activate()
    End Sub

  
End Class