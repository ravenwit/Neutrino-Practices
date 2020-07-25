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
    Friend WithEvents btnEnlarge As System.Windows.Forms.Button
    Friend WithEvents btnShrink As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Location = New System.Drawing.Point(88, 88)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.TabIndex = 0
        Me.btnEnlarge.Text = "Enlarge"
        '
        'btnShrink
        '
        Me.btnShrink.Location = New System.Drawing.Point(88, 136)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.TabIndex = 1
        Me.btnShrink.Text = "Shrink"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 189)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnShrink, Me.btnEnlarge})
        Me.Name = "Form1"
        Me.Text = "Property Example Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnEnlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnlarge.Click
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20

    End Sub

    Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20

    End Sub
End Class
