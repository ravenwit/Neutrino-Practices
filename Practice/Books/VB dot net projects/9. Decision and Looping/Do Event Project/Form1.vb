Public Class frmDoEvent
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents btnBeep As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnBeep = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(152, 64)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.TabIndex = 0
        Me.btnCount.Text = "Count"
        '
        'btnBeep
        '
        Me.btnBeep.Location = New System.Drawing.Point(152, 112)
        Me.btnBeep.Name = "btnBeep"
        Me.btnBeep.TabIndex = 1
        Me.btnBeep.Text = "Beep"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(152, 160)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'frmDoEvent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1, Me.btnQuit, Me.btnBeep, Me.btnCount})
        Me.Name = "frmDoEvent"
        Me.Text = "Do Event Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim Number As Object
        TextBox1.Text = ""
        ' Display Number from 1 to 2000
        For Number = 1 To 2000
            TextBox1.Text = Number
            TextBox1().Refresh()
            System.Windows.Forms.Application.DoEvents() ' Respond to Outside events
        Next Number

    End Sub

    Private Sub btnBeep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBeep.Click
        Beep()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
