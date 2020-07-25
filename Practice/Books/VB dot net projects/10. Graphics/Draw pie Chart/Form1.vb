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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(368, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Draw Pie "
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 325)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim G As System.Drawing.Graphics
        G = Me.CreateGraphics
        Dim Brush As System.Drawing.SolidBrush
        Brush = New System.Drawing.SolidBrush(Color.Green)
        Dim Rect As Rectangle
        Rect = New Rectangle(100, 10, 300, 300)
        Dim Angles() As Single = {0, 40, 80, 125, 170, 260, 360}
        Dim Colors() As Color = {Color.Red, Color.Cornsilk, Color.Firebrick, Color.OliveDrab, Color.LawnGreen, Color.SandyBrown, Color.MidnightBlue}
        G.Clear(Color.Ivory)
        Dim Angle As Integer
        For Angle = 1 To Angles.GetUpperBound(0)
            Brush.Color = Colors(Angle - 1)
            G.FillPie(Brush, Rect, Angles(Angle - 1), Angles(Angle) - Angles(Angle - 1))
        Next
        G.DrawEllipse(Pens.Black, Rect)
    End Sub
End Class
