Option Strict On
Public Class TextEditor
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FileNew As System.Windows.Forms.MenuItem
    Friend WithEvents FileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents FileSave As System.Windows.Forms.MenuItem
    Friend WithEvents FileSaveAs As System.Windows.Forms.MenuItem
    Friend WithEvents EditUndo As System.Windows.Forms.MenuItem
    Friend WithEvents FileExit As System.Windows.Forms.MenuItem
    Friend WithEvents EditCopy As System.Windows.Forms.MenuItem
    Friend WithEvents EditCut As System.Windows.Forms.MenuItem
    Friend WithEvents EditPaste As System.Windows.Forms.MenuItem
    Friend WithEvents EditSelect As System.Windows.Forms.MenuItem
    Friend WithEvents EditFind As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessUpper As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessLower As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessNumber As System.Windows.Forms.MenuItem
    Friend WithEvents CustomizeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents CustomizeFont As System.Windows.Forms.MenuItem
    Friend WithEvents CustomizePageColor As System.Windows.Forms.MenuItem
    Friend WithEvents CustomizeTextColor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Editor As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CustomizePageColor = New System.Windows.Forms.MenuItem()
        Me.EditCut = New System.Windows.Forms.MenuItem()
        Me.ProcessUpper = New System.Windows.Forms.MenuItem()
        Me.FileOpen = New System.Windows.Forms.MenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.EditSelect = New System.Windows.Forms.MenuItem()
        Me.EditPaste = New System.Windows.Forms.MenuItem()
        Me.EditMenu = New System.Windows.Forms.MenuItem()
        Me.EditUndo = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.EditCopy = New System.Windows.Forms.MenuItem()
        Me.EditFind = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.FileNew = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.FileSave = New System.Windows.Forms.MenuItem()
        Me.FileSaveAs = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.FileExit = New System.Windows.Forms.MenuItem()
        Me.ProcessMenu = New System.Windows.Forms.MenuItem()
        Me.ProcessLower = New System.Windows.Forms.MenuItem()
        Me.ProcessNumber = New System.Windows.Forms.MenuItem()
        Me.CustomizeMenu = New System.Windows.Forms.MenuItem()
        Me.CustomizeFont = New System.Windows.Forms.MenuItem()
        Me.CustomizeTextColor = New System.Windows.Forms.MenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Editor = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'CustomizePageColor
        '
        Me.CustomizePageColor.Index = 1
        Me.CustomizePageColor.Text = "Page Color"
        '
        'EditCut
        '
        Me.EditCut.Index = 3
        Me.EditCut.Text = "Cut"
        '
        'ProcessUpper
        '
        Me.ProcessUpper.Index = 0
        Me.ProcessUpper.Text = "Upper Case"
        '
        'FileOpen
        '
        Me.FileOpen.Index = 1
        Me.FileOpen.Text = "Open"
        '
        'EditSelect
        '
        Me.EditSelect.Index = 5
        Me.EditSelect.Text = "Select All"
        '
        'EditPaste
        '
        Me.EditPaste.Index = 4
        Me.EditPaste.Text = "Paste"
        '
        'EditMenu
        '
        Me.EditMenu.Index = 1
        Me.EditMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.EditUndo, Me.MenuItem3, Me.EditCopy, Me.EditCut, Me.EditPaste, Me.EditSelect, Me.EditFind, Me.MenuItem4})
        Me.EditMenu.Text = "Edit"
        '
        'EditUndo
        '
        Me.EditUndo.Index = 0
        Me.EditUndo.Text = "Undo"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'EditCopy
        '
        Me.EditCopy.Index = 2
        Me.EditCopy.Text = "Copy"
        '
        'EditFind
        '
        Me.EditFind.Index = 6
        Me.EditFind.Text = "Find"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "-"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.EditMenu, Me.ProcessMenu, Me.CustomizeMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileNew, Me.FileOpen, Me.MenuItem1, Me.FileSave, Me.FileSaveAs, Me.MenuItem2, Me.FileExit})
        Me.FileMenu.Text = "File"
        '
        'FileNew
        '
        Me.FileNew.Index = 0
        Me.FileNew.Text = "New"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'FileSave
        '
        Me.FileSave.Index = 3
        Me.FileSave.Text = "Save"
        '
        'FileSaveAs
        '
        Me.FileSaveAs.Index = 4
        Me.FileSaveAs.Text = "Save As"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "-"
        '
        'FileExit
        '
        Me.FileExit.Index = 6
        Me.FileExit.Text = "Exit"
        '
        'ProcessMenu
        '
        Me.ProcessMenu.Index = 2
        Me.ProcessMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ProcessUpper, Me.ProcessLower, Me.ProcessNumber})
        Me.ProcessMenu.Text = "Process"
        '
        'ProcessLower
        '
        Me.ProcessLower.Index = 1
        Me.ProcessLower.Text = "Lower Case"
        '
        'ProcessNumber
        '
        Me.ProcessNumber.Index = 2
        Me.ProcessNumber.Text = "Lines Number"
        '
        'CustomizeMenu
        '
        Me.CustomizeMenu.Index = 3
        Me.CustomizeMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CustomizeFont, Me.CustomizePageColor, Me.CustomizeTextColor})
        Me.CustomizeMenu.Text = "Customize"
        '
        'CustomizeFont
        '
        Me.CustomizeFont.Index = 0
        Me.CustomizeFont.Text = "Font"
        '
        'CustomizeTextColor
        '
        Me.CustomizeTextColor.Index = 2
        Me.CustomizeTextColor.Text = "Text Color"
        '
        'Editor
        '
        Me.Editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Editor.HideSelection = False
        Me.Editor.MaxLength = 0
        Me.Editor.Multiline = True
        Me.Editor.Name = "Editor"
        Me.Editor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Editor.Size = New System.Drawing.Size(464, 273)
        Me.Editor.TabIndex = 0
        Me.Editor.Text = " Visual Basic and Visual C# Concepts   "
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'TextEditor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Editor})
        Me.Menu = Me.MainMenu1
        Me.Name = "TextEditor"
        Me.Text = "Text Editor Menu Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim SaveFileName As String
    Public Shared txtBox As TextBox
    Dim frm As New FindForm()

    Private Sub EditUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUndo.Click
        If EditUndo.Text = "Undo" Then
            Editor.Undo()
            EditUndo.Text = "Redo"
        Else
            Editor.Undo()
            EditUndo.Text = "Undo"
        End If
    End Sub

    Private Sub FileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSaveAs.Click
        SaveFileDialog1.DefaultExt = "TXT"
        SaveFileDialog1.Filter = "Text Files|*.TXT|HTML Files|*.HTM|All Files|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then Exit Sub
        Dim tWriter As System.IO.StreamWriter
        tWriter = New System.IO.StreamWriter(SaveFileDialog1.FileName)
        tWriter.Write(Editor.Text)
        tWriter.Close()
        tWriter = Nothing
        Editor.SelectionStart = 0
        Editor.SelectionLength = 0
        SaveFileName = SaveFileDialog1.FileName
        Editor.Modified = False
    End Sub

    Private Sub FileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSave.Click
        If SaveFileName = "" Then
            FileSaveAs_Click(sender, e)
            Exit Sub
        End If
        Dim TWriter As System.IO.StreamWriter
        TWriter = New System.IO.StreamWriter(SaveFileName)
        TWriter.Write(Editor.Text)
        TWriter.Close()
        TWriter = Nothing
        Editor.SelectionStart = 0
        Editor.SelectionLength = 0
        Editor.Modified = False
    End Sub

    Private Sub EditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCopy.Click
        Clipboard.SetDataObject(Editor.SelectedText)
    End Sub

    Private Sub FileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileOpen.Click
        If Editor.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("File hasn't been saved. Discard changes?", MsgBoxStyle.YesNo, "New Text Requested")
            If reply <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        OpenFileDialog1.DefaultExt = "TXT"
        OpenFileDialog1.Filter = "Text Files|*.TXT|HTML Files|*.HTM|All Files|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        Dim TReader As System.IO.StreamReader
        TReader = New System.IO.StreamReader(OpenFileDialog1.FileName)
        Editor.Text = TReader.ReadToEnd
        TReader.Close()
        TReader = Nothing
        Editor.SelectionStart = 0
        Editor.SelectionLength = 0
        SaveFileName = SaveFileDialog1.FileName
    End Sub


    Private Sub FileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileNew.Click
        If Editor.Modified Then
            Dim reply As Integer
            reply = MsgBox("File hasn't been saved. Erase anyway?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.Yes Then
                Editor.Clear()
            End If
        Else
            Editor.Clear()
        End If
    End Sub

    Private Sub CustomizeTextColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeTextColor.Click

        ColorDialog1.ShowDialog()
        Editor.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub EditSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelect.Click
        Editor.SelectAll()
    End Sub

    Private Sub CustomizePageColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizePageColor.Click
        ColorDialog1.ShowDialog()
        Editor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub CustomizeFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeFont.Click
        FontDialog1.FontMustExist = True
        FontDialog1.ShowDialog()
        Editor.Font = FontDialog1.Font
    End Sub

    Private Sub ProcessNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessNumber.Click
        Dim iLine As Integer
        Dim newText As New System.Text.StringBuilder()
        For iLine = 0 To Editor.Lines.Length - 1
            newText.Append((iLine + 1).ToString & vbTab & Editor.Lines(iLine) & vbCrLf)
        Next
        ' The following operation, which moves the text to the Clipboard
        ' and back to the TextBox control, marks the current operation as an
        ' undoable operation. The Undo command will remove the numbers in front
        ' of the lines, as long as you don't insert or delete any text after the
        ' Number Lines operation.
        ' You can repeat these statements after any operation you want to reverse with
        ' the Edit > Undo command
        Editor.SelectAll()
        Clipboard.SetDataObject(newText.ToString())
        Editor.Paste()
    End Sub

    Private Sub EditPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPaste.Click
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
            Editor.SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text).ToString
        End If
    End Sub

    Private Sub EditFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFind.Click
        frm.searchWord.Text = Editor.SelectedText
        frm.Show()
    End Sub

    Private Sub TextEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBox = Editor
    End Sub

    Private Sub ProcessUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessUpper.Click
        Editor.SelectedText = Editor.SelectedText.ToUpper
    End Sub

    Private Sub ProcessLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessLower.Click
        Editor.SelectedText = Editor.SelectedText.ToLower
    End Sub

    Private Sub EditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCut.Click
        Clipboard.SetDataObject(Editor.SelectedText)
        Editor.SelectedText = ""
    End Sub

    Private Sub FileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExit.Click
        If Editor.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("The current file has been edited. Quit anyway (Y/N)?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Editor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editor.TextChanged
        EditUndo.Text = "Undo"
    End Sub

    Private Sub TextEditor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Editor.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("The current file has been edited. Quit anyway (Y/N)?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class
