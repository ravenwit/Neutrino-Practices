Public Class FindForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchWord As System.Windows.Forms.TextBox
    Friend WithEvents replaceWord As System.Windows.Forms.TextBox
    Friend WithEvents chkCase As System.Windows.Forms.CheckBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.chkCase = New System.Windows.Forms.CheckBox()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.searchWord = New System.Windows.Forms.TextBox()
        Me.replaceWord = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnReplace
        '
        Me.btnReplace.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnReplace.Location = New System.Drawing.Point(256, 64)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(96, 32)
        Me.btnReplace.TabIndex = 7
        Me.btnReplace.Text = "Replace"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search For"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Replace With"
        '
        'btnFindNext
        '
        Me.btnFindNext.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnFindNext.Location = New System.Drawing.Point(360, 16)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(96, 32)
        Me.btnFindNext.TabIndex = 6
        Me.btnFindNext.Text = "Find Next"
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnFind.Location = New System.Drawing.Point(256, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(96, 32)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find"
        '
        'chkCase
        '
        Me.chkCase.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkCase.Location = New System.Drawing.Point(8, 96)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(160, 16)
        Me.chkCase.TabIndex = 4
        Me.chkCase.Text = "Case Sensitive"
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnReplaceAll.Location = New System.Drawing.Point(360, 64)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(96, 32)
        Me.btnReplaceAll.TabIndex = 8
        Me.btnReplaceAll.Text = "Replace All"
        '
        'searchWord
        '
        Me.searchWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.searchWord.Location = New System.Drawing.Point(8, 24)
        Me.searchWord.Name = "searchWord"
        Me.searchWord.Size = New System.Drawing.Size(240, 22)
        Me.searchWord.TabIndex = 1
        Me.searchWord.Text = ""
        '
        'replaceWord
        '
        Me.replaceWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.replaceWord.Location = New System.Drawing.Point(8, 72)
        Me.replaceWord.Name = "replaceWord"
        Me.replaceWord.Size = New System.Drawing.Size(240, 22)
        Me.replaceWord.TabIndex = 3
        Me.replaceWord.Text = ""
        '
        'FindForm
        '
        Me.AcceptButton = Me.btnFindNext
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 117)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.replaceWord, Me.chkCase, Me.btnReplaceAll, Me.btnReplace, Me.btnFindNext, Me.btnFind, Me.searchWord})
        Me.Name = "FindForm"
        Me.Text = "Find & Replace"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bttnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        Dim curPos, curSel As Integer
        curPos = TextEditor.txtBox.SelectionStart
        curSel = TextEditor.txtBox.SelectionLength
        TextEditor.txtBox.Text = Replace(TextEditor.txtBox.Text, Trim(searchWord.Text), Trim(replaceWord.Text))
        TextEditor.txtBox.SelectionStart = curPos
        TextEditor.txtBox.SelectionLength = curSel
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim selStart As Integer
        Dim srchMode As Microsoft.VisualBasic.CompareMethod

        If chkCase.Checked = True Then
            srchMode = CompareMethod.Binary
        Else
            srchMode = CompareMethod.Text
        End If
        selStart = InStr(TextEditor.txtBox.Text, searchWord.Text, srchMode)
        If selStart = 0 Then
            MsgBox("Can't find word")
            Exit Sub
        End If
        TextEditor.txtBox.Select(selStart - 1, searchWord.Text.Length)
        btnFindNext.Enabled = True
        btnReplace.Enabled = True
        btnReplaceAll.Enabled = True
        TextEditor.txtBox.ScrollToCaret()
    End Sub

    Private Sub searchWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchWord.TextChanged
        If searchWord.Text.Length > 0 Then
            btnFind.Enabled = True
            btnFindNext.Enabled = True
        Else
            btnFind.Enabled = False
            btnFindNext.Enabled = False
        End If
        If replaceWord.Text.Length > 0 Then
            btnReplace.Enabled = True
            btnReplaceAll.Enabled = True
        Else
            btnReplace.Enabled = False
            btnReplaceAll.Enabled = False
        End If

    End Sub

    Private Sub bttnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        Dim selStart As Integer
        Dim srchMode As Microsoft.VisualBasic.CompareMethod

        If chkCase.Checked = True Then
            srchMode = Microsoft.VisualBasic.CompareMethod.Binary
        Else
            srchMode = Microsoft.VisualBasic.CompareMethod.Text
        End If
        selStart = InStr(TextEditor.txtBox.SelectionStart + 2, TextEditor.txtBox.Text, searchWord.Text, srchMode)
        If selStart = 0 Then
            MsgBox("No more matches")
            Exit Sub
        End If
        TextEditor.txtBox.Select(selStart - 1, searchWord.Text.Length)
        TextEditor.txtBox.ScrollToCaret()
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        searchWord_TextChanged(sender, e)
    End Sub

    Private Sub bttnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        If TextEditor.txtBox.SelectedText <> "" Then
            TextEditor.txtBox.SelectedText = replaceWord.Text
        End If
        bttnFindNext_Click(sender, e)
    End Sub

    Private Sub replaceWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles replaceWord.TextChanged
        If replaceWord.Text.Length > 0 Then
            btnReplace.Enabled = True
            btnReplaceAll.Enabled = True
        Else
            btnReplace.Enabled = False
            btnReplaceAll.Enabled = False
        End If
    End Sub
End Class
