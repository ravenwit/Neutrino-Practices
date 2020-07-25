Imports System.IO
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(160, 325)
        Me.TreeView1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(160, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 325)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(163, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(279, 325)
        Me.ListView1.TabIndex = 2
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 325)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListView1, Me.Splitter1, Me.TreeView1})
        Me.Name = "Form1"
        Me.Text = "File Explorer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add drives to the treeview
        Dim sDrives() As String = System.IO.Directory.GetLogicalDrives()
        Dim sDrive As String
        Dim tvwNode As TreeNode

        For Each sDrive In sDrives
            tvwNode = TreeView1.Nodes.Add(sDrive)
            'add a dummy node
            tvwNode.Nodes.Add("dummy")
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim sFiles() As String = Directory.GetFiles(TreeView1.SelectedNode.FullPath)
        Dim sFile As String
        Dim oItem As ListViewItem

        ListView1.Items.Clear()

        For Each sFile In sFiles
            oItem = ListView1.Items.Add(StripPath(sFile))
            If ListView1.Items.Count > 0 Then
                oItem.SubItems.Add(File.GetLastWriteTime(sFile))
            End If
        Next
    End Sub

    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand

        Dim oNode As TreeNode = CType(e.Node, TreeNode)
        If oNode.Nodes(0).Text = "dummy" Then
            'remove the dummy
            oNode.Nodes(0).Remove()
            'add the real children
            GetChildren(oNode)
        End If
    End Sub
    Private Sub GetChildren(ByVal node As TreeNode)
        Dim sDirs() As String = Directory.GetDirectories(node.FullPath)
        Dim sDir As String
        Dim oNode As TreeNode

        For Each sDir In sDirs
            oNode = node.Nodes.Add(StripPath(sDir))
            'add a dummy node as a child
            oNode.Nodes.Add("dummy")
        Next
    End Sub

    Private Function StripPath(ByVal path As String) As String
        Dim iPos As Integer
        'find the last \ character
        iPos = path.LastIndexOf("\")
        'everything after it is the actual filename
        Return path.Substring(iPos + 1)
    End Function

End Class
