<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormController
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
        Me.tmrSecret = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMsg = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmrLogin = New System.Windows.Forms.Timer(Me.components)
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblSecret = New System.Windows.Forms.Label()
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tmrSecret
        '
        '
        'tmrMsg
        '
        Me.tmrMsg.Enabled = True
        Me.tmrMsg.Interval = 80
        '
        'tmrDraw
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'tmrLogin
        '
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(224, 181)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(101, 13)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Identification Code :"
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(224, 144)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 13)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "Identification :"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Location = New System.Drawing.Point(354, 178)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(289, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUser.Location = New System.Drawing.Point(354, 141)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(289, 20)
        Me.txtUser.TabIndex = 1
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(463, 155)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(39, 13)
        Me.lblIdentity.TabIndex = 23
        Me.lblIdentity.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Green
        Me.lblDate.Location = New System.Drawing.Point(24, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(195, 23)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "30-Jan-13 24:59:59 AM"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Green
        Me.lblTime.Location = New System.Drawing.Point(754, 32)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(138, 23)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "24:59:59.1000"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecret
        '
        Me.lblSecret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSecret.Font = New System.Drawing.Font("Terminus (TTF)", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecret.Location = New System.Drawing.Point(0, 77)
        Me.lblSecret.Name = "lblSecret"
        Me.lblSecret.Size = New System.Drawing.Size(950, 332)
        Me.lblSecret.TabIndex = 16
        Me.lblSecret.Text = "Label1"
        Me.lblSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlatinum
        '
        Me.lblPlatinum.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlatinum.Font = New System.Drawing.Font("DS-Terminal", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(950, 77)
        Me.lblPlatinum.TabIndex = 15
        Me.lblPlatinum.Text = "Welcome to Platinum"
        Me.lblPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(850, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 13)
        Me.TextBox1.TabIndex = 24
        '
        'FormController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 409)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSecret)
        Me.Controls.Add(Me.lblPlatinum)
        Me.Name = "FormController"
        Me.Text = "FormController"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrSecret As System.Windows.Forms.Timer
    Friend WithEvents tmrMsg As System.Windows.Forms.Timer
    Friend WithEvents tmrDraw As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tmrLogin As System.Windows.Forms.Timer
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblIdentity As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblSecret As System.Windows.Forms.Label
    Friend WithEvents lblPlatinum As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
