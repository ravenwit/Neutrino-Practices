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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd1 As System.Windows.Forms.Button
    Friend WithEvents btnAdd2 As System.Windows.Forms.Button
    Friend WithEvents btnRemove1 As System.Windows.Forms.Button
    Friend WithEvents btnRemove2 As System.Windows.Forms.Button
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents btnMove1 As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll2 As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll1 As System.Windows.Forms.Button
    Friend WithEvents btnMove2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnMove1 = New System.Windows.Forms.Button()
        Me.btnMoveAll2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnRemove2 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnMoveAll1 = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnMove2 = New System.Windows.Forms.Button()
        Me.btnRemove1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DisplayMember = "G"
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(8, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(176, 200)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "G"
        '
        'btnMove1
        '
        Me.btnMove1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove1.Location = New System.Drawing.Point(192, 56)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(40, 32)
        Me.btnMove1.TabIndex = 2
        Me.btnMove1.Text = ">"
        '
        'btnMoveAll2
        '
        Me.btnMoveAll2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveAll2.Location = New System.Drawing.Point(192, 176)
        Me.btnMoveAll2.Name = "btnMoveAll2"
        Me.btnMoveAll2.Size = New System.Drawing.Size(40, 32)
        Me.btnMoveAll2.TabIndex = 2
        Me.btnMoveAll2.Text = "<<"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(248, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(176, 200)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Unsorted Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sorted Items"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd1
        '
        Me.btnAdd1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1.Location = New System.Drawing.Point(8, 232)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(176, 32)
        Me.btnAdd1.TabIndex = 3
        Me.btnAdd1.Text = "Add Item to ListBox1"
        '
        'btnRemove2
        '
        Me.btnRemove2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove2.Location = New System.Drawing.Point(248, 264)
        Me.btnRemove2.Name = "btnRemove2"
        Me.btnRemove2.Size = New System.Drawing.Size(176, 32)
        Me.btnRemove2.TabIndex = 3
        Me.btnRemove2.Text = "Remove Selected Item"
        '
        'btnClear2
        '
        Me.btnClear2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear2.Location = New System.Drawing.Point(248, 296)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(176, 32)
        Me.btnClear2.TabIndex = 3
        Me.btnClear2.Text = "Clear ListBox2"
        '
        'btnClear1
        '
        Me.btnClear1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear1.Location = New System.Drawing.Point(8, 296)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(176, 32)
        Me.btnClear1.TabIndex = 3
        Me.btnClear1.Text = "Clear ListBox1"
        '
        'btnMoveAll1
        '
        Me.btnMoveAll1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveAll1.Location = New System.Drawing.Point(192, 136)
        Me.btnMoveAll1.Name = "btnMoveAll1"
        Me.btnMoveAll1.Size = New System.Drawing.Size(40, 32)
        Me.btnMoveAll1.TabIndex = 2
        Me.btnMoveAll1.Text = ">>"
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Location = New System.Drawing.Point(248, 232)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(176, 32)
        Me.btnAdd2.TabIndex = 3
        Me.btnAdd2.Text = "Add Item to ListBox2"
        '
        'btnMove2
        '
        Me.btnMove2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove2.Location = New System.Drawing.Point(192, 96)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(40, 32)
        Me.btnMove2.TabIndex = 2
        Me.btnMove2.Text = "<"
        '
        'btnRemove1
        '
        Me.btnRemove1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove1.Location = New System.Drawing.Point(8, 264)
        Me.btnRemove1.Name = "btnRemove1"
        Me.btnRemove1.Size = New System.Drawing.Size(176, 32)
        Me.btnRemove1.TabIndex = 3
        Me.btnRemove1.Text = "Remove Selected Items"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.btnRemove2, Me.btnRemove1, Me.btnClear2, Me.btnClear1, Me.btnAdd2, Me.btnAdd1, Me.btnMoveAll2, Me.btnMove2, Me.btnMove1, Me.btnMoveAll1, Me.ListBox2, Me.ListBox1})
        Me.Name = "Form1"
        Me.Text = "List Box Demo Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        Dim ListItem As String
        ListItem = InputBox("Enter new item's name")
        If ListItem.Trim <> "" Then
            ListBox2.Items.Add(ListItem)
        End If
    End Sub

    Private Sub btnAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        Dim ListItem As String
        ListItem = InputBox("Enter new item's name")
        If ListItem.Trim <> "" Then
            ListBox1.Items.Add(ListItem)
        End If
    End Sub

    Private Sub btnRemove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove2.Click
        If ListBox2.SelectedItems.Count > 0 Then
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub btnRemove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove1.Click
        Dim i As Integer
        For i = 0 To ListBox1.SelectedIndices.Count - 1
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices(0))
        Next
    End Sub

    Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
        If ListBox2.SelectedItems.Count > 0 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub btnMoveAll2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll1.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(0))
            ListBox1.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
        Dim i As Integer
        For i = 0 To ListBox1.SelectedIndices.Count - 1
            ListBox2.Items.Add(ListBox1.Items(ListBox1.SelectedIndices(0)))
            ListBox1.Items.Remove(ListBox1.Items(ListBox1.SelectedIndices(0)))
        Next
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnClear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear2.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub btnMoveAll1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll2.Click
        Dim i As Integer
        For i = 0 To ListBox2.Items.Count - 1
            ListBox1.Items.Add(ListBox2.Items(0))
            ListBox2.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
