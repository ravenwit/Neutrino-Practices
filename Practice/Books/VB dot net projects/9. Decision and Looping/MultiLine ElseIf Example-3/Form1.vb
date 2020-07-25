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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoGray As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoGray = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdoWhite, Me.rdoBlue, Me.rdoGreen, Me.rdoRed, Me.rdoGray})
        Me.GroupBox1.Location = New System.Drawing.Point(0, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdoWhite
        '
        Me.rdoWhite.Location = New System.Drawing.Point(8, 153)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(144, 24)
        Me.rdoWhite.TabIndex = 4
        Me.rdoWhite.Text = "White"
        '
        'rdoBlue
        '
        Me.rdoBlue.Location = New System.Drawing.Point(8, 128)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(144, 16)
        Me.rdoBlue.TabIndex = 3
        Me.rdoBlue.Text = "Blue"
        '
        'rdoGreen
        '
        Me.rdoGreen.Location = New System.Drawing.Point(8, 88)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(144, 24)
        Me.rdoGreen.TabIndex = 2
        Me.rdoGreen.Text = "Green"
        '
        'rdoRed
        '
        Me.rdoRed.Location = New System.Drawing.Point(8, 56)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(144, 24)
        Me.rdoRed.TabIndex = 1
        Me.rdoRed.Text = "Red"
        '
        'rdoGray
        '
        Me.rdoGray.Location = New System.Drawing.Point(8, 24)
        Me.rdoGray.Name = "rdoGray"
        Me.rdoGray.Size = New System.Drawing.Size(144, 24)
        Me.rdoGray.TabIndex = 0
        Me.rdoGray.Text = "Gray"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1})
        Me.Name = "Form1"
        Me.Text = "MultiLine ElseIf Example-3"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub rdoGray_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoGray.Click, rdoRed.Click, rdoGreen.Click, rdoBlue.Click, rdoWhite.Click
        If rdoGray.Checked = True Then
            Me.BackColor = System.Drawing.Color.Gray
        ElseIf rdoRed.Checked = True Then
            Me.BackColor = System.Drawing.Color.Red
        ElseIf rdoGreen.Checked = True Then
            Me.BackColor = System.Drawing.Color.Green
        ElseIf rdoBlue.Checked = True Then
            Me.BackColor = System.Drawing.Color.Blue
        ElseIf rdoWhite.Checked = True Then
            Me.BackColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
