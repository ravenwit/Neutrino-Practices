Public Class frmChild1
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
    Friend WithEvents btnShowChild2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShowChild2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowChild2
        '
        Me.btnShowChild2.Location = New System.Drawing.Point(105, 100)
        Me.btnShowChild2.Name = "btnShowChild2"
        Me.btnShowChild2.Size = New System.Drawing.Size(85, 25)
        Me.btnShowChild2.TabIndex = 0
        Me.btnShowChild2.Text = "Show Child 2"
        '
        'frmChild1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnShowChild2})
        Me.Name = "frmChild1"
        Me.Text = "Child one"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShowChild2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowChild2.Click
        Dim objChild As New frmChild2()
        objChild.MdiParent = Me.MdiParent
        objChild.Show()

    End Sub
End Class
