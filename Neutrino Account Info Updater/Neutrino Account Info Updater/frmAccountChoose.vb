Public Class frmAccountChoose
    Private intDialogMode As Integer
    Public Enum AccountDialogMode As Integer
        OpenAccount = 0
        NewAccount = 1
    End Enum

    Public Sub OpenAccountChooseDialog(Optional ByVal DialogMode As Integer = 0)
        If AccountDialogMode.OpenAccount Then
            txtAccountName.Visible = False
            cmbName.Visible = True
        ElseIf AccountDialogMode.NewAccount Then
            txtAccountName.Visible = True
            cmbName.Visible = False
        End If
        intDialogMode = DialogMode
    End Sub

    Private Function CurrentDirectory() As String
        Dim CurrDir As String
        If Not IsNothing(cmbDir2.SelectedItem) Then
            CurrDir = My.Settings.rootDir & "\" & cmbDir1.SelectedItem.ToString & "\" & cmbDir2.SelectedItem.ToString
        Else
            CurrDir = My.Settings.rootDir & "\" & cmbDir1.SelectedItem.ToString
        End If
        Return CurrDir
    End Function

    Private Sub frmAccountChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDir2.Visible = False
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.rootDir) Or Not My.Settings.rootDir.Length > 0 Then
            Try
                For Each Dir As String In My.Computer.FileSystem.GetDirectories(My.Settings.rootDir)
                    cmbDir1.Items.Add(Dir)
                Next
            Catch ex As Exception
                MsgBox("Error occured while getting account infos from " & My.Settings.rootDir & "." & vbCrLf & "Message Description : " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel, "Error...")
            End Try
        Else
            MsgBox("Unable to locate the root directory you specified. It is either not valid or empty. Check your root directory path in option.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid root directory.")
        End If
       
    End Sub

    Private Sub cmbDir1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDir1.SelectedIndexChanged, cmbDir2.SelectedIndexChanged
        CreateList(sender, CurrentDirectory())
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Select Case intDialogMode
            Case 0
                If cmbName.SelectedItem.ToString.Length > 0 Then
                    frmMain.strFileName = My.Settings.rootDir & "\" & cmbDir1.SelectedItem.ToString & "\" & cmbDir2.SelectedItem.ToString & "\" & cmbName.SelectedItem.ToString
                    Try
                        frmMain.txtEditor.Text = My.Computer.FileSystem.ReadAllText(frmMain.strFileName)
                    Catch ex As Exception
                        MsgBox("Error occured while opening account info." & vbCrLf & "Error Description : " & ex.Message, MsgBoxStyle.Exclamation, "Error...")
                    End Try
                End If
            Case 1
                If txtAccountName.Text.ToString.Length > 0 Then
                    frmMain.strFileName = My.Settings.rootDir & "\" & cmbDir1.SelectedItem.ToString & "\" & cmbDir2.SelectedItem.ToString & "\" & txtAccountName.Text.ToString
                    frmMain.txtEditor.Text = Nothing
                End If
        End Select
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CreateList(ByVal Sender As Object, ByVal Directory As String)
        Dim IsFinalDir As Boolean = False
        Dim IsValid As Boolean = False
        If Sender.ToString.Contains("cmbDir1") Then cmbDir2.Items.Clear()
        cmbName.Items.Clear()
        With My.Computer.FileSystem
            For Each Dir As String In .GetDirectories(Directory)
                For Each File As String In .GetFiles(Dir)
                    If .GetFileInfo(File).Name = "Account Info.aci" Then
                        IsFinalDir = True
                    ElseIf Not .GetFileInfo(File).Extension = ".aci" Then
                    Else
                        IsValid = True
                    End If
                Next
                If IsFinalDir Then
                    cmbName.Items.Add(Dir)
                ElseIf IsValid Then
                    cmbDir2.Items.Add(Dir)
                End If
            Next
        End With
        If Not IsNothing(cmbDir2.Items) Then
            cmbDir2.Visible = True
        End If
    End Sub

End Class