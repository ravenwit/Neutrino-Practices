Public Class frmFileManipulation
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(8, 8)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(80, 25)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Source"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(95, 10)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(184, 20)
        Me.txtSource.TabIndex = 1
        Me.txtSource.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(8, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Destination"
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(95, 40)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(184, 20)
        Me.txtDestination.TabIndex = 3
        Me.txtDestination.Text = ""
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(8, 72)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(80, 25)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy"
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(8, 104)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(80, 25)
        Me.btnMove.TabIndex = 5
        Me.btnMove.Text = "Move"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(8, 136)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 25)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        '
        'frmFileManipulation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 237)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.btnMove, Me.btnCopy, Me.txtDestination, Me.btnSave, Me.txtSource, Me.btnOpenFile})
        Me.Name = "frmFileManipulation"
        Me.Text = "File Manupulation project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Title = "Select a File"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            txtSource.Text = OpenFileDialog1.FileName
        Else
            txtSource.Text = " "
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        SaveFileDialog1.Title = "Specity Destination Filename"
        SaveFileDialog1.Filter = "Text Files| *.txt"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.OverwritePrompt = True
        If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            txtDestination.Text = SaveFileDialog1.FileName
        End If

    End Sub

    Private Sub frmFileManipulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Function SourceFileExists() As Boolean
        If Not (System.IO.File.Exists(txtSource.Text)) Then
            MsgBox("The File does not exists! ", MsgBoxStyle.Exclamation)
        Else
            SourceFileExists = True
        End If
    End Function

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If Not (SourceFileExists()) Then Exit Sub
        System.IO.File.Copy(txtSource.Text, txtDestination.Text)
        MsgBox("The file has been suceessfully copied.")

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If Not (SourceFileExists()) Then Exit Sub
        System.IO.File.Move(txtSource.Text, txtDestination.Text)
        MsgBox("The file has been suceessfully Moved.")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If Not (SourceFileExists()) Then Exit Sub

        If MsgBox("Are you want to delete the file.?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            System.IO.File.Delete(txtSource.Text)
            MsgBox("The file has been suceessfully Deleted.")
        End If
    End Sub
End Class
