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
    Friend WithEvents btnPerformDivision As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPerformDivision = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPerformDivision
        '
        Me.btnPerformDivision.Location = New System.Drawing.Point(95, 145)
        Me.btnPerformDivision.Name = "btnPerformDivision"
        Me.btnPerformDivision.Size = New System.Drawing.Size(105, 25)
        Me.btnPerformDivision.TabIndex = 0
        Me.btnPerformDivision.Text = "Perform Division"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(90, 115)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(120, 20)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 245)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtInput, Me.btnPerformDivision})
        Me.Name = "Form1"
        Me.Text = "Debugging Examples"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnPerformDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformDivision.Click

        'This procedures divides 100 by the value inputed
        ' in the textBox

        Dim IngAnswer As Long
        IngAnswer = 100 / CLng(txtInput.Text)
        MsgBox("100 /" & txtInput.Text & " is " & IngAnswer)


    End Sub
End Class
