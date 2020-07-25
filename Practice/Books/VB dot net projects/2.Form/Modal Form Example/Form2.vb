Public Class Form2
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
    Friend WithEvents btnHideMe As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnHideMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHideMe
        '
        Me.btnHideMe.Location = New System.Drawing.Point(96, 120)
        Me.btnHideMe.Name = "btnHideMe"
        Me.btnHideMe.TabIndex = 0
        Me.btnHideMe.Text = "Hide me"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHideMe})
        Me.Name = "Form2"
        Me.Text = "Form Two"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnHideMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideMe.Click
        Me.Hide()
    End Sub
End Class
