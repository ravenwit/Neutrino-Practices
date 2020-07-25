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
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnWhite As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnWhite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRed.Location = New System.Drawing.Point(208, 48)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGreen.Location = New System.Drawing.Point(208, 96)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.TabIndex = 1
        Me.btnGreen.Text = "Green"
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBlue.Location = New System.Drawing.Point(208, 136)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.TabIndex = 2
        Me.btnBlue.Text = "Blue"
        '
        'btnWhite
        '
        Me.btnWhite.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnWhite.Location = New System.Drawing.Point(208, 184)
        Me.btnWhite.Name = "btnWhite"
        Me.btnWhite.TabIndex = 3
        Me.btnWhite.Text = "White"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 245)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnWhite, Me.btnBlue, Me.btnGreen, Me.btnRed})
        Me.Name = "Form1"
        Me.Text = "Background Color project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        Me.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub btnGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreen.Click
        Me.BackColor = System.Drawing.Color.Green
    End Sub

    Private Sub btnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlue.Click
        Me.BackColor = System.Drawing.Color.Blue
    End Sub

    Private Sub btnWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhite.Click
        Me.BackColor = System.Drawing.Color.White
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
