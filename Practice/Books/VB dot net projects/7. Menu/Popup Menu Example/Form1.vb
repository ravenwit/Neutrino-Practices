Public Class Form1
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
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mnuCopy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mnuCopy = New System.Windows.Forms.MenuItem()
        Me.mnuCut = New System.Windows.Forms.MenuItem()
        Me.mnuPaste = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste, Me.mnuDelete})
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenu = Me.ContextMenu1
        Me.TextBox1.Location = New System.Drawing.Point(48, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 48)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'mnuCopy
        '
        Me.mnuCopy.Index = 0
        Me.mnuCopy.Text = "Copy"
        '
        'mnuCut
        '
        Me.mnuCut.Index = 1
        Me.mnuCut.Text = "Cut"
        '
        'mnuPaste
        '
        Me.mnuPaste.Index = 2
        Me.mnuPaste.Text = "Paste"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 3
        Me.mnuDelete.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        Clipboard.SetDataObject(TextBox1.Text)
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        Clipboard.SetDataObject(TextBox1.Text)
        TextBox1.Text = ""

    End Sub

    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        Dim data As IDataObject = Clipboard.GetDataObject()
        If (data.GetDataPresent(DataFormats.Text)) Then
            TextBox1.Text = data.GetData(DataFormats.Text).ToString()
        End If

    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        TextBox1.Text = ""
    End Sub
End Class
