Public Class frmEventsDemo
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
    Friend WithEvents txtEvents As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtEvents = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEvents
        '
        Me.txtEvents.Location = New System.Drawing.Point(48, 120)
        Me.txtEvents.Name = "txtEvents"
        Me.txtEvents.Size = New System.Drawing.Size(133, 20)
        Me.txtEvents.TabIndex = 0
        Me.txtEvents.Text = "Click Me!"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(48, 152)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(192, 16)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEventsDemo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblMessage, Me.txtEvents})
        Me.Name = "frmEventsDemo"
        Me.Text = "Events Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtEvents_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEvents.TextChanged

    End Sub

    Private Sub txtEvents_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEvents.MouseDown
        Select Case e.Button
            Case MouseButtons.Left
                lblMessage.Text = "  You have pressed the left button."
            Case MouseButtons.Middle
                lblMessage.Text = " You have pressed the middle button."
            Case MouseButtons.Right
                lblMessage.Text = " You have pressed the Right button."
        End Select
    End Sub

    Private Sub txtEvents_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEvents.MouseUp
        lblMessage.Text = ""
    End Sub
End Class



