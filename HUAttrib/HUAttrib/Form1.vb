Public Class frmMain
    Private Function stringout(ByVal RadioButton As RadioButton) As String
        Dim s_out As String = Nothing
        If RadioButton.Checked = True Then
            s_out = "+h +s"
        ElseIf RadioButton.Checked = False Then
            s_out = "-h -s"
        End If
        Return s_out
    End Function
    Dim Path As String = Nothing

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radbtnFile.Checked = True
        radbtnUnhide.Checked = True
        Path = Nothing

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        If radbtnFile.Checked = True Then
            Try
                Shell("cmd.exe /c" + " attrib " + stringout(radbtnHide) + " " + """" + Path + """")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf radbtnFolder.Checked = True Then
            Try

                Shell("cmd.exe /c" + " attrib  " + stringout(radbtnHide) + " " + """" + Path + """" + " /S /D")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Error")

        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        Dim openFolder As New FolderBrowserDialog

        openFile.Multiselect = False
        openFile.RestoreDirectory = True
        openFolder.ShowNewFolderButton = False

        If radbtnFile.Checked = True Then
            If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                Path = openFile.FileName
                txtPath.Text = Path
            End If
        ElseIf radbtnFolder.Checked = True Then
            If openFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
                Path = openFolder.SelectedPath
                txtPath.Text = Path
            End If
        Else
            MsgBox("Error!" & vbCrLf & "What did you do!?")
        End If
    End Sub
End Class
