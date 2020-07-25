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
    Friend WithEvents ChkRed As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGreen As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBlue As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ChkRed = New System.Windows.Forms.CheckBox()
        Me.ChkGreen = New System.Windows.Forms.CheckBox()
        Me.ChkBlue = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChkRed
        '
        Me.ChkRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRed.Location = New System.Drawing.Point(8, 51)
        Me.ChkRed.Name = "ChkRed"
        Me.ChkRed.TabIndex = 0
        Me.ChkRed.Text = "Red"
        '
        'ChkGreen
        '
        Me.ChkGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGreen.Location = New System.Drawing.Point(9, 81)
        Me.ChkGreen.Name = "ChkGreen"
        Me.ChkGreen.TabIndex = 1
        Me.ChkGreen.Text = "Green"
        '
        'ChkBlue
        '
        Me.ChkBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBlue.Location = New System.Drawing.Point(8, 113)
        Me.ChkBlue.Name = "ChkBlue"
        Me.ChkBlue.TabIndex = 2
        Me.ChkBlue.Text = "Blue"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Set Form Back Color"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(25, Byte), CType(25, Byte))
        Me.ClientSize = New System.Drawing.Size(336, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.ChkBlue, Me.ChkGreen, Me.ChkRed})
        Me.Name = "Form1"
        Me.Text = "CheckBox Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ColorRed As Object, ColorGreen As Object, ColorBlue As Integer
        If ChkRed.CheckState = CheckState.Checked Then
            ColorRed = 255
        Else
            ColorRed = 0
        End If
        If ChkGreen.CheckState = CheckState.Checked Then
            ColorGreen = 255
        Else
            ColorGreen = 0
        End If

        If ChkBlue.CheckState = CheckState.Checked Then
            ColorBlue = 255
        Else
            ColorBlue = 0
        End If

        Me.BackColor = Color.FromArgb(ColorRed, ColorGreen, ColorBlue)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
