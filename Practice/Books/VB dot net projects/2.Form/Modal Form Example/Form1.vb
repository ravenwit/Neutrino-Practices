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
    Friend WithEvents btnShowForm2 As System.Windows.Forms.Button
    Friend WithEvents btnHideForm2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShowForm2 = New System.Windows.Forms.Button()
        Me.btnHideForm2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowForm2
        '
        Me.btnShowForm2.Location = New System.Drawing.Point(88, 64)
        Me.btnShowForm2.Name = "btnShowForm2"
        Me.btnShowForm2.TabIndex = 0
        Me.btnShowForm2.Text = "Show Form2"
        '
        'btnHideForm2
        '
        Me.btnHideForm2.Location = New System.Drawing.Point(88, 104)
        Me.btnHideForm2.Name = "btnHideForm2"
        Me.btnHideForm2.TabIndex = 1
        Me.btnHideForm2.Text = "Hide Form2"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(88, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 237)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnHideForm2, Me.btnShowForm2})
        Me.Name = "Form1"
        Me.Text = "Demonstrate a Modal Form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShowForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowForm2.Click
        Dim ModalTestForm As New Form2()
        ModalTestForm.ShowDialog()

    End Sub

    Private Sub btnHideForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideForm2.Click
        Dim ModalTestForm As New Form2()
        ModalTestForm.Hide()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
