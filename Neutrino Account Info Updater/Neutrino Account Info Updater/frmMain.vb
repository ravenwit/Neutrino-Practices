﻿Public Class frmMain
    Dim IsSave As Boolean = True
    Dim IsCancel As Boolean = False
    Dim saveFile As New SaveFileDialog
    Public strFileName As String = Nothing
    Private Enum Caller As Integer
        NewFile = 0
        OpenFile = 1
        NewAccount = 2
        OpenAccount = 3
    End Enum

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

    Private Sub SavePrompt(ByVal CallerName As Integer)
        Dim msgSavePrompt = MsgBox("Do you want to save changes to current file?", MsgBoxStyle.YesNoCancel, Application.ProductName)
        Select Case msgSavePrompt
            Case MsgBoxResult.Yes
                SetPropertyOfSave()
                Try
                    If saveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtEditor.Text, False)
                    End If
                Catch ex As Exception
                    MsgBox("Error occured while saving the file." & vbCrLf & "Error Description :" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel, "Error...")
                Finally

                End Try
            Case MsgBoxResult.No
                Select Case CallerName
                    Case Caller.NewFile
                        txtEditor.Text = Nothing
                        txtEditor.Refresh()
                    Case Caller.OpenFile
                        'Do Nothing
                    Case Else
                        End
                End Select
            Case MsgBoxResult.Cancel
                If CallerName = Caller.OpenFile Or Caller.OpenAccount Then
                    IsCancel = True
                End If
                Exit Sub
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.rootDir) Or Not My.Settings.rootDir > 0 Then
            Dim MsgAsk = MsgBox("Root directory path is not valid or empty. Do you want to specify a valid path for root directory now? You can change it later in options.", MsgBoxStyle.YesNo, "Specify Root Directory")
            If MsgAsk = MsgBoxResult.Yes Then
                Dim openRoot As New FolderBrowserDialog
                openRoot.ShowNewFolderButton = True
                Try
                    If openRoot.ShowDialog = Windows.Forms.DialogResult.OK Then
                        My.Settings.rootDir = openRoot.SelectedPath
                        My.Settings.Save()
                    End If
                Catch ex As Exception
                    MsgBox("Error occured while selecting directory path." & vbCrLf & "Message Dexcription : " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel, "Error...")
                End Try
            End If
        End If
        Timer1.Enabled = True
        Timer1.Interval = 1
        tsBtnNew.Image = NewToolStripMenuItem.Image
        tsBtnOpen.Image = OpenToolStripMenuItem.Image
        tsBtnSave.Image = SaveToolStripMenuItem.Image
        tsBtnCut.Image = CutToolStripMenuItem.Image
        tsBtnCopy.Image = CopyToolStripMenuItem.Image
        tsBtnPaste.Image = PasteToolStripMenuItem.Image
        tsBtnUndo.Image = UndoToolStripMenuItem.Image
        tsBtnRedo.Image = RedoToolStripMenuItem.Image
        tsBtnDelete.Image = DeleteToolStripMenuItem.Image
        tsBtnFind.Image = FindToolStripMenuItem.Image
        tsBtnFont.Image = FontToolStripMenuItem.Image
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

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click, tsBtnNewFile.Click
        If IsSave Then
            txtEditor.Text = Nothing
            strFileName = Nothing
        Else
            SavePrompt("new")
        End If
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAccountToolStripMenuItem.Click, tsBtnNewAccount.Click
        If IsSave Then

        Else
            SavePrompt("new")
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click, tsBtnOpenFile.Click
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
                strFileName = dlgOpenFile.FileName
            End If
        Catch ex As Exception
            Dim errMsg = MsgBox("Error occured while opening the file." & vbCrLf & "Error Description : " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel, "Error...")
            If errMsg = MsgBoxResult.Retry Then
                GoTo OpenTheFile
            End If
        End Try
    End Sub

    Private Sub OpenAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAccountToolStripMenuItem.Click, tsBtnOpenAccount.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, tsBtnSave.Click
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

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click, tsBtnUndo.Click
        If txtEditor.CanUndo Then
            txtEditor.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click, tsBtnRedo.Click
        txtEditor.ClearUndo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click, tsBtnCut.Click
        txtEditor.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, tsBtnCopy.Click
        txtEditor.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click, tsBtnPaste.Click
        txtEditor.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click, tsBtnDelete.Click
        If Not IsNothing(txtEditor.SelectedText) Then
            txtEditor.SelectedText = Nothing
        End If
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
            MsgBox("Check your input and try again." & vbCrLf & ex.Message.ToString, MsgBoxStyle.Exclamation, ex.Source)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtEditor.SelectAll()
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        txtEditor.SelectedText = Now.ToString
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click, tsBtnFont.Click
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
        End With
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.ShowDialog()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class
