Public Class frmMessage
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
    Friend WithEvents btnInformation As System.Windows.Forms.Button
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
    Friend WithEvents btnExclemation As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnInformation = New System.Windows.Forms.Button()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnExclemation = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInformation
        '
        Me.btnInformation.Location = New System.Drawing.Point(24, 32)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(72, 23)
        Me.btnInformation.TabIndex = 0
        Me.btnInformation.Text = "Information"
        '
        'btnQuestion
        '
        Me.btnQuestion.Location = New System.Drawing.Point(24, 72)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.TabIndex = 1
        Me.btnQuestion.Text = "Question"
        '
        'btnExclemation
        '
        Me.btnExclemation.Location = New System.Drawing.Point(24, 112)
        Me.btnExclemation.Name = "btnExclemation"
        Me.btnExclemation.TabIndex = 2
        Me.btnExclemation.Text = "Exclamation"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(24, 152)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        '
        'frmMessage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 197)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnStop, Me.btnExclemation, Me.btnQuestion, Me.btnInformation})
        Me.Name = "frmMessage"
        Me.Text = "Defferent Type Message Box"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnIngormation1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformation.Click
        MsgBox("This is an Infirmation box", 64, "Information")


    End Sub

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        MsgBox(" Are you sure you want to do that ?", 32, "Question")
    End Sub

    Private Sub btnExclemation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExclemation.Click
        MsgBox("Keep up the good works ! ", 48, "Exclamation")

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        MsgBox("Stop the Program now. ", 16, "Stop")
    End Sub
End Class
