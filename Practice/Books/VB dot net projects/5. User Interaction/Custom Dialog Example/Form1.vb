Public Class frmMain
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
    Friend WithEvents btnShowCustomDialogBox As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShowCustomDialogBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowCustomDialogBox
        '
        Me.btnShowCustomDialogBox.Location = New System.Drawing.Point(72, 180)
        Me.btnShowCustomDialogBox.Name = "btnShowCustomDialogBox"
        Me.btnShowCustomDialogBox.Size = New System.Drawing.Size(152, 23)
        Me.btnShowCustomDialogBox.TabIndex = 0
        Me.btnShowCustomDialogBox.Text = "Show Custom Dialog Box"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnShowCustomDialogBox})
        Me.Name = "frmMain"
        Me.Text = "Custom Dialog Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShowCustomDialogBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCustomDialogBox.Click
        Dim objCustomDialogBox As New frmCustomDialogBox()
        If objCustomDialogBox.ShowDialog = DialogResult.OK Then
            MsgBox("You Click Ok")
        Else
            MsgBox("You Click Cancel")
        End If
        objCustomDialogBox = Nothing
    End Sub
End Class
