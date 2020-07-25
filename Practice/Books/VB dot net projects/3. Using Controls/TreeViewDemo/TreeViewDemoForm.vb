Option Strict On
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnDistict As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMoveTree As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnCity As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnDistict = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCity = New System.Windows.Forms.Button()
        Me.btnMoveTree = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(8, 8)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(240, 232)
        Me.TreeView1.TabIndex = 0
        '
        'btnDistict
        '
        Me.btnDistict.Enabled = False
        Me.btnDistict.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnDistict.Location = New System.Drawing.Point(256, 46)
        Me.btnDistict.Name = "btnDistict"
        Me.btnDistict.Size = New System.Drawing.Size(136, 32)
        Me.btnDistict.TabIndex = 2
        Me.btnDistict.Text = "Add Distict"
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnSort.Location = New System.Drawing.Point(256, 88)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(136, 32)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort Items"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnClear.Location = New System.Drawing.Point(256, 176)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 32)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Control"
        '
        'btnCity
        '
        Me.btnCity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnCity.Location = New System.Drawing.Point(256, 8)
        Me.btnCity.Name = "btnCity"
        Me.btnCity.Size = New System.Drawing.Size(136, 32)
        Me.btnCity.TabIndex = 1
        Me.btnCity.Text = "Add City"
        '
        'btnMoveTree
        '
        Me.btnMoveTree.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnMoveTree.Location = New System.Drawing.Point(256, 136)
        Me.btnMoveTree.Name = "btnMoveTree"
        Me.btnMoveTree.Size = New System.Drawing.Size(136, 32)
        Me.btnMoveTree.TabIndex = 7
        Me.btnMoveTree.Text = "Move Tree"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 261)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnMoveTree, Me.btnClear, Me.btnSort, Me.btnDistict, Me.btnCity, Me.TreeView1})
        Me.Name = "Form1"
        Me.Text = "TreeView Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCity.Click

        TreeView1.Nodes.Add("Dhaka")
        TreeView1.Nodes.Add("Chittagong")
        TreeView1.Nodes.Add("Barisal")
        btnDistict.Enabled = True

    End Sub

    Private Sub btnDistict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistict.Click

        Dim node0, node1, node2 As TreeNode

        node0 = TreeView1.Nodes(0)
        node0.Nodes.Add("Narayangonj")
        node0.Nodes.Add("Manikgonj")

        node1 = TreeView1.Nodes(1)
        node1.Nodes.Add("Noakhali")
        node1.Nodes.Add("Cox Bazar")

        node2 = TreeView1.Nodes(2)
        node2.Nodes.Add("Jhalakati")
        node2.Nodes.Add("Bhola")

        node0.Expand()
        node1.Expand()
        node2.Expand()

    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        TreeView1.Sorted = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TreeView1.Nodes.Clear()
        btnDistict.Enabled = False

    End Sub

    Private Sub btnMoveTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveTree.Click
        Dim DhakaNode, ChittagongNode, BarisalNode As TreeNode
        DhakaNode = TreeView1.Nodes(0)
        ChittagongNode = TreeView1.Nodes(1)
        BarisalNode = TreeView1.Nodes(2)

        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("Items")

        TreeView1.Nodes(0).Nodes.Add(DhakaNode)
        TreeView1.Nodes(0).Nodes.Add(ChittagongNode)
        TreeView1.Nodes(0).Nodes.Add(BarisalNode)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
