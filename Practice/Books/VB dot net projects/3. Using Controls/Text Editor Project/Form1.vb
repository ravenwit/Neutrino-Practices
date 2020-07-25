Public Class TextTextBox1
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnUpper As System.Windows.Forms.Button
    Friend WithEvents btnLower As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnUpper = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TextBox1.Location = New System.Drawing.Point(0, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(568, 304)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(50, 23)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOpen.Location = New System.Drawing.Point(56, 0)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(50, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Location = New System.Drawing.Point(112, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCopy.Location = New System.Drawing.Point(168, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(50, 23)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy"
        '
        'btnCut
        '
        Me.btnCut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCut.Location = New System.Drawing.Point(224, 0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(50, 23)
        Me.btnCut.TabIndex = 5
        Me.btnCut.Text = "Cut"
        '
        'btnPaste
        '
        Me.btnPaste.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPaste.Location = New System.Drawing.Point(280, 0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(50, 23)
        Me.btnPaste.TabIndex = 6
        Me.btnPaste.Text = "Paste"
        '
        'btnUpper
        '
        Me.btnUpper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpper.Location = New System.Drawing.Point(336, 0)
        Me.btnUpper.Name = "btnUpper"
        Me.btnUpper.Size = New System.Drawing.Size(50, 23)
        Me.btnUpper.TabIndex = 7
        Me.btnUpper.Text = "Upper"
        '
        'btnLower
        '
        Me.btnLower.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLower.Location = New System.Drawing.Point(400, 0)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(50, 23)
        Me.btnLower.TabIndex = 8
        Me.btnLower.Text = "Lower"
        '
        'btnFont
        '
        Me.btnFont.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFont.Location = New System.Drawing.Point(456, 0)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(50, 23)
        Me.btnFont.TabIndex = 9
        Me.btnFont.Text = "Font"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Location = New System.Drawing.Point(512, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'FontDialog1
        '
        Me.FontDialog1.FontMustExist = True
        '
        'TextTextBox1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(568, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnFont, Me.btnLower, Me.btnUpper, Me.btnPaste, Me.btnCut, Me.btnCopy, Me.btnSave, Me.btnOpen, Me.btnNew, Me.TextBox1})
        Me.Name = "TextTextBox1"
        Me.Text = "Text Editor Project"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim SaveFileName As String

    Public Shared txtBox As TextBox

    Private Sub btnLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLower.Click
        TextBox1.SelectedText = TextBox1.SelectedText.ToLower
    End Sub

    Private Sub btnUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpper.Click
        TextBox1.SelectedText = TextBox1.SelectedText.ToUpper
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Clipboard.SetDataObject(TextBox1.SelectedText)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If TextBox1.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("File hasn't been saved. Discard changes?", MsgBoxStyle.YesNo)
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

        TextBox1.Text = TReader.ReadToEnd
        TReader.Close()
        TReader = Nothing

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If TextBox1.Modified Then
            Dim reply As Integer
            reply = MsgBox("File hasn't been saved. Erase anyway?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.Yes Then
                TextBox1.Clear()
            End If
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextTextBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click
        Clipboard.SetDataObject(TextBox1.SelectedText)
        TextBox1.SelectedText = ""
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
            TextBox1.SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text).ToString
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileDialog1.DefaultExt = "TXT"
        SaveFileDialog1.Filter = "Text Files|*.TXT|HTML Files|*.HTM|All Files|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then Exit Sub

        Dim tWriter As System.IO.StreamWriter
        tWriter = New System.IO.StreamWriter(SaveFileDialog1.FileName)
        tWriter.Write(TextBox1.Text)

        tWriter.Close()
        tWriter = Nothing
        SaveFileName = SaveFileDialog1.FileName
    End Sub

End Class
