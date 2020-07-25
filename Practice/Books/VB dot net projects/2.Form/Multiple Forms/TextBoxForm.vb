Option Strict On
Public Class TextBoxForm
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
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnInput.Location = New System.Drawing.Point(48, 128)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(168, 40)
        Me.btnInput.TabIndex = 2
        Me.btnInput.Text = "Input in Text Box"
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnRead.Location = New System.Drawing.Point(48, 184)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(176, 40)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "Read From Text Box"
        '
        'TextBoxForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnRead, Me.btnInput, Me.TextBox1})
        Me.Name = "TextBoxForm"
        Me.Text = "Text Box Form"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Me.TextBox1.Text = InputBox("Enter a new value for Text Box")
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim str As String
        str = Me.TextBox1.Text
        MsgBox(str)
    End Sub

    Private Sub TextBoxForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
