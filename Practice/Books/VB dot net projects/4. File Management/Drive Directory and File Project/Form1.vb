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
    Friend WithEvents FileListBox1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents btnPrintPath As System.Windows.Forms.Button
    Friend WithEvents btnPrintPattern As System.Windows.Forms.Button
    Friend WithEvents btnPrintListCount As System.Windows.Forms.Button
    Friend WithEvents btnPrintListIndex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.btnPrintPath = New System.Windows.Forms.Button()
        Me.btnPrintPattern = New System.Windows.Forms.Button()
        Me.btnPrintListCount = New System.Windows.Forms.Button()
        Me.btnPrintListIndex = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FileListBox1
        '
        Me.FileListBox1.Location = New System.Drawing.Point(216, 48)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.Size = New System.Drawing.Size(120, 199)
        Me.FileListBox1.TabIndex = 0
        '
        'btnPrintPath
        '
        Me.btnPrintPath.Location = New System.Drawing.Point(0, 8)
        Me.btnPrintPath.Name = "btnPrintPath"
        Me.btnPrintPath.TabIndex = 1
        Me.btnPrintPath.Text = "Prin tPath"
        '
        'btnPrintPattern
        '
        Me.btnPrintPattern.Location = New System.Drawing.Point(80, 8)
        Me.btnPrintPattern.Name = "btnPrintPattern"
        Me.btnPrintPattern.TabIndex = 2
        Me.btnPrintPattern.Text = "Print Pattern"
        '
        'btnPrintListCount
        '
        Me.btnPrintListCount.Location = New System.Drawing.Point(160, 8)
        Me.btnPrintListCount.Name = "btnPrintListCount"
        Me.btnPrintListCount.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintListCount.TabIndex = 3
        Me.btnPrintListCount.Text = "Print List Count"
        '
        'btnPrintListIndex
        '
        Me.btnPrintListIndex.Location = New System.Drawing.Point(272, 8)
        Me.btnPrintListIndex.Name = "btnPrintListIndex"
        Me.btnPrintListIndex.Size = New System.Drawing.Size(88, 23)
        Me.btnPrintListIndex.TabIndex = 4
        Me.btnPrintListIndex.Text = "Print List Index"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrintListIndex, Me.btnPrintListCount, Me.btnPrintPattern, Me.btnPrintPath, Me.FileListBox1})
        Me.Name = "Form1"
        Me.Text = "Drive Directory and File Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnPrintPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPath.Click
        Print(FileListBox1.Path)
    End Sub

    Private Sub btnPrintPattern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPattern.Click
        Print(FileListBox1.Pattern)
    End Sub

    Private Sub btnPrintListCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintListCount.Click
        'Print(FileListBox1.ListCount)
    End Sub

    Private Sub btnPrintListIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintListIndex.Click
        'Print(FileListBox1.ListIndex)
    End Sub
End Class
