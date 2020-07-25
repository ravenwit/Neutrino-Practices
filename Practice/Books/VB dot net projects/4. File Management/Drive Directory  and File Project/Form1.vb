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
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents DirListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents FileListBox1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.SuspendLayout()
        '
        'DriveListBox1
        '
        Me.DriveListBox1.Location = New System.Drawing.Point(8, 16)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(121, 21)
        Me.DriveListBox1.TabIndex = 0
        '
        'DirListBox1
        '
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(8, 144)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.TabIndex = 1
        '
        'FileListBox1
        '
        Me.FileListBox1.Location = New System.Drawing.Point(184, 16)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.Size = New System.Drawing.Size(160, 212)
        Me.FileListBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.FileListBox1, Me.DirListBox1, Me.DriveListBox1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DirListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirListBox1.SelectedIndexChanged

        'If Dir List Box1's path changes, Update File List Box1's path
        FileListBox1.Path = DirListBox1.Path

    End Sub

    Private Sub DriveListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        'If Drive List Box l Changes, update Dir List Box `s path
        DirListBox1.Path = DriveListBox1.Drive

    End Sub
End Class
