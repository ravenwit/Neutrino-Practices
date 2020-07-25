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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(32, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "BIMAN"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(32, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "BTRC"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(32, 112)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "BIWTC"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(32, 152)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "BIWTA"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 40)
        Me.Label1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.RadioButton4, Me.RadioButton3, Me.RadioButton2, Me.RadioButton1})
        Me.Name = "Form1"
        Me.Text = "Label Control Examples"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "BIMAN stands for  Bangladesh Air Lines"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "BRTC stands for  Bangladesh Road Transport Corporation"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "BIWTC stands for  Bangladesh Inland Water Transport Corporation"
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "BIWTC stands for  Bangladesh Inland Water Transport Authority"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
