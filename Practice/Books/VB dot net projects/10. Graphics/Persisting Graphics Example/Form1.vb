Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private m_objDrawingSurface As Bitmap
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
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnDrawText As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnDrawText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(40, 185)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(110, 20)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = ""
        '
        'btnDrawText
        '
        Me.btnDrawText.Location = New System.Drawing.Point(192, 185)
        Me.btnDrawText.Name = "btnDrawText"
        Me.btnDrawText.TabIndex = 1
        Me.btnDrawText.Text = "Draw Text"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 261)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDrawText, Me.txtInput})
        Me.Name = "frmMain"
        Me.Text = "Persisting Graphis Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        m_objDrawingSurface = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height, _
        Drawing.Imaging.PixelFormat.Format24bppRgb)
        Call InitializeSurface()

    End Sub
    Private Sub InitializeSurface()
        Dim ObjGraphics As Graphics
        Dim recBounds As Rectangle
        'Create a graphics object that reference that bitmap and clear it.

        ObjGraphics = Graphics.FromImage(m_objDrawingSurface)
        ObjGraphics.Clear(System.Drawing.SystemColors.Control)
        'Create Rectangle the same size of the bitmap.
        recBounds = New Rectangle(0, 0, m_objDrawingSurface.Width, _
        m_objDrawingSurface.Height)
        ' Reduce the Rectangle Slightly so the ellipse will not appear on the border.
        recBounds.Inflate(-1, -1)
        'Draw Ellipse that fill the form.
        ObjGraphics.DrawEllipse(System.Drawing.Pens.Orange, recBounds)
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim ObjGraphics As Graphics
        ' You can not modify e. graphics directly
        ObjGraphics = e.Graphics
        ' Draw Contents of the bitmap on the Form
        ObjGraphics.DrawImage(m_objDrawingSurface, 0, 0, _
        m_objDrawingSurface.Width, m_objDrawingSurface.Height)

    End Sub

    Private Sub btnDrawText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawText.Click
        Dim ObjGraphics As Graphics
        Dim ObjFont As Font
        Dim IntFontSize As Integer
        Dim intTextX As Integer
        Dim intTextY As Integer

        ' If not text has been entered
        If txtInput.Text = "" Then Exit Sub

        'Create Graphics Object using the memory bitmap.
        ObjGraphics = Graphics.FromImage(m_objDrawingSurface)
        'Create a random number for the font size, keep it between 8 and 48.
        IntFontSize = Int((48 - 8 + 1) * Rnd() + 8)

        'Create Random number for X cordinate for the text.

        intTextX = Int(((Me.ClientRectangle.Width - 20) - 0 + 1) * Rnd() + 0)
        'Create Random number for Y cordinate for the text.
        intTextY = Int(((Me.ClientRectangle.Height - 20) - 0 + 1) * Rnd() + 0)

        'Create New Font Object.
        ObjFont = New System.Drawing.Font("Arial", IntFontSize, _
        FontStyle.Bold Or FontStyle.Italic)

        'Draw the users Text
        ObjGraphics.DrawString(txtInput.Text, ObjFont, _
        System.Drawing.Brushes.Red, intTextX, intTextY)
        ' Clean up.
        ObjGraphics.Dispose()
        ' Force the Form to paint itself. This triggers the paint event.
        Me.Invalidate()

    End Sub
End Class
