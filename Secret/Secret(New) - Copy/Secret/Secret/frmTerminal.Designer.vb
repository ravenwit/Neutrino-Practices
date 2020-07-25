<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerminal
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.tmrTerminal = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(837, 462)
        Me.TextBox1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Green
        Me.lblDate.Location = New System.Drawing.Point(39, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(195, 23)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "30-Jan-13 24:59:59 AM"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Green
        Me.lblTime.Location = New System.Drawing.Point(658, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(138, 23)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "24:59:59.1000"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlatinum
        '
        Me.lblPlatinum.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlatinum.Font = New System.Drawing.Font("DS-Terminal", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(837, 77)
        Me.lblPlatinum.TabIndex = 19
        Me.lblPlatinum.Text = "Welcome to Platinum"
        Me.lblPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 462)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPlatinum)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmTerminal"
        Me.Text = "frmTerminal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblPlatinum As System.Windows.Forms.Label
    Friend WithEvents tmrTerminal As System.Windows.Forms.Timer
End Class
