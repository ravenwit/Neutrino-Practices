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
    Friend WithEvents txtInputForLength As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtInputForLength = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Compute Length"
        '
        'txtInputForLength
        '
        Me.txtInputForLength.Location = New System.Drawing.Point(32, 48)
        Me.txtInputForLength.Name = "txtInputForLength"
        Me.txtInputForLength.Size = New System.Drawing.Size(200, 20)
        Me.txtInputForLength.TabIndex = 1
        Me.txtInputForLength.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 205)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtInputForLength, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Function Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intLength As Integer
        intLength = ComputeLength(txtInputForLength().Text)
        MsgBox(" Length is :" & intLength)


    End Sub
    Public Function ComputeLength(ByVal strText As String) As Integer
        ComputeLength = Len(strText)
    End Function

End Class
