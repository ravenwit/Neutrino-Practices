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
    Friend WithEvents btnDrawEllipse As System.Windows.Forms.Button
    Friend WithEvents btnClearEllipse As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDrawEllipse = New System.Windows.Forms.Button()
        Me.btnClearEllipse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDrawEllipse
        '
        Me.btnDrawEllipse.Name = "btnDrawEllipse"
        Me.btnDrawEllipse.Size = New System.Drawing.Size(80, 25)
        Me.btnDrawEllipse.TabIndex = 0
        Me.btnDrawEllipse.Text = "Draw Ellipse"
        '
        'btnClearEllipse
        '
        Me.btnClearEllipse.Location = New System.Drawing.Point(280, 0)
        Me.btnClearEllipse.Name = "btnClearEllipse"
        Me.btnClearEllipse.Size = New System.Drawing.Size(80, 25)
        Me.btnClearEllipse.TabIndex = 1
        Me.btnClearEllipse.Text = "Clear Ellipse"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(367, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClearEllipse, Me.btnDrawEllipse})
        Me.Name = "Form1"
        Me.Text = "Procedure Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnDrawEllipse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawEllipse.Click
        Call DrawEllipse(Me)
    End Sub

    Private Sub btnClearEllipse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearEllipse.Click
        Call ClearEllipse(Me)
    End Sub
End Class
