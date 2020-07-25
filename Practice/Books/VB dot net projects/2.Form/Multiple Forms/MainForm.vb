Option Strict On
Public Class MainForm
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
    Friend WithEvents btnDateDialog As System.Windows.Forms.Button
    Friend WithEvents btnTextForm As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDateDialog = New System.Windows.Forms.Button()
        Me.btnTextForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDateDialog
        '
        Me.btnDateDialog.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnDateDialog.Location = New System.Drawing.Point(48, 56)
        Me.btnDateDialog.Name = "btnDateDialog"
        Me.btnDateDialog.Size = New System.Drawing.Size(192, 40)
        Me.btnDateDialog.TabIndex = 0
        Me.btnDateDialog.Text = "Show Date DialogBox"
        '
        'btnTextForm
        '
        Me.btnTextForm.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnTextForm.Location = New System.Drawing.Point(48, 112)
        Me.btnTextForm.Name = "btnTextForm"
        Me.btnTextForm.Size = New System.Drawing.Size(192, 40)
        Me.btnTextForm.TabIndex = 0
        Me.btnTextForm.Text = "Show Text Form"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 205)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnTextForm, Me.btnDateDialog})
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim DLG As New DateDialogBox()
    Dim FRM As New TextBoxForm()

    Private Sub btnDateDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateDialog.Click
        DLG.cmbDay.Text = "4"
        DLG.cmbMonth.Text = "January"
        DLG.cmbYear.Text = "2003"
        DLG.ShowDialog()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTextForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextForm.Click
        FRM.Show()
    End Sub


End Class
