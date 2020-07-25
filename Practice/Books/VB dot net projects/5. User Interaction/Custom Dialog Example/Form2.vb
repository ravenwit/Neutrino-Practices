Public Class frmCustomDialogBox
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
    Friend WithEvents txtCustomMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCustomMessage = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCustomMessage
        '
        Me.txtCustomMessage.Location = New System.Drawing.Point(8, 8)
        Me.txtCustomMessage.Multiline = True
        Me.txtCustomMessage.Name = "txtCustomMessage"
        Me.txtCustomMessage.Size = New System.Drawing.Size(280, 225)
        Me.txtCustomMessage.TabIndex = 0
        Me.txtCustomMessage.Text = "Custom message goes here"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(136, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(216, 240)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        '
        'frmCustomDialogBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnOk, Me.btnCancel, Me.txtCustomMessage})
        Me.Name = "frmCustomDialogBox"
        Me.Text = "This is a Custom Box"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
