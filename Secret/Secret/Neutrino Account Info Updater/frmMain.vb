Public Class frmMain
    Dim IsSave As Boolean = True
    Dim IsCancel As Boolean = False
    Dim saveFile As New SaveFileDialog
    Dim strFileName As String = Nothing

    Private Sub SetPropertyOfSave()
        With saveFile
            .Dispose()
            .AddExtension = True
            .AutoUpgradeEnabled = True
            .DefaultExt = "Text Documents (*.txt)|*.txt|Rich Text Documents (*.rtf)|*.rtf|All Files (*.*)|*.*"
            .Filter = "Text Documents (*.txt)|*.txt|Rich Text Documents (*.rtf)|*.rtf|All Files (*.*)|*.*"
            .OverwritePrompt = True
            .RestoreDirectory = True
            .ShowHelp = True
            .Title = "Save As..."
        End With
    End Sub

    Private Sub SavePrompt(ByVal Caller As String)
        Dim msgSavePrompt = MsgBox("Do you want to save changes to current file?", MsgBoxStyle.YesNoCancel, Application.ProductName)
        Select Case msgSavePrompt
            Case MsgBoxResult.Yes
                SetPropertyOfSave()
                If saveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtEditor.Text, False)
                End If
            Case MsgBoxResult.No
                Select Case Caller.ToLower
                    Case "new"
                        txtEditor.Text = Nothing
                        txtEditor.Refresh()
                    Case "end"
                        End
                    Case "open"
                        'Do Nothing
                End Select
            Case MsgBoxResult.Cancel
                If Caller.ToLower = "open" Then
                    IsCancel = True
                End If
                Exit Sub
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With UndoToolStripMenuItem
            If txtEditor.CanUndo Then
                .Enabled = True
            Else
                .Enabled = False
            End If
        End With

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If IsSave Then
            txtEditor.Text = Nothing
        Else
            SavePrompt("new")
        End If
        strFileName = Nothing
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dlgOpenFile As New OpenFileDialog
        With dlgOpenFile
            .AddExtension = True
            .AutoUpgradeEnabled = True
            .DefaultExt = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
            .Filter = "Text Documents (*.txt)|*.txt|Rich Text Documents (*.rtf)|*.rtf|All Files (*.*)|*.*"
            .Multiselect = False
            .RestoreDirectory = True
            .ShowReadOnly = True
            .Title = "Open a file"
        End With
        If IsSave Then
            GoTo OpenTheFile
        Else
            SavePrompt("new")
            If Not IsCancel Then
                GoTo OpenTheFile
            End If
        End If

OpenTheFile:
        Try
            If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtEditor.Text = My.Computer.FileSystem.ReadAllText(dlgOpenFile.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, "Error opening file")
        End Try
        strFileName = dlgOpenFile.FileName
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If IsNothing(strFileName) Then
            SaveAsToolStripMenuItem.PerformClick()
        Else
            Try
                My.Computer.FileSystem.WriteAllText(strFileName, txtEditor.Text, False)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error saving file")
            End Try
        End If
        'txtEditor.DeselectAll()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SetPropertyOfSave()
        Try
            If saveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtEditor.Text, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error saving file")
        End Try
        'txtEditor.DeselectAll()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If IsSave Then
            End
        Else
            SavePrompt("end")
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If txtEditor.CanUndo Then
            txtEditor.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        txtEditor.ClearUndo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtEditor.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtEditor.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtEditor.Paste()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        
        Find.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Find.MdiParent = Me
        Find.Show()
    End Sub

    Private Sub GotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GotoToolStripMenuItem.Click
        Dim getLine As Integer = InputBox("Enter Line Number", "Go To")
        Try
            If getLine < txtEditor.Lines.Count And getLine > 0 Then
                txtEditor.Select(txtEditor.GetFirstCharIndexFromLine(getLine - 1), 0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, ex.Source)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtEditor.SelectAll()
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        txtEditor.SelectedText = Now.ToString
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim ChooseFont As New FontDialog
        With ChooseFont
            .AllowVectorFonts = True
            .AllowVerticalFonts = True
            .ShowApply = True
            .ShowColor = True
            .ShowEffects = True
            .ShowHelp = True
        Try
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    txtEditor.Font = .Font
                    txtEditor.ForeColor = .Color
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, ex.Source)
        End Try
        End with
    End Sub

   
End Class
