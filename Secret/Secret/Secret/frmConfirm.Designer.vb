<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrConfirm = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.pnlUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrConfirm
        '
        '
        'lblPlatinum
        '
        Me.lblPlatinum.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlatinum.Font = New System.Drawing.Font("DS-Terminal", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(742, 77)
        Me.lblPlatinum.TabIndex = 0
        Me.lblPlatinum.Text = "Welcome to Platinum"
        Me.lblPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlUser
        '
        Me.pnlUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUser.Controls.Add(Me.lblPassword)
        Me.pnlUser.Controls.Add(Me.lblUser)
        Me.pnlUser.Controls.Add(Me.txtPassword)
        Me.pnlUser.Controls.Add(Me.txtUser)
        Me.pnlUser.Font = New System.Drawing.Font("Terminus (TTF)", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUser.Location = New System.Drawing.Point(66, 222)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(610, 85)
        Me.pnlUser.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(8, 47)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(219, 19)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Identification Code :"
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(8, 10)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(169, 19)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Identification :"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Location = New System.Drawing.Point(142, 47)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(461, 28)
        Me.txtPassword.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUser.Location = New System.Drawing.Point(142, 10)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(461, 28)
        Me.txtUser.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(332, 134)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(39, 13)
        Me.lblIdentity.TabIndex = 3
        Me.lblIdentity.Text = "Label1"
        '
        'frmConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 348)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.lblPlatinum)
        Me.Name = "frmConfirm"
        Me.Text = "frmConfirm"
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrConfirm As System.Windows.Forms.Timer
    Friend WithEvents lblPlatinum As System.Windows.Forms.Label
    Friend WithEvents pnlUser As System.Windows.Forms.Panel
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lblIdentity As System.Windows.Forms.Label
End Class
