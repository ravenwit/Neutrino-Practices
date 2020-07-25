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
    Friend WithEvents tbrMainToolbar As System.Windows.Forms.ToolBar
    Friend WithEvents ImgMyPicture As System.Windows.Forms.ImageList
    Friend WithEvents tbbQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbInvisible As System.Windows.Forms.ToolBarButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.tbrMainToolbar = New System.Windows.Forms.ToolBar()
        Me.tbbQuit = New System.Windows.Forms.ToolBarButton()
        Me.tbbInvisible = New System.Windows.Forms.ToolBarButton()
        Me.ImgMyPicture = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.SuspendLayout()
        '
        'tbrMainToolbar
        '
        Me.tbrMainToolbar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbQuit, Me.tbbInvisible})
        Me.tbrMainToolbar.DropDownArrows = True
        Me.tbrMainToolbar.ImageList = Me.ImgMyPicture
        Me.tbrMainToolbar.Name = "tbrMainToolbar"
        Me.tbrMainToolbar.ShowToolTips = True
        Me.tbrMainToolbar.Size = New System.Drawing.Size(292, 25)
        Me.tbrMainToolbar.TabIndex = 0
        Me.tbrMainToolbar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'tbbQuit
        '
        Me.tbbQuit.ImageIndex = 0
        Me.tbbQuit.Text = "Quit"
        Me.tbbQuit.ToolTipText = "Quit this application"
        '
        'tbbInvisible
        '
        Me.tbbInvisible.ImageIndex = 1
        Me.tbbInvisible.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.tbbInvisible.Text = "Invisible"
        '
        'ImgMyPicture
        '
        Me.ImgMyPicture.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgMyPicture.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgMyPicture.ImageStream = CType(resources.GetObject("ImgMyPicture.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgMyPicture.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 231)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(292, 22)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "Toolbar example"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.StatusBar1, Me.TextBox1, Me.tbrMainToolbar})
        Me.Name = "Form1"
        Me.Text = "Toolbar Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tbrMainToolbar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbrMainToolbar.ButtonClick
        Select Case tbrMainToolbar.Buttons.IndexOf(e.Button)
            Case Is = 0
                Me.Close()
            Case Is = 1
                TextBox1.Visible = Not (tbbInvisible.Pushed)
        End Select
    End Sub
End Class
