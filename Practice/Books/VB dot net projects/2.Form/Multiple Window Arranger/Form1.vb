Public Class MdiParent
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindowJorizontal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindowVertical As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindowCascade As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindowArrange As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuWindow = New System.Windows.Forms.MenuItem()
        Me.mnuWindowJorizontal = New System.Windows.Forms.MenuItem()
        Me.mnuWindowVertical = New System.Windows.Forms.MenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.MenuItem()
        Me.mnuWindowArrange = New System.Windows.Forms.MenuItem()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Graphics files|*.gif;*.bmp;*.jpg|All files|*.*"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuWindow})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.mnuFileExit})
        Me.mnuFile.Text = "File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 0
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 1
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuWindow
        '
        Me.mnuWindow.Index = 1
        Me.mnuWindow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWindowJorizontal, Me.mnuWindowVertical, Me.mnuWindowCascade, Me.mnuWindowArrange})
        Me.mnuWindow.Text = "Window"
        '
        'mnuWindowJorizontal
        '
        Me.mnuWindowJorizontal.Index = 0
        Me.mnuWindowJorizontal.Text = "Tile Horizpntally"
        '
        'mnuWindowVertical
        '
        Me.mnuWindowVertical.Index = 1
        Me.mnuWindowVertical.Text = "Tile Vertically"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Index = 2
        Me.mnuWindowCascade.Text = "Cascade"
        '
        'mnuWindowArrange
        '
        Me.mnuWindowArrange.Index = 3
        Me.mnuWindowArrange.Text = "Arrange Icon"
        '
        'MdiParent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 303)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MdiParent"
        Me.Text = "Multiple Form Arranger"

    End Sub

#End Region


    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim oForm As New frmView()
            oForm.MdiParent = Me
            oForm.Picture = Image.FromFile(OpenFileDialog1.FileName)
            oForm.Show()
        End If
    End Sub

    Private Sub mnuWindowHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowJorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWindowCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowArrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowArrange.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub mnuFileExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
End Class
