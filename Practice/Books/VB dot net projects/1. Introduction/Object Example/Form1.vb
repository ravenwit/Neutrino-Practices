Public Class frmDrawing
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
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(112, 140)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw"
        '
        'frmDrawing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDraw})
        Me.Name = "frmDrawing"
        Me.Text = "Object Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click

        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawLine(System.Drawing.Pens.Black, 0, 0, _
        Me.DisplayRectangle.Width, Me.DisplayRectangle.Height)

        objGraphics.Dispose()
    End Sub
End Class
