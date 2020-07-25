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

    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Private WithEvents ProcessRotateLeft As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessRotateRight As System.Windows.Forms.MenuItem
    Friend WithEvents ZoomIn As System.Windows.Forms.MenuItem
    Friend WithEvents ZoomOut As System.Windows.Forms.MenuItem
    Private WithEvents ZoomAuto As System.Windows.Forms.MenuItem
    Private WithEvents ZoomMenu As System.Windows.Forms.MenuItem
    Private WithEvents ImageExit As System.Windows.Forms.MenuItem
    Private WithEvents ProcessMenu As System.Windows.Forms.MenuItem
    Private WithEvents ImageMenu As System.Windows.Forms.MenuItem
    Private WithEvents ImageLoad As System.Windows.Forms.MenuItem
    Friend WithEvents ZoomNormal As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessFlipVertical As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessFlipHorizontal As System.Windows.Forms.MenuItem

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProcessRotateRight = New System.Windows.Forms.MenuItem()
        Me.ZoomIn = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ZoomMenu = New System.Windows.Forms.MenuItem()
        Me.ZoomAuto = New System.Windows.Forms.MenuItem()
        Me.ZoomNormal = New System.Windows.Forms.MenuItem()
        Me.ZoomOut = New System.Windows.Forms.MenuItem()
        Me.ProcessMenu = New System.Windows.Forms.MenuItem()
        Me.ProcessRotateLeft = New System.Windows.Forms.MenuItem()
        Me.ProcessFlipVertical = New System.Windows.Forms.MenuItem()
        Me.ProcessFlipHorizontal = New System.Windows.Forms.MenuItem()
        Me.ImageExit = New System.Windows.Forms.MenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.ImageMenu = New System.Windows.Forms.MenuItem()
        Me.ImageLoad = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ProcessRotateRight
        '
        Me.ProcessRotateRight.Index = 1
        Me.ProcessRotateRight.Text = "Rotate Right"
        '
        'ZoomIn
        '
        Me.ZoomIn.Index = 2
        Me.ZoomIn.Text = "Zoom In"
        '
        'ZoomMenu
        '
        Me.ZoomMenu.Index = 2
        Me.ZoomMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ZoomAuto, Me.ZoomNormal, Me.ZoomIn, Me.ZoomOut})
        Me.ZoomMenu.Text = "Zoom"
        '
        'ZoomAuto
        '
        Me.ZoomAuto.Index = 0
        Me.ZoomAuto.Text = "Auto"
        '
        'ZoomNormal
        '
        Me.ZoomNormal.Index = 1
        Me.ZoomNormal.Text = "Normal"
        '
        'ZoomOut
        '
        Me.ZoomOut.Index = 3
        Me.ZoomOut.Text = "Zoom Out"
        '
        'ProcessMenu
        '
        Me.ProcessMenu.Index = 1
        Me.ProcessMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ProcessRotateLeft, Me.ProcessRotateRight, Me.ProcessFlipVertical, Me.ProcessFlipHorizontal})
        Me.ProcessMenu.Text = "Process"
        '
        'ProcessRotateLeft
        '
        Me.ProcessRotateLeft.Index = 0
        Me.ProcessRotateLeft.Text = "Rotate Left"
        '
        'ProcessFlipVertical
        '
        Me.ProcessFlipVertical.Index = 2
        Me.ProcessFlipVertical.Text = "Flip Vertical"
        '
        'ProcessFlipHorizontal
        '
        Me.ProcessFlipHorizontal.Index = 3
        Me.ProcessFlipHorizontal.Text = "Flip Horizontal"
        '
        'ImageExit
        '
        Me.ImageExit.Index = 2
        Me.ImageExit.Text = "Exit"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ImageMenu, Me.ProcessMenu, Me.ZoomMenu})
        '
        'ImageMenu
        '
        Me.ImageMenu.Index = 0
        Me.ImageMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ImageLoad, Me.MenuItem4, Me.ImageExit})
        Me.ImageMenu.Text = "Image"
        '
        'ImageLoad
        '
        Me.ImageLoad.Index = 0
        Me.ImageLoad.Text = "Load"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(360, 225)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1})
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Image Load Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ImageLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageLoad.Click
        OpenFileDialog1.Filter = "Images|*.GIF;*.JPG;*.TIF;*.bmp;*.wmf"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            ResizeImage()
        End If
    End Sub

    Private Sub ProcessRotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessRotateRight.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Invalidate()
        Dim tmp As Integer
        tmp = PictureBox1.Width
        PictureBox1.Width = PictureBox1.Height
        PictureBox1.Height = tmp
    End Sub

    Private Sub ZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomIn.Click
        PictureBox1.Width = PictureBox1.Width * 1.25
        PictureBox1.Height = PictureBox1.Height * 1.25
    End Sub

    Private Sub ZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOut.Click
        PictureBox1.Width = PictureBox1.Width / 1.25
        PictureBox1.Height = PictureBox1.Height / 1.25
    End Sub

    Private Overloads Sub ZoomAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomAuto.Click
        ResizeImage()
    End Sub

    Private Sub ProcessRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessRotateLeft.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PictureBox1.Invalidate()
        Dim tmp As Integer
        tmp = PictureBox1.Width
        PictureBox1.Width = PictureBox1.Height
        PictureBox1.Height = tmp
    End Sub


    Private Sub ZoomNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomNormal.Click
        PictureBox1.Width = PictureBox1.Image.Width
        PictureBox1.Height = PictureBox1.Image.Height
    End Sub

    Private Sub ResizeImage()
        PictureBox1.Width = 400
        PictureBox1.Height = 400
        ' The code shown in the text assumes a default image size of 400 x 400 pixels.
        ' The following two statements resize the image so that it nearle fills the
        ' larger of the two dimensions of the form:
        '
        'PictureBox1.Width = Me.Width - 15
        'PictureBox1.Height = Me.Height - SystemInformation.MenuHeight - SystemInformation.CaptionHeight - 15 
        '
        ' the extra 15 pixels we subtract correspond to small padding around the PictureBox control 
        ' Uncomment the last two statements and comment out the statements that
        ' set the dimensions of the PictureBox to 400 pixels and see how the Zoom > Auto command works
        If PictureBox1.Image.Width < PictureBox1.Width And _
              PictureBox1.Image.Height < PictureBox1.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        Else
            Dim ratio As Single
            If PictureBox1.Image.Width > PictureBox1.Image.Height Then
                ratio = PictureBox1.Image.Width / _
                        PictureBox1.Image.Height
                PictureBox1.Height = PictureBox1.Width / ratio
            Else
                ratio = PictureBox1.Image.Height / _
                        PictureBox1.Image.Width
                PictureBox1.Width = PictureBox1.Height / ratio
            End If
        End If
    End Sub

    Private Sub ProcessFlipVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessFlipVertical.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Invalidate()
    End Sub

    Private Sub ProcessFlipHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessFlipHorizontal.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Invalidate()
    End Sub

    Private Sub ImageExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageExit.Click
        End
    End Sub

End Class
