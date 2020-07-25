Public Class Options
    Dim RootDir_temp As String
    Dim blnEncryptFile_temp As Boolean
    Dim MasterKey As String
    Dim blnDiffKey_temp As Boolean

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With My.Settings
            Me.chkMasterKey.Checked = Not .blnDiffKey
            Me.chkEncryptFile.Checked = .blnEncryptFile
            Me.txtMasterKey.Text = .MasterKey

        End With
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFolder As New FolderBrowserDialog
        openFolder.Description = "Browse to specify root directory"
        Try
            If openFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtRootDir.Text = openFolder.SelectedPath
                RootDir_temp = txtRootDir.Text
            End If
        Catch ex As Exception
            MsgBox("Error occured while selecting root directory" & vbCrLf & "Error Description : " & ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub

    Private Sub txtRootDir_TextChanged(sender As Object, e As EventArgs) Handles txtRootDir.TextChanged
        RootDir_temp = txtRootDir.Text

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkEncryptFile.CheckedChanged
        If chkEncryptFile.Checked Then
            blnEncryptFile_temp = True
        Else
            blnEncryptFile_temp = False
        End If
    End Sub

    Private Sub chkMasterKey_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasterKey.CheckedChanged
        If chkMasterKey.Checked Then
            txtMasterKey.Enabled = True
            blnDiffKey_temp = False
        Else
            txtMasterKey.Enabled = False
            blnDiffKey_temp = True
        End If
    End Sub

    Private Sub txtMasterKey_TextChanged(sender As Object, e As EventArgs) Handles txtMasterKey.TextChanged
        MasterKey = txtMasterKey.Text
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With My.Settings
            .blnDiffKey = blnDiffKey_temp
            .blnEncryptFile = blnEncryptFile_temp
            .MasterKey = MasterKey
            .Save()
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

   
End Class